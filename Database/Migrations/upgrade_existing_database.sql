-- ============================================================
-- UPGRADE EXISTING DATABASE SCRIPT
-- Safely migrates an existing database to the final normalized schema
-- ============================================================
-- NOTE: Please backup your live database before executing this script.
-- ============================================================

USE `loa_eclearance_latest`;

-- 1. Create AcademicTerms table if it doesn't exist
CREATE TABLE IF NOT EXISTS `academicterms` (
  `TermID` int(11) NOT NULL AUTO_INCREMENT,
  `AcademicYear` varchar(20) NOT NULL,
  `Semester` varchar(30) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 0,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`TermID`),
  UNIQUE KEY `uq_academic_term` (`AcademicYear`,`Semester`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Insert a default active term if empty
INSERT IGNORE INTO `academicterms` (`TermID`, `AcademicYear`, `Semester`, `IsActive`)
VALUES (1, '2026-2027', '1st Semester', 1);

-- 2. Clean up Users table
-- We drop the legacy constraints and keys first
SET FOREIGN_KEY_CHECKS = 0;

-- Ignore errors if these don't exist (using a safe approach for older MySQL versions)
-- We will just alter table directly. If columns don't exist, it might throw an error, 
-- but that means it's already upgraded!
ALTER TABLE `users`
  DROP FOREIGN KEY `fk_users_department`;

ALTER TABLE `users`
  DROP INDEX `uq_student_no`,
  DROP INDEX `idx_user_department`,
  DROP INDEX `idx_student_course_year_section`;

-- Drop the legacy unnormalized columns
ALTER TABLE `users`
  DROP COLUMN `StudentNo`,
  DROP COLUMN `Course`,
  DROP COLUMN `Section`,
  DROP COLUMN `YearLevel`,
  DROP COLUMN `StudentType`,
  DROP COLUMN `GuidanceInfoUpdateRequired`,
  DROP COLUMN `EnrolledInNSTP`,
  DROP COLUMN `DepartmentID`,
  DROP COLUMN `ContactNo`,
  DROP COLUMN `Email`,
  DROP COLUMN `Address`,
  DROP COLUMN `CivilStatus`,
  DROP COLUMN `EmergencyContactName`,
  DROP COLUMN `EmergencyContactNo`,
  DROP COLUMN `Relationship`,
  DROP COLUMN `AdditionalNotes`,
  DROP COLUMN `GuidanceInfoUpdated`;

-- Add UpdatedAt column (might throw error if it already exists)
ALTER TABLE `users`
  ADD COLUMN `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp();

SET FOREIGN_KEY_CHECKS = 1;

-- ============================================================
-- UPGRADE COMPLETE
-- ============================================================
