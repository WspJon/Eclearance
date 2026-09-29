Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics

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
                    names(names.Length - 1).
                    Substring(0, 1).
                    ToUpper()

            ElseIf names.Length = 1 Then

                initials =
                    names(0).
                    Substring(0, 1).
                    ToUpper()

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

                lblTermBadge.Text =
                    "No Active Term"

                ClearOfficeCards()

                lblProgressSub.Text =
                    "No active clearance term"

                lblProgressPercent.Text =
                    "0%"

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


            Dim parameters As New Dictionary(
                Of String,
                Object
            ) From {

                {
                    "@StudentID",
                    AppSession.UserID
                },

                {
                    "@TermID",
                    activeTermID
                }

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


        Dim parameters As New Dictionary(
            Of String,
            Object
        ) From {

            {
                "@TermID",
                termID
            }

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
                    totalRecords /
                    CDbl(PageSize)
                )
            )


        If currentPage > totalPages Then
            currentPage = totalPages
        End If


        If currentPage < 1 Then
            currentPage = 1
        End If


        Dim startIndex As Integer =
            (currentPage - 1) *
            PageSize


        Dim endIndex As Integer =
            Math.Min(
                startIndex + PageSize,
                totalRecords
            )


        For index As Integer =
            startIndex To endIndex - 1

            Dim row As DataRow =
                filteredClearanceRecords.Rows(index)

            CreateOfficeCard(row)

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
    ' REMOVE SAMPLE/DYNAMIC CARDS
    ' ============================================================
    Private Sub ClearOfficeCards()

        flpOfficesGrid.Controls.Clear()

    End Sub


    ' ============================================================
    ' CREATE OFFICE CARD
    ' ============================================================
    Private Sub CreateOfficeCard(
        row As DataRow
    )

        Dim recordID As Integer =
            Convert.ToInt32(
                row("RecordID")
            )

        Dim officeName As String =
            row("DepartmentName").ToString()

        Dim requirementName As String =
            row("RequirementName").ToString()

        Dim instructions As String =
            row("Instructions").ToString()

        Dim status As String =
            row("Status").ToString()

        Dim requiresFile As Boolean =
            Convert.ToBoolean(
                row("RequiresFile")
            )

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


        ' --------------------------------------------------------
        ' CARD PANEL
        ' --------------------------------------------------------
        Dim card As New Panel()

        card.BackColor =
            Color.White

        card.BorderStyle =
            BorderStyle.FixedSingle

        card.Margin =
            New Padding(
                3,
                3,
                16,
                16
            )

        card.Padding =
            New Padding(16)

        card.Size =
            New Size(
                440,
                215
            )


        ' --------------------------------------------------------
        ' OFFICE ICON
        ' --------------------------------------------------------
        Dim lblIcon As New Label()

        lblIcon.BackColor =
            Color.FromArgb(
                238,
                242,
                255
            )

        lblIcon.Font =
            New Font(
                "Segoe UI Emoji",
                14.0F
            )

        lblIcon.Location =
            New Point(
                16,
                15
            )

        lblIcon.Size =
            New Size(
                32,
                32
            )

        lblIcon.Text =
            "🏢"

        lblIcon.TextAlign =
            ContentAlignment.MiddleCenter


        ' --------------------------------------------------------
        ' OFFICE NAME
        ' --------------------------------------------------------
        Dim lblOffice As New Label()

        lblOffice.Font =
            New Font(
                "Segoe UI",
                11.0F,
                FontStyle.Bold
            )

        lblOffice.ForeColor =
            Color.FromArgb(
                15,
                23,
                42
            )

        lblOffice.Location =
            New Point(
                54,
                17
            )

        lblOffice.Size =
            New Size(
                245,
                28
            )

        lblOffice.Text =
            officeName


        ' --------------------------------------------------------
        ' STATUS BADGE
        ' --------------------------------------------------------
        Dim lblStatus As New Label()

        lblStatus.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblStatus.Location =
            New Point(
                310,
                17
            )

        lblStatus.Size =
            New Size(
                112,
                27
            )

        lblStatus.Text =
            status

        lblStatus.TextAlign =
            ContentAlignment.MiddleCenter

        ApplyStatusStyle(
            lblStatus,
            status
        )


        ' --------------------------------------------------------
        ' REQUIREMENT / INSTRUCTIONS
        ' --------------------------------------------------------
        Dim lblDescription As New Label()

        lblDescription.Font =
            New Font(
                "Segoe UI",
                8.5F
            )

        lblDescription.ForeColor =
            Color.FromArgb(
                100,
                116,
                139
            )

        lblDescription.Location =
            New Point(
                16,
                57
            )

        lblDescription.Size =
            New Size(
                406,
                40
            )

        If String.IsNullOrWhiteSpace(instructions) Then

            lblDescription.Text =
                requirementName

        Else

            lblDescription.Text =
                requirementName &
                " — " &
                instructions

        End If


        ' --------------------------------------------------------
        ' FILE PANEL
        ' --------------------------------------------------------
        Dim pnlFile As New Panel()

        pnlFile.BackColor =
            Color.FromArgb(
                248,
                250,
                252
            )

        pnlFile.BorderStyle =
            BorderStyle.FixedSingle

        pnlFile.Location =
            New Point(
                16,
                103
            )

        pnlFile.Size =
            New Size(
                406,
                48
            )


        Dim lblFileIcon As New Label()

        lblFileIcon.Font =
            New Font(
                "Segoe UI Emoji",
                14.0F
            )

        lblFileIcon.Location =
            New Point(
                8,
                8
            )

        lblFileIcon.Size =
            New Size(
                28,
                30
            )

        lblFileIcon.Text =
            "📄"

        lblFileIcon.TextAlign =
            ContentAlignment.MiddleCenter


        Dim lblFileName As New Label()

        lblFileName.Font =
            New Font(
                "Segoe UI Semibold",
                8.5F,
                FontStyle.Bold
            )

        lblFileName.ForeColor =
            Color.FromArgb(
                30,
                41,
                59
            )

        lblFileName.Location =
            New Point(
                42,
                6
            )

        lblFileName.Size =
            New Size(
                340,
                18
            )


        Dim lblFileDate As New Label()

        lblFileDate.Font =
            New Font(
                "Segoe UI",
                8.0F
            )

        lblFileDate.ForeColor =
            Color.FromArgb(
                148,
                163,
                184
            )

        lblFileDate.Location =
            New Point(
                42,
                25
            )

        lblFileDate.Size =
            New Size(
                340,
                17
            )


        If requiresFile Then

            If String.IsNullOrWhiteSpace(
                fileName
            ) Then

                lblFileName.Text =
                    "No document uploaded"

                lblFileDate.Text =
                    "Upload required"

            Else

                lblFileName.Text =
                    fileName


                If Not IsDBNull(
                    row("SubmittedAt")
                ) Then

                    Dim submittedDate As DateTime =
                        Convert.ToDateTime(
                            row("SubmittedAt")
                        )


                    lblFileDate.Text =
                        "Submitted " &
                        submittedDate.
                        ToString(
                            "MMM dd, yyyy hh:mm tt"
                        )

                Else

                    lblFileDate.Text =
                        "Submitted"

                End If

            End If

        Else

            lblFileName.Text =
                "No document required"

            lblFileDate.Text =
                "This office will update your status."

        End If


        pnlFile.Controls.Add(
            lblFileIcon
        )

        pnlFile.Controls.Add(
            lblFileName
        )

        pnlFile.Controls.Add(
            lblFileDate
        )


        ' --------------------------------------------------------
        ' ACTION BUTTON
        ' --------------------------------------------------------
        Dim btnAction As New Button()

        btnAction.Cursor =
            Cursors.Hand

        btnAction.FlatStyle =
            FlatStyle.Flat

        btnAction.FlatAppearance.BorderSize =
            0

        btnAction.Font =
            New Font(
                "Segoe UI Semibold",
                9.0F,
                FontStyle.Bold
            )

        btnAction.Location =
            New Point(
                16,
                161
            )

        btnAction.Size =
            New Size(
                406,
                36
            )

        btnAction.Tag =
            New ClearanceActionInfo With {
                .RecordID = recordID,
                .Status = status,
                .RequiresFile = requiresFile,
                .FilePath = filePath
            }


        ConfigureActionButton(
            btnAction,
            status,
            requiresFile,
            filePath
        )


        AddHandler btnAction.Click,
            AddressOf ClearanceActionButton_Click


        card.Controls.Add(
            lblIcon
        )

        card.Controls.Add(
            lblOffice
        )

        card.Controls.Add(
            lblStatus
        )

        card.Controls.Add(
            lblDescription
        )

        card.Controls.Add(
            pnlFile
        )

        card.Controls.Add(
            btnAction
        )


        flpOfficesGrid.Controls.Add(
            card
        )

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
                    "⬆ Upload requirement"

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
                    "↻ Upload corrected document"

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

                If Not String.IsNullOrWhiteSpace(
                    filePath
                ) Then

                    button.Text =
                        "👁 View submitted document"

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

                If Not String.IsNullOrWhiteSpace(
                    filePath
                ) Then

                    button.Text =
                        "✓ Cleared — View document"

                    button.Enabled =
                        True

                Else

                    button.Text =
                        "✓ Requirement cleared"

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
    ' CARD ACTION BUTTON CLICK
    ' ============================================================
    Private Sub ClearanceActionButton_Click(
        sender As Object,
        e As EventArgs
    )

        Dim button As Button =
            DirectCast(
                sender,
                Button
            )


        Dim info As ClearanceActionInfo =
            DirectCast(
                button.Tag,
                ClearanceActionInfo
            )


        Select Case info.Status.ToLower()

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


            ' Maximum 10 MB
            Const maxFileSize As Long =
                10L *
                1024L *
                1024L


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


            If Not allowedExtensions.Contains(
                extension
            ) Then

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


                If Not Directory.Exists(
                    uploadFolder
                ) Then

                    Directory.CreateDirectory(
                        uploadFolder
                    )

                End If


                Dim savedFileName As String =
                    recordID.ToString() &
                    "_" &
                    DateTime.Now.
                    ToString(
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


        If Not File.Exists(
            filePath
        ) Then

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

            pbOverall.Value =
                0

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


        Dim clearedCount As Integer =
            0

        Dim attentionCount As Integer =
            0


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

        cmbFilterOffices.SelectedIndex = 0

        LoadClearanceData()

    End Sub


    ' ============================================================
    ' NAVIGATION - HISTORY
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
