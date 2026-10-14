<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
    Inherits Form
    Private components As System.ComponentModel.IContainer
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        picSchoolLogo = New PictureBox()
        lblBrand = New Label()
        lblNavSection = New Label()
        btnNavStudents = New Button()
        btnNavStaff = New Button()
        btnNavReports = New Button()
        btnNavHistory = New Button()
        btnNavStartTerm = New Button()
        btnNavLogout = New Button()
        pnlViewport = New Panel()
        pnlCanvas = New Panel()
        tlpBottom = New TableLayoutPanel()
        pnlStudents = New Panel()
        lblStudentsTitle = New Label()
        txtSearch = New TextBox()
        dgvStudents = New DataGridView()
        colNumber = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colCourseYear = New DataGridViewTextBoxColumn()
        colProgress = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colWaiting = New DataGridViewTextBoxColumn()
        colActivity = New DataGridViewTextBoxColumn()
        lblPage = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        pnlPresets = New Panel()
        lblPresetsTitle = New Label()
        btnPresetAll = New Button()
        btnPresetCleared = New Button()
        btnPresetAttention = New Button()
        btnPresetOffice = New Button()
        btnPresetWaiting = New Button()
        lblPresetsNote = New Label()
        tlpCharts = New TableLayoutPanel()
        pnlOfficeChart = New Panel()
        lblOfficeChartTitle = New Label()
        lblOfficeChartSub = New Label()
        chartOffices = New ReportsChartPanel()
        pnlOverallChart = New Panel()
        lblOverallTitle = New Label()
        lblOverallSub = New Label()
        chartOverall = New ReportsChartPanel()
        tlpSummaryCards = New TableLayoutPanel()
        pnlCleared = New Panel()
        lblClearedTitle = New Label()
        lblClearedCount = New Label()
        lblClearedDetail = New Label()
        pnlProgress = New Panel()
        lblProgressTitle = New Label()
        lblProgressCount = New Label()
        lblProgressDetail = New Label()
        pnlAttention = New Panel()
        lblAttentionTitle = New Label()
        lblAttentionCount = New Label()
        lblAttentionDetail = New Label()
        pnlReview = New Panel()
        lblReviewTitle = New Label()
        lblReviewCount = New Label()
        lblReviewDetail = New Label()
        pnlFilters = New Panel()
        tlpFilterInputs = New TableLayoutPanel()
        lblTerm = New Label()
        lblOffice = New Label()
        lblCourse = New Label()
        lblYear = New Label()
        lblStatus = New Label()
        cmbTerm = New ComboBox()
        cmbOffice = New ComboBox()
        cmbCourse = New ComboBox()
        cmbYear = New ComboBox()
        cmbStatus = New ComboBox()
        btnGenerate = New Button()
        btnExportCsv = New Button()
        btnExportPdf = New Button()
        btnPrint = New Button()
        lblLoading = New Label()
        lblActiveTerm = New Label()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlSidebar.SuspendLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlViewport.SuspendLayout()
        pnlCanvas.SuspendLayout()
        tlpBottom.SuspendLayout()
        pnlStudents.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlPresets.SuspendLayout()
        tlpCharts.SuspendLayout()
        pnlOfficeChart.SuspendLayout()
        pnlOverallChart.SuspendLayout()
        tlpSummaryCards.SuspendLayout()
        pnlCleared.SuspendLayout()
        pnlProgress.SuspendLayout()
        pnlAttention.SuspendLayout()
        pnlReview.SuspendLayout()
        pnlFilters.SuspendLayout()
        tlpFilterInputs.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        pnlSidebar.Controls.Add(picSchoolLogo)
        pnlSidebar.Controls.Add(lblBrand)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(btnNavStudents)
        pnlSidebar.Controls.Add(btnNavStaff)
        pnlSidebar.Controls.Add(btnNavReports)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavStartTerm)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 900)
        pnlSidebar.TabIndex = 1
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(12, 16)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(32, 32)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' lblBrand
        ' 
        lblBrand.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(55, 18)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(145, 38)
        lblBrand.TabIndex = 1
        lblBrand.Text = "EClearance"
        ' 
        ' lblNavSection
        ' 
        lblNavSection.Font = New Font("Segoe UI", 8.0F)
        lblNavSection.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(180, 20)
        lblNavSection.TabIndex = 2
        lblNavSection.Text = "ADMINISTRATION"
        ' 
        ' btnNavStudents
        ' 
        btnNavStudents.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStudents.Cursor = Cursors.Hand
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI", 9.5F)
        btnNavStudents.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavStudents.Location = New Point(12, 115)
        btnNavStudents.Name = "btnNavStudents"
        btnNavStudents.Padding = New Padding(12, 0, 0, 0)
        btnNavStudents.Size = New Size(196, 42)
        btnNavStudents.TabIndex = 3
        btnNavStudents.Text = "  Students"
        btnNavStudents.TextAlign = ContentAlignment.MiddleLeft
        btnNavStudents.UseVisualStyleBackColor = False
        ' 
        ' btnNavStaff
        ' 
        btnNavStaff.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStaff.Cursor = Cursors.Hand
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI", 9.5F)
        btnNavStaff.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavStaff.Location = New Point(12, 163)
        btnNavStaff.Name = "btnNavStaff"
        btnNavStaff.Padding = New Padding(12, 0, 0, 0)
        btnNavStaff.Size = New Size(196, 42)
        btnNavStaff.TabIndex = 4
        btnNavStaff.Text = "  Department Heads & Offices"
        btnNavStaff.TextAlign = ContentAlignment.MiddleLeft
        btnNavStaff.UseVisualStyleBackColor = False
        ' 
        ' btnNavReports
        ' 
        btnNavReports.BackColor = Color.FromArgb(CByte(28), CByte(91), CByte(184))
        btnNavReports.Cursor = Cursors.Hand
        btnNavReports.FlatAppearance.BorderSize = 0
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnNavReports.ForeColor = Color.White
        btnNavReports.Location = New Point(12, 211)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Padding = New Padding(12, 0, 0, 0)
        btnNavReports.Size = New Size(196, 42)
        btnNavReports.TabIndex = 5
        btnNavReports.Text = "  Reports"
        btnNavReports.TextAlign = ContentAlignment.MiddleLeft
        btnNavReports.UseVisualStyleBackColor = False
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavHistory.Cursor = Cursors.Hand
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavHistory.Location = New Point(12, 259)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(12, 0, 0, 0)
        btnNavHistory.Size = New Size(196, 42)
        btnNavHistory.TabIndex = 6
        btnNavHistory.Text = "  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavStartTerm
        ' 
        btnNavStartTerm.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStartTerm.Cursor = Cursors.Hand
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI", 9.5F)
        btnNavStartTerm.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavStartTerm.Location = New Point(12, 307)
        btnNavStartTerm.Name = "btnNavStartTerm"
        btnNavStartTerm.Padding = New Padding(12, 0, 0, 0)
        btnNavStartTerm.Size = New Size(196, 42)
        btnNavStartTerm.TabIndex = 7
        btnNavStartTerm.Text = "  Start new term"
        btnNavStartTerm.TextAlign = ContentAlignment.MiddleLeft
        btnNavStartTerm.UseVisualStyleBackColor = False
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavLogout.Location = New Point(0, 852)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Size = New Size(220, 48)
        btnNavLogout.TabIndex = 8
        btnNavLogout.Text = "Log out"
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlViewport
        ' 
        pnlViewport.AutoScroll = True
        pnlViewport.Controls.Add(pnlCanvas)
        pnlViewport.Dock = DockStyle.Fill
        pnlViewport.Location = New Point(220, 0)
        pnlViewport.Name = "pnlViewport"
        pnlViewport.Size = New Size(1260, 900)
        pnlViewport.TabIndex = 0
        ' 
        ' pnlCanvas
        ' 
        pnlCanvas.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlCanvas.Controls.Add(tlpBottom)
        pnlCanvas.Controls.Add(tlpCharts)
        pnlCanvas.Controls.Add(tlpSummaryCards)
        pnlCanvas.Controls.Add(pnlFilters)
        pnlCanvas.Controls.Add(lblActiveTerm)
        pnlCanvas.Controls.Add(lblSubtitle)
        pnlCanvas.Controls.Add(lblTitle)
        pnlCanvas.Dock = DockStyle.Top
        pnlCanvas.Location = New Point(0, 0)
        pnlCanvas.MinimumSize = New Size(1060, 1370)
        pnlCanvas.Name = "pnlCanvas"
        pnlCanvas.Size = New Size(1243, 1370)
        pnlCanvas.TabIndex = 0
        ' 
        ' tlpBottom
        ' 
        tlpBottom.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tlpBottom.ColumnCount = 2
        tlpBottom.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 68.0F))
        tlpBottom.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.0F))
        tlpBottom.Controls.Add(pnlStudents, 0, 0)
        tlpBottom.Controls.Add(pnlPresets, 1, 0)
        tlpBottom.Location = New Point(28, 846)
        tlpBottom.Name = "tlpBottom"
        tlpBottom.RowCount = 1
        tlpBottom.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpBottom.Size = New Size(1187, 490)
        tlpBottom.TabIndex = 0
        ' 
        ' pnlStudents
        ' 
        pnlStudents.BackColor = Color.White
        pnlStudents.BorderStyle = BorderStyle.FixedSingle
        pnlStudents.Controls.Add(lblStudentsTitle)
        pnlStudents.Controls.Add(txtSearch)
        pnlStudents.Controls.Add(dgvStudents)
        pnlStudents.Controls.Add(lblPage)
        pnlStudents.Controls.Add(btnPrevious)
        pnlStudents.Controls.Add(btnNext)
        pnlStudents.Dock = DockStyle.Fill
        pnlStudents.Location = New Point(0, 0)
        pnlStudents.Margin = New Padding(0, 0, 10, 0)
        pnlStudents.Name = "pnlStudents"
        pnlStudents.Size = New Size(797, 490)
        pnlStudents.TabIndex = 0
        ' 
        ' lblStudentsTitle
        ' 
        lblStudentsTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblStudentsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentsTitle.Location = New Point(20, 20)
        lblStudentsTitle.Name = "lblStudentsTitle"
        lblStudentsTitle.Size = New Size(320, 30)
        lblStudentsTitle.TabIndex = 0
        lblStudentsTitle.Text = "Student clearance status"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.Location = New Point(1063, 20)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by name or student no."
        txtSearch.Size = New Size(320, 24)
        txtSearch.TabIndex = 1
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AllowUserToResizeRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.ColumnHeadersHeight = 42
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colNumber, colName, colCourseYear, colProgress, colStatus, colWaiting, colActivity})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.EnableHeadersVisualStyles = False
        dgvStudents.GridColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        dgvStudents.Location = New Point(20, 64)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowTemplate.Height = 48
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(1363, 743)
        dgvStudents.TabIndex = 2
        ' 
        ' colNumber
        ' 
        colNumber.HeaderText = "Student No."
        colNumber.Name = "colNumber"
        colNumber.ReadOnly = True
        colNumber.SortMode = DataGridViewColumnSortMode.NotSortable
        colNumber.Width = 110
        ' 
        ' colName
        ' 
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.SortMode = DataGridViewColumnSortMode.NotSortable
        colName.Width = 160
        ' 
        ' colCourseYear
        ' 
        colCourseYear.HeaderText = "Course / Year"
        colCourseYear.Name = "colCourseYear"
        colCourseYear.ReadOnly = True
        colCourseYear.SortMode = DataGridViewColumnSortMode.NotSortable
        colCourseYear.Width = 135
        ' 
        ' colProgress
        ' 
        colProgress.HeaderText = "Progress"
        colProgress.Name = "colProgress"
        colProgress.ReadOnly = True
        colProgress.SortMode = DataGridViewColumnSortMode.NotSortable
        colProgress.Width = 115
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        colStatus.Width = 130
        ' 
        ' colWaiting
        ' 
        colWaiting.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colWaiting.HeaderText = "Waiting on"
        colWaiting.MinimumWidth = 180
        colWaiting.Name = "colWaiting"
        colWaiting.ReadOnly = True
        colWaiting.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colActivity
        ' 
        colActivity.HeaderText = "Last activity"
        colActivity.Name = "colActivity"
        colActivity.ReadOnly = True
        colActivity.SortMode = DataGridViewColumnSortMode.NotSortable
        colActivity.Width = 145
        ' 
        ' lblPage
        ' 
        lblPage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblPage.Font = New Font("Segoe UI", 9.0F)
        lblPage.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblPage.Location = New Point(20, 828)
        lblPage.Name = "lblPage"
        lblPage.Size = New Size(420, 25)
        lblPage.TabIndex = 3
        lblPage.Text = "No report generated"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnPrevious.BackColor = Color.White
        btnPrevious.Cursor = Cursors.Hand
        btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPrevious.Location = New Point(1178, 823)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(95, 34)
        btnPrevious.TabIndex = 4
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNext.BackColor = Color.White
        btnNext.Cursor = Cursors.Hand
        btnNext.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnNext.Location = New Point(1288, 823)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(95, 34)
        btnNext.TabIndex = 5
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' pnlPresets
        ' 
        pnlPresets.BackColor = Color.White
        pnlPresets.BorderStyle = BorderStyle.FixedSingle
        pnlPresets.Controls.Add(lblPresetsTitle)
        pnlPresets.Controls.Add(btnPresetAll)
        pnlPresets.Controls.Add(btnPresetCleared)
        pnlPresets.Controls.Add(btnPresetAttention)
        pnlPresets.Controls.Add(btnPresetOffice)
        pnlPresets.Controls.Add(btnPresetWaiting)
        pnlPresets.Controls.Add(lblPresetsNote)
        pnlPresets.Dock = DockStyle.Fill
        pnlPresets.Location = New Point(817, 0)
        pnlPresets.Margin = New Padding(10, 0, 0, 0)
        pnlPresets.Name = "pnlPresets"
        pnlPresets.Size = New Size(370, 490)
        pnlPresets.TabIndex = 1
        ' 
        ' lblPresetsTitle
        ' 
        lblPresetsTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPresetsTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblPresetsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblPresetsTitle.Location = New Point(20, 20)
        lblPresetsTitle.Name = "lblPresetsTitle"
        lblPresetsTitle.Size = New Size(503, 30)
        lblPresetsTitle.TabIndex = 0
        lblPresetsTitle.Text = "Available reports"
        ' 
        ' btnPresetAll
        ' 
        btnPresetAll.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPresetAll.BackColor = Color.White
        btnPresetAll.Cursor = Cursors.Hand
        btnPresetAll.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPresetAll.FlatStyle = FlatStyle.Flat
        btnPresetAll.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPresetAll.Location = New Point(20, 64)
        btnPresetAll.Name = "btnPresetAll"
        btnPresetAll.Padding = New Padding(12, 0, 0, 0)
        btnPresetAll.Size = New Size(503, 52)
        btnPresetAll.TabIndex = 1
        btnPresetAll.Text = "All clearance records"
        btnPresetAll.TextAlign = ContentAlignment.MiddleLeft
        btnPresetAll.UseVisualStyleBackColor = False
        ' 
        ' btnPresetCleared
        ' 
        btnPresetCleared.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPresetCleared.BackColor = Color.White
        btnPresetCleared.Cursor = Cursors.Hand
        btnPresetCleared.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPresetCleared.FlatStyle = FlatStyle.Flat
        btnPresetCleared.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPresetCleared.Location = New Point(20, 126)
        btnPresetCleared.Name = "btnPresetCleared"
        btnPresetCleared.Padding = New Padding(12, 0, 0, 0)
        btnPresetCleared.Size = New Size(503, 52)
        btnPresetCleared.TabIndex = 2
        btnPresetCleared.Text = "Fully cleared students"
        btnPresetCleared.TextAlign = ContentAlignment.MiddleLeft
        btnPresetCleared.UseVisualStyleBackColor = False
        ' 
        ' btnPresetAttention
        ' 
        btnPresetAttention.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPresetAttention.BackColor = Color.White
        btnPresetAttention.Cursor = Cursors.Hand
        btnPresetAttention.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPresetAttention.FlatStyle = FlatStyle.Flat
        btnPresetAttention.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPresetAttention.Location = New Point(20, 188)
        btnPresetAttention.Name = "btnPresetAttention"
        btnPresetAttention.Padding = New Padding(12, 0, 0, 0)
        btnPresetAttention.Size = New Size(503, 52)
        btnPresetAttention.TabIndex = 3
        btnPresetAttention.Text = "Needs attention"
        btnPresetAttention.TextAlign = ContentAlignment.MiddleLeft
        btnPresetAttention.UseVisualStyleBackColor = False
        ' 
        ' btnPresetOffice
        ' 
        btnPresetOffice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPresetOffice.BackColor = Color.White
        btnPresetOffice.Cursor = Cursors.Hand
        btnPresetOffice.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPresetOffice.FlatStyle = FlatStyle.Flat
        btnPresetOffice.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPresetOffice.Location = New Point(20, 250)
        btnPresetOffice.Name = "btnPresetOffice"
        btnPresetOffice.Padding = New Padding(12, 0, 0, 0)
        btnPresetOffice.Size = New Size(503, 52)
        btnPresetOffice.TabIndex = 4
        btnPresetOffice.Text = "Clearance by office"
        btnPresetOffice.TextAlign = ContentAlignment.MiddleLeft
        btnPresetOffice.UseVisualStyleBackColor = False
        ' 
        ' btnPresetWaiting
        ' 
        btnPresetWaiting.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPresetWaiting.BackColor = Color.White
        btnPresetWaiting.Cursor = Cursors.Hand
        btnPresetWaiting.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPresetWaiting.FlatStyle = FlatStyle.Flat
        btnPresetWaiting.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPresetWaiting.Location = New Point(20, 312)
        btnPresetWaiting.Name = "btnPresetWaiting"
        btnPresetWaiting.Padding = New Padding(12, 0, 0, 0)
        btnPresetWaiting.Size = New Size(503, 52)
        btnPresetWaiting.TabIndex = 5
        btnPresetWaiting.Text = "Waiting-on report"
        btnPresetWaiting.TextAlign = ContentAlignment.MiddleLeft
        btnPresetWaiting.UseVisualStyleBackColor = False
        ' 
        ' lblPresetsNote
        ' 
        lblPresetsNote.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPresetsNote.Font = New Font("Segoe UI", 9.0F)
        lblPresetsNote.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblPresetsNote.Location = New Point(20, 788)
        lblPresetsNote.Name = "lblPresetsNote"
        lblPresetsNote.Size = New Size(503, 65)
        lblPresetsNote.TabIndex = 6
        lblPresetsNote.Text = "Reports use the filters above. Export includes all matching students, across every page."
        ' 
        ' tlpCharts
        ' 
        tlpCharts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tlpCharts.ColumnCount = 2
        tlpCharts.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.0F))
        tlpCharts.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.0F))
        tlpCharts.Controls.Add(pnlOfficeChart, 0, 0)
        tlpCharts.Controls.Add(pnlOverallChart, 1, 0)
        tlpCharts.Location = New Point(28, 408)
        tlpCharts.Name = "tlpCharts"
        tlpCharts.RowCount = 1
        tlpCharts.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpCharts.Size = New Size(1187, 420)
        tlpCharts.TabIndex = 1
        ' 
        ' pnlOfficeChart
        ' 
        pnlOfficeChart.BackColor = Color.White
        pnlOfficeChart.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeChart.Controls.Add(lblOfficeChartTitle)
        pnlOfficeChart.Controls.Add(lblOfficeChartSub)
        pnlOfficeChart.Controls.Add(chartOffices)
        pnlOfficeChart.Dock = DockStyle.Fill
        pnlOfficeChart.Location = New Point(0, 0)
        pnlOfficeChart.Margin = New Padding(0, 0, 10, 0)
        pnlOfficeChart.Name = "pnlOfficeChart"
        pnlOfficeChart.Size = New Size(737, 420)
        pnlOfficeChart.TabIndex = 0
        ' 
        ' lblOfficeChartTitle
        ' 
        lblOfficeChartTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOfficeChartTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblOfficeChartTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeChartTitle.Location = New Point(20, 18)
        lblOfficeChartTitle.Name = "lblOfficeChartTitle"
        lblOfficeChartTitle.Size = New Size(1245, 28)
        lblOfficeChartTitle.TabIndex = 0
        lblOfficeChartTitle.Text = "Clearance by office"
        ' 
        ' lblOfficeChartSub
        ' 
        lblOfficeChartSub.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOfficeChartSub.Font = New Font("Segoe UI", 9.0F)
        lblOfficeChartSub.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeChartSub.Location = New Point(20, 48)
        lblOfficeChartSub.Name = "lblOfficeChartSub"
        lblOfficeChartSub.Size = New Size(1245, 25)
        lblOfficeChartSub.TabIndex = 1
        lblOfficeChartSub.Text = "Applicable requirements only; non-applicable items are excluded."
        ' 
        ' chartOffices
        ' 
        chartOffices.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        chartOffices.AutoScroll = True
        chartOffices.BackColor = Color.White
        chartOffices.Location = New Point(18, 79)
        chartOffices.Name = "chartOffices"
        chartOffices.Size = New Size(1245, 641)
        chartOffices.TabIndex = 2
        ' 
        ' pnlOverallChart
        ' 
        pnlOverallChart.BackColor = Color.White
        pnlOverallChart.BorderStyle = BorderStyle.FixedSingle
        pnlOverallChart.Controls.Add(lblOverallTitle)
        pnlOverallChart.Controls.Add(lblOverallSub)
        pnlOverallChart.Controls.Add(chartOverall)
        pnlOverallChart.Dock = DockStyle.Fill
        pnlOverallChart.Location = New Point(757, 0)
        pnlOverallChart.Margin = New Padding(10, 0, 0, 0)
        pnlOverallChart.Name = "pnlOverallChart"
        pnlOverallChart.Size = New Size(430, 420)
        pnlOverallChart.TabIndex = 1
        ' 
        ' lblOverallTitle
        ' 
        lblOverallTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOverallTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblOverallTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOverallTitle.Location = New Point(20, 18)
        lblOverallTitle.Name = "lblOverallTitle"
        lblOverallTitle.Size = New Size(628, 28)
        lblOverallTitle.TabIndex = 0
        lblOverallTitle.Text = "Overall student status"
        ' 
        ' lblOverallSub
        ' 
        lblOverallSub.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOverallSub.Font = New Font("Segoe UI", 9.0F)
        lblOverallSub.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOverallSub.Location = New Point(20, 48)
        lblOverallSub.Name = "lblOverallSub"
        lblOverallSub.Size = New Size(628, 25)
        lblOverallSub.TabIndex = 1
        lblOverallSub.Text = "Same status rules as the Students screen."
        ' 
        ' chartOverall
        ' 
        chartOverall.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        chartOverall.BackColor = Color.White
        chartOverall.Location = New Point(18, 79)
        chartOverall.Name = "chartOverall"
        chartOverall.Size = New Size(628, 641)
        chartOverall.TabIndex = 2
        ' 
        ' tlpSummaryCards
        ' 
        tlpSummaryCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tlpSummaryCards.ColumnCount = 4
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpSummaryCards.Controls.Add(pnlCleared, 0, 0)
        tlpSummaryCards.Controls.Add(pnlProgress, 1, 0)
        tlpSummaryCards.Controls.Add(pnlAttention, 2, 0)
        tlpSummaryCards.Controls.Add(pnlReview, 3, 0)
        tlpSummaryCards.Location = New Point(28, 274)
        tlpSummaryCards.Name = "tlpSummaryCards"
        tlpSummaryCards.RowCount = 1
        tlpSummaryCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpSummaryCards.Size = New Size(1187, 116)
        tlpSummaryCards.TabIndex = 2
        ' 
        ' pnlCleared
        ' 
        pnlCleared.BackColor = Color.White
        pnlCleared.BorderStyle = BorderStyle.FixedSingle
        pnlCleared.Controls.Add(lblClearedTitle)
        pnlCleared.Controls.Add(lblClearedCount)
        pnlCleared.Controls.Add(lblClearedDetail)
        pnlCleared.Dock = DockStyle.Fill
        pnlCleared.Location = New Point(0, 0)
        pnlCleared.Margin = New Padding(0, 0, 9, 0)
        pnlCleared.Name = "pnlCleared"
        pnlCleared.Size = New Size(287, 116)
        pnlCleared.TabIndex = 0
        ' 
        ' lblClearedTitle
        ' 
        lblClearedTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClearedTitle.Font = New Font("Segoe UI", 9.5F)
        lblClearedTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClearedTitle.Location = New Point(18, 14)
        lblClearedTitle.Name = "lblClearedTitle"
        lblClearedTitle.Size = New Size(335, 23)
        lblClearedTitle.TabIndex = 0
        lblClearedTitle.Text = "Fully cleared"
        ' 
        ' lblClearedCount
        ' 
        lblClearedCount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClearedCount.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblClearedCount.ForeColor = Color.FromArgb(CByte(21), CByte(128), CByte(61))
        lblClearedCount.Location = New Point(18, 38)
        lblClearedCount.Name = "lblClearedCount"
        lblClearedCount.Size = New Size(335, 42)
        lblClearedCount.TabIndex = 1
        lblClearedCount.Text = "0"
        ' 
        ' lblClearedDetail
        ' 
        lblClearedDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClearedDetail.Font = New Font("Segoe UI", 8.5F)
        lblClearedDetail.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClearedDetail.Location = New Point(18, 83)
        lblClearedDetail.Name = "lblClearedDetail"
        lblClearedDetail.Size = New Size(335, 23)
        lblClearedDetail.TabIndex = 2
        lblClearedDetail.Text = "No report generated"
        ' 
        ' pnlProgress
        ' 
        pnlProgress.BackColor = Color.White
        pnlProgress.BorderStyle = BorderStyle.FixedSingle
        pnlProgress.Controls.Add(lblProgressTitle)
        pnlProgress.Controls.Add(lblProgressCount)
        pnlProgress.Controls.Add(lblProgressDetail)
        pnlProgress.Dock = DockStyle.Fill
        pnlProgress.Location = New Point(301, 0)
        pnlProgress.Margin = New Padding(5, 0, 7, 0)
        pnlProgress.Name = "pnlProgress"
        pnlProgress.Size = New Size(284, 116)
        pnlProgress.TabIndex = 1
        ' 
        ' lblProgressTitle
        ' 
        lblProgressTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProgressTitle.Font = New Font("Segoe UI", 9.5F)
        lblProgressTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblProgressTitle.Location = New Point(18, 14)
        lblProgressTitle.Name = "lblProgressTitle"
        lblProgressTitle.Size = New Size(332, 23)
        lblProgressTitle.TabIndex = 0
        lblProgressTitle.Text = "In progress"
        ' 
        ' lblProgressCount
        ' 
        lblProgressCount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProgressCount.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblProgressCount.ForeColor = Color.FromArgb(CByte(180), CByte(83), CByte(9))
        lblProgressCount.Location = New Point(18, 38)
        lblProgressCount.Name = "lblProgressCount"
        lblProgressCount.Size = New Size(332, 42)
        lblProgressCount.TabIndex = 1
        lblProgressCount.Text = "0"
        ' 
        ' lblProgressDetail
        ' 
        lblProgressDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProgressDetail.Font = New Font("Segoe UI", 8.5F)
        lblProgressDetail.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblProgressDetail.Location = New Point(18, 83)
        lblProgressDetail.Name = "lblProgressDetail"
        lblProgressDetail.Size = New Size(332, 23)
        lblProgressDetail.TabIndex = 2
        lblProgressDetail.Text = "No report generated"
        ' 
        ' pnlAttention
        ' 
        pnlAttention.BackColor = Color.White
        pnlAttention.BorderStyle = BorderStyle.FixedSingle
        pnlAttention.Controls.Add(lblAttentionTitle)
        pnlAttention.Controls.Add(lblAttentionCount)
        pnlAttention.Controls.Add(lblAttentionDetail)
        pnlAttention.Dock = DockStyle.Fill
        pnlAttention.Location = New Point(599, 0)
        pnlAttention.Margin = New Padding(7, 0, 5, 0)
        pnlAttention.Name = "pnlAttention"
        pnlAttention.Size = New Size(284, 116)
        pnlAttention.TabIndex = 2
        ' 
        ' lblAttentionTitle
        ' 
        lblAttentionTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAttentionTitle.Font = New Font("Segoe UI", 9.5F)
        lblAttentionTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAttentionTitle.Location = New Point(18, 14)
        lblAttentionTitle.Name = "lblAttentionTitle"
        lblAttentionTitle.Size = New Size(332, 23)
        lblAttentionTitle.TabIndex = 0
        lblAttentionTitle.Text = "Needs attention"
        ' 
        ' lblAttentionCount
        ' 
        lblAttentionCount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAttentionCount.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblAttentionCount.ForeColor = Color.FromArgb(CByte(185), CByte(28), CByte(28))
        lblAttentionCount.Location = New Point(18, 38)
        lblAttentionCount.Name = "lblAttentionCount"
        lblAttentionCount.Size = New Size(332, 42)
        lblAttentionCount.TabIndex = 1
        lblAttentionCount.Text = "0"
        ' 
        ' lblAttentionDetail
        ' 
        lblAttentionDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAttentionDetail.Font = New Font("Segoe UI", 8.5F)
        lblAttentionDetail.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAttentionDetail.Location = New Point(18, 83)
        lblAttentionDetail.Name = "lblAttentionDetail"
        lblAttentionDetail.Size = New Size(332, 23)
        lblAttentionDetail.TabIndex = 2
        lblAttentionDetail.Text = "No report generated"
        ' 
        ' pnlReview
        ' 
        pnlReview.BackColor = Color.White
        pnlReview.BorderStyle = BorderStyle.FixedSingle
        pnlReview.Controls.Add(lblReviewTitle)
        pnlReview.Controls.Add(lblReviewCount)
        pnlReview.Controls.Add(lblReviewDetail)
        pnlReview.Dock = DockStyle.Fill
        pnlReview.Location = New Point(897, 0)
        pnlReview.Margin = New Padding(9, 0, 0, 0)
        pnlReview.Name = "pnlReview"
        pnlReview.Size = New Size(290, 116)
        pnlReview.TabIndex = 3
        ' 
        ' lblReviewTitle
        ' 
        lblReviewTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblReviewTitle.Font = New Font("Segoe UI", 9.5F)
        lblReviewTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReviewTitle.Location = New Point(18, 14)
        lblReviewTitle.Name = "lblReviewTitle"
        lblReviewTitle.Size = New Size(338, 23)
        lblReviewTitle.TabIndex = 0
        lblReviewTitle.Text = "Awaiting Department Head review"
        ' 
        ' lblReviewCount
        ' 
        lblReviewCount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblReviewCount.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblReviewCount.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblReviewCount.Location = New Point(18, 38)
        lblReviewCount.Name = "lblReviewCount"
        lblReviewCount.Size = New Size(338, 42)
        lblReviewCount.TabIndex = 1
        lblReviewCount.Text = "0"
        ' 
        ' lblReviewDetail
        ' 
        lblReviewDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblReviewDetail.Font = New Font("Segoe UI", 8.5F)
        lblReviewDetail.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReviewDetail.Location = New Point(18, 83)
        lblReviewDetail.Name = "lblReviewDetail"
        lblReviewDetail.Size = New Size(338, 23)
        lblReviewDetail.TabIndex = 2
        lblReviewDetail.Text = "No report generated"
        ' 
        ' pnlFilters
        ' 
        pnlFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilters.BackColor = Color.White
        pnlFilters.BorderStyle = BorderStyle.FixedSingle
        pnlFilters.Controls.Add(tlpFilterInputs)
        pnlFilters.Controls.Add(btnGenerate)
        pnlFilters.Controls.Add(btnExportCsv)
        pnlFilters.Controls.Add(btnExportPdf)
        pnlFilters.Controls.Add(btnPrint)
        pnlFilters.Controls.Add(lblLoading)
        pnlFilters.Location = New Point(28, 108)
        pnlFilters.Name = "pnlFilters"
        pnlFilters.Size = New Size(1187, 148)
        pnlFilters.TabIndex = 3
        ' 
        ' tlpFilterInputs
        ' 
        tlpFilterInputs.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tlpFilterInputs.ColumnCount = 5
        tlpFilterInputs.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpFilterInputs.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpFilterInputs.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpFilterInputs.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpFilterInputs.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpFilterInputs.Controls.Add(lblTerm, 0, 0)
        tlpFilterInputs.Controls.Add(lblOffice, 1, 0)
        tlpFilterInputs.Controls.Add(lblCourse, 2, 0)
        tlpFilterInputs.Controls.Add(lblYear, 3, 0)
        tlpFilterInputs.Controls.Add(lblStatus, 4, 0)
        tlpFilterInputs.Controls.Add(cmbTerm, 0, 1)
        tlpFilterInputs.Controls.Add(cmbOffice, 1, 1)
        tlpFilterInputs.Controls.Add(cmbCourse, 2, 1)
        tlpFilterInputs.Controls.Add(cmbYear, 3, 1)
        tlpFilterInputs.Controls.Add(cmbStatus, 4, 1)
        tlpFilterInputs.Location = New Point(18, 14)
        tlpFilterInputs.Name = "tlpFilterInputs"
        tlpFilterInputs.RowCount = 2
        tlpFilterInputs.RowStyles.Add(New RowStyle(SizeType.Absolute, 26.0F))
        tlpFilterInputs.RowStyles.Add(New RowStyle(SizeType.Absolute, 36.0F))
        tlpFilterInputs.Size = New Size(1149, 64)
        tlpFilterInputs.TabIndex = 0
        ' 
        ' lblTerm
        ' 
        lblTerm.Dock = DockStyle.Fill
        lblTerm.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblTerm.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblTerm.Location = New Point(0, 0)
        lblTerm.Margin = New Padding(0, 0, 10, 0)
        lblTerm.Name = "lblTerm"
        lblTerm.Size = New Size(219, 26)
        lblTerm.TabIndex = 0
        lblTerm.Text = "Academic term"
        ' 
        ' lblOffice
        ' 
        lblOffice.Dock = DockStyle.Fill
        lblOffice.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblOffice.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOffice.Location = New Point(229, 0)
        lblOffice.Margin = New Padding(0, 0, 10, 0)
        lblOffice.Name = "lblOffice"
        lblOffice.Size = New Size(219, 26)
        lblOffice.TabIndex = 1
        lblOffice.Text = "Office"
        ' 
        ' lblCourse
        ' 
        lblCourse.Dock = DockStyle.Fill
        lblCourse.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCourse.Location = New Point(458, 0)
        lblCourse.Margin = New Padding(0, 0, 10, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(219, 26)
        lblCourse.TabIndex = 2
        lblCourse.Text = "Course"
        ' 
        ' lblYear
        ' 
        lblYear.Dock = DockStyle.Fill
        lblYear.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblYear.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblYear.Location = New Point(687, 0)
        lblYear.Margin = New Padding(0, 0, 10, 0)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(219, 26)
        lblYear.TabIndex = 3
        lblYear.Text = "Year level"
        ' 
        ' lblStatus
        ' 
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStatus.Location = New Point(916, 0)
        lblStatus.Margin = New Padding(0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(233, 26)
        lblStatus.TabIndex = 4
        lblStatus.Text = "Status"
        ' 
        ' cmbTerm
        ' 
        cmbTerm.Dock = DockStyle.Fill
        cmbTerm.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTerm.Location = New Point(0, 26)
        cmbTerm.Margin = New Padding(0, 0, 10, 0)
        cmbTerm.Name = "cmbTerm"
        cmbTerm.Size = New Size(219, 25)
        cmbTerm.TabIndex = 5
        ' 
        ' cmbOffice
        ' 
        cmbOffice.Dock = DockStyle.Fill
        cmbOffice.DropDownStyle = ComboBoxStyle.DropDownList
        cmbOffice.Location = New Point(229, 26)
        cmbOffice.Margin = New Padding(0, 0, 10, 0)
        cmbOffice.Name = "cmbOffice"
        cmbOffice.Size = New Size(219, 25)
        cmbOffice.TabIndex = 6
        ' 
        ' cmbCourse
        ' 
        cmbCourse.Dock = DockStyle.Fill
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.Location = New Point(458, 26)
        cmbCourse.Margin = New Padding(0, 0, 10, 0)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(219, 25)
        cmbCourse.TabIndex = 7
        ' 
        ' cmbYear
        ' 
        cmbYear.Dock = DockStyle.Fill
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.Location = New Point(687, 26)
        cmbYear.Margin = New Padding(0, 0, 10, 0)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(219, 25)
        cmbYear.TabIndex = 8
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Dock = DockStyle.Fill
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Location = New Point(916, 26)
        cmbStatus.Margin = New Padding(0)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(233, 25)
        cmbStatus.TabIndex = 9
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        btnGenerate.Cursor = Cursors.Hand
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(18, 90)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(150, 38)
        btnGenerate.TabIndex = 1
        btnGenerate.Text = "Generate report"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' btnExportCsv
        ' 
        btnExportCsv.BackColor = Color.White
        btnExportCsv.Cursor = Cursors.Hand
        btnExportCsv.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnExportCsv.FlatStyle = FlatStyle.Flat
        btnExportCsv.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnExportCsv.Location = New Point(176, 90)
        btnExportCsv.Name = "btnExportCsv"
        btnExportCsv.Size = New Size(120, 38)
        btnExportCsv.TabIndex = 2
        btnExportCsv.Text = "Export CSV"
        btnExportCsv.UseVisualStyleBackColor = False
        ' 
        ' btnExportPdf
        ' 
        btnExportPdf.BackColor = Color.White
        btnExportPdf.Cursor = Cursors.Hand
        btnExportPdf.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnExportPdf.FlatStyle = FlatStyle.Flat
        btnExportPdf.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnExportPdf.Location = New Point(304, 90)
        btnExportPdf.Name = "btnExportPdf"
        btnExportPdf.Size = New Size(120, 38)
        btnExportPdf.TabIndex = 3
        btnExportPdf.Text = "Export PDF"
        btnExportPdf.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.White
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnPrint.Location = New Point(432, 90)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(96, 38)
        btnPrint.TabIndex = 4
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblLoading
        ' 
        lblLoading.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblLoading.Font = New Font("Segoe UI", 9.0F)
        lblLoading.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblLoading.Location = New Point(544, 96)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(623, 28)
        lblLoading.TabIndex = 5
        lblLoading.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblActiveTerm
        ' 
        lblActiveTerm.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblActiveTerm.BackColor = Color.White
        lblActiveTerm.BorderStyle = BorderStyle.FixedSingle
        lblActiveTerm.Font = New Font("Segoe UI", 9.5F)
        lblActiveTerm.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblActiveTerm.Location = New Point(870, 24)
        lblActiveTerm.Name = "lblActiveTerm"
        lblActiveTerm.Size = New Size(345, 42)
        lblActiveTerm.TabIndex = 4
        lblActiveTerm.Text = "Loading active term..."
        lblActiveTerm.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSubtitle.Location = New Point(28, 65)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(783, 25)
        lblSubtitle.TabIndex = 5
        lblSubtitle.Text = "Monitor clearance progress per office and export records for the selected term."
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblTitle.Location = New Point(28, 22)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(500, 40)
        lblTitle.TabIndex = 6
        lblTitle.Text = "Reports"
        ' 
        ' ReportsForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1480, 900)
        Controls.Add(pnlViewport)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.5F)
        MinimumSize = New Size(1100, 650)
        Name = "ReportsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Reports"
        pnlSidebar.ResumeLayout(False)
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlViewport.ResumeLayout(False)
        pnlCanvas.ResumeLayout(False)
        tlpBottom.ResumeLayout(False)
        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlPresets.ResumeLayout(False)
        tlpCharts.ResumeLayout(False)
        pnlOfficeChart.ResumeLayout(False)
        pnlOverallChart.ResumeLayout(False)
        tlpSummaryCards.ResumeLayout(False)
        pnlCleared.ResumeLayout(False)
        pnlProgress.ResumeLayout(False)
        pnlAttention.ResumeLayout(False)
        pnlReview.ResumeLayout(False)
        pnlFilters.ResumeLayout(False)
        tlpFilterInputs.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picSchoolLogo As PictureBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavStudents As Button
    Friend WithEvents btnNavStaff As Button
    Friend WithEvents btnNavReports As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavStartTerm As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlViewport As Panel
    Friend WithEvents pnlCanvas As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblActiveTerm As Label
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents tlpFilterInputs As TableLayoutPanel
    Friend WithEvents lblTerm As Label
    Friend WithEvents cmbTerm As ComboBox
    Friend WithEvents lblOffice As Label
    Friend WithEvents cmbOffice As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnExportCsv As Button
    Friend WithEvents btnExportPdf As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblLoading As Label
    Friend WithEvents tlpSummaryCards As TableLayoutPanel
    Friend WithEvents pnlCleared As Panel
    Friend WithEvents lblClearedTitle As Label
    Friend WithEvents lblClearedCount As Label
    Friend WithEvents lblClearedDetail As Label
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents lblProgressTitle As Label
    Friend WithEvents lblProgressCount As Label
    Friend WithEvents lblProgressDetail As Label
    Friend WithEvents pnlAttention As Panel
    Friend WithEvents lblAttentionTitle As Label
    Friend WithEvents lblAttentionCount As Label
    Friend WithEvents lblAttentionDetail As Label
    Friend WithEvents pnlReview As Panel
    Friend WithEvents lblReviewTitle As Label
    Friend WithEvents lblReviewCount As Label
    Friend WithEvents lblReviewDetail As Label
    Friend WithEvents tlpCharts As TableLayoutPanel
    Friend WithEvents pnlOfficeChart As Panel
    Friend WithEvents lblOfficeChartTitle As Label
    Friend WithEvents lblOfficeChartSub As Label
    Friend WithEvents chartOffices As ReportsChartPanel
    Friend WithEvents pnlOverallChart As Panel
    Friend WithEvents lblOverallTitle As Label
    Friend WithEvents lblOverallSub As Label
    Friend WithEvents chartOverall As ReportsChartPanel
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents pnlStudents As Panel
    Friend WithEvents lblStudentsTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents colNumber As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colCourseYear As DataGridViewTextBoxColumn
    Friend WithEvents colProgress As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colWaiting As DataGridViewTextBoxColumn
    Friend WithEvents colActivity As DataGridViewTextBoxColumn
    Friend WithEvents lblPage As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents pnlPresets As Panel
    Friend WithEvents lblPresetsTitle As Label
    Friend WithEvents btnPresetAll As Button
    Friend WithEvents btnPresetCleared As Button
    Friend WithEvents btnPresetAttention As Button
    Friend WithEvents btnPresetOffice As Button
    Friend WithEvents btnPresetWaiting As Button
    Friend WithEvents lblPresetsNote As Label
End Class
