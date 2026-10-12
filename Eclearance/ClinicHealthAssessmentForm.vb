Imports System.IO
Imports System.Diagnostics

Public Class ClinicHealthAssessmentForm

    Public Property RecordID As Integer = 0
    Public Property StudentID As Integer = 0
    Public Property TermID As Integer = 0
    Public Property AcademicYear As String = ""
    Public Property IsReadOnly As Boolean = False
    Public Property IsStaffReview As Boolean = False

    Private db As New DatabaseHelper()
    Private _assessmentID As Integer = 0
    Private _isDraft As Boolean = True
    Private _attachedLocalFilePath As String = ""
    Private _existingStoredFilePath As String = ""
    Private _existingOriginalFileName As String = ""
    Private _hasUnsavedChanges As Boolean = False
    Private _isLoading As Boolean = True

    Private Sub ClinicHealthAssessmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True

        If StudentID <= 0 Then StudentID = AppSession.UserID
        If TermID <= 0 Then TermID = GetActiveTermID()
        If String.IsNullOrWhiteSpace(AcademicYear) Then AcademicYear = GetCurrentAcademicYear()

        If Not CanAccessClinicRecord() Then
            MessageBox.Show("Access Denied: This Clinic record is not assigned to you or you are not authorized to view its medical assessment.", "Confidential Medical Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
            Return
        End If
        If IsStaffReview Then IsReadOnly = True

        ' Privacy check: Non-staff students cannot view other students' assessments
        If Not IsStaffReview AndAlso AppSession.Role.Equals("Student", StringComparison.OrdinalIgnoreCase) Then
            If StudentID <> AppSession.UserID Then
                MessageBox.Show("Access Denied: You are not authorized to view another student's health assessment.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.Close()
                Return
            End If
        End If

        ' Privacy check for staff: Only Clinic staff (DepartmentID = 9) can view medical assessments
        If IsStaffReview Then
            If Not AppSession.DepartmentID.HasValue OrElse AppSession.DepartmentID.Value <> 9 Then
                MessageBox.Show("Access Denied: Health assessment responses are confidential and restricted to authorized School Clinic personnel.", "Confidential Medical Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.Close()
                Return
            End If
        End If

        LoadStudentMetadata()
        LoadExistingAssessment()
        LoadExistingFiles()
        ConfigureStatusAndMode()

        _isLoading = False
        _hasUnsavedChanges = False
    End Sub

    Private Function CanAccessClinicRecord(Optional forSaving As Boolean = False) As Boolean
        If RecordID <= 0 OrElse StudentID <= 0 OrElse TermID <= 0 Then Return False
        Dim isStudent As Boolean = AppSession.Role.Equals("Student", StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not IsStaffReview AndAlso StudentID = AppSession.UserID
        Dim isClinicStaff As Boolean = AppSession.Role.Equals("Staff", StringComparison.OrdinalIgnoreCase) AndAlso
                                       IsStaffReview AndAlso AppSession.DepartmentID.HasValue AndAlso AppSession.DepartmentID.Value = 9
        If Not isStudent AndAlso Not isClinicStaff Then Return False
        If forSaving AndAlso (Not isStudent OrElse IsReadOnly) Then Return False

        Try
            Dim sql As String =
                "SELECT cr.RecordID FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN AcademicTerms t ON cr.TermID = t.TermID " &
                "INNER JOIN Users student ON cr.StudentID = student.UserID " &
                "WHERE cr.RecordID = @RecordID AND cr.StudentID = @StudentID AND cr.TermID = @TermID " &
                "AND r.DepartmentID = 9 AND student.Role = 'Student' "
            If isStudent Then sql &= "AND student.IsActive = 1 "
            If isClinicStaff Then
                sql &= "AND EXISTS (SELECT 1 FROM Staff st INNER JOIN Users officer ON st.UserID = officer.UserID " &
                       "WHERE officer.UserID = @ActorID AND officer.Role = 'Staff' AND officer.IsActive = 1 AND st.DepartmentID = 9) " &
                       "AND EXISTS (SELECT 1 FROM ClinicHealthAssessments a WHERE a.RecordID = cr.RecordID " &
                       "AND a.StudentID = cr.StudentID AND a.TermID = cr.TermID AND a.IsDraft = 0) "
            End If
            If forSaving Then sql &= "AND t.IsActive = 1 AND cr.Status IN ('Pending', 'Locked', 'Rejected') "
            Dim records As DataTable = db.ExecuteQuery(sql & "LIMIT 1;", New Dictionary(Of String, Object) From {
                {"@RecordID", RecordID}, {"@StudentID", StudentID}, {"@TermID", TermID}, {"@ActorID", AppSession.UserID}
            })
            Return records.Rows.Count = 1
        Catch
            Return False
        End Try
    End Function

    Private Function GetActiveTermID() As Integer
        Try
            Dim dt = db.ExecuteQuery("SELECT TermID FROM AcademicTerms WHERE IsActive = 1 ORDER BY TermID DESC LIMIT 1;")
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("TermID"))
        Catch
        End Try
        Return 1
    End Function

    Private Function GetCurrentAcademicYear() As String
        Try
            Dim dt = db.ExecuteQuery("SELECT AcademicYear FROM AcademicTerms WHERE IsActive = 1 ORDER BY TermID DESC LIMIT 1;")
            If dt.Rows.Count > 0 Then Return dt.Rows(0)("AcademicYear").ToString()
        Catch
        End Try
        Return "2026-2027"
    End Function

    Private Sub LoadStudentMetadata()
        Try
            Dim sql As String =
                "SELECT u.FullName, COALESCE(s.StudentNo, '') AS StudentNo, " &
                "       COALESCE(s.Course, '') AS Course, COALESCE(s.YearLevel, '') AS YearLevel, " &
                "       COALESCE(t.AcademicYear, '') AS AcademicYear, COALESCE(t.Semester, '') AS Semester " &
                "FROM Users u " &
                "LEFT JOIN Students s ON s.UserID = u.UserID " &
                "LEFT JOIN AcademicTerms t ON t.TermID = @TermID " &
                "WHERE u.UserID = @StudentID LIMIT 1;"

            Dim dt = db.ExecuteQuery(sql, New Dictionary(Of String, Object) From {
                {"@StudentID", StudentID},
                {"@TermID", TermID}
            })

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txtStudentName.Text = row("FullName").ToString()
                txtStudentNo.Text = row("StudentNo").ToString()
                txtCourse.Text = row("Course").ToString()
                txtYearLevel.Text = row("YearLevel").ToString()
                Dim termAY = row("AcademicYear").ToString()
                Dim termSem = row("Semester").ToString()
                txtTerm.Text = "AY " & If(String.IsNullOrWhiteSpace(termAY), AcademicYear, termAY) & " — " & termSem
            Else
                txtStudentName.Text = AppSession.FullName
                txtStudentNo.Text = AppSession.StudentNo
                txtCourse.Text = AppSession.Course
                txtYearLevel.Text = AppSession.YearLevel
                txtTerm.Text = "AY " & AcademicYear
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load student information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadExistingAssessment()
        Try
            Dim query As String =
                "SELECT * FROM ClinicHealthAssessments WHERE RecordID = @RecordID AND StudentID = @StudentID AND TermID = @TermID " &
                If(IsStaffReview, "AND IsDraft = 0 ", "") & "LIMIT 1;"
            Dim dt = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@RecordID", RecordID},
                {"@StudentID", StudentID},
                {"@TermID", TermID}
            })

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                _assessmentID = Convert.ToInt32(row("AssessmentID"))
                _isDraft = Convert.ToBoolean(row("IsDraft"))

                ' Section 2: Medical History
                Dim hasMed = Convert.ToBoolean(row("HasMedicalCondition"))
                If hasMed Then
                    rdoMedHistoryYes.Checked = True
                    txtMedHistoryDetails.Text = If(IsDBNull(row("MedicalConditionDetails")), "", row("MedicalConditionDetails").ToString())
                    txtMedHistoryDetails.Enabled = (Not IsReadOnly)
                Else
                    rdoMedHistoryNo.Checked = True
                    txtMedHistoryDetails.Text = ""
                    txtMedHistoryDetails.Enabled = False
                End If

                ' Section 3: Allergies
                Dim hasAlg = Convert.ToBoolean(row("HasAllergies"))
                If hasAlg Then
                    rdoAllergiesYes.Checked = True
                    txtAllergiesDetails.Text = If(IsDBNull(row("AllergiesDetails")), "", row("AllergiesDetails").ToString())
                    txtAllergiesDetails.Enabled = (Not IsReadOnly)
                Else
                    rdoAllergiesNo.Checked = True
                    txtAllergiesDetails.Text = ""
                    txtAllergiesDetails.Enabled = False
                End If

                ' Section 4: Medications
                Dim hasMedications = Convert.ToBoolean(row("HasMedications"))
                If hasMedications Then
                    rdoMedicationsYes.Checked = True
                    txtMedicationsDetails.Text = If(IsDBNull(row("MedicationsDetails")), "", row("MedicationsDetails").ToString())
                    txtMedicationsDetails.Enabled = (Not IsReadOnly)
                Else
                    rdoMedicationsNo.Checked = True
                    txtMedicationsDetails.Text = ""
                    txtMedicationsDetails.Enabled = False
                End If

                ' Section 5: Health Concerns
                Dim hasConcerns = Convert.ToBoolean(row("HasHealthConcerns"))
                If hasConcerns Then
                    rdoHealthConcernsYes.Checked = True
                    txtHealthConcernsDetails.Text = If(IsDBNull(row("HealthConcernsDetails")), "", row("HealthConcernsDetails").ToString())
                    txtHealthConcernsDetails.Enabled = (Not IsReadOnly)
                Else
                    rdoHealthConcernsNo.Checked = True
                    txtHealthConcernsDetails.Text = ""
                    txtHealthConcernsDetails.Enabled = False
                End If

                ' Section 6: Emergency Contact
                txtEmergencyName.Text = If(IsDBNull(row("EmergencyContactName")), "", row("EmergencyContactName").ToString())
                txtRelationship.Text = If(IsDBNull(row("Relationship")), "", row("Relationship").ToString())
                txtEmergencyContactNo.Text = If(IsDBNull(row("EmergencyContactNo")), "", row("EmergencyContactNo").ToString())

                ' Section 8: Declaration
                chkDeclaration.Checked = Convert.ToBoolean(row("IsConfirmed"))
            Else
                ' Prefill emergency contact from Guidance or Students table
                PrefillEmergencyContact()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading assessment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrefillEmergencyContact()
        Try
            ' 1. Try GuidanceStudentProfiles for current academic year
            Dim gQuery = "SELECT EmergencyContactName, EmergencyContactNo, Relationship FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear LIMIT 1;"
            Dim gDt = db.ExecuteQuery(gQuery, New Dictionary(Of String, Object) From {
                {"@StudentID", StudentID},
                {"@AcademicYear", AcademicYear}
            })

            If gDt.Rows.Count > 0 Then
                Dim gRow = gDt.Rows(0)
                txtEmergencyName.Text = If(IsDBNull(gRow("EmergencyContactName")), "", gRow("EmergencyContactName").ToString())
                txtRelationship.Text = If(IsDBNull(gRow("Relationship")), "", gRow("Relationship").ToString())
                txtEmergencyContactNo.Text = If(IsDBNull(gRow("EmergencyContactNo")), "", gRow("EmergencyContactNo").ToString())
                Return
            End If

            ' 2. Fallback to Students table
            Dim sQuery = "SELECT EmergencyContactName, EmergencyContactNo, Relationship FROM Students WHERE UserID = @StudentID LIMIT 1;"
            Dim sDt = db.ExecuteQuery(sQuery, New Dictionary(Of String, Object) From {{"@StudentID", StudentID}})

            If sDt.Rows.Count > 0 Then
                Dim sRow = sDt.Rows(0)
                txtEmergencyName.Text = If(IsDBNull(sRow("EmergencyContactName")), "", sRow("EmergencyContactName").ToString())
                txtRelationship.Text = If(IsDBNull(sRow("Relationship")), "", sRow("Relationship").ToString())
                txtEmergencyContactNo.Text = If(IsDBNull(sRow("EmergencyContactNo")), "", sRow("EmergencyContactNo").ToString())
            End If
        Catch
        End Try
    End Sub

    Private Sub LoadExistingFiles()
        Try
            Dim filesQuery As String =
                "SELECT StoredFilePath, OriginalFileName FROM ClearanceRecordFiles WHERE RecordID = @RecordID ORDER BY FileID DESC LIMIT 1;"
            Dim dtFiles = db.ExecuteQuery(filesQuery, New Dictionary(Of String, Object) From {{"@RecordID", RecordID}})

            If dtFiles.Rows.Count > 0 Then
                _existingStoredFilePath = dtFiles.Rows(0)("StoredFilePath").ToString()
                _existingOriginalFileName = dtFiles.Rows(0)("OriginalFileName").ToString()

                lblAttachedFileName.Text = _existingOriginalFileName
                lblAttachedFileName.ForeColor = Color.FromArgb(15, 23, 42)
                btnViewDocument.Visible = True
                btnRemoveDocument.Visible = (Not IsReadOnly)
            Else
                ' Check ClearanceRecords directly
                Dim recQuery = "SELECT SubmittedFilePath, SubmittedFileName FROM ClearanceRecords WHERE RecordID = @RecordID LIMIT 1;"
                Dim dtRec = db.ExecuteQuery(recQuery, New Dictionary(Of String, Object) From {{"@RecordID", RecordID}})
                If dtRec.Rows.Count > 0 AndAlso Not IsDBNull(dtRec.Rows(0)("SubmittedFilePath")) Then
                    _existingStoredFilePath = dtRec.Rows(0)("SubmittedFilePath").ToString()
                    _existingOriginalFileName = dtRec.Rows(0)("SubmittedFileName").ToString()

                    lblAttachedFileName.Text = _existingOriginalFileName
                    lblAttachedFileName.ForeColor = Color.FromArgb(15, 23, 42)
                    btnViewDocument.Visible = True
                    btnRemoveDocument.Visible = (Not IsReadOnly)
                Else
                    lblAttachedFileName.Text = "No document attached"
                    lblAttachedFileName.ForeColor = Color.FromArgb(100, 116, 139)
                    btnViewDocument.Visible = False
                    btnRemoveDocument.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ConfigureStatusAndMode()
        Try
            Dim statusSql = "SELECT Status, Remarks FROM ClearanceRecords WHERE RecordID = @RecordID LIMIT 1;"
            Dim dtStatus = db.ExecuteQuery(statusSql, New Dictionary(Of String, Object) From {{"@RecordID", RecordID}})

            Dim status As String = "Pending"
            Dim remarks As String = ""
            If dtStatus.Rows.Count > 0 Then
                status = dtStatus.Rows(0)("Status").ToString()
                remarks = If(IsDBNull(dtStatus.Rows(0)("Remarks")), "", dtStatus.Rows(0)("Remarks").ToString())
            End If

            Select Case status.ToLowerInvariant()
                Case "cleared"
                    lblStatusBadge.Text = "Approved / Cleared"
                    lblStatusBadge.BackColor = Color.FromArgb(220, 252, 231)
                    lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52)
                    IsReadOnly = True

                Case "under review"
                    lblStatusBadge.Text = "Under Review"
                    lblStatusBadge.BackColor = Color.FromArgb(219, 234, 254)
                    lblStatusBadge.ForeColor = Color.FromArgb(30, 64, 175)
                    If Not IsStaffReview Then IsReadOnly = True

                Case "rejected"
                    ' In Clinic, rejected status represents 'Needs Completion'
                    lblStatusBadge.Text = "Needs Completion"
                    lblStatusBadge.BackColor = Color.FromArgb(254, 243, 199)
                    lblStatusBadge.ForeColor = Color.FromArgb(180, 83, 9)

                    pnlRemarksAlert.Visible = True
                    If Not String.IsNullOrWhiteSpace(remarks) Then
                        lblRemarksAlertText.Text = remarks
                    Else
                        lblRemarksAlertText.Text = "The Clinic office has returned this assessment for completion. Please review your answers, provide any requested details or documents, and resubmit."
                    End If
                    btnSubmit.Text = "Resubmit Assessment"

                Case Else
                    If _assessmentID > 0 AndAlso _isDraft Then
                        lblStatusBadge.Text = "Draft Saved"
                        lblStatusBadge.BackColor = Color.FromArgb(241, 245, 249)
                        lblStatusBadge.ForeColor = Color.FromArgb(71, 85, 105)
                    Else
                        lblStatusBadge.Text = "Not Submitted"
                        lblStatusBadge.BackColor = Color.FromArgb(254, 243, 199)
                        lblStatusBadge.ForeColor = Color.FromArgb(180, 83, 9)
                    End If
            End Select

            If IsReadOnly Then
                ApplyReadOnlyMode()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ApplyReadOnlyMode()
        rdoMedHistoryNo.Enabled = False
        rdoMedHistoryYes.Enabled = False
        txtMedHistoryDetails.ReadOnly = True

        rdoAllergiesNo.Enabled = False
        rdoAllergiesYes.Enabled = False
        txtAllergiesDetails.ReadOnly = True

        rdoMedicationsNo.Enabled = False
        rdoMedicationsYes.Enabled = False
        txtMedicationsDetails.ReadOnly = True

        rdoHealthConcernsNo.Enabled = False
        rdoHealthConcernsYes.Enabled = False
        txtHealthConcernsDetails.ReadOnly = True

        txtEmergencyName.ReadOnly = True
        txtRelationship.ReadOnly = True
        txtEmergencyContactNo.ReadOnly = True

        btnAttachDocument.Visible = False
        btnRemoveDocument.Visible = False

        chkDeclaration.Enabled = False

        btnSaveDraft.Visible = False
        btnSubmit.Visible = False
        btnCancel.Text = "Close"
    End Sub

    ' ============================================================
    ' YES / NO QUESTION TOGGLES
    ' ============================================================
    Private Sub rdoMedHistoryYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMedHistoryYes.CheckedChanged
        If IsReadOnly Then Return
        txtMedHistoryDetails.Enabled = rdoMedHistoryYes.Checked
        If Not rdoMedHistoryYes.Checked Then txtMedHistoryDetails.Text = ""
        If Not _isLoading Then _hasUnsavedChanges = True
    End Sub

    Private Sub rdoAllergiesYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllergiesYes.CheckedChanged
        If IsReadOnly Then Return
        txtAllergiesDetails.Enabled = rdoAllergiesYes.Checked
        If Not rdoAllergiesYes.Checked Then txtAllergiesDetails.Text = ""
        If Not _isLoading Then _hasUnsavedChanges = True
    End Sub

    Private Sub rdoMedicationsYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMedicationsYes.CheckedChanged
        If IsReadOnly Then Return
        txtMedicationsDetails.Enabled = rdoMedicationsYes.Checked
        If Not rdoMedicationsYes.Checked Then txtMedicationsDetails.Text = ""
        If Not _isLoading Then _hasUnsavedChanges = True
    End Sub

    Private Sub rdoHealthConcernsYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHealthConcernsYes.CheckedChanged
        If IsReadOnly Then Return
        txtHealthConcernsDetails.Enabled = rdoHealthConcernsYes.Checked
        If Not rdoHealthConcernsYes.Checked Then txtHealthConcernsDetails.Text = ""
        If Not _isLoading Then _hasUnsavedChanges = True
    End Sub

    Private Sub Input_Changed(sender As Object, e As EventArgs) Handles txtEmergencyName.TextChanged,
                                                                        txtRelationship.TextChanged,
                                                                        txtEmergencyContactNo.TextChanged,
                                                                        txtMedHistoryDetails.TextChanged,
                                                                        txtAllergiesDetails.TextChanged,
                                                                        txtMedicationsDetails.TextChanged,
                                                                        txtHealthConcernsDetails.TextChanged,
                                                                        chkDeclaration.CheckedChanged
        If Not _isLoading Then _hasUnsavedChanges = True
    End Sub

    ' ============================================================
    ' DOCUMENT ATTACHMENT
    ' ============================================================
    Private Sub btnAttachDocument_Click(sender As Object, e As EventArgs) Handles btnAttachDocument.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Supporting Medical Document"
            ofd.Filter = "Medical Documents (*.pdf;*.jpg;*.jpeg;*.png)|*.pdf;*.jpg;*.jpeg;*.png|All Files (*.*)|*.*"
            ofd.Multiselect = False

            If ofd.ShowDialog(Me) = DialogResult.OK Then
                Dim fi As New FileInfo(ofd.FileName)

                ' Validate extension
                Dim ext = fi.Extension.ToLowerInvariant()
                If ext <> ".pdf" AndAlso ext <> ".jpg" AndAlso ext <> ".jpeg" AndAlso ext <> ".png" Then
                    MessageBox.Show("Invalid file format. Please upload a PDF or Image (JPG, JPEG, PNG).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Validate size (Max 5MB)
                If fi.Length > 5 * 1024 * 1024 Then
                    MessageBox.Show("The selected file exceeds the 5MB size limit. Please choose a smaller file.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                _attachedLocalFilePath = ofd.FileName
                lblAttachedFileName.Text = fi.Name & " (" & Math.Round(fi.Length / 1024.0, 1) & " KB)"
                lblAttachedFileName.ForeColor = Color.FromArgb(15, 23, 42)
                btnRemoveDocument.Visible = True
                btnViewDocument.Visible = True
                _hasUnsavedChanges = True
            End If
        End Using
    End Sub

    Private Sub btnRemoveDocument_Click(sender As Object, e As EventArgs) Handles btnRemoveDocument.Click
        _attachedLocalFilePath = ""
        _existingStoredFilePath = ""
        _existingOriginalFileName = ""
        lblAttachedFileName.Text = "No document attached"
        lblAttachedFileName.ForeColor = Color.FromArgb(100, 116, 139)
        btnRemoveDocument.Visible = False
        btnViewDocument.Visible = False
        _hasUnsavedChanges = True
    End Sub

    Private Sub btnViewDocument_Click(sender As Object, e As EventArgs) Handles btnViewDocument.Click
        Dim fileToOpen As String = If(Not String.IsNullOrWhiteSpace(_attachedLocalFilePath), _attachedLocalFilePath, _existingStoredFilePath)

        If String.IsNullOrWhiteSpace(fileToOpen) OrElse Not File.Exists(fileToOpen) Then
            MessageBox.Show("The attached document could not be found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Process.Start(New ProcessStartInfo(fileToOpen) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Unable to open document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' ACTIONS: SAVE DRAFT & SUBMIT
    ' ============================================================
    Private Sub btnSaveDraft_Click(sender As Object, e As EventArgs) Handles btnSaveDraft.Click
        If SaveAssessment(isDraft:=True) Then
            MessageBox.Show(
                "Health Assessment draft saved successfully!" & Environment.NewLine & Environment.NewLine &
                "Your responses are stored, but this requirement has NOT been submitted yet." & Environment.NewLine &
                "When you are ready, please click 'Submit Assessment' to send it to the School Clinic.",
                "Draft Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            _hasUnsavedChanges = False
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validation for final submission
        If Not (rdoMedHistoryYes.Checked OrElse rdoMedHistoryNo.Checked) Then
            MessageBox.Show("Please answer the Medical History question (2).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdoMedHistoryNo.Focus()
            Return
        End If

        If Not (rdoAllergiesYes.Checked OrElse rdoAllergiesNo.Checked) Then
            MessageBox.Show("Please answer the Allergies question (3).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdoAllergiesNo.Focus()
            Return
        End If

        If Not (rdoMedicationsYes.Checked OrElse rdoMedicationsNo.Checked) Then
            MessageBox.Show("Please answer the Current Medications question (4).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdoMedicationsNo.Focus()
            Return
        End If

        If Not (rdoHealthConcernsYes.Checked OrElse rdoHealthConcernsNo.Checked) Then
            MessageBox.Show("Please answer the Health Concerns question (5).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdoHealthConcernsNo.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtEmergencyName.Text.Trim()) Then
            MessageBox.Show("Please provide an Emergency Contact Name (6).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtRelationship.Text.Trim()) Then
            MessageBox.Show("Please provide your relationship with the emergency contact (6).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRelationship.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtEmergencyContactNo.Text.Trim()) Then
            MessageBox.Show("Please provide an Emergency Contact Number (6).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyContactNo.Focus()
            Return
        End If

        If Not chkDeclaration.Checked Then
            MessageBox.Show("You must check the confirmation declaration (8) before submitting.", "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            chkDeclaration.Focus()
            Return
        End If

        Dim confirmMsg As String =
            "Are you ready to submit your Health Assessment to the School Clinic?" & Environment.NewLine & Environment.NewLine &
            "Once submitted, your responses will be sent to Clinic staff for verification."
        Dim res = MessageBox.Show(confirmMsg, "Confirm Assessment Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then Return

        If SaveAssessment(isDraft:=False) Then
            MessageBox.Show(
                "Your Health Assessment has been submitted successfully!" & Environment.NewLine & Environment.NewLine &
                "The School Clinic clearing officer will review and verify your assessment.",
                "Assessment Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            _hasUnsavedChanges = False
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function SaveAssessment(isDraft As Boolean) As Boolean
        If Not CanAccessClinicRecord(forSaving:=True) Then
            MessageBox.Show("Only the student who owns this current-term Clinic record can save or submit an editable assessment.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Try
            Dim hasMedHistory As Boolean = rdoMedHistoryYes.Checked
            Dim medDetails As String = If(hasMedHistory, txtMedHistoryDetails.Text.Trim(), "")

            Dim hasAllergies As Boolean = rdoAllergiesYes.Checked
            Dim allergiesDetails As String = If(hasAllergies, txtAllergiesDetails.Text.Trim(), "")

            Dim hasMedications As Boolean = rdoMedicationsYes.Checked
            Dim medicationsDetails As String = If(hasMedications, txtMedicationsDetails.Text.Trim(), "")

            Dim hasConcerns As Boolean = rdoHealthConcernsYes.Checked
            Dim concernsDetails As String = If(hasConcerns, txtHealthConcernsDetails.Text.Trim(), "")

            Dim emName As String = txtEmergencyName.Text.Trim()
            Dim emRel As String = txtRelationship.Text.Trim()
            Dim emNo As String = txtEmergencyContactNo.Text.Trim()
            Dim isConfirmed As Boolean = chkDeclaration.Checked

            ' Handle file upload if a new local file was selected
            Dim uploadedStoredPath As String = _existingStoredFilePath
            Dim uploadedOriginalName As String = _existingOriginalFileName

            If Not String.IsNullOrWhiteSpace(_attachedLocalFilePath) AndAlso File.Exists(_attachedLocalFilePath) Then
                Dim appDir As String = Application.StartupPath
                Dim uploadsDir As String = Path.Combine(appDir, "Uploads", "Student_" & StudentID)
                If Not Directory.Exists(uploadsDir) Then Directory.CreateDirectory(uploadsDir)

                Dim origFileName As String = Path.GetFileName(_attachedLocalFilePath)
                Dim cleanFileName As String = String.Concat(origFileName.Split(Path.GetInvalidFileNameChars()))
                Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                Dim destFileName As String = RecordID.ToString() & "_" & timestamp & "_" & cleanFileName
                Dim destPath As String = Path.Combine(uploadsDir, destFileName)

                File.Copy(_attachedLocalFilePath, destPath, True)
                uploadedStoredPath = destPath
                uploadedOriginalName = origFileName

                ' Save to ClearanceRecordFiles
                Dim fileSql As String =
                    "INSERT INTO ClearanceRecordFiles (RecordID, StoredFilePath, OriginalFileName, UploadedAt) " &
                    "VALUES (@RecordID, @StoredFilePath, @OriginalFileName, NOW());"
                db.ExecuteNonQuery(fileSql, New Dictionary(Of String, Object) From {
                    {"@RecordID", RecordID},
                    {"@StoredFilePath", uploadedStoredPath},
                    {"@OriginalFileName", uploadedOriginalName}
                })
            End If

            ' Save or Update ClinicHealthAssessments table
            Dim upsertSql As String =
                "INSERT INTO ClinicHealthAssessments " &
                "(RecordID, StudentID, TermID, AcademicYear, " &
                " HasMedicalCondition, MedicalConditionDetails, " &
                " HasAllergies, AllergiesDetails, " &
                " HasMedications, MedicationsDetails, " &
                " HasHealthConcerns, HealthConcernsDetails, " &
                " EmergencyContactName, Relationship, EmergencyContactNo, " &
                " IsConfirmed, IsDraft, SubmittedAt, UpdatedAt) " &
                "VALUES (@RecordID, @StudentID, @TermID, @AcademicYear, " &
                " @HasMed, @MedDetails, @HasAlg, @AlgDetails, @HasMeds, @MedsDetails, " &
                " @HasConcerns, @ConcernsDetails, @EmName, @EmRel, @EmNo, " &
                " @IsConfirmed, @IsDraft, " & If(isDraft, "NULL", "NOW()") & ", NOW()) " &
                "ON DUPLICATE KEY UPDATE " &
                "HasMedicalCondition = @HasMed, MedicalConditionDetails = @MedDetails, " &
                "HasAllergies = @HasAlg, AllergiesDetails = @AlgDetails, " &
                "HasMedications = @HasMeds, MedicationsDetails = @MedsDetails, " &
                "HasHealthConcerns = @HasConcerns, HealthConcernsDetails = @ConcernsDetails, " &
                "EmergencyContactName = @EmName, Relationship = @EmRel, EmergencyContactNo = @EmNo, " &
                "IsConfirmed = @IsConfirmed, IsDraft = @IsDraft, " &
                "SubmittedAt = " & If(isDraft, "SubmittedAt", "NOW()") & ", UpdatedAt = NOW();"

            Dim pms As New Dictionary(Of String, Object) From {
                {"@RecordID", RecordID},
                {"@StudentID", StudentID},
                {"@TermID", TermID},
                {"@AcademicYear", AcademicYear},
                {"@HasMed", hasMedHistory},
                {"@MedDetails", medDetails},
                {"@HasAlg", hasAllergies},
                {"@AlgDetails", allergiesDetails},
                {"@HasMeds", hasMedications},
                {"@MedsDetails", medicationsDetails},
                {"@HasConcerns", hasConcerns},
                {"@ConcernsDetails", concernsDetails},
                {"@EmName", emName},
                {"@EmRel", emRel},
                {"@EmNo", emNo},
                {"@IsConfirmed", isConfirmed},
                {"@IsDraft", isDraft}
            }

            db.ExecuteNonQuery(upsertSql, pms)

            ' If NOT draft (Actual Submission) -> update ClearanceRecords and ClearanceHistory
            If Not isDraft Then
                Dim oldStatus As String = "Pending"
                Dim dtCurrent = db.ExecuteQuery("SELECT Status FROM ClearanceRecords WHERE RecordID = @RecordID LIMIT 1;", New Dictionary(Of String, Object) From {{"@RecordID", RecordID}})
                If dtCurrent.Rows.Count > 0 Then oldStatus = dtCurrent.Rows(0)("Status").ToString()

                Dim updateRecSql As String =
                    "UPDATE ClearanceRecords " &
                    "SET Status = 'Under Review', " &
                    "    SubmittedAt = NOW(), " &
                    "    SubmittedFilePath = @FilePath, " &
                    "    SubmittedFileName = @FileName " &
                    "WHERE RecordID = @RecordID;"

                db.ExecuteNonQuery(updateRecSql, New Dictionary(Of String, Object) From {
                    {"@RecordID", RecordID},
                    {"@FilePath", If(String.IsNullOrWhiteSpace(uploadedStoredPath), DBNull.Value, CObj(uploadedStoredPath))},
                    {"@FileName", If(String.IsNullOrWhiteSpace(uploadedOriginalName), DBNull.Value, CObj(uploadedOriginalName))}
                })

                Dim actionName As String = If(oldStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase), "Resubmitted Assessment", "Submitted Assessment")
                Dim histRemarks As String = "Student submitted digital Health Assessment Form."
                If Not String.IsNullOrWhiteSpace(uploadedOriginalName) Then
                    histRemarks &= " Attached supporting document: " & uploadedOriginalName
                End If

                Dim histSql As String =
                    "INSERT INTO ClearanceHistory (RecordID, ActionType, OldStatus, NewStatus, Remarks, ActionAt, ActionBy) " &
                    "VALUES (@RecordID, @ActionType, @OldStatus, 'Under Review', @Remarks, NOW(), @StudentID);"

                db.ExecuteNonQuery(histSql, New Dictionary(Of String, Object) From {
                    {"@RecordID", RecordID},
                    {"@ActionType", actionName},
                    {"@OldStatus", oldStatus},
                    {"@Remarks", histRemarks},
                    {"@StudentID", StudentID}
                })
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Failed to save health assessment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnCancel.Click
        If _hasUnsavedChanges AndAlso Not IsReadOnly Then
            Dim confirm = MessageBox.Show("You have unsaved changes. Are you sure you want to close without saving?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm <> DialogResult.Yes Then Return
        End If
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
