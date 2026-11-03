<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagementUC))
        Panel1 = New Panel()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        UserPB = New PictureBox()
        CancelBTN = New Button()
        UserLV = New ListView()
        SearchTXT = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        RoleCMB = New ComboBox()
        StatusCMB = New ComboBox()
        PasswordTXT = New TextBox()
        UsernameTXT = New TextBox()
        BrowseImageBTN = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        DeleteBTN = New Button()
        EditBTN = New Button()
        AddBTN = New Button()
        Label2 = New Label()
        FullNameTXT = New TextBox()
        CType(UserPB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Location = New Point(1213, 158)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(119, 119)
        Panel1.TabIndex = 63
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Status"
        ColumnHeader4.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Role"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Username"
        ColumnHeader2.Width = 269
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Full Name"
        ColumnHeader1.Width = 300
        ' 
        ' UserPB
        ' 
        UserPB.BackColor = Color.White
        UserPB.Location = New Point(1215, 160)
        UserPB.Name = "UserPB"
        UserPB.Size = New Size(115, 115)
        UserPB.TabIndex = 56
        UserPB.TabStop = False
        ' 
        ' CancelBTN
        ' 
        CancelBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        CancelBTN.Cursor = Cursors.Hand
        CancelBTN.FlatAppearance.BorderSize = 0
        CancelBTN.FlatStyle = FlatStyle.Flat
        CancelBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CancelBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        CancelBTN.Location = New Point(1413, 99)
        CancelBTN.Name = "CancelBTN"
        CancelBTN.Size = New Size(88, 26)
        CancelBTN.TabIndex = 62
        CancelBTN.Text = "Cancel"
        CancelBTN.UseVisualStyleBackColor = False
        CancelBTN.Visible = False
        ' 
        ' UserLV
        ' 
        UserLV.BorderStyle = BorderStyle.None
        UserLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        UserLV.Font = New Font("Poppins", 12F)
        UserLV.FullRowSelect = True
        UserLV.GridLines = True
        UserLV.Location = New Point(36, 135)
        UserLV.MultiSelect = False
        UserLV.Name = "UserLV"
        UserLV.Size = New Size(975, 830)
        UserLV.TabIndex = 61
        UserLV.UseCompatibleStateImageBehavior = False
        UserLV.View = View.Details
        ' 
        ' SearchTXT
        ' 
        SearchTXT.BackColor = Color.White
        SearchTXT.BorderStyle = BorderStyle.None
        SearchTXT.Font = New Font("Poppins", 12F)
        SearchTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchTXT.Location = New Point(71, 56)
        SearchTXT.Name = "SearchTXT"
        SearchTXT.Size = New Size(1430, 24)
        SearchTXT.TabIndex = 60
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label9.Location = New Point(33, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 26)
        Label9.TabIndex = 59
        Label9.Text = "Search User"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label8.Location = New Point(1043, 130)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 26)
        Label8.TabIndex = 58
        Label8.Text = "User Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label7.Location = New Point(33, 130)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 26)
        Label7.TabIndex = 57
        Label7.Text = "Users List"
        ' 
        ' RoleCMB
        ' 
        RoleCMB.BackColor = Color.White
        RoleCMB.Cursor = Cursors.Hand
        RoleCMB.DropDownStyle = ComboBoxStyle.DropDownList
        RoleCMB.FlatStyle = FlatStyle.Flat
        RoleCMB.Font = New Font("Poppins", 9F)
        RoleCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RoleCMB.FormattingEnabled = True
        RoleCMB.Location = New Point(1068, 514)
        RoleCMB.Name = "RoleCMB"
        RoleCMB.Size = New Size(416, 30)
        RoleCMB.TabIndex = 55
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
        StatusCMB.Location = New Point(1068, 584)
        StatusCMB.Name = "StatusCMB"
        StatusCMB.Size = New Size(416, 30)
        StatusCMB.TabIndex = 54
        ' 
        ' PasswordTXT
        ' 
        PasswordTXT.BackColor = Color.White
        PasswordTXT.BorderStyle = BorderStyle.None
        PasswordTXT.Font = New Font("Poppins", 12F)
        PasswordTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        PasswordTXT.Location = New Point(1070, 447)
        PasswordTXT.Name = "PasswordTXT"
        PasswordTXT.Size = New Size(411, 24)
        PasswordTXT.TabIndex = 53
        PasswordTXT.UseSystemPasswordChar = True
        ' 
        ' UsernameTXT
        ' 
        UsernameTXT.BackColor = Color.White
        UsernameTXT.BorderStyle = BorderStyle.None
        UsernameTXT.Font = New Font("Poppins", 12F)
        UsernameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        UsernameTXT.Location = New Point(1070, 377)
        UsernameTXT.Name = "UsernameTXT"
        UsernameTXT.Size = New Size(411, 24)
        UsernameTXT.TabIndex = 52
        ' 
        ' BrowseImageBTN
        ' 
        BrowseImageBTN.BackColor = Color.White
        BrowseImageBTN.Cursor = Cursors.Hand
        BrowseImageBTN.FlatAppearance.BorderSize = 0
        BrowseImageBTN.FlatStyle = FlatStyle.Flat
        BrowseImageBTN.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BrowseImageBTN.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        BrowseImageBTN.Location = New Point(1069, 654)
        BrowseImageBTN.Name = "BrowseImageBTN"
        BrowseImageBTN.Size = New Size(411, 30)
        BrowseImageBTN.TabIndex = 51
        BrowseImageBTN.Text = "Browse Image"
        BrowseImageBTN.TextAlign = ContentAlignment.MiddleLeft
        BrowseImageBTN.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(1063, 633)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 26)
        Label6.TabIndex = 50
        Label6.Text = "Profile Image"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(1063, 562)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 26)
        Label5.TabIndex = 49
        Label5.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(1063, 493)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 26)
        Label4.TabIndex = 48
        Label4.Text = "Role"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(1063, 422)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 26)
        Label3.TabIndex = 47
        Label3.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label1.Location = New Point(1063, 352)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 26)
        Label1.TabIndex = 46
        Label1.Text = "Username"
        ' 
        ' DeleteBTN
        ' 
        DeleteBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        DeleteBTN.Cursor = Cursors.Hand
        DeleteBTN.FlatAppearance.BorderSize = 0
        DeleteBTN.FlatStyle = FlatStyle.Flat
        DeleteBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        DeleteBTN.Location = New Point(1287, 885)
        DeleteBTN.Name = "DeleteBTN"
        DeleteBTN.Size = New Size(196, 64)
        DeleteBTN.TabIndex = 45
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
        EditBTN.Location = New Point(1069, 885)
        EditBTN.Name = "EditBTN"
        EditBTN.Size = New Size(196, 64)
        EditBTN.TabIndex = 44
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
        AddBTN.Location = New Point(1070, 806)
        AddBTN.Name = "AddBTN"
        AddBTN.Size = New Size(412, 64)
        AddBTN.TabIndex = 43
        AddBTN.Text = "Add"
        AddBTN.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(1063, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 26)
        Label2.TabIndex = 42
        Label2.Text = "Full Name"
        ' 
        ' FullNameTXT
        ' 
        FullNameTXT.BackColor = Color.White
        FullNameTXT.BorderStyle = BorderStyle.None
        FullNameTXT.Font = New Font("Poppins", 12F)
        FullNameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        FullNameTXT.Location = New Point(1070, 307)
        FullNameTXT.Name = "FullNameTXT"
        FullNameTXT.Size = New Size(411, 24)
        FullNameTXT.TabIndex = 41
        ' 
        ' UserManagementUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(UserPB)
        Controls.Add(CancelBTN)
        Controls.Add(UserLV)
        Controls.Add(SearchTXT)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(RoleCMB)
        Controls.Add(StatusCMB)
        Controls.Add(PasswordTXT)
        Controls.Add(UsernameTXT)
        Controls.Add(BrowseImageBTN)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(DeleteBTN)
        Controls.Add(EditBTN)
        Controls.Add(AddBTN)
        Controls.Add(Label2)
        Controls.Add(FullNameTXT)
        Controls.Add(Panel1)
        Name = "UserManagementUC"
        Size = New Size(1537, 1001)
        CType(UserPB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents UserPB As PictureBox
    Friend WithEvents CancelBTN As Button
    Friend WithEvents UserLV As ListView
    Friend WithEvents SearchTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RoleCMB As ComboBox
    Friend WithEvents StatusCMB As ComboBox
    Friend WithEvents PasswordTXT As TextBox
    Friend WithEvents UsernameTXT As TextBox
    Friend WithEvents BrowseImageBTN As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents EditBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FullNameTXT As TextBox

End Class
