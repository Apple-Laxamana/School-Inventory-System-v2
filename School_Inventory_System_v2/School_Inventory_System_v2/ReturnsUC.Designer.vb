<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnsUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnsUC))
        SearchItemsToReturnTXT = New TextBox()
        Label9 = New Label()
        ItemsToReturnLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Label7 = New Label()
        RemoveSelectedBTN = New Button()
        AddSelectedBTN = New Button()
        ItemsForReturnLV = New ListView()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        Label2 = New Label()
        ItemNameLBL = New Label()
        RecepientNameLBL = New Label()
        TotalQuantityLBL = New Label()
        Label13 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        QuantityToReturnTXT = New TextBox()
        Label1 = New Label()
        ConditionCMB = New ComboBox()
        Label3 = New Label()
        Label5 = New Label()
        RemarksTXT = New TextBox()
        UpdateQuantityBTN = New Button()
        ClearBTN = New Button()
        ReturnBTN = New Button()
        TotalUnitsLBL = New Label()
        DifferentItemsLBL = New Label()
        Label4 = New Label()
        Label6 = New Label()
        ReturnHistoryLV = New ListView()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        ColumnHeader17 = New ColumnHeader()
        Label12 = New Label()
        SearchReturnHistoryTXT = New TextBox()
        Label14 = New Label()
        ReturnDateDTP = New DateTimePicker()
        UpdateRemarksBTN = New Button()
        SuspendLayout()
        ' 
        ' SearchItemsToReturnTXT
        ' 
        SearchItemsToReturnTXT.BackColor = Color.White
        SearchItemsToReturnTXT.BorderStyle = BorderStyle.None
        SearchItemsToReturnTXT.Font = New Font("Poppins", 12F)
        SearchItemsToReturnTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchItemsToReturnTXT.Location = New Point(71, 46)
        SearchItemsToReturnTXT.Name = "SearchItemsToReturnTXT"
        SearchItemsToReturnTXT.Size = New Size(676, 24)
        SearchItemsToReturnTXT.TabIndex = 112
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(28, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 26)
        Label9.TabIndex = 111
        Label9.Text = "Search items"
        ' 
        ' ItemsToReturnLV
        ' 
        ItemsToReturnLV.BorderStyle = BorderStyle.None
        ItemsToReturnLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        ItemsToReturnLV.Font = New Font("Poppins", 12F)
        ItemsToReturnLV.FullRowSelect = True
        ItemsToReturnLV.GridLines = True
        ItemsToReturnLV.Location = New Point(32, 117)
        ItemsToReturnLV.MultiSelect = False
        ItemsToReturnLV.Name = "ItemsToReturnLV"
        ItemsToReturnLV.Size = New Size(715, 361)
        ItemsToReturnLV.TabIndex = 116
        ItemsToReturnLV.UseCompatibleStateImageBehavior = False
        ItemsToReturnLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ColumnHeader1.Width = 114
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Item"
        ColumnHeader2.Width = 114
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Issued"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Returned"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Remaining"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label7.Location = New Point(29, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 26)
        Label7.TabIndex = 115
        Label7.Text = "Items to Return"
        ' 
        ' RemoveSelectedBTN
        ' 
        RemoveSelectedBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        RemoveSelectedBTN.Cursor = Cursors.Hand
        RemoveSelectedBTN.FlatAppearance.BorderSize = 0
        RemoveSelectedBTN.FlatStyle = FlatStyle.Flat
        RemoveSelectedBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveSelectedBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        RemoveSelectedBTN.Location = New Point(791, 306)
        RemoveSelectedBTN.Name = "RemoveSelectedBTN"
        RemoveSelectedBTN.Size = New Size(144, 26)
        RemoveSelectedBTN.TabIndex = 120
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
        AddSelectedBTN.Location = New Point(603, 490)
        AddSelectedBTN.Name = "AddSelectedBTN"
        AddSelectedBTN.Size = New Size(144, 26)
        AddSelectedBTN.TabIndex = 119
        AddSelectedBTN.Text = "Add Selected"
        AddSelectedBTN.UseVisualStyleBackColor = False
        ' 
        ' ItemsForReturnLV
        ' 
        ItemsForReturnLV.BorderStyle = BorderStyle.None
        ItemsForReturnLV.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader8, ColumnHeader6, ColumnHeader9})
        ItemsForReturnLV.Font = New Font("Poppins", 12F)
        ItemsForReturnLV.FullRowSelect = True
        ItemsForReturnLV.GridLines = True
        ItemsForReturnLV.Location = New Point(791, 46)
        ItemsForReturnLV.MultiSelect = False
        ItemsForReturnLV.Name = "ItemsForReturnLV"
        ItemsForReturnLV.Size = New Size(715, 245)
        ItemsForReturnLV.TabIndex = 122
        ItemsForReturnLV.UseCompatibleStateImageBehavior = False
        ItemsForReturnLV.View = View.Details
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Name"
        ColumnHeader7.Width = 114
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Item"
        ColumnHeader8.Width = 114
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Quantity"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Condition"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(789, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 26)
        Label2.TabIndex = 121
        Label2.Text = "Selected Items for Return"
        ' 
        ' ItemNameLBL
        ' 
        ItemNameLBL.AutoSize = True
        ItemNameLBL.BackColor = Color.Transparent
        ItemNameLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItemNameLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemNameLBL.Location = New Point(897, 372)
        ItemNameLBL.Name = "ItemNameLBL"
        ItemNameLBL.Size = New Size(108, 30)
        ItemNameLBL.TabIndex = 130
        ItemNameLBL.Text = "Item name"
        ItemNameLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RecepientNameLBL
        ' 
        RecepientNameLBL.AutoSize = True
        RecepientNameLBL.BackColor = Color.Transparent
        RecepientNameLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RecepientNameLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RecepientNameLBL.Location = New Point(897, 342)
        RecepientNameLBL.Name = "RecepientNameLBL"
        RecepientNameLBL.Size = New Size(173, 30)
        RecepientNameLBL.TabIndex = 129
        RecepientNameLBL.Text = "Name of recepient"
        RecepientNameLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TotalQuantityLBL
        ' 
        TotalQuantityLBL.AutoSize = True
        TotalQuantityLBL.BackColor = Color.Transparent
        TotalQuantityLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalQuantityLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalQuantityLBL.Location = New Point(1313, 342)
        TotalQuantityLBL.Name = "TotalQuantityLBL"
        TotalQuantityLBL.Size = New Size(57, 30)
        TotalQuantityLBL.TabIndex = 127
        TotalQuantityLBL.Text = "0000"
        TotalQuantityLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label13.Location = New Point(789, 342)
        Label13.Name = "Label13"
        Label13.Size = New Size(102, 30)
        Label13.TabIndex = 126
        Label13.Text = "Recepient:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label11.Location = New Point(789, 372)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 30)
        Label11.TabIndex = 125
        Label11.Text = "Item:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label10.Location = New Point(1172, 372)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 30)
        Label10.TabIndex = 124
        Label10.Text = "Return Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(1172, 342)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 30)
        Label8.TabIndex = 123
        Label8.Text = "Total Quantity:"
        ' 
        ' QuantityToReturnTXT
        ' 
        QuantityToReturnTXT.BackColor = Color.White
        QuantityToReturnTXT.BorderStyle = BorderStyle.None
        QuantityToReturnTXT.Font = New Font("Poppins", 12F)
        QuantityToReturnTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        QuantityToReturnTXT.Location = New Point(790, 439)
        QuantityToReturnTXT.Name = "QuantityToReturnTXT"
        QuantityToReturnTXT.Size = New Size(226, 24)
        QuantityToReturnTXT.TabIndex = 132
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F)
        Label1.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label1.Location = New Point(789, 412)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 26)
        Label1.TabIndex = 131
        Label1.Text = "Quantity to Return"
        ' 
        ' ConditionCMB
        ' 
        ConditionCMB.BackColor = Color.White
        ConditionCMB.Cursor = Cursors.Hand
        ConditionCMB.DropDownStyle = ComboBoxStyle.DropDownList
        ConditionCMB.FlatStyle = FlatStyle.Flat
        ConditionCMB.Font = New Font("Poppins", 9F)
        ConditionCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ConditionCMB.FormattingEnabled = True
        ConditionCMB.Location = New Point(1169, 436)
        ConditionCMB.Name = "ConditionCMB"
        ConditionCMB.Size = New Size(340, 30)
        ConditionCMB.TabIndex = 134
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(1171, 412)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 26)
        Label3.TabIndex = 133
        Label3.Text = "Condition"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(789, 474)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 26)
        Label5.TabIndex = 136
        Label5.Text = "Remarks"
        ' 
        ' RemarksTXT
        ' 
        RemarksTXT.BackColor = Color.White
        RemarksTXT.BorderStyle = BorderStyle.None
        RemarksTXT.Font = New Font("Poppins", 12F)
        RemarksTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RemarksTXT.Location = New Point(790, 501)
        RemarksTXT.Name = "RemarksTXT"
        RemarksTXT.Size = New Size(602, 24)
        RemarksTXT.TabIndex = 135
        ' 
        ' UpdateQuantityBTN
        ' 
        UpdateQuantityBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        UpdateQuantityBTN.Cursor = Cursors.Hand
        UpdateQuantityBTN.FlatAppearance.BorderSize = 0
        UpdateQuantityBTN.FlatStyle = FlatStyle.Flat
        UpdateQuantityBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateQuantityBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        UpdateQuantityBTN.Location = New Point(1027, 436)
        UpdateQuantityBTN.Name = "UpdateQuantityBTN"
        UpdateQuantityBTN.Size = New Size(82, 30)
        UpdateQuantityBTN.TabIndex = 137
        UpdateQuantityBTN.Text = "Update"
        UpdateQuantityBTN.UseVisualStyleBackColor = False
        UpdateQuantityBTN.Visible = False
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        ClearBTN.Cursor = Cursors.Hand
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ClearBTN.Location = New Point(28, 632)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(718, 64)
        ClearBTN.TabIndex = 139
        ClearBTN.Text = "Clear Selected"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' ReturnBTN
        ' 
        ReturnBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        ReturnBTN.Cursor = Cursors.Hand
        ReturnBTN.FlatAppearance.BorderSize = 0
        ReturnBTN.FlatStyle = FlatStyle.Flat
        ReturnBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ReturnBTN.Location = New Point(790, 632)
        ReturnBTN.Name = "ReturnBTN"
        ReturnBTN.Size = New Size(715, 64)
        ReturnBTN.TabIndex = 138
        ReturnBTN.Text = "Return"
        ReturnBTN.UseVisualStyleBackColor = False
        ' 
        ' TotalUnitsLBL
        ' 
        TotalUnitsLBL.AutoSize = True
        TotalUnitsLBL.BackColor = Color.Transparent
        TotalUnitsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalUnitsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalUnitsLBL.Location = New Point(1448, 595)
        TotalUnitsLBL.Name = "TotalUnitsLBL"
        TotalUnitsLBL.Size = New Size(57, 30)
        TotalUnitsLBL.TabIndex = 143
        TotalUnitsLBL.Text = "0000"
        TotalUnitsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DifferentItemsLBL
        ' 
        DifferentItemsLBL.AutoSize = True
        DifferentItemsLBL.BackColor = Color.Transparent
        DifferentItemsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DifferentItemsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DifferentItemsLBL.Location = New Point(1448, 565)
        DifferentItemsLBL.Name = "DifferentItemsLBL"
        DifferentItemsLBL.Size = New Size(57, 30)
        DifferentItemsLBL.TabIndex = 142
        DifferentItemsLBL.Text = "0000"
        DifferentItemsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(32, 565)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 30)
        Label4.TabIndex = 141
        Label4.Text = "Different items"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(32, 595)
        Label6.Name = "Label6"
        Label6.Size = New Size(179, 30)
        Label6.TabIndex = 140
        Label6.Text = "Total units received"
        ' 
        ' ReturnHistoryLV
        ' 
        ReturnHistoryLV.BorderStyle = BorderStyle.None
        ReturnHistoryLV.Columns.AddRange(New ColumnHeader() {ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14, ColumnHeader15, ColumnHeader16, ColumnHeader17})
        ReturnHistoryLV.Font = New Font("Poppins", 12F)
        ReturnHistoryLV.FullRowSelect = True
        ReturnHistoryLV.GridLines = True
        ReturnHistoryLV.Location = New Point(55, 827)
        ReturnHistoryLV.MultiSelect = False
        ReturnHistoryLV.Name = "ReturnHistoryLV"
        ReturnHistoryLV.Size = New Size(1430, 121)
        ReturnHistoryLV.TabIndex = 147
        ReturnHistoryLV.UseCompatibleStateImageBehavior = False
        ReturnHistoryLV.View = View.Details
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Return ID"
        ColumnHeader10.Width = 114
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Recepient"
        ColumnHeader11.Width = 114
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Item"
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "Quantity"
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "Condition"
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "Return Date"
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "Received By"
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "Remarks"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label12.Location = New Point(51, 799)
        Label12.Name = "Label12"
        Label12.Size = New Size(137, 26)
        Label12.TabIndex = 146
        Label12.Text = "Previous Returns"
        ' 
        ' SearchReturnHistoryTXT
        ' 
        SearchReturnHistoryTXT.BackColor = Color.White
        SearchReturnHistoryTXT.BorderStyle = BorderStyle.None
        SearchReturnHistoryTXT.Font = New Font("Poppins", 12F)
        SearchReturnHistoryTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchReturnHistoryTXT.Location = New Point(91, 767)
        SearchReturnHistoryTXT.Name = "SearchReturnHistoryTXT"
        SearchReturnHistoryTXT.Size = New Size(1394, 24)
        SearchReturnHistoryTXT.TabIndex = 145
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label14.Location = New Point(50, 740)
        Label14.Name = "Label14"
        Label14.Size = New Size(194, 26)
        Label14.TabIndex = 144
        Label14.Text = "Search Previous Returns"
        ' 
        ' ReturnDateDTP
        ' 
        ReturnDateDTP.CalendarFont = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReturnDateDTP.CalendarForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        ReturnDateDTP.CalendarMonthBackground = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        ReturnDateDTP.CalendarTitleBackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        ReturnDateDTP.CalendarTrailingForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        ReturnDateDTP.Cursor = Cursors.Hand
        ReturnDateDTP.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ReturnDateDTP.Location = New Point(1295, 371)
        ReturnDateDTP.MinDate = New Date(2026, 8, 1, 0, 0, 0, 0)
        ReturnDateDTP.Name = "ReturnDateDTP"
        ReturnDateDTP.Size = New Size(214, 30)
        ReturnDateDTP.TabIndex = 148
        ' 
        ' UpdateRemarksBTN
        ' 
        UpdateRemarksBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        UpdateRemarksBTN.Cursor = Cursors.Hand
        UpdateRemarksBTN.FlatAppearance.BorderSize = 0
        UpdateRemarksBTN.FlatStyle = FlatStyle.Flat
        UpdateRemarksBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateRemarksBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        UpdateRemarksBTN.Location = New Point(1407, 498)
        UpdateRemarksBTN.Name = "UpdateRemarksBTN"
        UpdateRemarksBTN.Size = New Size(102, 30)
        UpdateRemarksBTN.TabIndex = 149
        UpdateRemarksBTN.Text = "Update"
        UpdateRemarksBTN.UseVisualStyleBackColor = False
        UpdateRemarksBTN.Visible = False
        ' 
        ' ReturnsUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(UpdateRemarksBTN)
        Controls.Add(ReturnDateDTP)
        Controls.Add(ReturnHistoryLV)
        Controls.Add(Label12)
        Controls.Add(SearchReturnHistoryTXT)
        Controls.Add(Label14)
        Controls.Add(TotalUnitsLBL)
        Controls.Add(DifferentItemsLBL)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(ClearBTN)
        Controls.Add(ReturnBTN)
        Controls.Add(UpdateQuantityBTN)
        Controls.Add(Label5)
        Controls.Add(RemarksTXT)
        Controls.Add(ConditionCMB)
        Controls.Add(Label3)
        Controls.Add(QuantityToReturnTXT)
        Controls.Add(Label1)
        Controls.Add(ItemNameLBL)
        Controls.Add(RecepientNameLBL)
        Controls.Add(TotalQuantityLBL)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(ItemsForReturnLV)
        Controls.Add(Label2)
        Controls.Add(RemoveSelectedBTN)
        Controls.Add(AddSelectedBTN)
        Controls.Add(ItemsToReturnLV)
        Controls.Add(Label7)
        Controls.Add(SearchItemsToReturnTXT)
        Controls.Add(Label9)
        Name = "ReturnsUC"
        Size = New Size(1537, 1001)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SearchItemsToReturnTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ItemsToReturnLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents RemoveSelectedBTN As Button
    Friend WithEvents AddSelectedBTN As Button
    Friend WithEvents ItemsForReturnLV As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ItemNameLBL As Label
    Friend WithEvents RecepientNameLBL As Label
    Friend WithEvents TotalQuantityLBL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents QuantityToReturnTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ConditionCMB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RemarksTXT As TextBox
    Friend WithEvents UpdateQuantityBTN As Button
    Friend WithEvents ClearBTN As Button
    Friend WithEvents ReturnBTN As Button
    Friend WithEvents TotalUnitsLBL As Label
    Friend WithEvents DifferentItemsLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ReturnHistoryLV As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents SearchReturnHistoryTXT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ReturnDateDTP As DateTimePicker
    Friend WithEvents UpdateRemarksBTN As Button

End Class
