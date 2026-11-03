<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssuanceUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssuanceUC))
        SearchAvailItemsTXT = New TextBox()
        Label9 = New Label()
        SearchSelectedItemsTXT = New TextBox()
        Label1 = New Label()
        AvailableItemsLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Label7 = New Label()
        SelectedItemsLV = New ListView()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        Label2 = New Label()
        RecepientNameTXT = New TextBox()
        Label3 = New Label()
        RecepientTypeCMB = New ComboBox()
        Label4 = New Label()
        IssueDateDTP = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        RequestedQuantityTXT = New TextBox()
        AddSelectedBTN = New Button()
        ClearBTN = New Button()
        IssueBTN = New Button()
        RemoveSelectedBTN = New Button()
        ItemNameLBL = New Label()
        QuantityLBL = New Label()
        ItemDescriptionLBL = New Label()
        DepartmentNameLBL = New Label()
        UpdateQuantityBTN = New Button()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        TotalQuantityOfAllSelectedItemsLBL = New Label()
        SelectedItemsQuantityLBL = New Label()
        RemarksTXT = New TextBox()
        Label23 = New Label()
        SuspendLayout()
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
        SearchAvailItemsTXT.TabIndex = 64
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
        Label9.TabIndex = 63
        Label9.Text = "Search Available Item"
        ' 
        ' SearchSelectedItemsTXT
        ' 
        SearchSelectedItemsTXT.BackColor = Color.White
        SearchSelectedItemsTXT.BorderStyle = BorderStyle.None
        SearchSelectedItemsTXT.Font = New Font("Poppins", 12F)
        SearchSelectedItemsTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchSelectedItemsTXT.Location = New Point(824, 193)
        SearchSelectedItemsTXT.Name = "SearchSelectedItemsTXT"
        SearchSelectedItemsTXT.Size = New Size(682, 24)
        SearchSelectedItemsTXT.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label1.Location = New Point(787, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 26)
        Label1.TabIndex = 65
        Label1.Text = "Search Selected Item"
        ' 
        ' AvailableItemsLV
        ' 
        AvailableItemsLV.BorderStyle = BorderStyle.None
        AvailableItemsLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        AvailableItemsLV.Font = New Font("Poppins", 12F)
        AvailableItemsLV.FullRowSelect = True
        AvailableItemsLV.GridLines = True
        AvailableItemsLV.Location = New Point(32, 264)
        AvailableItemsLV.MultiSelect = False
        AvailableItemsLV.Name = "AvailableItemsLV"
        AvailableItemsLV.Size = New Size(715, 272)
        AvailableItemsLV.TabIndex = 68
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
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Dept"
        ColumnHeader3.Width = 114
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Location"
        ColumnHeader4.Width = 114
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
        Label7.TabIndex = 67
        Label7.Text = "Available Items"
        ' 
        ' SelectedItemsLV
        ' 
        SelectedItemsLV.BorderStyle = BorderStyle.None
        SelectedItemsLV.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        SelectedItemsLV.Font = New Font("Poppins", 12F)
        SelectedItemsLV.FullRowSelect = True
        SelectedItemsLV.GridLines = True
        SelectedItemsLV.Location = New Point(791, 264)
        SelectedItemsLV.MultiSelect = False
        SelectedItemsLV.Name = "SelectedItemsLV"
        SelectedItemsLV.Size = New Size(715, 272)
        SelectedItemsLV.TabIndex = 70
        SelectedItemsLV.UseCompatibleStateImageBehavior = False
        SelectedItemsLV.View = View.Details
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
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Available"
        ColumnHeader9.Width = 114
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Dept"
        ColumnHeader10.Width = 114
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label2.Location = New Point(788, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 26)
        Label2.TabIndex = 69
        Label2.Text = "Selected Items"
        ' 
        ' RecepientNameTXT
        ' 
        RecepientNameTXT.BackColor = Color.White
        RecepientNameTXT.BorderStyle = BorderStyle.None
        RecepientNameTXT.Font = New Font("Poppins", 12F)
        RecepientNameTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RecepientNameTXT.Location = New Point(55, 83)
        RecepientNameTXT.Name = "RecepientNameTXT"
        RecepientNameTXT.Size = New Size(692, 24)
        RecepientNameTXT.TabIndex = 72
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(51, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 26)
        Label3.TabIndex = 71
        Label3.Text = "Recepient Name"
        ' 
        ' RecepientTypeCMB
        ' 
        RecepientTypeCMB.BackColor = Color.White
        RecepientTypeCMB.Cursor = Cursors.Hand
        RecepientTypeCMB.DropDownStyle = ComboBoxStyle.DropDownList
        RecepientTypeCMB.FlatStyle = FlatStyle.Flat
        RecepientTypeCMB.Font = New Font("Poppins", 9F)
        RecepientTypeCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RecepientTypeCMB.FormattingEnabled = True
        RecepientTypeCMB.Location = New Point(787, 80)
        RecepientTypeCMB.Name = "RecepientTypeCMB"
        RecepientTypeCMB.Size = New Size(335, 30)
        RecepientTypeCMB.TabIndex = 74
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(787, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 26)
        Label4.TabIndex = 73
        Label4.Text = "Type"
        ' 
        ' IssueDateDTP
        ' 
        IssueDateDTP.CalendarFont = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IssueDateDTP.CalendarForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        IssueDateDTP.CalendarMonthBackground = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        IssueDateDTP.CalendarTitleBackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        IssueDateDTP.CalendarTrailingForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        IssueDateDTP.Cursor = Cursors.Hand
        IssueDateDTP.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IssueDateDTP.Location = New Point(1150, 80)
        IssueDateDTP.MinDate = New Date(2026, 8, 1, 0, 0, 0, 0)
        IssueDateDTP.Name = "IssueDateDTP"
        IssueDateDTP.Size = New Size(335, 30)
        IssueDateDTP.TabIndex = 77
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(1150, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 26)
        Label5.TabIndex = 78
        Label5.Text = "Issue Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(32, 582)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 26)
        Label6.TabIndex = 79
        Label6.Text = "Item Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(71, 622)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 30)
        Label8.TabIndex = 80
        Label8.Text = "Item Name:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label10.Location = New Point(71, 652)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 30)
        Label10.TabIndex = 81
        Label10.Text = "Quantity:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label11.Location = New Point(791, 652)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 30)
        Label11.TabIndex = 82
        Label11.Text = "Description:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label13.Location = New Point(791, 622)
        Label13.Name = "Label13"
        Label13.Size = New Size(120, 30)
        Label13.TabIndex = 83
        Label13.Text = "Department:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label12.Location = New Point(74, 696)
        Label12.Name = "Label12"
        Label12.Size = New Size(185, 30)
        Label12.TabIndex = 84
        Label12.Text = "Requested Quantity:"
        ' 
        ' RequestedQuantityTXT
        ' 
        RequestedQuantityTXT.BackColor = Color.White
        RequestedQuantityTXT.BorderStyle = BorderStyle.None
        RequestedQuantityTXT.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RequestedQuantityTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RequestedQuantityTXT.Location = New Point(263, 699)
        RequestedQuantityTXT.Name = "RequestedQuantityTXT"
        RequestedQuantityTXT.Size = New Size(56, 23)
        RequestedQuantityTXT.TabIndex = 85
        ' 
        ' AddSelectedBTN
        ' 
        AddSelectedBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        AddSelectedBTN.Cursor = Cursors.Hand
        AddSelectedBTN.FlatAppearance.BorderSize = 0
        AddSelectedBTN.FlatStyle = FlatStyle.Flat
        AddSelectedBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddSelectedBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        AddSelectedBTN.Location = New Point(603, 553)
        AddSelectedBTN.Name = "AddSelectedBTN"
        AddSelectedBTN.Size = New Size(144, 26)
        AddSelectedBTN.TabIndex = 86
        AddSelectedBTN.Text = "Add Selected"
        AddSelectedBTN.UseVisualStyleBackColor = False
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        ClearBTN.Cursor = Cursors.Hand
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ClearBTN.Location = New Point(29, 911)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(718, 64)
        ClearBTN.TabIndex = 88
        ClearBTN.Text = "Clear Selected"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' IssueBTN
        ' 
        IssueBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        IssueBTN.Cursor = Cursors.Hand
        IssueBTN.FlatAppearance.BorderSize = 0
        IssueBTN.FlatStyle = FlatStyle.Flat
        IssueBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IssueBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        IssueBTN.Location = New Point(791, 911)
        IssueBTN.Name = "IssueBTN"
        IssueBTN.Size = New Size(715, 64)
        IssueBTN.TabIndex = 87
        IssueBTN.Text = "Issue"
        IssueBTN.UseVisualStyleBackColor = False
        ' 
        ' RemoveSelectedBTN
        ' 
        RemoveSelectedBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        RemoveSelectedBTN.Cursor = Cursors.Hand
        RemoveSelectedBTN.FlatAppearance.BorderSize = 0
        RemoveSelectedBTN.FlatStyle = FlatStyle.Flat
        RemoveSelectedBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemoveSelectedBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        RemoveSelectedBTN.Location = New Point(791, 553)
        RemoveSelectedBTN.Name = "RemoveSelectedBTN"
        RemoveSelectedBTN.Size = New Size(144, 26)
        RemoveSelectedBTN.TabIndex = 89
        RemoveSelectedBTN.Text = "Remove Selected"
        RemoveSelectedBTN.UseVisualStyleBackColor = False
        ' 
        ' ItemNameLBL
        ' 
        ItemNameLBL.AutoSize = True
        ItemNameLBL.BackColor = Color.Transparent
        ItemNameLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItemNameLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemNameLBL.Location = New Point(180, 622)
        ItemNameLBL.Name = "ItemNameLBL"
        ItemNameLBL.Size = New Size(164, 30)
        ItemNameLBL.TabIndex = 90
        ItemNameLBL.Text = "Name of the item"
        ItemNameLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' QuantityLBL
        ' 
        QuantityLBL.AutoSize = True
        QuantityLBL.BackColor = Color.Transparent
        QuantityLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        QuantityLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        QuantityLBL.Location = New Point(180, 652)
        QuantityLBL.Name = "QuantityLBL"
        QuantityLBL.Size = New Size(160, 30)
        QuantityLBL.TabIndex = 91
        QuantityLBL.Text = "Quantity of items"
        QuantityLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ItemDescriptionLBL
        ' 
        ItemDescriptionLBL.AutoSize = True
        ItemDescriptionLBL.BackColor = Color.Transparent
        ItemDescriptionLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItemDescriptionLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemDescriptionLBL.Location = New Point(909, 652)
        ItemDescriptionLBL.Name = "ItemDescriptionLBL"
        ItemDescriptionLBL.Size = New Size(207, 30)
        ItemDescriptionLBL.TabIndex = 93
        ItemDescriptionLBL.Text = "Description of the item"
        ItemDescriptionLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DepartmentNameLBL
        ' 
        DepartmentNameLBL.AutoSize = True
        DepartmentNameLBL.BackColor = Color.Transparent
        DepartmentNameLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DepartmentNameLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        DepartmentNameLBL.Location = New Point(909, 622)
        DepartmentNameLBL.Name = "DepartmentNameLBL"
        DepartmentNameLBL.Size = New Size(195, 30)
        DepartmentNameLBL.TabIndex = 92
        DepartmentNameLBL.Text = "Name of Department"
        DepartmentNameLBL.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UpdateQuantityBTN
        ' 
        UpdateQuantityBTN.BackColor = Color.FromArgb(CByte(34), CByte(116), CByte(217))
        UpdateQuantityBTN.Cursor = Cursors.Hand
        UpdateQuantityBTN.FlatAppearance.BorderSize = 0
        UpdateQuantityBTN.FlatStyle = FlatStyle.Flat
        UpdateQuantityBTN.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateQuantityBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        UpdateQuantityBTN.Location = New Point(334, 697)
        UpdateQuantityBTN.Name = "UpdateQuantityBTN"
        UpdateQuantityBTN.Size = New Size(143, 26)
        UpdateQuantityBTN.TabIndex = 94
        UpdateQuantityBTN.Text = "Update Quantity"
        UpdateQuantityBTN.UseVisualStyleBackColor = False
        UpdateQuantityBTN.Visible = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label18.Location = New Point(71, 745)
        Label18.Name = "Label18"
        Label18.Size = New Size(87, 30)
        Label18.TabIndex = 95
        Label18.Text = "Remarks"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label19.Location = New Point(71, 824)
        Label19.Name = "Label19"
        Label19.Size = New Size(144, 30)
        Label19.TabIndex = 96
        Label19.Text = "Selected Items:"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label20.Location = New Point(71, 849)
        Label20.Name = "Label20"
        Label20.Size = New Size(135, 30)
        Label20.TabIndex = 97
        Label20.Text = "Total Quantity:"
        Label20.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TotalQuantityOfAllSelectedItemsLBL
        ' 
        TotalQuantityOfAllSelectedItemsLBL.AutoSize = True
        TotalQuantityOfAllSelectedItemsLBL.BackColor = Color.Transparent
        TotalQuantityOfAllSelectedItemsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalQuantityOfAllSelectedItemsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalQuantityOfAllSelectedItemsLBL.Location = New Point(1405, 849)
        TotalQuantityOfAllSelectedItemsLBL.Name = "TotalQuantityOfAllSelectedItemsLBL"
        TotalQuantityOfAllSelectedItemsLBL.Size = New Size(57, 30)
        TotalQuantityOfAllSelectedItemsLBL.TabIndex = 99
        TotalQuantityOfAllSelectedItemsLBL.Text = "0000"
        TotalQuantityOfAllSelectedItemsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SelectedItemsQuantityLBL
        ' 
        SelectedItemsQuantityLBL.AutoSize = True
        SelectedItemsQuantityLBL.BackColor = Color.Transparent
        SelectedItemsQuantityLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SelectedItemsQuantityLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SelectedItemsQuantityLBL.Location = New Point(1405, 824)
        SelectedItemsQuantityLBL.Name = "SelectedItemsQuantityLBL"
        SelectedItemsQuantityLBL.Size = New Size(57, 30)
        SelectedItemsQuantityLBL.TabIndex = 98
        SelectedItemsQuantityLBL.Text = "0000"
        SelectedItemsQuantityLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' RemarksTXT
        ' 
        RemarksTXT.BackColor = Color.White
        RemarksTXT.BorderStyle = BorderStyle.None
        RemarksTXT.Font = New Font("Poppins", 12F)
        RemarksTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RemarksTXT.Location = New Point(76, 776)
        RemarksTXT.Name = "RemarksTXT"
        RemarksTXT.Size = New Size(1386, 24)
        RemarksTXT.TabIndex = 100
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = Color.Transparent
        Label23.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label23.Location = New Point(32, 17)
        Label23.Name = "Label23"
        Label23.Size = New Size(179, 26)
        Label23.TabIndex = 101
        Label23.Text = "Recepient Information"
        ' 
        ' IssuanceUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(Label23)
        Controls.Add(RemarksTXT)
        Controls.Add(TotalQuantityOfAllSelectedItemsLBL)
        Controls.Add(SelectedItemsQuantityLBL)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(UpdateQuantityBTN)
        Controls.Add(ItemDescriptionLBL)
        Controls.Add(DepartmentNameLBL)
        Controls.Add(QuantityLBL)
        Controls.Add(ItemNameLBL)
        Controls.Add(RemoveSelectedBTN)
        Controls.Add(ClearBTN)
        Controls.Add(IssueBTN)
        Controls.Add(AddSelectedBTN)
        Controls.Add(RequestedQuantityTXT)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(IssueDateDTP)
        Controls.Add(RecepientTypeCMB)
        Controls.Add(Label4)
        Controls.Add(RecepientNameTXT)
        Controls.Add(Label3)
        Controls.Add(SelectedItemsLV)
        Controls.Add(Label2)
        Controls.Add(AvailableItemsLV)
        Controls.Add(Label7)
        Controls.Add(SearchSelectedItemsTXT)
        Controls.Add(Label1)
        Controls.Add(SearchAvailItemsTXT)
        Controls.Add(Label9)
        Name = "IssuanceUC"
        Size = New Size(1537, 1001)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SearchAvailItemsTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SearchSelectedItemsTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AvailableItemsLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents SelectedItemsLV As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents RecepientNameTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RecepientTypeCMB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IssueDateDTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RequestedQuantityTXT As TextBox
    Friend WithEvents AddSelectedBTN As Button
    Friend WithEvents ClearBTN As Button
    Friend WithEvents IssueBTN As Button
    Friend WithEvents RemoveSelectedBTN As Button
    Friend WithEvents ItemNameLBL As Label
    Friend WithEvents QuantityLBL As Label
    Friend WithEvents ItemDescriptionLBL As Label
    Friend WithEvents DepartmentNameLBL As Label
    Friend WithEvents UpdateQuantityBTN As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TotalQuantityOfAllSelectedItemsLBL As Label
    Friend WithEvents SelectedItemsQuantityLBL As Label
    Friend WithEvents RemarksTXT As TextBox
    Friend WithEvents Label23 As Label

End Class
