Imports System.IO
Imports System.Diagnostics

Public Class ClearanceHistoryForm

    Private ReadOnly db As New DatabaseHelper()

    Public Property StudentIDFilter As Integer? = Nothing

    Public Property StudentNameFilter As String = ""

    Private selectedFilePath As String = ""


    Private Sub ClearanceHistoryForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigureView()

        LoadHistory()

    End Sub


    Private Sub ConfigureView()

        If AppSession.Role.Equals(
            "Student",
            StringComparison.OrdinalIgnoreCase
        ) Then

            btnNavStudents.Visible = False

            btnNavStaff.Visible = False

            btnNavStartTerm.Visible = False

            lblHeaderTitle.Text =
                "Clearance History"

            lblSubHeader.Text =
                "View your clearance activities and status changes."

        Else

            btnNavStudents.Visible = True

            btnNavStaff.Visible = True

            btnNavStartTerm.Visible = True

            lblHeaderTitle.Text =
                "Clearance History"

            If StudentIDFilter.HasValue AndAlso
               Not String.IsNullOrWhiteSpace(StudentNameFilter) Then

                lblSubHeader.Text =
                    "Viewing clearance history for " &
                    StudentNameFilter

            Else

                lblSubHeader.Text =
                    "Review clearance activities and status changes."

            End If

        End If

    End Sub


    Private Sub LoadHistory()

        Try

            dgvHistory.Rows.Clear()

            ClearDetails()


            Dim query As String =
                "SELECT " &
                "h.HistoryID, " &
                "h.RecordID, " &
                "h.ActionType, " &
                "h.OldStatus, " &
                "h.NewStatus, " &
                "h.Remarks, " &
                "h.ActionAt, " &
                "cr.StudentID, " &
                "cr.SubmittedFilePath, " &
                "cr.SubmittedFileName, " &
                "cr.SubmittedAt, " &
                "d.DepartmentName, " &
                "t.AcademicYear, " &
                "t.Semester, " &
                "student.FullName AS StudentName, " &
                "actor.FullName AS ChangedByName " &
                "FROM ClearanceHistory h " &
                "INNER JOIN ClearanceRecords cr " &
                "ON h.RecordID = cr.RecordID " &
                "INNER JOIN ClearanceRequirements req " &
                "ON cr.RequirementID = req.RequirementID " &
                "INNER JOIN Departments d " &
                "ON req.DepartmentID = d.DepartmentID " &
                "INNER JOIN AcademicTerms t " &
                "ON cr.TermID = t.TermID " &
                "INNER JOIN Users student " &
                "ON cr.StudentID = student.UserID " &
                "LEFT JOIN Users actor " &
                "ON h.ActionBy = actor.UserID "


            Dim parameters As New Dictionary(Of String, Object)()


            If AppSession.Role.Equals(
                "Student",
                StringComparison.OrdinalIgnoreCase
            ) Then

                query &=
                    "WHERE cr.StudentID = @StudentID "

                parameters.Add(
                    "@StudentID",
                    AppSession.UserID
                )


            ElseIf StudentIDFilter.HasValue Then

                query &=
                    "WHERE cr.StudentID = @StudentID "

                parameters.Add(
                    "@StudentID",
                    StudentIDFilter.Value
                )

            End If


            query &=
                "ORDER BY h.ActionAt DESC, h.HistoryID DESC;"


            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            Dim lastRecordID As Integer = -1
            Dim lastActionType As String = ""
            Dim lastNewStatus As String = ""

            For Each row As DataRow In table.Rows
                Dim recID As Integer = Convert.ToInt32(row("RecordID"))
                Dim actType As String = If(IsDBNull(row("ActionType")), "", row("ActionType").ToString())
                Dim st As String = If(IsDBNull(row("NewStatus")), "", row("NewStatus").ToString())

                ' Filter out consecutive duplicate events for the same record and status
                If recID = lastRecordID AndAlso actType.Equals(lastActionType, StringComparison.OrdinalIgnoreCase) AndAlso st.Equals(lastNewStatus, StringComparison.OrdinalIgnoreCase) Then
                    Continue For
                End If

                lastRecordID = recID
                lastActionType = actType
                lastNewStatus = st

                AddHistoryRow(row)

            Next


            If dgvHistory.Rows.Count > 0 Then

                dgvHistory.Rows(0).Selected =
                    True

                ShowSelectedHistory()

            Else

                lblCalloutText.Text =
                    "No clearance history records were found."

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load clearance history." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "History Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub AddHistoryRow(
        dataRow As DataRow
    )

        Dim actionDate As DateTime =
            Convert.ToDateTime(
                dataRow("ActionAt")
            )


        Dim term As String =
            dataRow("AcademicYear").ToString() &
            " - " &
            dataRow("Semester").ToString()


        Dim changedBy As String =
            "System"


        If Not IsDBNull(
            dataRow("ChangedByName")
        ) Then

            Dim value As String =
                dataRow("ChangedByName").ToString()

            If Not String.IsNullOrWhiteSpace(value) Then

                changedBy = value

            End If

        End If


        Dim newStatus As String = ""

        If Not IsDBNull(
            dataRow("NewStatus")
        ) Then

            newStatus =
                dataRow("NewStatus").ToString()

        End If


        Dim rowIndex As Integer =
            dgvHistory.Rows.Add(
                actionDate.ToString(
                    "MMM dd, yyyy hh:mm tt"
                ),
                term,
                dataRow("DepartmentName").ToString(),
                dataRow("ActionType").ToString(),
                changedBy,
                newStatus
            )


        dgvHistory.Rows(rowIndex).Tag =
            Convert.ToInt32(
                dataRow("HistoryID")
            )

    End Sub


    Private Sub dgvHistory_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvHistory.SelectionChanged

        ShowSelectedHistory()

    End Sub


    Private Sub ShowSelectedHistory()

        If dgvHistory.SelectedRows.Count = 0 Then

            ClearDetails()

            Return

        End If


        If dgvHistory.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim historyID As Integer =
            Convert.ToInt32(
                dgvHistory.SelectedRows(0).Tag
            )


        Try

            Dim query As String =
                "SELECT " &
                "h.ActionType, " &
                "h.OldStatus, " &
                "h.NewStatus, " &
                "h.Remarks, " &
                "actor.FullName AS ChangedByName, " &
                "cr.SubmittedFilePath, " &
                "cr.SubmittedFileName, " &
                "cr.SubmittedAt " &
                "FROM ClearanceHistory h " &
                "INNER JOIN ClearanceRecords cr " &
                "ON h.RecordID = cr.RecordID " &
                "LEFT JOIN Users actor " &
                "ON h.ActionBy = actor.UserID " &
                "WHERE h.HistoryID = @HistoryID " &
                "LIMIT 1;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@HistoryID", historyID}
            }


            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            If table.Rows.Count = 0 Then

                ClearDetails()

                Return

            End If


            Dim row As DataRow =
                table.Rows(0)


            lblActionVal.Text =
                row("ActionType").ToString()


            If IsDBNull(
                row("ChangedByName")
            ) Then

                lblChangedByVal.Text =
                    "System"

            Else

                lblChangedByVal.Text =
                    row("ChangedByName").ToString()

            End If


            If IsDBNull(
                row("OldStatus")
            ) Then

                lblPrevStatusBadge.Text =
                    "—"

            Else

                lblPrevStatusBadge.Text =
                    row("OldStatus").ToString()

            End If


            If IsDBNull(
                row("NewStatus")
            ) Then

                lblNewStatusBadge.Text =
                    "—"

            Else

                lblNewStatusBadge.Text =
                    row("NewStatus").ToString()

            End If


            If IsDBNull(
                row("Remarks")
            ) OrElse
               String.IsNullOrWhiteSpace(
                   row("Remarks").ToString()
               ) Then

                lblRemarksVal.Text =
                    "No remarks."

            Else

                lblRemarksVal.Text =
                    row("Remarks").ToString()

            End If


            selectedFilePath = ""


            If Not IsDBNull(
                row("SubmittedFilePath")
            ) Then

                selectedFilePath =
                    row("SubmittedFilePath").ToString()

            End If


            If Not IsDBNull(
                row("SubmittedFileName")
            ) AndAlso
               Not String.IsNullOrWhiteSpace(
                   row("SubmittedFileName").ToString()
               ) Then

                lblFileName.Text =
                    row("SubmittedFileName").ToString()

                btnViewSavedFile.Enabled =
                    Not String.IsNullOrWhiteSpace(
                        selectedFilePath
                    )

            Else

                lblFileName.Text =
                    "No file attached"

                btnViewSavedFile.Enabled =
                    False

            End If


            If Not IsDBNull(
                row("SubmittedAt")
            ) Then

                Dim submittedDate As DateTime =
                    Convert.ToDateTime(
                        row("SubmittedAt")
                    )

                lblFileMeta.Text =
                    "Submitted " &
                    submittedDate.ToString(
                        "MMM dd, yyyy hh:mm tt"
                    )

            Else

                lblFileMeta.Text = ""

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load history details." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "History Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub ClearDetails()

        lblActionVal.Text =
            "Select a history event"

        lblChangedByVal.Text =
            "—"

        lblPrevStatusBadge.Text =
            "—"

        lblNewStatusBadge.Text =
            "—"

        lblRemarksVal.Text =
            "Select a record to view details."

        lblFileName.Text =
            "No file selected"

        lblFileMeta.Text = ""

        selectedFilePath = ""

        btnViewSavedFile.Enabled =
            False

    End Sub


    Private Sub btnViewSavedFile_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewSavedFile.Click

        If String.IsNullOrWhiteSpace(
            selectedFilePath
        ) Then

            MessageBox.Show(
                "No saved file is available.",
                "File",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not File.Exists(
            selectedFilePath
        ) Then

            MessageBox.Show(
                "The saved file could not be found.",
                "File Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            Dim info As New ProcessStartInfo()

            info.FileName =
                selectedFilePath

            info.UseShellExecute =
                True

            Process.Start(info)

        Catch ex As Exception

            MessageBox.Show(
                "Unable to open the file." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "File Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadHistory()

    End Sub


    Private Sub btnNavStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStudents.Click

        Me.Close()

    End Sub


    Private Sub btnNavStaff_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStaff.Click

        If Not AppSession.Role.Equals(
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) Then

            Return

        End If


        Me.Hide()

        Using frm As New StaffOfficesForm()

            frm.ShowDialog()

        End Using

        Me.Close()

    End Sub


    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        LoadHistory()

    End Sub


    Private Sub btnNavStartTerm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStartTerm.Click

        If Not AppSession.Role.Equals(
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) Then

            Return

        End If


        Me.Hide()

        Using frm As New StartNewTermForm()

            frm.ShowDialog()

        End Using

        Me.Close()

    End Sub


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