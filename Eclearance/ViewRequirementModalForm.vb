Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ViewRequirementModalForm

    Private ReadOnly db As New DatabaseHelper()

    Public Property DepartmentName As String = ""
    Public Property RequirementName As String = ""
    Public Property SequenceOrder As Integer = 0
    Public Property EffectiveStatus As String = "Pending"
    Public Property InstructionsText As String = ""
    Public Property RequiresFile As Boolean = True
    Public Property RequirementLink As String = ""
    Public Property IsGuidanceOffice As Boolean = False
    Public Property AcademicYear As String = ""
    Public Property TermID As Integer = 0

    Private Sub ViewRequirementModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblModalHeader.Text = If(String.IsNullOrWhiteSpace(DepartmentName), "Requirement Instructions", DepartmentName & " - Instructions")
        lblRequirementTitle.Text = RequirementName
        lblStepOrder.Text = "Step " & SequenceOrder.ToString()
        lblStatusBadge.Text = EffectiveStatus

        ApplyStatusStyle(lblStatusBadge, EffectiveStatus)

        lblInstructionsValue.Text = If(String.IsNullOrWhiteSpace(InstructionsText), "No special instructions provided.", InstructionsText)

        If RequiresFile Then
            lblProofValue.Text = "Document / image file upload is required (PDF, JPG, PNG under 10MB)."
        Else
            lblProofValue.Text = "No document upload required for this office."
        End If

        ' External Link / Survey
        If Not String.IsNullOrWhiteSpace(RequirementLink) Then
            pnlLinkSection.Visible = True
            btnOpenLink.Tag = RequirementLink
        Else
            pnlLinkSection.Visible = False
        End If

        ' Guidance Personal Information Section
        If IsGuidanceOffice Then
            pnlGuidanceSection.Visible = True
            LoadGuidanceStudentInfo()

            ' Under Review or Cleared: do not allow editing
            Dim canEdit As Boolean = (EffectiveStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse EffectiveStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase))
            btnSaveGuidanceInfo.Enabled = canEdit
            If Not canEdit Then
                btnSaveGuidanceInfo.BackColor = Color.FromArgb(203, 213, 225)
                btnSaveGuidanceInfo.Text = "Information Submitted (" & EffectiveStatus & ")"
                txtContactNo.ReadOnly = True
                txtEmail.ReadOnly = True
                txtAddress.ReadOnly = True
                cmbCivilStatus.Enabled = False
                txtEmergencyContactName.ReadOnly = True
                cmbRelationship.Enabled = False
                txtEmergencyContactNo.ReadOnly = True
                txtAdditionalNotes.ReadOnly = True
            End If
        Else
            pnlGuidanceSection.Visible = False
        End If
    End Sub

    Private Sub ApplyStatusStyle(lbl As Label, status As String)
        Select Case status.ToLowerInvariant()
            Case "cleared"
                lbl.BackColor = Color.FromArgb(220, 252, 231)
                lbl.ForeColor = Color.FromArgb(22, 101, 52)
            Case "under review"
                lbl.BackColor = Color.FromArgb(219, 234, 254)
                lbl.ForeColor = Color.FromArgb(30, 64, 175)
            Case "rejected"
                lbl.BackColor = Color.FromArgb(254, 226, 226)
                lbl.ForeColor = Color.FromArgb(185, 28, 28)
            Case "locked"
                lbl.BackColor = Color.FromArgb(241, 245, 249)
                lbl.ForeColor = Color.FromArgb(100, 116, 139)
            Case "not applicable"
                lbl.BackColor = Color.FromArgb(243, 244, 246)
                lbl.ForeColor = Color.FromArgb(107, 114, 128)
            Case Else
                lbl.BackColor = Color.FromArgb(254, 243, 199)
                lbl.ForeColor = Color.FromArgb(146, 64, 14)
        End Select
    End Sub

    Private Sub EnsureActiveTermInfo()
        If String.IsNullOrWhiteSpace(AcademicYear) OrElse TermID <= 0 Then
            Try
                Dim dtTerm As DataTable = db.ExecuteQuery("SELECT TermID, AcademicYear FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
                If dtTerm.Rows.Count > 0 Then
                    TermID = Convert.ToInt32(dtTerm.Rows(0)("TermID"))
                    AcademicYear = dtTerm.Rows(0)("AcademicYear").ToString()
                End If
            Catch
            End Try
            If String.IsNullOrWhiteSpace(AcademicYear) Then AcademicYear = "2026-2027"
        End If
    End Sub

    Private Sub LoadGuidanceStudentInfo()
        Try
            EnsureActiveTermInfo()

            ' 1. Check if profile exists for current student & active academic year
            Dim thisYearQuery As String =
                "SELECT * FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear LIMIT 1;"
            Dim dtThisYear = db.ExecuteQuery(thisYearQuery, New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID},
                {"@AcademicYear", AcademicYear}
            })

            Dim hasExistingData As Boolean = False
            Dim sourceRow As DataRow = Nothing

            If dtThisYear.Rows.Count > 0 Then
                sourceRow = dtThisYear.Rows(0)
                hasExistingData = True
            Else
                ' 2. Try latest previous academic year
                Dim prevQuery As String =
                    "SELECT * FROM GuidanceStudentProfiles WHERE StudentID = @StudentID ORDER BY CreatedAt DESC, GuidanceProfileID DESC LIMIT 1;"
                Dim dtPrev = db.ExecuteQuery(prevQuery, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID}
                })
                If dtPrev.Rows.Count > 0 Then
                    sourceRow = dtPrev.Rows(0)
                    hasExistingData = True
                Else
                    ' 3. Fallback to Users table for backwards compatibility
                    Dim userQuery As String =
                        "SELECT ContactNo, Email, Address, CivilStatus, EmergencyContactName, Relationship, EmergencyContactNo, AdditionalNotes " &
                        "FROM Users WHERE UserID = @UserID LIMIT 1;"
                    Dim dtUser = db.ExecuteQuery(userQuery, New Dictionary(Of String, Object) From {{"@UserID", AppSession.UserID}})
                    If dtUser.Rows.Count > 0 Then
                        sourceRow = dtUser.Rows(0)
                        If Not IsDBNull(sourceRow("ContactNo")) AndAlso Not String.IsNullOrWhiteSpace(sourceRow("ContactNo").ToString()) Then
                            hasExistingData = True
                        End If
                    End If
                End If
            End If

            If sourceRow IsNot Nothing Then
                txtContactNo.Text = If(IsDBNull(sourceRow("ContactNo")), "", sourceRow("ContactNo").ToString())
                txtEmail.Text = If(IsDBNull(sourceRow("Email")), "", sourceRow("Email").ToString())
                txtAddress.Text = If(IsDBNull(sourceRow("Address")), "", sourceRow("Address").ToString())

                Dim civil = If(IsDBNull(sourceRow("CivilStatus")), "", sourceRow("CivilStatus").ToString())
                If Not String.IsNullOrWhiteSpace(civil) Then
                    If Not cmbCivilStatus.Items.Contains(civil) Then
                        cmbCivilStatus.Items.Add(civil)
                    End If
                    cmbCivilStatus.SelectedItem = civil
                Else
                    cmbCivilStatus.SelectedIndex = -1
                End If

                txtEmergencyContactName.Text = If(IsDBNull(sourceRow("EmergencyContactName")), "", sourceRow("EmergencyContactName").ToString())

                Dim rel = If(IsDBNull(sourceRow("Relationship")), "", sourceRow("Relationship").ToString())
                If Not String.IsNullOrWhiteSpace(rel) AndAlso cmbRelationship.Items.Contains(rel) Then
                    cmbRelationship.SelectedItem = rel
                Else
                    cmbRelationship.SelectedIndex = -1
                End If

                txtEmergencyContactNo.Text = If(IsDBNull(sourceRow("EmergencyContactNo")), "", sourceRow("EmergencyContactNo").ToString())
                txtAdditionalNotes.Text = If(IsDBNull(sourceRow("AdditionalNotes")), "", sourceRow("AdditionalNotes").ToString())
            End If

            Dim hasCurrentYearProfile As Boolean = (dtThisYear.Rows.Count > 0)
            If hasCurrentYearProfile Then
                btnSaveGuidanceInfo.Text = "Review / Update Information"
            Else
                btnSaveGuidanceInfo.Text = "Complete Information"
            End If
        Catch ex As Exception
            ' Keep blank fallback
        End Try
    End Sub

    Private Sub btnSaveGuidanceInfo_Click(sender As Object, e As EventArgs) Handles btnSaveGuidanceInfo.Click
        Dim contact = txtContactNo.Text.Trim()
        Dim email = txtEmail.Text.Trim()
        Dim address = txtAddress.Text.Trim()
        Dim civil = If(cmbCivilStatus.SelectedItem, "").ToString().Trim()
        Dim emName = txtEmergencyContactName.Text.Trim()
        Dim relationship = If(cmbRelationship.SelectedItem, "").ToString().Trim()
        Dim emNo = txtEmergencyContactNo.Text.Trim()
        Dim notes = txtAdditionalNotes.Text.Trim()

        ' 1. Validate Student Contact Number: Required, 11 digits, numbers only, starts with 09
        If Not Regex.IsMatch(contact, "^09\d{9}$") Then
            MessageBox.Show("Student contact number must be exactly 11 digits and start with '09' (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        ' 2. Validate Email: Required, basic email format
        If Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid email address (e.g., student@email.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        ' 3. Validate Address: Required, minimum 5 characters
        If address.Length < 5 Then
            MessageBox.Show("Please enter a valid current address (at least 5 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return
        End If

        ' 4. Validate Civil Status: Required selection
        If String.IsNullOrWhiteSpace(civil) OrElse cmbCivilStatus.SelectedIndex < 0 Then
            MessageBox.Show("Please select a Civil Status from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCivilStatus.Focus()
            Return
        End If

        ' 5. Validate Emergency Contact Person: Required, letters/spaces/hyphens/periods/apostrophes
        If String.IsNullOrWhiteSpace(emName) OrElse Not Regex.IsMatch(emName, "^[a-zA-Z\s\.\-']+$") Then
            MessageBox.Show("Please enter a valid emergency contact person name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyContactName.Focus()
            Return
        End If

        ' 6. Validate Relationship: Required selection
        If String.IsNullOrWhiteSpace(relationship) OrElse cmbRelationship.SelectedIndex < 0 Then
            MessageBox.Show("Please select the relationship to the emergency contact person.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRelationship.Focus()
            Return
        End If

        ' 7. Validate Emergency Contact Number: Required, 11 digits, numbers only, starts with 09
        If Not Regex.IsMatch(emNo, "^09\d{9}$") Then
            MessageBox.Show("Emergency contact number must be exactly 11 digits and start with '09' (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyContactNo.Focus()
            Return
        End If

        ' 8. Additional Notes: Max 500 characters
        If notes.Length > 500 Then
            MessageBox.Show("Additional notes cannot exceed 500 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdditionalNotes.Focus()
            Return
        End If

        ' Confirmation Dialog
        Dim confirmResult = MessageBox.Show(
            "Are you sure the information you entered is correct?",
            "Confirm Guidance Information Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            EnsureActiveTermInfo()

            ' Upsert into GuidanceStudentProfiles for active AcademicYear
            Dim saveSql As String =
                "INSERT INTO GuidanceStudentProfiles (StudentID, AcademicYear, TermID, Address, ContactNo, Email, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, AdditionalNotes, CreatedAt, UpdatedAt) " &
                "VALUES (@StudentID, @AcademicYear, @TermID, @Address, @ContactNo, @Email, @CivilStatus, @EmergencyContactName, @EmergencyContactNo, @Relationship, @AdditionalNotes, NOW(), NOW()) " &
                "ON DUPLICATE KEY UPDATE " &
                "  Address = VALUES(Address), " &
                "  ContactNo = VALUES(ContactNo), " &
                "  Email = VALUES(Email), " &
                "  CivilStatus = VALUES(CivilStatus), " &
                "  EmergencyContactName = VALUES(EmergencyContactName), " &
                "  EmergencyContactNo = VALUES(EmergencyContactNo), " &
                "  Relationship = VALUES(Relationship), " &
                "  AdditionalNotes = VALUES(AdditionalNotes), " &
                "  UpdatedAt = NOW();"

            Dim params As New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID},
                {"@AcademicYear", AcademicYear},
                {"@TermID", TermID},
                {"@Address", address},
                {"@ContactNo", contact},
                {"@Email", email},
                {"@CivilStatus", civil},
                {"@EmergencyContactName", emName},
                {"@EmergencyContactNo", emNo},
                {"@Relationship", relationship},
                {"@AdditionalNotes", notes}
            }
            db.ExecuteNonQuery(saveSql, params)

            ' Sync core user info
            Try
                Dim userUpdateSql As String = "UPDATE Users SET ContactNo = @ContactNo, Email = @Email, Address = @Address, GuidanceInfoUpdated = 1 WHERE UserID = @UserID;"
                db.ExecuteNonQuery(userUpdateSql, New Dictionary(Of String, Object) From {
                    {"@ContactNo", contact},
                    {"@Email", email},
                    {"@Address", address},
                    {"@UserID", AppSession.UserID}
                })
            Catch
            End Try

            ' Also update student's active Guidance clearance record to 'Under Review' so staff can review it
            Try
                Dim findRecordSql As String =
                    "SELECT cr.RecordID, cr.Status " &
                    "FROM ClearanceRecords cr " &
                    "INNER JOIN ClearanceRequirements req ON cr.RequirementID = req.RequirementID " &
                    "WHERE cr.StudentID = @StudentID " &
                    "  AND cr.TermID = @TermID " &
                    "  AND (req.DepartmentID = 6 OR req.RequirementName LIKE '%Guidance%') " &
                    "LIMIT 1;"
                Dim dtRecord As DataTable = db.ExecuteQuery(findRecordSql, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID},
                    {"@TermID", TermID}
                })

                If dtRecord.Rows.Count > 0 Then
                    Dim recId As Integer = Convert.ToInt32(dtRecord.Rows(0)("RecordID"))
                    Dim oldStatus As String = dtRecord.Rows(0)("Status").ToString()

                    If oldStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse oldStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        Dim updateRecordSql As String =
                            "UPDATE ClearanceRecords " &
                            "SET Status = 'Under Review', SubmittedAt = NOW() " &
                            "WHERE RecordID = @RecordID;"
                        db.ExecuteNonQuery(updateRecordSql, New Dictionary(Of String, Object) From {{"@RecordID", recId}})

                        ' Log to ClearanceHistory
                        Dim actionType As String = If(oldStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase), "Resubmitted", "Information Submitted")
                        Dim actionRemarks As String = If(oldStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase),
                            "Student corrected and resubmitted guidance information.",
                            "Student submitted yearly guidance information for review.")

                        Dim histSql As String =
                            "INSERT INTO ClearanceHistory (RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks, ActionAt) " &
                            "VALUES (@RecordID, @ActionBy, @ActionType, @OldStatus, 'Under Review', @Remarks, NOW());"

                        db.ExecuteNonQuery(histSql, New Dictionary(Of String, Object) From {
                            {"@RecordID", recId},
                            {"@ActionBy", AppSession.UserID},
                            {"@ActionType", actionType},
                            {"@OldStatus", oldStatus},
                            {"@Remarks", actionRemarks}
                        })

                        EffectiveStatus = "Under Review"
                        lblStatusBadge.Text = "Under Review"
                        ApplyStatusStyle(lblStatusBadge, "Under Review")
                    End If
                End If
            Catch
            End Try

            btnSaveGuidanceInfo.Enabled = False
            btnSaveGuidanceInfo.BackColor = Color.FromArgb(203, 213, 225)
            btnSaveGuidanceInfo.Text = "Information Submitted (Under Review)"
            txtContactNo.ReadOnly = True
            txtEmail.ReadOnly = True
            txtAddress.ReadOnly = True
            cmbCivilStatus.Enabled = False
            txtEmergencyContactName.ReadOnly = True
            cmbRelationship.Enabled = False
            txtEmergencyContactNo.ReadOnly = True
            txtAdditionalNotes.ReadOnly = True

            MessageBox.Show("Student personal information for Academic Year " & AcademicYear & " saved successfully for Guidance records.", "Guidance Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save guidance details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpenLink_Click(sender As Object, e As EventArgs) Handles btnOpenLink.Click
        Dim url As String = If(btnOpenLink.Tag, "").ToString().Trim()
        If Not String.IsNullOrWhiteSpace(url) Then
            Try
                Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
            Catch ex As Exception
                MessageBox.Show("Unable to open the link: " & ex.Message, "Browser Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnDismiss.Click
        Me.Close()
    End Sub

End Class
