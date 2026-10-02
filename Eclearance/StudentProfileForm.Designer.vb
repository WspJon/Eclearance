<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentProfileForm
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
        pnlSidebar = New Panel()
        btnNavLogout = New Button()
        btnNavProfile = New Button()
        btnNavHistory = New Button()
        btnNavMyClearance = New Button()
        pnlLogo = New Panel()
        lblLogoSubtitle = New Label()
        picSchoolLogo = New PictureBox()
        lblLogoTitle = New Label()
        pnlMain = New Panel()
        pnlScrollContent = New Panel()
        tlpCards = New TableLayoutPanel()
        pnlPersonalCard = New Panel()
        lblPersonalCivilStatusVal = New Label()
        lblPersonalCivilStatusTitle = New Label()
        lblPersonalFullNameVal = New Label()
        lblPersonalFullNameTitle = New Label()
        pnlPersonalSep = New Panel()
        lblPersonalTitle = New Label()
        lblPersonalIcon = New Label()
        pnlAcademicCard = New Panel()
        lblAcademicTermVal = New Label()
        lblAcademicTermTitle = New Label()
        lblAcademicYearVal = New Label()
        lblAcademicYearTitle = New Label()
        lblAcademicCollegeVal = New Label()
        lblAcademicCollegeTitle = New Label()
        lblAcademicStudentTypeVal = New Label()
        lblAcademicStudentTypeTitle = New Label()
        lblAcademicSectionVal = New Label()
        lblAcademicSectionTitle = New Label()
        lblAcademicYearLevelVal = New Label()
        lblAcademicYearLevelTitle = New Label()
        lblAcademicCourseVal = New Label()
        lblAcademicCourseTitle = New Label()
        lblAcademicStudentNoVal = New Label()
        lblAcademicStudentNoTitle = New Label()
        pnlAcademicSep = New Panel()
        lblAcademicTitle = New Label()
        lblAcademicIcon = New Label()
        pnlContactCard = New Panel()
        lblContactRelationshipVal = New Label()
        lblContactRelationshipTitle = New Label()
        lblContactEmergencyPhoneVal = New Label()
        lblContactEmergencyPhoneTitle = New Label()
        lblContactEmergencyNameVal = New Label()
        lblContactEmergencyNameTitle = New Label()
        lblContactAddressVal = New Label()
        lblContactAddressTitle = New Label()
        lblContactPhoneVal = New Label()
        lblContactPhoneTitle = New Label()
        lblContactEmailVal = New Label()
        lblContactEmailTitle = New Label()
        pnlContactSep = New Panel()
        lblContactTitle = New Label()
        lblContactIcon = New Label()
        pnlAccountCard = New Panel()
        lblAccountCreatedVal = New Label()
        lblAccountCreatedTitle = New Label()
        lblAccountStatusBadge = New Label()
        lblAccountStatusTitle = New Label()
        btnChangePassword = New Button()
        lblAccountPasswordVal = New Label()
        lblAccountPasswordTitle = New Label()
        lblAccountUsernameVal = New Label()
        lblAccountUsernameTitle = New Label()
        pnlAccountSep = New Panel()
        lblAccountTitle = New Label()
        lblAccountIcon = New Label()
        pnlSpacer = New Panel()
        pnlSummaryCard = New Panel()
        btnEditProfile = New Button()
        lblCollege = New Label()
        lblCourseFull = New Label()
        lblStatusBadge = New Label()
        lblStudentNoVal = New Label()
        lblStudentNoLabel = New Label()
        lblStudentName = New Label()
        picAvatar = New PictureBox()
        pnlHeader = New Panel()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlScrollContent.SuspendLayout()
        tlpCards.SuspendLayout()
        pnlPersonalCard.SuspendLayout()
        pnlAcademicCard.SuspendLayout()
        pnlContactCard.SuspendLayout()
        pnlAccountCard.SuspendLayout()
        pnlSummaryCard.SuspendLayout()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(15, 39, 74)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(btnNavProfile)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavMyClearance)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 780)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavLogout.Location = New Point(0, 736)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(20, 0, 0, 0)
        btnNavLogout.Size = New Size(220, 44)
        btnNavLogout.TabIndex = 4
        btnNavLogout.Text = "  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavProfile
        ' 
        btnNavProfile.BackColor = Color.FromArgb(28, 91, 184)
        btnNavProfile.Cursor = Cursors.Hand
        btnNavProfile.Dock = DockStyle.Top
        btnNavProfile.FlatAppearance.BorderSize = 0
        btnNavProfile.FlatStyle = FlatStyle.Flat
        btnNavProfile.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavProfile.ForeColor = Color.White
        btnNavProfile.Location = New Point(0, 164)
        btnNavProfile.Name = "btnNavProfile"
        btnNavProfile.Padding = New Padding(20, 0, 0, 0)
        btnNavProfile.Size = New Size(220, 44)
        btnNavProfile.TabIndex = 3
        btnNavProfile.Text = "  Profile"
        btnNavProfile.TextAlign = ContentAlignment.MiddleLeft
        btnNavProfile.UseVisualStyleBackColor = False
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.Cursor = Cursors.Hand
        btnNavHistory.Dock = DockStyle.Top
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavHistory.Location = New Point(0, 120)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(20, 0, 0, 0)
        btnNavHistory.Size = New Size(220, 44)
        btnNavHistory.TabIndex = 2
        btnNavHistory.Text = "  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = True
        ' 
        ' btnNavMyClearance
        ' 
        btnNavMyClearance.Cursor = Cursors.Hand
        btnNavMyClearance.Dock = DockStyle.Top
        btnNavMyClearance.FlatAppearance.BorderSize = 0
        btnNavMyClearance.FlatStyle = FlatStyle.Flat
        btnNavMyClearance.Font = New Font("Segoe UI", 9.5F)
        btnNavMyClearance.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavMyClearance.Location = New Point(0, 76)
        btnNavMyClearance.Name = "btnNavMyClearance"
        btnNavMyClearance.Padding = New Padding(20, 0, 0, 0)
        btnNavMyClearance.Size = New Size(220, 44)
        btnNavMyClearance.TabIndex = 1
        btnNavMyClearance.Text = "  My Clearance"
        btnNavMyClearance.TextAlign = ContentAlignment.MiddleLeft
        btnNavMyClearance.UseVisualStyleBackColor = True
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoSubtitle)
        pnlLogo.Controls.Add(picSchoolLogo)
        pnlLogo.Controls.Add(lblLogoTitle)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 76)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoSubtitle
        ' 
        lblLogoSubtitle.AutoSize = True
        lblLogoSubtitle.Font = New Font("Segoe UI", 8.0F)
        lblLogoSubtitle.ForeColor = Color.FromArgb(148, 163, 184)
        lblLogoSubtitle.Location = New Point(68, 41)
        lblLogoSubtitle.Name = "lblLogoSubtitle"
        lblLogoSubtitle.Size = New Size(77, 13)
        lblLogoSubtitle.TabIndex = 2
        lblLogoSubtitle.Text = "Student Portal"
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(16, 16)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(42, 42)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' lblLogoTitle
        ' 
        lblLogoTitle.AutoSize = True
        lblLogoTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblLogoTitle.ForeColor = Color.White
        lblLogoTitle.Location = New Point(67, 19)
        lblLogoTitle.Name = "lblLogoTitle"
        lblLogoTitle.Size = New Size(89, 21)
        lblLogoTitle.TabIndex = 1
        lblLogoTitle.Text = "EClearance"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(248, 250, 252)
        pnlMain.Controls.Add(pnlScrollContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(980, 780)
        pnlMain.TabIndex = 1
        ' 
        ' pnlScrollContent
        ' 
        pnlScrollContent.AutoScroll = True
        pnlScrollContent.Controls.Add(tlpCards)
        pnlScrollContent.Controls.Add(pnlSpacer)
        pnlScrollContent.Controls.Add(pnlSummaryCard)
        pnlScrollContent.Dock = DockStyle.Fill
        pnlScrollContent.Location = New Point(0, 72)
        pnlScrollContent.Name = "pnlScrollContent"
        pnlScrollContent.Padding = New Padding(28, 8, 28, 28)
        pnlScrollContent.Size = New Size(980, 708)
        pnlScrollContent.TabIndex = 1
        ' 
        ' tlpCards
        ' 
        tlpCards.AutoSize = True
        tlpCards.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpCards.ColumnCount = 2
        tlpCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        tlpCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        tlpCards.Controls.Add(pnlPersonalCard, 0, 0)
        tlpCards.Controls.Add(pnlAcademicCard, 1, 0)
        tlpCards.Controls.Add(pnlContactCard, 0, 1)
        tlpCards.Controls.Add(pnlAccountCard, 1, 1)
        tlpCards.Dock = DockStyle.Top
        tlpCards.Location = New Point(28, 146)
        tlpCards.Name = "tlpCards"
        tlpCards.RowCount = 2
        tlpCards.RowStyles.Add(New RowStyle())
        tlpCards.RowStyles.Add(New RowStyle())
        tlpCards.Size = New Size(924, 604)
        tlpCards.TabIndex = 2
        ' 
        ' pnlPersonalCard
        ' 
        pnlPersonalCard.BackColor = Color.White
        pnlPersonalCard.Controls.Add(lblPersonalCivilStatusVal)
        pnlPersonalCard.Controls.Add(lblPersonalCivilStatusTitle)
        pnlPersonalCard.Controls.Add(lblPersonalFullNameVal)
        pnlPersonalCard.Controls.Add(lblPersonalFullNameTitle)
        pnlPersonalCard.Controls.Add(pnlPersonalSep)
        pnlPersonalCard.Controls.Add(lblPersonalTitle)
        pnlPersonalCard.Controls.Add(lblPersonalIcon)
        pnlPersonalCard.Dock = DockStyle.Fill
        pnlPersonalCard.Location = New Point(0, 0)
        pnlPersonalCard.Margin = New Padding(0, 0, 10, 16)
        pnlPersonalCard.Name = "pnlPersonalCard"
        pnlPersonalCard.Padding = New Padding(20, 16, 20, 18)
        pnlPersonalCard.Size = New Size(452, 286)
        pnlPersonalCard.TabIndex = 0
        ' 
        ' lblPersonalCivilStatusVal
        ' 
        lblPersonalCivilStatusVal.AutoSize = True
        lblPersonalCivilStatusVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPersonalCivilStatusVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblPersonalCivilStatusVal.Location = New Point(170, 96)
        lblPersonalCivilStatusVal.Name = "lblPersonalCivilStatusVal"
        lblPersonalCivilStatusVal.Size = New Size(44, 17)
        lblPersonalCivilStatusVal.TabIndex = 6
        lblPersonalCivilStatusVal.Text = "Single"
        ' 
        ' lblPersonalCivilStatusTitle
        ' 
        lblPersonalCivilStatusTitle.AutoSize = True
        lblPersonalCivilStatusTitle.Font = New Font("Segoe UI", 9.0F)
        lblPersonalCivilStatusTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblPersonalCivilStatusTitle.Location = New Point(20, 97)
        lblPersonalCivilStatusTitle.Name = "lblPersonalCivilStatusTitle"
        lblPersonalCivilStatusTitle.Size = New Size(65, 15)
        lblPersonalCivilStatusTitle.TabIndex = 5
        lblPersonalCivilStatusTitle.Text = "Civil Status"
        ' 
        ' lblPersonalFullNameVal
        ' 
        lblPersonalFullNameVal.AutoSize = True
        lblPersonalFullNameVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPersonalFullNameVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblPersonalFullNameVal.Location = New Point(170, 62)
        lblPersonalFullNameVal.Name = "lblPersonalFullNameVal"
        lblPersonalFullNameVal.Size = New Size(94, 17)
        lblPersonalFullNameVal.TabIndex = 4
        lblPersonalFullNameVal.Text = "Juan Dela Cruz"
        ' 
        ' lblPersonalFullNameTitle
        ' 
        lblPersonalFullNameTitle.AutoSize = True
        lblPersonalFullNameTitle.Font = New Font("Segoe UI", 9.0F)
        lblPersonalFullNameTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblPersonalFullNameTitle.Location = New Point(20, 63)
        lblPersonalFullNameTitle.Name = "lblPersonalFullNameTitle"
        lblPersonalFullNameTitle.Size = New Size(61, 15)
        lblPersonalFullNameTitle.TabIndex = 3
        lblPersonalFullNameTitle.Text = "Full Name"
        ' 
        ' pnlPersonalSep
        ' 
        pnlPersonalSep.BackColor = Color.FromArgb(241, 245, 249)
        pnlPersonalSep.Location = New Point(20, 46)
        pnlPersonalSep.Name = "pnlPersonalSep"
        pnlPersonalSep.Size = New Size(412, 1)
        pnlPersonalSep.TabIndex = 2
        ' 
        ' lblPersonalTitle
        ' 
        lblPersonalTitle.AutoSize = True
        lblPersonalTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblPersonalTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblPersonalTitle.Location = New Point(44, 16)
        lblPersonalTitle.Name = "lblPersonalTitle"
        lblPersonalTitle.Size = New Size(142, 19)
        lblPersonalTitle.TabIndex = 1
        lblPersonalTitle.Text = "Personal Information"
        ' 
        ' lblPersonalIcon
        ' 
        lblPersonalIcon.Font = New Font("Segoe UI", 11.0F)
        lblPersonalIcon.ForeColor = Color.FromArgb(28, 91, 184)
        lblPersonalIcon.Location = New Point(18, 14)
        lblPersonalIcon.Name = "lblPersonalIcon"
        lblPersonalIcon.Size = New Size(24, 22)
        lblPersonalIcon.TabIndex = 0
        lblPersonalIcon.Text = "👤"
        ' 
        ' pnlAcademicCard
        ' 
        pnlAcademicCard.BackColor = Color.White
        pnlAcademicCard.Controls.Add(lblAcademicTermVal)
        pnlAcademicCard.Controls.Add(lblAcademicTermTitle)
        pnlAcademicCard.Controls.Add(lblAcademicYearVal)
        pnlAcademicCard.Controls.Add(lblAcademicYearTitle)
        pnlAcademicCard.Controls.Add(lblAcademicCollegeVal)
        pnlAcademicCard.Controls.Add(lblAcademicCollegeTitle)
        pnlAcademicCard.Controls.Add(lblAcademicStudentTypeVal)
        pnlAcademicCard.Controls.Add(lblAcademicStudentTypeTitle)
        pnlAcademicCard.Controls.Add(lblAcademicSectionVal)
        pnlAcademicCard.Controls.Add(lblAcademicSectionTitle)
        pnlAcademicCard.Controls.Add(lblAcademicYearLevelVal)
        pnlAcademicCard.Controls.Add(lblAcademicYearLevelTitle)
        pnlAcademicCard.Controls.Add(lblAcademicCourseVal)
        pnlAcademicCard.Controls.Add(lblAcademicCourseTitle)
        pnlAcademicCard.Controls.Add(lblAcademicStudentNoVal)
        pnlAcademicCard.Controls.Add(lblAcademicStudentNoTitle)
        pnlAcademicCard.Controls.Add(pnlAcademicSep)
        pnlAcademicCard.Controls.Add(lblAcademicTitle)
        pnlAcademicCard.Controls.Add(lblAcademicIcon)
        pnlAcademicCard.Dock = DockStyle.Fill
        pnlAcademicCard.Location = New Point(472, 0)
        pnlAcademicCard.Margin = New Padding(10, 0, 0, 16)
        pnlAcademicCard.Name = "pnlAcademicCard"
        pnlAcademicCard.Padding = New Padding(20, 16, 20, 18)
        pnlAcademicCard.Size = New Size(452, 286)
        pnlAcademicCard.TabIndex = 1
        ' 
        ' lblAcademicTermVal
        ' 
        lblAcademicTermVal.AutoSize = True
        lblAcademicTermVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicTermVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicTermVal.Location = New Point(170, 252)
        lblAcademicTermVal.Name = "lblAcademicTermVal"
        lblAcademicTermVal.Size = New Size(88, 17)
        lblAcademicTermVal.TabIndex = 18
        lblAcademicTermVal.Text = "1st Semester"
        ' 
        ' lblAcademicTermTitle
        ' 
        lblAcademicTermTitle.AutoSize = True
        lblAcademicTermTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicTermTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicTermTitle.Location = New Point(20, 253)
        lblAcademicTermTitle.Name = "lblAcademicTermTitle"
        lblAcademicTermTitle.Size = New Size(33, 15)
        lblAcademicTermTitle.TabIndex = 17
        lblAcademicTermTitle.Text = "Term"
        ' 
        ' lblAcademicYearVal
        ' 
        lblAcademicYearVal.AutoSize = True
        lblAcademicYearVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicYearVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicYearVal.Location = New Point(170, 224)
        lblAcademicYearVal.Name = "lblAcademicYearVal"
        lblAcademicYearVal.Size = New Size(80, 17)
        lblAcademicYearVal.TabIndex = 16
        lblAcademicYearVal.Text = "2024 - 2025"
        ' 
        ' lblAcademicYearTitle
        ' 
        lblAcademicYearTitle.AutoSize = True
        lblAcademicYearTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicYearTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicYearTitle.Location = New Point(20, 225)
        lblAcademicYearTitle.Name = "lblAcademicYearTitle"
        lblAcademicYearTitle.Size = New Size(86, 15)
        lblAcademicYearTitle.TabIndex = 15
        lblAcademicYearTitle.Text = "Academic Year"
        ' 
        ' lblAcademicCollegeVal
        ' 
        lblAcademicCollegeVal.AutoSize = True
        lblAcademicCollegeVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicCollegeVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicCollegeVal.Location = New Point(170, 196)
        lblAcademicCollegeVal.Name = "lblAcademicCollegeVal"
        lblAcademicCollegeVal.Size = New Size(181, 17)
        lblAcademicCollegeVal.TabIndex = 14
        lblAcademicCollegeVal.Text = "College of Computer Studies"
        ' 
        ' lblAcademicCollegeTitle
        ' 
        lblAcademicCollegeTitle.AutoSize = True
        lblAcademicCollegeTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicCollegeTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicCollegeTitle.Location = New Point(20, 197)
        lblAcademicCollegeTitle.Name = "lblAcademicCollegeTitle"
        lblAcademicCollegeTitle.Size = New Size(47, 15)
        lblAcademicCollegeTitle.TabIndex = 13
        lblAcademicCollegeTitle.Text = "College"
        ' 
        ' lblAcademicStudentTypeVal
        ' 
        lblAcademicStudentTypeVal.AutoSize = True
        lblAcademicStudentTypeVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicStudentTypeVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicStudentTypeVal.Location = New Point(170, 168)
        lblAcademicStudentTypeVal.Name = "lblAcademicStudentTypeVal"
        lblAcademicStudentTypeVal.Size = New Size(30, 17)
        lblAcademicStudentTypeVal.TabIndex = 12
        lblAcademicStudentTypeVal.Text = "Old"
        ' 
        ' lblAcademicStudentTypeTitle
        ' 
        lblAcademicStudentTypeTitle.AutoSize = True
        lblAcademicStudentTypeTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicStudentTypeTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicStudentTypeTitle.Location = New Point(20, 169)
        lblAcademicStudentTypeTitle.Name = "lblAcademicStudentTypeTitle"
        lblAcademicStudentTypeTitle.Size = New Size(76, 15)
        lblAcademicStudentTypeTitle.TabIndex = 11
        lblAcademicStudentTypeTitle.Text = "Student Type"
        ' 
        ' lblAcademicSectionVal
        ' 
        lblAcademicSectionVal.AutoSize = True
        lblAcademicSectionVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicSectionVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicSectionVal.Location = New Point(170, 140)
        lblAcademicSectionVal.Name = "lblAcademicSectionVal"
        lblAcademicSectionVal.Size = New Size(54, 17)
        lblAcademicSectionVal.TabIndex = 10
        lblAcademicSectionVal.Text = "BSIT 2A"
        ' 
        ' lblAcademicSectionTitle
        ' 
        lblAcademicSectionTitle.AutoSize = True
        lblAcademicSectionTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicSectionTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicSectionTitle.Location = New Point(20, 141)
        lblAcademicSectionTitle.Name = "lblAcademicSectionTitle"
        lblAcademicSectionTitle.Size = New Size(46, 15)
        lblAcademicSectionTitle.TabIndex = 9
        lblAcademicSectionTitle.Text = "Section"
        ' 
        ' lblAcademicYearLevelVal
        ' 
        lblAcademicYearLevelVal.AutoSize = True
        lblAcademicYearLevelVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicYearLevelVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicYearLevelVal.Location = New Point(170, 112)
        lblAcademicYearLevelVal.Name = "lblAcademicYearLevelVal"
        lblAcademicYearLevelVal.Size = New Size(58, 17)
        lblAcademicYearLevelVal.TabIndex = 8
        lblAcademicYearLevelVal.Text = "2nd Year"
        ' 
        ' lblAcademicYearLevelTitle
        ' 
        lblAcademicYearLevelTitle.AutoSize = True
        lblAcademicYearLevelTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicYearLevelTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicYearLevelTitle.Location = New Point(20, 113)
        lblAcademicYearLevelTitle.Name = "lblAcademicYearLevelTitle"
        lblAcademicYearLevelTitle.Size = New Size(60, 15)
        lblAcademicYearLevelTitle.TabIndex = 7
        lblAcademicYearLevelTitle.Text = "Year Level"
        ' 
        ' lblAcademicCourseVal
        ' 
        lblAcademicCourseVal.AutoSize = True
        lblAcademicCourseVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicCourseVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicCourseVal.Location = New Point(170, 84)
        lblAcademicCourseVal.Name = "lblAcademicCourseVal"
        lblAcademicCourseVal.Size = New Size(160, 17)
        lblAcademicCourseVal.TabIndex = 6
        lblAcademicCourseVal.Text = "BS Information Technology"
        ' 
        ' lblAcademicCourseTitle
        ' 
        lblAcademicCourseTitle.AutoSize = True
        lblAcademicCourseTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicCourseTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicCourseTitle.Location = New Point(20, 85)
        lblAcademicCourseTitle.Name = "lblAcademicCourseTitle"
        lblAcademicCourseTitle.Size = New Size(99, 15)
        lblAcademicCourseTitle.TabIndex = 5
        lblAcademicCourseTitle.Text = "Course / Program"
        ' 
        ' lblAcademicStudentNoVal
        ' 
        lblAcademicStudentNoVal.AutoSize = True
        lblAcademicStudentNoVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAcademicStudentNoVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAcademicStudentNoVal.Location = New Point(170, 56)
        lblAcademicStudentNoVal.Name = "lblAcademicStudentNoVal"
        lblAcademicStudentNoVal.Size = New Size(77, 17)
        lblAcademicStudentNoVal.TabIndex = 4
        lblAcademicStudentNoVal.Text = "2023-00123"
        ' 
        ' lblAcademicStudentNoTitle
        ' 
        lblAcademicStudentNoTitle.AutoSize = True
        lblAcademicStudentNoTitle.Font = New Font("Segoe UI", 9.0F)
        lblAcademicStudentNoTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAcademicStudentNoTitle.Location = New Point(20, 57)
        lblAcademicStudentNoTitle.Name = "lblAcademicStudentNoTitle"
        lblAcademicStudentNoTitle.Size = New Size(94, 15)
        lblAcademicStudentNoTitle.TabIndex = 3
        lblAcademicStudentNoTitle.Text = "Student Number"
        ' 
        ' pnlAcademicSep
        ' 
        pnlAcademicSep.BackColor = Color.FromArgb(241, 245, 249)
        pnlAcademicSep.Location = New Point(20, 44)
        pnlAcademicSep.Name = "pnlAcademicSep"
        pnlAcademicSep.Size = New Size(412, 1)
        pnlAcademicSep.TabIndex = 2
        ' 
        ' lblAcademicTitle
        ' 
        lblAcademicTitle.AutoSize = True
        lblAcademicTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblAcademicTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblAcademicTitle.Location = New Point(44, 16)
        lblAcademicTitle.Name = "lblAcademicTitle"
        lblAcademicTitle.Size = New Size(149, 19)
        lblAcademicTitle.TabIndex = 1
        lblAcademicTitle.Text = "Academic Information"
        ' 
        ' lblAcademicIcon
        ' 
        lblAcademicIcon.Font = New Font("Segoe UI", 11.0F)
        lblAcademicIcon.ForeColor = Color.FromArgb(28, 91, 184)
        lblAcademicIcon.Location = New Point(18, 14)
        lblAcademicIcon.Name = "lblAcademicIcon"
        lblAcademicIcon.Size = New Size(24, 22)
        lblAcademicIcon.TabIndex = 0
        lblAcademicIcon.Text = "🎓"
        ' 
        ' pnlContactCard
        ' 
        pnlContactCard.BackColor = Color.White
        pnlContactCard.Controls.Add(lblContactRelationshipVal)
        pnlContactCard.Controls.Add(lblContactRelationshipTitle)
        pnlContactCard.Controls.Add(lblContactEmergencyPhoneVal)
        pnlContactCard.Controls.Add(lblContactEmergencyPhoneTitle)
        pnlContactCard.Controls.Add(lblContactEmergencyNameVal)
        pnlContactCard.Controls.Add(lblContactEmergencyNameTitle)
        pnlContactCard.Controls.Add(lblContactAddressVal)
        pnlContactCard.Controls.Add(lblContactAddressTitle)
        pnlContactCard.Controls.Add(lblContactPhoneVal)
        pnlContactCard.Controls.Add(lblContactPhoneTitle)
        pnlContactCard.Controls.Add(lblContactEmailVal)
        pnlContactCard.Controls.Add(lblContactEmailTitle)
        pnlContactCard.Controls.Add(pnlContactSep)
        pnlContactCard.Controls.Add(lblContactTitle)
        pnlContactCard.Controls.Add(lblContactIcon)
        pnlContactCard.Dock = DockStyle.Fill
        pnlContactCard.Location = New Point(0, 302)
        pnlContactCard.Margin = New Padding(0, 0, 10, 16)
        pnlContactCard.Name = "pnlContactCard"
        pnlContactCard.Padding = New Padding(20, 16, 20, 18)
        pnlContactCard.Size = New Size(452, 286)
        pnlContactCard.TabIndex = 2
        ' 
        ' lblContactRelationshipVal
        ' 
        lblContactRelationshipVal.AutoSize = True
        lblContactRelationshipVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactRelationshipVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactRelationshipVal.Location = New Point(180, 240)
        lblContactRelationshipVal.Name = "lblContactRelationshipVal"
        lblContactRelationshipVal.Size = New Size(52, 17)
        lblContactRelationshipVal.TabIndex = 14
        lblContactRelationshipVal.Text = "Mother"
        ' 
        ' lblContactRelationshipTitle
        ' 
        lblContactRelationshipTitle.AutoSize = True
        lblContactRelationshipTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactRelationshipTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactRelationshipTitle.Location = New Point(20, 241)
        lblContactRelationshipTitle.Name = "lblContactRelationshipTitle"
        lblContactRelationshipTitle.Size = New Size(72, 15)
        lblContactRelationshipTitle.TabIndex = 13
        lblContactRelationshipTitle.Text = "Relationship"
        ' 
        ' lblContactEmergencyPhoneVal
        ' 
        lblContactEmergencyPhoneVal.AutoSize = True
        lblContactEmergencyPhoneVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactEmergencyPhoneVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactEmergencyPhoneVal.Location = New Point(180, 208)
        lblContactEmergencyPhoneVal.Name = "lblContactEmergencyPhoneVal"
        lblContactEmergencyPhoneVal.Size = New Size(100, 17)
        lblContactEmergencyPhoneVal.TabIndex = 12
        lblContactEmergencyPhoneVal.Text = "09XX XXX XXXX"
        ' 
        ' lblContactEmergencyPhoneTitle
        ' 
        lblContactEmergencyPhoneTitle.AutoSize = True
        lblContactEmergencyPhoneTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactEmergencyPhoneTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactEmergencyPhoneTitle.Location = New Point(20, 209)
        lblContactEmergencyPhoneTitle.Name = "lblContactEmergencyPhoneTitle"
        lblContactEmergencyPhoneTitle.Size = New Size(150, 15)
        lblContactEmergencyPhoneTitle.TabIndex = 11
        lblContactEmergencyPhoneTitle.Text = "Emergency Contact Number"
        ' 
        ' lblContactEmergencyNameVal
        ' 
        lblContactEmergencyNameVal.AutoSize = True
        lblContactEmergencyNameVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactEmergencyNameVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactEmergencyNameVal.Location = New Point(180, 176)
        lblContactEmergencyNameVal.Name = "lblContactEmergencyNameVal"
        lblContactEmergencyNameVal.Size = New Size(99, 17)
        lblContactEmergencyNameVal.TabIndex = 10
        lblContactEmergencyNameVal.Text = "Maria Dela Cruz"
        ' 
        ' lblContactEmergencyNameTitle
        ' 
        lblContactEmergencyNameTitle.AutoSize = True
        lblContactEmergencyNameTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactEmergencyNameTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactEmergencyNameTitle.Location = New Point(20, 177)
        lblContactEmergencyNameTitle.Name = "lblContactEmergencyNameTitle"
        lblContactEmergencyNameTitle.Size = New Size(143, 15)
        lblContactEmergencyNameTitle.TabIndex = 9
        lblContactEmergencyNameTitle.Text = "Emergency Contact Person"
        ' 
        ' lblContactAddressVal
        ' 
        lblContactAddressVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactAddressVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactAddressVal.Location = New Point(180, 122)
        lblContactAddressVal.Name = "lblContactAddressVal"
        lblContactAddressVal.Size = New Size(250, 46)
        lblContactAddressVal.TabIndex = 8
        lblContactAddressVal.Text = "House No., Street, Barangay, City, Province"
        ' 
        ' lblContactAddressTitle
        ' 
        lblContactAddressTitle.AutoSize = True
        lblContactAddressTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactAddressTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactAddressTitle.Location = New Point(20, 123)
        lblContactAddressTitle.Name = "lblContactAddressTitle"
        lblContactAddressTitle.Size = New Size(92, 15)
        lblContactAddressTitle.TabIndex = 7
        lblContactAddressTitle.Text = "Current Address"
        ' 
        ' lblContactPhoneVal
        ' 
        lblContactPhoneVal.AutoSize = True
        lblContactPhoneVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactPhoneVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactPhoneVal.Location = New Point(180, 90)
        lblContactPhoneVal.Name = "lblContactPhoneVal"
        lblContactPhoneVal.Size = New Size(100, 17)
        lblContactPhoneVal.TabIndex = 6
        lblContactPhoneVal.Text = "09XX XXX XXXX"
        ' 
        ' lblContactPhoneTitle
        ' 
        lblContactPhoneTitle.AutoSize = True
        lblContactPhoneTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactPhoneTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactPhoneTitle.Location = New Point(20, 91)
        lblContactPhoneTitle.Name = "lblContactPhoneTitle"
        lblContactPhoneTitle.Size = New Size(94, 15)
        lblContactPhoneTitle.TabIndex = 5
        lblContactPhoneTitle.Text = "Contact Number"
        ' 
        ' lblContactEmailVal
        ' 
        lblContactEmailVal.AutoSize = True
        lblContactEmailVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblContactEmailVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblContactEmailVal.Location = New Point(180, 58)
        lblContactEmailVal.Name = "lblContactEmailVal"
        lblContactEmailVal.Size = New Size(157, 17)
        lblContactEmailVal.TabIndex = 4
        lblContactEmailVal.Text = "juan.delacruz@email.com"
        ' 
        ' lblContactEmailTitle
        ' 
        lblContactEmailTitle.AutoSize = True
        lblContactEmailTitle.Font = New Font("Segoe UI", 9.0F)
        lblContactEmailTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblContactEmailTitle.Location = New Point(20, 59)
        lblContactEmailTitle.Name = "lblContactEmailTitle"
        lblContactEmailTitle.Size = New Size(81, 15)
        lblContactEmailTitle.TabIndex = 3
        lblContactEmailTitle.Text = "Email Address"
        ' 
        ' pnlContactSep
        ' 
        pnlContactSep.BackColor = Color.FromArgb(241, 245, 249)
        pnlContactSep.Location = New Point(20, 44)
        pnlContactSep.Name = "pnlContactSep"
        pnlContactSep.Size = New Size(412, 1)
        pnlContactSep.TabIndex = 2
        ' 
        ' lblContactTitle
        ' 
        lblContactTitle.AutoSize = True
        lblContactTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblContactTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblContactTitle.Location = New Point(44, 16)
        lblContactTitle.Name = "lblContactTitle"
        lblContactTitle.Size = New Size(135, 19)
        lblContactTitle.TabIndex = 1
        lblContactTitle.Text = "Contact Information"
        ' 
        ' lblContactIcon
        ' 
        lblContactIcon.Font = New Font("Segoe UI", 11.0F)
        lblContactIcon.ForeColor = Color.FromArgb(28, 91, 184)
        lblContactIcon.Location = New Point(18, 14)
        lblContactIcon.Name = "lblContactIcon"
        lblContactIcon.Size = New Size(24, 22)
        lblContactIcon.TabIndex = 0
        lblContactIcon.Text = "📞"
        ' 
        ' pnlAccountCard
        ' 
        pnlAccountCard.BackColor = Color.White
        pnlAccountCard.Controls.Add(lblAccountCreatedVal)
        pnlAccountCard.Controls.Add(lblAccountCreatedTitle)
        pnlAccountCard.Controls.Add(lblAccountStatusBadge)
        pnlAccountCard.Controls.Add(lblAccountStatusTitle)
        pnlAccountCard.Controls.Add(btnChangePassword)
        pnlAccountCard.Controls.Add(lblAccountPasswordVal)
        pnlAccountCard.Controls.Add(lblAccountPasswordTitle)
        pnlAccountCard.Controls.Add(lblAccountUsernameVal)
        pnlAccountCard.Controls.Add(lblAccountUsernameTitle)
        pnlAccountCard.Controls.Add(pnlAccountSep)
        pnlAccountCard.Controls.Add(lblAccountTitle)
        pnlAccountCard.Controls.Add(lblAccountIcon)
        pnlAccountCard.Dock = DockStyle.Fill
        pnlAccountCard.Location = New Point(472, 302)
        pnlAccountCard.Margin = New Padding(10, 0, 0, 16)
        pnlAccountCard.Name = "pnlAccountCard"
        pnlAccountCard.Padding = New Padding(20, 16, 20, 18)
        pnlAccountCard.Size = New Size(452, 286)
        pnlAccountCard.TabIndex = 3
        ' 
        ' lblAccountCreatedVal
        ' 
        lblAccountCreatedVal.AutoSize = True
        lblAccountCreatedVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAccountCreatedVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAccountCreatedVal.Location = New Point(170, 164)
        lblAccountCreatedVal.Name = "lblAccountCreatedVal"
        lblAccountCreatedVal.Size = New Size(166, 17)
        lblAccountCreatedVal.TabIndex = 10
        lblAccountCreatedVal.Text = "September 26, 2025 3:45 PM"
        ' 
        ' lblAccountCreatedTitle
        ' 
        lblAccountCreatedTitle.AutoSize = True
        lblAccountCreatedTitle.Font = New Font("Segoe UI", 9.0F)
        lblAccountCreatedTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAccountCreatedTitle.Location = New Point(20, 165)
        lblAccountCreatedTitle.Name = "lblAccountCreatedTitle"
        lblAccountCreatedTitle.Size = New Size(62, 15)
        lblAccountCreatedTitle.TabIndex = 9
        lblAccountCreatedTitle.Text = "Last Login"
        ' 
        ' lblAccountStatusBadge
        ' 
        lblAccountStatusBadge.AutoSize = True
        lblAccountStatusBadge.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAccountStatusBadge.ForeColor = Color.FromArgb(22, 101, 52)
        lblAccountStatusBadge.Location = New Point(170, 128)
        lblAccountStatusBadge.Name = "lblAccountStatusBadge"
        lblAccountStatusBadge.Size = New Size(44, 17)
        lblAccountStatusBadge.TabIndex = 8
        lblAccountStatusBadge.Text = "Active"
        ' 
        ' lblAccountStatusTitle
        ' 
        lblAccountStatusTitle.AutoSize = True
        lblAccountStatusTitle.Font = New Font("Segoe UI", 9.0F)
        lblAccountStatusTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAccountStatusTitle.Location = New Point(20, 129)
        lblAccountStatusTitle.Name = "lblAccountStatusTitle"
        lblAccountStatusTitle.Size = New Size(87, 15)
        lblAccountStatusTitle.TabIndex = 7
        lblAccountStatusTitle.Text = "Account Status"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.FromArgb(235, 243, 252)
        btnChangePassword.Cursor = Cursors.Hand
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(191, 219, 254)
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnChangePassword.ForeColor = Color.FromArgb(28, 91, 184)
        btnChangePassword.Location = New Point(280, 88)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(125, 26)
        btnChangePassword.TabIndex = 6
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' lblAccountPasswordVal
        ' 
        lblAccountPasswordVal.AutoSize = True
        lblAccountPasswordVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAccountPasswordVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAccountPasswordVal.Location = New Point(170, 93)
        lblAccountPasswordVal.Name = "lblAccountPasswordVal"
        lblAccountPasswordVal.Size = New Size(78, 17)
        lblAccountPasswordVal.TabIndex = 5
        lblAccountPasswordVal.Text = "************"
        ' 
        ' lblAccountPasswordTitle
        ' 
        lblAccountPasswordTitle.AutoSize = True
        lblAccountPasswordTitle.Font = New Font("Segoe UI", 9.0F)
        lblAccountPasswordTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAccountPasswordTitle.Location = New Point(20, 94)
        lblAccountPasswordTitle.Name = "lblAccountPasswordTitle"
        lblAccountPasswordTitle.Size = New Size(57, 15)
        lblAccountPasswordTitle.TabIndex = 4
        lblAccountPasswordTitle.Text = "Password"
        ' 
        ' lblAccountUsernameVal
        ' 
        lblAccountUsernameVal.AutoSize = True
        lblAccountUsernameVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAccountUsernameVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblAccountUsernameVal.Location = New Point(170, 58)
        lblAccountUsernameVal.Name = "lblAccountUsernameVal"
        lblAccountUsernameVal.Size = New Size(52, 17)
        lblAccountUsernameVal.TabIndex = 3
        lblAccountUsernameVal.Text = "juan123"
        ' 
        ' lblAccountUsernameTitle
        ' 
        lblAccountUsernameTitle.AutoSize = True
        lblAccountUsernameTitle.Font = New Font("Segoe UI", 9.0F)
        lblAccountUsernameTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblAccountUsernameTitle.Location = New Point(20, 59)
        lblAccountUsernameTitle.Name = "lblAccountUsernameTitle"
        lblAccountUsernameTitle.Size = New Size(60, 15)
        lblAccountUsernameTitle.TabIndex = 2
        lblAccountUsernameTitle.Text = "Username"
        ' 
        ' pnlAccountSep
        ' 
        pnlAccountSep.BackColor = Color.FromArgb(241, 245, 249)
        pnlAccountSep.Location = New Point(20, 44)
        pnlAccountSep.Name = "pnlAccountSep"
        pnlAccountSep.Size = New Size(412, 1)
        pnlAccountSep.TabIndex = 1
        ' 
        ' lblAccountTitle
        ' 
        lblAccountTitle.AutoSize = True
        lblAccountTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblAccountTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblAccountTitle.Location = New Point(44, 16)
        lblAccountTitle.Name = "lblAccountTitle"
        lblAccountTitle.Size = New Size(137, 19)
        lblAccountTitle.TabIndex = 1
        lblAccountTitle.Text = "Account Information"
        ' 
        ' lblAccountIcon
        ' 
        lblAccountIcon.Font = New Font("Segoe UI", 11.0F)
        lblAccountIcon.ForeColor = Color.FromArgb(28, 91, 184)
        lblAccountIcon.Location = New Point(18, 14)
        lblAccountIcon.Name = "lblAccountIcon"
        lblAccountIcon.Size = New Size(24, 22)
        lblAccountIcon.TabIndex = 0
        lblAccountIcon.Text = "⚙"
        ' 
        ' pnlSpacer
        ' 
        pnlSpacer.Dock = DockStyle.Top
        pnlSpacer.Location = New Point(28, 130)
        pnlSpacer.Name = "pnlSpacer"
        pnlSpacer.Size = New Size(924, 16)
        pnlSpacer.TabIndex = 1
        ' 
        ' pnlSummaryCard
        ' 
        pnlSummaryCard.BackColor = Color.White
        pnlSummaryCard.Controls.Add(btnEditProfile)
        pnlSummaryCard.Controls.Add(lblCollege)
        pnlSummaryCard.Controls.Add(lblCourseFull)
        pnlSummaryCard.Controls.Add(lblStatusBadge)
        pnlSummaryCard.Controls.Add(lblStudentNoVal)
        pnlSummaryCard.Controls.Add(lblStudentNoLabel)
        pnlSummaryCard.Controls.Add(lblStudentName)
        pnlSummaryCard.Controls.Add(picAvatar)
        pnlSummaryCard.Dock = DockStyle.Top
        pnlSummaryCard.Location = New Point(28, 8)
        pnlSummaryCard.Name = "pnlSummaryCard"
        pnlSummaryCard.Padding = New Padding(20, 16, 20, 16)
        pnlSummaryCard.Size = New Size(924, 122)
        pnlSummaryCard.TabIndex = 0
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEditProfile.BackColor = Color.FromArgb(28, 91, 184)
        btnEditProfile.Cursor = Cursors.Hand
        btnEditProfile.FlatAppearance.BorderSize = 0
        btnEditProfile.FlatStyle = FlatStyle.Flat
        btnEditProfile.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.White
        btnEditProfile.Location = New Point(788, 20)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(116, 36)
        btnEditProfile.TabIndex = 7
        btnEditProfile.Text = "✎  Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' lblCollege
        ' 
        lblCollege.AutoSize = True
        lblCollege.Font = New Font("Segoe UI", 9.0F)
        lblCollege.ForeColor = Color.FromArgb(100, 116, 139)
        lblCollege.Location = New Point(122, 90)
        lblCollege.Name = "lblCollege"
        lblCollege.Size = New Size(155, 15)
        lblCollege.TabIndex = 6
        lblCollege.Text = "College of Computer Studies"
        ' 
        ' lblCourseFull
        ' 
        lblCourseFull.AutoSize = True
        lblCourseFull.Font = New Font("Segoe UI", 9.5F)
        lblCourseFull.ForeColor = Color.FromArgb(51, 65, 85)
        lblCourseFull.Location = New Point(122, 69)
        lblCourseFull.Name = "lblCourseFull"
        lblCourseFull.Size = New Size(160, 17)
        lblCourseFull.TabIndex = 5
        lblCourseFull.Text = "BS Information Technology"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.AutoSize = True
        lblStatusBadge.BackColor = Color.FromArgb(220, 252, 231)
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52)
        lblStatusBadge.Location = New Point(286, 47)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Padding = New Padding(6, 2, 6, 2)
        lblStatusBadge.Size = New Size(49, 17)
        lblStatusBadge.TabIndex = 4
        lblStatusBadge.Text = "Active"
        ' 
        ' lblStudentNoVal
        ' 
        lblStudentNoVal.AutoSize = True
        lblStudentNoVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStudentNoVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblStudentNoVal.Location = New Point(216, 47)
        lblStudentNoVal.Name = "lblStudentNoVal"
        lblStudentNoVal.Size = New Size(62, 17)
        lblStudentNoVal.TabIndex = 3
        lblStudentNoVal.Text = "1237-24"
        ' 
        ' lblStudentNoLabel
        ' 
        lblStudentNoLabel.AutoSize = True
        lblStudentNoLabel.Font = New Font("Segoe UI", 9.5F)
        lblStudentNoLabel.ForeColor = Color.FromArgb(71, 85, 105)
        lblStudentNoLabel.Location = New Point(122, 47)
        lblStudentNoLabel.Name = "lblStudentNoLabel"
        lblStudentNoLabel.Size = New Size(94, 17)
        lblStudentNoLabel.TabIndex = 2
        lblStudentNoLabel.Text = "Student Number:"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI Bold", 15.0F, FontStyle.Bold)
        lblStudentName.ForeColor = Color.FromArgb(15, 39, 74)
        lblStudentName.Location = New Point(120, 16)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(149, 28)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Juan Dela Cruz"
        ' 
        ' picAvatar
        ' 
        picAvatar.Location = New Point(20, 16)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(88, 88)
        picAvatar.TabIndex = 0
        picAvatar.TabStop = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(28, 14, 28, 12)
        pnlHeader.Size = New Size(980, 72)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(28, 41)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(393, 17)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "View your personal information, academic details, and contact information."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Bold", 18.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblHeaderTitle.Location = New Point(26, 9)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(130, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "My Profile"
        ' 
        ' StudentProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(248, 250, 252)
        ClientSize = New Size(1200, 780)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F)
        MinimumSize = New Size(900, 600)
        Name = "StudentProfileForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Student Portal"
        pnlSidebar.ResumeLayout(False)
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlScrollContent.ResumeLayout(False)
        pnlScrollContent.PerformLayout()
        tlpCards.ResumeLayout(False)
        pnlPersonalCard.ResumeLayout(False)
        pnlPersonalCard.PerformLayout()
        pnlAcademicCard.ResumeLayout(False)
        pnlAcademicCard.PerformLayout()
        pnlContactCard.ResumeLayout(False)
        pnlContactCard.PerformLayout()
        pnlAccountCard.ResumeLayout(False)
        pnlAccountCard.PerformLayout()
        pnlSummaryCard.ResumeLayout(False)
        pnlSummaryCard.PerformLayout()
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picSchoolLogo As PictureBox
    Friend WithEvents lblLogoTitle As Label
    Friend WithEvents lblLogoSubtitle As Label
    Friend WithEvents btnNavMyClearance As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavProfile As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlScrollContent As Panel
    Friend WithEvents pnlSummaryCard As Panel
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentNoLabel As Label
    Friend WithEvents lblStudentNoVal As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents lblCourseFull As Label
    Friend WithEvents lblCollege As Label
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents pnlSpacer As Panel
    Friend WithEvents tlpCards As TableLayoutPanel
    Friend WithEvents pnlPersonalCard As Panel
    Friend WithEvents lblPersonalIcon As Label
    Friend WithEvents lblPersonalTitle As Label
    Friend WithEvents pnlPersonalSep As Panel
    Friend WithEvents lblPersonalFullNameTitle As Label
    Friend WithEvents lblPersonalFullNameVal As Label
    Friend WithEvents lblPersonalCivilStatusTitle As Label
    Friend WithEvents lblPersonalCivilStatusVal As Label
    Friend WithEvents pnlAcademicCard As Panel
    Friend WithEvents lblAcademicIcon As Label
    Friend WithEvents lblAcademicTitle As Label
    Friend WithEvents pnlAcademicSep As Panel
    Friend WithEvents lblAcademicStudentNoTitle As Label
    Friend WithEvents lblAcademicStudentNoVal As Label
    Friend WithEvents lblAcademicCourseTitle As Label
    Friend WithEvents lblAcademicCourseVal As Label
    Friend WithEvents lblAcademicYearLevelTitle As Label
    Friend WithEvents lblAcademicYearLevelVal As Label
    Friend WithEvents lblAcademicSectionTitle As Label
    Friend WithEvents lblAcademicSectionVal As Label
    Friend WithEvents lblAcademicStudentTypeTitle As Label
    Friend WithEvents lblAcademicStudentTypeVal As Label
    Friend WithEvents lblAcademicCollegeTitle As Label
    Friend WithEvents lblAcademicCollegeVal As Label
    Friend WithEvents lblAcademicYearTitle As Label
    Friend WithEvents lblAcademicYearVal As Label
    Friend WithEvents lblAcademicTermTitle As Label
    Friend WithEvents lblAcademicTermVal As Label
    Friend WithEvents pnlContactCard As Panel
    Friend WithEvents lblContactIcon As Label
    Friend WithEvents lblContactTitle As Label
    Friend WithEvents pnlContactSep As Panel
    Friend WithEvents lblContactEmailTitle As Label
    Friend WithEvents lblContactEmailVal As Label
    Friend WithEvents lblContactPhoneTitle As Label
    Friend WithEvents lblContactPhoneVal As Label
    Friend WithEvents lblContactAddressTitle As Label
    Friend WithEvents lblContactAddressVal As Label
    Friend WithEvents lblContactEmergencyNameTitle As Label
    Friend WithEvents lblContactEmergencyNameVal As Label
    Friend WithEvents lblContactEmergencyPhoneTitle As Label
    Friend WithEvents lblContactEmergencyPhoneVal As Label
    Friend WithEvents lblContactRelationshipTitle As Label
    Friend WithEvents lblContactRelationshipVal As Label
    Friend WithEvents pnlAccountCard As Panel
    Friend WithEvents lblAccountIcon As Label
    Friend WithEvents lblAccountTitle As Label
    Friend WithEvents pnlAccountSep As Panel
    Friend WithEvents lblAccountUsernameTitle As Label
    Friend WithEvents lblAccountUsernameVal As Label
    Friend WithEvents lblAccountPasswordTitle As Label
    Friend WithEvents lblAccountPasswordVal As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents lblAccountStatusTitle As Label
    Friend WithEvents lblAccountStatusBadge As Label
    Friend WithEvents lblAccountCreatedTitle As Label
    Friend WithEvents lblAccountCreatedVal As Label
End Class
