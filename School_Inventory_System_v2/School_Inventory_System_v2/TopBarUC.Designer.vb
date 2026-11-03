<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopBarUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopBarUC))
        Label1 = New Label()
        NameLBL = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        Label1.Location = New Point(1516, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 42)
        Label1.TabIndex = 14
        Label1.Text = "School Inventory System"
        ' 
        ' NameLBL
        ' 
        NameLBL.AutoSize = True
        NameLBL.BackColor = Color.Transparent
        NameLBL.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameLBL.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        NameLBL.ImageAlign = ContentAlignment.MiddleRight
        NameLBL.Location = New Point(17, 19)
        NameLBL.Name = "NameLBL"
        NameLBL.Size = New Size(92, 42)
        NameLBL.TabIndex = 15
        NameLBL.Text = "Name"
        ' 
        ' TopBarUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(38), CByte(100), CByte(176))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(NameLBL)
        Controls.Add(Label1)
        Name = "TopBarUC"
        Size = New Size(1919, 79)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameLBL As Label

End Class
