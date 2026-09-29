Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics

Public Class ClearanceHistoryForm

    Private ReadOnly db As New DatabaseHelper()

    ' Optional:
    ' Kapag Admin at gusto mong isang student lang ang history,
    ' set this property before ShowDialog().
    Public Property StudentIDFilter As Integer? = Nothing

    Public Property StudentNameFilter As String = ""

    Private selectedDetails As HistoryDetails = Nothing


    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub ClearanceHistoryForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigureFormForCurrentUser()

        ClearEventDetails()

        LoadHistory()

    End Sub


    ' ============================================================
    ' CONFIGURE FORM DEPENDING ON USER ROLE
    ' ============================================================
    Private Sub ConfigureFormForCurrentUser()

        If AppSession.Role.Equals(
            "Student",
            StringComparison.OrdinalIgnoreCase
        ) Then

            ' Hide admin navigation from students
            btnNavStudents.Visible = False
            btnNavStaff.Visible = False
            btnNavStartTerm.Visible = False

            btnNavHistory.Text = "⏱  History"

            lblHeaderTitle.Text =
                "Clearance history"

            lblSubHeader.Text =
                "View the history of your clearance activities and status changes."

            lblCalloutText.Text =
                "This page is read-only. Clearance history records cannot be edited."

        Else

            ' Admin mode
            btnNavStudents.Visible = True
            btnNavStaff.Visible = True
            btnNavStartTerm.Visible = True

            If StudentIDFilter.HasValue Then

                lblHeaderTitle.Text =
                    "Student clearance history"

                If Not String.IsNullOrWhiteSpace(
                    StudentNameFilter
                ) Then

                    lblSubHeader.Text =
                        "Viewing clearance history for " &
                        StudentNameFilter

                Else

                    lblSubHeader.Text =
                        "Viewing the selected student's clearance history."

                End If

            Else

                lblHeaderTitle.Text =
                    "Clearance history"

                lblSubHeader.Text =
                    "Review recorded clearance activities and status changes."

            End If

        End If

    End Sub


    ' ============================================================
    ' LOAD HISTORY
    ' ============================================================
    Private Sub LoadHistory()

        Try

            dgvHistory.Rows.Clear()

            ClearEventDetails()


            Dim query As String =
                "SELECT " &
                "h.HistoryID, " &
                "h.RecordID, " &
                "h.ActionBy, " &
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
                "at.AcademicYear, " &
                "at.Semester, " &
                "student.FullName AS StudentName, " &
                "actor.FullName AS ChangedByName " &
                "FROM ClearanceHistory h " &
                "INNER JOIN ClearanceRecords cr " &
                "ON h.RecordID = cr.RecordID " &
                "INNER JOIN ClearanceRequirements req " &
                "ON cr.RequirementID = req.RequirementID " &
                "INNER JOIN Departments d " &
                "ON req.DepartmentID = d.DepartmentID " &
                "INNER JOIN AcademicTerms at " &
                "ON cr.TermID = at.TermID " &
                "INNER JOIN Users student " &
                "ON cr.StudentID = student.UserID " &
                "LEFT JOIN Users actor " &
                "ON h.ActionBy = actor.UserID "


            Dim parameters As New Dictionary(
                Of String,
                Object
            )


            ' ====================================================
            ' STUDENT VIEW
            ' ====================================================
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


            ' ====================================================
            ' ADMIN VIEW - SPECIFIC STUDENT
            ' ====================================================
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


            Dim dt As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            For Each row As DataRow In dt.Rows

                AddHistoryRow(row)

            Next


            If dgvHistory.Rows.Count > 0 Then

                dgvHistory.Rows(0).Selected =
                    True

                ShowSelectedHistoryDetails()

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


    ' ============================================================
    ' ADD HISTORY ROW TO DATAGRIDVIEW
    ' ============================================================
    Private Sub AddHistoryRow(
        row As DataRow
    )

        Dim actionDate As DateTime =
            Convert.ToDateTime(
                row("ActionAt")
            )


        Dim termText As String =
            row("AcademicYear").ToString() &
            " - " &
            row("Semester").ToString()


        Dim officeName As String =
            row("DepartmentName").ToString()


        Dim actionType As String =
            row("ActionType").ToString()


        Dim changedBy As String =
            "System"


        If Not IsDBNull(
            row("ChangedByName")
        ) AndAlso
           Not String.IsNullOrWhiteSpace(
               row("ChangedByName").ToString()
           ) Then

            changedBy =
                row("ChangedByName").
                ToString()

        End If


        Dim oldStatus As String = ""

        If Not IsDBNull(
            row("OldStatus")
        ) Then

            oldStatus =
                row("OldStatus").
                ToString()

        End If


        Dim newStatus As String = ""

        If Not IsDBNull(
            row("NewStatus")
        ) Then

            newStatus =
                row("NewStatus").
                ToString()

        End If


        Dim statusDisplay As String =
            newStatus


        If String.IsNullOrWhiteSpace(
            statusDisplay
        ) Then

            statusDisplay =
                actionType

        End If


        Dim rowIndex As Integer =
            dgvHistory.Rows.Add(
                actionDate.ToString(
                    "MMM dd, yyyy hh:mm tt"
                ),
                termText,
                officeName,
                actionType,
                changedBy,
                statusDisplay
            )


        Dim gridRow As DataGridViewRow =
            dgvHistory.Rows(rowIndex)


        Dim remarks As String = ""

        If Not IsDBNull(
            row("Remarks")
        ) Then

            remarks =
                row("Remarks").
                ToString()

        End If


        Dim fileName As String = ""

        If Not IsDBNull(
            row("SubmittedFileName")
        ) Then

            fileName =
                row("SubmittedFileName").
                ToString()

        End If


        Dim filePath As String = ""

        If Not IsDBNull(
            row("SubmittedFilePath")
        ) Then

            filePath =
                row("SubmittedFilePath").
                ToString()

        End If


        Dim submittedAt As DateTime? =
            Nothing


        If Not IsDBNull(
            row("SubmittedAt")
        ) Then

            submittedAt =
                Convert.ToDateTime(
                    row("SubmittedAt")
                )

        End If


        Dim studentName As String = ""

        If Not IsDBNull(
            row("StudentName")
        ) Then

            studentName =
                row("StudentName").
                ToString()

        End If


        gridRow.Tag =
            New HistoryDetails With {

                .HistoryID =
                    Convert.ToInt32(
                        row("HistoryID")
                    ),

                .RecordID =
                    Convert.ToInt32(
                        row("RecordID")
                    ),

                .StudentName =
                    studentName,

                .ActionType =
                    actionType,

                .ChangedBy =
                    changedBy,

                .OldStatus =
                    oldStatus,

                .NewStatus =
                    newStatus,

                .Remarks =
                    remarks,

                .FileName =
                    fileName,

                .FilePath =
                    filePath,

                .SubmittedAt =
                    submittedAt,

                .ActionAt =
                    actionDate

            }


        ApplyGridStatusColor(
            gridRow,
            newStatus
        )

    End Sub


    ' ============================================================
    ' COLOR STATUS CELL
    ' ============================================================
    Private Sub ApplyGridStatusColor(
        gridRow As DataGridViewRow,
        status As String
    )

        Dim statusCell As DataGridViewCell =
            gridRow.Cells(
                colStatus.Index
            )


        Select Case status.ToLower()

            Case "cleared"

                statusCell.Style.BackColor =
                    Color.FromArgb(
                        220,
                        252,
                        231
                    )

                statusCell.Style.ForeColor =
                    Color.FromArgb(
                        22,
                        101,
                        52
                    )


            Case "under review"

                statusCell.Style.BackColor =
                    Color.FromArgb(
                        219,
                        234,
                        254
                    )

                statusCell.Style.ForeColor =
                    Color.FromArgb(
                        30,
                        64,
                        175
                    )


            Case "rejected"

                statusCell.Style.BackColor =
                    Color.FromArgb(
                        254,
                        226,
                        226
                    )

                statusCell.Style.ForeColor =
                    Color.FromArgb(
                        185,
                        28,
                        28
                    )


            Case "pending"

                statusCell.Style.BackColor =
                    Color.FromArgb(
                        254,
                        243,
                        199
                    )

                statusCell.Style.ForeColor =
                    Color.FromArgb(
                        146,
                        64,
                        14
                    )

        End Select

    End Sub


    ' ============================================================
    ' DATAGRIDVIEW SELECTION CHANGED
    ' ============================================================
    Private Sub dgvHistory_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvHistory.SelectionChanged

        ShowSelectedHistoryDetails()

    End Sub


    ' ============================================================
    ' SHOW SELECTED HISTORY DETAILS
    ' ============================================================
    Private Sub ShowSelectedHistoryDetails()

        If dgvHistory.SelectedRows.Count = 0 Then

            ClearEventDetails()

            Return

        End If


        Dim selectedRow As DataGridViewRow =
            dgvHistory.SelectedRows(0)


        If selectedRow.Tag Is Nothing Then

            ClearEventDetails()

            Return

        End If


        selectedDetails =
            DirectCast(
                selectedRow.Tag,
                HistoryDetails
            )


        lblActionVal.Text =
            selectedDetails.ActionType


        lblChangedByVal.Text =
            selectedDetails.ChangedBy


        lblPrevStatusBadge.Text =
            If(
                String.IsNullOrWhiteSpace(
                    selectedDetails.OldStatus
                ),
                "—",
                selectedDetails.OldStatus
            )


        lblNewStatusBadge.Text =
            If(
                String.IsNullOrWhiteSpace(
                    selectedDetails.NewStatus
                ),
                "—",
                selectedDetails.NewStatus
            )


        ApplyStatusBadgeStyle(
            lblPrevStatusBadge,
            selectedDetails.OldStatus
        )


        ApplyStatusBadgeStyle(
            lblNewStatusBadge,
            selectedDetails.NewStatus
        )


        If String.IsNullOrWhiteSpace(
            selectedDetails.Remarks
        ) Then

            lblRemarksVal.Text =
                "No remarks."

        Else

            lblRemarksVal.Text =
                selectedDetails.Remarks

        End If


        ShowFileInformation()

    End Sub


    ' ============================================================
    ' SHOW FILE INFORMATION
    ' ============================================================
    Private Sub ShowFileInformation()

        If selectedDetails Is Nothing Then

            lblFileName.Text =
                "No file selected"

            lblFileMeta.Text =
                ""

            btnViewSavedFile.Enabled =
                False

            Return

        End If


        If String.IsNullOrWhiteSpace(
            selectedDetails.FileName
        ) OrElse
           String.IsNullOrWhiteSpace(
               selectedDetails.FilePath
           ) Then

            lblFileName.Text =
                "No file attached"

            lblFileMeta.Text =
                "This history event has no saved document."

            btnViewSavedFile.Enabled =
                False

            Return

        End If


        lblFileName.Text =
            selectedDetails.FileName


        If selectedDetails.SubmittedAt.HasValue Then

            lblFileMeta.Text =
                "Submitted " &
                selectedDetails.
                SubmittedAt.
                Value.
                ToString(
                    "MMM dd, yyyy hh:mm tt"
                )

        Else

            lblFileMeta.Text =
                "Saved attachment"

        End If


        btnViewSavedFile.Enabled =
            True

    End Sub


    ' ============================================================
    ' CLEAR EVENT DETAILS
    ' ============================================================
    Private Sub ClearEventDetails()

        selectedDetails =
            Nothing


        lblActionVal.Text =
            "Select a history event"


        lblChangedByVal.Text =
            "—"


        lblPrevStatusBadge.Text =
            "—"


        lblNewStatusBadge.Text =
            "—"


        lblRemarksVal.Text =
            "Select a record from the table to view details."


        lblFileName.Text =
            "No file selected"


        lblFileMeta.Text =
            ""


        btnViewSavedFile.Enabled =
            False


        ApplyStatusBadgeStyle(
            lblPrevStatusBadge,
            ""
        )


        ApplyStatusBadgeStyle(
            lblNewStatusBadge,
            ""
        )

    End Sub


    ' ============================================================
    ' STATUS BADGE STYLE
    ' ============================================================
    Private Sub ApplyStatusBadgeStyle(
        badge As Label,
        status As String
    )

        badge.TextAlign =
            ContentAlignment.MiddleCenter


        Select Case status.ToLower()

            Case "cleared"

                badge.BackColor =
                    Color.FromArgb(
                        220,
                        252,
                        231
                    )

                badge.ForeColor =
                    Color.FromArgb(
                        22,
                        101,
                        52
                    )


            Case "under review"

                badge.BackColor =
                    Color.FromArgb(
                        219,
                        234,
                        254
                    )

                badge.ForeColor =
                    Color.FromArgb(
                        30,
                        64,
                        175
                    )


            Case "rejected"

                badge.BackColor =
                    Color.FromArgb(
                        254,
                        226,
                        226
                    )

                badge.ForeColor =
                    Color.FromArgb(
                        185,
                        28,
                        28
                    )


            Case "pending"

                badge.BackColor =
                    Color.FromArgb(
                        254,
                        243,
                        199
                    )

                badge.ForeColor =
                    Color.FromArgb(
                        146,
                        64,
                        14
                    )


            Case Else

                badge.BackColor =
                    Color.FromArgb(
                        241,
                        245,
                        249
                    )

                badge.ForeColor =
                    Color.FromArgb(
                        100,
                        116,
                        139
                    )

        End Select

    End Sub


    ' ============================================================
    ' VIEW SAVED FILE
    ' ============================================================
    Private Sub btnViewSavedFile_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewSavedFile.Click

        If selectedDetails Is Nothing Then

            MessageBox.Show(
                "Please select a history record first.",
                "History",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        Dim filePath As String =
            selectedDetails.FilePath


        If String.IsNullOrWhiteSpace(
            filePath
        ) Then

            MessageBox.Show(
                "No document is attached to this record.",
                "Document",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not File.Exists(
            filePath
        ) Then

            MessageBox.Show(
                "The saved document could not be found." &
                Environment.NewLine &
                Environment.NewLine &
                "Stored path:" &
                Environment.NewLine &
                filePath,
                "File Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            Dim processInfo As New ProcessStartInfo()

            processInfo.FileName =
                filePath

            processInfo.UseShellExecute =
                True


            Process.Start(
                processInfo
            )

        Catch ex As Exception

            MessageBox.Show(
                "Unable to open the saved document." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "File Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' REFRESH
    ' ============================================================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadHistory()

    End Sub


    ' ============================================================
    ' ADMIN NAVIGATION - STUDENTS
    ' ============================================================
    Private Sub btnNavStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStudents.Click

        If AppSession.Role.Equals(
            "Admin",
            StringComparison.OrdinalIgnoreCase
        ) Then

            Me.Close()

        End If

    End Sub


    ' ============================================================
    ' ADMIN NAVIGATION - STAFF
    ' ============================================================
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


    ' ============================================================
    ' HISTORY BUTTON
    ' ============================================================
    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        LoadHistory()

    End Sub


    ' ============================================================
    ' ADMIN NAVIGATION - START NEW TERM
    ' ============================================================
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


        If answer <> DialogResult.Yes Then
            Return
        End If


        AppSession.Clear()

        Me.Close()

    End Sub


    ' ============================================================
    ' HISTORY DETAILS CLASS
    ' ============================================================
    Private Class HistoryDetails

        Public Property HistoryID As Integer

        Public Property RecordID As Integer

        Public Property StudentName As String

        Public Property ActionType As String

        Public Property ChangedBy As String

        Public Property OldStatus As String

        Public Property NewStatus As String

        Public Property Remarks As String

        Public Property FileName As String

        Public Property FilePath As String

        Public Property SubmittedAt As DateTime?

        Public Property ActionAt As DateTime

    End Class

End Class
