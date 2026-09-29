Imports MySql.Data.MySqlClient

Public Class StartNewTermForm

    Private ReadOnly db As New DatabaseHelper()

    Private Sub StartNewTermForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTermOptions()
    End Sub

    Private Sub InitializeTermOptions()
        If cmbSemester.Items.Count = 0 Then
            cmbSemester.Items.Add("1st Semester")
            cmbSemester.Items.Add("2nd Semester")
            cmbSemester.Items.Add("Summer Term")
        End If

        Try
            Dim query As String = "SELECT AcademicYear, Semester FROM AcademicTerms ORDER BY TermID DESC LIMIT 1;"
            Dim table As DataTable = db.ExecuteQuery(query)

            If table.Rows.Count > 0 Then
                Dim lastYear As String = table.Rows(0)("AcademicYear").ToString()
                Dim lastSem As String = table.Rows(0)("Semester").ToString()

                txtSchoolYear.Text = lastYear

                If lastSem.Contains("1st") Then
                    cmbSemester.SelectedItem = "2nd Semester"
                ElseIf lastSem.Contains("2nd") Then
                    cmbSemester.SelectedItem = "Summer Term"
                Else
                    cmbSemester.SelectedItem = "1st Semester"
                End If
            Else
                txtSchoolYear.Text = "2026-2027"
                cmbSemester.SelectedIndex = 0
            End If
        Catch
            txtSchoolYear.Text = "2026-2027"
            If cmbSemester.Items.Count > 0 Then cmbSemester.SelectedIndex = 0
        End Try
    End Sub

    Private Sub btnStartTerm_Click(sender As Object, e As EventArgs) Handles btnStartTerm.Click
        Dim schoolYear As String = txtSchoolYear.Text.Trim()
        Dim semester As String = If(cmbSemester.SelectedItem IsNot Nothing, cmbSemester.SelectedItem.ToString(), "")

        If String.IsNullOrWhiteSpace(schoolYear) Then
            MessageBox.Show("Please enter the school year (Format: YYYY-YYYY).", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchoolYear.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(semester) Then
            MessageBox.Show("Please select a semester.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSemester.Focus()
            Return
        End If

        Dim confirmMsg As String =
            "Are you sure you want to start the term: " & schoolYear & " - " & semester & "?" & Environment.NewLine & Environment.NewLine &
            "• This will archive previous active terms." & Environment.NewLine &
            "• New pending clearance records will be generated for all current students."

        Dim answer As DialogResult = MessageBox.Show(confirmMsg, "Confirm New School Term", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer <> DialogResult.Yes Then Return

        Try
            Dim checkQuery As String = "SELECT COUNT(*) FROM AcademicTerms WHERE AcademicYear = @Year AND Semester = @Sem;"
            Dim checkParams As New Dictionary(Of String, Object) From {
                {"@Year", schoolYear},
                {"@Sem", semester}
            }
            Dim count As Integer = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams))

            If count > 0 Then
                MessageBox.Show("The academic term " & schoolYear & " (" & semester & ") has already been created previously.", "Duplicate Term", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Deactivate old terms
                        Using cmdDeactivate As New MySqlCommand("UPDATE AcademicTerms SET IsActive = 0;", conn, transaction)
                            cmdDeactivate.ExecuteNonQuery()
                        End Using

                        ' Insert new term
                        Dim insertTermSql As String =
                            "INSERT INTO AcademicTerms (AcademicYear, Semester, IsActive, StartDate) " &
                            "VALUES (@Year, @Sem, 1, CURDATE());"

                        Dim newTermID As Integer
                        Using cmdTerm As New MySqlCommand(insertTermSql, conn, transaction)
                            cmdTerm.Parameters.AddWithValue("@Year", schoolYear)
                            cmdTerm.Parameters.AddWithValue("@Sem", semester)
                            cmdTerm.ExecuteNonQuery()
                            newTermID = Convert.ToInt32(cmdTerm.LastInsertedId)
                        End Using

                        ' Batch generate clearance records for all active students matching requirement course & NSTP
                        Dim generateRecordsSql As String =
                            "INSERT INTO ClearanceRecords (StudentID, RequirementID, TermID, Status) " &
                            "SELECT u.UserID, r.RequirementID, @TermID, 'Pending' " &
                            "FROM Users u " &
                            "CROSS JOIN ClearanceRequirements r " &
                            "WHERE u.Role = 'Student' AND u.IsActive = 1 " &
                            "AND r.IsActive = 1 " &
                            "AND (r.AppliesToCourse IS NULL OR r.AppliesToCourse = '' OR r.AppliesToCourse = u.Course) " &
                            "AND (r.RequiresNSTP = 0 OR u.EnrolledInNSTP = 1);"

                        Using cmdRecords As New MySqlCommand(generateRecordsSql, conn, transaction)
                            cmdRecords.Parameters.AddWithValue("@TermID", newTermID)
                            cmdRecords.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                        MessageBox.Show(
                            "New school term " & schoolYear & " - " & semester & " started successfully!" & Environment.NewLine &
                            "All students' clearance requirements have been initialized to Pending.",
                            "Term Started",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        ' If parent is AdminStudentsForm, navigate to Students view
                        If TypeOf Me.ParentForm Is AdminStudentsForm Then
                            DirectCast(Me.ParentForm, AdminStudentsForm).ShowStudentsView()
                        ElseIf Me.Parent IsNot Nothing AndAlso TypeOf Me.Parent.FindForm() Is AdminStudentsForm Then
                            DirectCast(Me.Parent.FindForm(), AdminStudentsForm).ShowStudentsView()
                        Else
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If

                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to start new school term." & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If TypeOf Me.ParentForm Is AdminStudentsForm Then
            DirectCast(Me.ParentForm, AdminStudentsForm).ShowStudentsView()
        ElseIf Me.Parent IsNot Nothing AndAlso TypeOf Me.Parent.FindForm() Is AdminStudentsForm Then
            DirectCast(Me.Parent.FindForm(), AdminStudentsForm).ShowStudentsView()
        Else
            Me.Close()
        End If
    End Sub

End Class
