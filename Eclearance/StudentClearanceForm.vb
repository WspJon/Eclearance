Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Linq

Public Class StudentClearanceForm

    Private ReadOnly db As New DatabaseHelper()

    Private currentPage As Integer = 1
    Private Const PageSize As Integer = 4

    Private allClearanceRecords As New DataTable()
    Private filteredClearanceRecords As New DataTable()


    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub StudentClearanceForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetupStudentInformation()
        SetupFilter()
        LoadClearanceData()

    End Sub


    ' ============================================================
    ' STUDENT INFORMATION
    ' ============================================================
    Private Sub SetupStudentInformation()

        lblUserName.Text = AppSession.FullName
        lblUserRole.Text = "Student"

        lblStudentCourseYear.Text =
            AppSession.Course &
            "  •  " &
            AppSession.YearLevel

        Dim initials As String = ""

        If Not String.IsNullOrWhiteSpace(AppSession.FullName) Then

            Dim names() As String =
                AppSession.FullName.Split(
                    " "c,
                    StringSplitOptions.RemoveEmptyEntries
                )

            If names.Length >= 2 Then

                initials =
                    names(0).Substring(0, 1).ToUpper() &
                    names(names.Length - 1).Substring(0, 1).ToUpper()

            ElseIf names.Length = 1 Then

                initials =
                    names(0).Substring(0, 1).ToUpper()

            End If

        End If

        lblUserAvatar.Text = initials

    End Sub


    ' ============================================================
    ' FILTER OPTIONS
    ' ============================================================
    Private Sub SetupFilter()

        cmbFilterOffices.Items.Clear()

        cmbFilterOffices.Items.Add("All offices")
        cmbFilterOffices.Items.Add("Pending")
        cmbFilterOffices.Items.Add("Under Review")
        cmbFilterOffices.Items.Add("Cleared")
        cmbFilterOffices.Items.Add("Rejected")

        cmbFilterOffices.SelectedIndex = 0

    End Sub


    ' ============================================================
    ' LOAD ALL CLEARANCE DATA
    ' ============================================================
    Private Sub LoadClearanceData()

        Try

            Dim activeTermID As Integer =
                GetActiveTermID()

            If activeTermID = 0 Then

                lblTermBadge.Text = "No Active Term"

                ClearOfficeCards()

                lblProgressSub.Text =
                    "No active clearance term"

                lblProgressPercent.Text = "0%"

                pbOverall.Value = 0

                lblAttentionTitle.Text =
                    "No clearance term available"

                lblAttentionDesc.Text =
                    "Please contact the administrator."

                Return

            End If

            LoadCurrentTerm(activeTermID)

            Dim query As String =
                "SELECT " &
                "cr.RecordID, " &
                "cr.StudentID, " &
                "cr.RequirementID, " &
                "cr.TermID, " &
                "cr.Status, " &
                "cr.Remarks, " &
                "cr.SubmittedFilePath, " &
                "cr.SubmittedFileName, " &
                "cr.SubmittedAt, " &
                "cr.ReviewedAt, " &
                "r.RequirementName, " &
                "r.Instructions, " &
                "r.RequiresFile, " &
                "d.DepartmentID, " &
                "d.DepartmentName " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r " &
                "ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Departments d " &
                "ON r.DepartmentID = d.DepartmentID " &
                "WHERE cr.StudentID = @StudentID " &
                "AND cr.TermID = @TermID " &
                "ORDER BY d.DepartmentName ASC;"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID},
                {"@TermID", activeTermID}
            }

            allClearanceRecords =
                db.ExecuteQuery(
                    query,
                    parameters
                )

            currentPage = 1

            ApplyFilter()
            UpdateProgress()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load your clearance information." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Clearance Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' GET ACTIVE TERM ID
    ' ============================================================
    Private Function GetActiveTermID() As Integer

        Dim query As String =
            "SELECT TermID " &
            "FROM AcademicTerms " &
            "WHERE IsActive = 1 " &
            "ORDER BY TermID DESC " &
            "LIMIT 1;"

        Dim result As Object =
            db.ExecuteScalar(query)

        If result Is Nothing OrElse
           result Is DBNull.Value Then

            Return 0

        End If

        Return Convert.ToInt32(result)

    End Function


    ' ============================================================
    ' DISPLAY CURRENT TERM
    ' ============================================================
    Private Sub LoadCurrentTerm(
        termID As Integer
    )

        Dim query As String =
            "SELECT AcademicYear, Semester " &
            "FROM AcademicTerms " &
            "WHERE TermID = @TermID " &
            "LIMIT 1;"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@TermID", termID}
        }

        Dim dt As DataTable =
            db.ExecuteQuery(
                query,
                parameters
            )

        If dt.Rows.Count > 0 Then

            Dim row As DataRow =
                dt.Rows(0)

            lblTermBadge.Text =
                row("AcademicYear").ToString() &
                " • " &
                row("Semester").ToString()

        Else

            lblTermBadge.Text =
                "Current Term"

        End If

    End Sub


    ' ============================================================
    ' APPLY STATUS FILTER
    ' ============================================================
    Private Sub ApplyFilter()

        If allClearanceRecords Is Nothing Then
            Return
        End If

        filteredClearanceRecords =
            allClearanceRecords.Clone()

        Dim selectedFilter As String =
            "All offices"

        If cmbFilterOffices.SelectedItem IsNot Nothing Then

            selectedFilter =
                cmbFilterOffices.SelectedItem.ToString()

        End If

        For Each row As DataRow In allClearanceRecords.Rows

            Dim status As String =
                row("Status").ToString()

            If selectedFilter = "All offices" OrElse
               status.Equals(
                   selectedFilter,
                   StringComparison.OrdinalIgnoreCase
               ) Then

                filteredClearanceRecords.ImportRow(row)

            End If

        Next

        currentPage = 1

        DisplayCurrentPage()

    End Sub


    ' ============================================================
    ' DISPLAY CURRENT PAGE
    ' ============================================================
    Private Sub DisplayCurrentPage()

        ClearOfficeCards()

        Dim totalRecords As Integer =
            filteredClearanceRecords.Rows.Count

        If totalRecords = 0 Then

            lblShowingOffices.Text =
                "Showing 0 of 0 offices"

            UpdatePaginationButtons()

            Return

        End If

        Dim totalPages As Integer =
            CInt(
                Math.Ceiling(
                    totalRecords / CDbl(PageSize)
                )
            )

        If currentPage > totalPages Then
            currentPage = totalPages
        End If

        If currentPage < 1 Then
            currentPage = 1
        End If

        Dim startIndex As Integer =
            (currentPage - 1) * PageSize

        Dim endIndex As Integer =
            Math.Min(
                startIndex + PageSize,
                totalRecords
            )

        For index As Integer =
            startIndex To endIndex - 1

            Dim row As DataRow =
                filteredClearanceRecords.Rows(index)

            PopulateOfficeCard(index, row)

        Next

        lblShowingOffices.Text =
            "Showing " &
            (startIndex + 1).ToString() &
            "-" &
            endIndex.ToString() &
            " of " &
            totalRecords.ToString() &
            " offices"

        UpdatePaginationButtons()

    End Sub


    ' ============================================================
    ' HIDE/RESET OFFICE CARDS
    ' ============================================================
    Private Sub ClearOfficeCards()

        pnlOfficeCard1.Visible = False
        pnlOfficeCard2.Visible = False
        pnlOfficeCard3.Visible = False
        pnlOfficeCard4.Visible = False
        pnlOfficeCard5.Visible = False
        pnlOfficeCard6.Visible = False
        pnlOfficeCard7.Visible = False
        pnlOfficeCard8.Visible = False

    End Sub


    ' ============================================================
    ' POPULATE DESIGNER OFFICE CARD
    ' ============================================================
    Private Sub PopulateOfficeCard(
        cardIndex As Integer,
        row As DataRow
    )

        Dim cardPanel As Panel = Nothing
        Dim lblIcon As Label = Nothing
        Dim lblTitle As Label = Nothing
        Dim lblBadge As Label = Nothing
        Dim lblDesc As Label = Nothing
        Dim pnlFile As Panel = Nothing
        Dim lblFileIco As Label = Nothing
        Dim lblFileNm As Label = Nothing
        Dim lblFileDt As Label = Nothing
        Dim btnAct As Button = Nothing
        Dim btnRmv As Button = Nothing

        Select Case cardIndex
            Case 0
                cardPanel = pnlOfficeCard1
                lblIcon = lblOfficeIcon1
                lblTitle = lblOfficeTitle1
                lblBadge = lblOfficeStatusBadge1
                lblDesc = lblOfficeDesc1
                pnlFile = pnlFileAttach1
                lblFileIco = lblFileIcon1
                lblFileNm = lblFileName1
                lblFileDt = lblFileDate1
                btnAct = btnAction1
                btnRmv = btnrmvsub1

            Case 1
                cardPanel = pnlOfficeCard2
                lblIcon = lblOfficeIcon2
                lblTitle = lblOfficeTitle2
                lblBadge = lblOfficeStatusBadge2
                lblDesc = lblOfficeDesc2
                pnlFile = pnlFileAttach2
                lblFileIco = lblFileIcon2
                lblFileNm = lblFileName2
                lblFileDt = lblFileDate2
                btnAct = btnAction2
                btnRmv = btnrmvsub2

            Case 2
                cardPanel = pnlOfficeCard3
                lblIcon = lblOfficeIcon3
                lblTitle = lblOfficeTitle3
                lblBadge = lblOfficeStatusBadge3
                lblDesc = lblOfficeDesc3
                pnlFile = pnlFileAttach3
                lblFileIco = lblFileIcon3
                lblFileNm = lblFileName3
                lblFileDt = lblFileDate3
                btnAct = btnAction3
                btnRmv = btnrmvsub3

            Case 3
                cardPanel = pnlOfficeCard4
                lblIcon = lblOfficeIcon4
                lblTitle = lblOfficeTitle4
                lblBadge = lblOfficeStatusBadge4
                lblDesc = lblOfficeDesc4
                pnlFile = pnlFileAttach4
                lblFileIco = lblFileIcon4
                lblFileNm = lblFileName4
                lblFileDt = lblFileDate4
                btnAct = btnAction4
                btnRmv = btnrmvsub4

            Case 4
                cardPanel = pnlOfficeCard5
                lblIcon = lblOfficeIcon5
                lblTitle = lblOfficeTitle5
                lblBadge = lblOfficeStatusBadge5
                lblDesc = lblOfficeDesc5
                pnlFile = pnlFileAttach5
                lblFileIco = lblFileIcon5
                lblFileNm = lblFileName5
                lblFileDt = lblFileDate5
                btnAct = btnAction5
                btnRmv = btnrmvsub5

            Case 5
                cardPanel = pnlOfficeCard6
                lblIcon = lblOfficeIcon6
                lblTitle = lblOfficeTitle6
                lblBadge = lblOfficeStatusBadge6
                lblDesc = lblOfficeDesc6
                pnlFile = pnlFileAttach6
                lblFileIco = lblFileIcon6
                lblFileNm = lblFileName6
                lblFileDt = lblFileDate6
                btnAct = btnAction6
                btnRmv = btnrmvsub6

            Case 6
                cardPanel = pnlOfficeCard7
                lblIcon = lblOfficeIcon7
                lblTitle = lblOfficeTitle7
                lblBadge = lblOfficeStatusBadge7
                lblDesc = lblOfficeDesc7
                pnlFile = pnlFileAttach7
                lblFileIco = lblFileIcon7
                lblFileNm = lblFileName7
                lblFileDt = lblFileDate7
                btnAct = btnAction7
                btnRmv = btnrmvsub7

            Case 7
                cardPanel = pnlOfficeCard8
                lblIcon = lblOfficeIcon8
                lblTitle = lblOfficeTitle8
                lblBadge = lblOfficeStatusBadge8
                lblDesc = lblOfficeDesc8
                pnlFile = pnlFileAttach8
                lblFileIco = lblFileIcon8
                lblFileNm = lblFileName8
                lblFileDt = lblFileDate8
                btnAct = btnAction8
                btnRmv = btnrmvsub8

            Case Else
                Return
        End Select

        Dim recordID As Integer =
            Convert.ToInt32(row("RecordID"))

        Dim officeName As String =
            row("DepartmentName").ToString()

        Dim requirementName As String =
            row("RequirementName").ToString()

        Dim instructions As String =
            row("Instructions").ToString()

        Dim status As String =
            row("Status").ToString()

        Dim requiresFile As Boolean =
            Convert.ToBoolean(row("RequiresFile"))

        Dim fileName As String = ""
        If Not IsDBNull(row("SubmittedFileName")) Then
            fileName = row("SubmittedFileName").ToString()
        End If

        Dim filePath As String = ""
        If Not IsDBNull(row("SubmittedFilePath")) Then
            filePath = row("SubmittedFilePath").ToString()
        End If

        cardPanel.Visible = True
        lblTitle.Text = officeName
        lblDesc.Text = requirementName & If(Not String.IsNullOrWhiteSpace(instructions), " — " & instructions, "")
        lblBadge.Text = status
        ApplyStatusStyle(lblBadge, status)
        lblIcon.Text = "🏛"

        If Not String.IsNullOrWhiteSpace(fileName) Then
            pnlFile.Visible = True
            lblFileNm.Text = fileName
            Dim submittedAtText As String = ""
            If Not IsDBNull(row("SubmittedAt")) Then
                Dim submittedDate As DateTime = Convert.ToDateTime(row("SubmittedAt"))
                submittedAtText = "Submitted " & submittedDate.ToString("MMM dd, yyyy hh:mm tt").ToLower()
            Else
                submittedAtText = "Submitted file"
            End If
            lblFileDt.Text = submittedAtText
        Else
            pnlFile.Visible = True
            lblFileNm.Text = "No document uploaded"
            lblFileDt.Text = If(requiresFile, "Upload required", "No file required")
        End If

        btnAct.Tag =
            New ClearanceActionInfo With {
                .RecordID = recordID,
                .Status = status,
                .RequiresFile = requiresFile,
                .FilePath = filePath
            }

        ConfigureActionButton(
            btnAct,
            status,
            requiresFile,
            filePath
        )

        If btnRmv IsNot Nothing Then
            btnRmv.Tag =
                New ClearanceActionInfo With {
                    .RecordID = recordID,
                    .Status = status,
                    .RequiresFile = requiresFile,
                    .FilePath = filePath
                }

            ConfigureRemoveButton(
                btnRmv,
                status,
                requiresFile,
                filePath
            )
        End If

    End Sub

    ' ============================================================
    ' STATUS COLORS
    ' ============================================================
    Private Sub ApplyStatusStyle(
        lblStatus As Label,
        status As String
    )

        Select Case status.ToLower()

            Case "cleared"

                lblStatus.BackColor =
                    Color.FromArgb(
                        220,
                        252,
                        231
                    )

                lblStatus.ForeColor =
                    Color.FromArgb(
                        22,
                        101,
                        52
                    )


            Case "under review"

                lblStatus.BackColor =
                    Color.FromArgb(
                        219,
                        234,
                        254
                    )

                lblStatus.ForeColor =
                    Color.FromArgb(
                        30,
                        64,
                        175
                    )


            Case "rejected"

                lblStatus.BackColor =
                    Color.FromArgb(
                        254,
                        226,
                        226
                    )

                lblStatus.ForeColor =
                    Color.FromArgb(
                        185,
                        28,
                        28
                    )


            Case Else

                lblStatus.BackColor =
                    Color.FromArgb(
                        254,
                        243,
                        199
                    )

                lblStatus.ForeColor =
                    Color.FromArgb(
                        146,
                        64,
                        14
                    )

        End Select

    End Sub


    ' ============================================================
    ' ACTION BUTTON APPEARANCE
    ' ============================================================
    Private Sub ConfigureActionButton(
        button As Button,
        status As String,
        requiresFile As Boolean,
        filePath As String
    )

        If Not requiresFile Then

            button.Text =
                "Waiting for office clearance"

            button.Enabled =
                False

            button.BackColor =
                Color.FromArgb(
                    226,
                    232,
                    240
                )

            button.ForeColor =
                Color.FromArgb(
                    100,
                    116,
                    139
                )

            Return

        End If


        Select Case status.ToLower()

            Case "pending"

                button.Text =
                    "Upload requirement"

                button.Enabled =
                    True

                button.BackColor =
                    Color.FromArgb(
                        11,
                        99,
                        229
                    )

                button.ForeColor =
                    Color.White


            Case "rejected"

                button.Text =
                    "Upload corrected document"

                button.Enabled =
                    True

                button.BackColor =
                    Color.FromArgb(
                        220,
                        38,
                        38
                    )

                button.ForeColor =
                    Color.White


            Case "under review"

                If Not String.IsNullOrWhiteSpace(filePath) Then

                    button.Text =
                        "View submitted document"

                    button.Enabled =
                        True

                Else

                    button.Text =
                        "Under Review"

                    button.Enabled =
                        False

                End If


                button.BackColor =
                    Color.FromArgb(
                        59,
                        130,
                        246
                    )

                button.ForeColor =
                    Color.White


            Case "cleared"

                If Not String.IsNullOrWhiteSpace(filePath) Then

                    button.Text =
                        "Cleared - View document"

                    button.Enabled =
                        True

                Else

                    button.Text =
                        "Requirement cleared"

                    button.Enabled =
                        False

                End If


                button.BackColor =
                    Color.FromArgb(
                        22,
                        163,
                        74
                    )

                button.ForeColor =
                    Color.White


            Case Else

                button.Text =
                    "View requirement"

                button.Enabled =
                    False

                button.BackColor =
                    Color.FromArgb(
                        226,
                        232,
                        240
                    )

                button.ForeColor =
                    Color.FromArgb(
                        100,
                        116,
                        139
                    )

        End Select

    End Sub
 
    ' ============================================================
    ' REMOVE BUTTON APPEARANCE
    ' ============================================================
    Private Sub ConfigureRemoveButton(
        button As Button,
        status As String,
        requiresFile As Boolean,
        filePath As String
    )
        If button Is Nothing Then Return

        If Not requiresFile Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "No file required"
            button.Cursor = Cursors.Default
            Return
        End If

        If status.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "Cleared - Locked"
            button.Cursor = Cursors.Default
            Return
        End If

        If Not String.IsNullOrWhiteSpace(filePath) Then
            button.Enabled = True
            button.BackColor = Color.FromArgb(220, 38, 38)
            button.ForeColor = Color.White
            button.Text = "Remove submitted document"
            button.Cursor = Cursors.Hand
        Else
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "No document uploaded"
            button.Cursor = Cursors.Default
        End If
    End Sub

    ' ============================================================
    ' CARD REMOVE SUBMITTED DOCUMENT CLICK
    ' ============================================================
    Private Sub RemoveSubmittedDocumentButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnrmvsub1.Click, btnrmvsub2.Click, btnrmvsub3.Click, btnrmvsub4.Click,
              btnrmvsub5.Click, btnrmvsub6.Click, btnrmvsub7.Click, btnrmvsub8.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceActionInfo) Then
            Return
        End If

        Dim info = DirectCast(button.Tag, ClearanceActionInfo)

        If info.Status.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show(
                "A cleared clearance requirement cannot be removed.",
                "Cannot Remove",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        If String.IsNullOrWhiteSpace(info.FilePath) Then
            MessageBox.Show(
                "There is no submitted document to remove.",
                "No Document",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "Are you sure you want to remove your submitted document for this office?" & vbCrLf & vbCrLf &
            "Your submitted file will be deleted and your clearance status will be reset to Pending.",
            "Remove Submitted Document",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        ExecuteRemoveSubmittedDocument(info.RecordID, info.FilePath, info.Status)
    End Sub

    Private Sub ExecuteRemoveSubmittedDocument(
        recordID As Integer,
        filePath As String,
        oldStatus As String
    )
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim updateQuery As String =
                            "UPDATE ClearanceRecords " &
                            "SET SubmittedFilePath = NULL, " &
                            "SubmittedFileName = NULL, " &
                            "SubmittedAt = NULL, " &
                            "Status = 'Pending', " &
                            "Remarks = NULL, " &
                            "ReviewedBy = NULL, " &
                            "ReviewedAt = NULL " &
                            "WHERE RecordID = @RecordID AND StudentID = @StudentID;"

                        Using updateCmd As New MySqlCommand(updateQuery, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@RecordID", recordID)
                            updateCmd.Parameters.AddWithValue("@StudentID", AppSession.UserID)
                            Dim affectedRows As Integer = updateCmd.ExecuteNonQuery()
                            If affectedRows = 0 Then
                                Throw New Exception("The clearance record could not be updated.")
                            End If
                        End Using

                        Dim historyQuery As String =
                            "INSERT INTO ClearanceHistory " &
                            "(RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks) " &
                            "VALUES (@RecordID, @ActionBy, 'Document Removed', @OldStatus, 'Pending', 'Student removed submitted document');"

                        Using histCmd As New MySqlCommand(historyQuery, conn, transaction)
                            histCmd.Parameters.AddWithValue("@RecordID", recordID)
                            histCmd.Parameters.AddWithValue("@ActionBy", AppSession.UserID)
                            histCmd.Parameters.AddWithValue("@OldStatus", oldStatus)
                            histCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            ' Delete physical file from disk if it exists
            If Not String.IsNullOrWhiteSpace(filePath) Then
                Try
                    Dim fullPath As String = filePath
                    If Not Path.IsPathRooted(fullPath) Then
                        fullPath = Path.Combine(Application.StartupPath, filePath)
                    End If
                    If File.Exists(fullPath) Then
                        File.Delete(fullPath)
                    End If
                Catch
                    ' Physical file delete exception ignored if DB update succeeded
                End Try
            End If

            MessageBox.Show(
                "Your submitted document has been removed successfully. Clearance status is now Pending.",
                "Document Removed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadClearanceData()

        Catch ex As Exception
            MessageBox.Show(
                "Failed to remove submitted document: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub


    ' ============================================================
    ' CARD ACTION BUTTON CLICK
    ' ============================================================
    Private Sub ClearanceActionButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAction1.Click, btnAction2.Click, btnAction3.Click, btnAction4.Click, btnAction5.Click, btnAction6.Click, btnAction7.Click, btnAction8.Click

        Dim button =
            DirectCast(
                sender,
                Button
            )

        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceActionInfo) Then
            Return
        End If

        Dim info =
            DirectCast(
                button.Tag,
                ClearanceActionInfo
            )

        Select Case info.Status.ToLower

            Case "pending",
                 "rejected"

                UploadRequirement(
                    info.RecordID
                )


            Case "under review",
                 "cleared"

                OpenSubmittedFile(
                    info.FilePath
                )

        End Select

    End Sub


    ' ============================================================
    ' UPLOAD REQUIREMENT
    ' ============================================================
    Private Sub UploadRequirement(
        recordID As Integer
    )

        Using dialog As New OpenFileDialog()

            dialog.Title =
                "Select clearance requirement"

            dialog.Filter =
                "Supported Files (*.pdf;*.jpg;*.jpeg;*.png)|*.pdf;*.jpg;*.jpeg;*.png"

            dialog.Multiselect =
                False


            If dialog.ShowDialog() <>
               DialogResult.OK Then

                Return

            End If


            Dim selectedFile As String =
                dialog.FileName

            Dim fileInfo As New FileInfo(
                selectedFile
            )

            Const maxFileSize As Long =
                10L * 1024L * 1024L


            If fileInfo.Length >
               maxFileSize Then

                MessageBox.Show(
                    "The selected file exceeds the 10 MB limit.",
                    "File Too Large",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim extension As String =
                Path.GetExtension(
                    selectedFile
                ).ToLower()

            Dim allowedExtensions() As String = {
                ".pdf",
                ".jpg",
                ".jpeg",
                ".png"
            }


            If Not allowedExtensions.Contains(extension) Then

                MessageBox.Show(
                    "Only PDF, JPG, JPEG, and PNG files are allowed.",
                    "Unsupported File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim answer As DialogResult =
                MessageBox.Show(
                    "Submit this document for review?" &
                    Environment.NewLine &
                    Environment.NewLine &
                    fileInfo.Name,
                    "Submit Requirement",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )


            If answer <>
               DialogResult.Yes Then

                Return

            End If


            Try

                Dim uploadFolder As String =
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "Uploads",
                        "Student_" &
                        AppSession.UserID.ToString()
                    )


                If Not Directory.Exists(uploadFolder) Then

                    Directory.CreateDirectory(
                        uploadFolder
                    )

                End If


                Dim savedFileName As String =
                    recordID.ToString() &
                    "_" &
                    DateTime.Now.ToString(
                        "yyyyMMddHHmmss"
                    ) &
                    extension


                Dim destinationPath As String =
                    Path.Combine(
                        uploadFolder,
                        savedFileName
                    )


                File.Copy(
                    selectedFile,
                    destinationPath,
                    True
                )


                SaveSubmission(
                    recordID,
                    destinationPath,
                    fileInfo.Name
                )


                MessageBox.Show(
                    "Your requirement was submitted successfully." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Status: Under Review",
                    "Requirement Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                LoadClearanceData()

            Catch ex As Exception

                MessageBox.Show(
                    "The file could not be submitted." &
                    Environment.NewLine &
                    Environment.NewLine &
                    ex.Message,
                    "Upload Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End Using

    End Sub


    ' ============================================================
    ' SAVE SUBMISSION TO DATABASE
    ' ============================================================
    Private Sub SaveSubmission(
        recordID As Integer,
        filePath As String,
        originalFileName As String
    )

        Using conn As MySqlConnection =
            db.GetConnection()

            conn.Open()

            Using transaction As MySqlTransaction =
                conn.BeginTransaction()

                Try

                    Dim oldStatus As String =
                        "Pending"


                    Dim getStatusQuery As String =
                        "SELECT Status " &
                        "FROM ClearanceRecords " &
                        "WHERE RecordID = @RecordID " &
                        "AND StudentID = @StudentID " &
                        "LIMIT 1;"


                    Using statusCmd As New MySqlCommand(
                        getStatusQuery,
                        conn,
                        transaction
                    )

                        statusCmd.Parameters.AddWithValue(
                            "@RecordID",
                            recordID
                        )

                        statusCmd.Parameters.AddWithValue(
                            "@StudentID",
                            AppSession.UserID
                        )


                        Dim statusResult As Object =
                            statusCmd.ExecuteScalar()


                        If statusResult Is Nothing Then

                            Throw New Exception(
                                "The clearance record was not found."
                            )

                        End If


                        oldStatus =
                            statusResult.ToString()

                    End Using


                    If oldStatus.Equals(
                        "Cleared",
                        StringComparison.OrdinalIgnoreCase
                    ) Then

                        Throw New Exception(
                            "A cleared requirement cannot be replaced."
                        )

                    End If


                    If oldStatus.Equals(
                        "Under Review",
                        StringComparison.OrdinalIgnoreCase
                    ) Then

                        Throw New Exception(
                            "This requirement is already under review."
                        )

                    End If


                    Dim updateQuery As String =
                        "UPDATE ClearanceRecords " &
                        "SET SubmittedFilePath = @FilePath, " &
                        "SubmittedFileName = @FileName, " &
                        "SubmittedAt = CURRENT_TIMESTAMP, " &
                        "Status = 'Under Review', " &
                        "Remarks = NULL, " &
                        "ReviewedBy = NULL, " &
                        "ReviewedAt = NULL " &
                        "WHERE RecordID = @RecordID " &
                        "AND StudentID = @StudentID;"


                    Using updateCmd As New MySqlCommand(
                        updateQuery,
                        conn,
                        transaction
                    )

                        updateCmd.Parameters.AddWithValue(
                            "@FilePath",
                            filePath
                        )

                        updateCmd.Parameters.AddWithValue(
                            "@FileName",
                            originalFileName
                        )

                        updateCmd.Parameters.AddWithValue(
                            "@RecordID",
                            recordID
                        )

                        updateCmd.Parameters.AddWithValue(
                            "@StudentID",
                            AppSession.UserID
                        )


                        Dim affectedRows As Integer =
                            updateCmd.ExecuteNonQuery()


                        If affectedRows = 0 Then

                            Throw New Exception(
                                "The clearance record could not be updated."
                            )

                        End If

                    End Using


                    Dim historyQuery As String =
                        "INSERT INTO ClearanceHistory " &
                        "(" &
                        "RecordID, " &
                        "ActionBy, " &
                        "ActionType, " &
                        "OldStatus, " &
                        "NewStatus, " &
                        "Remarks" &
                        ") " &
                        "VALUES " &
                        "(" &
                        "@RecordID, " &
                        "@ActionBy, " &
                        "'Document Submitted', " &
                        "@OldStatus, " &
                        "'Under Review', " &
                        "@Remarks" &
                        ");"


                    Using historyCmd As New MySqlCommand(
                        historyQuery,
                        conn,
                        transaction
                    )

                        historyCmd.Parameters.AddWithValue(
                            "@RecordID",
                            recordID
                        )

                        historyCmd.Parameters.AddWithValue(
                            "@ActionBy",
                            AppSession.UserID
                        )

                        historyCmd.Parameters.AddWithValue(
                            "@OldStatus",
                            oldStatus
                        )

                        historyCmd.Parameters.AddWithValue(
                            "@Remarks",
                            "Student submitted " &
                            originalFileName
                        )

                        historyCmd.ExecuteNonQuery()

                    End Using


                    transaction.Commit()

                Catch

                    transaction.Rollback()

                    Throw

                End Try

            End Using

        End Using

    End Sub


    ' ============================================================
    ' OPEN SUBMITTED FILE
    ' ============================================================
    Private Sub OpenSubmittedFile(
        filePath As String
    )

        If String.IsNullOrWhiteSpace(
            filePath
        ) Then

            MessageBox.Show(
                "No submitted document is available.",
                "Document",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If Not File.Exists(filePath) Then

            MessageBox.Show(
                "The submitted document could not be found." &
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
                "Unable to open the document." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Document Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' UPDATE PROGRESS
    ' ============================================================
    Private Sub UpdateProgress()

        Dim total As Integer =
            allClearanceRecords.Rows.Count


        If total = 0 Then

            pbOverall.Value = 0

            lblProgressPercent.Text =
                "0%"

            lblProgressSub.Text =
                "0 of 0 offices cleared"

            lblAttentionTitle.Text =
                "No clearance requirements"

            lblAttentionDesc.Text =
                "No requirements are available for the current term."

            Return

        End If


        Dim clearedCount As Integer = 0
        Dim attentionCount As Integer = 0


        For Each row As DataRow In allClearanceRecords.Rows

            Dim status As String =
                row("Status").ToString()


            If status.Equals(
                "Cleared",
                StringComparison.OrdinalIgnoreCase
            ) Then

                clearedCount += 1

            End If


            If status.Equals(
                "Pending",
                StringComparison.OrdinalIgnoreCase
            ) OrElse
               status.Equals(
                   "Rejected",
                   StringComparison.OrdinalIgnoreCase
               ) Then

                attentionCount += 1

            End If

        Next


        Dim percent As Integer =
            CInt(
                Math.Round(
                    clearedCount *
                    100.0 /
                    total
                )
            )


        percent =
            Math.Max(
                0,
                Math.Min(
                    100,
                    percent
                )
            )


        pbOverall.Value =
            percent

        lblProgressPercent.Text =
            percent.ToString() &
            "%"

        lblProgressSub.Text =
            clearedCount.ToString() &
            " of " &
            total.ToString() &
            " offices cleared"


        If attentionCount = 0 AndAlso
           clearedCount = total Then

            lblAttentionTitle.Text =
                "Clearance complete"

            lblAttentionDesc.Text =
                "You have completed all clearance requirements."

        Else

            lblAttentionTitle.Text =
                attentionCount.ToString() &
                If(
                    attentionCount = 1,
                    " office needs your attention",
                    " offices need your attention"
                )

            lblAttentionDesc.Text =
                "Complete pending or rejected requirements to finalize your clearance."

        End If

    End Sub


    ' ============================================================
    ' FILTER CHANGED
    ' ============================================================
    Private Sub cmbFilterOffices_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbFilterOffices.SelectedIndexChanged

        If Me.IsHandleCreated Then
            ApplyFilter()
        End If

    End Sub


    ' ============================================================
    ' REFRESH
    ' ============================================================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadClearanceData()

    End Sub


    ' ============================================================
    ' PAGE 1
    ' ============================================================
    Private Sub btnPage1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPage1.Click

        currentPage = 1

        DisplayCurrentPage()

    End Sub


    ' ============================================================
    ' PAGE 2
    ' ============================================================
    Private Sub btnPage2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPage2.Click

        If GetTotalPages() >= 2 Then

            currentPage = 2

            DisplayCurrentPage()

        End If

    End Sub


    ' ============================================================
    ' NEXT PAGE
    ' ============================================================
    Private Sub btnNextPage_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNextPage.Click

        Dim totalPages As Integer =
            GetTotalPages()


        If currentPage < totalPages Then

            currentPage += 1

            DisplayCurrentPage()

        End If

    End Sub


    ' ============================================================
    ' TOTAL PAGES
    ' ============================================================
    Private Function GetTotalPages() As Integer

        If filteredClearanceRecords Is Nothing OrElse
           filteredClearanceRecords.Rows.Count = 0 Then

            Return 1

        End If


        Return CInt(
            Math.Ceiling(
                filteredClearanceRecords.Rows.Count /
                CDbl(PageSize)
            )
        )

    End Function


    ' ============================================================
    ' UPDATE PAGINATION BUTTONS
    ' ============================================================
    Private Sub UpdatePaginationButtons()

        Dim totalPages As Integer =
            GetTotalPages()


        btnPage1.Visible =
            totalPages >= 1

        btnPage2.Visible =
            totalPages >= 2

        btnNextPage.Enabled =
            currentPage < totalPages


        If currentPage = 1 Then

            btnPage1.BackColor =
                Color.FromArgb(
                    11,
                    99,
                    229
                )

            btnPage1.ForeColor =
                Color.White

            btnPage2.BackColor =
                Color.White

            btnPage2.ForeColor =
                Color.Black

        ElseIf currentPage = 2 Then

            btnPage2.BackColor =
                Color.FromArgb(
                    11,
                    99,
                    229
                )

            btnPage2.ForeColor =
                Color.White

            btnPage1.BackColor =
                Color.White

            btnPage1.ForeColor =
                Color.Black

        End If

    End Sub


    ' ============================================================
    ' NAVIGATION - MY CLEARANCE
    ' ============================================================
    Private Sub btnNavMyClearance_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavMyClearance.Click

        ShowMyClearanceView()

    End Sub


    ' ============================================================
    ' NAVIGATION - HISTORY
    ' ============================================================
    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        ShowHistoryView()

    End Sub


    ' ============================================================
    ' SPA VIEW SWITCHING (SINGLE PAGE ARCHITECTURE)
    ' ============================================================
    Private pnlViewHost As Panel = Nothing

    Private Sub EnsureViewHost()
        If pnlViewHost Is Nothing Then
            pnlViewHost = New Panel()
            pnlViewHost.Dock = DockStyle.Fill
            pnlViewHost.Visible = False
            pnlViewHost.BackColor = Color.FromArgb(244, 246, 250)
            Me.Controls.Add(pnlViewHost)
        End If
    End Sub

    Public Sub ShowMyClearanceView()
        SetActiveNavButton(btnNavMyClearance)
        If pnlViewHost IsNot Nothing Then
            pnlViewHost.Visible = False
            pnlViewHost.Controls.Clear()
        End If
        pnlMain.Visible = True
        pnlMain.BringToFront()
        cmbFilterOffices.SelectedIndex = 0
        LoadClearanceData()
    End Sub

    Public Sub ShowHistoryView()
        SetActiveNavButton(btnNavHistory)
        Dim historyForm As New ClearanceHistoryForm()
        historyForm.StudentIDFilter = AppSession.UserID
        historyForm.StudentNameFilter = AppSession.FullName
        LoadChildFormView(historyForm)
    End Sub

    Private Sub LoadChildFormView(childForm As Form)
        EnsureViewHost()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Dim childSidebar As Control = childForm.Controls("pnlSidebar")
        If childSidebar IsNot Nothing Then
            childSidebar.Visible = False
        End If

        pnlViewHost.Controls.Clear()
        pnlViewHost.Controls.Add(childForm)
        pnlMain.Visible = False
        pnlViewHost.Visible = True
        pnlViewHost.BringToFront()
        childForm.Show()
    End Sub

    Private Sub SetActiveNavButton(activeBtn As Button)
        Dim navButtons As Button() = {btnNavMyClearance, btnNavHistory}

        For Each btn In navButtons
            If btn Is activeBtn Then
                btn.BackColor = Color.FromArgb(28, 91, 184)
                btn.ForeColor = Color.White
                btn.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
            Else
                btn.BackColor = Color.FromArgb(15, 39, 74)
                btn.ForeColor = Color.FromArgb(160, 180, 208)
                btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
            End If
        Next
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


    ' ============================================================
    ' SMALL CLASS USED BY DYNAMIC BUTTONS
    ' ============================================================
    Private Class ClearanceActionInfo

        Public Property RecordID As Integer

        Public Property Status As String

        Public Property RequiresFile As Boolean

        Public Property FilePath As String

    End Class

End Class