<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffOfficesForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        lblNavSection = New Label()
        btnNavStudents = New Button()
        btnNavStaff = New Button()
        btnNavHistory = New Button()
        btnNavStartTerm = New Button()
        btnNavLogout = New Button()
        pnlLogo = New Panel()
        lblLogoText = New Label()
        picSchoolLogo = New PictureBox()
        pnlMain = New Panel()
        pnlBottomDetails = New Panel()
        pnlActionsCard = New Panel()
        btnRemoveStaff = New Button()
        btnResetPassword = New Button()
        btnEditStaff = New Button()
        lblActionsSub = New Label()
        lblActionsTitle = New Label()
        pnlDetailsCard = New Panel()
        lblSelectedOfficeVal = New Label()
        lblSelectedOffice = New Label()
        lblSelectedUsernameVal = New Label()
        lblSelectedUsername = New Label()
        lblSelectedStaffVal = New Label()
        lblSelectedStaff = New Label()
        lblDetailsTitle = New Label()
        dgvStaff = New DataGridView()
        colStaffName = New DataGridViewTextBoxColumn()
        colAssignedOffice = New DataGridViewTextBoxColumn()
        colUsername = New DataGridViewTextBoxColumn()
        colRole = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlSearchRow = New Panel()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        pnlHeader = New Panel()
        btnAddStaff = New Button()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlBottomDetails.SuspendLayout()
        pnlActionsCard.SuspendLayout()
        pnlDetailsCard.SuspendLayout()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchRow.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
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
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblNavSection.ForeColor = Color.FromArgb(CByte(91), CByte(122), CByte(159))
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(93, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "ADMINISTRATION"
        ' 
        ' btnNavStudents
        ' 
        btnNavStudents.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI", 9.5F)
        btnNavStudents.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavStudents.Location = New Point(12, 115)
        btnNavStudents.Name = "btnNavStudents"
        btnNavStudents.Padding = New Padding(12, 0, 0, 0)
        btnNavStudents.Size = New Size(196, 42)
        btnNavStudents.TabIndex = 2
        btnNavStudents.Text = "  Students"
        btnNavStudents.TextAlign = ContentAlignment.MiddleLeft
        btnNavStudents.UseVisualStyleBackColor = False
        ' 
        ' btnNavStaff
        ' 
        btnNavStaff.BackColor = Color.FromArgb(CByte(28), CByte(91), CByte(184))
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavStaff.ForeColor = Color.White
        btnNavStaff.Location = New Point(12, 163)
        btnNavStaff.Name = "btnNavStaff"
        btnNavStaff.Padding = New Padding(12, 0, 0, 0)
        btnNavStaff.Size = New Size(196, 42)
        btnNavStaff.TabIndex = 3
        btnNavStaff.Text = "  Staff & offices"
        btnNavStaff.TextAlign = ContentAlignment.MiddleLeft
        btnNavStaff.UseVisualStyleBackColor = False
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavHistory.Location = New Point(12, 211)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(12, 0, 0, 0)
        btnNavHistory.Size = New Size(196, 42)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavStartTerm
        ' 
        btnNavStartTerm.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI", 9.5F)
        btnNavStartTerm.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavStartTerm.Location = New Point(12, 259)
        btnNavStartTerm.Name = "btnNavStartTerm"
        btnNavStartTerm.Padding = New Padding(12, 0, 0, 0)
        btnNavStartTerm.Size = New Size(196, 42)
        btnNavStartTerm.TabIndex = 5
        btnNavStartTerm.Text = "  Start new term"
        btnNavStartTerm.TextAlign = ContentAlignment.MiddleLeft
        btnNavStartTerm.UseVisualStyleBackColor = False
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavLogout.Location = New Point(0, 752)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(20, 0, 0, 0)
        btnNavLogout.Size = New Size(220, 48)
        btnNavLogout.TabIndex = 6
        btnNavLogout.Text = "  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoText)
        pnlLogo.Controls.Add(picSchoolLogo)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 75)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoText
        ' 
        lblLogoText.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblLogoText.ForeColor = Color.White
        lblLogoText.Location = New Point(52, 16)
        lblLogoText.Name = "lblLogoText"
        lblLogoText.Size = New Size(140, 40)
        lblLogoText.TabIndex = 1
        lblLogoText.Text = "EClearance"
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(3, 16)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(43, 40)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlMain.Controls.Add(pnlBottomDetails)
        pnlMain.Controls.Add(dgvStaff)
        pnlMain.Controls.Add(pnlSearchRow)
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
        pnlBottomDetails.Location = New Point(28, 540)
        pnlBottomDetails.Name = "pnlBottomDetails"
        pnlBottomDetails.Size = New Size(924, 240)
        pnlBottomDetails.TabIndex = 3
        ' 
        ' pnlActionsCard
        ' 
        pnlActionsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlActionsCard.BackColor = Color.White
        pnlActionsCard.BorderStyle = BorderStyle.FixedSingle
        pnlActionsCard.Controls.Add(btnRemoveStaff)
        pnlActionsCard.Controls.Add(btnResetPassword)
        pnlActionsCard.Controls.Add(btnEditStaff)
        pnlActionsCard.Controls.Add(lblActionsSub)
        pnlActionsCard.Controls.Add(lblActionsTitle)
        pnlActionsCard.Location = New Point(630, 0)
        pnlActionsCard.Name = "pnlActionsCard"
        pnlActionsCard.Padding = New Padding(16)
        pnlActionsCard.Size = New Size(294, 236)
        pnlActionsCard.TabIndex = 1
        ' 
        ' btnRemoveStaff
        ' 
        btnRemoveStaff.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnRemoveStaff.Cursor = Cursors.Hand
        btnRemoveStaff.FlatAppearance.BorderSize = 0
        btnRemoveStaff.FlatStyle = FlatStyle.Flat
        btnRemoveStaff.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnRemoveStaff.ForeColor = Color.White
        btnRemoveStaff.Location = New Point(16, 185)
        btnRemoveStaff.Name = "btnRemoveStaff"
        btnRemoveStaff.Size = New Size(260, 36)
        btnRemoveStaff.TabIndex = 4
        btnRemoveStaff.Text = "Deactivate Staff"
        btnRemoveStaff.UseVisualStyleBackColor = False
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.White
        btnResetPassword.Cursor = Cursors.Hand
        btnResetPassword.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnResetPassword.FlatStyle = FlatStyle.Flat
        btnResetPassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnResetPassword.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        btnResetPassword.Location = New Point(16, 140)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(260, 36)
        btnResetPassword.TabIndex = 3
        btnResetPassword.Text = "🔑 Reset password"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' btnEditStaff
        ' 
        btnEditStaff.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnEditStaff.Cursor = Cursors.Hand
        btnEditStaff.FlatAppearance.BorderSize = 0
        btnEditStaff.FlatStyle = FlatStyle.Flat
        btnEditStaff.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnEditStaff.ForeColor = Color.White
        btnEditStaff.Location = New Point(16, 95)
        btnEditStaff.Name = "btnEditStaff"
        btnEditStaff.Size = New Size(260, 36)
        btnEditStaff.TabIndex = 2
        btnEditStaff.Text = "✏ Edit staff account"
        btnEditStaff.UseVisualStyleBackColor = False
        ' 
        ' lblActionsSub
        ' 
        lblActionsSub.Font = New Font("Segoe UI", 8.5F)
        lblActionsSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblActionsSub.Location = New Point(16, 42)
        lblActionsSub.Name = "lblActionsSub"
        lblActionsSub.Size = New Size(260, 42)
        lblActionsSub.TabIndex = 1
        lblActionsSub.Text = "Update account credentials or change assigned clearance office."
        ' 
        ' lblActionsTitle
        ' 
        lblActionsTitle.AutoSize = True
        lblActionsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblActionsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
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
        pnlDetailsCard.Controls.Add(lblSelectedOfficeVal)
        pnlDetailsCard.Controls.Add(lblSelectedOffice)
        pnlDetailsCard.Controls.Add(lblSelectedUsernameVal)
        pnlDetailsCard.Controls.Add(lblSelectedUsername)
        pnlDetailsCard.Controls.Add(lblSelectedStaffVal)
        pnlDetailsCard.Controls.Add(lblSelectedStaff)
        pnlDetailsCard.Controls.Add(lblDetailsTitle)
        pnlDetailsCard.Location = New Point(0, 0)
        pnlDetailsCard.Name = "pnlDetailsCard"
        pnlDetailsCard.Padding = New Padding(20)
        pnlDetailsCard.Size = New Size(616, 236)
        pnlDetailsCard.TabIndex = 0
        ' 
        ' lblSelectedOfficeVal
        ' 
        lblSelectedOfficeVal.AutoSize = True
        lblSelectedOfficeVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSelectedOfficeVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSelectedOfficeVal.Location = New Point(150, 135)
        lblSelectedOfficeVal.Name = "lblSelectedOfficeVal"
        lblSelectedOfficeVal.Size = New Size(18, 17)
        lblSelectedOfficeVal.TabIndex = 6
        lblSelectedOfficeVal.Text = "--"
        ' 
        ' lblSelectedOffice
        ' 
        lblSelectedOffice.AutoSize = True
        lblSelectedOffice.Font = New Font("Segoe UI", 9F)
        lblSelectedOffice.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSelectedOffice.Location = New Point(20, 135)
        lblSelectedOffice.Name = "lblSelectedOffice"
        lblSelectedOffice.Size = New Size(88, 15)
        lblSelectedOffice.TabIndex = 5
        lblSelectedOffice.Text = "Assigned office"
        ' 
        ' lblSelectedUsernameVal
        ' 
        lblSelectedUsernameVal.AutoSize = True
        lblSelectedUsernameVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSelectedUsernameVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSelectedUsernameVal.Location = New Point(150, 95)
        lblSelectedUsernameVal.Name = "lblSelectedUsernameVal"
        lblSelectedUsernameVal.Size = New Size(18, 17)
        lblSelectedUsernameVal.TabIndex = 4
        lblSelectedUsernameVal.Text = "--"
        ' 
        ' lblSelectedUsername
        ' 
        lblSelectedUsername.AutoSize = True
        lblSelectedUsername.Font = New Font("Segoe UI", 9F)
        lblSelectedUsername.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSelectedUsername.Location = New Point(20, 95)
        lblSelectedUsername.Name = "lblSelectedUsername"
        lblSelectedUsername.Size = New Size(60, 15)
        lblSelectedUsername.TabIndex = 3
        lblSelectedUsername.Text = "Username"
        ' 
        ' lblSelectedStaffVal
        ' 
        lblSelectedStaffVal.AutoSize = True
        lblSelectedStaffVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSelectedStaffVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSelectedStaffVal.Location = New Point(150, 55)
        lblSelectedStaffVal.Name = "lblSelectedStaffVal"
        lblSelectedStaffVal.Size = New Size(18, 17)
        lblSelectedStaffVal.TabIndex = 2
        lblSelectedStaffVal.Text = "--"
        ' 
        ' lblSelectedStaff
        ' 
        lblSelectedStaff.AutoSize = True
        lblSelectedStaff.Font = New Font("Segoe UI", 9F)
        lblSelectedStaff.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSelectedStaff.Location = New Point(20, 55)
        lblSelectedStaff.Name = "lblSelectedStaff"
        lblSelectedStaff.Size = New Size(64, 15)
        lblSelectedStaff.TabIndex = 1
        lblSelectedStaff.Text = "Staff name"
        ' 
        ' lblDetailsTitle
        ' 
        lblDetailsTitle.AutoSize = True
        lblDetailsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblDetailsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDetailsTitle.Location = New Point(20, 18)
        lblDetailsTitle.Name = "lblDetailsTitle"
        lblDetailsTitle.Size = New Size(93, 20)
        lblDetailsTitle.TabIndex = 0
        lblDetailsTitle.Text = "Staff details"
        ' 
        ' dgvStaff
        ' 
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.AllowUserToDeleteRows = False
        dgvStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStaff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStaff.ColumnHeadersHeight = 36
        dgvStaff.Columns.AddRange(New DataGridViewColumn() {colStaffName, colAssignedOffice, colUsername, colRole, colStatus})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(224), CByte(238), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStaff.DefaultCellStyle = DataGridViewCellStyle2
        dgvStaff.EnableHeadersVisualStyles = False
        dgvStaff.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvStaff.Location = New Point(28, 160)
        dgvStaff.Name = "dgvStaff"
        dgvStaff.ReadOnly = True
        dgvStaff.RowHeadersVisible = False
        dgvStaff.RowTemplate.Height = 36
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.Size = New Size(924, 360)
        dgvStaff.TabIndex = 2
        ' 
        ' colStaffName
        ' 
        colStaffName.HeaderText = "Staff name"
        colStaffName.Name = "colStaffName"
        colStaffName.ReadOnly = True
        colStaffName.Width = 200
        ' 
        ' colAssignedOffice
        ' 
        colAssignedOffice.HeaderText = "Assigned office"
        colAssignedOffice.Name = "colAssignedOffice"
        colAssignedOffice.ReadOnly = True
        colAssignedOffice.Width = 180
        ' 
        ' colUsername
        ' 
        colUsername.HeaderText = "Username"
        colUsername.Name = "colUsername"
        colUsername.ReadOnly = True
        colUsername.Width = 160
        ' 
        ' colRole
        ' 
        colRole.HeaderText = "Role"
        colRole.Name = "colRole"
        colRole.ReadOnly = True
        colRole.Width = 140
        ' 
        ' colStatus
        ' 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' pnlSearchRow
        ' 
        pnlSearchRow.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSearchRow.Controls.Add(btnRefresh)
        pnlSearchRow.Controls.Add(txtSearch)
        pnlSearchRow.Location = New Point(28, 95)
        pnlSearchRow.Name = "pnlSearchRow"
        pnlSearchRow.Size = New Size(924, 45)
        pnlSearchRow.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.White
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
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
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        txtSearch.Location = New Point(0, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by name, office, or username"
        txtSearch.Size = New Size(808, 25)
        txtSearch.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(btnAddStaff)
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Location = New Point(28, 15)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddStaff.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnAddStaff.Cursor = Cursors.Hand
        btnAddStaff.FlatAppearance.BorderSize = 0
        btnAddStaff.FlatStyle = FlatStyle.Flat
        btnAddStaff.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnAddStaff.ForeColor = Color.White
        btnAddStaff.Location = New Point(804, 12)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(120, 38)
        btnAddStaff.TabIndex = 2
        btnAddStaff.Text = "+ Add staff"
        btnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSubHeader.Location = New Point(0, 38)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(340, 17)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Manage staff accounts and clearance office assignments."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(-3, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(176, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Staff & offices"
        ' 
        ' StaffOfficesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "StaffOfficesForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Staff & Offices"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlBottomDetails.ResumeLayout(False)
        pnlActionsCard.ResumeLayout(False)
        pnlActionsCard.PerformLayout()
        pnlDetailsCard.ResumeLayout(False)
        pnlDetailsCard.PerformLayout()
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchRow.ResumeLayout(False)
        pnlSearchRow.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picSchoolLogo As PictureBox
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
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents pnlSearchRow As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents colStaffName As DataGridViewTextBoxColumn
    Friend WithEvents colAssignedOffice As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents pnlBottomDetails As Panel
    Friend WithEvents pnlDetailsCard As Panel
    Friend WithEvents lblDetailsTitle As Label
    Friend WithEvents lblSelectedStaff As Label
    Friend WithEvents lblSelectedStaffVal As Label
    Friend WithEvents lblSelectedUsername As Label
    Friend WithEvents lblSelectedUsernameVal As Label
    Friend WithEvents lblSelectedOffice As Label
    Friend WithEvents lblSelectedOfficeVal As Label
    Friend WithEvents pnlActionsCard As Panel
    Friend WithEvents lblActionsTitle As Label
    Friend WithEvents lblActionsSub As Label
    Friend WithEvents btnEditStaff As Button
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnRemoveStaff As Button

End Class
