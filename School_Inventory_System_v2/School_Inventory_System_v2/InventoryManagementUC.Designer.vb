<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagementUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagementUC))
        SearchTXT = New TextBox()
        Label9 = New Label()
        InventoryLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label7 = New Label()
        ItemNameTXT = New TextBox()
        Label1 = New Label()
        AvailableQtyTXT = New TextBox()
        Label2 = New Label()
        DamagedQtyTXT = New TextBox()
        Label3 = New Label()
        DepartmentCMB = New ComboBox()
        Label4 = New Label()
        LocationCMB = New ComboBox()
        Label5 = New Label()
        StatusCMB = New ComboBox()
        Label6 = New Label()
        ItemPB = New PictureBox()
        Panel1 = New Panel()
        ItemDescTXT = New TextBox()
        DeleteBTN = New Button()
        EditBTN = New Button()
        AddBTN = New Button()
        CancelBTN = New Button()
        BrowseImageBTN = New Button()
        Label8 = New Label()
        Label10 = New Label()
        CType(ItemPB, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SearchTXT
        ' 
        SearchTXT.BackColor = Color.White
        SearchTXT.BorderStyle = BorderStyle.None
        SearchTXT.Font = New Font("Poppins", 12F)
        SearchTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchTXT.Location = New Point(67, 73)
        SearchTXT.Name = "SearchTXT"
        SearchTXT.Size = New Size(650, 24)
        SearchTXT.TabIndex = 62
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(29, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 26)
        Label9.TabIndex = 61
        Label9.Text = "Search Item"
        ' 
        ' InventoryLV
        ' 
        InventoryLV.BorderStyle = BorderStyle.None
        InventoryLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        InventoryLV.Font = New Font("Poppins", 12F)
        InventoryLV.FullRowSelect = True
        InventoryLV.GridLines = True
        InventoryLV.Location = New Point(33, 160)
        InventoryLV.MultiSelect = False
        InventoryLV.Name = "InventoryLV"
        InventoryLV.Size = New Size(684, 808)
        InventoryLV.TabIndex = 64
        InventoryLV.UseCompatibleStateImageBehavior = False
        InventoryLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ColumnHeader1.Width = 114
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Available"
        ColumnHeader2.Width = 114
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Damaged"
        ColumnHeader3.Width = 114
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Dept"
        ColumnHeader4.Width = 114
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Location"
        ColumnHeader5.Width = 114
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Status"
        ColumnHeader6.Width = 114
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label7.Location = New Point(30, 130)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 26)
        Label7.TabIndex = 63
        Label7.Text = "List"
        ' 
        ' ItemNameTXT
        ' 
        ItemNameTXT.BackColor = Color.White
        ItemNameTXT.BorderStyle = BorderStyle.None
        ItemNameTXT.Font = New Font("Poppins", 12F)
        ItemNameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemNameTXT.Location = New Point(1087, 129)
        ItemNameTXT.Name = "ItemNameTXT"
        ItemNameTXT.Size = New Size(386, 24)
        ItemNameTXT.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label1.Location = New Point(1083, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 26)
        Label1.TabIndex = 65
        Label1.Text = "Item Name"
        ' 
        ' AvailableQtyTXT
        ' 
        AvailableQtyTXT.BackColor = Color.White
        AvailableQtyTXT.BorderStyle = BorderStyle.None
        AvailableQtyTXT.Font = New Font("Poppins", 12F)
        AvailableQtyTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        AvailableQtyTXT.Location = New Point(790, 450)
        AvailableQtyTXT.Name = "AvailableQtyTXT"
        AvailableQtyTXT.Size = New Size(302, 24)
        AvailableQtyTXT.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(786, 421)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 26)
        Label2.TabIndex = 67
        Label2.Text = "Available Quantity"
        ' 
        ' DamagedQtyTXT
        ' 
        DamagedQtyTXT.BackColor = Color.White
        DamagedQtyTXT.BorderStyle = BorderStyle.None
        DamagedQtyTXT.Font = New Font("Poppins", 12F)
        DamagedQtyTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DamagedQtyTXT.Location = New Point(1170, 451)
        DamagedQtyTXT.Name = "DamagedQtyTXT"
        DamagedQtyTXT.Size = New Size(302, 24)
        DamagedQtyTXT.TabIndex = 70
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(1167, 422)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 26)
        Label3.TabIndex = 69
        Label3.Text = "Damaged Quantity"
        ' 
        ' DepartmentCMB
        ' 
        DepartmentCMB.BackColor = Color.White
        DepartmentCMB.Cursor = Cursors.Hand
        DepartmentCMB.DropDownStyle = ComboBoxStyle.DropDownList
        DepartmentCMB.FlatStyle = FlatStyle.Flat
        DepartmentCMB.Font = New Font("Poppins", 9F)
        DepartmentCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DepartmentCMB.FormattingEnabled = True
        DepartmentCMB.Location = New Point(786, 526)
        DepartmentCMB.Name = "DepartmentCMB"
        DepartmentCMB.Size = New Size(308, 30)
        DepartmentCMB.TabIndex = 72
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(786, 501)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 26)
        Label4.TabIndex = 71
        Label4.Text = "Department"
        ' 
        ' LocationCMB
        ' 
        LocationCMB.BackColor = Color.White
        LocationCMB.Cursor = Cursors.Hand
        LocationCMB.DropDownStyle = ComboBoxStyle.DropDownList
        LocationCMB.FlatStyle = FlatStyle.Flat
        LocationCMB.Font = New Font("Poppins", 9F)
        LocationCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LocationCMB.FormattingEnabled = True
        LocationCMB.Location = New Point(1167, 527)
        LocationCMB.Name = "LocationCMB"
        LocationCMB.Size = New Size(308, 30)
        LocationCMB.TabIndex = 74
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(1171, 502)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 26)
        Label5.TabIndex = 73
        Label5.Text = "Location"
        ' 
        ' StatusCMB
        ' 
        StatusCMB.BackColor = Color.White
        StatusCMB.Cursor = Cursors.Hand
        StatusCMB.DropDownStyle = ComboBoxStyle.DropDownList
        StatusCMB.FlatStyle = FlatStyle.Flat
        StatusCMB.Font = New Font("Poppins", 9F)
        StatusCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        StatusCMB.FormattingEnabled = True
        StatusCMB.Items.AddRange(New Object() {"Active", "Inactive"})
        StatusCMB.Location = New Point(786, 605)
        StatusCMB.Name = "StatusCMB"
        StatusCMB.Size = New Size(308, 30)
        StatusCMB.TabIndex = 76
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(786, 580)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 26)
        Label6.TabIndex = 75
        Label6.Text = "Status"
        ' 
        ' ItemPB
        ' 
        ItemPB.BackColor = Color.White
        ItemPB.Location = New Point(3, 3)
        ItemPB.Name = "ItemPB"
        ItemPB.Size = New Size(254, 254)
        ItemPB.TabIndex = 77
        ItemPB.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(ItemPB)
        Panel1.Location = New Point(786, 113)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 260)
        Panel1.TabIndex = 78
        ' 
        ' ItemDescTXT
        ' 
        ItemDescTXT.BackColor = Color.White
        ItemDescTXT.BorderStyle = BorderStyle.None
        ItemDescTXT.Font = New Font("Poppins", 12F)
        ItemDescTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemDescTXT.Location = New Point(1082, 185)
        ItemDescTXT.Multiline = True
        ItemDescTXT.Name = "ItemDescTXT"
        ItemDescTXT.Size = New Size(390, 185)
        ItemDescTXT.TabIndex = 79
        ' 
        ' DeleteBTN
        ' 
        DeleteBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        DeleteBTN.Cursor = Cursors.Hand
        DeleteBTN.FlatAppearance.BorderSize = 0
        DeleteBTN.FlatStyle = FlatStyle.Flat
        DeleteBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeleteBTN.Location = New Point(1146, 885)
        DeleteBTN.Name = "DeleteBTN"
        DeleteBTN.Size = New Size(327, 64)
        DeleteBTN.TabIndex = 82
        DeleteBTN.Text = "Delete"
        DeleteBTN.UseVisualStyleBackColor = False
        ' 
        ' EditBTN
        ' 
        EditBTN.BackColor = Color.FromArgb(CByte(216), CByte(221), CByte(67))
        EditBTN.Cursor = Cursors.Hand
        EditBTN.FlatAppearance.BorderSize = 0
        EditBTN.FlatStyle = FlatStyle.Flat
        EditBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        EditBTN.Location = New Point(788, 885)
        EditBTN.Name = "EditBTN"
        EditBTN.Size = New Size(328, 64)
        EditBTN.TabIndex = 81
        EditBTN.Text = "Edit"
        EditBTN.UseVisualStyleBackColor = False
        ' 
        ' AddBTN
        ' 
        AddBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        AddBTN.Cursor = Cursors.Hand
        AddBTN.FlatAppearance.BorderSize = 0
        AddBTN.FlatStyle = FlatStyle.Flat
        AddBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        AddBTN.Location = New Point(789, 806)
        AddBTN.Name = "AddBTN"
        AddBTN.Size = New Size(684, 64)
        AddBTN.TabIndex = 80
        AddBTN.Text = "Add"
        AddBTN.UseVisualStyleBackColor = False
        ' 
        ' CancelBTN
        ' 
        CancelBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        CancelBTN.Cursor = Cursors.Hand
        CancelBTN.FlatAppearance.BorderSize = 0
        CancelBTN.FlatStyle = FlatStyle.Flat
        CancelBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CancelBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        CancelBTN.Location = New Point(1419, 32)
        CancelBTN.Name = "CancelBTN"
        CancelBTN.Size = New Size(88, 26)
        CancelBTN.TabIndex = 83
        CancelBTN.Text = "Cancel"
        CancelBTN.UseVisualStyleBackColor = False
        CancelBTN.Visible = False
        ' 
        ' BrowseImageBTN
        ' 
        BrowseImageBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        BrowseImageBTN.Cursor = Cursors.Hand
        BrowseImageBTN.FlatAppearance.BorderSize = 0
        BrowseImageBTN.FlatStyle = FlatStyle.Flat
        BrowseImageBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BrowseImageBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        BrowseImageBTN.Location = New Point(790, 379)
        BrowseImageBTN.Name = "BrowseImageBTN"
        BrowseImageBTN.Size = New Size(253, 26)
        BrowseImageBTN.TabIndex = 84
        BrowseImageBTN.Text = "Browse Image"
        BrowseImageBTN.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(785, 87)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 26)
        Label8.TabIndex = 85
        Label8.Text = "Image"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label10.Location = New Point(1082, 159)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 26)
        Label10.TabIndex = 86
        Label10.Text = "Description"
        ' 
        ' InventoryManagementUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(BrowseImageBTN)
        Controls.Add(CancelBTN)
        Controls.Add(DeleteBTN)
        Controls.Add(EditBTN)
        Controls.Add(AddBTN)
        Controls.Add(ItemDescTXT)
        Controls.Add(Panel1)
        Controls.Add(StatusCMB)
        Controls.Add(Label6)
        Controls.Add(LocationCMB)
        Controls.Add(Label5)
        Controls.Add(DepartmentCMB)
        Controls.Add(Label4)
        Controls.Add(DamagedQtyTXT)
        Controls.Add(Label3)
        Controls.Add(AvailableQtyTXT)
        Controls.Add(Label2)
        Controls.Add(ItemNameTXT)
        Controls.Add(Label1)
        Controls.Add(InventoryLV)
        Controls.Add(Label7)
        Controls.Add(SearchTXT)
        Controls.Add(Label9)
        Name = "InventoryManagementUC"
        Size = New Size(1537, 1001)
        CType(ItemPB, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SearchTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents InventoryLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents ItemNameTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AvailableQtyTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DamagedQtyTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DepartmentCMB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LocationCMB As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StatusCMB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ItemPB As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ItemDescTXT As TextBox
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents EditBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents CancelBTN As Button
    Friend WithEvents BrowseImageBTN As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label

End Class
