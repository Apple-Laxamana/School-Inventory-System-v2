Imports MySql.Data.MySqlClient

Public Class LoginUC

    Public Event LoginSucceeded(
    userID As Integer,
    fullName As String,
    roleID As Integer,
    roleName As String
)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub

    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        Dim username As String = UsernameTXT.Text.Trim()
        Dim password As String = PasswordTXT.Text

        If String.IsNullOrWhiteSpace(username) OrElse
           String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show(
                "Please enter your username and password.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Try
            Using conn As MySqlConnection = Database.GetConnection()

                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                Dim sql As String =
                    "SELECT u.User_ID, u.Username, u.Password, " &
                    "u.FullName, u.Role_ID, u.Status, r.RoleName " &
                    "FROM users u " &
                    "INNER JOIN roles r ON u.Role_ID = r.Role_ID " &
                    "WHERE u.Username = @Username " &
                    "LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@Username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If Not reader.Read() Then
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            )
                            Return
                        End If

                        If reader("Status").ToString() <> "Active" Then
                            MessageBox.Show(
                                "This account is inactive. Please contact an administrator.",
                                "Account Inactive",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            )
                            Return
                        End If

                        ' TEMPORARY: plain-text comparison for the initial test account.
                        If password <> reader("Password").ToString() Then
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            )
                            Return
                        End If

                        Dim userID As Integer =
                            Convert.ToInt32(reader("User_ID"))

                        Dim fullName As String =
                            reader("FullName").ToString()

                        Dim roleID As Integer =
                            Convert.ToInt32(reader("Role_ID"))

                        Dim roleName As String =
                            reader("RoleName").ToString()

                        reader.Close()

                        MessageBox.Show(
                            "Welcome, " & fullName & "!",
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        RaiseEvent LoginSucceeded(
                            userID,
                            fullName,
                            roleID,
                            roleName
                        )

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Unable to log in: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub
End Class
