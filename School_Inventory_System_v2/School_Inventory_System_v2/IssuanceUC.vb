Imports MySql.Data.MySqlClient
Imports System.Data

Public Class IssuanceUC

    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Class InventoryItem
        Public Property ItemID As Integer
        Public Property ItemName As String
        Public Property AvailableQuantity As Integer
        Public Property DepartmentName As String
        Public Property LocationName As String
        Public Property Description As String
        Public Property RequestedQuantity As Integer = 1
    End Class

    Private SelectedItems As New List(Of InventoryItem)
    Private CurrentItem As InventoryItem = Nothing
    Private CurrentList As String = ""

    Private Function CanProcessIssuance() As Boolean
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Return role = "admin" OrElse role = "issuance clerk"
    End Function

    Private Sub ApplyRolePermissions()
        Dim canProcess As Boolean = CanProcessIssuance()

        RecepientNameTXT.Enabled = canProcess
        RecepientTypeCMB.Enabled = canProcess
        IssueDateDTP.Enabled = canProcess
        RemarksTXT.Enabled = canProcess
        AddSelectedBTN.Enabled = canProcess
        RemoveSelectedBTN.Enabled = canProcess
        ClearBTN.Enabled = canProcess
        IssueBTN.Enabled = canProcess
        RequestedQuantityTXT.Enabled = False
        UpdateQuantityBTN.Enabled = False
        UpdateQuantityBTN.Visible = False

        SearchAvailItemsTXT.Enabled = True
        AvailableItemsLV.Enabled = True
        SearchSelectedItemsTXT.Enabled = True
        SelectedItemsLV.Enabled = True
    End Sub

    Private Sub IssuanceUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupLists()
        RecepientTypeCMB.Items.Clear()
        RecepientTypeCMB.Items.AddRange(New Object() {"Teacher", "Staff", "Department", "Other"})
        IssueDateDTP.Format = DateTimePickerFormat.Custom
        IssueDateDTP.CustomFormat = "yyyy-MM-dd HH:mm"
        IssueDateDTP.Value = DateTime.Now
        RequestedQuantityTXT.Enabled = False
        UpdateQuantityBTN.Visible = False
        ReloadAvailableItems()
        RefreshSelectedItems()
        ClearItemDetails()
        ApplyRolePermissions()
    End Sub

    Private Sub SetupLists()
        AvailableItemsLV.View = View.Details
        AvailableItemsLV.FullRowSelect = True
        AvailableItemsLV.MultiSelect = False
        AvailableItemsLV.HideSelection = False
        AvailableItemsLV.Columns.Clear()
        AvailableItemsLV.Columns.Add("Item Name", 160)
        AvailableItemsLV.Columns.Add("Available", 75)
        AvailableItemsLV.Columns.Add("Department", 130)
        AvailableItemsLV.Columns.Add("Location", 120)

        SelectedItemsLV.View = View.Details
        SelectedItemsLV.FullRowSelect = True
        SelectedItemsLV.MultiSelect = False
        SelectedItemsLV.HideSelection = False
        SelectedItemsLV.Columns.Clear()
        SelectedItemsLV.Columns.Add("Item Name", 160)
        SelectedItemsLV.Columns.Add("Requested", 85)
        SelectedItemsLV.Columns.Add("Available", 75)
        SelectedItemsLV.Columns.Add("Department", 130)
    End Sub

    Private Sub ReloadAvailableItems()
        AvailableItemsLV.Items.Clear()
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Using cmd As New MySqlCommand("SELECT i.ItemID, i.ItemName, i.AvailableQuantity, i.Description, d.DepartmentName, COALESCE(l.LocationName, 'Unassigned') AS LocationName FROM inventory i INNER JOIN departments d ON i.DepartmentID = d.DepartmentID LEFT JOIN locations l ON i.LocationID = l.LocationID WHERE i.Status = 'Active' AND i.AvailableQuantity > 0 AND (i.ItemName LIKE @search OR d.DepartmentName LIKE @search OR COALESCE(l.LocationName, '') LIKE @search) ORDER BY i.ItemName", conn)
                    cmd.Parameters.AddWithValue("@search", "%" & SearchAvailItemsTXT.Text.Trim() & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New InventoryItem With {
                                .ItemID = Convert.ToInt32(reader("ItemID")),
                                .ItemName = reader("ItemName").ToString(),
                                .AvailableQuantity = Convert.ToInt32(reader("AvailableQuantity")),
                                .DepartmentName = reader("DepartmentName").ToString(),
                                .LocationName = reader("LocationName").ToString(),
                                .Description = If(reader("Description") Is DBNull.Value, "", reader("Description").ToString())
                            }
                            Dim row As New ListViewItem(item.ItemName)
                            row.SubItems.Add(item.AvailableQuantity.ToString())
                            row.SubItems.Add(item.DepartmentName)
                            row.SubItems.Add(item.LocationName)
                            row.Tag = item
                            AvailableItemsLV.Items.Add(row)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load available inventory: " & ex.Message, "Inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshSelectedItems()
        SelectedItemsLV.Items.Clear()
        Dim search As String = SearchSelectedItemsTXT.Text.Trim().ToLower()
        For Each item As InventoryItem In SelectedItems
            If item.ItemName.ToLower().Contains(search) OrElse item.DepartmentName.ToLower().Contains(search) Then
                Dim row As New ListViewItem(item.ItemName)
                row.SubItems.Add(item.RequestedQuantity.ToString())
                row.SubItems.Add(item.AvailableQuantity.ToString())
                row.SubItems.Add(item.DepartmentName)
                row.Tag = item
                SelectedItemsLV.Items.Add(row)
            End If
        Next
        SelectedItemsQuantityLBL.Text = SelectedItems.Count.ToString()
        TotalQuantityOfAllSelectedItemsLBL.Text = SelectedItems.Sum(Function(i) i.RequestedQuantity).ToString()
    End Sub

    Private Sub SearchAvailItemsTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchAvailItemsTXT.TextChanged
        ReloadAvailableItems()
        ClearItemDetails()
    End Sub

    Private Sub SearchSelectedItemsTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchSelectedItemsTXT.TextChanged
        RefreshSelectedItems()
        ClearItemDetails()
    End Sub

    Private Sub AvailableItemsLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailableItemsLV.SelectedIndexChanged
        If AvailableItemsLV.SelectedItems.Count = 0 Then Return
        CurrentItem = DirectCast(AvailableItemsLV.SelectedItems(0).Tag, InventoryItem)
        CurrentList = "Available"
        DisplayItemDetails(CurrentItem, False)
    End Sub

    Private Sub SelectedItemsLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedItemsLV.SelectedIndexChanged
        If SelectedItemsLV.SelectedItems.Count = 0 Then Return
        CurrentItem = DirectCast(SelectedItemsLV.SelectedItems(0).Tag, InventoryItem)
        CurrentList = "Selected"
        DisplayItemDetails(CurrentItem, True)
    End Sub

    Private Sub DisplayItemDetails(item As InventoryItem, canEditQuantity As Boolean)
        Dim canEdit As Boolean = canEditQuantity AndAlso CanProcessIssuance()
        ItemNameLBL.Text = item.ItemName
        QuantityLBL.Text = item.AvailableQuantity.ToString() & If(canEdit, " | Requested: " & item.RequestedQuantity.ToString(), "")
        DepartmentNameLBL.Text = item.DepartmentName
        ItemDescriptionLBL.Text = If(String.IsNullOrWhiteSpace(item.Description), "No description available.", item.Description)
        RequestedQuantityTXT.Enabled = canEdit
        RequestedQuantityTXT.Text = If(canEdit, item.RequestedQuantity.ToString(), "")
        UpdateQuantityBTN.Visible = False
        UpdateQuantityBTN.Enabled = canEdit
    End Sub

    Private Sub ClearItemDetails()
        CurrentItem = Nothing
        CurrentList = ""
        ItemNameLBL.Text = ""
        QuantityLBL.Text = ""
        DepartmentNameLBL.Text = ""
        ItemDescriptionLBL.Text = ""
        RequestedQuantityTXT.Clear()
        RequestedQuantityTXT.Enabled = False
        UpdateQuantityBTN.Visible = False
        UpdateQuantityBTN.Enabled = False
    End Sub

    Private Sub RequestedQuantityTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RequestedQuantityTXT.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub RequestedQuantityTXT_TextChanged(sender As Object, e As EventArgs) Handles RequestedQuantityTXT.TextChanged
        If Not CanProcessIssuance() OrElse CurrentItem Is Nothing OrElse CurrentList <> "Selected" Then
            UpdateQuantityBTN.Visible = False
            Return
        End If
        Dim quantity As Integer
        UpdateQuantityBTN.Visible = Integer.TryParse(RequestedQuantityTXT.Text, quantity) AndAlso quantity > 0 AndAlso quantity <> CurrentItem.RequestedQuantity
    End Sub

    Private Sub AddSelectedBTN_Click(sender As Object, e As EventArgs) Handles AddSelectedBTN.Click
        If Not CanProcessIssuance() Then Return

        If AvailableItemsLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an available inventory item first.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim item As InventoryItem = DirectCast(AvailableItemsLV.SelectedItems(0).Tag, InventoryItem)
        Dim existing As InventoryItem = SelectedItems.FirstOrDefault(Function(i) i.ItemID = item.ItemID)
        If existing IsNot Nothing Then
            MessageBox.Show("This item is already in the issuance list. Select it there to change its quantity.", "Item Already Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectItemInList(SelectedItemsLV, existing.ItemID)
            Return
        End If
        If item.AvailableQuantity < 1 Then
            MessageBox.Show("This item has no available stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ReloadAvailableItems()
            Return
        End If
        item.RequestedQuantity = 1
        SelectedItems.Add(item)
        RefreshSelectedItems()
        ClearItemDetails()
    End Sub

    Private Sub RemoveSelectedBTN_Click(sender As Object, e As EventArgs) Handles RemoveSelectedBTN.Click
        If Not CanProcessIssuance() Then Return

        If SelectedItemsLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an item from the issuance list first.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim item As InventoryItem = DirectCast(SelectedItemsLV.SelectedItems(0).Tag, InventoryItem)
        SelectedItems.RemoveAll(Function(i) i.ItemID = item.ItemID)
        RefreshSelectedItems()
        ClearItemDetails()
    End Sub

    Private Sub UpdateQuantityBTN_Click(sender As Object, e As EventArgs) Handles UpdateQuantityBTN.Click
        If Not CanProcessIssuance() Then Return
        If CurrentItem Is Nothing OrElse CurrentList <> "Selected" Then Return
        Dim quantity As Integer
        If Not Integer.TryParse(RequestedQuantityTXT.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a whole number greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If quantity > CurrentItem.AvailableQuantity Then
            MessageBox.Show("The requested quantity cannot exceed the available stock of " & CurrentItem.AvailableQuantity & ".", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        CurrentItem.RequestedQuantity = quantity
        RefreshSelectedItems()
        DisplayItemDetails(CurrentItem, True)
        SelectItemInList(SelectedItemsLV, CurrentItem.ItemID)
        UpdateQuantityBTN.Visible = False
    End Sub

    Private Sub SelectItemInList(list As ListView, itemID As Integer)
        For Each row As ListViewItem In list.Items
            Dim item As InventoryItem = TryCast(row.Tag, InventoryItem)
            If item IsNot Nothing AndAlso item.ItemID = itemID Then
                row.Selected = True
                row.Focused = True
                row.EnsureVisible()
                Exit For
            End If
        Next
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        If Not CanProcessIssuance() Then Return

        If MessageBox.Show("Clear the recipient information and all selected items?", "Clear Issuance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        RecepientNameTXT.Clear()
        RecepientTypeCMB.SelectedIndex = -1
        IssueDateDTP.Value = DateTime.Now
        RemarksTXT.Clear()
        SelectedItems.Clear()
        SearchAvailItemsTXT.Clear()
        SearchSelectedItemsTXT.Clear()
        RefreshSelectedItems()
        ReloadAvailableItems()
        ClearItemDetails()
    End Sub

    Private Sub IssueBTN_Click(sender As Object, e As EventArgs) Handles IssueBTN.Click
        If Not CanProcessIssuance() Then Return

        If String.IsNullOrWhiteSpace(RecepientNameTXT.Text) Then
            MessageBox.Show("Enter the recipient name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RecepientNameTXT.Focus()
            Return
        End If
        If RecepientTypeCMB.SelectedIndex < 0 Then
            MessageBox.Show("Select a recipient type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RecepientTypeCMB.Focus()
            Return
        End If
        If SelectedItems.Count = 0 Then
            MessageBox.Show("Add at least one item before issuing.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If CurrentLoggedInUserID <= 0 Then
            MessageBox.Show("The logged-in user could not be identified. Please log in again.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If MessageBox.Show("Issue " & SelectedItems.Count & " different item(s), totaling " & SelectedItems.Sum(Function(i) i.RequestedQuantity) & " unit(s), to " & RecepientNameTXT.Text.Trim() & "?", "Confirm Issuance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        For Each item As InventoryItem In SelectedItems
                            Using checkCmd As New MySqlCommand("SELECT AvailableQuantity, Status FROM inventory WHERE ItemID = @id FOR UPDATE", conn, transaction)
                                checkCmd.Parameters.AddWithValue("@id", item.ItemID)
                                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                                    If Not reader.Read() Then Throw New Exception("An item no longer exists in inventory: " & item.ItemName)
                                    If reader("Status").ToString() <> "Active" OrElse Convert.ToInt32(reader("AvailableQuantity")) < item.RequestedQuantity Then Throw New Exception("Insufficient stock for " & item.ItemName & ". Please refresh the item list and try again.")
                                End Using
                            End Using
                        Next

                        Dim issuanceID As Integer
                        Using cmd As New MySqlCommand("INSERT INTO issuances (RecepientName, RecepientType, IssuedByUserID, IssueDate, Status, Remarks) VALUES (@name, @type, @user, @date, 'Issued', @remarks)", conn, transaction)
                            cmd.Parameters.AddWithValue("@name", RecepientNameTXT.Text.Trim())
                            cmd.Parameters.AddWithValue("@type", RecepientTypeCMB.Text)
                            cmd.Parameters.AddWithValue("@user", CurrentLoggedInUserID)
                            cmd.Parameters.AddWithValue("@date", IssueDateDTP.Value)
                            cmd.Parameters.AddWithValue("@remarks", If(String.IsNullOrWhiteSpace(RemarksTXT.Text), CType(DBNull.Value, Object), RemarksTXT.Text.Trim()))
                            cmd.ExecuteNonQuery()
                        End Using
                        Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction)
                            issuanceID = Convert.ToInt32(cmd.ExecuteScalar())
                        End Using

                        For Each item As InventoryItem In SelectedItems
                            Using cmd As New MySqlCommand("INSERT INTO issuance_details (IssuanceID, ItemID, QuantityIssued, QuantityReturned) VALUES (@issuance, @item, @quantity, 0)", conn, transaction)
                                cmd.Parameters.AddWithValue("@issuance", issuanceID)
                                cmd.Parameters.AddWithValue("@item", item.ItemID)
                                cmd.Parameters.AddWithValue("@quantity", item.RequestedQuantity)
                                cmd.ExecuteNonQuery()
                            End Using
                            Using cmd As New MySqlCommand("UPDATE inventory SET AvailableQuantity = AvailableQuantity - @quantity WHERE ItemID = @item AND Status = 'Active' AND AvailableQuantity >= @quantity", conn, transaction)
                                cmd.Parameters.AddWithValue("@quantity", item.RequestedQuantity)
                                cmd.Parameters.AddWithValue("@item", item.ItemID)
                                If cmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Stock changed while issuing " & item.ItemName & ". No changes were saved.")
                            End Using
                            Using cmd As New MySqlCommand("INSERT INTO stock_movements (ItemID, MovementType, Quantity, User_ID, ReferenceType, ReferenceID, Remarks) VALUES (@item, 'Issue', @quantity, @user, 'Issuance', @reference, @remarks)", conn, transaction)
                                cmd.Parameters.AddWithValue("@item", item.ItemID)
                                cmd.Parameters.AddWithValue("@quantity", item.RequestedQuantity)
                                cmd.Parameters.AddWithValue("@user", CurrentLoggedInUserID)
                                cmd.Parameters.AddWithValue("@reference", issuanceID)
                                cmd.Parameters.AddWithValue("@remarks", "Issuance to " & RecepientNameTXT.Text.Trim())
                                cmd.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Issuance recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SelectedItems.Clear()
            RecepientNameTXT.Clear()
            RecepientTypeCMB.SelectedIndex = -1
            IssueDateDTP.Value = DateTime.Now
            RemarksTXT.Clear()
            SearchAvailItemsTXT.Clear()
            SearchSelectedItemsTXT.Clear()
            RefreshSelectedItems()
            ReloadAvailableItems()
            ClearItemDetails()
        Catch ex As Exception
            MessageBox.Show("Issuance failed: " & ex.Message, "Issuance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReloadAvailableItems()
        End Try
    End Sub

End Class