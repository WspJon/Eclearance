<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffRequestsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Dim dataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        btnNavLogout = New Button()
        btnNavHistory = New Button()
        btnNavRequests = New Button()
        btnNavDashboard = New Button()
        lblNavSection = New Label()
        pnlLogo = New Panel()
        lblLogoSub = New Label()
        lblLogoTitle = New Label()
        lblLogoIcon = New Label()
        pnlMain = New Panel()
        pnlTableCard = New Panel()
        dgvRequests = New DataGridView()
        colReqNum = New DataGridViewTextBoxColumn()
        colReqRecordID = New DataGridViewTextBoxColumn()
        colReqStudentNo = New DataGridViewTextBoxColumn()
        colReqStudentName = New DataGridViewTextBoxColumn()
        colReqRequirement = New DataGridViewTextBoxColumn()
        colReqSubmittedAt = New DataGridViewTextBoxColumn()
        colReqStatus = New DataGridViewTextBoxColumn()
        colReqAction = New DataGridViewButtonColumn()
        lblRecordCount = New Label()
        lblTableTitle = New Label()
        lblTableIcon = New Label()
        pnlFilterBar = New Panel()
        btnRefresh = New Button()
        btnFilterRejected = New Button()
        btnFilterCleared = New Button()
        btnFilterReview = New Button()
        btnFilterPending = New Button()
        btnFilterAll = New Button()
        txtSearch = New TextBox()
        lblSearchIcon = New Label()
        pnlSummaryPending = New Panel()
        lblPendingArrow = New Label()
        lblPendingSub = New Label()
        lblPendingTitle = New Label()
        lblPendingCount = New Label()
        lblPendingIcon = New Label()
        pnlSummaryTotal = New Panel()
        lblTotalArrow = New Label()
        lblTotalSub = New Label()
        lblTotalTitle = New Label()
        lblTotalCount = New Label()
        lblTotalIcon = New Label()
        lblDateTimeBadge = New Label()
        pnlStaffBadge = New Panel()
        lblStaffRole = New Label()
        lblStaffName = New Label()
        lblStaffIcon = New Label()
        pnlOfficeBadge = New Panel()
        lblOfficeSub = New Label()
        lblOfficeName = New Label()
        lblOfficeIcon = New Label()
        lblHeaderSub = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlTableCard.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilterBar.SuspendLayout()
        pnlSummaryPending.SuspendLayout()
        pnlSummaryTotal.SuspendLayout()
        pnlStaffBadge.SuspendLayout()
        pnlOfficeBadge.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(15, 39, 74)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavRequests)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavLogout.Location = New Point(16, 735)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Size = New Size(188, 44)
        btnNavLogout.TabIndex = 5
        btnNavLogout.Text = "  🚪   Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.Cursor = Cursors.Hand
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavHistory.Location = New Point(16, 224)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Size = New Size(188, 44)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "  🕒   History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = True
        ' 
        ' btnNavRequests
        ' 
        btnNavRequests.BackColor = Color.FromArgb(28, 91, 184)
        btnNavRequests.Cursor = Cursors.Hand
        btnNavRequests.FlatAppearance.BorderSize = 0
        btnNavRequests.FlatStyle = FlatStyle.Flat
        btnNavRequests.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavRequests.ForeColor = Color.White
        btnNavRequests.Location = New Point(16, 172)
        btnNavRequests.Name = "btnNavRequests"
        btnNavRequests.Size = New Size(188, 44)
        btnNavRequests.TabIndex = 3
        btnNavRequests.Text = "  📄   Requests"
        btnNavRequests.TextAlign = ContentAlignment.MiddleLeft
        btnNavRequests.UseVisualStyleBackColor = False
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 9.5F)
        btnNavDashboard.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavDashboard.Location = New Point(16, 120)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(188, 44)
        btnNavDashboard.TabIndex = 2
        btnNavDashboard.Text = "  ⌂   Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = True
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblNavSection.ForeColor = Color.FromArgb(100, 130, 170)
        lblNavSection.Location = New Point(16, 95)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(79, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "STAFF PORTAL"
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoSub)
        pnlLogo.Controls.Add(lblLogoTitle)
        pnlLogo.Controls.Add(lblLogoIcon)
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 75)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoSub
        ' 
        lblLogoSub.AutoSize = True
        lblLogoSub.Font = New Font("Segoe UI", 7.5F)
        lblLogoSub.ForeColor = Color.FromArgb(140, 168, 205)
        lblLogoSub.Location = New Point(50, 38)
        lblLogoSub.Name = "lblLogoSub"
        lblLogoSub.Size = New Size(123, 12)
        lblLogoSub.TabIndex = 2
        lblLogoSub.Text = "Student Clearance System"
        ' 
        ' lblLogoTitle
        ' 
        lblLogoTitle.AutoSize = True
        lblLogoTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLogoTitle.ForeColor = Color.White
        lblLogoTitle.Location = New Point(48, 16)
        lblLogoTitle.Name = "lblLogoTitle"
        lblLogoTitle.Size = New Size(134, 21)
        lblLogoTitle.TabIndex = 1
        lblLogoTitle.Text = "School Clearance"
        ' 
        ' lblLogoIcon
        ' 
        lblLogoIcon.AutoSize = True
        lblLogoIcon.Font = New Font("Segoe UI Emoji", 18F)
        lblLogoIcon.ForeColor = Color.White
        lblLogoIcon.Location = New Point(12, 16)
        lblLogoIcon.Name = "lblLogoIcon"
        lblLogoIcon.Size = New Size(39, 32)
        lblLogoIcon.TabIndex = 0
        lblLogoIcon.Text = "🎓"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(244, 247, 251)
        pnlMain.Controls.Add(pnlTableCard)
        pnlMain.Controls.Add(pnlFilterBar)
        pnlMain.Controls.Add(pnlSummaryPending)
        pnlMain.Controls.Add(pnlSummaryTotal)
        pnlMain.Controls.Add(lblDateTimeBadge)
        pnlMain.Controls.Add(pnlStaffBadge)
        pnlMain.Controls.Add(pnlOfficeBadge)
        pnlMain.Controls.Add(lblHeaderSub)
        pnlMain.Controls.Add(lblHeaderTitle)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' pnlTableCard
        ' 
        pnlTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTableCard.BackColor = Color.White
        pnlTableCard.BorderStyle = BorderStyle.FixedSingle
        pnlTableCard.Controls.Add(dgvRequests)
        pnlTableCard.Controls.Add(lblRecordCount)
        pnlTableCard.Controls.Add(lblTableTitle)
        pnlTableCard.Controls.Add(lblTableIcon)
        pnlTableCard.Location = New Point(28, 260)
        pnlTableCard.Name = "pnlTableCard"
        pnlTableCard.Padding = New Padding(16)
        pnlTableCard.Size = New Size(924, 504)
        pnlTableCard.TabIndex = 8
        ' 
        ' dgvRequests
        ' 
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.AllowUserToDeleteRows = False
        dgvRequests.AllowUserToResizeRows = False
        dgvRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRequests.BackgroundColor = Color.White
        dgvRequests.BorderStyle = BorderStyle.None
        dgvRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(100, 116, 139)
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 116, 139)
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvRequests.ColumnHeadersHeight = 36
        dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRequests.Columns.AddRange(New DataGridViewColumn() {colReqNum, colReqRecordID, colReqStudentNo, colReqStudentName, colReqRequirement, colReqSubmittedAt, colReqStatus, colReqAction})
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = Color.White
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 8.5F)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRequests.DefaultCellStyle = dataGridViewCellStyle2
        dgvRequests.EnableHeadersVisualStyles = False
        dgvRequests.GridColor = Color.FromArgb(241, 245, 249)
        dgvRequests.Location = New Point(16, 52)
        dgvRequests.MultiSelect = False
        dgvRequests.Name = "dgvRequests"
        dgvRequests.ReadOnly = True
        dgvRequests.RowHeadersVisible = False
        dgvRequests.RowTemplate.Height = 40
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.Size = New Size(890, 434)
        dgvRequests.TabIndex = 3
        ' 
        ' colReqNum
        ' 
        colReqNum.HeaderText = "#"
        colReqNum.Name = "colReqNum"
        colReqNum.ReadOnly = True
        colReqNum.Width = 40
        ' 
        ' colReqRecordID
        ' 
        colReqRecordID.HeaderText = "RecordID"
        colReqRecordID.Name = "colReqRecordID"
        colReqRecordID.ReadOnly = True
        colReqRecordID.Visible = False
        ' 
        ' colReqStudentNo
        ' 
        colReqStudentNo.HeaderText = "Student No."
        colReqStudentNo.Name = "colReqStudentNo"
        colReqStudentNo.ReadOnly = True
        colReqStudentNo.Width = 110
        ' 
        ' colReqStudentName
        ' 
        colReqStudentName.HeaderText = "Student Name"
        colReqStudentName.Name = "colReqStudentName"
        colReqStudentName.ReadOnly = True
        colReqStudentName.Width = 180
        ' 
        ' colReqRequirement
        ' 
        colReqRequirement.HeaderText = "Requirement"
        colReqRequirement.Name = "colReqRequirement"
        colReqRequirement.ReadOnly = True
        colReqRequirement.Width = 160
        ' 
        ' colReqSubmittedAt
        ' 
        colReqSubmittedAt.HeaderText = "Submitted At"
        colReqSubmittedAt.Name = "colReqSubmittedAt"
        colReqSubmittedAt.ReadOnly = True
        colReqSubmittedAt.Width = 150
        ' 
        ' colReqStatus
        ' 
        colReqStatus.HeaderText = "Status"
        colReqStatus.Name = "colReqStatus"
        colReqStatus.ReadOnly = True
        colReqStatus.Width = 110
        ' 
        ' colReqAction
        ' 
        colReqAction.FlatStyle = FlatStyle.Flat
        colReqAction.HeaderText = "Action"
        colReqAction.Name = "colReqAction"
        colReqAction.ReadOnly = True
        colReqAction.Text = "Review"
        colReqAction.UseColumnTextForButtonValue = True
        colReqAction.Width = 100
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 8.5F)
        lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139)
        lblRecordCount.Location = New Point(770, 18)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(130, 15)
        lblRecordCount.TabIndex = 2
        lblRecordCount.Text = "Showing 0 of 0 records"
        ' 
        ' lblTableTitle
        ' 
        lblTableTitle.AutoSize = True
        lblTableTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTableTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblTableTitle.Location = New Point(42, 16)
        lblTableTitle.Name = "lblTableTitle"
        lblTableTitle.Size = New Size(205, 20)
        lblTableTitle.TabIndex = 1
        lblTableTitle.Text = "Student Clearance Requests"
        ' 
        ' lblTableIcon
        ' 
        lblTableIcon.AutoSize = True
        lblTableIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblTableIcon.ForeColor = Color.FromArgb(11, 99, 229)
        lblTableIcon.Location = New Point(16, 16)
        lblTableIcon.Name = "lblTableIcon"
        lblTableIcon.Size = New Size(24, 21)
        lblTableIcon.TabIndex = 0
        lblTableIcon.Text = "📄"
        ' 
        ' pnlFilterBar
        ' 
        pnlFilterBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilterBar.BackColor = Color.White
        pnlFilterBar.BorderStyle = BorderStyle.FixedSingle
        pnlFilterBar.Controls.Add(btnRefresh)
        pnlFilterBar.Controls.Add(btnFilterRejected)
        pnlFilterBar.Controls.Add(btnFilterCleared)
        pnlFilterBar.Controls.Add(btnFilterReview)
        pnlFilterBar.Controls.Add(btnFilterPending)
        pnlFilterBar.Controls.Add(btnFilterAll)
        pnlFilterBar.Controls.Add(txtSearch)
        pnlFilterBar.Controls.Add(lblSearchIcon)
        pnlFilterBar.Location = New Point(28, 194)
        pnlFilterBar.Name = "pnlFilterBar"
        pnlFilterBar.Size = New Size(924, 52)
        pnlFilterBar.TabIndex = 7
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(11, 99, 229)
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(818, 9)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(92, 32)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnFilterRejected
        ' 
        btnFilterRejected.BackColor = Color.FromArgb(254, 226, 226)
        btnFilterRejected.Cursor = Cursors.Hand
        btnFilterRejected.FlatAppearance.BorderColor = Color.FromArgb(252, 165, 165)
        btnFilterRejected.FlatStyle = FlatStyle.Flat
        btnFilterRejected.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnFilterRejected.ForeColor = Color.FromArgb(220, 38, 38)
        btnFilterRejected.Location = New Point(696, 10)
        btnFilterRejected.Name = "btnFilterRejected"
        btnFilterRejected.Size = New Size(88, 30)
        btnFilterRejected.TabIndex = 6
        btnFilterRejected.Text = "✕ Rejected"
        btnFilterRejected.UseVisualStyleBackColor = False
        ' 
        ' btnFilterCleared
        ' 
        btnFilterCleared.BackColor = Color.FromArgb(220, 252, 231)
        btnFilterCleared.Cursor = Cursors.Hand
        btnFilterCleared.FlatAppearance.BorderColor = Color.FromArgb(134, 239, 172)
        btnFilterCleared.FlatStyle = FlatStyle.Flat
        btnFilterCleared.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnFilterCleared.ForeColor = Color.FromArgb(22, 163, 74)
        btnFilterCleared.Location = New Point(594, 10)
        btnFilterCleared.Name = "btnFilterCleared"
        btnFilterCleared.Size = New Size(96, 30)
        btnFilterCleared.TabIndex = 5
        btnFilterCleared.Text = "✓ Approved"
        btnFilterCleared.UseVisualStyleBackColor = False
        ' 
        ' btnFilterReview
        ' 
        btnFilterReview.BackColor = Color.FromArgb(219, 234, 254)
        btnFilterReview.Cursor = Cursors.Hand
        btnFilterReview.FlatAppearance.BorderColor = Color.FromArgb(147, 197, 253)
        btnFilterReview.FlatStyle = FlatStyle.Flat
        btnFilterReview.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnFilterReview.ForeColor = Color.FromArgb(37, 99, 235)
        btnFilterReview.Location = New Point(478, 10)
        btnFilterReview.Name = "btnFilterReview"
        btnFilterReview.Size = New Size(110, 30)
        btnFilterReview.TabIndex = 4
        btnFilterReview.Text = "⏳ Under Review"
        btnFilterReview.UseVisualStyleBackColor = False
        ' 
        ' btnFilterPending
        ' 
        btnFilterPending.BackColor = Color.FromArgb(254, 243, 199)
        btnFilterPending.Cursor = Cursors.Hand
        btnFilterPending.FlatAppearance.BorderColor = Color.FromArgb(253, 230, 138)
        btnFilterPending.FlatStyle = FlatStyle.Flat
        btnFilterPending.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnFilterPending.ForeColor = Color.FromArgb(217, 119, 6)
        btnFilterPending.Location = New Point(386, 10)
        btnFilterPending.Name = "btnFilterPending"
        btnFilterPending.Size = New Size(86, 30)
        btnFilterPending.TabIndex = 3
        btnFilterPending.Text = "⏱ Pending"
        btnFilterPending.UseVisualStyleBackColor = False
        ' 
        ' btnFilterAll
        ' 
        btnFilterAll.BackColor = Color.FromArgb(11, 99, 229)
        btnFilterAll.Cursor = Cursors.Hand
        btnFilterAll.FlatAppearance.BorderSize = 0
        btnFilterAll.FlatStyle = FlatStyle.Flat
        btnFilterAll.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnFilterAll.ForeColor = Color.White
        btnFilterAll.Location = New Point(328, 10)
        btnFilterAll.Name = "btnFilterAll"
        btnFilterAll.Size = New Size(52, 30)
        btnFilterAll.TabIndex = 2
        btnFilterAll.Text = "All"
        btnFilterAll.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9F)
        txtSearch.ForeColor = Color.FromArgb(30, 41, 59)
        txtSearch.Location = New Point(38, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by student name or student number..."
        txtSearch.Size = New Size(280, 23)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearchIcon
        ' 
        lblSearchIcon.AutoSize = True
        lblSearchIcon.Font = New Font("Segoe UI Emoji", 10F)
        lblSearchIcon.ForeColor = Color.FromArgb(100, 116, 139)
        lblSearchIcon.Location = New Point(12, 16)
        lblSearchIcon.Name = "lblSearchIcon"
        lblSearchIcon.Size = New Size(21, 19)
        lblSearchIcon.TabIndex = 0
        lblSearchIcon.Text = "🔍"
        ' 
        ' pnlSummaryPending
        ' 
        pnlSummaryPending.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlSummaryPending.BackColor = Color.White
        pnlSummaryPending.BorderStyle = BorderStyle.FixedSingle
        pnlSummaryPending.Controls.Add(lblPendingArrow)
        pnlSummaryPending.Controls.Add(lblPendingSub)
        pnlSummaryPending.Controls.Add(lblPendingTitle)
        pnlSummaryPending.Controls.Add(lblPendingCount)
        pnlSummaryPending.Controls.Add(lblPendingIcon)
        pnlSummaryPending.Location = New Point(500, 92)
        pnlSummaryPending.Name = "pnlSummaryPending"
        pnlSummaryPending.Size = New Size(452, 86)
        pnlSummaryPending.TabIndex = 6
        ' 
        ' lblPendingArrow
        ' 
        lblPendingArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPendingArrow.AutoSize = True
        lblPendingArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPendingArrow.ForeColor = Color.FromArgb(37, 99, 235)
        lblPendingArrow.Location = New Point(420, 32)
        lblPendingArrow.Name = "lblPendingArrow"
        lblPendingArrow.Size = New Size(19, 21)
        lblPendingArrow.TabIndex = 4
        lblPendingArrow.Text = ">"
        ' 
        ' lblPendingSub
        ' 
        lblPendingSub.AutoSize = True
        lblPendingSub.Font = New Font("Segoe UI", 8F)
        lblPendingSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblPendingSub.Location = New Point(68, 56)
        lblPendingSub.Name = "lblPendingSub"
        lblPendingSub.Size = New Size(137, 13)
        lblPendingSub.TabIndex = 3
        lblPendingSub.Text = "Awaiting your evaluation"
        ' 
        ' lblPendingTitle
        ' 
        lblPendingTitle.AutoSize = True
        lblPendingTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblPendingTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblPendingTitle.Location = New Point(68, 38)
        lblPendingTitle.Name = "lblPendingTitle"
        lblPendingTitle.Size = New Size(89, 15)
        lblPendingTitle.TabIndex = 2
        lblPendingTitle.Text = "Pending Review"
        ' 
        ' lblPendingCount
        ' 
        lblPendingCount.AutoSize = True
        lblPendingCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblPendingCount.ForeColor = Color.FromArgb(15, 23, 42)
        lblPendingCount.Location = New Point(68, 8)
        lblPendingCount.Name = "lblPendingCount"
        lblPendingCount.Size = New Size(26, 30)
        lblPendingCount.TabIndex = 1
        lblPendingCount.Text = "0"
        ' 
        ' lblPendingIcon
        ' 
        lblPendingIcon.BackColor = Color.FromArgb(219, 234, 254)
        lblPendingIcon.Font = New Font("Segoe UI", 14F)
        lblPendingIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblPendingIcon.Location = New Point(16, 16)
        lblPendingIcon.Name = "lblPendingIcon"
        lblPendingIcon.Size = New Size(42, 42)
        lblPendingIcon.TabIndex = 0
        lblPendingIcon.Text = "⏳"
        lblPendingIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSummaryTotal
        ' 
        pnlSummaryTotal.BackColor = Color.White
        pnlSummaryTotal.BorderStyle = BorderStyle.FixedSingle
        pnlSummaryTotal.Controls.Add(lblTotalArrow)
        pnlSummaryTotal.Controls.Add(lblTotalSub)
        pnlSummaryTotal.Controls.Add(lblTotalTitle)
        pnlSummaryTotal.Controls.Add(lblTotalCount)
        pnlSummaryTotal.Controls.Add(lblTotalIcon)
        pnlSummaryTotal.Location = New Point(28, 92)
        pnlSummaryTotal.Name = "pnlSummaryTotal"
        pnlSummaryTotal.Size = New Size(452, 86)
        pnlSummaryTotal.TabIndex = 5
        ' 
        ' lblTotalArrow
        ' 
        lblTotalArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalArrow.AutoSize = True
        lblTotalArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalArrow.ForeColor = Color.FromArgb(217, 119, 6)
        lblTotalArrow.Location = New Point(420, 32)
        lblTotalArrow.Name = "lblTotalArrow"
        lblTotalArrow.Size = New Size(19, 21)
        lblTotalArrow.TabIndex = 4
        lblTotalArrow.Text = ">"
        ' 
        ' lblTotalSub
        ' 
        lblTotalSub.AutoSize = True
        lblTotalSub.Font = New Font("Segoe UI", 8F)
        lblTotalSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblTotalSub.Location = New Point(68, 56)
        lblTotalSub.Name = "lblTotalSub"
        lblTotalSub.Size = New Size(160, 13)
        lblTotalSub.TabIndex = 3
        lblTotalSub.Text = "All submissions for your office"
        ' 
        ' lblTotalTitle
        ' 
        lblTotalTitle.AutoSize = True
        lblTotalTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblTotalTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblTotalTitle.Location = New Point(68, 38)
        lblTotalTitle.Name = "lblTotalTitle"
        lblTotalTitle.Size = New Size(83, 15)
        lblTotalTitle.TabIndex = 2
        lblTotalTitle.Text = "Total Requests"
        ' 
        ' lblTotalCount
        ' 
        lblTotalCount.AutoSize = True
        lblTotalCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalCount.ForeColor = Color.FromArgb(15, 23, 42)
        lblTotalCount.Location = New Point(68, 8)
        lblTotalCount.Name = "lblTotalCount"
        lblTotalCount.Size = New Size(26, 30)
        lblTotalCount.TabIndex = 1
        lblTotalCount.Text = "0"
        ' 
        ' lblTotalIcon
        ' 
        lblTotalIcon.BackColor = Color.FromArgb(254, 243, 199)
        lblTotalIcon.Font = New Font("Segoe UI", 14F)
        lblTotalIcon.ForeColor = Color.FromArgb(217, 119, 6)
        lblTotalIcon.Location = New Point(16, 16)
        lblTotalIcon.Name = "lblTotalIcon"
        lblTotalIcon.Size = New Size(42, 42)
        lblTotalIcon.TabIndex = 0
        lblTotalIcon.Text = "📄"
        lblTotalIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTimeBadge.Font = New Font("Segoe UI", 8F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(100, 116, 139)
        lblDateTimeBadge.Location = New Point(854, 16)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(98, 48)
        lblDateTimeBadge.TabIndex = 4
        lblDateTimeBadge.Text = "📅 Today"
        lblDateTimeBadge.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlStaffBadge
        ' 
        pnlStaffBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlStaffBadge.BackColor = Color.White
        pnlStaffBadge.BorderStyle = BorderStyle.FixedSingle
        pnlStaffBadge.Controls.Add(lblStaffRole)
        pnlStaffBadge.Controls.Add(lblStaffName)
        pnlStaffBadge.Controls.Add(lblStaffIcon)
        pnlStaffBadge.Location = New Point(680, 16)
        pnlStaffBadge.Name = "pnlStaffBadge"
        pnlStaffBadge.Size = New Size(168, 48)
        pnlStaffBadge.TabIndex = 3
        ' 
        ' lblStaffRole
        ' 
        lblStaffRole.AutoSize = True
        lblStaffRole.Font = New Font("Segoe UI", 7.5F)
        lblStaffRole.ForeColor = Color.FromArgb(100, 116, 139)
        lblStaffRole.Location = New Point(38, 26)
        lblStaffRole.Name = "lblStaffRole"
        lblStaffRole.Size = New Size(106, 12)
        lblStaffRole.TabIndex = 2
        lblStaffRole.Text = "Staff / Clearing Officer"
        ' 
        ' lblStaffName
        ' 
        lblStaffName.AutoSize = True
        lblStaffName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblStaffName.ForeColor = Color.FromArgb(15, 23, 42)
        lblStaffName.Location = New Point(38, 8)
        lblStaffName.Name = "lblStaffName"
        lblStaffName.Size = New Size(79, 15)
        lblStaffName.TabIndex = 1
        lblStaffName.Text = "Staff Member"
        ' 
        ' lblStaffIcon
        ' 
        lblStaffIcon.AutoSize = True
        lblStaffIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblStaffIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblStaffIcon.Location = New Point(8, 10)
        lblStaffIcon.Name = "lblStaffIcon"
        lblStaffIcon.Size = New Size(28, 26)
        lblStaffIcon.TabIndex = 0
        lblStaffIcon.Text = "👤"
        ' 
        ' pnlOfficeBadge
        ' 
        pnlOfficeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlOfficeBadge.BackColor = Color.White
        pnlOfficeBadge.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeBadge.Controls.Add(lblOfficeSub)
        pnlOfficeBadge.Controls.Add(lblOfficeName)
        pnlOfficeBadge.Controls.Add(lblOfficeIcon)
        pnlOfficeBadge.Location = New Point(504, 16)
        pnlOfficeBadge.Name = "pnlOfficeBadge"
        pnlOfficeBadge.Size = New Size(168, 48)
        pnlOfficeBadge.TabIndex = 2
        ' 
        ' lblOfficeSub
        ' 
        lblOfficeSub.AutoSize = True
        lblOfficeSub.Font = New Font("Segoe UI", 7.5F)
        lblOfficeSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeSub.Location = New Point(38, 26)
        lblOfficeSub.Name = "lblOfficeSub"
        lblOfficeSub.Size = New Size(74, 12)
        lblOfficeSub.TabIndex = 2
        lblOfficeSub.Text = "Assigned Office"
        ' 
        ' lblOfficeName
        ' 
        lblOfficeName.AutoSize = True
        lblOfficeName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblOfficeName.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeName.Location = New Point(38, 8)
        lblOfficeName.Name = "lblOfficeName"
        lblOfficeName.Size = New Size(86, 15)
        lblOfficeName.TabIndex = 1
        lblOfficeName.Text = "Assigned Office"
        ' 
        ' lblOfficeIcon
        ' 
        lblOfficeIcon.AutoSize = True
        lblOfficeIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblOfficeIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblOfficeIcon.Location = New Point(8, 10)
        lblOfficeIcon.Name = "lblOfficeIcon"
        lblOfficeIcon.Size = New Size(28, 26)
        lblOfficeIcon.TabIndex = 0
        lblOfficeIcon.Text = "🏛"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 9.5F)
        lblHeaderSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblHeaderSub.Location = New Point(28, 56)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(301, 17)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "Review student submissions for your assigned office."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(24, 16)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(200, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Staff Requests"
        ' 
        ' StaffRequestsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "StaffRequestsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Staff Requests"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlTableCard.ResumeLayout(False)
        pnlTableCard.PerformLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlFilterBar.ResumeLayout(False)
        pnlFilterBar.PerformLayout()
        pnlSummaryPending.ResumeLayout(False)
        pnlSummaryPending.PerformLayout()
        pnlSummaryTotal.ResumeLayout(False)
        pnlSummaryTotal.PerformLayout()
        pnlStaffBadge.ResumeLayout(False)
        pnlStaffBadge.PerformLayout()
        pnlOfficeBadge.ResumeLayout(False)
        pnlOfficeBadge.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoIcon As Label
    Friend WithEvents lblLogoTitle As Label
    Friend WithEvents lblLogoSub As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavRequests As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlOfficeBadge As Panel
    Friend WithEvents lblOfficeIcon As Label
    Friend WithEvents lblOfficeName As Label
    Friend WithEvents lblOfficeSub As Label
    Friend WithEvents pnlStaffBadge As Panel
    Friend WithEvents lblStaffIcon As Label
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffRole As Label
    Friend WithEvents lblDateTimeBadge As Label
    Friend WithEvents pnlSummaryTotal As Panel
    Friend WithEvents lblTotalIcon As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotalSub As Label
    Friend WithEvents lblTotalArrow As Label
    Friend WithEvents pnlSummaryPending As Panel
    Friend WithEvents lblPendingIcon As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblPendingSub As Label
    Friend WithEvents lblPendingArrow As Label
    Friend WithEvents pnlFilterBar As Panel
    Friend WithEvents lblSearchIcon As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnFilterAll As Button
    Friend WithEvents btnFilterPending As Button
    Friend WithEvents btnFilterReview As Button
    Friend WithEvents btnFilterCleared As Button
    Friend WithEvents btnFilterRejected As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlTableCard As Panel
    Friend WithEvents lblTableIcon As Label
    Friend WithEvents lblTableTitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents colReqNum As DataGridViewTextBoxColumn
    Friend WithEvents colReqRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colReqStudentNo As DataGridViewTextBoxColumn
    Friend WithEvents colReqStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colReqRequirement As DataGridViewTextBoxColumn
    Friend WithEvents colReqSubmittedAt As DataGridViewTextBoxColumn
    Friend WithEvents colReqStatus As DataGridViewTextBoxColumn
    Friend WithEvents colReqAction As DataGridViewButtonColumn

End Class
