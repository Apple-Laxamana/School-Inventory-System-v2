
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DashboardUC

    Public Property CurrentLoggedInUserID As Integer = 0
    Public Property CurrentUserRole As String = ""

    Private Sub DashboardUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupActivitiesListView()
        LoadDashboard()
    End Sub

    Private Sub SetupActivitiesListView()
        MaintenanceLV.View = View.Details
        MaintenanceLV.FullRowSelect = True
        MaintenanceLV.GridLines = True
        MaintenanceLV.MultiSelect = False
        MaintenanceLV.HideSelection = False
        MaintenanceLV.Columns.Clear()
        MaintenanceLV.Columns.Add("Activity Type", 120)
        MaintenanceLV.Columns.Add("Description", 450)
        MaintenanceLV.Columns.Add("Date & Time", 160)
        MaintenanceLV.Columns.Add("Performed By", 180)
    End Sub

    Private Function GetCount(conn As MySqlConnection, sql As String) As Integer
        Using cmd As New MySqlCommand(sql, conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function GetAmount(conn As MySqlConnection, sql As String) As Decimal
        Using cmd As New MySqlCommand(sql, conn)
            Dim result As Object = cmd.ExecuteScalar()
            If result Is Nothing OrElse IsDBNull(result) Then Return 0D
            Return Convert.ToDecimal(result)
        End Using
    End Function

    Private Sub LoadDashboard()
        Try
            Using conn As MySqlConnection = Database.GetConnection()
                conn.Open()

                'INVENTORY OVERVIEW
                RegisteredItemsLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM inventory").ToString("N0")
                AvailableStockLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(AvailableQuantity),0) FROM inventory").ToString("N0")
                DamagedStockLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(DamagedQuantity),0) FROM inventory").ToString("N0")
                NeedsRepairLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM inventory WHERE DamagedQuantity>0").ToString("N0")

                'ISSUANCE OVERVIEW
                TotalIssuancesLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM issuances").ToString("N0")
                OutstandingLBL.Text = GetCount(conn, "SELECT COUNT(DISTINCT IssuanceID) FROM issuance_details WHERE QuantityIssued>QuantityReturned").ToString("N0")
                UnitsNotReturnedLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(QuantityIssued-QuantityReturned),0) FROM issuance_details WHERE QuantityIssued>QuantityReturned").ToString("N0")

                'RETURNS OVERVIEW
                TotalReturnedUnitsLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(QuantityReturned),0) FROM returns").ToString("N0")
                RecentReturnsLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM returns WHERE ReturnDate>=NOW()-INTERVAL 7 DAY").ToString("N0")
                ItemsReturnedTodayLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(QuantityReturned),0) FROM returns WHERE ReturnDate>=CURDATE() AND ReturnDate<CURDATE()+INTERVAL 1 DAY").ToString("N0")

                'STOCK SUMMARY
                TotalAvailableLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(AvailableQuantity),0) FROM inventory").ToString("N0")
                TotalDamagedLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(DamagedQuantity),0) FROM inventory").ToString("N0")
                TotalStockLBL.Text = GetAmount(conn, "SELECT COALESCE(SUM(AvailableQuantity+DamagedQuantity),0) FROM inventory").ToString("N0")

                'MAINTENANCE STATUS
                UnderMaintenanceLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM maintenance WHERE COALESCE(Status,'')<>'Completed' AND Remarks NOT LIKE '%Beyond Repair%'").ToString("N0")
                BeyondRepairLBL.Text = GetCount(conn, "SELECT COUNT(DISTINCT ItemID) FROM maintenance WHERE Remarks LIKE '%Item condition after repair: Beyond Repair%'").ToString("N0")
                CompletedRepairsLBL.Text = GetCount(conn, "SELECT COUNT(*) FROM maintenance WHERE Status='Completed'").ToString("N0")

                'RECENT ACTIVITIES
                LoadRecentActivities(conn)
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard information: " & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadRecentActivities(conn As MySqlConnection)
        MaintenanceLV.Items.Clear()

        Dim sql As String =
            "SELECT * FROM (" &
            "SELECT 'Issuance' AS ActivityType, CONCAT('Issued to ',iss.RecepientName) AS Description, iss.IssueDate AS ActivityDate, COALESCE(u.FullName,'') AS PerformedBy FROM issuances iss LEFT JOIN users u ON iss.IssuedByUserID=u.User_ID " &
            "UNION ALL " &
            "SELECT 'Return', CONCAT('Returned ',r.QuantityReturned,' unit(s) of ',i.ItemName,' - ',r.ConditionOnReturn), r.ReturnDate, COALESCE(u.FullName,'') FROM returns r INNER JOIN issuance_details id ON r.IssuanceDetailID=id.IssuanceDetailID INNER JOIN inventory i ON id.ItemID=i.ItemID LEFT JOIN users u ON r.ReceivedByUserID=u.User_ID " &
            "UNION ALL " &
            "SELECT sm.MovementType, CONCAT(i.ItemName,' - ',sm.Quantity,' unit(s)'), sm.MovementDate, COALESCE(u.FullName,'') FROM stock_movements sm INNER JOIN inventory i ON sm.ItemID=i.ItemID LEFT JOIN users u ON sm.User_ID=u.User_ID " &
            "UNION ALL " &
            "SELECT 'Maintenance', CONCAT(i.ItemName,' - ',m.Status,' - ',m.Problem), COALESCE(m.CompletionDate,m.DateReported), COALESCE(u.FullName,'') FROM maintenance m INNER JOIN inventory i ON m.ItemID=i.ItemID LEFT JOIN users u ON m.AssignedUserID=u.User_ID" &
            ") AS activities ORDER BY ActivityDate DESC LIMIT 10"

        Using cmd As New MySqlCommand(sql, conn)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim row As New ListViewItem(reader("ActivityType").ToString())
                    row.SubItems.Add(reader("Description").ToString())

                    If Not IsDBNull(reader("ActivityDate")) Then
                        row.SubItems.Add(Convert.ToDateTime(reader("ActivityDate")).ToString("yyyy-MM-dd HH:mm"))
                    Else
                        row.SubItems.Add("")
                    End If

                    row.SubItems.Add(reader("PerformedBy").ToString())
                    MaintenanceLV.Items.Add(row)
                End While
            End Using
        End Using
    End Sub

End Class
