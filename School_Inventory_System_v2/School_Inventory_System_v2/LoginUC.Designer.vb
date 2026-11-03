<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginUC))
        LoginBTN = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PasswordTXT = New TextBox()
        UsernameTXT = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' LoginBTN
        ' 
        LoginBTN.BackColor = Color.FromArgb(CByte(214), CByte(176), CByte(96))
        LoginBTN.Cursor = Cursors.Hand
        LoginBTN.FlatAppearance.BorderSize = 0
        LoginBTN.FlatStyle = FlatStyle.Flat
        LoginBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        LoginBTN.Location = New Point(722, 666)
        LoginBTN.Name = "LoginBTN"
        LoginBTN.Size = New Size(477, 64)
        LoginBTN.TabIndex = 16
        LoginBTN.Text = "LOGIN"
        LoginBTN.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label3.Location = New Point(717, 586)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 26)
        Label3.TabIndex = 15
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label2.Location = New Point(717, 516)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 26)
        Label2.TabIndex = 14
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label1.Location = New Point(803, 431)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 42)
        Label1.TabIndex = 13
        Label1.Text = "School Inventory System"
        ' 
        ' PasswordTXT
        ' 
        PasswordTXT.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(129))
        PasswordTXT.BorderStyle = BorderStyle.None
        PasswordTXT.Font = New Font("Poppins", 12F)
        PasswordTXT.ForeColor = Color.White
        PasswordTXT.Location = New Point(759, 613)
        PasswordTXT.Name = "PasswordTXT"
        PasswordTXT.Size = New Size(438, 24)
        PasswordTXT.TabIndex = 12
        PasswordTXT.UseSystemPasswordChar = True
        ' 
        ' UsernameTXT
        ' 
        UsernameTXT.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(129))
        UsernameTXT.BorderStyle = BorderStyle.None
        UsernameTXT.Font = New Font("Poppins", 12F)
        UsernameTXT.ForeColor = Color.White
        UsernameTXT.Location = New Point(759, 545)
        UsernameTXT.Name = "UsernameTXT"
        UsernameTXT.Size = New Size(438, 24)
        UsernameTXT.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(1881, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(36, 34)
        Button1.TabIndex = 19
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LoginUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(Button1)
        Controls.Add(LoginBTN)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PasswordTXT)
        Controls.Add(UsernameTXT)
        Name = "LoginUC"
        Size = New Size(1920, 1080)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LoginBTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTXT As TextBox
    Friend WithEvents UsernameTXT As TextBox
    Friend WithEvents Button1 As Button

End Class
