Imports MySql.Data.MySqlClient

Public Class EditStudentProfileModalForm

    Private ReadOnly db As New DatabaseHelper()

    Private activeTermID As Integer = 0
    Private activeAcademicYear As String = ""

    Private Sub EditStudentProfileModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActiveTerm()
        LoadCurrentProfile()
    End Sub

    Private Sub LoadActiveTerm()
        Try
            Dim dt As DataTable = db.ExecuteQuery("SELECT TermID, AcademicYear FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
            If dt.Rows.Count > 0 Then
                activeTermID = Convert.ToInt32(dt.Rows(0)("TermID"))
                activeAcademicYear = dt.Rows(0)("AcademicYear").ToString()
            End If
        Catch
        End Try
    End Sub

    Private Sub LoadCurrentProfile()
        Try
            Dim sourceRow As DataRow = Nothing

            ' Try active academic year guidance profile first
            If Not String.IsNullOrWhiteSpace(activeAcademicYear) Then
                Dim qGuidance As String =
                    "SELECT ContactNo, Email, Address, CivilStatus, EmergencyContactName, Relationship, EmergencyContactNo " &
                    "FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear ORDER BY GuidanceProfileID DESC LIMIT 1;"
                Dim dtG As DataTable = db.ExecuteQuery(qGuidance, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID},
                    {"@AcademicYear", activeAcademicYear}
                })
                If dtG.Rows.Count > 0 Then
                    sourceRow = dtG.Rows(0)
                End If
            End If

            ' Fallback to latest guidance profile
            If sourceRow Is Nothing Then
                Dim qLatest As String =
                    "SELECT ContactNo, Email, Address, CivilStatus, EmergencyContactName, Relationship, EmergencyContactNo " &
                    "FROM GuidanceStudentProfiles WHERE StudentID = @StudentID ORDER BY GuidanceProfileID DESC LIMIT 1;"
                Dim dtL As DataTable = db.ExecuteQuery(qLatest, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID}
                })
                If dtL.Rows.Count > 0 Then
                    sourceRow = dtL.Rows(0)
                End If
            End If

            ' Fallback to Users table
            If sourceRow Is Nothing Then
                Dim qUser As String =
                    "SELECT ContactNo, Email, Address, CivilStatus, EmergencyContactName, Relationship, EmergencyContactNo " &
                    "FROM Users WHERE UserID = @UserID LIMIT 1;"
                Dim dtU As DataTable = db.ExecuteQuery(qUser, New Dictionary(Of String, Object) From {
                    {"@UserID", AppSession.UserID}
                })
                If dtU.Rows.Count > 0 Then
                    sourceRow = dtU.Rows(0)
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
                If Not String.IsNullOrWhiteSpace(rel) Then
                    If Not cmbRelationship.Items.Contains(rel) Then
                        cmbRelationship.Items.Add(rel)
                    End If
                    cmbRelationship.SelectedItem = rel
                Else
                    cmbRelationship.SelectedIndex = -1
                End If

                txtEmergencyContactNo.Text = If(IsDBNull(sourceRow("EmergencyContactNo")), "", sourceRow("EmergencyContactNo").ToString())
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to load profile details: " & ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim contactNo As String = txtContactNo.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim civil As String = If(cmbCivilStatus.SelectedItem, "").ToString().Trim()
        Dim emergencyName As String = txtEmergencyContactName.Text.Trim()
        Dim relationship As String = If(cmbRelationship.SelectedItem, "").ToString().Trim()
        Dim emergencyContactNo As String = txtEmergencyContactNo.Text.Trim()

        If String.IsNullOrWhiteSpace(contactNo) Then
            MessageBox.Show("Please enter your contact number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please enter your email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(address) Then
            MessageBox.Show("Please enter your current address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(civil) OrElse cmbCivilStatus.SelectedIndex < 0 Then
            MessageBox.Show("Please select your civil status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCivilStatus.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(emergencyName) Then
            MessageBox.Show("Please enter an emergency contact person.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyContactName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(relationship) OrElse cmbRelationship.SelectedIndex < 0 Then
            MessageBox.Show("Please select the relationship with your emergency contact.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRelationship.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(emergencyContactNo) Then
            MessageBox.Show("Please enter the emergency contact number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmergencyContactNo.Focus()
            Return
        End If

        Try
            ' 1. Update Users table
            Dim updateUserSql As String =
                "UPDATE Users SET " &
                "  ContactNo = @ContactNo, " &
                "  Email = @Email, " &
                "  Address = @Address, " &
                "  CivilStatus = @CivilStatus, " &
                "  EmergencyContactName = @EmergencyContactName, " &
                "  EmergencyContactNo = @EmergencyContactNo, " &
                "  Relationship = @Relationship " &
                "WHERE UserID = @UserID;"

            db.ExecuteNonQuery(updateUserSql, New Dictionary(Of String, Object) From {
                {"@ContactNo", contactNo},
                {"@Email", email},
                {"@Address", address},
                {"@CivilStatus", civil},
                {"@EmergencyContactName", emergencyName},
                {"@EmergencyContactNo", emergencyContactNo},
                {"@Relationship", relationship},
                {"@UserID", AppSession.UserID}
            })

            ' 2. Upsert GuidanceStudentProfiles if active term exists
            If Not String.IsNullOrWhiteSpace(activeAcademicYear) AndAlso activeTermID > 0 Then
                Dim upsertGuidanceSql As String =
                    "INSERT INTO GuidanceStudentProfiles (StudentID, AcademicYear, TermID, Address, ContactNo, Email, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, AdditionalNotes, CreatedAt, UpdatedAt) " &
                    "VALUES (@StudentID, @AcademicYear, @TermID, @Address, @ContactNo, @Email, @CivilStatus, @EmergencyContactName, @EmergencyContactNo, @Relationship, '', NOW(), NOW()) " &
                    "ON DUPLICATE KEY UPDATE " &
                    "  Address = VALUES(Address), " &
                    "  ContactNo = VALUES(ContactNo), " &
                    "  Email = VALUES(Email), " &
                    "  CivilStatus = VALUES(CivilStatus), " &
                    "  EmergencyContactName = VALUES(EmergencyContactName), " &
                    "  EmergencyContactNo = VALUES(EmergencyContactNo), " &
                    "  Relationship = VALUES(Relationship), " &
                    "  UpdatedAt = NOW();"

                db.ExecuteNonQuery(upsertGuidanceSql, New Dictionary(Of String, Object) From {
                    {"@StudentID", AppSession.UserID},
                    {"@AcademicYear", activeAcademicYear},
                    {"@TermID", activeTermID},
                    {"@Address", address},
                    {"@ContactNo", contactNo},
                    {"@Email", email},
                    {"@CivilStatus", civil},
                    {"@EmergencyContactName", emergencyName},
                    {"@EmergencyContactNo", emergencyContactNo},
                    {"@Relationship", relationship}
                })
            End If

            MessageBox.Show("Profile information updated successfully.", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
