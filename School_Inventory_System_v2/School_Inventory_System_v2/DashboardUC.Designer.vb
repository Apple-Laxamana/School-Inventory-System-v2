<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardUC))
        RegisteredItemsLBL = New Label()
        Label4 = New Label()
        AvailableStockLBL = New Label()
        Label2 = New Label()
        DamagedStockLBL = New Label()
        Label5 = New Label()
        NeedsRepairLBL = New Label()
        Label7 = New Label()
        TotalIssuancesLBL = New Label()
        Label9 = New Label()
        TotalReturnedUnitsLBL = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        UnitsNotReturnedLBL = New Label()
        OutstandingLBL = New Label()
        ItemsReturnedTodayLBL = New Label()
        RecentReturnsLBL = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        TotalDamagedLBL = New Label()
        TotalAvailableLBL = New Label()
        Label24 = New Label()
        Label25 = New Label()
        TotalStockLBL = New Label()
        Label27 = New Label()
        CompletedRepairsLBL = New Label()
        Label29 = New Label()
        BeyondRepairLBL = New Label()
        UnderMaintenanceLBL = New Label()
        Label32 = New Label()
        Label33 = New Label()
        MaintenanceLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Label34 = New Label()
        SuspendLayout()
        ' 
        ' RegisteredItemsLBL
        ' 
        RegisteredItemsLBL.AutoSize = True
        RegisteredItemsLBL.BackColor = Color.Transparent
        RegisteredItemsLBL.Font = New Font("Poppins", 35F)
        RegisteredItemsLBL.ForeColor = Color.FromArgb(CByte(57), CByte(117), CByte(215))
        RegisteredItemsLBL.Location = New Point(217, 64)
        RegisteredItemsLBL.Name = "RegisteredItemsLBL"
        RegisteredItemsLBL.Size = New Size(155, 82)
        RegisteredItemsLBL.TabIndex = 146
        RegisteredItemsLBL.Text = "0000"
        RegisteredItemsLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(57), CByte(117), CByte(215))
        Label4.Location = New Point(117, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 60)
        Label4.TabIndex = 145
        Label4.Text = "Registered" & vbCrLf & "Items"
        ' 
        ' AvailableStockLBL
        ' 
        AvailableStockLBL.AutoSize = True
        AvailableStockLBL.BackColor = Color.Transparent
        AvailableStockLBL.Font = New Font("Poppins", 35F)
        AvailableStockLBL.ForeColor = Color.FromArgb(CByte(38), CByte(151), CByte(101))
        AvailableStockLBL.Location = New Point(591, 64)
        AvailableStockLBL.Name = "AvailableStockLBL"
        AvailableStockLBL.Size = New Size(155, 82)
        AvailableStockLBL.TabIndex = 148
        AvailableStockLBL.Text = "0000"
        AvailableStockLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(151), CByte(101))
        Label2.Location = New Point(491, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 60)
        Label2.TabIndex = 147
        Label2.Text = "Available" & vbCrLf & "Stock"
        ' 
        ' DamagedStockLBL
        ' 
        DamagedStockLBL.AutoSize = True
        DamagedStockLBL.BackColor = Color.Transparent
        DamagedStockLBL.Font = New Font("Poppins", 35F)
        DamagedStockLBL.ForeColor = Color.FromArgb(CByte(220), CByte(156), CByte(51))
        DamagedStockLBL.Location = New Point(966, 64)
        DamagedStockLBL.Name = "DamagedStockLBL"
        DamagedStockLBL.Size = New Size(155, 82)
        DamagedStockLBL.TabIndex = 150
        DamagedStockLBL.Text = "0000"
        DamagedStockLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(220), CByte(156), CByte(51))
        Label5.Location = New Point(866, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 60)
        Label5.TabIndex = 149
        Label5.Text = "Damaged" & vbCrLf & "Stock"
        ' 
        ' NeedsRepairLBL
        ' 
        NeedsRepairLBL.AutoSize = True
        NeedsRepairLBL.BackColor = Color.Transparent
        NeedsRepairLBL.Font = New Font("Poppins", 35F)
        NeedsRepairLBL.ForeColor = Color.FromArgb(CByte(218), CByte(93), CByte(93))
        NeedsRepairLBL.Location = New Point(1341, 64)
        NeedsRepairLBL.Name = "NeedsRepairLBL"
        NeedsRepairLBL.Size = New Size(155, 82)
        NeedsRepairLBL.TabIndex = 152
        NeedsRepairLBL.Text = "0000"
        NeedsRepairLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(218), CByte(93), CByte(93))
        Label7.Location = New Point(1241, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 60)
        Label7.TabIndex = 151
        Label7.Text = "Needs" & vbCrLf & "Repair"
        ' 
        ' TotalIssuancesLBL
        ' 
        TotalIssuancesLBL.AutoSize = True
        TotalIssuancesLBL.BackColor = Color.Transparent
        TotalIssuancesLBL.Font = New Font("Poppins", 35F)
        TotalIssuancesLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalIssuancesLBL.Location = New Point(217, 243)
        TotalIssuancesLBL.Name = "TotalIssuancesLBL"
        TotalIssuancesLBL.Size = New Size(155, 82)
        TotalIssuancesLBL.TabIndex = 154
        TotalIssuancesLBL.Text = "0000"
        TotalIssuancesLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label9.Location = New Point(117, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 60)
        Label9.TabIndex = 153
        Label9.Text = "Total" & vbCrLf & "Issuances"
        ' 
        ' TotalReturnedUnitsLBL
        ' 
        TotalReturnedUnitsLBL.AutoSize = True
        TotalReturnedUnitsLBL.BackColor = Color.Transparent
        TotalReturnedUnitsLBL.Font = New Font("Poppins", 35F)
        TotalReturnedUnitsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalReturnedUnitsLBL.Location = New Point(217, 429)
        TotalReturnedUnitsLBL.Name = "TotalReturnedUnitsLBL"
        TotalReturnedUnitsLBL.Size = New Size(155, 82)
        TotalReturnedUnitsLBL.TabIndex = 156
        TotalReturnedUnitsLBL.Text = "0000"
        TotalReturnedUnitsLBL.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label11.Location = New Point(117, 425)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 90)
        Label11.TabIndex = 155
        Label11.Text = "Total" & vbCrLf & "Returned" & vbCrLf & "Units"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label12.Location = New Point(405, 244)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 30)
        Label12.TabIndex = 157
        Label12.Text = "Outstanding"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label13.Location = New Point(405, 292)
        Label13.Name = "Label13"
        Label13.Size = New Size(170, 30)
        Label13.TabIndex = 158
        Label13.Text = "Units Not Returned"
        ' 
        ' UnitsNotReturnedLBL
        ' 
        UnitsNotReturnedLBL.AutoSize = True
        UnitsNotReturnedLBL.BackColor = Color.Transparent
        UnitsNotReturnedLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UnitsNotReturnedLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        UnitsNotReturnedLBL.Location = New Point(674, 292)
        UnitsNotReturnedLBL.Name = "UnitsNotReturnedLBL"
        UnitsNotReturnedLBL.Size = New Size(57, 30)
        UnitsNotReturnedLBL.TabIndex = 160
        UnitsNotReturnedLBL.Text = "0000"
        UnitsNotReturnedLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' OutstandingLBL
        ' 
        OutstandingLBL.AutoSize = True
        OutstandingLBL.BackColor = Color.Transparent
        OutstandingLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OutstandingLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        OutstandingLBL.Location = New Point(674, 244)
        OutstandingLBL.Name = "OutstandingLBL"
        OutstandingLBL.Size = New Size(57, 30)
        OutstandingLBL.TabIndex = 159
        OutstandingLBL.Text = "0000"
        OutstandingLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ItemsReturnedTodayLBL
        ' 
        ItemsReturnedTodayLBL.AutoSize = True
        ItemsReturnedTodayLBL.BackColor = Color.Transparent
        ItemsReturnedTodayLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItemsReturnedTodayLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        ItemsReturnedTodayLBL.Location = New Point(674, 478)
        ItemsReturnedTodayLBL.Name = "ItemsReturnedTodayLBL"
        ItemsReturnedTodayLBL.Size = New Size(57, 30)
        ItemsReturnedTodayLBL.TabIndex = 164
        ItemsReturnedTodayLBL.Text = "0000"
        ItemsReturnedTodayLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' RecentReturnsLBL
        ' 
        RecentReturnsLBL.AutoSize = True
        RecentReturnsLBL.BackColor = Color.Transparent
        RecentReturnsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RecentReturnsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        RecentReturnsLBL.Location = New Point(674, 430)
        RecentReturnsLBL.Name = "RecentReturnsLBL"
        RecentReturnsLBL.Size = New Size(57, 30)
        RecentReturnsLBL.TabIndex = 163
        RecentReturnsLBL.Text = "0000"
        RecentReturnsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label18.Location = New Point(405, 478)
        Label18.Name = "Label18"
        Label18.Size = New Size(200, 30)
        Label18.TabIndex = 162
        Label18.Text = "Items Returned Today"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label19.Location = New Point(405, 430)
        Label19.Name = "Label19"
        Label19.Size = New Size(141, 30)
        Label19.TabIndex = 161
        Label19.Text = "Recent Returns"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label20.Location = New Point(796, 215)
        Label20.Name = "Label20"
        Label20.Size = New Size(213, 42)
        Label20.TabIndex = 165
        Label20.Text = "Stock Summary"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label21.Location = New Point(1172, 215)
        Label21.Name = "Label21"
        Label21.Size = New Size(264, 42)
        Label21.TabIndex = 166
        Label21.Text = "Maintenance Status"
        ' 
        ' TotalDamagedLBL
        ' 
        TotalDamagedLBL.AutoSize = True
        TotalDamagedLBL.BackColor = Color.Transparent
        TotalDamagedLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalDamagedLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalDamagedLBL.Location = New Point(1051, 340)
        TotalDamagedLBL.Name = "TotalDamagedLBL"
        TotalDamagedLBL.Size = New Size(57, 30)
        TotalDamagedLBL.TabIndex = 170
        TotalDamagedLBL.Text = "0000"
        TotalDamagedLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TotalAvailableLBL
        ' 
        TotalAvailableLBL.AutoSize = True
        TotalAvailableLBL.BackColor = Color.Transparent
        TotalAvailableLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalAvailableLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalAvailableLBL.Location = New Point(1051, 292)
        TotalAvailableLBL.Name = "TotalAvailableLBL"
        TotalAvailableLBL.Size = New Size(57, 30)
        TotalAvailableLBL.TabIndex = 169
        TotalAvailableLBL.Text = "0000"
        TotalAvailableLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = Color.Transparent
        Label24.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label24.Location = New Point(796, 340)
        Label24.Name = "Label24"
        Label24.Size = New Size(144, 30)
        Label24.TabIndex = 168
        Label24.Text = "Total Damaged"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.Transparent
        Label25.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label25.Location = New Point(796, 292)
        Label25.Name = "Label25"
        Label25.Size = New Size(136, 30)
        Label25.TabIndex = 167
        Label25.Text = "Total Available"
        ' 
        ' TotalStockLBL
        ' 
        TotalStockLBL.AutoSize = True
        TotalStockLBL.BackColor = Color.Transparent
        TotalStockLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalStockLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        TotalStockLBL.Location = New Point(1051, 390)
        TotalStockLBL.Name = "TotalStockLBL"
        TotalStockLBL.Size = New Size(57, 30)
        TotalStockLBL.TabIndex = 172
        TotalStockLBL.Text = "0000"
        TotalStockLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.BackColor = Color.Transparent
        Label27.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label27.Location = New Point(796, 390)
        Label27.Name = "Label27"
        Label27.Size = New Size(105, 30)
        Label27.TabIndex = 171
        Label27.Text = "Total Stock"
        ' 
        ' CompletedRepairsLBL
        ' 
        CompletedRepairsLBL.AutoSize = True
        CompletedRepairsLBL.BackColor = Color.Transparent
        CompletedRepairsLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CompletedRepairsLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        CompletedRepairsLBL.Location = New Point(1427, 394)
        CompletedRepairsLBL.Name = "CompletedRepairsLBL"
        CompletedRepairsLBL.Size = New Size(57, 30)
        CompletedRepairsLBL.TabIndex = 178
        CompletedRepairsLBL.Text = "0000"
        CompletedRepairsLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = Color.Transparent
        Label29.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label29.Location = New Point(1172, 394)
        Label29.Name = "Label29"
        Label29.Size = New Size(176, 30)
        Label29.TabIndex = 177
        Label29.Text = "Completed Repairs"
        ' 
        ' BeyondRepairLBL
        ' 
        BeyondRepairLBL.AutoSize = True
        BeyondRepairLBL.BackColor = Color.Transparent
        BeyondRepairLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BeyondRepairLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        BeyondRepairLBL.Location = New Point(1427, 343)
        BeyondRepairLBL.Name = "BeyondRepairLBL"
        BeyondRepairLBL.Size = New Size(57, 30)
        BeyondRepairLBL.TabIndex = 176
        BeyondRepairLBL.Text = "0000"
        BeyondRepairLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UnderMaintenanceLBL
        ' 
        UnderMaintenanceLBL.AutoSize = True
        UnderMaintenanceLBL.BackColor = Color.Transparent
        UnderMaintenanceLBL.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UnderMaintenanceLBL.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        UnderMaintenanceLBL.Location = New Point(1427, 295)
        UnderMaintenanceLBL.Name = "UnderMaintenanceLBL"
        UnderMaintenanceLBL.Size = New Size(57, 30)
        UnderMaintenanceLBL.TabIndex = 175
        UnderMaintenanceLBL.Text = "0000"
        UnderMaintenanceLBL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.BackColor = Color.Transparent
        Label32.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label32.Location = New Point(1172, 343)
        Label32.Name = "Label32"
        Label32.Size = New Size(135, 30)
        Label32.TabIndex = 174
        Label32.Text = "Beyond Repair"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.BackColor = Color.Transparent
        Label33.Font = New Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label33.Location = New Point(1172, 295)
        Label33.Name = "Label33"
        Label33.Size = New Size(180, 30)
        Label33.TabIndex = 173
        Label33.Text = "Under Maintenance"
        ' 
        ' MaintenanceLV
        ' 
        MaintenanceLV.BorderStyle = BorderStyle.None
        MaintenanceLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        MaintenanceLV.Font = New Font("Poppins", 12F)
        MaintenanceLV.FullRowSelect = True
        MaintenanceLV.GridLines = True
        MaintenanceLV.Location = New Point(36, 589)
        MaintenanceLV.MultiSelect = False
        MaintenanceLV.Name = "MaintenanceLV"
        MaintenanceLV.Size = New Size(1460, 381)
        MaintenanceLV.TabIndex = 180
        MaintenanceLV.UseCompatibleStateImageBehavior = False
        MaintenanceLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Activity Type"
        ColumnHeader1.Width = 114
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Description"
        ColumnHeader2.Width = 114
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Date & Time"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Performed By"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.Transparent
        Label34.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label34.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label34.Location = New Point(33, 560)
        Label34.Name = "Label34"
        Label34.Size = New Size(133, 26)
        Label34.TabIndex = 179
        Label34.Text = "Recent Activities"
        ' 
        ' DashboardUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(27), CByte(26))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Controls.Add(MaintenanceLV)
        Controls.Add(Label34)
        Controls.Add(CompletedRepairsLBL)
        Controls.Add(Label29)
        Controls.Add(BeyondRepairLBL)
        Controls.Add(UnderMaintenanceLBL)
        Controls.Add(Label32)
        Controls.Add(Label33)
        Controls.Add(TotalStockLBL)
        Controls.Add(Label27)
        Controls.Add(TotalDamagedLBL)
        Controls.Add(TotalAvailableLBL)
        Controls.Add(Label24)
        Controls.Add(Label25)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(ItemsReturnedTodayLBL)
        Controls.Add(RecentReturnsLBL)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(UnitsNotReturnedLBL)
        Controls.Add(OutstandingLBL)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(TotalReturnedUnitsLBL)
        Controls.Add(Label11)
        Controls.Add(TotalIssuancesLBL)
        Controls.Add(Label9)
        Controls.Add(NeedsRepairLBL)
        Controls.Add(Label7)
        Controls.Add(DamagedStockLBL)
        Controls.Add(Label5)
        Controls.Add(AvailableStockLBL)
        Controls.Add(Label2)
        Controls.Add(RegisteredItemsLBL)
        Controls.Add(Label4)
        Name = "DashboardUC"
        Size = New Size(1537, 1001)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RegisteredItemsLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AvailableStockLBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DamagedStockLBL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NeedsRepairLBL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalIssuancesLBL As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TotalReturnedUnitsLBL As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents UnitsNotReturnedLBL As Label
    Friend WithEvents OutstandingLBL As Label
    Friend WithEvents ItemsReturnedTodayLBL As Label
    Friend WithEvents RecentReturnsLBL As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TotalDamagedLBL As Label
    Friend WithEvents TotalAvailableLBL As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TotalStockLBL As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CompletedRepairsLBL As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents BeyondRepairLBL As Label
    Friend WithEvents UnderMaintenanceLBL As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents MaintenanceLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label34 As Label

End Class
