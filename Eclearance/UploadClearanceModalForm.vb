Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UploadClearanceModalForm

    Private ReadOnly db As New DatabaseHelper()

    Public Property RecordID As Integer = 0
    Public Property DepartmentName As String = ""
    Public Property RequirementName As String = ""

    Private ReadOnly selectedFilePaths As New List(Of String)()
    Private Const MaxFileSize As Long = 10L * 1024L * 1024L ' 10 MB

    Private Sub UploadClearanceModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblModalTitle.Text = If(String.IsNullOrWhiteSpace(DepartmentName), "Upload Requirement", "Upload: " & DepartmentName)
        lblOfficeSubtitle.Text = If(String.IsNullOrWhiteSpace(RequirementName), "Select files to submit for review.", RequirementName)
        UpdateFileListUI()
    End Sub

    Private Sub UpdateFileListUI()
        lstSelectedFiles.Items.Clear()
        For Each filePath In selectedFilePaths
            Dim fi As New FileInfo(filePath)
            Dim sizeMb As Double = fi.Length / (1024.0 * 1024.0)
            lstSelectedFiles.Items.Add(fi.Name & " (" & sizeMb.ToString("0.00") & " MB)")
        Next
        lblFilesCount.Text = "(" & selectedFilePaths.Count.ToString() & " file(s) selected)"
        btnRemoveFile.Enabled = (selectedFilePaths.Count > 0)
        btnSubmit.Enabled = (selectedFilePaths.Count > 0)
    End Sub

    Private Sub btnAddFiles_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click
        Using dialog As New OpenFileDialog()
            dialog.Title = "Select Clearance Documents"
            dialog.Filter = "Supported Files (*.pdf;*.jpg;*.jpeg;*.png)|*.pdf;*.jpg;*.jpeg;*.png"
            dialog.Multiselect = True

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim allowedExtensions() As String = {".pdf", ".jpg", ".jpeg", ".png"}

                For Each selectedPath In dialog.FileNames
                    If selectedFilePaths.Contains(selectedPath) Then
                        Continue For
                    End If

                    Dim fi As New FileInfo(selectedPath)
                    If fi.Length > MaxFileSize Then
                        MessageBox.Show("File '" & fi.Name & "' exceeds the 10 MB limit and was skipped.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    Dim ext = fi.Extension.ToLowerInvariant()
                    If Not allowedExtensions.Contains(ext) Then
                        MessageBox.Show("File '" & fi.Name & "' is not a supported format (.pdf, .jpg, .jpeg, .png).", "Unsupported File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    selectedFilePaths.Add(selectedPath)
                Next

                UpdateFileListUI()
            End If
        End Using
    End Sub

    Private Sub btnRemoveFile_Click(sender As Object, e As EventArgs) Handles btnRemoveFile.Click
        Dim selectedIdx As Integer = lstSelectedFiles.SelectedIndex
        If selectedIdx >= 0 AndAlso selectedIdx < selectedFilePaths.Count Then
            selectedFilePaths.RemoveAt(selectedIdx)
            UpdateFileListUI()
        Else
            MessageBox.Show("Please select a file from the list to remove.", "Select File", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If selectedFilePaths.Count = 0 Then
            MessageBox.Show("Please add at least one document or image file before submitting.", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmRes As DialogResult = MessageBox.Show(
            "Are you sure you want to submit " & selectedFilePaths.Count.ToString() & " file(s) for review?",
            "Confirm Submission",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmRes <> DialogResult.Yes Then Return

        Try
            Dim uploadFolder As String = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Uploads",
                "Student_" & AppSession.UserID.ToString()
            )

            If Not Directory.Exists(uploadFolder) Then
                Directory.CreateDirectory(uploadFolder)
            End If

            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' 1. Check current record status
                        Dim oldStatus As String = "Pending"
                        Dim checkQuery As String =
                            "SELECT Status FROM ClearanceRecords WHERE RecordID = @RecordID AND StudentID = @StudentID LIMIT 1;"

                        Using checkCmd As New MySqlCommand(checkQuery, conn, transaction)
                            checkCmd.Parameters.AddWithValue("@RecordID", RecordID)
                            checkCmd.Parameters.AddWithValue("@StudentID", AppSession.UserID)
                            Dim res = checkCmd.ExecuteScalar()
                            If res IsNot Nothing AndAlso Not IsDBNull(res) Then
                                oldStatus = res.ToString()
                            End If
                        End Using

                        If oldStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                            Throw New Exception("A cleared requirement cannot be resubmitted.")
                        End If

                        ' 2. Copy files and insert into ClearanceRecordFiles
                        Dim primaryFilePath As String = ""
                        Dim primaryFileName As String = ""

                        For i As Integer = 0 To selectedFilePaths.Count - 1
                            Dim sourcePath As String = selectedFilePaths(i)
                            Dim fi As New FileInfo(sourcePath)
                            Dim guidStr As String = Guid.NewGuid().ToString("N").Substring(0, 8)
                            Dim uniqueName As String = RecordID.ToString() & "_" & guidStr & "_" & (i + 1).ToString() & fi.Extension.ToLowerInvariant()
                            Dim destPath As String = Path.Combine(uploadFolder, uniqueName)

                            File.Copy(sourcePath, destPath, True)

                            If i = 0 Then
                                primaryFilePath = destPath
                                primaryFileName = fi.Name
                            End If

                            Dim insertFileSql As String =
                                "INSERT INTO ClearanceRecordFiles (RecordID, StoredFilePath, OriginalFileName, UploadedAt) " &
                                "VALUES (@RecordID, @StoredFilePath, @OriginalFileName, CURRENT_TIMESTAMP);"

                            Using fileCmd As New MySqlCommand(insertFileSql, conn, transaction)
                                fileCmd.Parameters.AddWithValue("@RecordID", RecordID)
                                fileCmd.Parameters.AddWithValue("@StoredFilePath", destPath)
                                fileCmd.Parameters.AddWithValue("@OriginalFileName", fi.Name)
                                fileCmd.ExecuteNonQuery()
                            End Using
                        Next

                        ' Format summary file name
                        Dim summaryFileName As String = primaryFileName
                        If selectedFilePaths.Count > 1 Then
                            summaryFileName &= " (+" & (selectedFilePaths.Count - 1).ToString() & " more)"
                        End If

                        ' 3. Update ClearanceRecords
                        Dim updateSql As String =
                            "UPDATE ClearanceRecords SET " &
                            "  SubmittedFilePath = @FilePath, " &
                            "  SubmittedFileName = @FileName, " &
                            "  SubmittedAt = CURRENT_TIMESTAMP, " &
                            "  Status = 'Under Review', " &
                            "  Remarks = NULL, " &
                            "  ReviewedBy = NULL, " &
                            "  ReviewedAt = NULL " &
                            "WHERE RecordID = @RecordID AND StudentID = @StudentID;"

                        Using updateCmd As New MySqlCommand(updateSql, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@FilePath", primaryFilePath)
                            updateCmd.Parameters.AddWithValue("@FileName", summaryFileName)
                            updateCmd.Parameters.AddWithValue("@RecordID", RecordID)
                            updateCmd.Parameters.AddWithValue("@StudentID", AppSession.UserID)
                            updateCmd.ExecuteNonQuery()
                        End Using

                        ' 4. Add History entry
                        Dim historySql As String =
                            "INSERT INTO ClearanceHistory (RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks) " &
                            "VALUES (@RecordID, @ActionBy, @ActionType, @OldStatus, 'Under Review', @Remarks);"

                        Using histCmd As New MySqlCommand(historySql, conn, transaction)
                            histCmd.Parameters.AddWithValue("@RecordID", RecordID)
                            histCmd.Parameters.AddWithValue("@ActionBy", AppSession.UserID)
                            histCmd.Parameters.AddWithValue("@ActionType", If(oldStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase), "Resubmitted", "Submitted"))
                            histCmd.Parameters.AddWithValue("@OldStatus", oldStatus)
                            histCmd.Parameters.AddWithValue("@Remarks", "Uploaded " & selectedFilePaths.Count.ToString() & " file(s) for review.")
                            histCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                        MessageBox.Show(
                            "Successfully submitted " & selectedFilePaths.Count.ToString() & " document(s) for review." & Environment.NewLine & Environment.NewLine &
                            "Status is now: Under Review",
                            "Submission Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to submit files: " & ex.Message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
