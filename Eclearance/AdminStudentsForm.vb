Public Class AdminStudentsForm

    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub AdminStudentsForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadCurrentTermLabel()
        LoadStudents()

    End Sub


    ' ============================================================
    ' ADD STUDENT BUTTON
    ' ============================================================
    Private Sub btnAddStudent_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddStudent.Click

        Dim modalBackdrop As New Form()

        Try
            modalBackdrop.FormBorderStyle = FormBorderStyle.None
            modalBackdrop.BackColor = Color.Black
            modalBackdrop.Opacity = 0.45R
            modalBackdrop.ShowInTaskbar = False
            modalBackdrop.StartPosition = FormStartPosition.Manual
            modalBackdrop.Location = Me.PointToScreen(Point.Empty)
            modalBackdrop.Size = Me.ClientSize
            modalBackdrop.Owner = Me
            modalBackdrop.Show()

            Using frm As New CreateStudentForm()
                If frm.ShowDialog(modalBackdrop) = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using

        Finally
            modalBackdrop.Dispose()
        End Try

    End Sub


    ' ============================================================
    ' REFRESH BUTTON
    ' ============================================================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadStudents()

    End Sub


    ' ============================================================
    ' SEARCH
    ' ============================================================
    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        LoadStudents()

    End Sub


    ' ============================================================
    ' LOAD STUDENTS
    ' ============================================================
    Private Sub LoadStudents()

        Try

            dgvStudents.Rows.Clear()

            Dim searchText As String =
                txtSearch.Text.Trim()


            Dim query As String =
                "SELECT " &
                "UserID, " &
                "StudentNo, " &
                "FullName, " &
                "Course, " &
                "YearLevel " &
                "FROM Users " &
                "WHERE Role = 'Student' " &
                "AND IsActive = 1 "


            Dim parameters As New Dictionary(Of String, Object)()


            If Not String.IsNullOrWhiteSpace(searchText) Then

                query &=
                    "AND (" &
                    "FullName LIKE @Search " &
                    "OR StudentNo LIKE @Search" &
                    ") "

                parameters.Add(
                    "@Search",
                    "%" & searchText & "%"
                )

            End If


            query &=
                "ORDER BY FullName ASC;"


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            For Each row As DataRow In table.Rows

                Dim userID As Integer =
                    Convert.ToInt32(
                        row("UserID")
                    )


                Dim studentNo As String =
                    row("StudentNo").ToString()


                Dim fullName As String =
                    row("FullName").ToString()


                Dim course As String =
                    row("Course").ToString()


                Dim yearLevel As String =
                    row("YearLevel").ToString()


                Dim progressText As String =
                    GetStudentProgress(userID)


                Dim statusText As String =
                    GetOverallStatus(userID)


                Dim rowIndex As Integer =
                    dgvStudents.Rows.Add(
                        studentNo,
                        fullName,
                        course,
                        yearLevel,
                        progressText,
                        statusText
                    )


                dgvStudents.Rows(rowIndex).Tag =
                    userID

            Next


            UpdateStatistics()

            dgvClearanceDetails.Rows.Clear()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load students." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Students Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' GET STUDENT PROGRESS
    ' ============================================================
    Private Function GetStudentProgress(
        studentID As Integer
    ) As String

        Try

            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                Return "0 / 0"

            End If


            Dim query As String =
                "SELECT " &
                "COUNT(*) AS TotalCount, " &
                "SUM(CASE WHEN Status = 'Cleared' THEN 1 ELSE 0 END) AS ClearedCount " &
                "FROM ClearanceRecords " &
                "WHERE StudentID = @StudentID " &
                "AND TermID = @TermID;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            }


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            If table.Rows.Count = 0 Then

                Return "0 / 0"

            End If


            Dim total As Integer = 0
            Dim cleared As Integer = 0


            If Not IsDBNull(
                table.Rows(0)("TotalCount")
            ) Then

                total =
                    Convert.ToInt32(
                        table.Rows(0)("TotalCount")
                    )

            End If


            If Not IsDBNull(
                table.Rows(0)("ClearedCount")
            ) Then

                cleared =
                    Convert.ToInt32(
                        table.Rows(0)("ClearedCount")
                    )

            End If


            Return cleared.ToString() &
                " / " &
                total.ToString()


        Catch

            Return "0 / 0"

        End Try

    End Function


    ' ============================================================
    ' GET OVERALL STATUS
    ' ============================================================
    Private Function GetOverallStatus(
        studentID As Integer
    ) As String

        Try

            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                Return "No Term"

            End If


            Dim query As String =
                "SELECT Status " &
                "FROM ClearanceRecords " &
                "WHERE StudentID = @StudentID " &
                "AND TermID = @TermID;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            }


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            If table.Rows.Count = 0 Then

                Return "Pending"

            End If


            Dim clearedCount As Integer = 0
            Dim rejectedCount As Integer = 0
            Dim underReviewCount As Integer = 0
            Dim pendingCount As Integer = 0


            For Each row As DataRow In table.Rows

                Dim status As String =
                    row("Status").ToString()


                Select Case status.ToLower()

                    Case "cleared"
                        clearedCount += 1

                    Case "rejected"
                        rejectedCount += 1

                    Case "under review"
                        underReviewCount += 1

                    Case Else
                        pendingCount += 1

                End Select

            Next


            If clearedCount = table.Rows.Count Then

                Return "Cleared"

            End If


            If rejectedCount > 0 Then

                Return "Needs Attention"

            End If


            If underReviewCount > 0 Then

                Return "Under Review"

            End If


            Return "Pending"


        Catch

            Return "Pending"

        End Try

    End Function


    ' ============================================================
    ' UPDATE STATISTICS
    ' ============================================================
    Private Sub UpdateStatistics()

        Dim total As Integer =
            dgvStudents.Rows.Count

        Dim fullyCleared As Integer = 0

        Dim needsAttention As Integer = 0


        For Each row As DataGridViewRow In dgvStudents.Rows

            If row.IsNewRow Then
                Continue For
            End If


            Dim status As String =
                row.Cells(
                    colStatus.Index
                ).Value.ToString()


            If status.Equals(
                "Cleared",
                StringComparison.OrdinalIgnoreCase
            ) Then

                fullyCleared += 1

            End If


            If status.Equals(
                "Needs Attention",
                StringComparison.OrdinalIgnoreCase
            ) Then

                needsAttention += 1

            End If

        Next


        lblStatTotalVal.Text =
            total.ToString()

        lblStatClearedVal.Text =
            fullyCleared.ToString()

        lblStatAttentionVal.Text =
            needsAttention.ToString()

    End Sub


    ' ============================================================
    ' STUDENT SELECTION CHANGED
    ' ============================================================
    Private Sub dgvStudents_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvStudents.SelectionChanged

        LoadSelectedStudentDetails()

    End Sub


    ' ============================================================
    ' LOAD CLEARANCE DETAILS FOR SELECTED STUDENT
    ' ============================================================
    Private Sub LoadSelectedStudentDetails()

        If dgvStudents.SelectedRows.Count = 0 Then

            dgvClearanceDetails.Rows.Clear()

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim studentID As Integer =
            Convert.ToInt32(
                dgvStudents.SelectedRows(0).Tag
            )


        Try

            dgvClearanceDetails.Rows.Clear()


            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                Return

            End If


            Dim query As String =
                "SELECT " &
                "d.DepartmentName, " &
                "cr.Status, " &
                "cr.Remarks " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r " &
                "ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Departments d " &
                "ON r.DepartmentID = d.DepartmentID " &
                "WHERE cr.StudentID = @StudentID " &
                "AND cr.TermID = @TermID " &
                "ORDER BY d.DepartmentName ASC;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            }


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            For Each row As DataRow In table.Rows

                Dim remarks As String = ""

                If Not IsDBNull(
                    row("Remarks")
                ) Then

                    remarks =
                        row("Remarks").ToString()

                End If


                dgvClearanceDetails.Rows.Add(
                    row("DepartmentName").ToString(),
                    row("Status").ToString(),
                    remarks
                )

            Next


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load student clearance details." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Clearance Details Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' VIEW HISTORY
    ' ============================================================
    Private Sub btnViewHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewHistory.Click

        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "View History",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim studentID As Integer =
            Convert.ToInt32(
                dgvStudents.SelectedRows(0).Tag
            )


        Dim studentName As String =
            dgvStudents.SelectedRows(0).
            Cells(colStudentName.Index).
            Value.ToString()


        Using frm As New ClearanceHistoryForm()

            frm.StudentIDFilter =
                studentID

            frm.StudentNameFilter =
                studentName

            frm.ShowDialog()

        End Using

    End Sub


    ' ============================================================
    ' RESET CURRENT TERM
    ' ============================================================
    Private Sub btnResetTerm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnResetTerm.Click

        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Reset Current Term",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim answer As DialogResult =
            MessageBox.Show(
                "Reset this student's clearance for the current term?" &
                Environment.NewLine &
                Environment.NewLine &
                "All current statuses will return to Pending.",
                "Reset Current Term",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )


        If answer <> DialogResult.Yes Then

            Return

        End If


        Try

            Dim studentID As Integer =
                Convert.ToInt32(
                    dgvStudents.SelectedRows(0).Tag
                )


            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                MessageBox.Show(
                    "No active term was found.",
                    "Reset Current Term",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim query As String =
                "UPDATE ClearanceRecords " &
                "SET Status = 'Pending', " &
                "Remarks = NULL, " &
                "SubmittedFilePath = NULL, " &
                "SubmittedFileName = NULL, " &
                "SubmittedAt = NULL, " &
                "ReviewedBy = NULL, " &
                "ReviewedAt = NULL " &
                "WHERE StudentID = @StudentID " &
                "AND TermID = @TermID;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            }


            Dim db As New DatabaseHelper()

            db.ExecuteNonQuery(
                query,
                parameters
            )


            MessageBox.Show(
                "The student's current clearance term was reset.",
                "Reset Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to reset the student's clearance." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Reset Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' CURRENT TERM LABEL
    ' ============================================================
    Private Sub LoadCurrentTermLabel()

        Try

            Dim query As String =
                "SELECT AcademicYear, Semester " &
                "FROM AcademicTerms " &
                "WHERE IsActive = 1 " &
                "ORDER BY TermID DESC " &
                "LIMIT 1;"


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(query)


            If table.Rows.Count > 0 Then

                lblTermBadge.Text =
                    table.Rows(0)("AcademicYear").ToString() &
                    " - " &
                    table.Rows(0)("Semester").ToString()

            Else

                lblTermBadge.Text =
                    "No Active Term"

            End If


        Catch

            lblTermBadge.Text =
                "Current Term"

        End Try

    End Sub


    ' ============================================================
    ' GET ACTIVE TERM
    ' ============================================================
    Private Function GetActiveTermID() As Integer

        Dim query As String =
            "SELECT TermID " &
            "FROM AcademicTerms " &
            "WHERE IsActive = 1 " &
            "ORDER BY TermID DESC " &
            "LIMIT 1;"


        Dim db As New DatabaseHelper()

        Dim result As Object =
            db.ExecuteScalar(query)


        If result Is Nothing OrElse
           result Is DBNull.Value Then

            Return 0

        End If


        Return Convert.ToInt32(result)

    End Function


    ' ============================================================
    ' NAV - STUDENTS
    ' ============================================================
    Private Sub btnNavStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStudents.Click

        LoadStudents()

    End Sub


    ' ============================================================
    ' NAV - STAFF & OFFICES
    ' ============================================================
    Private Sub btnNavStaff_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStaff.Click

        Me.Hide()

        Using frm As New StaffOfficesForm()

            frm.ShowDialog()

        End Using

        Me.Show()

        LoadStudents()

    End Sub


    ' ============================================================
    ' NAV - HISTORY
    ' ============================================================
    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        Using frm As New ClearanceHistoryForm()

            frm.ShowDialog()

        End Using

    End Sub


    ' ============================================================
    ' NAV - START NEW TERM
    ' ============================================================
    Private Sub btnNavStartTerm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStartTerm.Click

        Me.Hide()

        Using frm As New StartNewTermForm()

            frm.ShowDialog()

        End Using

        Me.Show()

        LoadCurrentTermLabel()
        LoadStudents()

    End Sub


    ' ============================================================
    ' LOGOUT
    ' ============================================================
    Private Sub btnNavLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavLogout.Click

        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If answer = DialogResult.Yes Then

            AppSession.Clear()

            Me.Close()

        End If

    End Sub

End Class