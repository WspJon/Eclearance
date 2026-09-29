<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminStudentsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        lblNavSection = New Label()
        btnNavStudents = New Button()
        btnNavStaff = New Button()
        btnNavHistory = New Button()
        btnNavStartTerm = New Button()
        btnNavLogout = New Button()
        pnlLogo = New Panel()
        lblLogoText = New Label()
        lblLogoIcon = New Label()
        pnlMain = New Panel()
        pnlBottomDetails = New Panel()
        pnlActionsCard = New Panel()
        btnResetTerm = New Button()
        btnViewHistory = New Button()
        lblActionsSub = New Label()
        lblActionsTitle = New Label()
        pnlDetailsCard = New Panel()
        dgvClearanceDetails = New DataGridView()
        colDetailOffice = New DataGridViewTextBoxColumn()
        colDetailStatus = New DataGridViewTextBoxColumn()
        colDetailRemarks = New DataGridViewTextBoxColumn()
        lblDetailsTitle = New Label()
        dgvStudents = New DataGridView()
        colStudentNo = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colCourse = New DataGridViewTextBoxColumn()
        colYear = New DataGridViewTextBoxColumn()
        colProgress = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlSearchRow = New Panel()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        pnlStatsRow = New Panel()
        pnlStatAttention = New Panel()
        lblStatAttentionVal = New Label()
        lblStatAttentionTitle = New Label()
        lblStatAttentionIcon = New Label()
        pnlStatCleared = New Panel()
        lblStatClearedVal = New Label()
        lblStatClearedTitle = New Label()
        lblStatClearedIcon = New Label()
        pnlStatTotal = New Panel()
        lblStatTotalVal = New Label()
        lblStatTotalTitle = New Label()
        lblStatTotalIcon = New Label()
        pnlHeader = New Panel()
        btnAddStudent = New Button()
        lblTermBadge = New Label()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        lblFooterNotice = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlBottomDetails.SuspendLayout()
        pnlActionsCard.SuspendLayout()
        pnlDetailsCard.SuspendLayout()
        CType(dgvClearanceDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchRow.SuspendLayout()
        pnlStatsRow.SuspendLayout()
        pnlStatAttention.SuspendLayout()
        pnlStatCleared.SuspendLayout()
        pnlStatTotal.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(15, 39, 74)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(btnNavStudents)
        pnlSidebar.Controls.Add(btnNavStaff)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavStartTerm)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblNavSection.ForeColor = Color.FromArgb(91, 122, 159)
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(94, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "ADMINISTRATION"
        ' 
        ' btnNavStudents
        ' 
        btnNavStudents.BackColor = Color.FromArgb(28, 91, 184)
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnNavStudents.ForeColor = Color.White
        btnNavStudents.Location = New Point(12, 115)
        btnNavStudents.Name = "btnNavStudents"
        btnNavStudents.Padding = New Padding(12, 0, 0, 0)
        btnNavStudents.Size = New Size(196, 42)
        btnNavStudents.TabIndex = 2
        btnNavStudents.Text = "👥  Students"
        btnNavStudents.TextAlign = ContentAlignment.MiddleLeft
        btnNavStudents.UseVisualStyleBackColor = False
        ' 
        ' btnNavStaff
        ' 
        btnNavStaff.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStaff.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavStaff.Location = New Point(12, 163)
        btnNavStaff.Name = "btnNavStaff"
        btnNavStaff.Padding = New Padding(12, 0, 0, 0)
        btnNavStaff.Size = New Size(196, 42)
        btnNavStaff.TabIndex = 3
        btnNavStaff.Text = "🏛  Staff & offices"
        btnNavStaff.TextAlign = ContentAlignment.MiddleLeft
        btnNavStaff.UseVisualStyleBackColor = False
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.BackColor = Color.FromArgb(15, 39, 74)
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavHistory.Location = New Point(12, 211)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(12, 0, 0, 0)
        btnNavHistory.Size = New Size(196, 42)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "⏱  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavStartTerm
        ' 
        btnNavStartTerm.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStartTerm.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavStartTerm.Location = New Point(12, 259)
        btnNavStartTerm.Name = "btnNavStartTerm"
        btnNavStartTerm.Padding = New Padding(12, 0, 0, 0)
        btnNavStartTerm.Size = New Size(196, 42)
        btnNavStartTerm.TabIndex = 5
        btnNavStartTerm.Text = "📅  Start new term"
        btnNavStartTerm.TextAlign = ContentAlignment.MiddleLeft
        btnNavStartTerm.UseVisualStyleBackColor = False
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavLogout.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavLogout.Location = New Point(0, 752)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(20, 0, 0, 0)
        btnNavLogout.Size = New Size(220, 48)
        btnNavLogout.TabIndex = 6
        btnNavLogout.Text = "↪  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoText)
        pnlLogo.Controls.Add(lblLogoIcon)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 75)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoText
        ' 
        lblLogoText.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogoText.ForeColor = Color.White
        lblLogoText.Location = New Point(55, 18)
        lblLogoText.Name = "lblLogoText"
        lblLogoText.Size = New Size(140, 40)
        lblLogoText.TabIndex = 1
        lblLogoText.Text = "School" & vbCrLf & "Clearance"
        ' 
        ' lblLogoIcon
        ' 
        lblLogoIcon.AutoSize = True
        lblLogoIcon.Font = New Font("Segoe UI Emoji", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblLogoIcon.ForeColor = Color.White
        lblLogoIcon.Location = New Point(14, 20)
        lblLogoIcon.Name = "lblLogoIcon"
        lblLogoIcon.Size = New Size(38, 32)
        lblLogoIcon.TabIndex = 0
        lblLogoIcon.Text = "🎓"
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = Color.FromArgb(244, 247, 251)
        pnlMain.Controls.Add(lblFooterNotice)
        pnlMain.Controls.Add(pnlBottomDetails)
        pnlMain.Controls.Add(dgvStudents)
        pnlMain.Controls.Add(pnlSearchRow)
        pnlMain.Controls.Add(pnlStatsRow)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 20, 28, 20)
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' pnlBottomDetails
        ' 
        pnlBottomDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBottomDetails.Controls.Add(pnlActionsCard)
        pnlBottomDetails.Controls.Add(pnlDetailsCard)
        pnlBottomDetails.Location = New Point(28, 520)
        pnlBottomDetails.Name = "pnlBottomDetails"
        pnlBottomDetails.Size = New Size(924, 230)
        pnlBottomDetails.TabIndex = 5
        ' 
        ' pnlActionsCard
        ' 
        pnlActionsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlActionsCard.BackColor = Color.White
        pnlActionsCard.BorderStyle = BorderStyle.FixedSingle
        pnlActionsCard.Controls.Add(btnResetTerm)
        pnlActionsCard.Controls.Add(btnViewHistory)
        pnlActionsCard.Controls.Add(lblActionsSub)
        pnlActionsCard.Controls.Add(lblActionsTitle)
        pnlActionsCard.Location = New Point(630, 0)
        pnlActionsCard.Name = "pnlActionsCard"
        pnlActionsCard.Padding = New Padding(16)
        pnlActionsCard.Size = New Size(294, 226)
        pnlActionsCard.TabIndex = 1
        ' 
        ' btnResetTerm
        ' 
        btnResetTerm.BackColor = Color.White
        btnResetTerm.Cursor = Cursors.Hand
        btnResetTerm.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68)
        btnResetTerm.FlatStyle = FlatStyle.Flat
        btnResetTerm.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnResetTerm.ForeColor = Color.FromArgb(220, 38, 38)
        btnResetTerm.Location = New Point(16, 160)
        btnResetTerm.Name = "btnResetTerm"
        btnResetTerm.Size = New Size(260, 38)
        btnResetTerm.TabIndex = 3
        btnResetTerm.Text = "🔄 Reset current term"
        btnResetTerm.UseVisualStyleBackColor = False
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.BackColor = Color.FromArgb(11, 99, 229)
        btnViewHistory.Cursor = Cursors.Hand
        btnViewHistory.FlatAppearance.BorderSize = 0
        btnViewHistory.FlatStyle = FlatStyle.Flat
        btnViewHistory.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnViewHistory.ForeColor = Color.White
        btnViewHistory.Location = New Point(16, 110)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(260, 38)
        btnViewHistory.TabIndex = 2
        btnViewHistory.Text = "📋 View history"
        btnViewHistory.UseVisualStyleBackColor = False
        ' 
        ' lblActionsSub
        ' 
        lblActionsSub.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblActionsSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblActionsSub.Location = New Point(16, 45)
        lblActionsSub.Name = "lblActionsSub"
        lblActionsSub.Size = New Size(260, 48)
        lblActionsSub.TabIndex = 1
        lblActionsSub.Text = "View the student's clearance history or reset their progress for the current term."
        ' 
        ' lblActionsTitle
        ' 
        lblActionsTitle.AutoSize = True
        lblActionsTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblActionsTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblActionsTitle.Location = New Point(16, 16)
        lblActionsTitle.Name = "lblActionsTitle"
        lblActionsTitle.Size = New Size(62, 20)
        lblActionsTitle.TabIndex = 0
        lblActionsTitle.Text = "Actions"
        ' 
        ' pnlDetailsCard
        ' 
        pnlDetailsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDetailsCard.BackColor = Color.White
        pnlDetailsCard.BorderStyle = BorderStyle.FixedSingle
        pnlDetailsCard.Controls.Add(dgvClearanceDetails)
        pnlDetailsCard.Controls.Add(lblDetailsTitle)
        pnlDetailsCard.Location = New Point(0, 0)
        pnlDetailsCard.Name = "pnlDetailsCard"
        pnlDetailsCard.Padding = New Padding(16)
        pnlDetailsCard.Size = New Size(616, 226)
        pnlDetailsCard.TabIndex = 0
        ' 
        ' dgvClearanceDetails
        ' 
        dgvClearanceDetails.AllowUserToAddRows = False
        dgvClearanceDetails.AllowUserToDeleteRows = False
        dgvClearanceDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClearanceDetails.BackgroundColor = Color.White
        dgvClearanceDetails.BorderStyle = BorderStyle.None
        dgvClearanceDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvClearanceDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvClearanceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvClearanceDetails.ColumnHeadersHeight = 32
        dgvClearanceDetails.Columns.AddRange(New DataGridViewColumn() {colDetailOffice, colDetailStatus, colDetailRemarks})
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = Color.White
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvClearanceDetails.DefaultCellStyle = dataGridViewCellStyle2
        dgvClearanceDetails.EnableHeadersVisualStyles = False
        dgvClearanceDetails.GridColor = Color.FromArgb(241, 245, 249)
        dgvClearanceDetails.Location = New Point(16, 48)
        dgvClearanceDetails.Name = "dgvClearanceDetails"
        dgvClearanceDetails.ReadOnly = True
        dgvClearanceDetails.RowHeadersVisible = False
        dgvClearanceDetails.RowTemplate.Height = 34
        dgvClearanceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClearanceDetails.Size = New Size(582, 160)
        dgvClearanceDetails.TabIndex = 1
        ' 
        ' colDetailOffice
        ' 
        colDetailOffice.HeaderText = "Office"
        colDetailOffice.Name = "colDetailOffice"
        colDetailOffice.ReadOnly = True
        colDetailOffice.Width = 140
        ' 
        ' colDetailStatus
        ' 
        colDetailStatus.HeaderText = "Status"
        colDetailStatus.Name = "colDetailStatus"
        colDetailStatus.ReadOnly = True
        colDetailStatus.Width = 130
        ' 
        ' colDetailRemarks
        ' 
        colDetailRemarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDetailRemarks.HeaderText = "Remarks"
        colDetailRemarks.Name = "colDetailRemarks"
        colDetailRemarks.ReadOnly = True
        ' 
        ' lblDetailsTitle
        ' 
        lblDetailsTitle.AutoSize = True
        lblDetailsTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblDetailsTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailsTitle.Location = New Point(16, 16)
        lblDetailsTitle.Name = "lblDetailsTitle"
        lblDetailsTitle.Size = New Size(128, 20)
        lblDetailsTitle.TabIndex = 0
        lblDetailsTitle.Text = "Clearance details"
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.FixedSingle
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
        dgvStudents.ColumnHeadersHeight = 36
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colStudentNo, colStudentName, colCourse, colYear, colProgress, colStatus})
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle4.BackColor = Color.White
        dataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 238, 255)
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = dataGridViewCellStyle4
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(241, 245, 249)
        dgvStudents.Location = New Point(28, 260)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowTemplate.Height = 36
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(924, 240)
        dgvStudents.TabIndex = 4
        ' 
        ' colStudentNo
        ' 
        colStudentNo.HeaderText = "Student no."
        colStudentNo.Name = "colStudentNo"
        colStudentNo.ReadOnly = True
        colStudentNo.Width = 120
        ' 
        ' colStudentName
        ' 
        colStudentName.HeaderText = "Student name"
        colStudentName.Name = "colStudentName"
        colStudentName.ReadOnly = True
        colStudentName.Width = 200
        ' 
        ' colCourse
        ' 
        colCourse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCourse.HeaderText = "Course"
        colCourse.Name = "colCourse"
        colCourse.ReadOnly = True
        ' 
        ' colYear
        ' 
        colYear.HeaderText = "Year"
        colYear.Name = "colYear"
        colYear.ReadOnly = True
        colYear.Width = 80
        ' 
        ' colProgress
        ' 
        colProgress.HeaderText = "Progress"
        colProgress.Name = "colProgress"
        colProgress.ReadOnly = True
        colProgress.Width = 90
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 110
        ' 
        ' pnlSearchRow
        ' 
        pnlSearchRow.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchRow.Controls.Add(btnRefresh)
        pnlSearchRow.Controls.Add(txtSearch)
        pnlSearchRow.Location = New Point(28, 205)
        pnlSearchRow.Name = "pnlSearchRow"
        pnlSearchRow.Size = New Size(924, 42)
        pnlSearchRow.TabIndex = 3
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.White
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.FromArgb(51, 65, 85)
        btnRefresh.Location = New Point(824, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 34)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.ForeColor = Color.FromArgb(15, 23, 42)
        txtSearch.Location = New Point(0, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by name or student number"
        txtSearch.Size = New Size(808, 25)
        txtSearch.TabIndex = 0
        ' 
        ' pnlStatsRow
        ' 
        pnlStatsRow.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStatsRow.Controls.Add(pnlStatAttention)
        pnlStatsRow.Controls.Add(pnlStatCleared)
        pnlStatsRow.Controls.Add(pnlStatTotal)
        pnlStatsRow.Location = New Point(28, 95)
        pnlStatsRow.Name = "pnlStatsRow"
        pnlStatsRow.Size = New Size(924, 95)
        pnlStatsRow.TabIndex = 2
        ' 
        ' pnlStatAttention
        ' 
        pnlStatAttention.BackColor = Color.White
        pnlStatAttention.BorderStyle = BorderStyle.FixedSingle
        pnlStatAttention.Controls.Add(lblStatAttentionVal)
        pnlStatAttention.Controls.Add(lblStatAttentionTitle)
        pnlStatAttention.Controls.Add(lblStatAttentionIcon)
        pnlStatAttention.Location = New Point(630, 0)
        pnlStatAttention.Name = "pnlStatAttention"
        pnlStatAttention.Size = New Size(294, 90)
        pnlStatAttention.TabIndex = 2
        ' 
        ' lblStatAttentionVal
        ' 
        lblStatAttentionVal.AutoSize = True
        lblStatAttentionVal.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatAttentionVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblStatAttentionVal.Location = New Point(75, 40)
        lblStatAttentionVal.Name = "lblStatAttentionVal"
        lblStatAttentionVal.Size = New Size(33, 37)
        lblStatAttentionVal.TabIndex = 2
        lblStatAttentionVal.Text = "0"
        ' 
        ' lblStatAttentionTitle
        ' 
        lblStatAttentionTitle.AutoSize = True
        lblStatAttentionTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStatAttentionTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblStatAttentionTitle.Location = New Point(75, 18)
        lblStatAttentionTitle.Name = "lblStatAttentionTitle"
        lblStatAttentionTitle.Size = New Size(88, 15)
        lblStatAttentionTitle.TabIndex = 1
        lblStatAttentionTitle.Text = "Needs attention"
        ' 
        ' lblStatAttentionIcon
        ' 
        lblStatAttentionIcon.BackColor = Color.FromArgb(254, 242, 242)
        lblStatAttentionIcon.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatAttentionIcon.ForeColor = Color.FromArgb(239, 68, 68)
        lblStatAttentionIcon.Location = New Point(18, 20)
        lblStatAttentionIcon.Name = "lblStatAttentionIcon"
        lblStatAttentionIcon.Size = New Size(46, 46)
        lblStatAttentionIcon.TabIndex = 0
        lblStatAttentionIcon.Text = "!"
        lblStatAttentionIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlStatCleared
        ' 
        pnlStatCleared.BackColor = Color.White
        pnlStatCleared.BorderStyle = BorderStyle.FixedSingle
        pnlStatCleared.Controls.Add(lblStatClearedVal)
        pnlStatCleared.Controls.Add(lblStatClearedTitle)
        pnlStatCleared.Controls.Add(lblStatClearedIcon)
        pnlStatCleared.Location = New Point(315, 0)
        pnlStatCleared.Name = "pnlStatCleared"
        pnlStatCleared.Size = New Size(294, 90)
        pnlStatCleared.TabIndex = 1
        ' 
        ' lblStatClearedVal
        ' 
        lblStatClearedVal.AutoSize = True
        lblStatClearedVal.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatClearedVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblStatClearedVal.Location = New Point(75, 40)
        lblStatClearedVal.Name = "lblStatClearedVal"
        lblStatClearedVal.Size = New Size(33, 37)
        lblStatClearedVal.TabIndex = 2
        lblStatClearedVal.Text = "0"
        ' 
        ' lblStatClearedTitle
        ' 
        lblStatClearedTitle.AutoSize = True
        lblStatClearedTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStatClearedTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblStatClearedTitle.Location = New Point(75, 18)
        lblStatClearedTitle.Name = "lblStatClearedTitle"
        lblStatClearedTitle.Size = New Size(73, 15)
        lblStatClearedTitle.TabIndex = 1
        lblStatClearedTitle.Text = "Fully cleared"
        ' 
        ' lblStatClearedIcon
        ' 
        lblStatClearedIcon.BackColor = Color.FromArgb(240, 253, 244)
        lblStatClearedIcon.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatClearedIcon.ForeColor = Color.FromArgb(22, 163, 74)
        lblStatClearedIcon.Location = New Point(18, 20)
        lblStatClearedIcon.Name = "lblStatClearedIcon"
        lblStatClearedIcon.Size = New Size(46, 46)
        lblStatClearedIcon.TabIndex = 0
        lblStatClearedIcon.Text = "✔"
        lblStatClearedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlStatTotal
        ' 
        pnlStatTotal.BackColor = Color.White
        pnlStatTotal.BorderStyle = BorderStyle.FixedSingle
        pnlStatTotal.Controls.Add(lblStatTotalVal)
        pnlStatTotal.Controls.Add(lblStatTotalTitle)
        pnlStatTotal.Controls.Add(lblStatTotalIcon)
        pnlStatTotal.Location = New Point(0, 0)
        pnlStatTotal.Name = "pnlStatTotal"
        pnlStatTotal.Size = New Size(294, 90)
        pnlStatTotal.TabIndex = 0
        ' 
        ' lblStatTotalVal
        ' 
        lblStatTotalVal.AutoSize = True
        lblStatTotalVal.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatTotalVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblStatTotalVal.Location = New Point(75, 40)
        lblStatTotalVal.Name = "lblStatTotalVal"
        lblStatTotalVal.Size = New Size(33, 37)
        lblStatTotalVal.TabIndex = 2
        lblStatTotalVal.Text = "0"
        ' 
        ' lblStatTotalTitle
        ' 
        lblStatTotalTitle.AutoSize = True
        lblStatTotalTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStatTotalTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblStatTotalTitle.Location = New Point(75, 18)
        lblStatTotalTitle.Name = "lblStatTotalTitle"
        lblStatTotalTitle.Size = New Size(79, 15)
        lblStatTotalTitle.TabIndex = 1
        lblStatTotalTitle.Text = "Total students"
        ' 
        ' lblStatTotalIcon
        ' 
        lblStatTotalIcon.BackColor = Color.FromArgb(239, 246, 255)
        lblStatTotalIcon.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatTotalIcon.ForeColor = Color.FromArgb(11, 99, 229)
        lblStatTotalIcon.Location = New Point(18, 20)
        lblStatTotalIcon.Name = "lblStatTotalIcon"
        lblStatTotalIcon.Size = New Size(46, 46)
        lblStatTotalIcon.TabIndex = 0
        lblStatTotalIcon.Text = "👥"
        lblStatTotalIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(btnAddStudent)
        pnlHeader.Controls.Add(lblTermBadge)
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Location = New Point(28, 15)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddStudent.BackColor = Color.FromArgb(11, 99, 229)
        btnAddStudent.Cursor = Cursors.Hand
        btnAddStudent.FlatAppearance.BorderSize = 0
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddStudent.ForeColor = Color.White
        btnAddStudent.Location = New Point(804, 12)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(120, 38)
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "+ Add student"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' lblTermBadge
        ' 
        lblTermBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTermBadge.BackColor = Color.FromArgb(238, 242, 255)
        lblTermBadge.BorderStyle = BorderStyle.FixedSingle
        lblTermBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTermBadge.ForeColor = Color.FromArgb(49, 46, 129)
        lblTermBadge.Location = New Point(610, 14)
        lblTermBadge.Name = "lblTermBadge"
        lblTermBadge.Padding = New Padding(6)
        lblTermBadge.Size = New Size(180, 34)
        lblTermBadge.TabIndex = 2
        lblTermBadge.Text = "📅 Current Term"
        lblTermBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(0, 38)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(247, 17)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Manage student clearance for current term."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(128, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Students"
        ' 
        ' lblFooterNotice
        ' 
        lblFooterNotice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblFooterNotice.AutoSize = True
        lblFooterNotice.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblFooterNotice.ForeColor = Color.FromArgb(148, 163, 184)
        lblFooterNotice.Location = New Point(28, 765)
        lblFooterNotice.Name = "lblFooterNotice"
        lblFooterNotice.Size = New Size(207, 15)
        lblFooterNotice.TabIndex = 6
        lblFooterNotice.Text = "Previous submissions remain in History."
        ' 
        ' AdminStudentsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "AdminStudentsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Administration (Students)"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlBottomDetails.ResumeLayout(False)
        pnlActionsCard.ResumeLayout(False)
        pnlActionsCard.PerformLayout()
        pnlDetailsCard.ResumeLayout(False)
        pnlDetailsCard.PerformLayout()
        CType(dgvClearanceDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchRow.ResumeLayout(False)
        pnlSearchRow.PerformLayout()
        pnlStatsRow.ResumeLayout(False)
        pnlStatAttention.ResumeLayout(False)
        pnlStatAttention.PerformLayout()
        pnlStatCleared.ResumeLayout(False)
        pnlStatCleared.PerformLayout()
        pnlStatTotal.ResumeLayout(False)
        pnlStatTotal.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoIcon As Label
    Friend WithEvents lblLogoText As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavStudents As Button
    Friend WithEvents btnNavStaff As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavStartTerm As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents lblTermBadge As Label
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents pnlStatsRow As Panel
    Friend WithEvents pnlStatTotal As Panel
    Friend WithEvents lblStatTotalIcon As Label
    Friend WithEvents lblStatTotalTitle As Label
    Friend WithEvents lblStatTotalVal As Label
    Friend WithEvents pnlStatCleared As Panel
    Friend WithEvents lblStatClearedIcon As Label
    Friend WithEvents lblStatClearedTitle As Label
    Friend WithEvents lblStatClearedVal As Label
    Friend WithEvents pnlStatAttention As Panel
    Friend WithEvents lblStatAttentionIcon As Label
    Friend WithEvents lblStatAttentionTitle As Label
    Friend WithEvents lblStatAttentionVal As Label
    Friend WithEvents pnlSearchRow As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents colStudentNo As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colCourse As DataGridViewTextBoxColumn
    Friend WithEvents colYear As DataGridViewTextBoxColumn
    Friend WithEvents colProgress As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents pnlBottomDetails As Panel
    Friend WithEvents pnlDetailsCard As Panel
    Friend WithEvents lblDetailsTitle As Label
    Friend WithEvents dgvClearanceDetails As DataGridView
    Friend WithEvents colDetailOffice As DataGridViewTextBoxColumn
    Friend WithEvents colDetailStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDetailRemarks As DataGridViewTextBoxColumn
    Friend WithEvents pnlActionsCard As Panel
    Friend WithEvents lblActionsTitle As Label
    Friend WithEvents lblActionsSub As Label
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnResetTerm As Button
    Friend WithEvents lblFooterNotice As Label

End Class
