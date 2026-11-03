
Imports MySql.Data.MySqlClient

Module Database

    Private ReadOnly connectionString As String = "Server=127.0.0.1;" & "Port=3307;" & "Database=inv_db;" & "Uid=root;" & "Pwd=password;" & "SslMode=Disabled;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
            End Using
            Return True

        Catch ex As Exception
            MessageBox.Show("Database connection failed." & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
