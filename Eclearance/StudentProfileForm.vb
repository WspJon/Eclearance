Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class StudentProfileForm

    Private ReadOnly db As New DatabaseHelper()

    Private activeTermID As Integer = 0
    Private activeAcademicYear As String = ""
    Private activeSemester As String = ""

    Private Sub StudentProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySchoolLogo(picSchoolLogo)
        LoadActiveTerm()
        LoadProfileData()
    End Sub

    Private Sub LoadActiveTerm()
        Try
            Dim dt As DataTable = db.ExecuteQuery("SELECT TermID, AcademicYear, Semester FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
            If dt.Rows.Count > 0 Then
                activeTermID = Convert.ToInt32(dt.Rows(0)("TermID"))
                activeAcademicYear = If(IsDBNull(dt.Rows(0)("AcademicYear")), "", dt.Rows(0)("AcademicYear").ToString())
                activeSemester = If(IsDBNull(dt.Rows(0)("Semester")), "", dt.Rows(0)("Semester").ToString())
            End If
        Catch
        End Try
    End Sub

    Public Sub LoadProfileData()
        If activeTermID = 0 OrElse String.IsNullOrWhiteSpace(activeAcademicYear) Then
            LoadActiveTerm()
        End If
        Try
            Dim queryUser As String =
                "SELECT UserID, Username, FullName, StudentNo, Course, Section, YearLevel, StudentType, " &
                "       ContactNo, Email, Address, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, " &
                "       IsActive, CreatedAt " &
                "FROM Users WHERE UserID = @UserID LIMIT 1;"

            Dim dtUser As DataTable = db.ExecuteQuery(queryUser, New Dictionary(Of String, Object) From {
                {"@UserID", AppSession.UserID}
            })

            If dtUser.Rows.Count = 0 Then
                Return
            End If

            Dim uRow As DataRow = dtUser.Rows(0)

            ' Try to get Guidance profile for active academic year first
            Dim gRow As DataRow = Nothing
            If Not String.IsNullOrWhiteSpace(activeAcademicYear) Then
                Dim qGuidance As String =
                    "SELECT Address, ContactNo, Email, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, UpdatedAt " &
                    "FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear ORDER BY GuidanceProfileID DESC LIMIT 1;"
                Dim dtG As DataTable = db.ExecuteQuery(qGuidance, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID},
                    {"@AcademicYear", activeAcademicYear}
                })
                If dtG.Rows.Count > 0 Then
                    gRow = dtG.Rows(0)
                End If
            End If

            ' Fallback to latest guidance profile if none for active year
            If gRow Is Nothing Then
                Dim qLatest As String =
                    "SELECT Address, ContactNo, Email, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, UpdatedAt " &
                    "FROM GuidanceStudentProfiles WHERE StudentID = @StudentID ORDER BY GuidanceProfileID DESC LIMIT 1;"
                Dim dtL As DataTable = db.ExecuteQuery(qLatest, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID}
                })
                If dtL.Rows.Count > 0 Then
                    gRow = dtL.Rows(0)
                End If
            End If

            ' Sourced values (prefer guidance profile, fallback to Users table)
            Dim fullName As String = If(IsDBNull(uRow("FullName")), "", uRow("FullName").ToString().Trim())
            Dim studentNo As String = If(IsDBNull(uRow("StudentNo")), "", uRow("StudentNo").ToString().Trim())
            Dim courseCode As String = If(IsDBNull(uRow("Course")), "", uRow("Course").ToString().Trim())
            Dim yearLevel As String = If(IsDBNull(uRow("YearLevel")), "", uRow("YearLevel").ToString().Trim())
            Dim section As String = If(IsDBNull(uRow("Section")), "", uRow("Section").ToString().Trim())
            Dim studentType As String = If(IsDBNull(uRow("StudentType")), "", uRow("StudentType").ToString().Trim())
            Dim username As String = If(IsDBNull(uRow("Username")), "", uRow("Username").ToString().Trim())

            Dim email As String = GetBestValue(gRow, uRow, "Email")
            Dim contactNo As String = GetBestValue(gRow, uRow, "ContactNo")
            Dim address As String = GetBestValue(gRow, uRow, "Address")
            Dim civilStatus As String = GetBestValue(gRow, uRow, "CivilStatus")
            Dim emergencyName As String = GetBestValue(gRow, uRow, "EmergencyContactName")
            Dim emergencyPhone As String = GetBestValue(gRow, uRow, "EmergencyContactNo")
            Dim relationship As String = GetBestValue(gRow, uRow, "Relationship")

            Dim fullCourseName As String = GetFullCourseName(courseCode)
            Dim collegeName As String = GetCollegeName(courseCode)

            ' 1. Top Summary Card
            lblStudentName.Text = If(String.IsNullOrWhiteSpace(fullName), "Student", fullName)
            lblStudentNoVal.Text = If(String.IsNullOrWhiteSpace(studentNo), "Not assigned", studentNo)

            ' Position Student No and Status Badge next to each other
            lblStudentNoVal.Location = New Point(lblStudentNoLabel.Right + 4, lblStudentNoLabel.Top)
            lblStatusBadge.Location = New Point(lblStudentNoVal.Right + 12, lblStudentNoLabel.Top)

            Dim isActiveUser As Boolean = True
            If Not IsDBNull(uRow("IsActive")) Then
                isActiveUser = Convert.ToBoolean(uRow("IsActive"))
            End If

            If isActiveUser Then
                lblStatusBadge.Text = "Active"
                lblStatusBadge.BackColor = Color.FromArgb(220, 252, 231)
                lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52)
            Else
                lblStatusBadge.Text = "Inactive"
                lblStatusBadge.BackColor = Color.FromArgb(241, 245, 249)
                lblStatusBadge.ForeColor = Color.FromArgb(100, 116, 139)
            End If

            lblCourseFull.Text = fullCourseName
            lblCollege.Text = collegeName

            ' 2. Personal Information Card
            SetFieldValue(lblPersonalFullNameVal, fullName)
            SetFieldValue(lblPersonalCivilStatusVal, civilStatus)

            ' 3. Academic Information Card
            SetFieldValue(lblAcademicStudentNoVal, studentNo)
            SetFieldValue(lblAcademicCourseVal, fullCourseName)
            SetFieldValue(lblAcademicYearLevelVal, yearLevel)
            SetFieldValue(lblAcademicSectionVal, section)
            SetFieldValue(lblAcademicStudentTypeVal, If(String.IsNullOrWhiteSpace(studentType), "Regular", studentType))
            SetFieldValue(lblAcademicCollegeVal, collegeName)
            SetFieldValue(lblAcademicYearVal, If(String.IsNullOrWhiteSpace(activeAcademicYear), "2024 - 2025", activeAcademicYear))
            SetFieldValue(lblAcademicTermVal, If(String.IsNullOrWhiteSpace(activeSemester), "1st Semester", activeSemester))

            ' 4. Contact Information Card
            SetFieldValue(lblContactEmailVal, email)
            SetFieldValue(lblContactPhoneVal, contactNo)
            SetFieldValue(lblContactAddressVal, address)
            SetFieldValue(lblContactEmergencyNameVal, emergencyName)
            SetFieldValue(lblContactEmergencyPhoneVal, emergencyPhone)
            SetFieldValue(lblContactRelationshipVal, relationship)

            ' 5. Account Information Card
            SetFieldValue(lblAccountUsernameVal, username)
            lblAccountPasswordVal.Text = "************"
            lblAccountStatusBadge.Text = If(isActiveUser, "Active", "Inactive")
            lblAccountStatusBadge.ForeColor = If(isActiveUser, Color.FromArgb(22, 101, 52), Color.FromArgb(100, 116, 139))

            If Not IsDBNull(uRow("CreatedAt")) Then
                Try
                    Dim dtCreated As DateTime = Convert.ToDateTime(uRow("CreatedAt"))
                    lblAccountCreatedVal.Text = dtCreated.ToString("MMMM d, yyyy h:mm tt")
                Catch
                    lblAccountCreatedVal.Text = "Active"
                End Try
            Else
                lblAccountCreatedVal.Text = DateTime.Now.ToString("MMMM d, yyyy")
            End If

            picAvatar.Invalidate()

        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetBestValue(gRow As DataRow, uRow As DataRow, colName As String) As String
        If gRow IsNot Nothing AndAlso Not IsDBNull(gRow(colName)) AndAlso Not String.IsNullOrWhiteSpace(gRow(colName).ToString()) Then
            Return gRow(colName).ToString().Trim()
        End If
        If uRow IsNot Nothing AndAlso Not IsDBNull(uRow(colName)) AndAlso Not String.IsNullOrWhiteSpace(uRow(colName).ToString()) Then
            Return uRow(colName).ToString().Trim()
        End If
        Return ""
    End Function

    Private Sub SetFieldValue(lbl As Label, val As String)
        If String.IsNullOrWhiteSpace(val) Then
            lbl.Text = "Not provided"
            lbl.ForeColor = Color.FromArgb(148, 163, 184)
            lbl.Font = New Font(lbl.Font, FontStyle.Italic)
        Else
            lbl.Text = val
            lbl.ForeColor = Color.FromArgb(15, 23, 42)
            lbl.Font = New Font(lbl.Font, FontStyle.Bold)
        End If
    End Sub

    Private Function GetFullCourseName(courseCode As String) As String
        If String.IsNullOrWhiteSpace(courseCode) Then Return "Not assigned"
        Select Case courseCode.Trim().ToUpperInvariant()
            Case "BSIT"
                Return "BS Information Technology"
            Case "BSCPE"
                Return "BS Computer Engineering"
            Case "BSBA"
                Return "BS Business Administration"
            Case "BSA"
                Return "BS Accountancy"
            Case "BSTM"
                Return "BS Tourism Management"
            Case "BSHM"
                Return "BS Hospitality Management"
            Case "CTHM"
                Return "Certificate in Tourism & Hospitality Management"
            Case Else
                Return courseCode
        End Select
    End Function

    Private Function GetCollegeName(courseCode As String) As String
        If String.IsNullOrWhiteSpace(courseCode) Then Return "Academic Department"
        Select Case courseCode.Trim().ToUpperInvariant()
            Case "BSIT"
                Return "College of Computer Studies"
            Case "BSCPE"
                Return "College of Engineering & Computer Studies"
            Case "BSBA"
                Return "College of Business Administration"
            Case "BSA"
                Return "College of Accountancy"
            Case "BSTM", "BSHM", "CTHM"
                Return "College of Tourism & Hospitality Management"
            Case Else
                Return "College of Academic Studies"
        End Select
    End Function

    ' ============================================================
    ' AVATAR PAINTING
    ' ============================================================
    Private Sub picAvatar_Paint(sender As Object, e As PaintEventArgs) Handles picAvatar.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As Rectangle = picAvatar.ClientRectangle
        rect.Inflate(-2, -2)

        ' Outer circle background
        Using brushBg As New SolidBrush(Color.FromArgb(226, 232, 240))
            g.FillEllipse(brushBg, 2, 2, 80, 80)
        End Using

        ' Silhouette head
        Using brushSil As New SolidBrush(Color.FromArgb(148, 163, 184))
            g.FillEllipse(brushSil, 30, 16, 24, 24)

            ' Silhouette shoulders (arc/polygon)
            Using path As New GraphicsPath()
                path.AddArc(16, 44, 52, 52, 180, 180)
                path.CloseFigure()
                g.FillPath(brushSil, path)
            End Using
        End Using

        ' Camera overlay badge at bottom-right
        Dim badgeRect As New Rectangle(54, 54, 26, 26)
        Using brushBadge As New SolidBrush(Color.FromArgb(28, 91, 184))
            g.FillEllipse(brushBadge, badgeRect)
        End Using
        Using penWhite As New Pen(Color.White, 2)
            g.DrawEllipse(penWhite, badgeRect)
        End Using

        ' Small camera glyph inside badge
        Using brushCam As New SolidBrush(Color.White)
            g.FillRectangle(brushCam, 60, 64, 14, 9)
            g.FillRectangle(brushCam, 64, 62, 6, 3)
            Using penCam As New Pen(Color.FromArgb(28, 91, 184), 1.5F)
                g.DrawEllipse(penCam, 64, 66, 6, 5)
            End Using
        End Using
    End Sub

    ' ============================================================
    ' CARD BORDER PAINTING (MODERN FIGMA / WEB LOOK)
    ' ============================================================
    Private Sub DrawCardBorder(sender As Object, e As PaintEventArgs) Handles _
        pnlSummaryCard.Paint, pnlPersonalCard.Paint, pnlAcademicCard.Paint, pnlContactCard.Paint, pnlAccountCard.Paint

        Dim pnl As Panel = CType(sender, Panel)
        Dim rect As Rectangle = pnl.ClientRectangle
        rect.Width -= 1
        rect.Height -= 1

        Using penBorder As New Pen(Color.FromArgb(226, 232, 240), 1)
            e.Graphics.DrawRectangle(penBorder, rect)
        End Using
    End Sub

    ' ============================================================
    ' ACTIONS: EDIT PROFILE & CHANGE PASSWORD
    ' ============================================================
    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Try
            Dim guidanceStatus As String = "Pending"
            Dim instructions As String = "Please review and complete/update your Guidance student profile information."

            Dim qRec As String =
                "SELECT cr.Status, r.Instructions " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "WHERE cr.StudentID = @StudentID " &
                "  AND (r.DepartmentID = 6 OR r.RequirementName LIKE '%Guidance%') " &
                "LIMIT 1;"
            Dim dtRec As DataTable = db.ExecuteQuery(qRec, New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID}
            })

            If dtRec.Rows.Count > 0 Then
                If Not IsDBNull(dtRec.Rows(0)("Status")) Then
                    guidanceStatus = dtRec.Rows(0)("Status").ToString()
                End If
                If Not IsDBNull(dtRec.Rows(0)("Instructions")) Then
                    instructions = dtRec.Rows(0)("Instructions").ToString()
                End If
            End If

            Using modal As New ViewRequirementModalForm()
                modal.DepartmentName = "Guidance Office"
                modal.RequirementName = "Student Information Sheet / Guidance Profile"
                modal.SequenceOrder = 1
                modal.EffectiveStatus = guidanceStatus
                modal.InstructionsText = instructions
                modal.RequiresFile = False
                modal.RequirementLink = ""
                modal.IsGuidanceOffice = True
                modal.AcademicYear = activeAcademicYear
                modal.TermID = activeTermID

                modal.ShowDialog(Me)
            End Using

            LoadProfileData()

        Catch ex As Exception
            MessageBox.Show("Unable to open Guidance Information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Using modal As New ChangePasswordModalForm()
            modal.ShowDialog(Me)
        End Using
    End Sub

    ' ============================================================
    ' SIDEBAR NAVIGATION (FOR STANDALONE MODE)
    ' ============================================================
    Private Sub btnNavMyClearance_Click(sender As Object, e As EventArgs) Handles btnNavMyClearance.Click
        Dim parentStudentForm As StudentClearanceForm = TryCast(Me.ParentForm, StudentClearanceForm)
        If parentStudentForm IsNot Nothing Then
            parentStudentForm.ShowMyClearanceView()
        Else
            Dim frm As New StudentClearanceForm()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavHistory_Click(sender As Object, e As EventArgs) Handles btnNavHistory.Click
        Dim parentStudentForm As StudentClearanceForm = TryCast(Me.ParentForm, StudentClearanceForm)
        If parentStudentForm IsNot Nothing Then
            parentStudentForm.ShowHistoryView()
        Else
            Dim histForm As New ClearanceHistoryForm()
            histForm.StudentIDFilter = AppSession.UserID
            histForm.StudentNameFilter = AppSession.FullName
            histForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavLogout_Click(sender As Object, e As EventArgs) Handles btnNavLogout.Click
        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If answer = DialogResult.Yes Then
            AppSession.Clear()
            Dim parentForm As Form = Me.ParentForm
            If parentForm IsNot Nothing Then
                parentForm.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub

End Class
