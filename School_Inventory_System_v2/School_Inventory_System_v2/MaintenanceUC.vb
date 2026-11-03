
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Public Class MaintenanceUC

    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Class MaintenanceRow
        Public Property MaintenanceID As Integer
        Public Property ItemID As Integer
        Public Property ItemName As String
        Public Property Problem As String
        Public Property DateReported As DateTime
        Public Property AssignedStaff As String
        Public Property Status As String
        Public Property IsAvailableToReport As Boolean
    End Class

    Private SelectedMaintenanceID As Integer = 0
    Private SelectedItemID As Integer = 0
    Private SelectedStatus As String = ""

    Private Function CanManageMaintenance() As Boolean
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Return role = "admin" OrElse role = "maintenance personnel"
    End Function

    Private Sub ApplyRolePermissions()
        Dim canManage As Boolean = CanManageMaintenance()

        ClearBTN.Enabled = canManage
        ProblemTXT.Enabled = canManage
        DateReportedDTP.Enabled = canManage
        AssignedStaffCMB.Enabled = canManage
        RmTXT.Enabled = canManage
        RepairCostTXT.Enabled = canManage
        ItemConditionCMB.Enabled = canManage

        SearchItemsTXT.Enabled = True
        MaintenanceLV.Enabled = True
        ItemTXT.ReadOnly = True
    End Sub

    Private Sub MaintenanceUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadStaff()

        ItemConditionCMB.Items.Clear()
        ItemConditionCMB.Items.AddRange(New Object() {"Good", "Beyond Repair"})
        ItemConditionCMB.SelectedIndex = 0

        ItemTXT.ReadOnly = True
        ItemPB.SizeMode = PictureBoxSizeMode.Zoom
        ItemPB.BorderStyle = BorderStyle.FixedSingle

        DateReportedDTP.Value = Date.Today
        ClearFields()
        LoadMaintenanceRecords("")

        StatusLBL.TextAlign = ContentAlignment.MiddleRight
        ApplyRolePermissions()
    End Sub

    Private Sub SetupListView()
        MaintenanceLV.View = View.Details
        MaintenanceLV.FullRowSelect = True
        MaintenanceLV.GridLines = True
        MaintenanceLV.MultiSelect = False
        MaintenanceLV.HideSelection = False
        MaintenanceLV.Columns.Clear()
        MaintenanceLV.Columns.Add("Maintenance ID", 105)
        MaintenanceLV.Columns.Add("Item Name", 160)
        MaintenanceLV.Columns.Add("Date Reported", 110)
        MaintenanceLV.Columns.Add("Problem", 190)
        MaintenanceLV.Columns.Add("Assigned Staff", 150)
        MaintenanceLV.Columns.Add("Status", 115)
    End Sub

    Private Sub LoadStaff()
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Dim sql As String = "SELECT User_ID, FullName FROM users WHERE Status='Active' ORDER BY FullName"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        AssignedStaffCMB.DataSource = Nothing
                        AssignedStaffCMB.Items.Clear()
                        AssignedStaffCMB.DataSource = dt
                        AssignedStaffCMB.DisplayMember = "FullName"
                        AssignedStaffCMB.ValueMember = "User_ID"
                        AssignedStaffCMB.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load staff: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMaintenanceRecords(searchText As String)
        MaintenanceLV.Items.Clear()

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                LoadAvailableDamagedItems(conn, searchText)

                Dim sql As String = "SELECT m.MaintenanceID, m.ItemID, i.ItemName, m.Problem, m.DateReported, COALESCE(u.FullName,'Unassigned') AS AssignedStaff, m.Status FROM maintenance m INNER JOIN inventory i ON m.ItemID=i.ItemID LEFT JOIN users u ON m.AssignedUserID=u.User_ID WHERE i.ItemName LIKE @search OR m.Problem LIKE @search OR CAST(m.MaintenanceID AS CHAR) LIKE @search OR m.Status LIKE @search ORDER BY CASE m.Status WHEN 'Pending' THEN 1 WHEN 'In Progress' THEN 2 WHEN 'Completed' THEN 3 WHEN 'Beyond Repair' THEN 4 ELSE 5 END, m.MaintenanceID DESC"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim record As New MaintenanceRow With {
                                .MaintenanceID = Convert.ToInt32(reader("MaintenanceID")),
                                .ItemID = Convert.ToInt32(reader("ItemID")),
                                .ItemName = reader("ItemName").ToString(),
                                .Problem = reader("Problem").ToString(),
                                .DateReported = Convert.ToDateTime(reader("DateReported")),
                                .AssignedStaff = reader("AssignedStaff").ToString(),
                                .Status = reader("Status").ToString(),
                                .IsAvailableToReport = False
                            }

                            AddMaintenanceRow(record)
                        End While
                    End Using
                End Using
            End Using

            UpdateSummary()

        Catch ex As Exception
            MessageBox.Show("Failed to load maintenance records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAvailableDamagedItems(conn As MySqlConnection, searchText As String)
        Dim sql As String = "SELECT i.ItemID, i.ItemName, i.DamagedQuantity, (SELECT COUNT(*) FROM maintenance m WHERE m.ItemID=i.ItemID AND m.Status IN ('Pending','In Progress')) AS ActiveRepairs, (SELECT COUNT(*) FROM maintenance m WHERE m.ItemID=i.ItemID AND m.Status='Beyond Repair') AS BeyondRepairCount FROM inventory i WHERE i.DamagedQuantity>0 AND (i.ItemName LIKE @search OR CAST(i.ItemID AS CHAR) LIKE @search) ORDER BY i.ItemName"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@search", "%" & searchText.Trim() & "%")

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim damagedQty As Integer = Convert.ToInt32(reader("DamagedQuantity"))
                    Dim activeRepairs As Integer = Convert.ToInt32(reader("ActiveRepairs"))
                    Dim beyondRepairCount As Integer = Convert.ToInt32(reader("BeyondRepairCount"))
                    Dim availableToReport As Integer = damagedQty - activeRepairs - beyondRepairCount

                    If availableToReport > 0 Then
                        Dim record As New MaintenanceRow With {
                            .MaintenanceID = 0,
                            .ItemID = Convert.ToInt32(reader("ItemID")),
                            .ItemName = reader("ItemName").ToString(),
                            .Problem = "Damaged item awaiting maintenance report",
                            .DateReported = Date.Today,
                            .AssignedStaff = "Unassigned",
                            .Status = "Available to Report",
                            .IsAvailableToReport = True
                        }

                        AddMaintenanceRow(record)
                    End If
                End While
            End Using
        End Using
    End Sub

    Private Sub AddMaintenanceRow(record As MaintenanceRow)
        Dim row As New ListViewItem(If(record.MaintenanceID = 0, "-", record.MaintenanceID.ToString()))
        row.SubItems.Add(record.ItemName)
        row.SubItems.Add(record.DateReported.ToString("yyyy-MM-dd"))
        row.SubItems.Add(record.Problem)
        row.SubItems.Add(record.AssignedStaff)
        row.SubItems.Add(record.Status)
        row.Tag = record
        MaintenanceLV.Items.Add(row)
    End Sub

    Private Sub UpdateSummary()
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Dim sql As String = "SELECT COUNT(*) AS TotalRecords, SUM(CASE WHEN Status='Pending' THEN 1 ELSE 0 END) AS PendingCount, SUM(CASE WHEN Status='In Progress' THEN 1 ELSE 0 END) AS InProgressCount, SUM(CASE WHEN Status='Completed' THEN 1 ELSE 0 END) AS CompletedCount, SUM(CASE WHEN Status='Beyond Repair' THEN 1 ELSE 0 END) AS BeyondRepairCount FROM maintenance"

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TotalRecordsLBL.Text = Convert.ToInt32(reader("TotalRecords")).ToString()
                            PendingLBL.Text = If(IsDBNull(reader("PendingCount")), "0", Convert.ToInt32(reader("PendingCount")).ToString())
                            InProgressLBL.Text = If(IsDBNull(reader("InProgressCount")), "0", Convert.ToInt32(reader("InProgressCount")).ToString())
                            CompletedLBL.Text = If(IsDBNull(reader("CompletedCount")), "0", Convert.ToInt32(reader("CompletedCount")).ToString())
                            BeyondRepairLBL.Text = If(IsDBNull(reader("BeyondRepairCount")), "0", Convert.ToInt32(reader("BeyondRepairCount")).ToString())
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to update maintenance summary: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchItemsTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchItemsTXT.TextChanged
        LoadMaintenanceRecords(SearchItemsTXT.Text)
        ClearFields()
    End Sub

    Private Sub MaintenanceLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaintenanceLV.SelectedIndexChanged
        If MaintenanceLV.SelectedItems.Count = 0 Then
            UpdateStatusLabel("No Status")
            Return
        End If

        Dim record As MaintenanceRow = TryCast(MaintenanceLV.SelectedItems(0).Tag, MaintenanceRow)
        If record Is Nothing Then Return

        SelectedMaintenanceID = record.MaintenanceID
        SelectedItemID = record.ItemID
        SelectedStatus = record.Status

        If record.IsAvailableToReport Then
            UpdateStatusLabel("To Be Reported")
        Else
            UpdateStatusLabel(record.Status)
        End If

        ItemTXT.Text = record.ItemName
        ProblemTXT.Text = If(record.IsAvailableToReport, "", record.Problem)
        DateReportedDTP.Value = record.DateReported
        RmTXT.Clear()
        RepairCostTXT.Clear()

        If record.IsAvailableToReport Then
            AssignedStaffCMB.SelectedIndex = -1
        Else
            SelectStaffByName(record.AssignedStaff)
        End If

        LoadItemImage(record.ItemID)
        UpdateButtonStates(record)
    End Sub

    Private Sub SelectStaffByName(staffName As String)
        AssignedStaffCMB.SelectedIndex = -1

        If AssignedStaffCMB.DataSource Is Nothing Then Return

        For i As Integer = 0 To AssignedStaffCMB.Items.Count - 1
            Dim row As DataRowView = TryCast(AssignedStaffCMB.Items(i), DataRowView)
            If row IsNot Nothing AndAlso row("FullName").ToString() = staffName Then
                AssignedStaffCMB.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub UpdateButtonStates(record As MaintenanceRow)
        Dim canManage As Boolean = CanManageMaintenance()

        ReportRepairBTN.Enabled = canManage AndAlso record.IsAvailableToReport
        StartRepairBTN.Enabled = canManage AndAlso Not record.IsAvailableToReport AndAlso record.Status = "Pending"
        CompleteRepairBTN.Enabled = canManage AndAlso Not record.IsAvailableToReport AndAlso record.Status = "In Progress"
    End Sub

    Private Sub LoadItemImage(itemID As Integer)
        ClearItemImage()

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Using cmd As New MySqlCommand("SELECT ImagePath FROM inventory WHERE ItemID=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", itemID)

                    Dim result As Object = cmd.ExecuteScalar()
                    Dim imagePath As String = If(result Is Nothing OrElse IsDBNull(result), "", result.ToString())

                    DisplayItemImage(imagePath)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load item image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayItemImage(imagePath As String)
        ClearItemImage()
        ItemPB.SizeMode = PictureBoxSizeMode.Zoom

        If String.IsNullOrWhiteSpace(imagePath) Then Return

        Dim fullPath As String = ResolveImagePath(imagePath)
        If Not File.Exists(fullPath) Then Return

        Try
            Using img As Image = Image.FromFile(fullPath)
                ItemPB.Image = New Bitmap(img)
            End Using
        Catch
            ' Ignore invalid or unreadable images.
        End Try
    End Sub

    Private Sub ClearItemImage()
        If ItemPB.Image IsNot Nothing Then
            Dim oldImage As Image = ItemPB.Image
            ItemPB.Image = Nothing
            oldImage.Dispose()
        End If
    End Sub

    Private Function GetSelectedStaffID() As Object
        If AssignedStaffCMB.SelectedIndex < 0 OrElse AssignedStaffCMB.SelectedValue Is Nothing Then Return DBNull.Value
        Return AssignedStaffCMB.SelectedValue
    End Function

    Private Sub ReportRepairBTN_Click(sender As Object, e As EventArgs) Handles ReportRepairBTN.Click
        If Not CanManageMaintenance() Then Return

        If SelectedItemID <= 0 OrElse SelectedMaintenanceID <> 0 OrElse SelectedStatus <> "Available to Report" Then
            MessageBox.Show("Select a damaged item marked Available to Report first.", "No Eligible Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(ProblemTXT.Text) Then
            MessageBox.Show("Enter the problem or reason for maintenance.", "Missing Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ProblemTXT.Focus()
            Return
        End If

        If MessageBox.Show("Create a pending maintenance record for " & ItemTXT.Text & "?", "Confirm Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim damagedQty As Integer
                        Using checkCmd As New MySqlCommand("SELECT DamagedQuantity FROM inventory WHERE ItemID=@itemID FOR UPDATE", conn, transaction)
                            checkCmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                            Dim result As Object = checkCmd.ExecuteScalar()
                            If result Is Nothing OrElse IsDBNull(result) Then Throw New Exception("The selected inventory item no longer exists.")
                            damagedQty = Convert.ToInt32(result)
                        End Using

                        Dim activeCount As Integer
                        Using countCmd As New MySqlCommand("SELECT COUNT(*) FROM maintenance WHERE ItemID=@itemID AND Status IN ('Pending','In Progress')", conn, transaction)
                            countCmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                            activeCount = Convert.ToInt32(countCmd.ExecuteScalar())
                        End Using

                        Dim beyondCount As Integer
                        Using countCmd As New MySqlCommand("SELECT COUNT(*) FROM maintenance WHERE ItemID=@itemID AND Status='Beyond Repair'", conn, transaction)
                            countCmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                            beyondCount = Convert.ToInt32(countCmd.ExecuteScalar())
                        End Using

                        If damagedQty - activeCount - beyondCount <= 0 Then Throw New Exception("There are no unassigned damaged units available to report.")

                        Dim insertSQL As String = "INSERT INTO maintenance (ItemID, Problem, DateReported, AssignedUserID, Status, RepairCost, CompletionDate, Remarks) VALUES (@itemID, @problem, @dateReported, @staffID, 'Pending', 0, NULL, @remarks)"

                        Using cmd As New MySqlCommand(insertSQL, conn, transaction)
                            cmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                            cmd.Parameters.AddWithValue("@problem", ProblemTXT.Text.Trim())
                            cmd.Parameters.AddWithValue("@dateReported", DateReportedDTP.Value.Date)
                            cmd.Parameters.AddWithValue("@staffID", GetSelectedStaffID())
                            cmd.Parameters.AddWithValue("@remarks", If(String.IsNullOrWhiteSpace(RmTXT.Text), "", RmTXT.Text.Trim()))
                            cmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Maintenance report created successfully. Status: Pending.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadMaintenanceRecords(SearchItemsTXT.Text)

        Catch ex As Exception
            MessageBox.Show("Failed to create maintenance report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StartRepairBTN_Click(sender As Object, e As EventArgs) Handles StartRepairBTN.Click
        If Not CanManageMaintenance() Then Return

        If SelectedMaintenanceID <= 0 OrElse SelectedStatus <> "Pending" Then
            MessageBox.Show("Select a Pending maintenance record first.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Start repairing " & ItemTXT.Text & "?", "Start Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Dim sql As String = "UPDATE maintenance SET Status='In Progress', AssignedUserID=@staffID WHERE MaintenanceID=@maintenanceID AND Status='Pending'"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@staffID", GetSelectedStaffID())
                    cmd.Parameters.AddWithValue("@maintenanceID", SelectedMaintenanceID)

                    If cmd.ExecuteNonQuery() <> 1 Then Throw New Exception("The record could not be started. Refresh the list and try again.")
                End Using
            End Using

            MessageBox.Show("Repair status changed to In Progress.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadMaintenanceRecords(SearchItemsTXT.Text)

        Catch ex As Exception
            MessageBox.Show("Failed to start repair: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CompleteRepairBTN_Click(sender As Object, e As EventArgs) Handles CompleteRepairBTN.Click
        If Not CanManageMaintenance() Then Return

        If SelectedMaintenanceID <= 0 OrElse SelectedStatus <> "In Progress" Then
            MessageBox.Show("Select an In Progress maintenance record first.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ItemConditionCMB.SelectedItem Is Nothing Then
            MessageBox.Show("Select the item's condition after repair.", "Missing Condition", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim repairCost As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(RepairCostTXT.Text) AndAlso (Not Decimal.TryParse(RepairCostTXT.Text.Trim(), repairCost) OrElse repairCost < 0D) Then
            MessageBox.Show("Enter a valid repair cost. Leave it blank if there is no cost.", "Invalid Repair Cost", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim condition As String = ItemConditionCMB.SelectedItem.ToString()

        If MessageBox.Show("Complete this maintenance record with the result '" & condition & "'?", "Confirm Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim currentStatus As String = ""

                        Using checkCmd As New MySqlCommand("SELECT Status FROM maintenance WHERE MaintenanceID=@maintenanceID FOR UPDATE", conn, transaction)
                            checkCmd.Parameters.AddWithValue("@maintenanceID", SelectedMaintenanceID)
                            Dim result As Object = checkCmd.ExecuteScalar()
                            If result Is Nothing OrElse IsDBNull(result) Then Throw New Exception("The maintenance record no longer exists.")
                            currentStatus = result.ToString()
                        End Using

                        If currentStatus <> "In Progress" Then Throw New Exception("This record is no longer In Progress. Refresh the list.")

                        If condition = "Good" Then
                            Dim damagedQty As Integer

                            Using checkItemCmd As New MySqlCommand("SELECT DamagedQuantity FROM inventory WHERE ItemID=@itemID FOR UPDATE", conn, transaction)
                                checkItemCmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                                Dim result As Object = checkItemCmd.ExecuteScalar()
                                If result Is Nothing OrElse IsDBNull(result) Then Throw New Exception("The inventory item no longer exists.")
                                damagedQty = Convert.ToInt32(result)
                            End Using

                            If damagedQty < 1 Then Throw New Exception("There is no damaged quantity available to transfer.")

                            Using updateItemCmd As New MySqlCommand("UPDATE inventory SET AvailableQuantity=AvailableQuantity+1, DamagedQuantity=DamagedQuantity-1 WHERE ItemID=@itemID AND DamagedQuantity>=1", conn, transaction)
                                updateItemCmd.Parameters.AddWithValue("@itemID", SelectedItemID)
                                If updateItemCmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Failed to update the inventory quantities.")
                            End Using
                        End If

                        Dim finalStatus As String = If(condition = "Beyond Repair", "Beyond Repair", "Completed")
                        Dim savedRemarks As String = RmTXT.Text.Trim()
                        If savedRemarks <> "" Then savedRemarks &= " | "
                        savedRemarks &= "Item condition after repair: " & condition

                        Dim updateSQL As String = "UPDATE maintenance SET AssignedUserID=@staffID, Status=@status, RepairCost=@cost, CompletionDate=NOW(), Remarks=@remarks WHERE MaintenanceID=@maintenanceID AND Status='In Progress'"

                        Using updateCmd As New MySqlCommand(updateSQL, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@staffID", GetSelectedStaffID())
                            updateCmd.Parameters.AddWithValue("@status", finalStatus)
                            updateCmd.Parameters.AddWithValue("@cost", repairCost)
                            updateCmd.Parameters.AddWithValue("@remarks", savedRemarks)
                            updateCmd.Parameters.AddWithValue("@maintenanceID", SelectedMaintenanceID)

                            If updateCmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Failed to complete the maintenance record.")
                        End Using

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Maintenance record completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadMaintenanceRecords(SearchItemsTXT.Text)

        Catch ex As Exception
            MessageBox.Show("Failed to complete maintenance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        If Not CanManageMaintenance() Then Return

        MaintenanceLV.SelectedItems.Clear()
        ClearFields()
    End Sub

    Private Sub ClearFields()
        SelectedMaintenanceID = 0
        SelectedItemID = 0
        SelectedStatus = ""

        ItemTXT.Clear()
        ProblemTXT.Clear()
        RepairCostTXT.Clear()
        RmTXT.Clear()

        DateReportedDTP.Value = Date.Today
        If ItemConditionCMB.Items.Count > 0 Then ItemConditionCMB.SelectedIndex = 0
        AssignedStaffCMB.SelectedIndex = -1

        ClearItemImage()

        ReportRepairBTN.Enabled = False
        StartRepairBTN.Enabled = False
        CompleteRepairBTN.Enabled = False

        ApplyRolePermissions()
    End Sub

    Private Function GetImagesFolder() As String
        Dim current As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
        While current IsNot Nothing
            Dim imagesPath As String = Path.Combine(current.FullName, "Images")
            If Directory.Exists(imagesPath) Then Return imagesPath
            current = current.Parent
        End While
        Dim newPath As String = Path.Combine(Application.StartupPath, "Images")
        Directory.CreateDirectory(newPath)
        Return newPath
    End Function

    Private Function ResolveImagePath(imagePath As String) As String
        If String.IsNullOrWhiteSpace(imagePath) Then Return ""
        If Path.IsPathRooted(imagePath) Then Return imagePath
        Return Path.Combine(Directory.GetParent(GetImagesFolder()).FullName, imagePath.Replace("/"c, Path.DirectorySeparatorChar))
    End Function

    Private Sub UpdateStatusLabel(status As String)
        StatusLBL.Text = status

        Select Case status
            Case "To Be Reported", "Pending"
                StatusLBL.ForeColor = Color.FromArgb(38, 50, 56)
                If status = "Pending" Then StatusLBL.Text = "Reported"

            Case "To Be Repaired"
                StatusLBL.ForeColor = Color.FromArgb(220, 156, 51)

            Case "In Progress"
                StatusLBL.ForeColor = Color.FromArgb(57, 117, 215)

            Case "Completed"
                StatusLBL.ForeColor = Color.FromArgb(38, 151, 101)

            Case "Beyond Repair"
                StatusLBL.ForeColor = Color.FromArgb(218, 93, 93)

            Case Else
                StatusLBL.Text = "No Status"
                StatusLBL.ForeColor = Color.Black
        End Select
    End Sub

End Class
