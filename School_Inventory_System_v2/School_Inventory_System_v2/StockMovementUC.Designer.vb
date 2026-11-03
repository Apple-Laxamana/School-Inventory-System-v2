<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMovementUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMovementUC))
        Label23 = New Label()
        Label5 = New Label()
        StockInDTP = New DateTimePicker()
        MovementTypeCMB = New ComboBox()
        Label4 = New Label()
        RemarksTXT = New TextBox()
        Label3 = New Label()
        ItemsToStockInLV = New ListView()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        Label2 = New Label()
        AvailableItemsLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        Label7 = New Label()
        SearchAvailItemsTXT = New TextBox()
        Label9 = New Label()
        RemoveSelectedBTN = New Button()
        AddSelectedBTN = New Button()
        QuantityToAddTXT = New TextBox()
        UpdateQuantityBTN = New Button()
        AvailableStocksLBL = New Label()
        Label13 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        TotalUnitsLBL = New Label()
        DifferentItemsLBL = New Label()
        Label10 = New Label()
        Label11 = New Label()
        ClearBTN = New Button()
        StockInBTN = New Button()
        SuspendLayout()
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.Transparent
        Label23.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label23.Location = New Point(32, 17)
        Label23.Name = "Label23"
        Label23.Size = New Size(184, 26)
        Label23.TabIndex = 108
        Label23.Text = "Movement Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(789, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 26)
        Label5.TabIndex = 107
        Label5.Text = "Remarks"
        ' 
        ' StockInDTP
        ' 
        StockInDTP.CalendarFont = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StockInDTP.CalendarForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        StockInDTP.CalendarMonthBackground = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        StockInDTP.CalendarTitleBackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        StockInDTP.CalendarTrailingForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        StockInDTP.Cursor = Cursors.Hand
        StockInDTP.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StockInDTP.Location = New Point(415, 80)
        StockInDTP.MinDate = New Date(2026, 8, 1, 0, 0, 0, 0)
        StockInDTP.Name = "StockInDTP"
        StockInDTP.Size = New Size(335, 30)
        StockInDTP.TabIndex = 106
        ' 
        ' MovementTypeCMB
        ' 
        MovementTypeCMB.BackColor = Color.White
        MovementTypeCMB.Cursor = Cursors.Hand
        MovementTypeCMB.DropDownStyle = ComboBoxStyle.DropDownList
        MovementTypeCMB.FlatStyle = FlatStyle.Flat
        MovementTypeCMB.Font = New Font("Poppins", 9F)
        MovementTypeCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        MovementTypeCMB.FormattingEnabled = True
        MovementTypeCMB.Location = New Point(52, 80)
        MovementTypeCMB.Name = "MovementTypeCMB"
        MovementTypeCMB.Size = New Size(335, 30)
        MovementTypeCMB.TabIndex = 105
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(415, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 26)
        Label4.TabIndex = 104
        Label4.Text = "Date/Time"
        ' 
        ' RemarksTXT
        ' 
        RemarksTXT.BackColor = Color.White
        RemarksTXT.BorderStyle = BorderStyle.None
        RemarksTXT.Font = New Font("Poppins", 12F)
        RemarksTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RemarksTXT.Location = New Point(789, 83)
        RemarksTXT.Name = "RemarksTXT"
        RemarksTXT.Size = New Size(692, 24)
        RemarksTXT.TabIndex = 103
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(51, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 26)
        Label3.TabIndex = 102
        Label3.Text = "Movement Type"
        ' 
        ' ItemsToStockInLV
        ' 
        ItemsToStockInLV.BorderStyle = BorderStyle.None
        ItemsToStockInLV.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader8})
        ItemsToStockInLV.Font = New Font("Poppins", 12F)
        ItemsToStockInLV.FullRowSelect = True
        ItemsToStockInLV.GridLines = True
        ItemsToStockInLV.Location = New Point(791, 195)
        ItemsToStockInLV.MultiSelect = False
        ItemsToStockInLV.Name = "ItemsToStockInLV"
        ItemsToStockInLV.Size = New Size(715, 407)
        ItemsToStockInLV.TabIndex = 116
        ItemsToStockInLV.UseCompatibleStateImageBehavior = False
        ItemsToStockInLV.View = View.Details
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Name"
        ColumnHeader7.Width = 114
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Quantity"
        ColumnHeader8.Width = 114
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(789, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 26)
        Label2.TabIndex = 115
        Label2.Text = "Items to Stock In"
        ' 
        ' AvailableItemsLV
        ' 
        AvailableItemsLV.BorderStyle = BorderStyle.None
        AvailableItemsLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        AvailableItemsLV.Font = New Font("Poppins", 12F)
        AvailableItemsLV.FullRowSelect = True
        AvailableItemsLV.GridLines = True
        AvailableItemsLV.Location = New Point(32, 264)
        AvailableItemsLV.MultiSelect = False
        AvailableItemsLV.Name = "AvailableItemsLV"
        AvailableItemsLV.Size = New Size(715, 338)
        AvailableItemsLV.TabIndex = 114
        AvailableItemsLV.UseCompatibleStateImageBehavior = False
        AvailableItemsLV.View = View.Details
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label7.Location = New Point(29, 234)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 26)
        Label7.TabIndex = 113
        Label7.Text = "Available Items"
        ' 
        ' SearchAvailItemsTXT
        ' 
        SearchAvailItemsTXT.BackColor = Color.White
        SearchAvailItemsTXT.BorderStyle = BorderStyle.None
        SearchAvailItemsTXT.Font = New Font("Poppins", 12F)
        SearchAvailItemsTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchAvailItemsTXT.Location = New Point(71, 193)
        SearchAvailItemsTXT.Name = "SearchAvailItemsTXT"
        SearchAvailItemsTXT.Size = New Size(676, 24)
        SearchAvailItemsTXT.TabIndex = 110
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(28, 166)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 26)
        Label9.TabIndex = 109
        Label9.Text = "Search Available Item"
        ' 
        ' RemoveSelectedBTN
        ' 
        RemoveSelectedBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        RemoveSelectedBTN.Cursor = Cursors.Hand
        RemoveSelectedBTN.FlatAppearance.BorderSize = 0
        RemoveSelectedBTN.FlatStyle = FlatStyle.Flat
        RemoveSelectedBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveSelectedBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        RemoveSelectedBTN.Location = New Point(791, 611)
        RemoveSelectedBTN.Name = "RemoveSelectedBTN"
        RemoveSelectedBTN.Size = New Size(144, 26)
        RemoveSelectedBTN.TabIndex = 118
        RemoveSelectedBTN.Text = "Remove Selected"
        RemoveSelectedBTN.UseVisualStyleBackColor = False
        ' 
        ' AddSelectedBTN
        ' 
        AddSelectedBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        AddSelectedBTN.Cursor = Cursors.Hand
        AddSelectedBTN.FlatAppearance.BorderSize = 0
        AddSelectedBTN.FlatStyle = FlatStyle.Flat
        AddSelectedBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddSelectedBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        AddSelectedBTN.Location = New Point(603, 611)
        AddSelectedBTN.Name = "AddSelectedBTN"
        AddSelectedBTN.Size = New Size(144, 26)
        AddSelectedBTN.TabIndex = 117
        AddSelectedBTN.Text = "Add Selected"
        AddSelectedBTN.UseVisualStyleBackColor = False
        ' 
        ' QuantityToAddTXT
        ' 
        QuantityToAddTXT.BackColor = Color.White
        QuantityToAddTXT.BorderStyle = BorderStyle.None
        QuantityToAddTXT.Font = New Font("Poppins", 12F)
        QuantityToAddTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        QuantityToAddTXT.Location = New Point(76, 701)
        QuantityToAddTXT.Name = "QuantityToAddTXT"
        QuantityToAddTXT.Size = New Size(671, 24)
        QuantityToAddTXT.TabIndex = 126
        ' 
        ' UpdateQuantityBTN
        ' 
        UpdateQuantityBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        UpdateQuantityBTN.Cursor = Cursors.Hand
        UpdateQuantityBTN.FlatAppearance.BorderSize = 0
        UpdateQuantityBTN.FlatStyle = FlatStyle.Flat
        UpdateQuantityBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateQuantityBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        UpdateQuantityBTN.Location = New Point(71, 739)
        UpdateQuantityBTN.Name = "UpdateQuantityBTN"
        UpdateQuantityBTN.Size = New Size(679, 26)
        UpdateQuantityBTN.TabIndex = 124
        UpdateQuantityBTN.Text = "Update Quantity"
        UpdateQuantityBTN.UseVisualStyleBackColor = False
        UpdateQuantityBTN.Visible = False
        ' 
        ' AvailableStocksLBL
        ' 
        AvailableStocksLBL.AutoSize = True
        AvailableStocksLBL.BackColor = Color.Transparent
        AvailableStocksLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AvailableStocksLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        AvailableStocksLBL.Location = New Point(791, 700)
        AvailableStocksLBL.Name = "AvailableStocksLBL"
        AvailableStocksLBL.Size = New Size(150, 30)
        AvailableStocksLBL.TabIndex = 123
        AvailableStocksLBL.Text = "Available Stocks"
        AvailableStocksLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label13.Location = New Point(789, 668)
        Label13.Name = "Label13"
        Label13.Size = New Size(187, 30)
        Label13.TabIndex = 121
        Label13.Text = "New Available Stock:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(71, 668)
        Label8.Name = "Label8"
        Label8.Size = New Size(145, 30)
        Label8.TabIndex = 120
        Label8.Text = "Quantity to add"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(32, 628)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 26)
        Label6.TabIndex = 119
        Label6.Text = "Item Details"
        ' 
        ' TotalUnitsLBL
        ' 
        TotalUnitsLBL.AutoSize = True
        TotalUnitsLBL.BackColor = Color.Transparent
        TotalUnitsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalUnitsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalUnitsLBL.Location = New Point(1413, 838)
        TotalUnitsLBL.Name = "TotalUnitsLBL"
        TotalUnitsLBL.Size = New Size(57, 30)
        TotalUnitsLBL.TabIndex = 130
        TotalUnitsLBL.Text = "0000"
        TotalUnitsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DifferentItemsLBL
        ' 
        DifferentItemsLBL.AutoSize = True
        DifferentItemsLBL.BackColor = Color.Transparent
        DifferentItemsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DifferentItemsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DifferentItemsLBL.Location = New Point(1413, 808)
        DifferentItemsLBL.Name = "DifferentItemsLBL"
        DifferentItemsLBL.Size = New Size(57, 30)
        DifferentItemsLBL.TabIndex = 129
        DifferentItemsLBL.Text = "0000"
        DifferentItemsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label10.Location = New Point(76, 808)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 30)
        Label10.TabIndex = 128
        Label10.Text = "Different items"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label11.Location = New Point(76, 838)
        Label11.Name = "Label11"
        Label11.Size = New Size(179, 30)
        Label11.TabIndex = 127
        Label11.Text = "Total units received"
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        ClearBTN.Cursor = Cursors.Hand
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ClearBTN.Location = New Point(32, 911)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(718, 64)
        ClearBTN.TabIndex = 132
        ClearBTN.Text = "Clear Selected"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' StockInBTN
        ' 
        StockInBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        StockInBTN.Cursor = Cursors.Hand
        StockInBTN.FlatAppearance.BorderSize = 0
        StockInBTN.FlatStyle = FlatStyle.Flat
        StockInBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StockInBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        StockInBTN.Location = New Point(794, 911)
        StockInBTN.Name = "StockInBTN"
        StockInBTN.Size = New Size(715, 64)
        StockInBTN.TabIndex = 131
        StockInBTN.Text = "Stock In"
        StockInBTN.UseVisualStyleBackColor = False
        ' 
        ' StockMovementUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(ClearBTN)
        Controls.Add(StockInBTN)
        Controls.Add(TotalUnitsLBL)
        Controls.Add(DifferentItemsLBL)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(QuantityToAddTXT)
        Controls.Add(UpdateQuantityBTN)
        Controls.Add(AvailableStocksLBL)
        Controls.Add(Label13)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(RemoveSelectedBTN)
        Controls.Add(AddSelectedBTN)
        Controls.Add(ItemsToStockInLV)
        Controls.Add(Label2)
        Controls.Add(AvailableItemsLV)
        Controls.Add(Label7)
        Controls.Add(SearchAvailItemsTXT)
        Controls.Add(Label9)
        Controls.Add(Label23)
        Controls.Add(Label5)
        Controls.Add(StockInDTP)
        Controls.Add(MovementTypeCMB)
        Controls.Add(Label4)
        Controls.Add(RemarksTXT)
        Controls.Add(Label3)
        Name = "StockMovementUC"
        Size = New Size(1537, 1001)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label23 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StockInDTP As DateTimePicker
    Friend WithEvents MovementTypeCMB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RemarksTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ItemsToStockInLV As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents AvailableItemsLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchAvailItemsTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RemoveSelectedBTN As Button
    Friend WithEvents AddSelectedBTN As Button
    Friend WithEvents QuantityToAddTXT As TextBox
    Friend WithEvents UpdateQuantityBTN As Button
    Friend WithEvents AvailableStocksLBL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalUnitsLBL As Label
    Friend WithEvents DifferentItemsLBL As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ClearBTN As Button
    Friend WithEvents StockInBTN As Button

End Class
