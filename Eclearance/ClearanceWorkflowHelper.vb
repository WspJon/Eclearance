Imports MySql.Data.MySqlClient
Imports System.Data

Public Class ClearanceWorkflowHelper

    Public Class ClearanceItemInfo
        Public Property RecordID As Integer
        Public Property RequirementID As Integer
        Public Property DepartmentID As Integer
        Public Property DepartmentName As String
        Public Property RequirementName As String
        Public Property Instructions As String
        Public Property RequirementLink As String
        Public Property RequiresFile As Boolean
        Public Property SequenceOrder As Integer
        Public Property AppliesToCourse As String
        Public Property RequiresNSTP As Boolean
        Public Property ApplicableCourses As String
        Public Property ApplicableYearLevels As String
        Public Property DBStatus As String
        Public Property EffectiveStatus As String ' Cleared, Under Review, Rejected, Pending, Locked, Not Applicable
        Public Property Remarks As String
        Public Property SubmittedFilePath As String
        Public Property SubmittedFileName As String
        Public Property SubmittedAt As Object
        Public Property IsApplicable As Boolean
        Public Property CanSubmit As Boolean
        Public Property FileCount As Integer = 0
    End Class

    ''' <summary>
    ''' Determines if a requirement is applicable to the student based on Course and Year Level.
    ''' CTHM Stock Room is only applicable to CTHM/Hospitality/Tourism programs.
    ''' NSTP is strictly applicable only to first-year students.
    ''' </summary>
    Public Shared Function IsRequirementApplicable(
        studentCourse As String,
        studentYearLevel As String,
        enrolledInNSTP As Boolean,
        appliesToCourse As String,
        requiresNSTP As Boolean,
        applicableCourses As String,
        applicableYearLevels As String
    ) As Boolean

        Dim course As String = If(studentCourse, "").Trim().ToUpperInvariant()
        Dim yearLevel As String = If(studentYearLevel, "").Trim().ToLowerInvariant()

        ' 1. Check actual NSTP enrollment applicability
        If requiresNSTP AndAlso Not enrolledInNSTP Then
            Return False
        End If

        ' 2. Check Year Level applicability
        If Not String.IsNullOrWhiteSpace(applicableYearLevels) Then
            Dim allowedLevels = applicableYearLevels.Split(New Char() {","c, ";"c, "|"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim isYearLevelMatched As Boolean = False
            
            For Each allowed In allowedLevels
                Dim cleanAllowed = allowed.Trim().ToLowerInvariant()
                If Not String.IsNullOrWhiteSpace(cleanAllowed) Then
                    If yearLevel = cleanAllowed OrElse yearLevel.Contains(cleanAllowed) Then
                        isYearLevelMatched = True
                        Exit For
                    End If
                End If
            Next
            
            If Not isYearLevelMatched Then
                Return False
            End If
        End If

        ' 3. Check Course applicability (e.g. CTHM Stock Room)
        Dim courseFilter As String = ""
        If Not String.IsNullOrWhiteSpace(applicableCourses) Then
            courseFilter = applicableCourses
        ElseIf Not String.IsNullOrWhiteSpace(appliesToCourse) Then
            courseFilter = appliesToCourse
        End If

        If Not String.IsNullOrWhiteSpace(courseFilter) Then
            Dim allowedCourses = courseFilter.Split(New Char() {","c, ";"c, "|"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim isCourseMatched As Boolean = False

            For Each allowed In allowedCourses
                Dim cleanAllowed = allowed.Trim().ToUpperInvariant()
                If Not String.IsNullOrWhiteSpace(cleanAllowed) AndAlso course = cleanAllowed Then
                    isCourseMatched = True
                    Exit For
                End If
            Next

            If Not isCourseMatched Then
                ' Course does not match (e.g. BSIT student skipping CTHM)
                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Evaluates clearance workflow according to the new clearance sequence rule:
    ''' - Steps 1–5: Parallel / Independent (Guidance, Library, Clinic, CTHM, NSTP).
    '''   None of these lock each other. Accessible immediately if applicable.
    ''' - Step 6: College Dean gate. Unlocks ONLY when ALL applicable Steps 1–5 are Cleared.
    '''   (Not Applicable counts as satisfied).
    ''' - Steps 7–9: Sequential.
    '''   Finance (Step 7) unlocks ONLY when College Dean (Step 6) is Cleared.
    '''   Registrar (Step 8) unlocks ONLY when Finance (Step 7) is Cleared.
    '''   OAA (Step 9) unlocks ONLY when Registrar (Step 8) is Cleared.
    ''' </summary>
    Public Shared Sub EvaluateSequentialWorkflow(
        items As List(Of ClearanceItemInfo),
        studentCourse As String,
        studentYearLevel As String,
        enrolledInNSTP As Boolean
    )
        If items Is Nothing Then Return

        ' 1. Determine applicability for all items
        For Each item In items
            item.IsApplicable = IsRequirementApplicable(
                studentCourse,
                studentYearLevel,
                enrolledInNSTP,
                item.AppliesToCourse,
                item.RequiresNSTP,
                item.ApplicableCourses,
                item.ApplicableYearLevels
            )
        Next

        ' Sort by SequenceOrder ascending
        Dim sorted = items.OrderBy(Function(i) i.SequenceOrder).ToList()

        ' 2. Steps 1–5: Parallel and Independent
        For Each item In sorted
            If item.SequenceOrder >= 1 AndAlso item.SequenceOrder <= 5 Then
                If Not item.IsApplicable Then
                    item.EffectiveStatus = "Not Applicable"
                    item.CanSubmit = False
                Else
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(item.DBStatus), "Pending", item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Cleared"
                        item.CanSubmit = False
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Under Review"
                        item.CanSubmit = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Rejected"
                        item.CanSubmit = True
                    Else
                        ' Pending (or legacy Locked) -> Pending and available!
                        item.EffectiveStatus = "Pending"
                        item.CanSubmit = True
                    End If
                End If
            End If
        Next

        ' 3. Check College Dean Gate: Are ALL applicable Steps 1–5 Cleared?
        ' (Not Applicable satisfies prerequisite; Pending/Under Review/Rejected/Locked block)
        Dim steps1To5Cleared As Boolean = True
        For Each itm In sorted
            If itm.SequenceOrder >= 1 AndAlso itm.SequenceOrder <= 5 Then
                If itm.IsApplicable Then
                    If Not itm.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        steps1To5Cleared = False
                        Exit For
                    End If
                End If
            End If
        Next

        ' 4. Step 6: College Dean
        Dim step6Item As ClearanceItemInfo = sorted.FirstOrDefault(Function(i) i.SequenceOrder = 6)
        Dim step6Satisfied As Boolean = False

        If step6Item IsNot Nothing Then
            If Not step6Item.IsApplicable Then
                step6Item.EffectiveStatus = "Not Applicable"
                step6Item.CanSubmit = False
                step6Satisfied = True
            Else
                If Not steps1To5Cleared Then
                    step6Item.EffectiveStatus = "Locked"
                    step6Item.CanSubmit = False
                    step6Satisfied = False
                Else
                    ' Steps 1-5 satisfied -> Step 6 unlocked!
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(step6Item.DBStatus), "Pending", step6Item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        step6Item.EffectiveStatus = "Cleared"
                        step6Item.CanSubmit = False
                        step6Satisfied = True
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        step6Item.EffectiveStatus = "Under Review"
                        step6Item.CanSubmit = False
                        step6Satisfied = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        step6Item.EffectiveStatus = "Rejected"
                        step6Item.CanSubmit = True
                        step6Satisfied = False
                    Else
                        step6Item.EffectiveStatus = "Pending"
                        step6Item.CanSubmit = True
                        step6Satisfied = False
                    End If
                End If
            End If
        Else
            step6Satisfied = True
        End If

        ' 5. Step 7: Finance (depends on Step 6)
        Dim step7Item As ClearanceItemInfo = sorted.FirstOrDefault(Function(i) i.SequenceOrder = 7)
        Dim step7Satisfied As Boolean = False

        If step7Item IsNot Nothing Then
            If Not step7Item.IsApplicable Then
                step7Item.EffectiveStatus = "Not Applicable"
                step7Item.CanSubmit = False
                step7Satisfied = True
            Else
                If Not step6Satisfied Then
                    step7Item.EffectiveStatus = "Locked"
                    step7Item.CanSubmit = False
                    step7Satisfied = False
                Else
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(step7Item.DBStatus), "Pending", step7Item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        step7Item.EffectiveStatus = "Cleared"
                        step7Item.CanSubmit = False
                        step7Satisfied = True
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        step7Item.EffectiveStatus = "Under Review"
                        step7Item.CanSubmit = False
                        step7Satisfied = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        step7Item.EffectiveStatus = "Rejected"
                        step7Item.CanSubmit = True
                        step7Satisfied = False
                    Else
                        step7Item.EffectiveStatus = "Pending"
                        step7Item.CanSubmit = True
                        step7Satisfied = False
                    End If
                End If
            End If
        Else
            step7Satisfied = True
        End If

        ' 6. Step 8: Registrar (depends on Step 7)
        Dim step8Item As ClearanceItemInfo = sorted.FirstOrDefault(Function(i) i.SequenceOrder = 8)
        Dim step8Satisfied As Boolean = False

        If step8Item IsNot Nothing Then
            If Not step8Item.IsApplicable Then
                step8Item.EffectiveStatus = "Not Applicable"
                step8Item.CanSubmit = False
                step8Satisfied = True
            Else
                If Not step7Satisfied Then
                    step8Item.EffectiveStatus = "Locked"
                    step8Item.CanSubmit = False
                    step8Satisfied = False
                Else
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(step8Item.DBStatus), "Pending", step8Item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        step8Item.EffectiveStatus = "Cleared"
                        step8Item.CanSubmit = False
                        step8Satisfied = True
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        step8Item.EffectiveStatus = "Under Review"
                        step8Item.CanSubmit = False
                        step8Satisfied = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        step8Item.EffectiveStatus = "Rejected"
                        step8Item.CanSubmit = True
                        step8Satisfied = False
                    Else
                        step8Item.EffectiveStatus = "Pending"
                        step8Item.CanSubmit = True
                        step8Satisfied = False
                    End If
                End If
            End If
        Else
            step8Satisfied = True
        End If

        ' 7. Step 9: OAA (depends on Step 8)
        Dim step9Item As ClearanceItemInfo = sorted.FirstOrDefault(Function(i) i.SequenceOrder = 9)

        If step9Item IsNot Nothing Then
            If Not step9Item.IsApplicable Then
                step9Item.EffectiveStatus = "Not Applicable"
                step9Item.CanSubmit = False
            Else
                If Not step8Satisfied Then
                    step9Item.EffectiveStatus = "Locked"
                    step9Item.CanSubmit = False
                Else
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(step9Item.DBStatus), "Pending", step9Item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        step9Item.EffectiveStatus = "Cleared"
                        step9Item.CanSubmit = False
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        step9Item.EffectiveStatus = "Under Review"
                        step9Item.CanSubmit = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        step9Item.EffectiveStatus = "Rejected"
                        step9Item.CanSubmit = True
                    Else
                        step9Item.EffectiveStatus = "Pending"
                        step9Item.CanSubmit = True
                    End If
                End If
            End If
        End If

        ' 8. General fallback for any higher steps (> 9)
        Dim previousStepSatisfied As Boolean = (step9Item Is Nothing OrElse Not step9Item.IsApplicable OrElse step9Item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) OrElse step9Item.EffectiveStatus.Equals("Not Applicable", StringComparison.OrdinalIgnoreCase))
        For Each item In sorted.Where(Function(i) i.SequenceOrder > 9)
            If Not item.IsApplicable Then
                item.EffectiveStatus = "Not Applicable"
                item.CanSubmit = False
                previousStepSatisfied = True
            Else
                If Not previousStepSatisfied Then
                    item.EffectiveStatus = "Locked"
                    item.CanSubmit = False
                Else
                    Dim dbStat As String = If(String.IsNullOrWhiteSpace(item.DBStatus), "Pending", item.DBStatus.Trim())
                    If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Cleared"
                        item.CanSubmit = False
                        previousStepSatisfied = True
                    ElseIf dbStat.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Under Review"
                        item.CanSubmit = False
                        previousStepSatisfied = False
                    ElseIf dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                        item.EffectiveStatus = "Rejected"
                        item.CanSubmit = True
                        previousStepSatisfied = False
                    Else
                        item.EffectiveStatus = "Pending"
                        item.CanSubmit = True
                        previousStepSatisfied = False
                    End If
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Loads, maps, and evaluates clearance items for a student in the specified term.
    ''' </summary>
    Public Shared Function GetStudentClearanceItems(
        studentID As Integer,
        termID As Integer,
        studentCourse As String,
        studentYearLevel As String,
        db As DatabaseHelper
    ) As List(Of ClearanceItemInfo)

        Dim result As New List(Of ClearanceItemInfo)()
        If studentID <= 0 OrElse termID <= 0 Then Return result

        Dim enrolledInNSTP As Boolean = False
        Try
            Dim nstpRes = db.ExecuteScalar(
                "SELECT EnrolledInNSTP FROM Students WHERE UserID = @UID",
                New Dictionary(Of String, Object) From {{"@UID", studentID}}
            )
            If nstpRes IsNot Nothing AndAlso Not IsDBNull(nstpRes) Then
                enrolledInNSTP = Convert.ToBoolean(nstpRes)
            End If
        Catch
        End Try

        Try
            Dim query As String =
                "SELECT " &
                "  r.RequirementID, " &
                "  r.RequirementName, " &
                "  r.Instructions, " &
                "  r.RequiresFile, " &
                "  r.SequenceOrder, " &
                "  r.RequirementLink, " &
                "  r.AppliesToCourse, " &
                "  r.RequiresNSTP, " &
                "  r.ApplicableCourses, " &
                "  r.ApplicableYearLevels, " &
                "  d.DepartmentID, " &
                "  d.DepartmentName, " &
                "  COALESCE(cr.RecordID, 0) AS RecordID, " &
                "  COALESCE(cr.Status, 'Pending') AS DBStatus, " &
                "  cr.Remarks, " &
                "  cr.SubmittedFilePath, " &
                "  cr.SubmittedFileName, " &
                "  cr.SubmittedAt, " &
                "  (SELECT COUNT(*) FROM ClearanceRecordFiles crf WHERE crf.RecordID = cr.RecordID) AS FileCount " &
                "FROM ClearanceRequirements r " &
                "INNER JOIN Departments d ON r.DepartmentID = d.DepartmentID " &
                "LEFT JOIN ClearanceRecords cr ON cr.RequirementID = r.RequirementID AND cr.StudentID = @StudentID AND cr.TermID = @TermID " &
                "WHERE r.IsActive = 1 " &
                "ORDER BY r.SequenceOrder ASC;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            })

            For Each row As DataRow In dt.Rows
                Dim item As New ClearanceItemInfo With {
                    .RecordID = Convert.ToInt32(row("RecordID")),
                    .RequirementID = Convert.ToInt32(row("RequirementID")),
                    .DepartmentID = Convert.ToInt32(row("DepartmentID")),
                    .DepartmentName = row("DepartmentName").ToString(),
                    .RequirementName = row("RequirementName").ToString(),
                    .Instructions = If(IsDBNull(row("Instructions")), "", row("Instructions").ToString()),
                    .RequirementLink = If(IsDBNull(row("RequirementLink")), "", row("RequirementLink").ToString()),
                    .RequiresFile = Convert.ToBoolean(row("RequiresFile")),
                    .SequenceOrder = Convert.ToInt32(row("SequenceOrder")),
                    .AppliesToCourse = If(IsDBNull(row("AppliesToCourse")), "", row("AppliesToCourse").ToString()),
                    .RequiresNSTP = Convert.ToBoolean(row("RequiresNSTP")),
                    .ApplicableCourses = If(IsDBNull(row("ApplicableCourses")), "", row("ApplicableCourses").ToString()),
                    .ApplicableYearLevels = If(IsDBNull(row("ApplicableYearLevels")), "", row("ApplicableYearLevels").ToString()),
                    .DBStatus = row("DBStatus").ToString(),
                    .Remarks = If(IsDBNull(row("Remarks")), "", row("Remarks").ToString()),
                    .SubmittedFilePath = If(IsDBNull(row("SubmittedFilePath")), "", row("SubmittedFilePath").ToString()),
                    .SubmittedFileName = If(IsDBNull(row("SubmittedFileName")), "", row("SubmittedFileName").ToString()),
                    .SubmittedAt = row("SubmittedAt"),
                    .FileCount = Convert.ToInt32(row("FileCount"))
                }
                result.Add(item)
            Next

            ' 1. Determine applicability for all items
            For Each item In result
                item.IsApplicable = IsRequirementApplicable(
                    studentCourse,
                    studentYearLevel,
                    enrolledInNSTP,
                    item.AppliesToCourse,
                    item.RequiresNSTP,
                    item.ApplicableCourses,
                    item.ApplicableYearLevels
                )
            Next

            ' 2. Filter Step 6 (Dean offices): Keep ONLY the student's applicable Dean office requirement
            ' Also completely hide CTHM Stock Room if it is not applicable to the student's program
            Dim filteredItems As New List(Of ClearanceItemInfo)()
            For Each item In result
                If item.SequenceOrder = 6 Then
                    If item.IsApplicable Then
                        filteredItems.Add(item)
                    End If
                ElseIf (item.DepartmentID = 8 OrElse item.RequirementName.IndexOf("CTHM Stock Room", StringComparison.OrdinalIgnoreCase) >= 0) AndAlso Not item.IsApplicable Then
                    ' Non-applicable CTHM Stock Room is hidden from clearance list
                    Continue For
                Else
                    filteredItems.Add(item)
                End If
            Next

            ' Fallback if course didn't match any specific dean but there was a dean requirement
            If Not filteredItems.Any(Function(i) i.SequenceOrder = 6) Then
                Dim firstDean = result.FirstOrDefault(Function(i) i.SequenceOrder = 6)
                If firstDean IsNot Nothing Then
                    firstDean.IsApplicable = True
                    filteredItems.Add(firstDean)
                End If
            End If

            result = filteredItems.OrderBy(Function(i) i.SequenceOrder).ToList()

            EvaluateSequentialWorkflow(result, studentCourse, studentYearLevel, enrolledInNSTP)

        Catch ex As Exception
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Computes overall student clearance status based on active-term requirements:
    ''' - Cleared: all applicable requirements are Cleared (Not Applicable counts as satisfied).
    ''' - Needs Attention: at least one applicable requirement is Rejected.
    ''' - In Progress: at least one applicable requirement is Pending or Under Review.
    ''' </summary>
    Public Shared Function ComputeStudentOverallStatus(
        studentID As Integer,
        termID As Integer,
        studentCourse As String,
        studentYearLevel As String,
        db As DatabaseHelper
    ) As String

        If termID <= 0 Then Return "No Term"

        Dim items = GetStudentClearanceItems(studentID, termID, studentCourse, studentYearLevel, db)
        If items Is Nothing OrElse items.Count = 0 Then Return "Pending"

        Dim applicableItems = items.Where(Function(i) i.IsApplicable).ToList()
        If applicableItems.Count = 0 Then Return "Cleared"

        ' 1. Needs Attention if any applicable is Rejected
        If applicableItems.Any(Function(i) i.EffectiveStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase)) Then
            Return "Needs Attention"
        End If

        ' 2. Cleared if all applicable are Cleared
        If applicableItems.All(Function(i) i.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase)) Then
            Return "Cleared"
        End If

        ' 3. In Progress if any applicable is Pending or Under Review
        If applicableItems.Any(Function(i) i.EffectiveStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse
                                           i.EffectiveStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase)) Then
            Return "In Progress"
        End If

        Return "In Progress"
    End Function

    ''' <summary>
    ''' Formats student clearance progress as "ClearedCount / TotalApplicableCount".
    ''' Non-applicable requirements do not inflate total requirement count.
    ''' </summary>
    Public Shared Function GetStudentProgressText(
        studentID As Integer,
        termID As Integer,
        studentCourse As String,
        studentYearLevel As String,
        db As DatabaseHelper
    ) As String

        If termID <= 0 Then Return "0 / 0"

        Dim items = GetStudentClearanceItems(studentID, termID, studentCourse, studentYearLevel, db)
        If items Is Nothing OrElse items.Count = 0 Then Return "0 / 0"

        Dim applicableItems = items.Where(Function(i) i.IsApplicable).ToList()
        Dim clearedCount = applicableItems.Where(Function(i) i.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase)).Count()

        Return clearedCount.ToString() & " / " & applicableItems.Count.ToString()
    End Function

    ''' <summary>
    ''' Validates whether a clearance officer can approve a clearance record.
    ''' Step 6 (College Dean) requires all applicable Steps 1-5 to be Cleared.
    ''' Steps 7+ require the immediate predecessor step to be Cleared or Not Applicable.
    ''' </summary>
    Public Shared Function CanStaffApproveRecord(
        recordID As Integer,
        db As DatabaseHelper,
        ByRef blockerReason As String
    ) As Boolean

        blockerReason = ""
        If recordID <= 0 Then
            blockerReason = "Invalid Record ID."
            Return False
        End If

        Try
            Dim dt = db.ExecuteQuery(
                "SELECT cr.StudentID, cr.TermID, r.SequenceOrder, r.RequirementName, " &
                "       COALESCE(s.Course, '') AS Course, " &
                "       COALESCE(s.YearLevel, '') AS YearLevel " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Users u ON cr.StudentID = u.UserID " &
                "LEFT JOIN Students s ON s.UserID = u.UserID " &
                "WHERE cr.RecordID = @RecordID LIMIT 1;",
                New Dictionary(Of String, Object) From {{"@RecordID", recordID}}
            )

            If dt.Rows.Count = 0 Then
                blockerReason = "Record not found."
                Return False
            End If

            Dim row = dt.Rows(0)
            Dim studentID As Integer = Convert.ToInt32(row("StudentID"))
            Dim termID As Integer = Convert.ToInt32(row("TermID"))
            Dim seqOrder As Integer = Convert.ToInt32(row("SequenceOrder"))
            Dim course As String = If(IsDBNull(row("Course")), "", row("Course").ToString())
            Dim yearLevel As String = If(IsDBNull(row("YearLevel")), "", row("YearLevel").ToString())

            ' Steps 1-5: Parallel and independent. Staff can review and approve anytime.
            If seqOrder <= 5 Then Return True

            Dim items = GetStudentClearanceItems(studentID, termID, course, yearLevel, db)

            If seqOrder = 6 Then
                ' College Dean: all applicable Steps 1-5 must be Cleared
                Dim incomplete = items.Where(Function(i) i.SequenceOrder >= 1 AndAlso i.SequenceOrder <= 5 AndAlso i.IsApplicable AndAlso Not i.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase)).ToList()
                If incomplete.Count > 0 Then
                    Dim names = String.Join(", ", incomplete.Select(Function(x) x.DepartmentName))
                    blockerReason = "Cannot approve College Dean clearance because the student has incomplete prerequisite steps: " & names & "."
                    Return False
                End If
            Else
                ' Steps 7+: Previous sequential step must be Cleared or Not Applicable
                Dim prevStep = items.FirstOrDefault(Function(i) i.SequenceOrder = seqOrder - 1)
                If prevStep IsNot Nothing AndAlso prevStep.IsApplicable AndAlso Not prevStep.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                    blockerReason = "Cannot approve this clearance because prerequisite step (" & prevStep.DepartmentName & ") is not yet cleared."
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            blockerReason = "An error occurred while validating clearance prerequisites."
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Synchronizes next sequential steps from 'Locked' to 'Pending' in the database when prerequisites are met.
    ''' </summary>
    Public Shared Sub UnlockNextStepsInDatabase(
        studentID As Integer,
        termID As Integer,
        studentCourse As String,
        studentYearLevel As String,
        db As DatabaseHelper,
        Optional conn As MySqlConnection = Nothing,
        Optional tx As MySqlTransaction = Nothing,
        Optional overrideRecordID As Integer = 0,
        Optional overrideStatus As String = ""
    )
        If studentID <= 0 OrElse termID <= 0 Then Return

        Try
            Dim items = GetStudentClearanceItems(studentID, termID, studentCourse, studentYearLevel, db)
            If items Is Nothing OrElse items.Count = 0 Then Return

            ' If we're inside a transaction, the DB read might not see the uncommitted new status.
            ' Manually override the status in memory before evaluating the workflow.
            If overrideRecordID > 0 AndAlso Not String.IsNullOrWhiteSpace(overrideStatus) Then
                Dim targetItem = items.FirstOrDefault(Function(x) x.RecordID = overrideRecordID)
                If targetItem IsNot Nothing Then
                    targetItem.DBStatus = overrideStatus
                    targetItem.EffectiveStatus = overrideStatus
                End If

                ' We need to re-evaluate the workflow since we mutated an item manually.
                Dim enrolledInNSTP As Boolean = False
                Dim nstpRes = db.ExecuteScalar("SELECT EnrolledInNSTP FROM Students WHERE UserID = " & studentID)
                If nstpRes IsNot Nothing AndAlso Not IsDBNull(nstpRes) Then enrolledInNSTP = Convert.ToBoolean(nstpRes)
                
                EvaluateSequentialWorkflow(items, studentCourse, studentYearLevel, enrolledInNSTP)
            End If

            Dim updateStepStatus = Sub(seq As Integer, newStat As String)
                Dim itm = items.FirstOrDefault(Function(x) x.SequenceOrder = seq)
                If itm IsNot Nothing AndAlso itm.RecordID > 0 Then
                    Dim sql As String = "UPDATE ClearanceRecords SET Status = @Status WHERE RecordID = @RecordID AND Status = 'Locked';"
                    Dim pms As New Dictionary(Of String, Object) From {
                        {"@Status", newStat},
                        {"@RecordID", itm.RecordID}
                    }
                    If conn IsNot Nothing AndAlso tx IsNot Nothing Then
                        Using cmd As New MySqlCommand(sql, conn, tx)
                            cmd.Parameters.AddWithValue("@Status", newStat)
                            cmd.Parameters.AddWithValue("@RecordID", itm.RecordID)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        db.ExecuteNonQuery(sql, pms)
                    End If
                End If
            End Sub

            ' Check Steps 1-5: If all applicable are Cleared, unlock Step 6
            Dim steps1To5Cleared As Boolean = True
            For Each itm In items
                If itm.SequenceOrder >= 1 AndAlso itm.SequenceOrder <= 5 AndAlso itm.IsApplicable Then
                    If Not itm.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                        steps1To5Cleared = False
                        Exit For
                    End If
                End If
            Next

            If steps1To5Cleared Then
                updateStepStatus(6, "Pending")
            End If

            ' Check Step 6: If Cleared or Not Applicable, unlock Step 7
            Dim itm6 = items.FirstOrDefault(Function(x) x.SequenceOrder = 6)
            If itm6 Is Nothing OrElse Not itm6.IsApplicable OrElse itm6.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                If steps1To5Cleared Then
                    updateStepStatus(7, "Pending")
                End If
            End If

            ' Check Step 7: If Cleared or Not Applicable, unlock Step 8
            Dim itm7 = items.FirstOrDefault(Function(x) x.SequenceOrder = 7)
            If itm7 Is Nothing OrElse Not itm7.IsApplicable OrElse itm7.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                updateStepStatus(8, "Pending")
            End If

            ' Check Step 8: If Cleared or Not Applicable, unlock Step 9
            Dim itm8 = items.FirstOrDefault(Function(x) x.SequenceOrder = 8)
            If itm8 Is Nothing OrElse Not itm8.IsApplicable OrElse itm8.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                updateStepStatus(9, "Pending")
            End If

        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Resolves the Dean DepartmentID for a given student course from CoursePrograms.
    ''' </summary>
    Public Shared Function GetDeanDepartmentForCourse(course As String, db As DatabaseHelper) As Integer
        Dim cleanCourse As String = If(course, "").Trim().ToUpperInvariant()
        If String.IsNullOrWhiteSpace(cleanCourse) Then Return 0
        Try
            Dim dt = db.ExecuteQuery(
                "SELECT DeanDepartmentID FROM CoursePrograms WHERE UPPER(CourseCode) = @Course AND IsActive = 1 LIMIT 1;",
                New Dictionary(Of String, Object) From {{"@Course", cleanCourse}}
            )
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("DeanDepartmentID"))
            End If

            ' Partial match fallback
            Dim dtAll = db.ExecuteQuery("SELECT CourseCode, DeanDepartmentID FROM CoursePrograms WHERE IsActive = 1;")
            For Each row As DataRow In dtAll.Rows
                Dim code = row("CourseCode").ToString().Trim().ToUpperInvariant()
                If cleanCourse.Contains(code) OrElse code.Contains(cleanCourse) Then
                    Return Convert.ToInt32(row("DeanDepartmentID"))
                End If
            Next
        Catch ex As Exception
        End Try
        Return 0
    End Function

    ''' <summary>
    ''' Resolves the Dean RequirementID for a given student course.
    ''' </summary>
    Public Shared Function GetDeanRequirementForCourse(course As String, db As DatabaseHelper) As Integer
        Dim deanDeptID = GetDeanDepartmentForCourse(course, db)
        If deanDeptID > 0 Then
            Try
                Dim res = db.ExecuteScalar(
                    "SELECT RequirementID FROM ClearanceRequirements WHERE DepartmentID = @DeptID AND SequenceOrder = 6 AND IsActive = 1 LIMIT 1;",
                    New Dictionary(Of String, Object) From {{"@DeptID", deanDeptID}}
                )
                If res IsNot Nothing AndAlso Not IsDBNull(res) Then
                    Return Convert.ToInt32(res)
                End If
            Catch ex As Exception
            End Try
        End If
        Return 0
    End Function

End Class
