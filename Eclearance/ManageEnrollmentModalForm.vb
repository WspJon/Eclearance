Imports System.Data

Public Class ManageEnrollmentModalForm

    Private ReadOnly _studentID As Integer
    Private ReadOnly _studentNo As String
    Private ReadOnly _studentName As String
    Private ReadOnly _course As String
    Private ReadOnly db As New DatabaseHelper()

    Private Class TermItem
        Public Property TermID As Integer
        Public Property DisplayText As String

        Public Overrides Function ToString() As String
            Return DisplayText
        End Function
    End Class

    Public Sub New(studentID As Integer, studentNo As String, studentName As String, course As String)
        InitializeComponent()
        _studentID = studentID
        _studentNo = studentNo
        _studentName = studentName
        _course = course
    End Sub

    Private Sub ManageEnrollmentModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentNameVal.Text = If(String.IsNullOrWhiteSpace(_studentName), "Student", _studentName)
        lblStudentInfoVal.Text = If(String.IsNullOrWhiteSpace(_studentNo), "N/A", _studentNo) & " | " & If(String.IsNullOrWhiteSpace(_course), "Student", _course)

        LoadTerms()
    End Sub

    Private Sub LoadTerms()
        Try
            ClearanceWorkflowHelper.EnsureEnrollmentTableExists(db)

            ' First determine active term and ensure predecessor term is registered
            Dim activeTermID As Integer = 0
            Dim dtActive = db.ExecuteQuery("SELECT TermID FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
            If dtActive.Rows.Count > 0 Then
                activeTermID = Convert.ToInt32(dtActive.Rows(0)("TermID"))
            End If

            Dim prevTermInfo = ClearanceWorkflowHelper.GetPreviousAcademicTerm(activeTermID, db)

            cmbAcademicTerm.Items.Clear()
            Dim query As String = "SELECT TermID, AcademicYear, Semester, IsActive FROM AcademicTerms ORDER BY TermID DESC;"
            Dim dt As DataTable = db.ExecuteQuery(query)

            Dim items As New List(Of TermItem)()

            For Each row As DataRow In dt.Rows
                Dim tId As Integer = Convert.ToInt32(row("TermID"))
                Dim ay As String = row("AcademicYear").ToString()
                Dim sem As String = row("Semester").ToString()
                Dim isActive As Boolean = Convert.ToBoolean(row("IsActive"))

                Dim text As String = ay & " | " & sem
                If isActive Then
                    text &= " (Current Active Term)"
                ElseIf prevTermInfo.TermID = tId Then
                    text &= " (Previous Semester)"
                End If
                items.Add(New TermItem With {.TermID = tId, .DisplayText = text})
            Next

            For Each item In items
                cmbAcademicTerm.Items.Add(item)
            Next

            ' Default selection to previous semester
            Dim defaultIndex As Integer = 0
            If prevTermInfo.TermID > 0 Then
                For i As Integer = 0 To cmbAcademicTerm.Items.Count - 1
                    Dim itm = CType(cmbAcademicTerm.Items(i), TermItem)
                    If itm.TermID = prevTermInfo.TermID Then
                        defaultIndex = i
                        Exit For
                    End If
                Next
            End If

            If cmbAcademicTerm.Items.Count > 0 Then
                cmbAcademicTerm.SelectedIndex = defaultIndex
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading academic terms: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbAcademicTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcademicTerm.SelectedIndexChanged
        If cmbAcademicTerm.SelectedItem Is Nothing Then Return
        Dim selectedTerm = CType(cmbAcademicTerm.SelectedItem, TermItem)

        Try
            Dim details = ClearanceWorkflowHelper.GetStudentPreviousEnrollmentDetails(_studentID, selectedTerm.TermID, db)

            ' Match enrollment status
            Dim matchedStatusIdx As Integer = cmbEnrollmentStatus.Items.Count - 1 ' default "No Record"
            For i As Integer = 0 To cmbEnrollmentStatus.Items.Count - 1
                Dim itemText = cmbEnrollmentStatus.Items(i).ToString()
                If String.Equals(itemText, details.Status, StringComparison.OrdinalIgnoreCase) Then
                    matchedStatusIdx = i
                    Exit For
                ElseIf (details.Status.IndexOf("Returnee", StringComparison.OrdinalIgnoreCase) >= 0 OrElse details.Status.IndexOf("Drop-out", StringComparison.OrdinalIgnoreCase) >= 0) AndAlso (itemText.IndexOf("Returnee", StringComparison.OrdinalIgnoreCase) >= 0 OrElse itemText.IndexOf("Drop-out", StringComparison.OrdinalIgnoreCase) >= 0) Then
                    matchedStatusIdx = i
                    Exit For
                ElseIf (details.Status.IndexOf("New Student", StringComparison.OrdinalIgnoreCase) >= 0 OrElse details.Status.Equals("N/A", StringComparison.OrdinalIgnoreCase)) AndAlso itemText.IndexOf("New Student", StringComparison.OrdinalIgnoreCase) >= 0 Then
                    matchedStatusIdx = i
                    Exit For
                ElseIf details.Status.IndexOf("Transferee", StringComparison.OrdinalIgnoreCase) >= 0 AndAlso itemText.IndexOf("Transferee", StringComparison.OrdinalIgnoreCase) >= 0 Then
                    matchedStatusIdx = i
                    Exit For
                End If
            Next
            cmbEnrollmentStatus.SelectedIndex = matchedStatusIdx

            ' Match verification basis
            Dim matchedBasisIdx As Integer = 0
            If Not String.IsNullOrWhiteSpace(details.VerificationBasis) Then
                For i As Integer = 0 To cmbVerificationBasis.Items.Count - 1
                    If String.Equals(cmbVerificationBasis.Items(i).ToString(), details.VerificationBasis, StringComparison.OrdinalIgnoreCase) Then
                        matchedBasisIdx = i
                        Exit For
                    End If
                Next
            ElseIf details.Status.Equals("No Record", StringComparison.OrdinalIgnoreCase) Then
                matchedBasisIdx = 4 ' "No Document Available / Unestablished"
            End If
            cmbVerificationBasis.SelectedIndex = matchedBasisIdx

            txtRemarks.Text = details.Remarks

            ' Update audit info text
            If Not String.IsNullOrWhiteSpace(details.VerifiedByName) Then
                Dim dateStr = If(details.VerificationDate.HasValue, details.VerificationDate.Value.ToString("MMM dd, yyyy hh:mm tt"), "Date unrecorded")
                lblAuditInfo.Text = "Last verified by " & details.VerifiedByName & " on " & dateStr
                If Not String.IsNullOrWhiteSpace(details.VerificationBasis) Then
                    lblAuditInfo.Text &= " [" & details.VerificationBasis & "]"
                End If
            Else
                lblAuditInfo.Text = "Last verified: No record recorded yet for this term."
            End If

        Catch ex As Exception
            cmbEnrollmentStatus.SelectedIndex = 2
            cmbVerificationBasis.SelectedIndex = 0
            txtRemarks.Text = String.Empty
            lblAuditInfo.Text = "Last verified: No record recorded yet."
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbAcademicTerm.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an academic term.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbEnrollmentStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an enrollment status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedTerm = CType(cmbAcademicTerm.SelectedItem, TermItem)
        Dim status = cmbEnrollmentStatus.SelectedItem.ToString()
        Dim basis = If(cmbVerificationBasis.SelectedItem IsNot Nothing, cmbVerificationBasis.SelectedItem.ToString(), "Manual Verification")
        Dim remarks = txtRemarks.Text.Trim()

        Dim success = ClearanceWorkflowHelper.SetStudentTermEnrollment(
            _studentID,
            selectedTerm.TermID,
            status,
            remarks,
            AppSession.UserID,
            basis,
            db
        )

        If success Then
            MessageBox.Show(
                "Enrollment record updated successfully for " & _studentName & "." & vbCrLf & vbCrLf &
                "Term: " & selectedTerm.DisplayText & vbCrLf &
                "Status: " & status & vbCrLf &
                "Basis: " & basis,
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Unable to save enrollment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
