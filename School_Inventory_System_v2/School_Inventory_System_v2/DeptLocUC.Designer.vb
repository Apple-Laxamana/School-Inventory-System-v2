<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeptLocUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeptLocUC))
        Panel1 = New Panel()
        LocationsPB = New PictureBox()
        DepartmentPB = New PictureBox()
        LocationsBTN = New Button()
        DepartmentsBTN = New Button()
        TabControl1 = New TabControl()
        DeptTP = New TabPage()
        DeptLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        Label7 = New Label()
        DeptCancelBTN = New Button()
        DeptDeleteBTN = New Button()
        DeptEditBTN = New Button()
        DeptAddBTN = New Button()
        Label6 = New Label()
        DeptDescTXT = New TextBox()
        StatusCMB = New ComboBox()
        Label5 = New Label()
        Label3 = New Label()
        ContactNumTXT = New TextBox()
        Label1 = New Label()
        DeptHeadCMB = New ComboBox()
        Label4 = New Label()
        Label2 = New Label()
        DepartmentNameTXT = New TextBox()
        SearchDeptTXT = New TextBox()
        Label9 = New Label()
        LocationsTP = New TabPage()
        LocCancelBTN = New Button()
        LocStatusCMB = New ComboBox()
        Label12 = New Label()
        LocDeleteBTN = New Button()
        LocEditBTN = New Button()
        LocAddBTN = New Button()
        Label11 = New Label()
        LocDescTXT = New TextBox()
        LocDeptCMB = New ComboBox()
        Label14 = New Label()
        Label13 = New Label()
        LocationNameTXT = New TextBox()
        LocLV = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label10 = New Label()
        SearchLocTXT = New TextBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(LocationsPB, ComponentModel.ISupportInitialize).BeginInit()
        CType(DepartmentPB, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        DeptTP.SuspendLayout()
        LocationsTP.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(243), CByte(238))
        Panel1.Controls.Add(LocationsPB)
        Panel1.Controls.Add(DepartmentPB)
        Panel1.Controls.Add(LocationsBTN)
        Panel1.Controls.Add(DepartmentsBTN)
        Panel1.Location = New Point(-17, -19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1574, 145)
        Panel1.TabIndex = 1
        ' 
        ' LocationsPB
        ' 
        LocationsPB.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(129))
        LocationsPB.BackgroundImageLayout = ImageLayout.None
        LocationsPB.Image = CType(resources.GetObject("LocationsPB.Image"), Image)
        LocationsPB.Location = New Point(1153, 62)
        LocationsPB.Name = "LocationsPB"
        LocationsPB.Size = New Size(15, 15)
        LocationsPB.SizeMode = PictureBoxSizeMode.Zoom
        LocationsPB.TabIndex = 20
        LocationsPB.TabStop = False
        ' 
        ' DepartmentPB
        ' 
        DepartmentPB.BackColor = Color.FromArgb(CByte(214), CByte(173), CByte(96))
        DepartmentPB.BackgroundImageLayout = ImageLayout.None
        DepartmentPB.Image = CType(resources.GetObject("DepartmentPB.Image"), Image)
        DepartmentPB.Location = New Point(398, 62)
        DepartmentPB.Name = "DepartmentPB"
        DepartmentPB.Size = New Size(15, 15)
        DepartmentPB.SizeMode = PictureBoxSizeMode.Zoom
        DepartmentPB.TabIndex = 19
        DepartmentPB.TabStop = False
        ' 
        ' LocationsBTN
        ' 
        LocationsBTN.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(129))
        LocationsBTN.Cursor = Cursors.Hand
        LocationsBTN.FlatAppearance.BorderSize = 2
        LocationsBTN.FlatStyle = FlatStyle.Flat
        LocationsBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LocationsBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LocationsBTN.Location = New Point(809, 51)
        LocationsBTN.Name = "LocationsBTN"
        LocationsBTN.Size = New Size(711, 64)
        LocationsBTN.TabIndex = 18
        LocationsBTN.Text = "Locations"
        LocationsBTN.TextAlign = ContentAlignment.BottomCenter
        LocationsBTN.UseVisualStyleBackColor = False
        ' 
        ' DepartmentsBTN
        ' 
        DepartmentsBTN.BackColor = Color.FromArgb(CByte(214), CByte(173), CByte(96))
        DepartmentsBTN.Cursor = Cursors.Hand
        DepartmentsBTN.FlatAppearance.BorderSize = 0
        DepartmentsBTN.FlatStyle = FlatStyle.Flat
        DepartmentsBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DepartmentsBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DepartmentsBTN.Location = New Point(53, 51)
        DepartmentsBTN.Name = "DepartmentsBTN"
        DepartmentsBTN.Size = New Size(714, 64)
        DepartmentsBTN.TabIndex = 17
        DepartmentsBTN.Text = "Departments"
        DepartmentsBTN.TextAlign = ContentAlignment.BottomCenter
        DepartmentsBTN.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(DeptTP)
        TabControl1.Controls.Add(LocationsTP)
        TabControl1.Location = New Point(-14, 93)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1568, 919)
        TabControl1.TabIndex = 19
        ' 
        ' DeptTP
        ' 
        DeptTP.BackgroundImage = CType(resources.GetObject("DeptTP.BackgroundImage"), Image)
        DeptTP.Controls.Add(DeptLV)
        DeptTP.Controls.Add(Label7)
        DeptTP.Controls.Add(DeptCancelBTN)
        DeptTP.Controls.Add(DeptDeleteBTN)
        DeptTP.Controls.Add(DeptEditBTN)
        DeptTP.Controls.Add(DeptAddBTN)
        DeptTP.Controls.Add(Label6)
        DeptTP.Controls.Add(DeptDescTXT)
        DeptTP.Controls.Add(StatusCMB)
        DeptTP.Controls.Add(Label5)
        DeptTP.Controls.Add(Label3)
        DeptTP.Controls.Add(ContactNumTXT)
        DeptTP.Controls.Add(Label1)
        DeptTP.Controls.Add(DeptHeadCMB)
        DeptTP.Controls.Add(Label4)
        DeptTP.Controls.Add(Label2)
        DeptTP.Controls.Add(DepartmentNameTXT)
        DeptTP.Controls.Add(SearchDeptTXT)
        DeptTP.Controls.Add(Label9)
        DeptTP.Location = New Point(4, 24)
        DeptTP.Name = "DeptTP"
        DeptTP.Padding = New Padding(3)
        DeptTP.Size = New Size(1560, 891)
        DeptTP.TabIndex = 0
        DeptTP.Text = "Departments"
        DeptTP.UseVisualStyleBackColor = True
        ' 
        ' DeptLV
        ' 
        DeptLV.BorderStyle = BorderStyle.None
        DeptLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        DeptLV.Font = New Font("Poppins", 12F)
        DeptLV.FullRowSelect = True
        DeptLV.GridLines = True
        DeptLV.Location = New Point(45, 109)
        DeptLV.MultiSelect = False
        DeptLV.Name = "DeptLV"
        DeptLV.Size = New Size(1465, 371)
        DeptLV.TabIndex = 79
        DeptLV.UseCompatibleStateImageBehavior = False
        DeptLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Department Name"
        ColumnHeader1.Width = 650
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Head"
        ColumnHeader2.Width = 550
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Status"
        ColumnHeader3.Width = 265
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label7.Location = New Point(42, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 26)
        Label7.TabIndex = 78
        Label7.Text = "Departments List"
        ' 
        ' DeptCancelBTN
        ' 
        DeptCancelBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        DeptCancelBTN.Cursor = Cursors.Hand
        DeptCancelBTN.FlatAppearance.BorderSize = 0
        DeptCancelBTN.FlatStyle = FlatStyle.Flat
        DeptCancelBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeptCancelBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeptCancelBTN.Location = New Point(1425, 492)
        DeptCancelBTN.Name = "DeptCancelBTN"
        DeptCancelBTN.Size = New Size(88, 26)
        DeptCancelBTN.TabIndex = 77
        DeptCancelBTN.Text = "Cancel"
        DeptCancelBTN.UseVisualStyleBackColor = False
        DeptCancelBTN.Visible = False
        ' 
        ' DeptDeleteBTN
        ' 
        DeptDeleteBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        DeptDeleteBTN.Cursor = Cursors.Hand
        DeptDeleteBTN.FlatAppearance.BorderSize = 0
        DeptDeleteBTN.FlatStyle = FlatStyle.Flat
        DeptDeleteBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeptDeleteBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeptDeleteBTN.Location = New Point(1295, 777)
        DeptDeleteBTN.Name = "DeptDeleteBTN"
        DeptDeleteBTN.Size = New Size(196, 64)
        DeptDeleteBTN.TabIndex = 76
        DeptDeleteBTN.Text = "Delete"
        DeptDeleteBTN.UseVisualStyleBackColor = False
        ' 
        ' DeptEditBTN
        ' 
        DeptEditBTN.BackColor = Color.FromArgb(CByte(216), CByte(221), CByte(67))
        DeptEditBTN.Cursor = Cursors.Hand
        DeptEditBTN.FlatAppearance.BorderSize = 0
        DeptEditBTN.FlatStyle = FlatStyle.Flat
        DeptEditBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeptEditBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeptEditBTN.Location = New Point(1061, 777)
        DeptEditBTN.Name = "DeptEditBTN"
        DeptEditBTN.Size = New Size(196, 64)
        DeptEditBTN.TabIndex = 75
        DeptEditBTN.Text = "Edit"
        DeptEditBTN.UseVisualStyleBackColor = False
        ' 
        ' DeptAddBTN
        ' 
        DeptAddBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        DeptAddBTN.Cursor = Cursors.Hand
        DeptAddBTN.FlatAppearance.BorderSize = 0
        DeptAddBTN.FlatStyle = FlatStyle.Flat
        DeptAddBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeptAddBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeptAddBTN.Location = New Point(826, 778)
        DeptAddBTN.Name = "DeptAddBTN"
        DeptAddBTN.Size = New Size(196, 64)
        DeptAddBTN.TabIndex = 74
        DeptAddBTN.Text = "Add"
        DeptAddBTN.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(59, 687)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 26)
        Label6.TabIndex = 73
        Label6.Text = "Description"
        ' 
        ' DeptDescTXT
        ' 
        DeptDescTXT.BackColor = Color.White
        DeptDescTXT.BorderStyle = BorderStyle.None
        DeptDescTXT.Font = New Font("Poppins", 12F)
        DeptDescTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DeptDescTXT.Location = New Point(65, 715)
        DeptDescTXT.Multiline = True
        DeptDescTXT.Name = "DeptDescTXT"
        DeptDescTXT.Size = New Size(662, 122)
        DeptDescTXT.TabIndex = 72
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
        StatusCMB.Location = New Point(826, 643)
        StatusCMB.Name = "StatusCMB"
        StatusCMB.Size = New Size(667, 30)
        StatusCMB.TabIndex = 71
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(821, 619)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 26)
        Label5.TabIndex = 70
        Label5.Text = "Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(59, 618)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 26)
        Label3.TabIndex = 69
        Label3.Text = "Contact Number"
        ' 
        ' ContactNumTXT
        ' 
        ContactNumTXT.BackColor = Color.White
        ContactNumTXT.BorderStyle = BorderStyle.None
        ContactNumTXT.Font = New Font("Poppins", 12F)
        ContactNumTXT.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ContactNumTXT.Location = New Point(65, 646)
        ContactNumTXT.Name = "ContactNumTXT"
        ContactNumTXT.Size = New Size(662, 24)
        ContactNumTXT.TabIndex = 68
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label1.Location = New Point(42, 501)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 26)
        Label1.TabIndex = 67
        Label1.Text = "Department Details"
        ' 
        ' DeptHeadCMB
        ' 
        DeptHeadCMB.BackColor = Color.White
        DeptHeadCMB.Cursor = Cursors.Hand
        DeptHeadCMB.DropDownStyle = ComboBoxStyle.DropDownList
        DeptHeadCMB.FlatStyle = FlatStyle.Flat
        DeptHeadCMB.Font = New Font("Poppins", 9F)
        DeptHeadCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DeptHeadCMB.FormattingEnabled = True
        DeptHeadCMB.Location = New Point(826, 573)
        DeptHeadCMB.Name = "DeptHeadCMB"
        DeptHeadCMB.Size = New Size(667, 30)
        DeptHeadCMB.TabIndex = 66
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(821, 548)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 26)
        Label4.TabIndex = 65
        Label4.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(59, 547)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 26)
        Label2.TabIndex = 64
        Label2.Text = "Department Name"
        ' 
        ' DepartmentNameTXT
        ' 
        DepartmentNameTXT.BackColor = Color.White
        DepartmentNameTXT.BorderStyle = BorderStyle.None
        DepartmentNameTXT.Font = New Font("Poppins", 12F)
        DepartmentNameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DepartmentNameTXT.Location = New Point(65, 575)
        DepartmentNameTXT.Name = "DepartmentNameTXT"
        DepartmentNameTXT.Size = New Size(662, 24)
        DepartmentNameTXT.TabIndex = 63
        ' 
        ' SearchDeptTXT
        ' 
        SearchDeptTXT.BackColor = Color.White
        SearchDeptTXT.BorderStyle = BorderStyle.None
        SearchDeptTXT.Font = New Font("Poppins", 12F)
        SearchDeptTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchDeptTXT.Location = New Point(80, 36)
        SearchDeptTXT.Name = "SearchDeptTXT"
        SearchDeptTXT.Size = New Size(1430, 24)
        SearchDeptTXT.TabIndex = 62
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(36, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 26)
        Label9.TabIndex = 61
        Label9.Text = "Search Department"
        ' 
        ' LocationsTP
        ' 
        LocationsTP.BackgroundImage = CType(resources.GetObject("LocationsTP.BackgroundImage"), Image)
        LocationsTP.Controls.Add(LocCancelBTN)
        LocationsTP.Controls.Add(LocStatusCMB)
        LocationsTP.Controls.Add(Label12)
        LocationsTP.Controls.Add(LocDeleteBTN)
        LocationsTP.Controls.Add(LocEditBTN)
        LocationsTP.Controls.Add(LocAddBTN)
        LocationsTP.Controls.Add(Label11)
        LocationsTP.Controls.Add(LocDescTXT)
        LocationsTP.Controls.Add(LocDeptCMB)
        LocationsTP.Controls.Add(Label14)
        LocationsTP.Controls.Add(Label13)
        LocationsTP.Controls.Add(LocationNameTXT)
        LocationsTP.Controls.Add(LocLV)
        LocationsTP.Controls.Add(Label10)
        LocationsTP.Controls.Add(SearchLocTXT)
        LocationsTP.Controls.Add(Label8)
        LocationsTP.Location = New Point(4, 24)
        LocationsTP.Name = "LocationsTP"
        LocationsTP.Padding = New Padding(3)
        LocationsTP.Size = New Size(1560, 891)
        LocationsTP.TabIndex = 1
        LocationsTP.Text = "Locations"
        LocationsTP.UseVisualStyleBackColor = True
        ' 
        ' LocCancelBTN
        ' 
        LocCancelBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        LocCancelBTN.Cursor = Cursors.Hand
        LocCancelBTN.FlatAppearance.BorderSize = 0
        LocCancelBTN.FlatStyle = FlatStyle.Flat
        LocCancelBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LocCancelBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LocCancelBTN.Location = New Point(1416, 74)
        LocCancelBTN.Name = "LocCancelBTN"
        LocCancelBTN.Size = New Size(88, 26)
        LocCancelBTN.TabIndex = 93
        LocCancelBTN.Text = "Cancel"
        LocCancelBTN.UseVisualStyleBackColor = False
        LocCancelBTN.Visible = False
        ' 
        ' LocStatusCMB
        ' 
        LocStatusCMB.BackColor = Color.White
        LocStatusCMB.Cursor = Cursors.Hand
        LocStatusCMB.DropDownStyle = ComboBoxStyle.DropDownList
        LocStatusCMB.FlatStyle = FlatStyle.Flat
        LocStatusCMB.Font = New Font("Poppins", 9F)
        LocStatusCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LocStatusCMB.FormattingEnabled = True
        LocStatusCMB.Location = New Point(823, 294)
        LocStatusCMB.Name = "LocStatusCMB"
        LocStatusCMB.Size = New Size(666, 30)
        LocStatusCMB.TabIndex = 92
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label12.Location = New Point(817, 269)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 26)
        Label12.TabIndex = 91
        Label12.Text = "Status"
        ' 
        ' LocDeleteBTN
        ' 
        LocDeleteBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        LocDeleteBTN.Cursor = Cursors.Hand
        LocDeleteBTN.FlatAppearance.BorderSize = 0
        LocDeleteBTN.FlatStyle = FlatStyle.Flat
        LocDeleteBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LocDeleteBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LocDeleteBTN.Location = New Point(1290, 777)
        LocDeleteBTN.Name = "LocDeleteBTN"
        LocDeleteBTN.Size = New Size(196, 64)
        LocDeleteBTN.TabIndex = 90
        LocDeleteBTN.Text = "Delete"
        LocDeleteBTN.UseVisualStyleBackColor = False
        ' 
        ' LocEditBTN
        ' 
        LocEditBTN.BackColor = Color.FromArgb(CByte(216), CByte(221), CByte(67))
        LocEditBTN.Cursor = Cursors.Hand
        LocEditBTN.FlatAppearance.BorderSize = 0
        LocEditBTN.FlatStyle = FlatStyle.Flat
        LocEditBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LocEditBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LocEditBTN.Location = New Point(1056, 777)
        LocEditBTN.Name = "LocEditBTN"
        LocEditBTN.Size = New Size(196, 64)
        LocEditBTN.TabIndex = 89
        LocEditBTN.Text = "Edit"
        LocEditBTN.UseVisualStyleBackColor = False
        ' 
        ' LocAddBTN
        ' 
        LocAddBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        LocAddBTN.Cursor = Cursors.Hand
        LocAddBTN.FlatAppearance.BorderSize = 0
        LocAddBTN.FlatStyle = FlatStyle.Flat
        LocAddBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LocAddBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LocAddBTN.Location = New Point(821, 778)
        LocAddBTN.Name = "LocAddBTN"
        LocAddBTN.Size = New Size(196, 64)
        LocAddBTN.TabIndex = 88
        LocAddBTN.Text = "Add"
        LocAddBTN.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label11.Location = New Point(816, 339)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 26)
        Label11.TabIndex = 87
        Label11.Text = "Description"
        ' 
        ' LocDescTXT
        ' 
        LocDescTXT.BackColor = Color.White
        LocDescTXT.BorderStyle = BorderStyle.None
        LocDescTXT.Font = New Font("Poppins", 12F)
        LocDescTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LocDescTXT.Location = New Point(822, 367)
        LocDescTXT.Multiline = True
        LocDescTXT.Name = "LocDescTXT"
        LocDescTXT.Size = New Size(662, 122)
        LocDescTXT.TabIndex = 86
        ' 
        ' LocDeptCMB
        ' 
        LocDeptCMB.BackColor = Color.White
        LocDeptCMB.Cursor = Cursors.Hand
        LocDeptCMB.DropDownStyle = ComboBoxStyle.DropDownList
        LocDeptCMB.FlatStyle = FlatStyle.Flat
        LocDeptCMB.Font = New Font("Poppins", 9F)
        LocDeptCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LocDeptCMB.FormattingEnabled = True
        LocDeptCMB.Location = New Point(822, 224)
        LocDeptCMB.Name = "LocDeptCMB"
        LocDeptCMB.Size = New Size(666, 30)
        LocDeptCMB.TabIndex = 85
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label14.Location = New Point(816, 199)
        Label14.Name = "Label14"
        Label14.Size = New Size(102, 26)
        Label14.TabIndex = 84
        Label14.Text = "Department"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label13.Location = New Point(816, 129)
        Label13.Name = "Label13"
        Label13.Size = New Size(125, 26)
        Label13.TabIndex = 83
        Label13.Text = "Location Name"
        ' 
        ' LocationNameTXT
        ' 
        LocationNameTXT.BackColor = Color.White
        LocationNameTXT.BorderStyle = BorderStyle.None
        LocationNameTXT.Font = New Font("Poppins", 12F)
        LocationNameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LocationNameTXT.Location = New Point(822, 157)
        LocationNameTXT.Name = "LocationNameTXT"
        LocationNameTXT.Size = New Size(662, 24)
        LocationNameTXT.TabIndex = 82
        ' 
        ' LocLV
        ' 
        LocLV.BorderStyle = BorderStyle.None
        LocLV.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6})
        LocLV.Font = New Font("Poppins", 12F)
        LocLV.FullRowSelect = True
        LocLV.GridLines = True
        LocLV.Location = New Point(39, 109)
        LocLV.MultiSelect = False
        LocLV.Name = "LocLV"
        LocLV.Size = New Size(710, 750)
        LocLV.TabIndex = 81
        LocLV.UseCompatibleStateImageBehavior = False
        LocLV.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Location"
        ColumnHeader4.Width = 275
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Department"
        ColumnHeader5.Width = 275
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Status"
        ColumnHeader6.Width = 160
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label10.Location = New Point(33, 80)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 26)
        Label10.TabIndex = 80
        Label10.Text = "Locations List"
        ' 
        ' SearchLocTXT
        ' 
        SearchLocTXT.BackColor = Color.White
        SearchLocTXT.BorderStyle = BorderStyle.None
        SearchLocTXT.Font = New Font("Poppins", 12F)
        SearchLocTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchLocTXT.Location = New Point(72, 35)
        SearchLocTXT.Name = "SearchLocTXT"
        SearchLocTXT.Size = New Size(1432, 24)
        SearchLocTXT.TabIndex = 64
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(36, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 26)
        Label8.TabIndex = 63
        Label8.Text = "Search Location"
        ' 
        ' DeptLocUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "DeptLocUC"
        Size = New Size(1537, 1001)
        Panel1.ResumeLayout(False)
        CType(LocationsPB, ComponentModel.ISupportInitialize).EndInit()
        CType(DepartmentPB, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        DeptTP.ResumeLayout(False)
        DeptTP.PerformLayout()
        LocationsTP.ResumeLayout(False)
        LocationsTP.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DepartmentsBTN As Button
    Friend WithEvents LocationsBTN As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DeptTP As TabPage
    Friend WithEvents LocationsTP As TabPage
    Friend WithEvents SearchDeptTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactNumTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DeptHeadCMB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentNameTXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DeptDescTXT As TextBox
    Friend WithEvents StatusCMB As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DeptDeleteBTN As Button
    Friend WithEvents DeptEditBTN As Button
    Friend WithEvents DeptAddBTN As Button
    Friend WithEvents DeptCancelBTN As Button
    Friend WithEvents DeptLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents LocationsPB As PictureBox
    Friend WithEvents DepartmentPB As PictureBox
    Friend WithEvents SearchLocTXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LocLV As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents LocStatusCMB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LocDeleteBTN As Button
    Friend WithEvents LocEditBTN As Button
    Friend WithEvents LocAddBTN As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents LocDescTXT As TextBox
    Friend WithEvents LocDeptCMB As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LocationNameTXT As TextBox
    Friend WithEvents LocCancelBTN As Button

End Class
