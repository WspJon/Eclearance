-- ============================================================
-- Non-destructive Migration: Add Evaluation Survey Requirements
-- Updates CCS, CTHM, CBA, COE College Deans, and Office of Student Affairs
-- Sets Requirement Name, Instructions, RequiresFile = 1, and Demo Survey Link
-- ============================================================

-- 1. Office of Student Affairs (DepartmentID = 4)
UPDATE `clearancerequirements`
SET
    `RequirementName` = 'Student Evaluation Survey',
    `Instructions` = 'Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',
    `RequiresFile` = 1,
    `RequirementLink` = COALESCE(NULLIF(RequirementLink, ''), 'https://example.com/student-evaluation')
WHERE `DepartmentID` = 4;

-- 2. College Deans: CCS (11), CTHM (12), CBA (13), COE (14), and generic College Dean (10)
UPDATE `clearancerequirements`
SET
    `RequirementName` = 'Student Evaluation Survey',
    `Instructions` = 'Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',
    `RequiresFile` = 1,
    `RequirementLink` = COALESCE(NULLIF(RequirementLink, ''), 'https://example.com/student-evaluation')
WHERE `DepartmentID` IN (10, 11, 12, 13, 14) AND `SequenceOrder` = 6;
