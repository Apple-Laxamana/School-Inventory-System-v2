<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideBarUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SideBarUC))
        DashboardPB = New PictureBox()
        InventoryPB = New PictureBox()
        IssuancePB = New PictureBox()
        DepsLocsPB = New PictureBox()
        MaintenanceRepairPB = New PictureBox()
        ReturnsPB = New PictureBox()
        StockMovementPB = New PictureBox()
        LogoutPB = New PictureBox()
        UserManagementPB = New PictureBox()
        DashboardBTN = New Button()
        InventoryBTN = New Button()
        IssuanceBTN = New Button()
        ReturnsBTN = New Button()
        MaintenanceBTN = New Button()
        DepsLocsBTN = New Button()
        StockMovementBTN = New Button()
        UserManagementBTN = New Button()
        LogoutBTN = New Button()
        CType(DashboardPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(InventoryPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(IssuancePB, ComponentModel.ISupportInitialize).BeginInit()
        CType(DepsLocsPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(MaintenanceRepairPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(ReturnsPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(StockMovementPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogoutPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserManagementPB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DashboardPB
        ' 
        DashboardPB.BackColor = Color.Transparent
        DashboardPB.BackgroundImageLayout = ImageLayout.None
        DashboardPB.Image = CType(resources.GetObject("DashboardPB.Image"), Image)
        DashboardPB.Location = New Point(28, 53)
        DashboardPB.Name = "DashboardPB"
        DashboardPB.Size = New Size(25, 25)
        DashboardPB.SizeMode = PictureBoxSizeMode.Zoom
        DashboardPB.TabIndex = 0
        DashboardPB.TabStop = False
        ' 
        ' InventoryPB
        ' 
        InventoryPB.BackColor = Color.Transparent
        InventoryPB.BackgroundImageLayout = ImageLayout.None
        InventoryPB.Image = CType(resources.GetObject("InventoryPB.Image"), Image)
        InventoryPB.Location = New Point(28, 144)
        InventoryPB.Name = "InventoryPB"
        InventoryPB.Size = New Size(25, 25)
        InventoryPB.SizeMode = PictureBoxSizeMode.Zoom
        InventoryPB.TabIndex = 1
        InventoryPB.TabStop = False
        ' 
        ' IssuancePB
        ' 
        IssuancePB.BackColor = Color.Transparent
        IssuancePB.BackgroundImageLayout = ImageLayout.None
        IssuancePB.Image = CType(resources.GetObject("IssuancePB.Image"), Image)
        IssuancePB.Location = New Point(28, 238)
        IssuancePB.Name = "IssuancePB"
        IssuancePB.Size = New Size(25, 25)
        IssuancePB.SizeMode = PictureBoxSizeMode.Zoom
        IssuancePB.TabIndex = 2
        IssuancePB.TabStop = False
        ' 
        ' DepsLocsPB
        ' 
        DepsLocsPB.BackColor = Color.Transparent
        DepsLocsPB.BackgroundImageLayout = ImageLayout.None
        DepsLocsPB.Image = CType(resources.GetObject("DepsLocsPB.Image"), Image)
        DepsLocsPB.Location = New Point(28, 520)
        DepsLocsPB.Name = "DepsLocsPB"
        DepsLocsPB.Size = New Size(25, 25)
        DepsLocsPB.SizeMode = PictureBoxSizeMode.Zoom
        DepsLocsPB.TabIndex = 5
        DepsLocsPB.TabStop = False
        ' 
        ' MaintenanceRepairPB
        ' 
        MaintenanceRepairPB.BackColor = Color.Transparent
        MaintenanceRepairPB.BackgroundImageLayout = ImageLayout.None
        MaintenanceRepairPB.Image = CType(resources.GetObject("MaintenanceRepairPB.Image"), Image)
        MaintenanceRepairPB.Location = New Point(28, 425)
        MaintenanceRepairPB.Name = "MaintenanceRepairPB"
        MaintenanceRepairPB.Size = New Size(25, 25)
        MaintenanceRepairPB.SizeMode = PictureBoxSizeMode.Zoom
        MaintenanceRepairPB.TabIndex = 4
        MaintenanceRepairPB.TabStop = False
        ' 
        ' ReturnsPB
        ' 
        ReturnsPB.BackColor = Color.Transparent
        ReturnsPB.BackgroundImageLayout = ImageLayout.None
        ReturnsPB.Image = CType(resources.GetObject("ReturnsPB.Image"), Image)
        ReturnsPB.Location = New Point(28, 335)
        ReturnsPB.Name = "ReturnsPB"
        ReturnsPB.Size = New Size(25, 25)
        ReturnsPB.SizeMode = PictureBoxSizeMode.Zoom
        ReturnsPB.TabIndex = 3
        ReturnsPB.TabStop = False
        ' 
        ' StockMovementPB
        ' 
        StockMovementPB.BackColor = Color.Transparent
        StockMovementPB.BackgroundImageLayout = ImageLayout.None
        StockMovementPB.Image = CType(resources.GetObject("StockMovementPB.Image"), Image)
        StockMovementPB.Location = New Point(28, 614)
        StockMovementPB.Name = "StockMovementPB"
        StockMovementPB.Size = New Size(25, 25)
        StockMovementPB.SizeMode = PictureBoxSizeMode.Zoom
        StockMovementPB.TabIndex = 6
        StockMovementPB.TabStop = False
        ' 
        ' LogoutPB
        ' 
        LogoutPB.BackColor = Color.Transparent
        LogoutPB.BackgroundImageLayout = ImageLayout.None
        LogoutPB.Image = CType(resources.GetObject("LogoutPB.Image"), Image)
        LogoutPB.Location = New Point(28, 942)
        LogoutPB.Name = "LogoutPB"
        LogoutPB.Size = New Size(25, 25)
        LogoutPB.SizeMode = PictureBoxSizeMode.Zoom
        LogoutPB.TabIndex = 9
        LogoutPB.TabStop = False
        ' 
        ' UserManagementPB
        ' 
        UserManagementPB.BackColor = Color.Transparent
        UserManagementPB.BackgroundImageLayout = ImageLayout.None
        UserManagementPB.Image = CType(resources.GetObject("UserManagementPB.Image"), Image)
        UserManagementPB.Location = New Point(29, 704)
        UserManagementPB.Name = "UserManagementPB"
        UserManagementPB.Size = New Size(25, 25)
        UserManagementPB.SizeMode = PictureBoxSizeMode.Zoom
        UserManagementPB.TabIndex = 8
        UserManagementPB.TabStop = False
        ' 
        ' DashboardBTN
        ' 
        DashboardBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        DashboardBTN.Cursor = Cursors.Hand
        DashboardBTN.FlatStyle = FlatStyle.Flat
        DashboardBTN.Font = New Font("Poppins", 14.25F)
        DashboardBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DashboardBTN.Location = New Point(-8, 34)
        DashboardBTN.Name = "DashboardBTN"
        DashboardBTN.Size = New Size(392, 64)
        DashboardBTN.TabIndex = 17
        DashboardBTN.Text = "                 Dashboard"
        DashboardBTN.TextAlign = ContentAlignment.MiddleLeft
        DashboardBTN.UseVisualStyleBackColor = False
        ' 
        ' InventoryBTN
        ' 
        InventoryBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        InventoryBTN.Cursor = Cursors.Hand
        InventoryBTN.FlatStyle = FlatStyle.Flat
        InventoryBTN.Font = New Font("Poppins", 14.25F)
        InventoryBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        InventoryBTN.Location = New Point(-9, 125)
        InventoryBTN.Name = "InventoryBTN"
        InventoryBTN.Size = New Size(392, 64)
        InventoryBTN.TabIndex = 18
        InventoryBTN.Text = "                 Inventory"
        InventoryBTN.TextAlign = ContentAlignment.MiddleLeft
        InventoryBTN.UseVisualStyleBackColor = False
        ' 
        ' IssuanceBTN
        ' 
        IssuanceBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        IssuanceBTN.Cursor = Cursors.Hand
        IssuanceBTN.FlatStyle = FlatStyle.Flat
        IssuanceBTN.Font = New Font("Poppins", 14.25F)
        IssuanceBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        IssuanceBTN.Location = New Point(-9, 218)
        IssuanceBTN.Name = "IssuanceBTN"
        IssuanceBTN.Size = New Size(392, 64)
        IssuanceBTN.TabIndex = 19
        IssuanceBTN.Text = "                 Issuance"
        IssuanceBTN.TextAlign = ContentAlignment.MiddleLeft
        IssuanceBTN.UseVisualStyleBackColor = False
        ' 
        ' ReturnsBTN
        ' 
        ReturnsBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        ReturnsBTN.Cursor = Cursors.Hand
        ReturnsBTN.FlatStyle = FlatStyle.Flat
        ReturnsBTN.Font = New Font("Poppins", 14.25F)
        ReturnsBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ReturnsBTN.Location = New Point(-9, 315)
        ReturnsBTN.Name = "ReturnsBTN"
        ReturnsBTN.Size = New Size(392, 64)
        ReturnsBTN.TabIndex = 20
        ReturnsBTN.Text = "                 Returns"
        ReturnsBTN.TextAlign = ContentAlignment.MiddleLeft
        ReturnsBTN.UseVisualStyleBackColor = False
        ' 
        ' MaintenanceBTN
        ' 
        MaintenanceBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        MaintenanceBTN.Cursor = Cursors.Hand
        MaintenanceBTN.FlatStyle = FlatStyle.Flat
        MaintenanceBTN.Font = New Font("Poppins", 14.25F)
        MaintenanceBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        MaintenanceBTN.Location = New Point(-8, 406)
        MaintenanceBTN.Name = "MaintenanceBTN"
        MaintenanceBTN.Size = New Size(392, 64)
        MaintenanceBTN.TabIndex = 21
        MaintenanceBTN.Text = "                 Maintenance and Repair"
        MaintenanceBTN.TextAlign = ContentAlignment.MiddleLeft
        MaintenanceBTN.UseVisualStyleBackColor = False
        ' 
        ' DepsLocsBTN
        ' 
        DepsLocsBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        DepsLocsBTN.Cursor = Cursors.Hand
        DepsLocsBTN.FlatStyle = FlatStyle.Flat
        DepsLocsBTN.Font = New Font("Poppins", 14.25F)
        DepsLocsBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DepsLocsBTN.Location = New Point(-9, 500)
        DepsLocsBTN.Name = "DepsLocsBTN"
        DepsLocsBTN.Size = New Size(392, 64)
        DepsLocsBTN.TabIndex = 22
        DepsLocsBTN.Text = "                 Departments and Location"
        DepsLocsBTN.TextAlign = ContentAlignment.MiddleLeft
        DepsLocsBTN.UseVisualStyleBackColor = False
        ' 
        ' StockMovementBTN
        ' 
        StockMovementBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        StockMovementBTN.Cursor = Cursors.Hand
        StockMovementBTN.FlatStyle = FlatStyle.Flat
        StockMovementBTN.Font = New Font("Poppins", 14.25F)
        StockMovementBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        StockMovementBTN.Location = New Point(-9, 594)
        StockMovementBTN.Name = "StockMovementBTN"
        StockMovementBTN.Size = New Size(392, 64)
        StockMovementBTN.TabIndex = 23
        StockMovementBTN.Text = "                 Stock Movement"
        StockMovementBTN.TextAlign = ContentAlignment.MiddleLeft
        StockMovementBTN.UseVisualStyleBackColor = False
        ' 
        ' UserManagementBTN
        ' 
        UserManagementBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        UserManagementBTN.Cursor = Cursors.Hand
        UserManagementBTN.FlatStyle = FlatStyle.Flat
        UserManagementBTN.Font = New Font("Poppins", 14.25F)
        UserManagementBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        UserManagementBTN.Location = New Point(-8, 685)
        UserManagementBTN.Name = "UserManagementBTN"
        UserManagementBTN.Size = New Size(392, 64)
        UserManagementBTN.TabIndex = 25
        UserManagementBTN.Text = "                 User Management"
        UserManagementBTN.TextAlign = ContentAlignment.MiddleLeft
        UserManagementBTN.UseVisualStyleBackColor = False
        ' 
        ' LogoutBTN
        ' 
        LogoutBTN.BackColor = Color.FromArgb(CByte(36), CByte(59), CByte(83))
        LogoutBTN.Cursor = Cursors.Hand
        LogoutBTN.FlatStyle = FlatStyle.Flat
        LogoutBTN.Font = New Font("Poppins", 14.25F)
        LogoutBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LogoutBTN.Location = New Point(-8, 922)
        LogoutBTN.Name = "LogoutBTN"
        LogoutBTN.Size = New Size(392, 64)
        LogoutBTN.TabIndex = 26
        LogoutBTN.Text = "                 Logout"
        LogoutBTN.TextAlign = ContentAlignment.MiddleLeft
        LogoutBTN.UseVisualStyleBackColor = False
        ' 
        ' SideBarUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(LogoutPB)
        Controls.Add(UserManagementPB)
        Controls.Add(StockMovementPB)
        Controls.Add(DepsLocsPB)
        Controls.Add(MaintenanceRepairPB)
        Controls.Add(ReturnsPB)
        Controls.Add(IssuancePB)
        Controls.Add(InventoryPB)
        Controls.Add(DashboardPB)
        Controls.Add(DashboardBTN)
        Controls.Add(InventoryBTN)
        Controls.Add(IssuanceBTN)
        Controls.Add(ReturnsBTN)
        Controls.Add(MaintenanceBTN)
        Controls.Add(DepsLocsBTN)
        Controls.Add(StockMovementBTN)
        Controls.Add(UserManagementBTN)
        Controls.Add(LogoutBTN)
        Name = "SideBarUC"
        Size = New Size(385, 1001)
        CType(DashboardPB, ComponentModel.ISupportInitialize).EndInit()
        CType(InventoryPB, ComponentModel.ISupportInitialize).EndInit()
        CType(IssuancePB, ComponentModel.ISupportInitialize).EndInit()
        CType(DepsLocsPB, ComponentModel.ISupportInitialize).EndInit()
        CType(MaintenanceRepairPB, ComponentModel.ISupportInitialize).EndInit()
        CType(ReturnsPB, ComponentModel.ISupportInitialize).EndInit()
        CType(StockMovementPB, ComponentModel.ISupportInitialize).EndInit()
        CType(LogoutPB, ComponentModel.ISupportInitialize).EndInit()
        CType(UserManagementPB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DashboardPB As PictureBox
    Friend WithEvents InventoryPB As PictureBox
    Friend WithEvents IssuancePB As PictureBox
    Friend WithEvents DepsLocsPB As PictureBox
    Friend WithEvents MaintenanceRepairPB As PictureBox
    Friend WithEvents ReturnsPB As PictureBox
    Friend WithEvents StockMovementPB As PictureBox
    Friend WithEvents LogoutPB As PictureBox
    Friend WithEvents UserManagementPB As PictureBox
    Friend WithEvents DashboardBTN As Button
    Friend WithEvents InventoryBTN As Button
    Friend WithEvents IssuanceBTN As Button
    Friend WithEvents ReturnsBTN As Button
    Friend WithEvents MaintenanceBTN As Button
    Friend WithEvents DepsLocsBTN As Button
    Friend WithEvents StockMovementBTN As Button
    Friend WithEvents UserManagementBTN As Button
    Friend WithEvents LogoutBTN As Button

End Class
