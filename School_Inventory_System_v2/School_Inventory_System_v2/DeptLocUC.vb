Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DeptLocUC

    Public Property CurrentUserRole As String = ""

    Private isAddingDept As Boolean = False
    Private isEditingDept As Boolean = False
    Private selectedDeptID As Integer = 0

    Private isAddingLoc As Boolean = False
    Private isEditingLoc As Boolean = False
    Private selectedLocID As Integer = 0

    Private Function CanManageDeptLoc() As Boolean
        Return CurrentUserRole.Trim().ToLowerInvariant() = "admin"
    End Function

    Private Sub DeptLocUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DeptLV.View = View.Details
        DeptLV.FullRowSelect = True
        DeptLV.GridLines = True
        DeptLV.MultiSelect = False
        DeptLV.HideSelection = False
        DeptLV.Columns.Clear()
        DeptLV.Columns.Add("Department Name", 180)
        DeptLV.Columns.Add("Head", 150)
        DeptLV.Columns.Add("Status", 90)

        LocLV.View = View.Details
        LocLV.FullRowSelect = True
        LocLV.GridLines = True
        LocLV.MultiSelect = False
        LocLV.HideSelection = False
        LocLV.Columns.Clear()
        LocLV.Columns.Add("Location", 180)
        LocLV.Columns.Add("Department", 150)
        LocLV.Columns.Add("Status", 90)

        DeptDescTXT.Multiline = True
        LocDescTXT.Multiline = True

        StatusCMB.Items.Clear()
        StatusCMB.Items.Add("Active")
        StatusCMB.Items.Add("Inactive")

        LocStatusCMB.Items.Clear()
        LocStatusCMB.Items.Add("Active")
        LocStatusCMB.Items.Add("Inactive")

        DeptCancelBTN.Visible = False
        LocCancelBTN.Visible = False

        LoadDepartmentHeads()
        LoadDepartmentsIntoLocationCombo()
        LoadDepartments()
        LoadLocations()

        SetDeptViewState()
        SetLocViewState()

    End Sub

    Private Sub DepartmentsBTN_Click(sender As Object, e As EventArgs) Handles DepartmentsBTN.Click
        If TabControl1.SelectedTab Is DeptTP Then
            MessageBox.Show("You are already in the Departments tab.", "Already in Tab", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TabControl1.SelectedTab = DeptTP
            DepartmentsBTN.BackColor = Color.FromArgb(214, 173, 96)
            DepartmentPB.BackColor = Color.FromArgb(214, 173, 96)
            DepartmentsBTN.FlatAppearance.BorderSize = 0
            LocationsBTN.BackColor = Color.FromArgb(72, 101, 129)
            LocationsPB.BackColor = Color.FromArgb(72, 101, 129)
            LocationsBTN.FlatAppearance.BorderSize = 2
            LocationsBTN.FlatAppearance.BorderColor = Color.White
        End If
    End Sub

    Private Sub LocationsBTN_Click(sender As Object, e As EventArgs) Handles LocationsBTN.Click
        If TabControl1.SelectedTab Is LocationsTP Then
            MessageBox.Show("You are already in the Locations tab.", "Already in Tab", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TabControl1.SelectedTab = LocationsTP
            LocationsBTN.BackColor = Color.FromArgb(214, 173, 96)
            LocationsPB.BackColor = Color.FromArgb(214, 173, 96)
            LocationsBTN.FlatAppearance.BorderSize = 0
            DepartmentsBTN.BackColor = Color.FromArgb(72, 101, 129)
            DepartmentPB.BackColor = Color.FromArgb(72, 101, 129)
            DepartmentsBTN.FlatAppearance.BorderSize = 2
            DepartmentsBTN.FlatAppearance.BorderColor = Color.White
        End If
    End Sub

    Private Sub LoadDepartmentHeads()
        Try
            Dim dt As New DataTable()
            dt.Columns.Add("User_ID", GetType(Integer))
            dt.Columns.Add("FullName", GetType(String))
            dt.Rows.Add(0, "-- No Head --")

            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT User_ID, FullName FROM users WHERE Status = 'Active' ORDER BY FullName"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            DeptHeadCMB.DataSource = Nothing
            DeptHeadCMB.DisplayMember = "FullName"
            DeptHeadCMB.ValueMember = "User_ID"
            DeptHeadCMB.DataSource = dt
            DeptHeadCMB.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Failed to load department heads: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDepartmentsIntoLocationCombo()
        Try
            Dim dt As New DataTable()

            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT DepartmentID, DepartmentName FROM departments WHERE Status = 'Active' ORDER BY DepartmentName"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            LocDeptCMB.DataSource = Nothing
            LocDeptCMB.DisplayMember = "DepartmentName"
            LocDeptCMB.ValueMember = "DepartmentID"
            LocDeptCMB.DataSource = dt
            LocDeptCMB.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Failed to load departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDepartments()
        Try
            DeptLV.Items.Clear()

            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT d.DepartmentID, d.DepartmentName, u.FullName AS HeadName, d.Status FROM departments d LEFT JOIN users u ON d.HeadUserID = u.User_ID WHERE d.DepartmentName LIKE @Search OR COALESCE(u.FullName, '') LIKE @Search OR d.Status LIKE @Search ORDER BY d.DepartmentName"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & SearchDeptTXT.Text.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("DepartmentName").ToString())
                            Dim headName As String = If(IsDBNull(reader("HeadName")), "", reader("HeadName").ToString())

                            item.SubItems.Add(headName)
                            item.SubItems.Add(reader("Status").ToString())
                            item.Tag = Convert.ToInt32(reader("DepartmentID"))
                            DeptLV.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load departments: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchDeptTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchDeptTXT.TextChanged
        If Not isAddingDept AndAlso Not isEditingDept Then
            selectedDeptID = 0
            ClearDeptDetails()
            LoadDepartments()
        End If
    End Sub

    Private Sub DeptLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeptLV.SelectedIndexChanged
        If isAddingDept OrElse isEditingDept Then Return
        If DeptLV.SelectedItems.Count = 0 Then Return

        selectedDeptID = CInt(DeptLV.SelectedItems(0).Tag)

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT DepartmentName, HeadUserID, ContactNum, Status, Description FROM departments WHERE DepartmentID = @ID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedDeptID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            DepartmentNameTXT.Text = reader("DepartmentName").ToString()
                            ContactNumTXT.Text = If(IsDBNull(reader("ContactNum")), "", reader("ContactNum").ToString())
                            DeptDescTXT.Text = If(IsDBNull(reader("Description")), "", reader("Description").ToString())
                            StatusCMB.SelectedItem = reader("Status").ToString()

                            If IsDBNull(reader("HeadUserID")) Then
                                DeptHeadCMB.SelectedValue = 0
                            Else
                                DeptHeadCMB.SelectedValue = Convert.ToInt32(reader("HeadUserID"))
                            End If
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load department details: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearDeptDetails()
        DepartmentNameTXT.Clear()
        ContactNumTXT.Clear()
        DeptDescTXT.Clear()
        DeptHeadCMB.SelectedIndex = -1
        StatusCMB.SelectedIndex = -1
    End Sub

    Private Function ValidateDepartment() As Boolean
        If String.IsNullOrWhiteSpace(DepartmentNameTXT.Text) Then
            MessageBox.Show("Please enter a department name.")
            Return False
        End If

        If StatusCMB.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department status.")
            Return False
        End If

        Return True
    End Function

    Private Sub DeptAddBTN_Click(sender As Object, e As EventArgs) Handles DeptAddBTN.Click
        If Not CanManageDeptLoc() Then Return

        If isAddingDept Then
            SaveDepartment()
            Return
        End If

        If isEditingDept Then Return

        isAddingDept = True
        selectedDeptID = 0
        DeptLV.SelectedItems.Clear()
        ClearDeptDetails()
        SetDeptViewState()
    End Sub

    Private Sub DeptEditBTN_Click(sender As Object, e As EventArgs) Handles DeptEditBTN.Click
        If Not CanManageDeptLoc() Then Return

        If isEditingDept Then
            UpdateDepartment()
            Return
        End If

        If isAddingDept Then Return

        If DeptLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a department first.")
            Return
        End If

        isEditingDept = True
        SetDeptViewState()
    End Sub

    Private Sub SaveDepartment()
        If Not CanManageDeptLoc() Then Return
        If Not ValidateDepartment() Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "INSERT INTO departments (DepartmentName, HeadUserID, ContactNum, Status, Description) VALUES (@Name, @Head, @Contact, @Status, @Description)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", DepartmentNameTXT.Text.Trim())

                    Dim headID As Integer = CInt(DeptHeadCMB.SelectedValue)
                    cmd.Parameters.AddWithValue("@Head", If(headID = 0, CType(DBNull.Value, Object), headID))
                    cmd.Parameters.AddWithValue("@Contact", ContactNumTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Description", DeptDescTXT.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Department added successfully.")
            FinishDepartmentEdit()

        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("That department name already exists.")
        Catch ex As Exception
            MessageBox.Show("Failed to add department: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateDepartment()
        If Not CanManageDeptLoc() Then Return
        If selectedDeptID = 0 OrElse Not ValidateDepartment() Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "UPDATE departments SET DepartmentName=@Name, HeadUserID=@Head, ContactNum=@Contact, Status=@Status, Description=@Description WHERE DepartmentID=@ID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", DepartmentNameTXT.Text.Trim())

                    Dim headID As Integer = CInt(DeptHeadCMB.SelectedValue)
                    cmd.Parameters.AddWithValue("@Head", If(headID = 0, CType(DBNull.Value, Object), headID))
                    cmd.Parameters.AddWithValue("@Contact", ContactNumTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Description", DeptDescTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@ID", selectedDeptID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Department updated successfully.")
            FinishDepartmentEdit()

        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("That department name already exists.")
        Catch ex As Exception
            MessageBox.Show("Failed to update department: " & ex.Message)
        End Try
    End Sub

    Private Sub DeptDeleteBTN_Click(sender As Object, e As EventArgs) Handles DeptDeleteBTN.Click
        If Not CanManageDeptLoc() Then Return

        If DeptLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a department to delete.")
            Return
        End If

        Dim item As ListViewItem = DeptLV.SelectedItems(0)
        Dim departmentID As Integer = CInt(item.Tag)
        Dim departmentName As String = item.Text

        If MessageBox.Show("Permanently delete department '" & departmentName & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Using cmd As New MySqlCommand("DELETE FROM departments WHERE DepartmentID=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", departmentID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Department deleted successfully.")
            selectedDeptID = 0
            ClearDeptDetails()
            LoadDepartments()
            LoadDepartmentsIntoLocationCombo()

        Catch ex As MySqlException When ex.Number = 1451
            MessageBox.Show("This department cannot be deleted because locations or inventory items still reference it. Remove or reassign those records first.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Failed to delete department: " & ex.Message)
        End Try
    End Sub

    Private Sub DeptCancelBTN_Click(sender As Object, e As EventArgs) Handles DeptCancelBTN.Click
        If Not CanManageDeptLoc() Then Return
        FinishDepartmentEdit()
    End Sub

    Private Sub FinishDepartmentEdit()
        isAddingDept = False
        isEditingDept = False
        selectedDeptID = 0

        ClearDeptDetails()
        LoadDepartments()
        LoadDepartmentHeads()
        LoadDepartmentsIntoLocationCombo()
        SetDeptViewState()
    End Sub

    Private Sub SetDeptViewState()
        Dim canManage As Boolean = CanManageDeptLoc()
        Dim busy As Boolean = canManage AndAlso (isAddingDept OrElse isEditingDept)

        DepartmentNameTXT.Enabled = busy
        ContactNumTXT.Enabled = busy
        DeptDescTXT.Enabled = busy
        DeptHeadCMB.Enabled = busy
        StatusCMB.Enabled = busy

        SearchDeptTXT.Enabled = Not busy
        DeptLV.Enabled = Not busy
        DeptDeleteBTN.Enabled = canManage AndAlso Not busy

        DeptAddBTN.Enabled = canManage AndAlso Not isEditingDept
        DeptEditBTN.Enabled = canManage AndAlso Not isAddingDept

        DeptAddBTN.Text = If(isAddingDept, "Save", "Add")
        DeptEditBTN.Text = If(isEditingDept, "Save", "Edit")

        DeptCancelBTN.Visible = busy
        DeptCancelBTN.Enabled = canManage
    End Sub

    Private Sub LoadLocations()
        Try
            LocLV.Items.Clear()

            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT l.LocationID, l.LocationName, d.DepartmentName, l.Status FROM locations l INNER JOIN departments d ON l.DepartmentID = d.DepartmentID WHERE l.LocationName LIKE @Search OR d.DepartmentName LIKE @Search OR l.Status LIKE @Search ORDER BY l.LocationName"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & SearchLocTXT.Text.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("LocationName").ToString())
                            item.SubItems.Add(reader("DepartmentName").ToString())
                            item.SubItems.Add(reader("Status").ToString())
                            item.Tag = Convert.ToInt32(reader("LocationID"))
                            LocLV.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load locations: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchLocTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchLocTXT.TextChanged
        If Not isAddingLoc AndAlso Not isEditingLoc Then
            selectedLocID = 0
            ClearLocDetails()
            LoadLocations()
        End If
    End Sub

    Private Sub LocLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LocLV.SelectedIndexChanged
        If isAddingLoc OrElse isEditingLoc Then Return
        If LocLV.SelectedItems.Count = 0 Then Return

        selectedLocID = CInt(LocLV.SelectedItems(0).Tag)

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "SELECT LocationName, DepartmentID, Status, Description FROM locations WHERE LocationID = @ID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedLocID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            LocationNameTXT.Text = reader("LocationName").ToString()
                            LocDeptCMB.SelectedValue = Convert.ToInt32(reader("DepartmentID"))
                            LocStatusCMB.SelectedItem = reader("Status").ToString()
                            LocDescTXT.Text = If(IsDBNull(reader("Description")), "", reader("Description").ToString())
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load location details: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearLocDetails()
        LocationNameTXT.Clear()
        LocDeptCMB.SelectedIndex = -1
        LocStatusCMB.SelectedIndex = -1
        LocDescTXT.Clear()
    End Sub

    Private Function ValidateLocation() As Boolean
        If String.IsNullOrWhiteSpace(LocationNameTXT.Text) Then
            MessageBox.Show("Please enter a location name.")
            Return False
        End If

        If LocDeptCMB.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department.")
            Return False
        End If

        If LocStatusCMB.SelectedIndex = -1 Then
            MessageBox.Show("Please select a location status.")
            Return False
        End If

        Return True
    End Function

    Private Sub LocAddBTN_Click(sender As Object, e As EventArgs) Handles LocAddBTN.Click
        If Not CanManageDeptLoc() Then Return

        If isAddingLoc Then
            SaveLocation()
            Return
        End If

        If isEditingLoc Then Return

        isAddingLoc = True
        selectedLocID = 0
        LocLV.SelectedItems.Clear()
        ClearLocDetails()
        SetLocViewState()
    End Sub

    Private Sub LocEditBTN_Click(sender As Object, e As EventArgs) Handles LocEditBTN.Click
        If Not CanManageDeptLoc() Then Return

        If isEditingLoc Then
            UpdateLocation()
            Return
        End If

        If isAddingLoc Then Return

        If LocLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a location first.")
            Return
        End If

        isEditingLoc = True
        SetLocViewState()
    End Sub

    Private Sub SaveLocation()
        If Not CanManageDeptLoc() Then Return
        If Not ValidateLocation() Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "INSERT INTO locations (LocationName, DepartmentID, Status, Description) VALUES (@Name, @DepartmentID, @Status, @Description)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", LocationNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@DepartmentID", CInt(LocDeptCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@Status", LocStatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Description", LocDescTXT.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Location added successfully.")
            FinishLocationEdit()

        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("A location with that name already exists in the selected department.")
        Catch ex As Exception
            MessageBox.Show("Failed to add location: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateLocation()
        If Not CanManageDeptLoc() Then Return
        If selectedLocID = 0 OrElse Not ValidateLocation() Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim sql As String = "UPDATE locations SET LocationName=@Name, DepartmentID=@DepartmentID, Status=@Status, Description=@Description WHERE LocationID=@ID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", LocationNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@DepartmentID", CInt(LocDeptCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@Status", LocStatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Description", LocDescTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@ID", selectedLocID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Location updated successfully.")
            FinishLocationEdit()

        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("A location with that name already exists in the selected department.")
        Catch ex As Exception
            MessageBox.Show("Failed to update location: " & ex.Message)
        End Try
    End Sub

    Private Sub LocDeleteBTN_Click(sender As Object, e As EventArgs) Handles LocDeleteBTN.Click
        If Not CanManageDeptLoc() Then Return

        If LocLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a location to delete.")
            Return
        End If

        Dim item As ListViewItem = LocLV.SelectedItems(0)
        Dim locationID As Integer = CInt(item.Tag)
        Dim locationName As String = item.Text

        If MessageBox.Show("Permanently delete location '" & locationName & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Using cmd As New MySqlCommand("DELETE FROM locations WHERE LocationID=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", locationID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Location deleted successfully.")
            selectedLocID = 0
            ClearLocDetails()
            LoadLocations()

        Catch ex As MySqlException When ex.Number = 1451
            MessageBox.Show("This location cannot be deleted because inventory items reference it. Reassign those items first.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Failed to delete location: " & ex.Message)
        End Try
    End Sub

    Private Sub LocCancelBTN_Click(sender As Object, e As EventArgs) Handles LocCancelBTN.Click
        If Not CanManageDeptLoc() Then Return
        FinishLocationEdit()
    End Sub

    Private Sub FinishLocationEdit()
        isAddingLoc = False
        isEditingLoc = False
        selectedLocID = 0

        ClearLocDetails()
        LoadLocations()
        SetLocViewState()
    End Sub

    Private Sub SetLocViewState()
        Dim canManage As Boolean = CanManageDeptLoc()
        Dim busy As Boolean = canManage AndAlso (isAddingLoc OrElse isEditingLoc)

        LocationNameTXT.Enabled = busy
        LocDeptCMB.Enabled = busy
        LocStatusCMB.Enabled = busy
        LocDescTXT.Enabled = busy

        SearchLocTXT.Enabled = Not busy
        LocLV.Enabled = Not busy
        LocDeleteBTN.Enabled = canManage AndAlso Not busy

        LocAddBTN.Enabled = canManage AndAlso Not isEditingLoc
        LocEditBTN.Enabled = canManage AndAlso Not isAddingLoc

        LocAddBTN.Text = If(isAddingLoc, "Save", "Add")
        LocEditBTN.Text = If(isEditingLoc, "Save", "Edit")

        LocCancelBTN.Visible = busy
        LocCancelBTN.Enabled = canManage
    End Sub

End Class