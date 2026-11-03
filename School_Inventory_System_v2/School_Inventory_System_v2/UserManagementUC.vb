
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Public Class UserManagementUC
    Private isAdding As Boolean = False
    Private isEditing As Boolean = False
    Private selectedUserID As Integer = 0
    Private selectedImageSource As String = ""

    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Function CanManageUsers() As Boolean
        Return CurrentUserRole.Trim().ToLowerInvariant() = "admin"
    End Function

    Private Sub UserManagementUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLV.View = View.Details
        UserLV.FullRowSelect = True
        UserLV.GridLines = True
        UserLV.MultiSelect = False
        UserLV.HideSelection = False
        UserLV.Columns.Clear()
        UserLV.Columns.Add("Full Name", 180)
        UserLV.Columns.Add("Username", 120)
        UserLV.Columns.Add("Role", 110)
        UserLV.Columns.Add("Status", 90)
        PasswordTXT.UseSystemPasswordChar = True
        StatusCMB.Items.Clear()
        StatusCMB.Items.Add("Active")
        StatusCMB.Items.Add("Inactive")
        CancelBTN.Visible = False
        LoadRoles()
        LoadUsers()
        SetViewState()
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

    Private Function SaveSelectedImage() As String
        If String.IsNullOrWhiteSpace(selectedImageSource) Then Return ""
        Dim usersFolder As String = Path.Combine(GetImagesFolder(), "Users")
        Directory.CreateDirectory(usersFolder)
        Dim extension As String = Path.GetExtension(selectedImageSource)
        Dim fileName As String = Guid.NewGuid().ToString() & extension
        Dim destination As String = Path.Combine(usersFolder, fileName)
        File.Copy(selectedImageSource, destination, False)
        Return Path.Combine("Images", "Users", fileName)
    End Function

    Private Sub DisplayProfileImage(imagePath As String)
        If UserPB.Image IsNot Nothing Then
            Dim oldImage As Image = UserPB.Image
            UserPB.Image = Nothing
            oldImage.Dispose()
        End If
        UserPB.SizeMode = PictureBoxSizeMode.Zoom
        If String.IsNullOrWhiteSpace(imagePath) Then Return
        Dim fullPath As String = ResolveImagePath(imagePath)
        If Not File.Exists(fullPath) Then Return
        Try
            Using img As Image = Image.FromFile(fullPath)
                UserPB.Image = New Bitmap(img)
            End Using
        Catch
            ' Ignore invalid or unreadable image files.
        End Try
    End Sub

    Private Sub BrowseImageBTN_Click(sender As Object, e As EventArgs) Handles BrowseImageBTN.Click
        If Not CanManageUsers() OrElse (Not isAdding AndAlso Not isEditing) Then Return

        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Profile Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.Multiselect = False
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Using img As Image = Image.FromFile(ofd.FileName)
                        Dim preview As New Bitmap(img)
                        If UserPB.Image IsNot Nothing Then
                            Dim oldImage As Image = UserPB.Image
                            UserPB.Image = Nothing
                            oldImage.Dispose()
                        End If
                        UserPB.SizeMode = PictureBoxSizeMode.Zoom
                        UserPB.Image = preview
                    End Using
                    selectedImageSource = ofd.FileName
                Catch ex As Exception
                    MessageBox.Show("Unable to load the selected image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub LoadRoles()
        Try
            Dim dt As New DataTable()
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT Role_ID, RoleName FROM roles ORDER BY RoleName"
                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            RoleCMB.DataSource = Nothing
            RoleCMB.DisplayMember = "RoleName"
            RoleCMB.ValueMember = "Role_ID"
            RoleCMB.DataSource = dt
            RoleCMB.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Failed to load roles: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadUsers()
        Try
            UserLV.Items.Clear()
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT u.User_ID, u.FullName, u.Username, r.RoleName, u.Status FROM users u INNER JOIN roles r ON u.Role_ID = r.Role_ID WHERE u.FullName LIKE @Search OR u.Username LIKE @Search OR r.RoleName LIKE @Search OR u.Status LIKE @Search ORDER BY u.FullName"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & SearchTXT.Text.Trim() & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("FullName").ToString())
                            item.SubItems.Add(reader("Username").ToString())
                            item.SubItems.Add(reader("RoleName").ToString())
                            item.SubItems.Add(reader("Status").ToString())
                            item.Tag = Convert.ToInt32(reader("User_ID"))
                            UserLV.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchTXT_TextChanged(sender As Object, e As EventArgs) Handles SearchTXT.TextChanged
        If Not isAdding AndAlso Not isEditing Then LoadUsers()
    End Sub

    Private Sub UserLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserLV.SelectedIndexChanged
        If isAdding OrElse isEditing Then Return
        If UserLV.SelectedItems.Count = 0 Then Return
        selectedUserID = CInt(UserLV.SelectedItems(0).Tag)
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "SELECT FullName, Username, Role_ID, Status, ProfileImagePath FROM users WHERE User_ID = @ID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", selectedUserID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            FullNameTXT.Text = reader("FullName").ToString()
                            UsernameTXT.Text = reader("Username").ToString()
                            PasswordTXT.Clear()
                            RoleCMB.SelectedValue = Convert.ToInt32(reader("Role_ID"))
                            StatusCMB.SelectedItem = reader("Status").ToString()
                            Dim imagePath As String = ""
                            If Not IsDBNull(reader("ProfileImagePath")) Then imagePath = reader("ProfileImagePath").ToString()
                            DisplayProfileImage(imagePath)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load user details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        If Not CanManageUsers() Then Return
        If isAdding Then
            SaveNewUser()
            Return
        End If
        If isEditing Then Return
        isAdding = True
        selectedUserID = 0
        selectedImageSource = ""
        ClearDetails()
        UserLV.SelectedItems.Clear()
        SetViewState()
    End Sub

    Private Sub EditBTN_Click(sender As Object, e As EventArgs) Handles EditBTN.Click
        If Not CanManageUsers() Then Return
        If isEditing Then
            UpdateUser()
            Return
        End If
        If isAdding Then Return
        If UserLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a user first.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        isEditing = True
        selectedImageSource = ""
        SetViewState()
    End Sub

    Private Sub SaveNewUser()
        If Not CanManageUsers() OrElse Not isAdding Then Return
        If Not ValidateUserDetails(True) Then Return
        Dim savedImagePath As String = ""
        Try
            If Not String.IsNullOrWhiteSpace(selectedImageSource) Then savedImagePath = SaveSelectedImage()
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "INSERT INTO users (Username, Password, FullName, Role_ID, Status, ProfileImagePath) VALUES (@Username, @Password, @FullName, @RoleID, @Status, @ImagePath)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Username", UsernameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", PasswordTXT.Text)
                    cmd.Parameters.AddWithValue("@FullName", FullNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@RoleID", CInt(RoleCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@ImagePath", If(String.IsNullOrWhiteSpace(savedImagePath), CType(DBNull.Value, Object), savedImagePath))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("User added successfully.")
            FinishEditing()
        Catch ex As MySqlException When ex.Number = 1062
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("That username already exists.")
        Catch ex As Exception
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to add user: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateUser()
        If Not CanManageUsers() OrElse Not isEditing Then Return
        If selectedUserID = 0 Then Return
        If Not ValidateUserDetails(False) Then Return
        Dim savedImagePath As String = ""
        Try
            If Not String.IsNullOrWhiteSpace(selectedImageSource) Then savedImagePath = SaveSelectedImage()
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "UPDATE users SET Username=@Username, FullName=@FullName, Role_ID=@RoleID, Status=@Status"
                If Not String.IsNullOrWhiteSpace(PasswordTXT.Text) Then sql &= ", Password=@Password"
                If Not String.IsNullOrWhiteSpace(savedImagePath) Then sql &= ", ProfileImagePath=@ImagePath"
                sql &= " WHERE User_ID=@ID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Username", UsernameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@FullName", FullNameTXT.Text.Trim())
                    cmd.Parameters.AddWithValue("@RoleID", CInt(RoleCMB.SelectedValue))
                    cmd.Parameters.AddWithValue("@Status", StatusCMB.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@ID", selectedUserID)
                    If Not String.IsNullOrWhiteSpace(PasswordTXT.Text) Then cmd.Parameters.AddWithValue("@Password", PasswordTXT.Text)
                    If Not String.IsNullOrWhiteSpace(savedImagePath) Then cmd.Parameters.AddWithValue("@ImagePath", savedImagePath)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("User updated successfully.")
            FinishEditing()
        Catch ex As MySqlException When ex.Number = 1062
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("That username already exists.")
        Catch ex As Exception
            DeleteSavedImage(savedImagePath)
            MessageBox.Show("Failed to update user: " & ex.Message)
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

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        If Not CanManageUsers() Then Return
        If UserLV.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedItem As ListViewItem = UserLV.SelectedItems(0)
        Dim userID As Integer = Convert.ToInt32(selectedItem.Tag)
        If userID = CurrentLoggedInUserID Then
            MessageBox.Show("You cannot delete the account you are currently logged in with.", "Deletion Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim username As String = selectedItem.SubItems(1).Text
        If MessageBox.Show("Permanently delete user '" & username & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim sql As String = "DELETE FROM users WHERE User_ID = @UserID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        selectedUserID = 0
                        LoadUsers()
                        ClearDetails()
                        SetViewState()
                    Else
                        MessageBox.Show("User not found.")
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("This user is referenced by other records and cannot be deleted.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Unable to delete user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to delete user: " & ex.Message)
        End Try
    End Sub

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        If Not CanManageUsers() Then Return
        FinishEditing()
    End Sub

    Private Function ValidateUserDetails(requirePassword As Boolean) As Boolean
        If Not CanManageUsers() Then Return False
        If String.IsNullOrWhiteSpace(FullNameTXT.Text) OrElse String.IsNullOrWhiteSpace(UsernameTXT.Text) OrElse RoleCMB.SelectedIndex = -1 OrElse StatusCMB.SelectedIndex = -1 Then
            MessageBox.Show("Please complete all required fields.")
            Return False
        End If
        If requirePassword AndAlso String.IsNullOrWhiteSpace(PasswordTXT.Text) Then
            MessageBox.Show("Please enter a password.")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearDetails()
        FullNameTXT.Clear()
        UsernameTXT.Clear()
        PasswordTXT.Clear()
        RoleCMB.SelectedIndex = -1
        StatusCMB.SelectedIndex = -1
        selectedImageSource = ""
        DisplayProfileImage("")
    End Sub

    Private Sub FinishEditing()
        isAdding = False
        isEditing = False
        selectedUserID = 0
        selectedImageSource = ""
        LoadUsers()
        ClearDetails()
        SetViewState()
    End Sub

    Private Sub SetViewState()
        Dim canManage As Boolean = CanManageUsers()
        Dim isBusy As Boolean = canManage AndAlso (isAdding OrElse isEditing)

        FullNameTXT.Enabled = isBusy
        UsernameTXT.Enabled = isBusy
        PasswordTXT.Enabled = isBusy
        RoleCMB.Enabled = isBusy
        StatusCMB.Enabled = isBusy
        BrowseImageBTN.Enabled = isBusy
        SearchTXT.Enabled = Not (isAdding OrElse isEditing)
        UserLV.Enabled = Not (isAdding OrElse isEditing)
        DeleteBTN.Enabled = canManage AndAlso Not isBusy
        AddBTN.Enabled = canManage AndAlso Not isEditing
        EditBTN.Enabled = canManage AndAlso Not isAdding
        AddBTN.Text = If(isAdding, "Save", "Add")
        EditBTN.Text = If(isEditing, "Save", "Edit")
        CancelBTN.Visible = canManage AndAlso isBusy
        CancelBTN.Enabled = canManage AndAlso isBusy
    End Sub
End Class