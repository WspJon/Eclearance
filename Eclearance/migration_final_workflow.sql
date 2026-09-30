-- Migration Script for E-Clearance Sequential Workflow Revisions

USE loa_eclearance;

-- 1. Update Departments: Add Clinic and College Dean if not existing
INSERT INTO `departments` (`DepartmentID`, `DepartmentName`, `IsActive`)
VALUES
(9, 'Clinic', 1),
(10, 'College Dean', 1)
ON DUPLICATE KEY UPDATE `DepartmentName` = VALUES(`DepartmentName`), `IsActive` = 1;

-- Deactivate OSA from active clearance requirements since it is not in the official 9 departments
UPDATE `departments` SET `IsActive` = 0 WHERE `DepartmentName` = 'OSA';

-- 2. Update ClearanceRequirements schema
ALTER TABLE `clearancerequirements`
  ADD COLUMN IF NOT EXISTS `SequenceOrder` INT NOT NULL DEFAULT 0,
  ADD COLUMN IF NOT EXISTS `RequirementLink` VARCHAR(500) NULL,
  ADD COLUMN IF NOT EXISTS `ApplicableCourses` VARCHAR(255) NULL,
  ADD COLUMN IF NOT EXISTS `ApplicableYearLevels` VARCHAR(255) NULL;

-- 3. Deactivate OSA requirement
UPDATE `clearancerequirements` SET `IsActive` = 0 WHERE `DepartmentID` = 4;

-- 4. Update existing requirements with official sequence orders, instructions, links, and applicability
-- 1. Guidance (Dept 6)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 1,
    `RequirementName` = 'Guidance Clearance',
    `Instructions` = 'Complete the required evaluation. Old students must also update their personal information before clearance approval.',
    `RequiresFile` = 0,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 0,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 6;

-- 2. Library (Dept 3)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 2,
    `RequirementName` = 'Library Clearance',
    `Instructions` = 'Submit a screenshot of the completed Library survey for verification and clearance approval.',
    `RequirementLink` = 'https://forms.gle/library-survey-loa',
    `RequiresFile` = 1,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 0,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 3;

-- 3. Clinic (Dept 9)
INSERT INTO `clearancerequirements` (`DepartmentID`, `RequirementName`, `Instructions`, `RequiresFile`, `AppliesToCourse`, `RequiresNSTP`, `IsActive`, `SequenceOrder`, `RequirementLink`, `ApplicableCourses`, `ApplicableYearLevels`)
SELECT 9, 'Clinic Clearance', 'Requirement pending confirmation from the Clinic office.', 0, NULL, 0, 1, 3, NULL, NULL, NULL
WHERE NOT EXISTS (SELECT 1 FROM `clearancerequirements` WHERE `DepartmentID` = 9);

UPDATE `clearancerequirements`
SET `SequenceOrder` = 3,
    `RequirementName` = 'Clinic Clearance',
    `Instructions` = 'Requirement pending confirmation from the Clinic office.',
    `RequiresFile` = 0,
    `IsActive` = 1
WHERE `DepartmentID` = 9;

-- 4. CTHM Stock Room (Dept 8)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 4,
    `RequirementName` = 'CTHM Stock Room Clearance',
    `Instructions` = 'Return or settle all required CTHM stock room items.',
    `RequiresFile` = 1,
    `AppliesToCourse` = 'CTHM,BSHM,BSTr',
    `RequiresNSTP` = 0,
    `ApplicableCourses` = 'CTHM,BSHM,BSTr,Hospitality,Tourism',
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 8;

-- 5. NSTP (Dept 7)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 5,
    `RequirementName` = 'NSTP Clearance',
    `Instructions` = 'Complete the required NSTP clearance.',
    `RequiresFile` = 1,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 1,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = '1st Year,First Year,1',
    `IsActive` = 1
WHERE `DepartmentID` = 7;

-- 6. College Dean (Dept 10)
INSERT INTO `clearancerequirements` (`DepartmentID`, `RequirementName`, `Instructions`, `RequiresFile`, `AppliesToCourse`, `RequiresNSTP`, `IsActive`, `SequenceOrder`, `RequirementLink`, `ApplicableCourses`, `ApplicableYearLevels`)
SELECT 10, 'College Dean Clearance', 'Submit proof of payment for the required organization fee.', 1, NULL, 0, 1, 6, NULL, NULL, NULL
WHERE NOT EXISTS (SELECT 1 FROM `clearancerequirements` WHERE `DepartmentID` = 10);

UPDATE `clearancerequirements`
SET `SequenceOrder` = 6,
    `RequirementName` = 'College Dean Clearance',
    `Instructions` = 'Submit proof of payment for the required organization fee.',
    `RequiresFile` = 1,
    `IsActive` = 1
WHERE `DepartmentID` = 10;

-- 7. Finance Department (Dept 1)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 7,
    `RequirementName` = 'Finance Clearance',
    `Instructions` = 'Settle all outstanding balances and submit the required proof if requested.',
    `RequiresFile` = 1,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 0,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 1;

-- 8. Registrar Department (Dept 2)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 8,
    `RequirementName` = 'Registrar Clearance',
    `Instructions` = 'Student must have no outstanding balance or pending obligation required by the Registrar before clearance approval.',
    `RequiresFile` = 1,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 0,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 2;

-- 9. OAA (Dept 5)
UPDATE `clearancerequirements`
SET `SequenceOrder` = 9,
    `RequirementName` = 'OAA Clearance',
    `Instructions` = 'Obtain final academic affairs approval. All previous clearance steps must be cleared.',
    `RequiresFile` = 1,
    `AppliesToCourse` = NULL,
    `RequiresNSTP` = 0,
    `ApplicableCourses` = NULL,
    `ApplicableYearLevels` = NULL,
    `IsActive` = 1
WHERE `DepartmentID` = 5;

-- 5. Create ClearanceRecordFiles table
CREATE TABLE IF NOT EXISTS `ClearanceRecordFiles` (
  `FileID` INT AUTO_INCREMENT PRIMARY KEY,
  `RecordID` INT NOT NULL,
  `StoredFilePath` VARCHAR(500) NOT NULL,
  `OriginalFileName` VARCHAR(255) NOT NULL,
  `UploadedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  KEY `RecordID` (`RecordID`),
  CONSTRAINT `fk_clearancerecordfiles_record` FOREIGN KEY (`RecordID`) REFERENCES `ClearanceRecords` (`RecordID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Migrate any existing single-file submissions into ClearanceRecordFiles
INSERT INTO `ClearanceRecordFiles` (`RecordID`, `StoredFilePath`, `OriginalFileName`, `UploadedAt`)
SELECT `RecordID`, `SubmittedFilePath`, `SubmittedFileName`, IFNULL(`SubmittedAt`, CURRENT_TIMESTAMP)
FROM `ClearanceRecords`
WHERE `SubmittedFilePath` IS NOT NULL AND `SubmittedFilePath` != ''
AND `RecordID` NOT IN (SELECT `RecordID` FROM `ClearanceRecordFiles`);

-- 6. Create Sections table and add Section to Users
CREATE TABLE IF NOT EXISTS `Sections` (
  `SectionID` INT AUTO_INCREMENT PRIMARY KEY,
  `CourseID` INT NULL,
  `CourseName` VARCHAR(100) NOT NULL,
  `SectionName` VARCHAR(100) NOT NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Add Section and Guidance Profile Fields to Users
ALTER TABLE `users`
  ADD COLUMN IF NOT EXISTS `Section` VARCHAR(50) NULL AFTER `Course`,
  ADD COLUMN IF NOT EXISTS `ContactNo` VARCHAR(50) NULL,
  ADD COLUMN IF NOT EXISTS `Address` VARCHAR(255) NULL,
  ADD COLUMN IF NOT EXISTS `EmergencyContactName` VARCHAR(100) NULL,
  ADD COLUMN IF NOT EXISTS `EmergencyContactNo` VARCHAR(50) NULL,
  ADD COLUMN IF NOT EXISTS `GuidanceInfoUpdated` TINYINT(1) NOT NULL DEFAULT 0;

-- Populate initial Sections if empty
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSIT', 'BSIT-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSIT-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSIT', 'BSIT-1B', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSIT-1B');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSIT', 'BSIT-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSIT-2A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSIT', 'BSIT-3A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSIT-3A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSIT', 'BSIT-4A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSIT-4A');

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSHM', 'BSHM-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSHM-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSHM', 'BSHM-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSHM-2A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSHM', 'BSHM-3A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSHM-3A');

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'CTHM', 'CTHM-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'CTHM-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'CTHM', 'CTHM-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'CTHM-2A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'CTHM', 'CTHM-3A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'CTHM-3A');

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSA', 'BSA-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSA-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSA', 'BSA-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSA-2A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSA', 'BSA-3A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSA-3A');

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSBA', 'BSBA-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSBA-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSBA', 'BSBA-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSBA-2A');

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSCpE', 'BSCpE-1A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSCpE-1A');
INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`)
SELECT 'BSCpE', 'BSCpE-2A', 1 WHERE NOT EXISTS (SELECT 1 FROM `Sections` WHERE `SectionName` = 'BSCpE-2A');

-- 7. Seed Staff for Clinic and College Dean for test accounts if not exists
INSERT INTO `users` (`Username`, `Password`, `FullName`, `Role`, `DepartmentID`, `IsActive`)
SELECT 'clinic_staff', 'clinic123', 'Clinic Staff Officer', 'Staff', 9, 1
WHERE NOT EXISTS (SELECT 1 FROM `users` WHERE `Username` = 'clinic_staff');

INSERT INTO `users` (`Username`, `Password`, `FullName`, `Role`, `DepartmentID`, `IsActive`)
SELECT 'dean_staff', 'dean123', 'College Dean Staff', 'Staff', 10, 1
WHERE NOT EXISTS (SELECT 1 FROM `users` WHERE `Username` = 'dean_staff');

-- 8. Synchronize existing ClearanceRecords for active term so all active requirements are represented
INSERT INTO `ClearanceRecords` (`StudentID`, `RequirementID`, `TermID`, `Status`)
SELECT u.UserID, r.RequirementID, t.TermID, 'Pending'
FROM `Users` u
CROSS JOIN `ClearanceRequirements` r
CROSS JOIN `AcademicTerms` t
WHERE u.Role = 'Student' AND u.IsActive = 1
  AND r.IsActive = 1
  AND t.IsActive = 1
  AND NOT EXISTS (
    SELECT 1 FROM `ClearanceRecords` cr
    WHERE cr.StudentID = u.UserID AND cr.RequirementID = r.RequirementID AND cr.TermID = t.TermID
  );
