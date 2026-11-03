
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Public Class InventoryManagementUC

    Public Property CurrentUserRole As String = ""

    Private isAdding As Boolean = False
    Private isEditing As Boolean = False
    Private selectedItemID As Integer = 0
    Private isLoading As Boolean = False
    Private selectedImageSource As String = ""

    Private Function CanManageInventory() As Boolean
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Return role = "admin" OrElse role = "inventory custodian"
    End Function

    Private Function CanDeleteInventory() As Boolean
        Return CurrentUserRole.Trim().ToLowerInvariant() = "admin"
    End Function

    Private Sub InventoryManagementUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoading = True
        InventoryLV.View = View.Details
        InventoryLV.FullRowSelect = True
        InventoryLV.GridLines = True
        InventoryLV.MultiSelect = False
        InventoryLV.HideSelection = False
        ItemDescTXT.Multiline = True
        AvailableQtyTXT.ReadOnly = True
        DamagedQtyTXT.ReadOnly = True
        ItemPB.SizeMode = PictureBoxSizeMode.Zoom
        StatusCMB.Items.Clear()
        StatusCMB.Items.Add("Active")
        StatusCMB.Items.Add("Inactive")
        LoadDepartments()
        LoadLocations()
        LoadInventory()
        ClearDetails()
        SetViewState()
        isLoading = False
    End Sub

    ' Find the Images folder beside the solution or application folder.
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

    ' Resolve a stored image path.
    Private Function ResolveImagePath(imagePath As String) As String
        If String.IsNullOrWhiteSpace(imagePath) Then Return ""
        If Path.IsPathRooted(imagePath) Then Return imagePath
        Return Path.Combine(Directory.GetParent(GetImagesFolder()).FullName, imagePath.Replace("/"c, Path.DirectorySeparatorChar))
    End Function

    ' Copy the selected image into Images\Inventory.
    Private Function SaveSelectedImage() As String
        If String.IsNullOrWhiteSpace(selectedImageSource) Then Return ""
        Dim inventoryFolder As String = Path.Combine(GetImagesFolder(), "Inventory")
        Directory.CreateDirectory(inventoryFolder)
        Dim extension As String = Path.GetExtension(selectedImageSource)
        Dim fileName As String = Guid.NewGuid().ToString() & extension
        File.Copy(selectedImageSource, Path.Combine(inventoryFolder, fileName), False)
        Return Path.Combine("Images", "Inventory", fileName)
    End Function

    ' Display an inventory item's image.
    Private Sub DisplayItemImage(imagePath As String)
        If ItemPB.Image IsNot Nothing Then
            Dim oldImage As Image = ItemPB.Image
            ItemPB.Image = Nothing
            oldImage.Dispose()
        End If
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

    ' Browse and preview an image.
    Private Sub BrowseImageBTN_Click(sender As Object, e As EventArgs) Handles BrowseImageBTN.Click
        If Not CanManageInventory() Then Return

        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Inventory Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.Multiselect = False
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Using img As Image = Image.FromFile(ofd.FileName)
                        Dim preview As New Bitmap(img)
                        If ItemPB.Image IsNot Nothing Then
                            Dim oldImage As Image = ItemPB.Image
                            ItemPB.Image = Nothing
                            oldImage.Dispose()
                        End If
                        ItemPB.SizeMode = PictureBoxSizeMode.Zoom
                        ItemPB.Image = preview
                    End Using
                    selectedImageSource = ofd.FileName
                Catch ex As Exception
                    MessageBox.Show("Unable to load the selected image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub LoadDepartments()
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Using cmd As New MySqlCommand("SELECT DepartmentID, DepartmentName FROM departments WHERE Status = 'Active' ORDER BY DepartmentName", conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        DepartmentCMB.DataSource = Nothing
                        DepartmentCMB.DisplayMember = "DepartmentName"
                        DepartmentCMB.ValueMember = "DepartmentID"
                        DepartmentCMB.DataSource = dt
                        DepartmentCMB.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLocations(Optional departmentID As Integer = 0)
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT LocationID, LocationName FROM locations WHERE Status = 'Active'"
                If departmentID > 0 Then sql &= " AND DepartmentID = @DepartmentID"
                sql &= " ORDER BY LocationName"
                Using cmd As New MySqlCommand(sql, conn)
                    If departmentID > 0 Then cmd.Parameters.AddWithValue("@DepartmentID", departmentID)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        Dim noLocation As DataRow = dt.NewRow()
                        noLocation("LocationID") = 0
                        noLocation("LocationName") = "-- No Location --"
                        dt.Rows.InsertAt(noLocation, 0)
                        LocationCMB.DataSource = Nothing
                        LocationCMB.DisplayMember = "LocationName"
                        LocationCMB.ValueMember = "LocationID"
                        LocationCMB.DataSource = dt
                        LocationCMB.SelectedValue = 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load locations: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DepartmentCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentCMB.SelectedIndexChanged
        If isLoading OrElse isAdding OrElse isEditing Then
            If DepartmentCMB.SelectedValue IsNot Nothing AndAlso TypeOf DepartmentCMB.SelectedValue Is Integer Then
                LoadLocations(CInt(DepartmentCMB.SelectedValue))
            End If
            Return
        End If
        If DepartmentCMB.SelectedValue IsNot Nothing AndAlso TypeOf DepartmentCMB.SelectedValue Is Integer Then
            LoadLocations(CInt(DepartmentCMB.SelectedValue))
        Else
            LoadLocations()
        End If
    End Sub

    Private Sub SearchTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchTXT.TextChanged
        If isLoading Then Return
        selectedItemID = 0
        ClearDetails()
        SetViewState()
        LoadInventory()
    End Sub

    Private Sub LoadInventory()
        Try
            InventoryLV.Items.Clear()
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT i.ItemID, i.ItemName, i.AvailableQuantity, i.DamagedQuantity, d.DepartmentName, l.LocationName, i.Status FROM inventory i INNER JOIN departments d ON i.DepartmentID = d.DepartmentID LEFT JOIN locations l ON i.LocationID = l.LocationID WHERE i.ItemName LIKE @Search OR d.DepartmentName LIKE @Search OR l.LocationName LIKE @Search OR i.Status LIKE @Search ORDER BY i.ItemName"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & SearchTXT.Text.Trim() & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("ItemName").ToString())
                            item.SubItems.Add(reader("AvailableQuantity").ToString())
                            item.SubItems.Add(reader("DamagedQuantity").ToString())
                            item.SubItems.Add(reader("DepartmentName").ToString())
                            item.SubItems.Add(If(IsDBNull(reader("LocationName")), "—", reader("LocationName").ToString()))
                            item.SubItems.Add(reader("Status").ToString())
                            item.Tag = Convert.ToInt32(reader("ItemID"))
                            InventoryLV.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load inventory: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InventoryLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InventoryLV.SelectedIndexChanged
        If isLoading OrElse isAdding OrElse isEditing OrElse InventoryLV.SelectedItems.Count = 0 Then Return
        selectedItemID = CInt(InventoryLV.SelectedItems(0).Tag)
        selectedImageSource = ""
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT * FROM inventory WHERE ItemID = @ID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedItemID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            isLoading = True
                            ItemNameTXT.Text = reader("ItemName").ToString()
                            ItemDescTXT.Text = If(IsDBNull(reader("Description")), "", reader("Description").ToString())
                            AvailableQtyTXT.Text = reader("AvailableQuantity").ToString()
                            DamagedQtyTXT.Text = reader("DamagedQuantity").ToString()
                            StatusCMB.Text = reader("Status").ToString()
                            DepartmentCMB.SelectedValue = Convert.ToInt32(reader("DepartmentID"))
                            LoadLocations(Convert.ToInt32(reader("DepartmentID")))
                            If IsDBNull(reader("LocationID")) Then
                                LocationCMB.SelectedValue = 0
                            Else
                                LocationCMB.SelectedValue = Convert.ToInt32(reader("LocationID"))
                            End If
                            Dim imagePath As String = ""
                            If Not IsDBNull(reader("ImagePath")) Then imagePath = reader("ImagePath").ToString()
                            DisplayItemImage(imagePath)
                            isLoading = False
                        End If
                    End Using
                End Using
            End Using
            SetViewState()
        Catch ex As Exception
            isLoading = False
            MessageBox.Show("Failed to load item details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearDetails()
        ItemNameTXT.Clear()
        ItemDescTXT.Clear()
        AvailableQtyTXT.Text = "0"
        DamagedQtyTXT.Text = "0"
        DepartmentCMB.SelectedIndex = -1
        LocationCMB.SelectedValue = 0
        StatusCMB.SelectedIndex = -1
        selectedImageSource = ""
        DisplayItemImage("")
    End Sub

    Private Function ValidateItem() As Boolean
        If String.IsNullOrWhiteSpace(ItemNameTXT.Text) Then
            MessageBox.Show("Please enter an item name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ItemNameTXT.Focus()
            Return False
        End If
        If DepartmentCMB.SelectedValue Is Nothing OrElse Not TypeOf DepartmentCMB.SelectedValue Is Integer Then
            MessageBox.Show("Please select a department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DepartmentCMB.Focus()
            Return False
        End If
        If StatusCMB.SelectedIndex = -1 Then
            MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            StatusCMB.Focus()
            Return False
        End If
        If LocationCMB.SelectedValue IsNot Nothing AndAlso TypeOf LocationCMB.SelectedValue Is Integer AndAlso CInt(LocationCMB.SelectedValue) > 0 Then
            Try
                Using conn As MySqlConnection = Database.GetConnection()
                    If conn.State <> ConnectionState.Open Then conn.Open()
                    Using cmd As New MySqlCommand("SELECT COUNT(*) FROM locations WHERE LocationID = @LocationID AND DepartmentID = @DepartmentID", conn)
                        cmd.Parameters.AddWithValue("@LocationID", CInt(LocationCMB.SelectedValue))
                        cmd.Parameters.AddWithValue("@DepartmentID", CInt(DepartmentCMB.SelectedValue))
                        If Convert.ToInt32(cmd.ExecuteScalar()) = 0 Then
                            MessageBox.Show("The selected location does not belong to the selected department.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to validate the location: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
        Return True
    End Function

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        If Not CanManageInventory() Then Return

        If isAdding Then
            SaveItem()
            Return
        End If
        isAdding = True
        isEditing = False
        selectedItemID = 0
        InventoryLV.SelectedItems.Clear()
        ClearDetails()
        SetViewState()
        ItemNameTXT.Focus()
    End Sub

    Private Sub SaveItem()
        If Not CanManageInventory() Then Return
        If Not ValidateItem() Then Return
        Dim savedImagePath As String = ""
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim checkSql As String = "SELECT COUNT(*) FROM inventory WHERE LOWER(TRIM(ItemName)) = LOWER(TRIM(@Name))"
                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@Name", ItemNameTXT.Text.Trim())
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("An inventory item with this name already exists. Please use a different name.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ItemNameTXT.Focus()
                        ItemNameTXT.SelectAll()
                        Return
                    End If
                End Using

                If Not String.IsNullOrWhiteSpace(selectedImageSource) Then savedImagePath = SaveSelectedImage()

                Dim sql As String = "INSERT INTO inventory (ItemName, Description, AvailableQuantity, DamagedQuantity, DepartmentID, LocationID, Status, ImagePath) VALUES (@Name, @Description, 1, 0, @DepartmentID, @LocationID, @Status, @ImagePath)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", ItemNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrWhiteSpace(ItemDescTXT.Text), CType(DBNull.Value, Object), ItemDescTXT.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DepartmentID", CInt(DepartmentCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@LocationID", GetSelectedLocationID())
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.Text)
                    cmd.Parameters.AddWithValue("@ImagePath", If(String.IsNullOrWhiteSpace(savedImagePath), CType(DBNull.Value, Object), savedImagePath))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Inventory item added successfully. Initial available quantity is set to 1.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FinishEdit()
        Catch ex As MySqlException
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to add item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to add item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditBTN_Click(sender As Object, e As EventArgs) Handles EditBTN.Click
        If Not CanManageInventory() Then Return

        If isEditing Then
            UpdateItem()
            Return
        End If
        If isAdding Then Return
        If InventoryLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an inventory item to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        isEditing = True
        selectedImageSource = ""
        SetViewState()
    End Sub

    Private Sub UpdateItem()
        If Not CanManageInventory() Then Return
        If selectedItemID = 0 OrElse Not ValidateItem() Then Return
        Dim savedImagePath As String = ""
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()

                Dim checkSql As String = "SELECT COUNT(*) FROM inventory WHERE LOWER(TRIM(ItemName)) = LOWER(TRIM(@Name)) AND ItemID <> @ID"
                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@Name", ItemNameTXT.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@ID", selectedItemID)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Another inventory item with this name already exists. Please use a different name.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ItemNameTXT.Focus()
                        ItemNameTXT.SelectAll()
                        Return
                    End If
                End Using

                If Not String.IsNullOrWhiteSpace(selectedImageSource) Then savedImagePath = SaveSelectedImage()

                Dim sql As String = "UPDATE inventory SET ItemName = @Name, Description = @Description, DepartmentID = @DepartmentID, LocationID = @LocationID, Status = @Status"
                If Not String.IsNullOrWhiteSpace(savedImagePath) Then sql &= ", ImagePath = @ImagePath"
                sql &= " WHERE ItemID = @ID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", ItemNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrWhiteSpace(ItemDescTXT.Text), CType(DBNull.Value, Object), ItemDescTXT.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DepartmentID", CInt(DepartmentCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@LocationID", GetSelectedLocationID())
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.Text)
                    cmd.Parameters.AddWithValue("@ID", selectedItemID)
                    If Not String.IsNullOrWhiteSpace(savedImagePath) Then cmd.Parameters.AddWithValue("@ImagePath", savedImagePath)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Inventory item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FinishEdit()
        Catch ex As MySqlException
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to update item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to update item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteSavedImage(imagePath As String)
        If String.IsNullOrWhiteSpace(imagePath) Then Return
        Try
            Dim fullPath As String = ResolveImagePath(imagePath)
            If File.Exists(fullPath) Then File.Delete(fullPath)
        Catch
            ' Ignore cleanup errors.
        End Try
    End Sub

    Private Function GetSelectedLocationID() As Object
        If LocationCMB.SelectedValue Is Nothing OrElse Not TypeOf LocationCMB.SelectedValue Is Integer OrElse CInt(LocationCMB.SelectedValue) = 0 Then Return DBNull.Value
        Return CInt(LocationCMB.SelectedValue)
    End Function

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        If Not CanDeleteInventory() Then Return
        If isAdding OrElse isEditing Then Return
        If InventoryLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an inventory item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim itemID As Integer = CInt(InventoryLV.SelectedItems(0).Tag)
        Dim itemName As String = InventoryLV.SelectedItems(0).Text
        If MessageBox.Show("Are you sure you want to delete '" & itemName & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM inventory WHERE ItemID = @ID", conn)
                    cmd.Parameters.AddWithValue("@ID", itemID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Inventory item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FinishEdit()
        Catch ex As MySqlException When ex.Number = 1451
            MessageBox.Show("This item cannot be deleted because it is referenced by stock movements, issuances, returns, or maintenance records.", "Deletion Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Failed to delete item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        FinishEdit()
    End Sub

    Private Sub FinishEdit()
        isAdding = False
        isEditing = False
        selectedItemID = 0
        selectedImageSource = ""
        ClearDetails()
        LoadInventory()
        SetViewState()
    End Sub

    Private Sub SetViewState()
        Dim editing As Boolean = isAdding OrElse isEditing
        Dim role As String = CurrentUserRole.Trim().ToLowerInvariant()
        Dim canManage As Boolean = role = "admin" OrElse role = "inventory custodian"
        Dim canDelete As Boolean = role = "admin"

        ItemNameTXT.Enabled = editing AndAlso canManage
        ItemDescTXT.Enabled = editing AndAlso canManage
        DepartmentCMB.Enabled = editing AndAlso canManage
        LocationCMB.Enabled = editing AndAlso canManage
        StatusCMB.Enabled = editing AndAlso canManage
        AvailableQtyTXT.ReadOnly = True
        DamagedQtyTXT.ReadOnly = True
        BrowseImageBTN.Enabled = editing AndAlso canManage
        SearchTXT.Enabled = Not editing
        InventoryLV.Enabled = Not editing

        AddBTN.Enabled = canManage
        EditBTN.Enabled = canManage AndAlso Not isAdding AndAlso (isEditing OrElse InventoryLV.SelectedItems.Count > 0)
        DeleteBTN.Enabled = canDelete AndAlso Not editing AndAlso InventoryLV.SelectedItems.Count > 0
        CancelBTN.Visible = editing AndAlso canManage

        If isAdding Then
            AddBTN.Text = "Save"
            EditBTN.Enabled = False
            DeleteBTN.Enabled = False
        Else
            AddBTN.Text = "Add"
        End If

        If isEditing Then
            EditBTN.Text = "Update"
            AddBTN.Enabled = False
            DeleteBTN.Enabled = False
        Else
            EditBTN.Text = "Edit"
        End If
    End Sub

End Class
