
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class StockMovementUC
    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Class StockItem
        Public Property ItemID As Integer
        Public Property ItemName As String
        Public Property Available As Integer
        Public Property Damaged As Integer
        Public Property Department As String
        Public Property Location As String
        Public Property QuantityToAdd As Integer
    End Class

    Private AvailableItems As New List(Of StockItem)
    Private SelectedItems As New List(Of StockItem)
    Private IsLoading As Boolean = False

    Private Function CanManageStock() As Boolean
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Return role = "admin" OrElse role = "inventory custodian"
    End Function

    Private Sub ApplyRolePermissions()
        Dim allowed As Boolean = CanManageStock()

        MovementTypeCMB.Enabled = allowed
        StockInDTP.Enabled = allowed
        SearchAvailItemsTXT.Enabled = allowed
        AvailableItemsLV.Enabled = allowed
        AddSelectedBTN.Enabled = allowed
        ItemsToStockInLV.Enabled = allowed
        QuantityToAddTXT.Enabled = allowed
        UpdateQuantityBTN.Enabled = allowed AndAlso ItemsToStockInLV.SelectedItems.Count > 0
        RemoveSelectedBTN.Enabled = allowed
        ClearBTN.Enabled = allowed
        RemarksTXT.Enabled = allowed
        StockInBTN.Enabled = allowed
    End Sub

    Private Sub StockMovementUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MovementTypeCMB.Items.Clear()
        MovementTypeCMB.Items.Add("Stock In")
        MovementTypeCMB.SelectedIndex = 0
        StockInDTP.Value = DateTime.Now
        SetupListViews()
        UpdateQuantityBTN.Visible = False
        ClearFields()
        LoadAvailableItems()
        ApplyRolePermissions()
    End Sub

    Private Sub SetupListViews()
        AvailableItemsLV.View = View.Details
        AvailableItemsLV.FullRowSelect = True
        AvailableItemsLV.GridLines = True
        AvailableItemsLV.MultiSelect = False
        AvailableItemsLV.Columns.Clear()
        AvailableItemsLV.Columns.Add("Item ID", 70)
        AvailableItemsLV.Columns.Add("Item Name", 180)
        AvailableItemsLV.Columns.Add("Available", 90)
        AvailableItemsLV.Columns.Add("Damaged", 90)
        AvailableItemsLV.Columns.Add("Department", 140)
        AvailableItemsLV.Columns.Add("Location", 140)

        ItemsToStockInLV.View = View.Details
        ItemsToStockInLV.FullRowSelect = True
        ItemsToStockInLV.GridLines = True
        ItemsToStockInLV.MultiSelect = False
        ItemsToStockInLV.Columns.Clear()
        ItemsToStockInLV.Columns.Add("Item ID", 70)
        ItemsToStockInLV.Columns.Add("Item Name", 180)
        ItemsToStockInLV.Columns.Add("Available", 90)
        ItemsToStockInLV.Columns.Add("Quantity to Add", 110)
        ItemsToStockInLV.Columns.Add("New Available", 110)
    End Sub

    Private Sub LoadAvailableItems(Optional searchText As String = "")
        AvailableItems.Clear()
        AvailableItemsLV.Items.Clear()

        Using conn As MySqlConnection = Database.GetConnection()
            conn.Open()
            Dim sql As String = "SELECT i.ItemID, i.ItemName, i.AvailableQuantity, i.DamagedQuantity, d.DepartmentName, COALESCE(l.LocationName, '') AS LocationName FROM inventory i INNER JOIN departments d ON i.DepartmentID = d.DepartmentID LEFT JOIN locations l ON i.LocationID = l.LocationID WHERE i.Status = 'Active' AND (i.ItemName LIKE @search OR d.DepartmentName LIKE @search OR COALESCE(l.LocationName, '') LIKE @search) ORDER BY i.ItemName"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchText.Trim() & "%")
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New StockItem With {
                            .ItemID = Convert.ToInt32(reader("ItemID")),
                            .ItemName = reader("ItemName").ToString(),
                            .Available = Convert.ToInt32(reader("AvailableQuantity")),
                            .Damaged = Convert.ToInt32(reader("DamagedQuantity")),
                            .Department = reader("DepartmentName").ToString(),
                            .Location = reader("LocationName").ToString()
                        }
                        AvailableItems.Add(item)
                        Dim row As New ListViewItem(item.ItemID.ToString())
                        row.SubItems.Add(item.ItemName)
                        row.SubItems.Add(item.Available.ToString())
                        row.SubItems.Add(item.Damaged.ToString())
                        row.SubItems.Add(item.Department)
                        row.SubItems.Add(item.Location)
                        AvailableItemsLV.Items.Add(row)
                    End While
                End Using
            End Using
        End Using

        For Each row As ListViewItem In AvailableItemsLV.Items
            If SelectedItems.Any(Function(x) x.ItemID = Convert.ToInt32(row.Text)) Then
                row.ForeColor = Color.Gray
            End If
        Next
    End Sub

    Private Sub SearchAvailableItemsTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchAvailItemsTXT.TextChanged
        If Not CanManageStock() Then Return
        LoadAvailableItems(SearchAvailItemsTXT.Text)
    End Sub

    Private Sub AvailableItemsLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailableItemsLV.SelectedIndexChanged
        If AvailableItemsLV.SelectedItems.Count = 0 Then
            AvailableStocksLBL.Text = "-"
            Return
        End If

        Dim itemID As Integer = Convert.ToInt32(AvailableItemsLV.SelectedItems(0).Text)
        Dim item As StockItem = AvailableItems.FirstOrDefault(Function(x) x.ItemID = itemID)
        If item IsNot Nothing Then AvailableStocksLBL.Text = " " & item.Available.ToString()
    End Sub

    Private Sub AddSelectedBTN_Click(sender As Object, e As EventArgs) Handles AddSelectedBTN.Click
        If Not CanManageStock() Then Return

        If AvailableItemsLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an inventory item first.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim itemID As Integer = Convert.ToInt32(AvailableItemsLV.SelectedItems(0).Text)
        If SelectedItems.Any(Function(x) x.ItemID = itemID) Then
            MessageBox.Show("This item is already in the stock-in list. Select it there to update its quantity.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim source As StockItem = AvailableItems.FirstOrDefault(Function(x) x.ItemID = itemID)
        If source Is Nothing Then Return

        SelectedItems.Add(New StockItem With {
            .ItemID = source.ItemID,
            .ItemName = source.ItemName,
            .Available = source.Available,
            .Damaged = source.Damaged,
            .Department = source.Department,
            .Location = source.Location,
            .QuantityToAdd = 1
        })

        RefreshSelectedItems()
    End Sub

    Private Sub RefreshSelectedItems()
        ItemsToStockInLV.Items.Clear()
        For Each item As StockItem In SelectedItems
            Dim row As New ListViewItem(item.ItemID.ToString())
            row.SubItems.Add(item.ItemName)
            row.SubItems.Add(item.Available.ToString())
            row.SubItems.Add(item.QuantityToAdd.ToString())
            row.SubItems.Add((item.Available + item.QuantityToAdd).ToString())
            ItemsToStockInLV.Items.Add(row)
        Next

        DifferentItemsLBL.Text = " " & SelectedItems.Count.ToString()
        TotalUnitsLBL.Text = " " & SelectedItems.Sum(Function(x) x.QuantityToAdd).ToString()
        UpdateQuantityBTN.Visible = False
    End Sub

    Private Sub ItemsToStockInLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemsToStockInLV.SelectedIndexChanged
        If Not CanManageStock() Then Return

        Dim hasSelection As Boolean = ItemsToStockInLV.SelectedItems.Count > 0
        UpdateQuantityBTN.Visible = hasSelection
        UpdateQuantityBTN.Enabled = hasSelection

        If Not hasSelection Then
            QuantityToAddTXT.Clear()
            Return
        End If

        Dim itemID As Integer = Convert.ToInt32(ItemsToStockInLV.SelectedItems(0).Text)
        Dim item As StockItem = SelectedItems.FirstOrDefault(Function(x) x.ItemID = itemID)

        If item IsNot Nothing Then
            QuantityToAddTXT.Text = item.QuantityToAdd.ToString()
            AvailableStocksLBL.Text = " " & item.Available.ToString()
        End If
    End Sub

    Private Sub UpdateQuantityBTN_Click(sender As Object, e As EventArgs) Handles UpdateQuantityBTN.Click
        If Not CanManageStock() Then Return

        If ItemsToStockInLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an item from the stock-in list first.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(QuantityToAddTXT.Text.Trim(), quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a positive whole number greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            QuantityToAddTXT.Focus()
            Return
        End If

        Dim itemID As Integer = Convert.ToInt32(ItemsToStockInLV.SelectedItems(0).Text)
        Dim item As StockItem = SelectedItems.FirstOrDefault(Function(x) x.ItemID = itemID)
        If item Is Nothing Then Return

        item.QuantityToAdd = quantity
        RefreshSelectedItems()
        QuantityToAddTXT.Clear()
        UpdateQuantityBTN.Visible = False
    End Sub

    Private Sub RemoveSelectedBTN_Click(sender As Object, e As EventArgs) Handles RemoveSelectedBTN.Click
        If Not CanManageStock() Then Return

        If ItemsToStockInLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Select an item from the stock-in list to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim itemID As Integer = Convert.ToInt32(ItemsToStockInLV.SelectedItems(0).Text)
        SelectedItems.RemoveAll(Function(x) x.ItemID = itemID)
        RefreshSelectedItems()
        QuantityToAddTXT.Clear()
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        If Not CanManageStock() Then Return

        If SelectedItems.Count > 0 AndAlso MessageBox.Show("Clear all selected items and quantities?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return
        ClearFields()
        LoadAvailableItems(SearchAvailItemsTXT.Text)
    End Sub

    Private Sub ClearFields()
        SelectedItems.Clear()
        ItemsToStockInLV.Items.Clear()
        QuantityToAddTXT.Clear()
        RemarksTXT.Clear()
        StockInDTP.Value = DateTime.Now
        AvailableStocksLBL.Text = "-"
        DifferentItemsLBL.Text = "0"
        TotalUnitsLBL.Text = "0"
    End Sub

    Private Sub StockInBTN_Click(sender As Object, e As EventArgs) Handles StockInBTN.Click
        If Not CanManageStock() Then Return

        If MovementTypeCMB.Text <> "Stock In" Then
            MessageBox.Show("Only Stock In is implemented currently.", "Movement Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If SelectedItems.Count = 0 Then
            MessageBox.Show("Add at least one item to the stock-in list.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Save this stock-in transaction?", "Confirm Stock In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        For Each item As StockItem In SelectedItems
                            Using updateCmd As New MySqlCommand("UPDATE inventory SET AvailableQuantity = AvailableQuantity + @qty WHERE ItemID = @id AND Status = 'Active'", conn, transaction)
                                updateCmd.Parameters.AddWithValue("@qty", item.QuantityToAdd)
                                updateCmd.Parameters.AddWithValue("@id", item.ItemID)
                                If updateCmd.ExecuteNonQuery() <> 1 Then Throw New Exception("Could not update item: " & item.ItemName)
                            End Using

                            Using movementCmd As New MySqlCommand("INSERT INTO stock_movements (ItemID, MovementType, Quantity, MovementDate, User_ID, ReferenceType, ReferenceID, Remarks) VALUES (@itemID, 'Stock In', @qty, @movementDate, @userID, 'Stock Movement', NULL, @remarks)", conn, transaction)
                                movementCmd.Parameters.AddWithValue("@itemID", item.ItemID)
                                movementCmd.Parameters.AddWithValue("@qty", item.QuantityToAdd)
                                movementCmd.Parameters.AddWithValue("@movementDate", StockInDTP.Value)
                                movementCmd.Parameters.AddWithValue("@userID", If(CurrentLoggedInUserID > 0, CType(CurrentLoggedInUserID, Object), DBNull.Value))
                                movementCmd.Parameters.AddWithValue("@remarks", If(String.IsNullOrWhiteSpace(RemarksTXT.Text), CType(DBNull.Value, Object), RemarksTXT.Text.Trim()))
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

            MessageBox.Show("Stock-in transaction saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadAvailableItems(SearchAvailItemsTXT.Text)

        Catch ex As Exception
            MessageBox.Show("Failed to save stock-in transaction: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuantityToAddTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityToAddTXT.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
