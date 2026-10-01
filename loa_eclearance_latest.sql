-- ============================================================
-- LOA E-CLEARANCE SYSTEM - CONSOLIDATED DATABASE
-- Latest consolidated schema for the current VB.NET project
-- Generated from Eclearance(6)
--
-- IMPORTANT:
-- This is a FRESH SETUP / RESET script.
-- Running it will DROP and recreate the loa_eclearance database.
-- Back up any important existing test data before importing.
-- ============================================================

SET SQL_MODE = 'NO_AUTO_VALUE_ON_ZERO';
SET time_zone = '+00:00';
SET FOREIGN_KEY_CHECKS = 0;

DROP DATABASE IF EXISTS `loa_eclearance`;
CREATE DATABASE `loa_eclearance`
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
USE `loa_eclearance`;

-- ============================================================
-- 1. ACADEMIC TERMS
-- ============================================================
CREATE TABLE `AcademicTerms` (
  `TermID` INT NOT NULL AUTO_INCREMENT,
  `AcademicYear` VARCHAR(20) NOT NULL,
  `Semester` VARCHAR(30) NOT NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 0,
  `StartDate` DATE NULL,
  `EndDate` DATE NULL,
  `CreatedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`TermID`),
  UNIQUE KEY `uq_academic_term` (`AcademicYear`, `Semester`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `AcademicTerms`
(`TermID`, `AcademicYear`, `Semester`, `IsActive`, `StartDate`, `EndDate`)
VALUES
(1, '2026-2027', '1st Semester', 1, NULL, NULL);

-- ============================================================
-- 2. DEPARTMENTS
-- IDs intentionally preserve the IDs used by the existing project.
-- OSA remains in the database but is inactive and is NOT part of
-- the official 9-step clearance sequence.
-- ============================================================
CREATE TABLE `Departments` (
  `DepartmentID` INT NOT NULL AUTO_INCREMENT,
  `DepartmentName` VARCHAR(100) NOT NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  `CreatedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`DepartmentID`),
  UNIQUE KEY `uq_department_name` (`DepartmentName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `Departments` (`DepartmentID`, `DepartmentName`, `IsActive`) VALUES
(1, 'Finance Office', 1),
(2, 'Registrar', 1),
(3, 'Library', 1),
(4, 'OSA', 0),
(5, 'OAA', 1),
(6, 'Guidance Office', 1),
(7, 'NSTP Office', 1),
(8, 'CTHM Stock Room', 1),
(9, 'Clinic', 1),
(10, 'College Dean', 1);

-- ============================================================
-- 3. USERS
-- The current prototype uses the Password column directly.
-- PasswordHash is intentionally omitted because the current code
-- does not use it.
-- ============================================================
CREATE TABLE `Users` (
  `UserID` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(50) NOT NULL,
  `Password` VARCHAR(100) NOT NULL,
  `FullName` VARCHAR(120) NOT NULL,
  `FirstName` VARCHAR(50) NULL,
  `LastName` VARCHAR(50) NULL,
  `Role` VARCHAR(20) NOT NULL,
  `StudentNo` VARCHAR(30) NULL,
  `Course` VARCHAR(100) NULL,
  `Section` VARCHAR(50) NULL,
  `YearLevel` VARCHAR(30) NULL,
  `EnrolledInNSTP` TINYINT(1) NOT NULL DEFAULT 0,
  `DepartmentID` INT NULL,
  `ContactNo` VARCHAR(20) NULL,
  `Email` VARCHAR(100) NULL,
  `Address` VARCHAR(255) NULL,
  `CivilStatus` VARCHAR(30) NULL,
  `EmergencyContactName` VARCHAR(100) NULL,
  `EmergencyContactNo` VARCHAR(20) NULL,
  `Relationship` VARCHAR(50) NULL,
  `AdditionalNotes` VARCHAR(500) NULL,
  `GuidanceInfoUpdated` TINYINT(1) NOT NULL DEFAULT 0,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  `CreatedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `uq_username` (`Username`),
  UNIQUE KEY `uq_student_no` (`StudentNo`),
  KEY `idx_user_department` (`DepartmentID`),
  KEY `idx_user_role` (`Role`),
  KEY `idx_student_course_year_section` (`Course`, `YearLevel`, `Section`),
  CONSTRAINT `fk_users_department`
    FOREIGN KEY (`DepartmentID`) REFERENCES `Departments` (`DepartmentID`)
    ON UPDATE CASCADE ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Default administrator account used by the current prototype.
INSERT INTO `Users`
(`UserID`, `Username`, `Password`, `FullName`, `Role`, `IsActive`)
VALUES
(1, 'admin', 'admin123', 'System Administrator', 'Admin', 1);

-- Test staff accounts currently used for the newly-added offices.
INSERT INTO `Users`
(`Username`, `Password`, `FullName`, `Role`, `DepartmentID`, `IsActive`)
VALUES
('clinic_staff', 'clinic123', 'Clinic Staff Officer', 'Staff', 9, 1),
('dean_staff', 'dean123', 'College Dean Staff', 'Staff', 10, 1);

-- ============================================================
-- 4. SECTIONS
-- CourseID is kept nullable because the current project filters
-- sections using CourseName rather than a separate Courses table.
-- ============================================================
CREATE TABLE `Sections` (
  `SectionID` INT NOT NULL AUTO_INCREMENT,
  `CourseID` INT NULL,
  `CourseName` VARCHAR(100) NOT NULL,
  `SectionName` VARCHAR(100) NOT NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`SectionID`),
  UNIQUE KEY `uq_course_section` (`CourseName`, `SectionName`),
  KEY `idx_sections_course` (`CourseName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `Sections` (`CourseName`, `SectionName`, `IsActive`) VALUES
('BSIT', 'BSIT-1A', 1),
('BSIT', 'BSIT-1B', 1),
('BSIT', 'BSIT-2A', 1),
('BSIT', 'BSIT-3A', 1),
('BSIT', 'BSIT-4A', 1),
('BSHM', 'BSHM-1A', 1),
('BSHM', 'BSHM-2A', 1),
('BSHM', 'BSHM-3A', 1),
('CTHM', 'CTHM-1A', 1),
('CTHM', 'CTHM-2A', 1),
('CTHM', 'CTHM-3A', 1),
('BSA', 'BSA-1A', 1),
('BSA', 'BSA-2A', 1),
('BSA', 'BSA-3A', 1),
('BSBA', 'BSBA-1A', 1),
('BSBA', 'BSBA-2A', 1),
('BSCpE', 'BSCpE-1A', 1),
('BSCpE', 'BSCpE-2A', 1);

-- ============================================================
-- 5. CLEARANCE REQUIREMENTS
-- Official sequential order:
-- 1 Guidance
-- 2 Library
-- 3 Clinic
-- 4 CTHM Stock Room (conditional by course/program)
-- 5 NSTP (first-year only)
-- 6 College Dean
-- 7 Finance
-- 8 Registrar
-- 9 OAA
-- ============================================================
CREATE TABLE `ClearanceRequirements` (
  `RequirementID` INT NOT NULL AUTO_INCREMENT,
  `DepartmentID` INT NOT NULL,
  `RequirementName` VARCHAR(150) NOT NULL,
  `Instructions` VARCHAR(500) NULL,
  `RequiresFile` TINYINT(1) NOT NULL DEFAULT 1,
  `AppliesToCourse` VARCHAR(50) NULL,
  `RequiresNSTP` TINYINT(1) NOT NULL DEFAULT 0,
  `SequenceOrder` INT NOT NULL DEFAULT 0,
  `RequirementLink` VARCHAR(500) NULL,
  `ApplicableCourses` VARCHAR(255) NULL,
  `ApplicableYearLevels` VARCHAR(255) NULL,
  `IsActive` TINYINT(1) NOT NULL DEFAULT 1,
  `CreatedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RequirementID`),
  KEY `idx_requirement_department` (`DepartmentID`),
  KEY `idx_requirement_sequence` (`SequenceOrder`),
  CONSTRAINT `fk_requirements_department`
    FOREIGN KEY (`DepartmentID`) REFERENCES `Departments` (`DepartmentID`)
    ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Requirement IDs preserve the original project IDs where possible.
INSERT INTO `ClearanceRequirements`
(`RequirementID`, `DepartmentID`, `RequirementName`, `Instructions`, `RequiresFile`,
 `AppliesToCourse`, `RequiresNSTP`, `SequenceOrder`, `RequirementLink`,
 `ApplicableCourses`, `ApplicableYearLevels`, `IsActive`)
VALUES
-- Finance (original RequirementID 1)
(1, 1, 'Finance Clearance',
 'Settle all outstanding balances and submit the required proof if requested.',
 1, NULL, 0, 7, NULL, NULL, NULL, 1),

-- Registrar (original RequirementID 2)
(2, 2, 'Registrar Clearance',
 'Student must have no outstanding balance or pending obligation required by the Registrar before clearance approval.',
 1, NULL, 0, 8, NULL, NULL, NULL, 1),

-- Library (original RequirementID 3)
(3, 3, 'Library Clearance',
 'Submit a screenshot of the completed Library survey for verification and clearance approval.',
 1, NULL, 0, 2, NULL, NULL, NULL, 1),

-- OSA remains inactive and outside the official 9-step workflow.
(4, 4, 'OSA Clearance',
 'Inactive legacy clearance requirement.',
 0, NULL, 0, 0, NULL, NULL, NULL, 0),

-- OAA (original RequirementID 5)
(5, 5, 'OAA Clearance',
 'Obtain final academic affairs approval. All previous applicable clearance steps must be cleared.',
 1, NULL, 0, 9, NULL, NULL, NULL, 1),

-- Guidance (original RequirementID 6)
(6, 6, 'Guidance Clearance',
 'Complete the required evaluation. Old students must also update their personal information before clearance approval.',
 0, NULL, 0, 1, NULL, NULL, NULL, 1),

-- NSTP (original RequirementID 7) - first year only
(7, 7, 'NSTP Clearance',
 'Complete the required NSTP clearance.',
 1, NULL, 1, 5, NULL, NULL, '1st Year,First Year,1', 1),

-- CTHM Stock Room (original RequirementID 8) - conditional by program
(8, 8, 'CTHM Stock Room Clearance',
 'Return or settle all required CTHM stock room items.',
 1, 'CTHM,BSHM,BSTr', 0, 4, NULL,
 'CTHM,BSHM,BSTr,Hospitality,Tourism', NULL, 1),

-- Clinic - requirement still pending final confirmation
(9, 9, 'Clinic Clearance',
 'Requirement pending confirmation from the Clinic office.',
 0, NULL, 0, 3, NULL, NULL, NULL, 1),

-- College Dean
(10, 10, 'College Dean Clearance',
 'Submit proof of payment for the required organization fee.',
 1, NULL, 0, 6, NULL, NULL, NULL, 1);

-- NOTE: RequirementLink for Library is intentionally NULL until the
-- official survey URL is confirmed. Update it later with:
-- UPDATE ClearanceRequirements
-- SET RequirementLink = 'OFFICIAL_LIBRARY_SURVEY_URL'
-- WHERE DepartmentID = 3;

-- ============================================================
-- 6. CLEARANCE RECORDS
-- Effective statuses such as Locked and Not Applicable are calculated
-- by the VB.NET workflow helper. Stored statuses remain primarily:
-- Pending, Under Review, Cleared, Rejected.
-- ============================================================
CREATE TABLE `ClearanceRecords` (
  `RecordID` INT NOT NULL AUTO_INCREMENT,
  `StudentID` INT NOT NULL,
  `RequirementID` INT NOT NULL,
  `TermID` INT NOT NULL,
  `Status` VARCHAR(30) NOT NULL DEFAULT 'Pending',
  `Remarks` VARCHAR(500) NULL,
  `SubmittedFilePath` VARCHAR(500) NULL,
  `SubmittedFileName` VARCHAR(255) NULL,
  `SubmittedAt` TIMESTAMP NULL DEFAULT NULL,
  `ReviewedBy` INT NULL,
  `ReviewedAt` TIMESTAMP NULL DEFAULT NULL,
  `CreatedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RecordID`),
  UNIQUE KEY `uq_student_requirement_term` (`StudentID`, `RequirementID`, `TermID`),
  KEY `idx_record_requirement` (`RequirementID`),
  KEY `idx_record_term` (`TermID`),
  KEY `idx_record_reviewer` (`ReviewedBy`),
  KEY `idx_record_status` (`Status`),
  CONSTRAINT `fk_records_student`
    FOREIGN KEY (`StudentID`) REFERENCES `Users` (`UserID`)
    ON UPDATE CASCADE ON DELETE CASCADE,
  CONSTRAINT `fk_records_requirement`
    FOREIGN KEY (`RequirementID`) REFERENCES `ClearanceRequirements` (`RequirementID`)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT `fk_records_term`
    FOREIGN KEY (`TermID`) REFERENCES `AcademicTerms` (`TermID`)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT `fk_records_reviewer`
    FOREIGN KEY (`ReviewedBy`) REFERENCES `Users` (`UserID`)
    ON UPDATE CASCADE ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
-- 7. MULTIPLE FILES PER CLEARANCE RECORD
-- ============================================================
CREATE TABLE `ClearanceRecordFiles` (
  `FileID` INT NOT NULL AUTO_INCREMENT,
  `RecordID` INT NOT NULL,
  `StoredFilePath` VARCHAR(500) NOT NULL,
  `OriginalFileName` VARCHAR(255) NOT NULL,
  `UploadedAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`FileID`),
  KEY `idx_record_files_record` (`RecordID`),
  CONSTRAINT `fk_record_files_record`
    FOREIGN KEY (`RecordID`) REFERENCES `ClearanceRecords` (`RecordID`)
    ON UPDATE CASCADE ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================
-- 8. CLEARANCE HISTORY / AUDIT TRAIL
-- ============================================================
CREATE TABLE `ClearanceHistory` (
  `HistoryID` INT NOT NULL AUTO_INCREMENT,
  `RecordID` INT NOT NULL,
  `ActionBy` INT NULL,
  `ActionType` VARCHAR(50) NOT NULL,
  `OldStatus` VARCHAR(30) NULL,
  `NewStatus` VARCHAR(30) NULL,
  `Remarks` VARCHAR(500) NULL,
  `ActionAt` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`HistoryID`),
  KEY `idx_history_record` (`RecordID`),
  KEY `idx_history_actor` (`ActionBy`),
  KEY `idx_history_action_at` (`ActionAt`),
  CONSTRAINT `fk_history_record`
    FOREIGN KEY (`RecordID`) REFERENCES `ClearanceRecords` (`RecordID`)
    ON UPDATE CASCADE ON DELETE CASCADE,
  CONSTRAINT `fk_history_actor`
    FOREIGN KEY (`ActionBy`) REFERENCES `Users` (`UserID`)
    ON UPDATE CASCADE ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

SET FOREIGN_KEY_CHECKS = 1;

-- ============================================================
-- QUICK VERIFICATION QUERIES (optional)
-- ============================================================
-- SELECT * FROM Departments ORDER BY DepartmentID;
-- SELECT RequirementID, DepartmentID, RequirementName, SequenceOrder,
--        RequiresFile, ApplicableCourses, ApplicableYearLevels, IsActive
-- FROM ClearanceRequirements
-- ORDER BY SequenceOrder;
-- DESCRIBE Users;
-- SHOW TABLES;

-- ============================================================
-- END OF CONSOLIDATED DATABASE
-- ============================================================
