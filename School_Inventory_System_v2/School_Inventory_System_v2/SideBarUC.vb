Public Class SideBarUC

    Public Event DashboardRequested()
    Public Event InventoryRequested()
    Public Event IssuanceRequested()
    Public Event ReturnsRequested()
    Public Event MaintenanceRequested()
    Public Event DeptLocRequested()
    Public Event StockMovementRequested()
    'Public Event ReportsRequested()
    Public Event UserManagementRequested()

    Public Event LogoutRequested()

    Private Sub LogoutBTN_Click(sender As Object, e As EventArgs) Handles LogoutBTN.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            RaiseEvent LogoutRequested()
        End If
    End Sub

    Private Sub UserManagementBTN_Click(sender As Object, e As EventArgs) Handles UserManagementBTN.Click
        RaiseEvent UserManagementRequested()
    End Sub

    Private Sub DepsLocsBTN_Click(sender As Object, e As EventArgs) Handles DepsLocsBTN.Click
        RaiseEvent DeptLocRequested()
    End Sub

    Private Sub InventoryBTN_Click(sender As Object, e As EventArgs) Handles InventoryBTN.Click
        RaiseEvent InventoryRequested()
    End Sub

    Private Sub IssuanceBTN_Click(sender As Object, e As EventArgs) Handles IssuanceBTN.Click
        RaiseEvent IssuanceRequested()
    End Sub

    Private Sub StockMovementBTN_Click(sender As Object, e As EventArgs) Handles StockMovementBTN.Click
        RaiseEvent StockMovementRequested()
    End Sub

    Private Sub ReturnsBTN_Click(sender As Object, e As EventArgs) Handles ReturnsBTN.Click
        RaiseEvent ReturnsRequested()
    End Sub

    Private Sub MaintenanceBTN_Click(sender As Object, e As EventArgs) Handles MaintenanceBTN.Click
        RaiseEvent MaintenanceRequested()
    End Sub

    Private Sub DashboardBTN_Click(sender As Object, e As EventArgs) Handles DashboardBTN.Click
        RaiseEvent DashboardRequested()
    End Sub

    Public Sub SetAccessLevel(roleName As String)
        'Disable all module buttons first.
        DashboardBTN.Enabled = False
        DashboardPB.Enabled = False
        InventoryBTN.Enabled = False
        InventoryPB.Enabled = False
        IssuanceBTN.Enabled = False
        IssuancePB.Enabled = False
        ReturnsBTN.Enabled = False
        ReturnsPB.Enabled = False
        MaintenanceBTN.Enabled = False
        MaintenanceRepairPB.Enabled = False
        DepsLocsBTN.Enabled = False
        DepsLocsPB.Enabled = False
        StockMovementBTN.Enabled = False
        StockMovementPB.Enabled = False
        UserManagementBTN.Enabled = False
        UserManagementPB.Enabled = False

        Select Case roleName.Trim().ToLower()
            Case "admin"
                DashboardBTN.Enabled = True
                InventoryBTN.Enabled = True
                IssuanceBTN.Enabled = True
                ReturnsBTN.Enabled = True
                MaintenanceBTN.Enabled = True
                DepsLocsBTN.Enabled = True
                StockMovementBTN.Enabled = True
                UserManagementBTN.Enabled = True

            Case "inventory custodian"
                DashboardBTN.Enabled = True
                InventoryBTN.Enabled = True
                StockMovementBTN.Enabled = True

            Case "issuance clerk"
                DashboardBTN.Enabled = True
                IssuanceBTN.Enabled = True
                ReturnsBTN.Enabled = True

            Case "maintenance personnel"
                DashboardBTN.Enabled = True
                MaintenanceBTN.Enabled = True

            Case "department head"
                DashboardBTN.Enabled = True
                InventoryBTN.Enabled = True
                IssuanceBTN.Enabled = True
                ReturnsBTN.Enabled = True
                DepsLocsBTN.Enabled = True

        End Select
    End Sub
End Class
