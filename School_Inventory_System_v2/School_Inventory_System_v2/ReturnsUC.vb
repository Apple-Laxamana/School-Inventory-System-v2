Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Linq

Public Class ReturnsUC

    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Class ReturnItem
        Public Property IssuanceDetailID As Integer
        Public Property IssuanceID As Integer
        Public Property ItemID As Integer
        Public Property Recipient As String
        Public Property ItemName As String
        Public Property IssuedQuantity As Integer
        Public Property PreviouslyReturned As Integer
        Public Property Outstanding As Integer
        Public Property QuantityToReturn As Integer
        Public Property Condition As String
        Public Property Remarks As String
    End Class

    Private SelectedItems As New List(Of ReturnItem)
    Private UpdatingControls As Boolean = False

    Private Function CanProcessReturns() As Boolean
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Return role = "admin" OrElse role = "issuance clerk"
    End Function

    Private Sub ApplyRolePermissions()
        Dim canProcess As Boolean = CanProcessReturns()

        AddSelectedBTN.Enabled = canProcess
        RemoveSelectedBTN.Enabled = canProcess
        ClearBTN.Enabled = canProcess
        ReturnBTN.Enabled = canProcess
        QuantityToReturnTXT.Enabled = canProcess
        ConditionCMB.Enabled = canProcess
        RemarksTXT.Enabled = canProcess
        ReturnDateDTP.Enabled = canProcess
        UpdateQuantityBTN.Enabled = canProcess
        UpdateRemarksBTN.Enabled = canProcess

        UpdateQuantityBTN.Visible = False
        UpdateRemarksBTN.Visible = False

        SearchItemsToReturnTXT.Enabled = True
        SearchReturnHistoryTXT.Enabled = True
        ItemsToReturnLV.Enabled = True
        ItemsForReturnLV.Enabled = True
        ReturnHistoryLV.Enabled = True
    End Sub

    Private Sub ReturnsUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListViews()
        UpdatingControls = True
        ConditionCMB.Items.Clear()
        ConditionCMB.Items.Add("Good")
        ConditionCMB.Items.Add("Damaged")
        ConditionCMB.SelectedIndex = 0
        ReturnDateDTP.Value = DateTime.Now
        UpdatingControls = False
        UpdateQuantityBTN.Visible = False
        ClearDetails()
        LoadOutstandingItems("")
        LoadReturnHistory("")
        ApplyRolePermissions()
    End Sub

    Private Sub SetupListViews()
        ItemsToReturnLV.View = View.Details
        ItemsToReturnLV.FullRowSelect = True
        ItemsToReturnLV.GridLines = True
        ItemsToReturnLV.Columns.Clear()
        ItemsToReturnLV.Columns.Add("Detail ID", 75)
        ItemsToReturnLV.Columns.Add("Recipient", 150)
        ItemsToReturnLV.Columns.Add("Item Name", 150)
        ItemsToReturnLV.Columns.Add("Date Issued", 110)
        ItemsToReturnLV.Columns.Add("Issued", 65)
        ItemsToReturnLV.Columns.Add("Returned", 75)
        ItemsToReturnLV.Columns.Add("Outstanding", 85)

        ItemsForReturnLV.View = View.Details
        ItemsForReturnLV.FullRowSelect = True
        ItemsForReturnLV.GridLines = True
        ItemsForReturnLV.Columns.Clear()
        ItemsForReturnLV.Columns.Add("Detail ID", 75)
        ItemsForReturnLV.Columns.Add("Recipient", 130)
        ItemsForReturnLV.Columns.Add("Item Name", 140)
        ItemsForReturnLV.Columns.Add("Outstanding", 85)
        ItemsForReturnLV.Columns.Add("Returning", 75)
        ItemsForReturnLV.Columns.Add("Condition", 85)
        ItemsForReturnLV.Columns.Add("Remarks", 180)

        ReturnHistoryLV.View = View.Details
        ReturnHistoryLV.FullRowSelect = True
        ReturnHistoryLV.GridLines = True
        ReturnHistoryLV.Columns.Clear()
        ReturnHistoryLV.Columns.Add("Return ID", 75)
        ReturnHistoryLV.Columns.Add("Date", 115)
        ReturnHistoryLV.Columns.Add("Recipient", 140)
        ReturnHistoryLV.Columns.Add("Item Name", 140)
        ReturnHistoryLV.Columns.Add("Quantity", 70)
        ReturnHistoryLV.Columns.Add("Condition", 85)
        ReturnHistoryLV.Columns.Add("Received By", 120)
        ReturnHistoryLV.Columns.Add("Remarks", 180)
    End Sub

    Private Sub LoadOutstandingItems(searchText As String)
        ItemsToReturnLV.Items.Clear()

        Using conn As MySqlConnection = Database.GetConnection()
            conn.Open()
            Dim sql As String = "SELECT id.IssuanceDetailID, id.IssuanceID, id.ItemID, iss.RecepientName, i.ItemName, iss.IssueDate, id.QuantityIssued, id.QuantityReturned, (id.QuantityIssued - id.QuantityReturned) AS Outstanding FROM issuance_details id INNER JOIN issuances iss ON id.IssuanceID = iss.IssuanceID INNER JOIN inventory i ON id.ItemID = i.ItemID WHERE id.QuantityIssued > id.QuantityReturned AND (iss.RecepientName LIKE @search OR i.ItemName LIKE @search OR CAST(id.IssuanceID AS CHAR) LIKE @search OR CAST(id.IssuanceDetailID AS CHAR) LIKE @search)"

            If SelectedItems.Count > 0 Then sql &= " AND iss.RecepientName = @recipient"

            sql &= " ORDER BY iss.IssueDate DESC"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                If SelectedItems.Count > 0 Then cmd.Parameters.AddWithValue("@recipient", SelectedItems(0).Recipient)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ReturnItem With {
                            .IssuanceDetailID = Convert.ToInt32(reader("IssuanceDetailID")),
                            .IssuanceID = Convert.ToInt32(reader("IssuanceID")),
                            .ItemID = Convert.ToInt32(reader("ItemID")),
                            .Recipient = reader("RecepientName").ToString(),
                            .ItemName = reader("ItemName").ToString(),
                            .IssuedQuantity = Convert.ToInt32(reader("QuantityIssued")),
                            .PreviouslyReturned = Convert.ToInt32(reader("QuantityReturned")),
                            .Outstanding = Convert.ToInt32(reader("Outstanding"))
                        }

                        Dim row As New ListViewItem(item.IssuanceDetailID.ToString())
                        row.SubItems.Add(item.Recipient)
                        row.SubItems.Add(item.ItemName)
                        row.SubItems.Add(Convert.ToDateTime(reader("IssueDate")).ToString("yyyy-MM-dd"))
                        row.SubItems.Add(item.IssuedQuantity.ToString())
                        row.SubItems.Add(item.PreviouslyReturned.ToString())
                        row.SubItems.Add(item.Outstanding.ToString())
                        row.Tag = item

                        ItemsToReturnLV.Items.Add(row)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadReturnHistory(searchText As String)
        ReturnHistoryLV.BeginUpdate()
        ReturnHistoryLV.Items.Clear()

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Dim sql As String = "SELECT r.ReturnID, r.ReturnDate, iss.RecepientName, i.ItemName, r.QuantityReturned, r.ConditionOnReturn, COALESCE(u.FullName, '') AS ReceivedBy, COALESCE(r.Remarks, '') AS Remarks FROM returns r INNER JOIN issuance_details id ON r.IssuanceDetailID = id.IssuanceDetailID INNER JOIN issuances iss ON id.IssuanceID = iss.IssuanceID INNER JOIN inventory i ON id.ItemID = i.ItemID LEFT JOIN users u ON r.ReceivedByUserID = u.User_ID WHERE (iss.RecepientName LIKE @search OR i.ItemName LIKE @search OR CAST(r.ReturnID AS CHAR) LIKE @search OR COALESCE(r.Remarks, '') LIKE @search OR COALESCE(u.FullName, '') LIKE @search) ORDER BY r.ReturnDate DESC, r.ReturnID DESC"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim row As New ListViewItem(reader("ReturnID").ToString())
                            row.SubItems.Add(Convert.ToDateTime(reader("ReturnDate")).ToString("yyyy-MM-dd HH:mm"))
                            row.SubItems.Add(reader("RecepientName").ToString())
                            row.SubItems.Add(reader("ItemName").ToString())
                            row.SubItems.Add(reader("QuantityReturned").ToString())
                            row.SubItems.Add(reader("ConditionOnReturn").ToString())
                            row.SubItems.Add(reader("ReceivedBy").ToString())
                            row.SubItems.Add(reader("Remarks").ToString())
                            ReturnHistoryLV.Items.Add(row)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load return history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ReturnHistoryLV.EndUpdate()
        End Try
    End Sub

    Private Sub SearchItemsToReturnTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchItemsToReturnTXT.TextChanged
        LoadOutstandingItems(SearchItemsToReturnTXT.Text)
    End Sub

    Private Sub SearchReturnHistoryTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchReturnHistoryTXT.TextChanged
        LoadReturnHistory(SearchReturnHistoryTXT.Text)
    End Sub

    Private Sub ItemsToReturnLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemsToReturnLV.SelectedIndexChanged
        If ItemsToReturnLV.SelectedItems.Count = 0 Then Return

        Dim item As ReturnItem = TryCast(ItemsToReturnLV.SelectedItems(0).Tag, ReturnItem)
        If item Is Nothing Then Return

        RecepientNameLBL.Text = item.Recipient
        ItemNameLBL.Text = item.ItemName
        TotalQuantityLBL.Text = item.IssuedQuantity.ToString()
    End Sub

    Private Sub AddSelectedBTN_Click(sender As Object, e As EventArgs) Handles AddSelectedBTN.Click
        If Not CanProcessReturns() Then Return

        If ItemsToReturnLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim source As ReturnItem = DirectCast(ItemsToReturnLV.SelectedItems(0).Tag, ReturnItem)

        If SelectedItems.Count > 0 AndAlso Not String.Equals(SelectedItems(0).Recipient, source.Recipient, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("You can only return items belonging to one recipient at a time. Remove all queued items or clear the list before selecting another recipient.", "Different Recipient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If SelectedItems.Any(Function(x) x.IssuanceDetailID = source.IssuanceDetailID) Then
            MessageBox.Show("This item is already in the return list.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SelectedItems.Add(New ReturnItem With {
            .IssuanceDetailID = source.IssuanceDetailID,
            .IssuanceID = source.IssuanceID,
            .ItemID = source.ItemID,
            .Recipient = source.Recipient,
            .ItemName = source.ItemName,
            .IssuedQuantity = source.IssuedQuantity,
            .PreviouslyReturned = source.PreviouslyReturned,
            .Outstanding = source.Outstanding,
            .QuantityToReturn = 1,
            .Condition = "Good",
            .Remarks = ""
        })

        RefreshSelectedItems()
        ClearDetails()
        LoadOutstandingItems(SearchItemsToReturnTXT.Text)
    End Sub

    Private Sub RemoveSelectedBTN_Click(sender As Object, e As EventArgs) Handles RemoveSelectedBTN.Click
        If Not CanProcessReturns() Then Return

        If ItemsForReturnLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim detailID As Integer = CInt(ItemsForReturnLV.SelectedItems(0).Tag)
        SelectedItems.RemoveAll(Function(x) x.IssuanceDetailID = detailID)

        RefreshSelectedItems()
        ClearDetails()
        LoadOutstandingItems(SearchItemsToReturnTXT.Text)
    End Sub

    Private Sub ItemsForReturnLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemsForReturnLV.SelectedIndexChanged
        If UpdatingControls OrElse ItemsForReturnLV.SelectedItems.Count = 0 Then Return

        Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
        Dim item As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)
        If item Is Nothing Then Return

        UpdatingControls = True
        RecepientNameLBL.Text = item.Recipient
        ItemNameLBL.Text = item.ItemName
        TotalQuantityLBL.Text = item.IssuedQuantity.ToString()
        QuantityToReturnTXT.Text = item.QuantityToReturn.ToString()
        If ConditionCMB.Items.Contains(item.Condition) Then ConditionCMB.SelectedItem = item.Condition
        RemarksTXT.Text = item.Remarks
        UpdateQuantityBTN.Visible = CanProcessReturns()
        UpdatingControls = False
        UpdateRemarksBTN.Visible = False
    End Sub

    Private Sub ConditionCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConditionCMB.SelectedIndexChanged
        If Not CanProcessReturns() Then Return
        If UpdatingControls OrElse ItemsForReturnLV.SelectedItems.Count = 0 OrElse ConditionCMB.SelectedItem Is Nothing Then Return

        Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
        Dim item As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)
        If item Is Nothing Then Return

        item.Condition = ConditionCMB.SelectedItem.ToString()
        RefreshSelectedItems()
        SelectQueuedReturnItem(detailID)
    End Sub

    Private Sub ReturnDateDTP_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDateDTP.ValueChanged
        'selected date is used directly when is clicked.
    End Sub

    Private Sub RemarksTXT_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarksTXT.KeyDown
        If Not CanProcessReturns() Then Return
        If e.KeyCode <> Keys.Enter Then Return
        e.SuppressKeyPress = True

        If ItemsForReturnLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an item in the return list before saving its remarks.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
        Dim item As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)
        If item Is Nothing Then Return

        item.Remarks = RemarksTXT.Text.Trim()
        RefreshSelectedItems()
        SelectQueuedReturnItem(detailID)
    End Sub

    Private Sub SelectQueuedReturnItem(detailID As Integer)
        For Each row As ListViewItem In ItemsForReturnLV.Items
            If Convert.ToInt32(row.Tag) = detailID Then
                row.Selected = True
                row.Focused = True
                row.EnsureVisible()
                Exit For
            End If
        Next
    End Sub

    Private Sub QuantityToReturnTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityToReturnTXT.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub UpdateQuantityBTN_Click(sender As Object, e As EventArgs) Handles UpdateQuantityBTN.Click
        If Not CanProcessReturns() Then Return

        If ItemsForReturnLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an item in the return list first.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
        Dim item As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)
        If item Is Nothing Then Return

        Dim qty As Integer
        If Not Integer.TryParse(QuantityToReturnTXT.Text.Trim(), qty) OrElse qty <= 0 Then
            MessageBox.Show("Enter a valid positive whole number for the return quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If qty > item.Outstanding Then
            MessageBox.Show("The return quantity cannot exceed the outstanding quantity of " & item.Outstanding.ToString() & ".", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        item.QuantityToReturn = qty
        RefreshSelectedItems()
        SelectQueuedReturnItem(detailID)
    End Sub

    Private Sub RefreshSelectedItems()
        UpdatingControls = True
        ItemsForReturnLV.Items.Clear()

        For Each item As ReturnItem In SelectedItems
            Dim row As New ListViewItem(item.IssuanceDetailID.ToString())
            row.SubItems.Add(item.Recipient)
            row.SubItems.Add(item.ItemName)
            row.SubItems.Add(item.Outstanding.ToString())
            row.SubItems.Add(item.QuantityToReturn.ToString())
            row.SubItems.Add(item.Condition)
            row.SubItems.Add(If(item.Remarks, ""))
            row.Tag = item.IssuanceDetailID
            ItemsForReturnLV.Items.Add(row)
        Next

        DifferentItemsLBL.Text = SelectedItems.Count.ToString()
        TotalUnitsLBL.Text = SelectedItems.Sum(Function(x) x.QuantityToReturn).ToString()
        UpdatingControls = False
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        If Not CanProcessReturns() Then Return

        SelectedItems.Clear()
        RefreshSelectedItems()
        ClearDetails()
        ReturnDateDTP.Value = DateTime.Now
        LoadOutstandingItems(SearchItemsToReturnTXT.Text)
    End Sub

    Private Sub ClearDetails()
        UpdatingControls = True
        RecepientNameLBL.Text = ""
        ItemNameLBL.Text = ""
        TotalQuantityLBL.Text = ""
        QuantityToReturnTXT.Clear()
        RemarksTXT.Clear()
        If ConditionCMB.Items.Count > 0 Then ConditionCMB.SelectedIndex = 0
        UpdateQuantityBTN.Visible = False
        UpdatingControls = False
        UpdateRemarksBTN.Visible = False
    End Sub

    Private Sub ReturnBTN_Click(sender As Object, e As EventArgs) Handles ReturnBTN.Click
        If Not CanProcessReturns() Then Return

        'Save the current input fields for the selected queued item before processing.
        If ItemsForReturnLV.SelectedItems.Count > 0 Then
            Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
            Dim selectedItem As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)

            If selectedItem IsNot Nothing Then
                selectedItem.Remarks = RemarksTXT.Text.Trim()
                If ConditionCMB.SelectedItem IsNot Nothing Then selectedItem.Condition = ConditionCMB.SelectedItem.ToString()

                Dim currentQty As Integer
                If Integer.TryParse(QuantityToReturnTXT.Text.Trim(), currentQty) AndAlso currentQty > 0 AndAlso currentQty <= selectedItem.Outstanding Then
                    selectedItem.QuantityToReturn = currentQty
                End If
            End If
        End If

        If SelectedItems.Count = 0 Then
            MessageBox.Show("Add at least one issued item to the return list.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRecipient As String = SelectedItems(0).Recipient

        If SelectedItems.Any(Function(x) Not String.Equals(x.Recipient, selectedRecipient, StringComparison.OrdinalIgnoreCase)) Then
            MessageBox.Show("The return list contains items from different recipients. Please clear the list and try again.", "Invalid Return List", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each item As ReturnItem In SelectedItems
            If item.QuantityToReturn <= 0 OrElse item.QuantityToReturn > item.Outstanding Then
                MessageBox.Show("Check the return quantity for " & item.ItemName & ".", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If item.Condition <> "Good" AndAlso item.Condition <> "Damaged" Then
                MessageBox.Show("Select a valid condition for " & item.ItemName & ".", "Invalid Condition", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        If CurrentLoggedInUserID <= 0 Then
            MessageBox.Show("The logged-in user ID was not provided. Reopen this module through Form1 before recording returns.", "User Not Identified", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalUnits As Integer = SelectedItems.Sum(Function(x) x.QuantityToReturn)
        If MessageBox.Show("Record " & SelectedItems.Count.ToString() & " item return(s), totaling " & totalUnits.ToString() & " unit(s)?", "Confirm Returns", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        For Each item As ReturnItem In SelectedItems
                            Dim issuedQuantity As Integer
                            Dim previouslyReturned As Integer
                            Dim currentItemID As Integer

                            Using checkCmd As New MySqlCommand("SELECT id.ItemID, id.QuantityIssued, id.QuantityReturned, iss.RecepientName FROM issuance_details id INNER JOIN issuances iss ON id.IssuanceID = iss.IssuanceID WHERE id.IssuanceDetailID = @detailID FOR UPDATE", conn, transaction)
                                checkCmd.Parameters.AddWithValue("@detailID", item.IssuanceDetailID)

                                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                                    If Not reader.Read() Then Throw New Exception("The original issuance record for " & item.ItemName & " no longer exists.")

                                    currentItemID = Convert.ToInt32(reader("ItemID"))
                                    issuedQuantity = Convert.ToInt32(reader("QuantityIssued"))
                                    previouslyReturned = Convert.ToInt32(reader("QuantityReturned"))

                                    Dim currentRecipient As String = reader("RecepientName").ToString()
                                    If Not String.Equals(currentRecipient, selectedRecipient, StringComparison.OrdinalIgnoreCase) Then
                                        Throw New Exception("The recipient of " & item.ItemName & " no longer matches the selected return recipient. Please refresh and try again.")
                                    End If
                                End Using
                            End Using

                            Dim currentOutstanding As Integer = issuedQuantity - previouslyReturned
                            If item.QuantityToReturn > currentOutstanding Then Throw New Exception("The outstanding quantity for " & item.ItemName & " has changed. Refresh the list and try again.")

                            Using detailCmd As New MySqlCommand("UPDATE issuance_details SET QuantityReturned = QuantityReturned + @qty WHERE IssuanceDetailID = @detailID AND QuantityReturned + @qty <= QuantityIssued", conn, transaction)
                                detailCmd.Parameters.AddWithValue("@qty", item.QuantityToReturn)
                                detailCmd.Parameters.AddWithValue("@detailID", item.IssuanceDetailID)
                                If detailCmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Could not update the returned quantity for " & item.ItemName & ".")
                            End Using

                            Dim inventoryColumn As String = If(item.Condition = "Good", "AvailableQuantity", "DamagedQuantity")
                            Using inventoryCmd As New MySqlCommand("UPDATE inventory SET " & inventoryColumn & " = " & inventoryColumn & " + @qty WHERE ItemID = @itemID", conn, transaction)
                                inventoryCmd.Parameters.AddWithValue("@qty", item.QuantityToReturn)
                                inventoryCmd.Parameters.AddWithValue("@itemID", currentItemID)
                                If inventoryCmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Could not update inventory for " & item.ItemName & ".")
                            End Using

                            Dim returnID As Long
                            Dim savedRemarks As String = If(item.Remarks, "").Trim()

                            Using returnCmd As New MySqlCommand("INSERT INTO returns (IssuanceDetailID, QuantityReturned, ReturnDate, ReceivedByUserID, ConditionOnReturn, Remarks) VALUES (@detailID, @qty, @returnDate, @userID, @condition, @remarks)", conn, transaction)
                                returnCmd.Parameters.AddWithValue("@detailID", item.IssuanceDetailID)
                                returnCmd.Parameters.AddWithValue("@qty", item.QuantityToReturn)
                                returnCmd.Parameters.AddWithValue("@returnDate", ReturnDateDTP.Value)
                                returnCmd.Parameters.AddWithValue("@userID", CurrentLoggedInUserID)
                                returnCmd.Parameters.AddWithValue("@condition", item.Condition)
                                returnCmd.Parameters.AddWithValue("@remarks", savedRemarks)
                                returnCmd.ExecuteNonQuery()
                                returnID = returnCmd.LastInsertedId
                            End Using

                            Using movementCmd As New MySqlCommand("INSERT INTO stock_movements (ItemID, MovementType, Quantity, MovementDate, User_ID, ReferenceType, ReferenceID, Remarks) VALUES (@itemID, 'Return', @qty, @movementDate, @userID, 'Return', @referenceID, @remarks)", conn, transaction)
                                movementCmd.Parameters.AddWithValue("@itemID", currentItemID)
                                movementCmd.Parameters.AddWithValue("@qty", item.QuantityToReturn)
                                movementCmd.Parameters.AddWithValue("@movementDate", ReturnDateDTP.Value)
                                movementCmd.Parameters.AddWithValue("@userID", CurrentLoggedInUserID)
                                movementCmd.Parameters.AddWithValue("@referenceID", returnID)
                                movementCmd.Parameters.AddWithValue("@remarks", savedRemarks)
                                movementCmd.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Returns recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectedItems.Clear()
            RefreshSelectedItems()
            ClearDetails()
            ReturnDateDTP.Value = DateTime.Now
            LoadOutstandingItems(SearchItemsToReturnTXT.Text)
            SearchReturnHistoryTXT.Clear()
            LoadReturnHistory("")

        Catch ex As Exception
            MessageBox.Show("Failed to record returns: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRemarksBTN_Click(sender As Object, e As EventArgs) Handles UpdateRemarksBTN.Click
        If Not CanProcessReturns() Then Return

        If ItemsForReturnLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item from the return list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim detailID As Integer = Convert.ToInt32(ItemsForReturnLV.SelectedItems(0).Tag)
        Dim selectedItem As ReturnItem = SelectedItems.FirstOrDefault(Function(x) x.IssuanceDetailID = detailID)

        If selectedItem Is Nothing Then Return

        selectedItem.Remarks = RemarksTXT.Text.Trim()

        RefreshSelectedItems()
        SelectQueuedReturnItem(detailID)

        UpdateRemarksBTN.Visible = False

        MessageBox.Show("Remarks updated for " & selectedItem.ItemName & ".", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RemarksTXT_TextChanged(sender As Object, e As EventArgs) Handles RemarksTXT.TextChanged
        If Not CanProcessReturns() Then
            UpdateRemarksBTN.Visible = False
            Return
        End If

        If UpdatingControls OrElse ItemsForReturnLV.SelectedItems.Count = 0 Then Return
        UpdateRemarksBTN.Visible = True
    End Sub

End Class