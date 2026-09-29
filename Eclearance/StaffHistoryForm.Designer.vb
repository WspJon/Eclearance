<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffHistoryForm
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
        Dim dataGridViewCellStyleStatus As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        pnlHistoryDetailCard = New Panel()
        btnReReview = New Button()
        lblDetailRemarksVal = New Label()
        lblDetailRemarksLabel = New Label()
        lblDetailStatusVal = New Label()
        lblDetailStatusLabel = New Label()
        lblDetailActionVal = New Label()
        lblDetailActionLabel = New Label()
        lblDetailDateVal = New Label()
        lblDetailDateLabel = New Label()
        lblDetailReqVal = New Label()
        lblDetailReqLabel = New Label()
        lblDetailYearVal = New Label()
        lblDetailYearLabel = New Label()
        lblDetailCourseVal = New Label()
        lblDetailCourseLabel = New Label()
        lblDetailNameVal = New Label()
        lblDetailNameLabel = New Label()
        lblDetailStudentNoVal = New Label()
        lblDetailStudentNoLabel = New Label()
        lblDetailTitle = New Label()
        lblDetailIcon = New Label()
        pnlHistoryTableCard = New Panel()
        dgvHistory = New DataGridView()
        colNum = New DataGridViewTextBoxColumn()
        colHistoryID = New DataGridViewTextBoxColumn()
        colRecordID = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colStudentNo = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colRequirement = New DataGridViewTextBoxColumn()
        colActionTaken = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colRemarks = New DataGridViewTextBoxColumn()
        lblRecordCount = New Label()
        lblTableTitle = New Label()
        lblTableIcon = New Label()
        pnlFilterBar = New Panel()
        btnRefresh = New Button()
        cmbStatusFilter = New ComboBox()
        cmbDateFilter = New ComboBox()
        txtSearch = New TextBox()
        lblSearchIcon = New Label()
        pnlSummaryCards = New Panel()
        pnlCardRejected = New Panel()
        lblRejectedArrow = New Label()
        lblRejectedSub = New Label()
        lblRejectedTitle = New Label()
        lblRejectedCount = New Label()
        lblRejectedIcon = New Label()
        pnlCardApproved = New Panel()
        lblApprovedArrow = New Label()
        lblApprovedSub = New Label()
        lblApprovedTitle = New Label()
        lblApprovedCount = New Label()
        lblApprovedIcon = New Label()
        pnlCardReviewed = New Panel()
        lblReviewedArrow = New Label()
        lblReviewedSub = New Label()
        lblReviewedTitle = New Label()
        lblReviewedCount = New Label()
        lblReviewedIcon = New Label()
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
        pnlHistoryDetailCard.SuspendLayout()
        pnlHistoryTableCard.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilterBar.SuspendLayout()
        pnlSummaryCards.SuspendLayout()
        pnlCardRejected.SuspendLayout()
        pnlCardApproved.SuspendLayout()
        pnlCardReviewed.SuspendLayout()
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
        btnNavHistory.BackColor = Color.FromArgb(28, 91, 184)
        btnNavHistory.Cursor = Cursors.Hand
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavHistory.ForeColor = Color.White
        btnNavHistory.Location = New Point(16, 224)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Size = New Size(188, 44)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "  🕒   History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavRequests
        ' 
        btnNavRequests.Cursor = Cursors.Hand
        btnNavRequests.FlatAppearance.BorderSize = 0
        btnNavRequests.FlatStyle = FlatStyle.Flat
        btnNavRequests.Font = New Font("Segoe UI", 9.5F)
        btnNavRequests.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavRequests.Location = New Point(16, 172)
        btnNavRequests.Name = "btnNavRequests"
        btnNavRequests.Size = New Size(188, 44)
        btnNavRequests.TabIndex = 3
        btnNavRequests.Text = "  📄   Requests"
        btnNavRequests.TextAlign = ContentAlignment.MiddleLeft
        btnNavRequests.UseVisualStyleBackColor = True
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
        pnlMain.Controls.Add(pnlHistoryDetailCard)
        pnlMain.Controls.Add(pnlHistoryTableCard)
        pnlMain.Controls.Add(pnlFilterBar)
        pnlMain.Controls.Add(pnlSummaryCards)
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
        ' pnlHistoryDetailCard
        ' 
        pnlHistoryDetailCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlHistoryDetailCard.BackColor = Color.White
        pnlHistoryDetailCard.BorderStyle = BorderStyle.FixedSingle
        pnlHistoryDetailCard.Controls.Add(btnReReview)
        pnlHistoryDetailCard.Controls.Add(lblDetailRemarksVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailRemarksLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailStatusVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailStatusLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailActionVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailActionLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailDateVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailDateLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailReqVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailReqLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailYearVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailYearLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailCourseVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailCourseLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailNameVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailNameLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailStudentNoVal)
        pnlHistoryDetailCard.Controls.Add(lblDetailStudentNoLabel)
        pnlHistoryDetailCard.Controls.Add(lblDetailTitle)
        pnlHistoryDetailCard.Controls.Add(lblDetailIcon)
        pnlHistoryDetailCard.Location = New Point(680, 260)
        pnlHistoryDetailCard.Name = "pnlHistoryDetailCard"
        pnlHistoryDetailCard.Padding = New Padding(16)
        pnlHistoryDetailCard.Size = New Size(272, 504)
        pnlHistoryDetailCard.TabIndex = 9
        ' 
        ' btnReReview
        ' 
        btnReReview.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnReReview.BackColor = Color.FromArgb(11, 99, 229)
        btnReReview.Cursor = Cursors.Hand
        btnReReview.Enabled = False
        btnReReview.FlatAppearance.BorderSize = 0
        btnReReview.FlatStyle = FlatStyle.Flat
        btnReReview.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnReReview.ForeColor = Color.White
        btnReReview.Location = New Point(16, 450)
        btnReReview.Name = "btnReReview"
        btnReReview.Size = New Size(238, 38)
        btnReReview.TabIndex = 20
        btnReReview.Text = "↗  Open Full Submission"
        btnReReview.UseVisualStyleBackColor = False
        ' 
        ' lblDetailRemarksVal
        ' 
        lblDetailRemarksVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetailRemarksVal.Font = New Font("Segoe UI", 8F)
        lblDetailRemarksVal.ForeColor = Color.FromArgb(51, 65, 85)
        lblDetailRemarksVal.Location = New Point(16, 334)
        lblDetailRemarksVal.Name = "lblDetailRemarksVal"
        lblDetailRemarksVal.Size = New Size(238, 100)
        lblDetailRemarksVal.TabIndex = 19
        lblDetailRemarksVal.Text = "Select a row from the history table to view details."
        ' 
        ' lblDetailRemarksLabel
        ' 
        lblDetailRemarksLabel.AutoSize = True
        lblDetailRemarksLabel.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblDetailRemarksLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailRemarksLabel.Location = New Point(16, 314)
        lblDetailRemarksLabel.Name = "lblDetailRemarksLabel"
        lblDetailRemarksLabel.Size = New Size(54, 13)
        lblDetailRemarksLabel.TabIndex = 18
        lblDetailRemarksLabel.Text = "Remarks :"
        ' 
        ' lblDetailStatusVal
        ' 
        lblDetailStatusVal.AutoSize = True
        lblDetailStatusVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailStatusVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailStatusVal.Location = New Point(110, 276)
        lblDetailStatusVal.Name = "lblDetailStatusVal"
        lblDetailStatusVal.Size = New Size(12, 15)
        lblDetailStatusVal.TabIndex = 17
        lblDetailStatusVal.Text = "-"
        ' 
        ' lblDetailStatusLabel
        ' 
        lblDetailStatusLabel.AutoSize = True
        lblDetailStatusLabel.Font = New Font("Segoe UI", 8F)
        lblDetailStatusLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailStatusLabel.Location = New Point(16, 276)
        lblDetailStatusLabel.Name = "lblDetailStatusLabel"
        lblDetailStatusLabel.Size = New Size(45, 13)
        lblDetailStatusLabel.TabIndex = 16
        lblDetailStatusLabel.Text = "Status :"
        ' 
        ' lblDetailActionVal
        ' 
        lblDetailActionVal.AutoSize = True
        lblDetailActionVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailActionVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailActionVal.Location = New Point(110, 246)
        lblDetailActionVal.Name = "lblDetailActionVal"
        lblDetailActionVal.Size = New Size(12, 15)
        lblDetailActionVal.TabIndex = 15
        lblDetailActionVal.Text = "-"
        ' 
        ' lblDetailActionLabel
        ' 
        lblDetailActionLabel.AutoSize = True
        lblDetailActionLabel.Font = New Font("Segoe UI", 8F)
        lblDetailActionLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailActionLabel.Location = New Point(16, 246)
        lblDetailActionLabel.Name = "lblDetailActionLabel"
        lblDetailActionLabel.Size = New Size(79, 13)
        lblDetailActionLabel.TabIndex = 14
        lblDetailActionLabel.Text = "Action Taken :"
        ' 
        ' lblDetailDateVal
        ' 
        lblDetailDateVal.AutoSize = True
        lblDetailDateVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailDateVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailDateVal.Location = New Point(110, 216)
        lblDetailDateVal.Name = "lblDetailDateVal"
        lblDetailDateVal.Size = New Size(12, 15)
        lblDetailDateVal.TabIndex = 13
        lblDetailDateVal.Text = "-"
        ' 
        ' lblDetailDateLabel
        ' 
        lblDetailDateLabel.AutoSize = True
        lblDetailDateLabel.Font = New Font("Segoe UI", 8F)
        lblDetailDateLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailDateLabel.Location = New Point(16, 216)
        lblDetailDateLabel.Name = "lblDetailDateLabel"
        lblDetailDateLabel.Size = New Size(91, 13)
        lblDetailDateLabel.TabIndex = 12
        lblDetailDateLabel.Text = "Date Actioned :"
        ' 
        ' lblDetailReqVal
        ' 
        lblDetailReqVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetailReqVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailReqVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailReqVal.Location = New Point(110, 178)
        lblDetailReqVal.Name = "lblDetailReqVal"
        lblDetailReqVal.Size = New Size(144, 30)
        lblDetailReqVal.TabIndex = 11
        lblDetailReqVal.Text = "-"
        ' 
        ' lblDetailReqLabel
        ' 
        lblDetailReqLabel.AutoSize = True
        lblDetailReqLabel.Font = New Font("Segoe UI", 8F)
        lblDetailReqLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailReqLabel.Location = New Point(16, 178)
        lblDetailReqLabel.Name = "lblDetailReqLabel"
        lblDetailReqLabel.Size = New Size(79, 13)
        lblDetailReqLabel.TabIndex = 10
        lblDetailReqLabel.Text = "Requirement :"
        ' 
        ' lblDetailYearVal
        ' 
        lblDetailYearVal.AutoSize = True
        lblDetailYearVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailYearVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailYearVal.Location = New Point(110, 148)
        lblDetailYearVal.Name = "lblDetailYearVal"
        lblDetailYearVal.Size = New Size(12, 15)
        lblDetailYearVal.TabIndex = 9
        lblDetailYearVal.Text = "-"
        ' 
        ' lblDetailYearLabel
        ' 
        lblDetailYearLabel.AutoSize = True
        lblDetailYearLabel.Font = New Font("Segoe UI", 8F)
        lblDetailYearLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailYearLabel.Location = New Point(16, 148)
        lblDetailYearLabel.Name = "lblDetailYearLabel"
        lblDetailYearLabel.Size = New Size(64, 13)
        lblDetailYearLabel.TabIndex = 8
        lblDetailYearLabel.Text = "Year Level :"
        ' 
        ' lblDetailCourseVal
        ' 
        lblDetailCourseVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetailCourseVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailCourseVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailCourseVal.Location = New Point(110, 110)
        lblDetailCourseVal.Name = "lblDetailCourseVal"
        lblDetailCourseVal.Size = New Size(144, 30)
        lblDetailCourseVal.TabIndex = 7
        lblDetailCourseVal.Text = "-"
        ' 
        ' lblDetailCourseLabel
        ' 
        lblDetailCourseLabel.AutoSize = True
        lblDetailCourseLabel.Font = New Font("Segoe UI", 8F)
        lblDetailCourseLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailCourseLabel.Location = New Point(16, 110)
        lblDetailCourseLabel.Name = "lblDetailCourseLabel"
        lblDetailCourseLabel.Size = New Size(49, 13)
        lblDetailCourseLabel.TabIndex = 6
        lblDetailCourseLabel.Text = "Course :"
        ' 
        ' lblDetailNameVal
        ' 
        lblDetailNameVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDetailNameVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailNameVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailNameVal.Location = New Point(110, 78)
        lblDetailNameVal.Name = "lblDetailNameVal"
        lblDetailNameVal.Size = New Size(144, 26)
        lblDetailNameVal.TabIndex = 5
        lblDetailNameVal.Text = "-"
        ' 
        ' lblDetailNameLabel
        ' 
        lblDetailNameLabel.AutoSize = True
        lblDetailNameLabel.Font = New Font("Segoe UI", 8F)
        lblDetailNameLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailNameLabel.Location = New Point(16, 78)
        lblDetailNameLabel.Name = "lblDetailNameLabel"
        lblDetailNameLabel.Size = New Size(85, 13)
        lblDetailNameLabel.TabIndex = 4
        lblDetailNameLabel.Text = "Student Name :"
        ' 
        ' lblDetailStudentNoVal
        ' 
        lblDetailStudentNoVal.AutoSize = True
        lblDetailStudentNoVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblDetailStudentNoVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailStudentNoVal.Location = New Point(110, 50)
        lblDetailStudentNoVal.Name = "lblDetailStudentNoVal"
        lblDetailStudentNoVal.Size = New Size(12, 15)
        lblDetailStudentNoVal.TabIndex = 3
        lblDetailStudentNoVal.Text = "-"
        ' 
        ' lblDetailStudentNoLabel
        ' 
        lblDetailStudentNoLabel.AutoSize = True
        lblDetailStudentNoLabel.Font = New Font("Segoe UI", 8F)
        lblDetailStudentNoLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblDetailStudentNoLabel.Location = New Point(16, 50)
        lblDetailStudentNoLabel.Name = "lblDetailStudentNoLabel"
        lblDetailStudentNoLabel.Size = New Size(73, 13)
        lblDetailStudentNoLabel.TabIndex = 2
        lblDetailStudentNoLabel.Text = "Student No. :"
        ' 
        ' lblDetailTitle
        ' 
        lblDetailTitle.AutoSize = True
        lblDetailTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblDetailTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblDetailTitle.Location = New Point(42, 16)
        lblDetailTitle.Name = "lblDetailTitle"
        lblDetailTitle.Size = New Size(117, 20)
        lblDetailTitle.TabIndex = 1
        lblDetailTitle.Text = "Request Details"
        ' 
        ' lblDetailIcon
        ' 
        lblDetailIcon.AutoSize = True
        lblDetailIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblDetailIcon.ForeColor = Color.FromArgb(11, 99, 229)
        lblDetailIcon.Location = New Point(16, 16)
        lblDetailIcon.Name = "lblDetailIcon"
        lblDetailIcon.Size = New Size(24, 21)
        lblDetailIcon.TabIndex = 0
        lblDetailIcon.Text = "📄"
        ' 
        ' pnlHistoryTableCard
        ' 
        pnlHistoryTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHistoryTableCard.BackColor = Color.White
        pnlHistoryTableCard.BorderStyle = BorderStyle.FixedSingle
        pnlHistoryTableCard.Controls.Add(dgvHistory)
        pnlHistoryTableCard.Controls.Add(lblRecordCount)
        pnlHistoryTableCard.Controls.Add(lblTableTitle)
        pnlHistoryTableCard.Controls.Add(lblTableIcon)
        pnlHistoryTableCard.Location = New Point(28, 260)
        pnlHistoryTableCard.Name = "pnlHistoryTableCard"
        pnlHistoryTableCard.Padding = New Padding(16)
        pnlHistoryTableCard.Size = New Size(636, 504)
        pnlHistoryTableCard.TabIndex = 8
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AllowUserToDeleteRows = False
        dgvHistory.AllowUserToResizeRows = False
        dgvHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistory.BackgroundColor = Color.White
        dgvHistory.BorderStyle = BorderStyle.None
        dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(100, 116, 139)
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 116, 139)
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvHistory.ColumnHeadersHeight = 36
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {colNum, colHistoryID, colRecordID, colDate, colStudentNo, colStudentName, colRequirement, colActionTaken, colStatus, colRemarks})
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = Color.White
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 8.5F)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvHistory.DefaultCellStyle = dataGridViewCellStyle2
        dgvHistory.EnableHeadersVisualStyles = False
        dgvHistory.GridColor = Color.FromArgb(241, 245, 249)
        dgvHistory.Location = New Point(16, 52)
        dgvHistory.MultiSelect = False
        dgvHistory.Name = "dgvHistory"
        dgvHistory.ReadOnly = True
        dgvHistory.RowHeadersVisible = False
        dgvHistory.RowTemplate.Height = 38
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.Size = New Size(602, 434)
        dgvHistory.TabIndex = 3
        ' 
        ' colNum
        ' 
        colNum.HeaderText = "#"
        colNum.Name = "colNum"
        colNum.ReadOnly = True
        colNum.Width = 35
        ' 
        ' colHistoryID
        ' 
        colHistoryID.HeaderText = "HistoryID"
        colHistoryID.Name = "colHistoryID"
        colHistoryID.ReadOnly = True
        colHistoryID.Visible = False
        ' 
        ' colRecordID
        ' 
        colRecordID.HeaderText = "RecordID"
        colRecordID.Name = "colRecordID"
        colRecordID.ReadOnly = True
        colRecordID.Visible = False
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        colDate.Width = 100
        ' 
        ' colStudentNo
        ' 
        colStudentNo.HeaderText = "Student No."
        colStudentNo.Name = "colStudentNo"
        colStudentNo.ReadOnly = True
        colStudentNo.Width = 95
        ' 
        ' colStudentName
        ' 
        colStudentName.HeaderText = "Student Name"
        colStudentName.Name = "colStudentName"
        colStudentName.ReadOnly = True
        colStudentName.Width = 120
        ' 
        ' colRequirement
        ' 
        colRequirement.HeaderText = "Requirement"
        colRequirement.Name = "colRequirement"
        colRequirement.ReadOnly = True
        colRequirement.Width = 105
        ' 
        ' colActionTaken
        ' 
        colActionTaken.HeaderText = "Action Taken"
        colActionTaken.Name = "colActionTaken"
        colActionTaken.ReadOnly = True
        colActionTaken.Width = 95
        ' 
        ' colStatus
        ' 
        dataGridViewCellStyleStatus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        colStatus.DefaultCellStyle = dataGridViewCellStyleStatus
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 85
        ' 
        ' colRemarks
        ' 
        colRemarks.HeaderText = "Remarks"
        colRemarks.Name = "colRemarks"
        colRemarks.ReadOnly = True
        colRemarks.Width = 120
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 8.5F)
        lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139)
        lblRecordCount.Location = New Point(480, 18)
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
        lblTableTitle.Size = New Size(227, 20)
        lblTableTitle.TabIndex = 1
        lblTableTitle.Text = "History of Processed Requests"
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
        pnlFilterBar.Controls.Add(cmbStatusFilter)
        pnlFilterBar.Controls.Add(cmbDateFilter)
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
        ' cmbStatusFilter
        ' 
        cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatusFilter.Font = New Font("Segoe UI", 9F)
        cmbStatusFilter.FormattingEnabled = True
        cmbStatusFilter.Items.AddRange(New Object() {"All Statuses", "Cleared", "Rejected", "Under Review"})
        cmbStatusFilter.Location = New Point(530, 14)
        cmbStatusFilter.Name = "cmbStatusFilter"
        cmbStatusFilter.Size = New Size(140, 23)
        cmbStatusFilter.TabIndex = 3
        ' 
        ' cmbDateFilter
        ' 
        cmbDateFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDateFilter.Font = New Font("Segoe UI", 9F)
        cmbDateFilter.FormattingEnabled = True
        cmbDateFilter.Items.AddRange(New Object() {"All Dates", "Today", "Last 7 Days", "Last 30 Days"})
        cmbDateFilter.Location = New Point(340, 14)
        cmbDateFilter.Name = "cmbDateFilter"
        cmbDateFilter.Size = New Size(170, 23)
        cmbDateFilter.TabIndex = 2
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
        ' pnlSummaryCards
        ' 
        pnlSummaryCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummaryCards.Controls.Add(pnlCardRejected)
        pnlSummaryCards.Controls.Add(pnlCardApproved)
        pnlSummaryCards.Controls.Add(pnlCardReviewed)
        pnlSummaryCards.Location = New Point(28, 92)
        pnlSummaryCards.Name = "pnlSummaryCards"
        pnlSummaryCards.Size = New Size(924, 86)
        pnlSummaryCards.TabIndex = 6
        ' 
        ' pnlCardRejected
        ' 
        pnlCardRejected.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlCardRejected.BackColor = Color.White
        pnlCardRejected.BorderStyle = BorderStyle.FixedSingle
        pnlCardRejected.Controls.Add(lblRejectedArrow)
        pnlCardRejected.Controls.Add(lblRejectedSub)
        pnlCardRejected.Controls.Add(lblRejectedTitle)
        pnlCardRejected.Controls.Add(lblRejectedCount)
        pnlCardRejected.Controls.Add(lblRejectedIcon)
        pnlCardRejected.Location = New Point(626, 0)
        pnlCardRejected.Name = "pnlCardRejected"
        pnlCardRejected.Size = New Size(298, 86)
        pnlCardRejected.TabIndex = 2
        ' 
        ' lblRejectedArrow
        ' 
        lblRejectedArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRejectedArrow.AutoSize = True
        lblRejectedArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblRejectedArrow.ForeColor = Color.FromArgb(220, 38, 38)
        lblRejectedArrow.Location = New Point(266, 32)
        lblRejectedArrow.Name = "lblRejectedArrow"
        lblRejectedArrow.Size = New Size(19, 21)
        lblRejectedArrow.TabIndex = 4
        lblRejectedArrow.Text = ">"
        ' 
        ' lblRejectedSub
        ' 
        lblRejectedSub.AutoSize = True
        lblRejectedSub.Font = New Font("Segoe UI", 8F)
        lblRejectedSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblRejectedSub.Location = New Point(64, 56)
        lblRejectedSub.Name = "lblRejectedSub"
        lblRejectedSub.Size = New Size(136, 13)
        lblRejectedSub.TabIndex = 3
        lblRejectedSub.Text = "Requests you have rejected"
        ' 
        ' lblRejectedTitle
        ' 
        lblRejectedTitle.AutoSize = True
        lblRejectedTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblRejectedTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblRejectedTitle.Location = New Point(64, 38)
        lblRejectedTitle.Name = "lblRejectedTitle"
        lblRejectedTitle.Size = New Size(53, 15)
        lblRejectedTitle.TabIndex = 2
        lblRejectedTitle.Text = "Rejected"
        ' 
        ' lblRejectedCount
        ' 
        lblRejectedCount.AutoSize = True
        lblRejectedCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblRejectedCount.ForeColor = Color.FromArgb(15, 23, 42)
        lblRejectedCount.Location = New Point(64, 8)
        lblRejectedCount.Name = "lblRejectedCount"
        lblRejectedCount.Size = New Size(26, 30)
        lblRejectedCount.TabIndex = 1
        lblRejectedCount.Text = "0"
        ' 
        ' lblRejectedIcon
        ' 
        lblRejectedIcon.BackColor = Color.FromArgb(254, 226, 226)
        lblRejectedIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblRejectedIcon.ForeColor = Color.FromArgb(220, 38, 38)
        lblRejectedIcon.Location = New Point(16, 16)
        lblRejectedIcon.Name = "lblRejectedIcon"
        lblRejectedIcon.Size = New Size(40, 40)
        lblRejectedIcon.TabIndex = 0
        lblRejectedIcon.Text = "✕"
        lblRejectedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardApproved
        ' 
        pnlCardApproved.Anchor = AnchorStyles.Top
        pnlCardApproved.BackColor = Color.White
        pnlCardApproved.BorderStyle = BorderStyle.FixedSingle
        pnlCardApproved.Controls.Add(lblApprovedArrow)
        pnlCardApproved.Controls.Add(lblApprovedSub)
        pnlCardApproved.Controls.Add(lblApprovedTitle)
        pnlCardApproved.Controls.Add(lblApprovedCount)
        pnlCardApproved.Controls.Add(lblApprovedIcon)
        pnlCardApproved.Location = New Point(313, 0)
        pnlCardApproved.Name = "pnlCardApproved"
        pnlCardApproved.Size = New Size(298, 86)
        pnlCardApproved.TabIndex = 1
        ' 
        ' lblApprovedArrow
        ' 
        lblApprovedArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblApprovedArrow.AutoSize = True
        lblApprovedArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblApprovedArrow.ForeColor = Color.FromArgb(22, 163, 74)
        lblApprovedArrow.Location = New Point(266, 32)
        lblApprovedArrow.Name = "lblApprovedArrow"
        lblApprovedArrow.Size = New Size(19, 21)
        lblApprovedArrow.TabIndex = 4
        lblApprovedArrow.Text = ">"
        ' 
        ' lblApprovedSub
        ' 
        lblApprovedSub.AutoSize = True
        lblApprovedSub.Font = New Font("Segoe UI", 8F)
        lblApprovedSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblApprovedSub.Location = New Point(64, 56)
        lblApprovedSub.Name = "lblApprovedSub"
        lblApprovedSub.Size = New Size(144, 13)
        lblApprovedSub.TabIndex = 3
        lblApprovedSub.Text = "Requests you have approved"
        ' 
        ' lblApprovedTitle
        ' 
        lblApprovedTitle.AutoSize = True
        lblApprovedTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblApprovedTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblApprovedTitle.Location = New Point(64, 38)
        lblApprovedTitle.Name = "lblApprovedTitle"
        lblApprovedTitle.Size = New Size(59, 15)
        lblApprovedTitle.TabIndex = 2
        lblApprovedTitle.Text = "Approved"
        ' 
        ' lblApprovedCount
        ' 
        lblApprovedCount.AutoSize = True
        lblApprovedCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblApprovedCount.ForeColor = Color.FromArgb(15, 23, 42)
        lblApprovedCount.Location = New Point(64, 8)
        lblApprovedCount.Name = "lblApprovedCount"
        lblApprovedCount.Size = New Size(26, 30)
        lblApprovedCount.TabIndex = 1
        lblApprovedCount.Text = "0"
        ' 
        ' lblApprovedIcon
        ' 
        lblApprovedIcon.BackColor = Color.FromArgb(220, 252, 231)
        lblApprovedIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblApprovedIcon.ForeColor = Color.FromArgb(22, 163, 74)
        lblApprovedIcon.Location = New Point(16, 16)
        lblApprovedIcon.Name = "lblApprovedIcon"
        lblApprovedIcon.Size = New Size(40, 40)
        lblApprovedIcon.TabIndex = 0
        lblApprovedIcon.Text = "✓"
        lblApprovedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardReviewed
        ' 
        pnlCardReviewed.BackColor = Color.White
        pnlCardReviewed.BorderStyle = BorderStyle.FixedSingle
        pnlCardReviewed.Controls.Add(lblReviewedArrow)
        pnlCardReviewed.Controls.Add(lblReviewedSub)
        pnlCardReviewed.Controls.Add(lblReviewedTitle)
        pnlCardReviewed.Controls.Add(lblReviewedCount)
        pnlCardReviewed.Controls.Add(lblReviewedIcon)
        pnlCardReviewed.Location = New Point(0, 0)
        pnlCardReviewed.Name = "pnlCardReviewed"
        pnlCardReviewed.Size = New Size(298, 86)
        pnlCardReviewed.TabIndex = 0
        ' 
        ' lblReviewedArrow
        ' 
        lblReviewedArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblReviewedArrow.AutoSize = True
        lblReviewedArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblReviewedArrow.ForeColor = Color.FromArgb(37, 99, 235)
        lblReviewedArrow.Location = New Point(266, 32)
        lblReviewedArrow.Name = "lblReviewedArrow"
        lblReviewedArrow.Size = New Size(19, 21)
        lblReviewedArrow.TabIndex = 4
        lblReviewedArrow.Text = ">"
        ' 
        ' lblReviewedSub
        ' 
        lblReviewedSub.AutoSize = True
        lblReviewedSub.Font = New Font("Segoe UI", 8F)
        lblReviewedSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblReviewedSub.Location = New Point(64, 56)
        lblReviewedSub.Name = "lblReviewedSub"
        lblReviewedSub.Size = New Size(175, 13)
        lblReviewedSub.TabIndex = 3
        lblReviewedSub.Text = "Total requests you have processed"
        ' 
        ' lblReviewedTitle
        ' 
        lblReviewedTitle.AutoSize = True
        lblReviewedTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblReviewedTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblReviewedTitle.Location = New Point(64, 38)
        lblReviewedTitle.Name = "lblReviewedTitle"
        lblReviewedTitle.Size = New Size(86, 15)
        lblReviewedTitle.TabIndex = 2
        lblReviewedTitle.Text = "Total Reviewed"
        ' 
        ' lblReviewedCount
        ' 
        lblReviewedCount.AutoSize = True
        lblReviewedCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblReviewedCount.ForeColor = Color.FromArgb(15, 23, 42)
        lblReviewedCount.Location = New Point(64, 8)
        lblReviewedCount.Name = "lblReviewedCount"
        lblReviewedCount.Size = New Size(26, 30)
        lblReviewedCount.TabIndex = 1
        lblReviewedCount.Text = "0"
        ' 
        ' lblReviewedIcon
        ' 
        lblReviewedIcon.BackColor = Color.FromArgb(219, 234, 254)
        lblReviewedIcon.Font = New Font("Segoe UI", 12F)
        lblReviewedIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblReviewedIcon.Location = New Point(16, 16)
        lblReviewedIcon.Name = "lblReviewedIcon"
        lblReviewedIcon.Size = New Size(40, 40)
        lblReviewedIcon.TabIndex = 0
        lblReviewedIcon.Text = "📄"
        lblReviewedIcon.TextAlign = ContentAlignment.MiddleCenter
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
        lblHeaderSub.Size = New Size(256, 17)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "View processed clearance actions and decisions."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(24, 16)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(177, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Staff History"
        ' 
        ' StaffHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "StaffHistoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Staff History"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlHistoryDetailCard.ResumeLayout(False)
        pnlHistoryDetailCard.PerformLayout()
        pnlHistoryTableCard.ResumeLayout(False)
        pnlHistoryTableCard.PerformLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        pnlFilterBar.ResumeLayout(False)
        pnlFilterBar.PerformLayout()
        pnlSummaryCards.ResumeLayout(False)
        pnlCardRejected.ResumeLayout(False)
        pnlCardRejected.PerformLayout()
        pnlCardApproved.ResumeLayout(False)
        pnlCardApproved.PerformLayout()
        pnlCardReviewed.ResumeLayout(False)
        pnlCardReviewed.PerformLayout()
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
    Friend WithEvents pnlSummaryCards As Panel
    Friend WithEvents pnlCardReviewed As Panel
    Friend WithEvents lblReviewedIcon As Label
    Friend WithEvents lblReviewedCount As Label
    Friend WithEvents lblReviewedTitle As Label
    Friend WithEvents lblReviewedSub As Label
    Friend WithEvents lblReviewedArrow As Label
    Friend WithEvents pnlCardApproved As Panel
    Friend WithEvents lblApprovedIcon As Label
    Friend WithEvents lblApprovedCount As Label
    Friend WithEvents lblApprovedTitle As Label
    Friend WithEvents lblApprovedSub As Label
    Friend WithEvents lblApprovedArrow As Label
    Friend WithEvents pnlCardRejected As Panel
    Friend WithEvents lblRejectedIcon As Label
    Friend WithEvents lblRejectedCount As Label
    Friend WithEvents lblRejectedTitle As Label
    Friend WithEvents lblRejectedSub As Label
    Friend WithEvents lblRejectedArrow As Label
    Friend WithEvents pnlFilterBar As Panel
    Friend WithEvents lblSearchIcon As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbDateFilter As ComboBox
    Friend WithEvents cmbStatusFilter As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlHistoryTableCard As Panel
    Friend WithEvents lblTableIcon As Label
    Friend WithEvents lblTableTitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colHistoryID As DataGridViewTextBoxColumn
    Friend WithEvents colRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStudentNo As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colRequirement As DataGridViewTextBoxColumn
    Friend WithEvents colActionTaken As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents pnlHistoryDetailCard As Panel
    Friend WithEvents lblDetailIcon As Label
    Friend WithEvents lblDetailTitle As Label
    Friend WithEvents lblDetailStudentNoLabel As Label
    Friend WithEvents lblDetailStudentNoVal As Label
    Friend WithEvents lblDetailNameLabel As Label
    Friend WithEvents lblDetailNameVal As Label
    Friend WithEvents lblDetailCourseLabel As Label
    Friend WithEvents lblDetailCourseVal As Label
    Friend WithEvents lblDetailYearLabel As Label
    Friend WithEvents lblDetailYearVal As Label
    Friend WithEvents lblDetailReqLabel As Label
    Friend WithEvents lblDetailReqVal As Label
    Friend WithEvents lblDetailDateLabel As Label
    Friend WithEvents lblDetailDateVal As Label
    Friend WithEvents lblDetailActionLabel As Label
    Friend WithEvents lblDetailActionVal As Label
    Friend WithEvents lblDetailStatusLabel As Label
    Friend WithEvents lblDetailStatusVal As Label
    Friend WithEvents lblDetailRemarksLabel As Label
    Friend WithEvents lblDetailRemarksVal As Label
    Friend WithEvents btnReReview As Button

End Class
