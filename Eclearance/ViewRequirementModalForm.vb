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

    Private Sub LoadGuidanceStudentInfo()
        Try
            Dim query As String =
                "SELECT ContactNo, Email, Address, CivilStatus, EmergencyContactName, Relationship, EmergencyContactNo, AdditionalNotes " &
                "FROM Users WHERE UserID = @UserID LIMIT 1;"

            Dim dt = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@UserID", AppSession.UserID}
            })

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txtContactNo.Text = If(IsDBNull(row("ContactNo")), "", row("ContactNo").ToString())
                txtEmail.Text = If(IsDBNull(row("Email")), "", row("Email").ToString())
                txtAddress.Text = If(IsDBNull(row("Address")), "", row("Address").ToString())

                Dim civil = If(IsDBNull(row("CivilStatus")), "", row("CivilStatus").ToString())
                If Not String.IsNullOrWhiteSpace(civil) AndAlso cmbCivilStatus.Items.Contains(civil) Then
                    cmbCivilStatus.SelectedItem = civil
                Else
                    cmbCivilStatus.SelectedIndex = -1
                End If

                txtEmergencyContactName.Text = If(IsDBNull(row("EmergencyContactName")), "", row("EmergencyContactName").ToString())

                Dim rel = If(IsDBNull(row("Relationship")), "", row("Relationship").ToString())
                If Not String.IsNullOrWhiteSpace(rel) AndAlso cmbRelationship.Items.Contains(rel) Then
                    cmbRelationship.SelectedItem = rel
                Else
                    cmbRelationship.SelectedIndex = -1
                End If

                txtEmergencyContactNo.Text = If(IsDBNull(row("EmergencyContactNo")), "", row("EmergencyContactNo").ToString())
                txtAdditionalNotes.Text = If(IsDBNull(row("AdditionalNotes")), "", row("AdditionalNotes").ToString())
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
            Dim updateSql As String =
                "UPDATE Users SET " &
                "  ContactNo = @ContactNo, " &
                "  Email = @Email, " &
                "  Address = @Address, " &
                "  CivilStatus = @CivilStatus, " &
                "  EmergencyContactName = @EmergencyContactName, " &
                "  Relationship = @Relationship, " &
                "  EmergencyContactNo = @EmergencyContactNo, " &
                "  AdditionalNotes = @AdditionalNotes, " &
                "  GuidanceInfoUpdated = 1 " &
                "WHERE UserID = @UserID;"

            Dim params As New Dictionary(Of String, Object) From {
                {"@ContactNo", contact},
                {"@Email", email},
                {"@Address", address},
                {"@CivilStatus", civil},
                {"@EmergencyContactName", emName},
                {"@Relationship", relationship},
                {"@EmergencyContactNo", emNo},
                {"@AdditionalNotes", notes},
                {"@UserID", AppSession.UserID}
            }

            db.ExecuteNonQuery(updateSql, params)

            ' Also update student's active Guidance clearance record to 'Under Review' so staff can review it
            Try
                Dim updateRecordSql As String =
                    "UPDATE ClearanceRecords cr " &
                    "INNER JOIN ClearanceRequirements req ON cr.RequirementID = req.RequirementID " &
                    "SET cr.Status = 'Under Review', cr.SubmittedAt = NOW() " &
                    "WHERE cr.StudentID = @UserID " &
                    "  AND (req.DepartmentID = 6 OR req.RequirementName LIKE '%Guidance%') " &
                    "  AND cr.Status IN ('Pending', 'Rejected');"

                db.ExecuteNonQuery(updateRecordSql, New Dictionary(Of String, Object) From {{"@UserID", AppSession.UserID}})

                EffectiveStatus = "Under Review"
                lblStatusBadge.Text = "Under Review"
                ApplyStatusStyle(lblStatusBadge, "Under Review")
            Catch
            End Try

            MessageBox.Show("Student personal information updated successfully for Guidance records.", "Guidance Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
