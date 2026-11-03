Imports System.Linq
Public Class Form1

    Private LoginScreen As LoginUC
    Private TopBar As TopBarUC
    Private SideBar As SideBarUC
    Private MainContent As MainContentUC

    Private loggedInUserID As Integer = 0
    Private loggedInRoleID As Integer = 0
    Private loggedInRoleName As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        ShowLogin()
    End Sub

    Private Sub ShowLogin()

        Me.Controls.Clear()

        LoginScreen = New LoginUC()
        LoginScreen.Dock = DockStyle.Fill

        AddHandler LoginScreen.LoginSucceeded, AddressOf OpenMainApp

        Me.Controls.Add(LoginScreen)
        LoginScreen.BringToFront()

    End Sub

    Private Sub ShowUserManagement()
        If MainContent.Controls.OfType(Of UserManagementUC)().Any() Then
            MessageBox.Show("You are already in User Management.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim userManagement As New UserManagementUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(userManagement)
        userManagement.BringToFront()
    End Sub

    Private Sub ShowDeptLoc()
        If MainContent.Controls.OfType(Of DeptLocUC)().Any() Then
            MessageBox.Show("You are already in Departments/Locations.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim deptLoc As New DeptLocUC With {
        .Dock = DockStyle.Fill,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(deptLoc)
        deptLoc.BringToFront()
    End Sub

    Private Sub ShowInventory()
        If MainContent.Controls.OfType(Of InventoryManagementUC)().Any() Then
            MessageBox.Show("You are already in Inventory Management.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim inventory As New InventoryManagementUC With {
        .Dock = DockStyle.Fill,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(inventory)
        inventory.BringToFront()
    End Sub

    Private Sub ShowIssuance()
        If MainContent.Controls.OfType(Of IssuanceUC)().Any() Then
            MessageBox.Show("You are already in Issuance.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim issuance As New IssuanceUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(issuance)
        issuance.BringToFront()
    End Sub

    Private Sub ShowStockMovement()
        If MainContent.Controls.OfType(Of StockMovementUC)().Any() Then
            MessageBox.Show("You are already in Stock Movement.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim stockMovement As New StockMovementUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(stockMovement)
        stockMovement.BringToFront()
    End Sub

    Private Sub ShowReturns()
        If MainContent.Controls.OfType(Of ReturnsUC)().Any() Then
            MessageBox.Show("You are already in Returns.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim returns As New ReturnsUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(returns)
        returns.BringToFront()
    End Sub

    Private Sub ShowMaintenance()
        If MainContent.Controls.OfType(Of MaintenanceUC)().Any() Then
            MessageBox.Show("You are already in Maintenance & Repair.", "Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        MainContent.Controls.Clear()

        Dim maintenance As New MaintenanceUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(maintenance)
        maintenance.BringToFront()
    End Sub

    Private Sub ShowDashboard()
        MainContent.Controls.Clear()

        Dim dashboard As New DashboardUC With {
        .Dock = DockStyle.Fill,
        .CurrentLoggedInUserID = loggedInUserID,
        .CurrentUserRole = loggedInRoleName
    }

        MainContent.Controls.Add(dashboard)
        dashboard.BringToFront()
    End Sub

    Private Sub OpenMainApp(userID As Integer, fullName As String, roleID As Integer, roleName As String)
        loggedInUserID = userID
        loggedInRoleID = roleID
        loggedInRoleName = roleName

        Me.Controls.Clear()

        'main app layout
        Dim AppLayout As New Panel With {
            .Dock = DockStyle.Fill,
            .Margin = New Padding(0),
            .Padding = New Padding(0)
        }

        'create the User Controls (UC)
        TopBar = New TopBarUC()
        SideBar = New SideBarUC()
        MainContent = New MainContentUC()

        TopBar.NameLBL.Text = fullName
        SideBar.SetAccessLevel(roleName)

        'remove spacing around each control
        TopBar.Margin = New Padding(0)
        SideBar.Margin = New Padding(0)
        MainContent.Margin = New Padding(0)

        'TOPBAR: spans the entire top
        TopBar.Dock = DockStyle.Top
        TopBar.Height = 79

        'SIDEBAR: below the topbar, on the left
        SideBar.Dock = DockStyle.Left
        SideBar.Width = 385

        MainContent.Dock = DockStyle.Fill

        'add handlers
        AddHandler SideBar.LogoutRequested, AddressOf ShowLogin
        AddHandler SideBar.DashboardRequested, AddressOf ShowDashboard
        AddHandler SideBar.InventoryRequested, AddressOf ShowInventory
        AddHandler SideBar.IssuanceRequested, AddressOf ShowIssuance
        AddHandler SideBar.ReturnsRequested, AddressOf ShowReturns
        AddHandler SideBar.MaintenanceRequested, AddressOf ShowMaintenance
        AddHandler SideBar.DeptLocRequested, AddressOf ShowDeptLoc
        AddHandler SideBar.StockMovementRequested, AddressOf ShowStockMovement
        'AddHandler SideBar.ReportsRequested, AddressOf ShowReports
        AddHandler SideBar.UserManagementRequested, AddressOf ShowUserManagement

        AppLayout.Controls.Add(MainContent)
        AppLayout.Controls.Add(SideBar)
        AppLayout.Controls.Add(TopBar)

        'application layout to fullscreen
        Me.Controls.Add(AppLayout)

        AppLayout.Dock = DockStyle.Fill
        AppLayout.BringToFront()

    End Sub
End Class