Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ReviewClearanceForm

    Public Property TargetRecordID As Integer = 0

    Private ReadOnly db As New DatabaseHelper()
    Private currentDepartmentName As String = "Assigned Office"
    Private currentFilePath As String = ""
    Private currentStatus As String = "Pending"

    Private Sub ReviewClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStaffInfo()
        If TargetRecordID > 0 Then
            LoadSubmissionDetails()
            LoadTimeline()
        Else
            MessageBox.Show("No clearance submission specified.", "Invalid Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub InitializeStaffInfo()
        lblStaffName.Text = If(String.IsNullOrWhiteSpace(AppSession.FullName), "Staff Officer", AppSession.FullName)
        lblDateTimeBadge.Text = "📅 " & DateTime.Now.ToString("dddd, MMM dd, yyyy")

        If AppSession.DepartmentID.HasValue Then
            Try
                Dim dtDept As DataTable = db.ExecuteQuery(
                    "SELECT DepartmentName FROM Departments WHERE DepartmentID = @DeptID LIMIT 1;",
                    New Dictionary(Of String, Object) From {{"@DeptID", AppSession.DepartmentID.Value}}
                )
                If dtDept.Rows.Count > 0 Then
                    currentDepartmentName = dtDept.Rows(0)("DepartmentName").ToString()
                End If
            Catch ex As Exception
                ' Keep fallback
            End Try
        End If

        lblOfficeName.Text = currentDepartmentName
    End Sub

    Private Sub LoadSubmissionDetails()
        Try
            Dim query As String =
                "SELECT " &
                "  cr.RecordID, " &
                "  cr.Status, " &
                "  cr.Remarks, " &
                "  cr.SubmittedFilePath, " &
                "  cr.SubmittedFileName, " &
                "  cr.SubmittedAt, " &
                "  u.StudentNo, " &
                "  u.FullName AS StudentName, " &
                "  u.Course, " &
                "  u.YearLevel, " &
                "  d.DepartmentName, " &
                "  r.RequirementName " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Departments d ON r.DepartmentID = d.DepartmentID " &
                "INNER JOIN Users u ON cr.StudentID = u.UserID " &
                "WHERE cr.RecordID = @RecordID LIMIT 1;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {{"@RecordID", TargetRecordID}})
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Submission record not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If

            Dim row = dt.Rows(0)
            lblStudentNoVal.Text = row("StudentNo").ToString()
            lblStudentNameVal.Text = row("StudentName").ToString()
            lblCourseVal.Text = If(IsDBNull(row("Course")) OrElse String.IsNullOrWhiteSpace(row("Course").ToString()), "N/A", row("Course").ToString())
            lblYearVal.Text = If(IsDBNull(row("YearLevel")) OrElse String.IsNullOrWhiteSpace(row("YearLevel").ToString()), "N/A", row("YearLevel").ToString())
            lblOfficeVal.Text = row("DepartmentName").ToString()
            lblReqVal.Text = row("RequirementName").ToString()

            If Not IsDBNull(row("SubmittedAt")) Then
                Dim subDate As DateTime = Convert.ToDateTime(row("SubmittedAt"))
                lblDateVal.Text = subDate.ToString("MMM dd, yyyy hh:mm tt")
            Else
                lblDateVal.Text = "Not yet submitted"
            End If

            currentStatus = row("Status").ToString()
            lblStatusBadge.Text = currentStatus

            If Not IsDBNull(row("Remarks")) Then
                txtRemarks.Text = row("Remarks").ToString()
                lblCharCount.Text = txtRemarks.Text.Length.ToString() & " / 500"
            End If

            currentFilePath = ""
            If Not IsDBNull(row("SubmittedFilePath")) Then
                currentFilePath = row("SubmittedFilePath").ToString()
            End If

            Dim fileName As String = "No document attached"
            If Not IsDBNull(row("SubmittedFileName")) Then
                fileName = row("SubmittedFileName").ToString()
            End If
            lblFileVal.Text = fileName
            lblDocFileName.Text = fileName

            LoadDocumentPreview()

        Catch ex As Exception
            MessageBox.Show("Failed to load submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDocumentPreview()
        If String.IsNullOrWhiteSpace(currentFilePath) Then
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "No Document Attached"
            lblPdfSub.Text = "The student has not uploaded any file for this clearance requirement."
            btnOpenExternal.Enabled = False
            btnOpenPdfCenter.Enabled = False
            Return
        End If

        btnOpenExternal.Enabled = True
        btnOpenPdfCenter.Enabled = True

        Dim fullPath As String = currentFilePath
        If Not Path.IsPathRooted(fullPath) Then
            fullPath = Path.Combine(Application.StartupPath, currentFilePath)
        End If

        If Not File.Exists(fullPath) Then
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "File Not Found On Server"
            lblPdfSub.Text = "The submitted document file cannot be found at: " & Path.GetFileName(fullPath)
            Return
        End If

        Dim ext As String = Path.GetExtension(fullPath).ToLower()
        If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".bmp" Then
            Try
                Using stream As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                    picPreview.Image = Image.FromStream(stream)
                End Using
                picPreview.Visible = True
                pnlPdfFallback.Visible = False
            Catch
                picPreview.Visible = False
                pnlPdfFallback.Visible = True
                lblPdfPrompt.Text = "Image Preview Error"
                lblPdfSub.Text = "Click Open Document to view this image in default photos app."
            End Try
        Else
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "PDF Document Ready"
            lblPdfSub.Text = "Click Open Document to view this file in your default PDF reader."
        End If
    End Sub

    Private Sub OpenSubmittedDocument()
        If String.IsNullOrWhiteSpace(currentFilePath) Then
            MessageBox.Show("No document attached.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fullPath As String = currentFilePath
        If Not Path.IsPathRooted(fullPath) Then
            fullPath = Path.Combine(Application.StartupPath, currentFilePath)
        End If

        If Not File.Exists(fullPath) Then
            MessageBox.Show("The file does not exist on disk: " & fullPath, "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim psi As New ProcessStartInfo(fullPath) With {.UseShellExecute = True}
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Failed to open document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadTimeline()
        flpTimeline.Controls.Clear()
        Try
            Dim query As String =
                "SELECT " &
                "  h.ActionType, " &
                "  h.OldStatus, " &
                "  h.NewStatus, " &
                "  h.Remarks, " &
                "  h.ActionAt, " &
                "  COALESCE(u.FullName, 'System') AS PerformedBy " &
                "FROM ClearanceHistory h " &
                "LEFT JOIN Users u ON h.ActionBy = u.UserID " &
                "WHERE h.RecordID = @RecordID " &
                "ORDER BY h.ActionAt DESC;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {{"@RecordID", TargetRecordID}})

            If dt.Rows.Count = 0 Then
                Dim lblEmpty As New Label With {
                    .Text = "No previous activity logged.",
                    .AutoSize = True,
                    .ForeColor = Color.FromArgb(100, 116, 139),
                    .Margin = New Padding(4, 10, 4, 4)
                }
                flpTimeline.Controls.Add(lblEmpty)
                Return
            End If

            For Each row As DataRow In dt.Rows
                Dim pnlItem As New Panel With {
                    .Width = 230,
                    .Height = 65,
                    .Margin = New Padding(0, 0, 0, 8),
                    .BackColor = Color.FromArgb(248, 250, 252)
                }

                Dim lblAction As New Label With {
                    .Text = "• " & row("ActionType").ToString(),
                    .Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                    .ForeColor = Color.FromArgb(15, 23, 42),
                    .Location = New Point(4, 4),
                    .AutoSize = True
                }

                Dim actionDate As DateTime = Convert.ToDateTime(row("ActionAt"))
                Dim lblTime As New Label With {
                    .Text = actionDate.ToString("MMM dd, yyyy hh:mm tt"),
                    .Font = New Font("Segoe UI", 7.5F),
                    .ForeColor = Color.FromArgb(100, 116, 139),
                    .Location = New Point(4, 24),
                    .AutoSize = True
                }

                Dim remarksText As String = If(IsDBNull(row("Remarks")), "", row("Remarks").ToString())
                Dim lblRem As New Label With {
                    .Text = If(String.IsNullOrWhiteSpace(remarksText), "By " & row("PerformedBy").ToString(), remarksText),
                    .Font = New Font("Segoe UI", 7.5F),
                    .ForeColor = Color.FromArgb(71, 85, 105),
                    .Location = New Point(4, 42),
                    .Size = New Size(220, 18)
                }

                pnlItem.Controls.Add(lblAction)
                pnlItem.Controls.Add(lblTime)
                pnlItem.Controls.Add(lblRem)
                flpTimeline.Controls.Add(pnlItem)
            Next

        Catch ex As Exception
            ' Timeline error
        End Try
    End Sub

    ' Remarks char count
    Private Sub txtRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRemarks.TextChanged
        lblCharCount.Text = txtRemarks.Text.Length.ToString() & " / 500"
    End Sub

    ' Open Document buttons
    Private Sub btnOpenExternal_Click(sender As Object, e As EventArgs) Handles btnOpenExternal.Click, btnOpenPdfCenter.Click
        OpenSubmittedDocument()
    End Sub

    ' Decision: Approve / Clear
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim remarks As String = txtRemarks.Text.Trim()
        Dim confirm = MessageBox.Show(
            "Are you sure you want to APPROVE and CLEAR this requirement for " & lblStudentNameVal.Text & "?",
            "Confirm Clearance Approval",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm <> DialogResult.Yes Then Return

        UpdateClearanceStatus("Cleared", remarks, "Requirement Approved / Cleared")
    End Sub

    ' Decision: Reject (Remarks REQUIRED!)
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim remarks As String = txtRemarks.Text.Trim()

        If String.IsNullOrWhiteSpace(remarks) Then
            MessageBox.Show(
                "Remarks are REQUIRED when rejecting a clearance request." & vbCrLf & vbCrLf &
                "Please explain to the student what is missing or needs correction.",
                "Remarks Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtRemarks.Focus()
            Return
        End If

        Dim confirm = MessageBox.Show(
            "Are you sure you want to REJECT this requirement?",
            "Confirm Rejection",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm <> DialogResult.Yes Then Return

        UpdateClearanceStatus("Rejected", remarks, "Requirement Rejected")
    End Sub

    Private Sub UpdateClearanceStatus(newStatus As String, remarks As String, actionTypeName As String)
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim updateQuery As String =
                            "UPDATE ClearanceRecords " &
                            "SET Status = @NewStatus, " &
                            "    Remarks = @Remarks, " &
                            "    ReviewedBy = @ReviewedBy, " &
                            "    ReviewedAt = CURRENT_TIMESTAMP " &
                            "WHERE RecordID = @RecordID;"

                        Using updateCmd As New MySqlCommand(updateQuery, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@NewStatus", newStatus)
                            updateCmd.Parameters.AddWithValue("@Remarks", If(String.IsNullOrWhiteSpace(remarks), DBNull.Value, CObj(remarks)))
                            updateCmd.Parameters.AddWithValue("@ReviewedBy", AppSession.UserID)
                            updateCmd.Parameters.AddWithValue("@RecordID", TargetRecordID)
                            updateCmd.ExecuteNonQuery()
                        End Using

                        Dim histQuery As String =
                            "INSERT INTO ClearanceHistory " &
                            "(RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks) " &
                            "VALUES (@RecordID, @ActionBy, @ActionType, @OldStatus, @NewStatus, @Remarks);"

                        Using histCmd As New MySqlCommand(histQuery, conn, transaction)
                            histCmd.Parameters.AddWithValue("@RecordID", TargetRecordID)
                            histCmd.Parameters.AddWithValue("@ActionBy", AppSession.UserID)
                            histCmd.Parameters.AddWithValue("@ActionType", actionTypeName)
                            histCmd.Parameters.AddWithValue("@OldStatus", currentStatus)
                            histCmd.Parameters.AddWithValue("@NewStatus", newStatus)
                            histCmd.Parameters.AddWithValue("@Remarks", If(String.IsNullOrWhiteSpace(remarks), actionTypeName, remarks))
                            histCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show(
                "Clearance status has been updated to: " & newStatus & " successfully.",
                "Decision Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to save decision: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReturnToRequests()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnBackToRequests.Click
        ReturnToRequests()
    End Sub
End Class
