<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintenanceUC))
        TotalRecordsLBL = New Label()
        Label4 = New Label()
        PendingLBL = New Label()
        Label2 = New Label()
        MaintenanceLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Label7 = New Label()
        SearchItemsTXT = New TextBox()
        Label9 = New Label()
        ProblemTXT = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        RepairCostTXT = New TextBox()
        Label5 = New Label()
        ItemTXT = New TextBox()
        AssignedStaffCMB = New ComboBox()
        Label8 = New Label()
        ItemConditionCMB = New ComboBox()
        Label12 = New Label()
        ClearBTN = New Button()
        CompleteRepairBTN = New Button()
        ItemPB = New PictureBox()
        Panel1 = New Panel()
        RmTXT = New TextBox()
        RemarksTXT = New Label()
        ReportRepairBTN = New Button()
        StartRepairBTN = New Button()
        DateReportedDTP = New DateTimePicker()
        Label6 = New Label()
        CompletedLBL = New Label()
        Label11 = New Label()
        InProgressLBL = New Label()
        Label14 = New Label()
        BeyondRepairLBL = New Label()
        Label16 = New Label()
        StatusLBL = New Label()
        CType(ItemPB, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TotalRecordsLBL
        ' 
        TotalRecordsLBL.AutoSize = True
        TotalRecordsLBL.BackColor = Color.Transparent
        TotalRecordsLBL.Font = New Font("Poppins", 35F)
        TotalRecordsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalRecordsLBL.Location = New Point(149, 52)
        TotalRecordsLBL.Name = "TotalRecordsLBL"
        TotalRecordsLBL.Size = New Size(125, 82)
        TotalRecordsLBL.TabIndex = 144
        TotalRecordsLBL.Text = "000"
        TotalRecordsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label4.Location = New Point(37, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 60)
        Label4.TabIndex = 143
        Label4.Text = "Total" & vbCrLf & "Records"
        ' 
        ' PendingLBL
        ' 
        PendingLBL.AutoSize = True
        PendingLBL.BackColor = Color.Transparent
        PendingLBL.Font = New Font("Poppins", 35F)
        PendingLBL.ForeColor = Color.FromArgb(CByte(220), CByte(156), CByte(51))
        PendingLBL.Location = New Point(429, 52)
        PendingLBL.Name = "PendingLBL"
        PendingLBL.Size = New Size(125, 82)
        PendingLBL.TabIndex = 146
        PendingLBL.Text = "000"
        PendingLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(220), CByte(156), CByte(51))
        Label2.Location = New Point(321, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 60)
        Label2.TabIndex = 145
        Label2.Text = "Pending" & vbCrLf & "Repairs"
        ' 
        ' MaintenanceLV
        ' 
        MaintenanceLV.BorderStyle = BorderStyle.None
        MaintenanceLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        MaintenanceLV.Font = New Font("Poppins", 12F)
        MaintenanceLV.FullRowSelect = True
        MaintenanceLV.GridLines = True
        MaintenanceLV.Location = New Point(30, 361)
        MaintenanceLV.MultiSelect = False
        MaintenanceLV.Name = "MaintenanceLV"
        MaintenanceLV.Size = New Size(712, 607)
        MaintenanceLV.TabIndex = 150
        MaintenanceLV.UseCompatibleStateImageBehavior = False
        MaintenanceLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Maintenance ID"
        ColumnHeader1.Width = 114
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Item"
        ColumnHeader2.Width = 114
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Problem"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Date"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Staff"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Status"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Cost"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label7.Location = New Point(30, 332)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 26)
        Label7.TabIndex = 149
        Label7.Text = "Maintenance Record"
        ' 
        ' SearchItemsTXT
        ' 
        SearchItemsTXT.BackColor = Color.White
        SearchItemsTXT.BorderStyle = BorderStyle.None
        SearchItemsTXT.Font = New Font("Poppins", 12F)
        SearchItemsTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        SearchItemsTXT.Location = New Point(71, 291)
        SearchItemsTXT.Name = "SearchItemsTXT"
        SearchItemsTXT.Size = New Size(671, 24)
        SearchItemsTXT.TabIndex = 148
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(26, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 26)
        Label9.TabIndex = 147
        Label9.Text = "Search items"
        ' 
        ' ProblemTXT
        ' 
        ProblemTXT.BackColor = Color.White
        ProblemTXT.BorderStyle = BorderStyle.None
        ProblemTXT.Font = New Font("Poppins", 12F)
        ProblemTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ProblemTXT.Location = New Point(1082, 163)
        ProblemTXT.Multiline = True
        ProblemTXT.Name = "ProblemTXT"
        ProblemTXT.Size = New Size(400, 152)
        ProblemTXT.TabIndex = 154
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label1.Location = New Point(1075, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 26)
        Label1.TabIndex = 153
        Label1.Text = "Problem"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(819, 476)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 26)
        Label3.TabIndex = 156
        Label3.Text = "Repair Cost"
        ' 
        ' RepairCostTXT
        ' 
        RepairCostTXT.BackColor = Color.White
        RepairCostTXT.BorderStyle = BorderStyle.None
        RepairCostTXT.Font = New Font("Poppins", 12F)
        RepairCostTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RepairCostTXT.Location = New Point(820, 501)
        RepairCostTXT.Name = "RepairCostTXT"
        RepairCostTXT.Size = New Size(316, 24)
        RepairCostTXT.TabIndex = 155
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label5.Location = New Point(1079, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 26)
        Label5.TabIndex = 157
        Label5.Text = "Item"
        ' 
        ' ItemTXT
        ' 
        ItemTXT.BackColor = Color.White
        ItemTXT.BorderStyle = BorderStyle.None
        ItemTXT.Font = New Font("Poppins", 12F)
        ItemTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemTXT.Location = New Point(1081, 101)
        ItemTXT.Name = "ItemTXT"
        ItemTXT.Size = New Size(401, 24)
        ItemTXT.TabIndex = 158
        ' 
        ' AssignedStaffCMB
        ' 
        AssignedStaffCMB.BackColor = Color.White
        AssignedStaffCMB.Cursor = Cursors.Hand
        AssignedStaffCMB.DropDownStyle = ComboBoxStyle.DropDownList
        AssignedStaffCMB.FlatStyle = FlatStyle.Flat
        AssignedStaffCMB.Font = New Font("Poppins", 9F)
        AssignedStaffCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        AssignedStaffCMB.FormattingEnabled = True
        AssignedStaffCMB.Location = New Point(819, 428)
        AssignedStaffCMB.Name = "AssignedStaffCMB"
        AssignedStaffCMB.Size = New Size(666, 30)
        AssignedStaffCMB.TabIndex = 162
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label8.Location = New Point(818, 405)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 26)
        Label8.TabIndex = 161
        Label8.Text = "Assigned Staff"
        ' 
        ' ItemConditionCMB
        ' 
        ItemConditionCMB.BackColor = Color.White
        ItemConditionCMB.Cursor = Cursors.Hand
        ItemConditionCMB.DropDownStyle = ComboBoxStyle.DropDownList
        ItemConditionCMB.FlatStyle = FlatStyle.Flat
        ItemConditionCMB.Font = New Font("Poppins", 9F)
        ItemConditionCMB.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemConditionCMB.FormattingEnabled = True
        ItemConditionCMB.Location = New Point(1166, 498)
        ItemConditionCMB.Name = "ItemConditionCMB"
        ItemConditionCMB.Size = New Size(319, 30)
        ItemConditionCMB.TabIndex = 168
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label12.Location = New Point(1166, 476)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 26)
        Label12.TabIndex = 167
        Label12.Text = "Item Condition"
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = Color.FromArgb(CByte(244), CByte(140), CByte(140))
        ClearBTN.Cursor = Cursors.Hand
        ClearBTN.FlatAppearance.BorderSize = 0
        ClearBTN.FlatStyle = FlatStyle.Flat
        ClearBTN.Font = New Font("Poppins", 9.75F)
        ClearBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ClearBTN.Location = New Point(1422, 12)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(88, 26)
        ClearBTN.TabIndex = 171
        ClearBTN.Text = "Clear"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' CompleteRepairBTN
        ' 
        CompleteRepairBTN.BackColor = Color.FromArgb(CByte(34), CByte(217), CByte(137))
        CompleteRepairBTN.Cursor = Cursors.Hand
        CompleteRepairBTN.FlatAppearance.BorderSize = 0
        CompleteRepairBTN.FlatStyle = FlatStyle.Flat
        CompleteRepairBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CompleteRepairBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        CompleteRepairBTN.Location = New Point(819, 885)
        CompleteRepairBTN.Name = "CompleteRepairBTN"
        CompleteRepairBTN.Size = New Size(663, 64)
        CompleteRepairBTN.TabIndex = 169
        CompleteRepairBTN.Text = "Complete Repair"
        CompleteRepairBTN.UseVisualStyleBackColor = False
        ' 
        ' ItemPB
        ' 
        ItemPB.BackColor = Color.White
        ItemPB.Location = New Point(3, 3)
        ItemPB.Name = "ItemPB"
        ItemPB.Size = New Size(235, 235)
        ItemPB.TabIndex = 77
        ItemPB.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(ItemPB)
        Panel1.Location = New Point(815, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 241)
        Panel1.TabIndex = 172
        ' 
        ' RmTXT
        ' 
        RmTXT.BackColor = Color.White
        RmTXT.BorderStyle = BorderStyle.None
        RmTXT.Font = New Font("Poppins", 12F)
        RmTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RmTXT.Location = New Point(820, 571)
        RmTXT.Name = "RmTXT"
        RmTXT.Size = New Size(663, 24)
        RmTXT.TabIndex = 174
        ' 
        ' RemarksTXT
        ' 
        RemarksTXT.AutoSize = True
        RemarksTXT.BackColor = Color.Transparent
        RemarksTXT.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemarksTXT.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RemarksTXT.Location = New Point(818, 542)
        RemarksTXT.Name = "RemarksTXT"
        RemarksTXT.Size = New Size(77, 26)
        RemarksTXT.TabIndex = 173
        RemarksTXT.Text = "Remarks"
        ' 
        ' ReportRepairBTN
        ' 
        ReportRepairBTN.BackColor = Color.FromArgb(CByte(57), CByte(117), CByte(215))
        ReportRepairBTN.Cursor = Cursors.Hand
        ReportRepairBTN.FlatAppearance.BorderSize = 0
        ReportRepairBTN.FlatStyle = FlatStyle.Flat
        ReportRepairBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold)
        ReportRepairBTN.ForeColor = Color.FromArgb(CByte(239), CByte(240), CByte(242))
        ReportRepairBTN.Location = New Point(819, 807)
        ReportRepairBTN.Name = "ReportRepairBTN"
        ReportRepairBTN.Size = New Size(318, 61)
        ReportRepairBTN.TabIndex = 175
        ReportRepairBTN.Text = "Report Repair"
        ReportRepairBTN.UseVisualStyleBackColor = False
        ' 
        ' StartRepairBTN
        ' 
        StartRepairBTN.BackColor = Color.FromArgb(CByte(216), CByte(221), CByte(67))
        StartRepairBTN.Cursor = Cursors.Hand
        StartRepairBTN.FlatAppearance.BorderSize = 0
        StartRepairBTN.FlatStyle = FlatStyle.Flat
        StartRepairBTN.Font = New Font("Poppins Medium", 15F, FontStyle.Bold)
        StartRepairBTN.ForeColor = Color.White
        StartRepairBTN.Location = New Point(1166, 807)
        StartRepairBTN.Name = "StartRepairBTN"
        StartRepairBTN.Size = New Size(318, 61)
        StartRepairBTN.TabIndex = 176
        StartRepairBTN.Text = "Start Repair"
        StartRepairBTN.UseVisualStyleBackColor = False
        ' 
        ' DateReportedDTP
        ' 
        DateReportedDTP.CalendarFont = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateReportedDTP.CalendarForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        DateReportedDTP.CalendarMonthBackground = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        DateReportedDTP.CalendarTitleBackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        DateReportedDTP.CalendarTrailingForeColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        DateReportedDTP.Cursor = Cursors.Hand
        DateReportedDTP.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateReportedDTP.Location = New Point(817, 358)
        DateReportedDTP.MinDate = New Date(2026, 8, 1, 0, 0, 0, 0)
        DateReportedDTP.Name = "DateReportedDTP"
        DateReportedDTP.Size = New Size(668, 30)
        DateReportedDTP.TabIndex = 177
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label6.Location = New Point(820, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 26)
        Label6.TabIndex = 178
        Label6.Text = "Date Reported"
        ' 
        ' CompletedLBL
        ' 
        CompletedLBL.AutoSize = True
        CompletedLBL.BackColor = Color.Transparent
        CompletedLBL.Font = New Font("Poppins", 35F)
        CompletedLBL.ForeColor = Color.FromArgb(CByte(38), CByte(151), CByte(101))
        CompletedLBL.Location = New Point(429, 169)
        CompletedLBL.Name = "CompletedLBL"
        CompletedLBL.Size = New Size(125, 82)
        CompletedLBL.TabIndex = 182
        CompletedLBL.Text = "000"
        CompletedLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(151), CByte(101))
        Label11.Location = New Point(321, 177)
        Label11.Name = "Label11"
        Label11.Size = New Size(109, 60)
        Label11.TabIndex = 181
        Label11.Text = "Completed" & vbCrLf & "Repairs"
        ' 
        ' InProgressLBL
        ' 
        InProgressLBL.AutoSize = True
        InProgressLBL.BackColor = Color.Transparent
        InProgressLBL.Font = New Font("Poppins", 35F)
        InProgressLBL.ForeColor = Color.FromArgb(CByte(57), CByte(117), CByte(215))
        InProgressLBL.Location = New Point(149, 169)
        InProgressLBL.Name = "InProgressLBL"
        InProgressLBL.Size = New Size(125, 82)
        InProgressLBL.TabIndex = 180
        InProgressLBL.Text = "000"
        InProgressLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(57), CByte(117), CByte(215))
        Label14.Location = New Point(37, 177)
        Label14.Name = "Label14"
        Label14.Size = New Size(86, 60)
        Label14.TabIndex = 179
        Label14.Text = "In" & vbCrLf & "Progress"
        ' 
        ' BeyondRepairLBL
        ' 
        BeyondRepairLBL.AutoSize = True
        BeyondRepairLBL.BackColor = Color.Transparent
        BeyondRepairLBL.Font = New Font("Poppins", 35F)
        BeyondRepairLBL.ForeColor = Color.FromArgb(CByte(218), CByte(93), CByte(93))
        BeyondRepairLBL.Location = New Point(605, 128)
        BeyondRepairLBL.Name = "BeyondRepairLBL"
        BeyondRepairLBL.Size = New Size(125, 82)
        BeyondRepairLBL.TabIndex = 184
        BeyondRepairLBL.Text = "000"
        BeyondRepairLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(218), CByte(93), CByte(93))
        Label16.Location = New Point(602, 86)
        Label16.Name = "Label16"
        Label16.Size = New Size(135, 30)
        Label16.TabIndex = 183
        Label16.Text = "Beyond Repair"
        ' 
        ' StatusLBL
        ' 
        StatusLBL.AutoSize = True
        StatusLBL.BackColor = Color.Transparent
        StatusLBL.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StatusLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        StatusLBL.Location = New Point(1362, 72)
        StatusLBL.Name = "StatusLBL"
        StatusLBL.Size = New Size(124, 26)
        StatusLBL.TabIndex = 185
        StatusLBL.Text = "--------------"
        ' 
        ' MaintenanceUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(StatusLBL)
        Controls.Add(BeyondRepairLBL)
        Controls.Add(Label16)
        Controls.Add(CompletedLBL)
        Controls.Add(Label11)
        Controls.Add(InProgressLBL)
        Controls.Add(Label14)
        Controls.Add(Label6)
        Controls.Add(DateReportedDTP)
        Controls.Add(StartRepairBTN)
        Controls.Add(ReportRepairBTN)
        Controls.Add(RmTXT)
        Controls.Add(RemarksTXT)
        Controls.Add(Panel1)
        Controls.Add(ClearBTN)
        Controls.Add(CompleteRepairBTN)
        Controls.Add(ItemConditionCMB)
        Controls.Add(Label12)
        Controls.Add(AssignedStaffCMB)
        Controls.Add(Label8)
        Controls.Add(ItemTXT)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(RepairCostTXT)
        Controls.Add(ProblemTXT)
        Controls.Add(Label1)
        Controls.Add(MaintenanceLV)
        Controls.Add(Label7)
        Controls.Add(SearchItemsTXT)
        Controls.Add(Label9)
        Controls.Add(PendingLBL)
        Controls.Add(Label2)
        Controls.Add(TotalRecordsLBL)
        Controls.Add(Label4)
        Name = "MaintenanceUC"
        Size = New Size(1537, 1001)
        CType(ItemPB, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TotalRecordsLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PendingLBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MaintenanceLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchItemsTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ProblemTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RepairCostTXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ItemTXT As TextBox
    Friend WithEvents AssignedStaffCMB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ItemConditionCMB As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ClearBTN As Button
    Friend WithEvents CompleteRepairBTN As Button
    Friend WithEvents ItemPB As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RmTXT As TextBox
    Friend WithEvents RemarksTXT As Label
    Friend WithEvents ReportRepairBTN As Button
    Friend WithEvents StartRepairBTN As Button
    Friend WithEvents DateReportedDTP As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents CompletedLBL As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents InProgressLBL As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BeyondRepairLBL As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusLBL As Label

End Class
