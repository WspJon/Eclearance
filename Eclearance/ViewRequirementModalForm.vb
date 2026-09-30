Imports System.Diagnostics
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
                "SELECT ContactNo, Address, EmergencyContactName, EmergencyContactNo " &
                "FROM Users WHERE UserID = @UserID LIMIT 1;"

            Dim dt = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@UserID", AppSession.UserID}
            })

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txtContactNo.Text = If(IsDBNull(row("ContactNo")), "", row("ContactNo").ToString())
                txtAddress.Text = If(IsDBNull(row("Address")), "", row("Address").ToString())
                txtEmergencyContactName.Text = If(IsDBNull(row("EmergencyContactName")), "", row("EmergencyContactName").ToString())
                txtEmergencyContactNo.Text = If(IsDBNull(row("EmergencyContactNo")), "", row("EmergencyContactNo").ToString())
            End If
        Catch ex As Exception
            ' Keep blank fallback
        End Try
    End Sub

    Private Sub btnSaveGuidanceInfo_Click(sender As Object, e As EventArgs) Handles btnSaveGuidanceInfo.Click
        Dim contact = txtContactNo.Text.Trim()
        Dim address = txtAddress.Text.Trim()
        Dim emName = txtEmergencyContactName.Text.Trim()
        Dim emNo = txtEmergencyContactNo.Text.Trim()

        If String.IsNullOrWhiteSpace(contact) OrElse String.IsNullOrWhiteSpace(address) Then
            MessageBox.Show("Please provide at least your Contact Number and Current Address.", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim updateSql As String =
                "UPDATE Users SET " &
                "  ContactNo = @ContactNo, " &
                "  Address = @Address, " &
                "  EmergencyContactName = @EmergencyContactName, " &
                "  EmergencyContactNo = @EmergencyContactNo, " &
                "  GuidanceInfoUpdated = 1 " &
                "WHERE UserID = @UserID;"

            Dim params As New Dictionary(Of String, Object) From {
                {"@ContactNo", contact},
                {"@Address", address},
                {"@EmergencyContactName", emName},
                {"@EmergencyContactNo", emNo},
                {"@UserID", AppSession.UserID}
            }

            db.ExecuteNonQuery(updateSql, params)

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
