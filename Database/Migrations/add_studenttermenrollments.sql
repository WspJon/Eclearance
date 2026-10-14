-- Non-destructive Migration: Add studenttermenrollments table
-- Tracks chronological term enrollment (Enrolled, Not Enrolled, No Record)
-- Informational only: does NOT restrict clearance processing

CREATE TABLE IF NOT EXISTS `studenttermenrollments` (
  `EnrollmentID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `TermID` int(11) NOT NULL,
  `EnrollmentStatus` varchar(30) NOT NULL,
  `Remarks` varchar(255) DEFAULT NULL,
  `VerifiedBy` int(11) DEFAULT NULL,
  `VerificationBasis` varchar(100) DEFAULT NULL,
  `VerificationDate` datetime DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`EnrollmentID`),
  UNIQUE KEY `uq_student_term_enrollment` (`StudentID`, `TermID`),
  KEY `idx_enrollment_student` (`StudentID`),
  KEY `idx_enrollment_term` (`TermID`),
  KEY `idx_enrollment_verifier` (`VerifiedBy`),
  CONSTRAINT `fk_enrollment_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_enrollment_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_enrollment_verifier` FOREIGN KEY (`VerifiedBy`) REFERENCES `users` (`UserID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Ensure audit columns exist if table was already created earlier:
SET @dbname = DATABASE();
SET @tablename = "studenttermenrollments";

SET @precheck = (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = @dbname AND TABLE_NAME = @tablename AND COLUMN_NAME = 'VerifiedBy');
SET @sql = IF(@precheck = 0, 'ALTER TABLE `studenttermenrollments` ADD COLUMN `VerifiedBy` int(11) DEFAULT NULL AFTER `Remarks`, ADD COLUMN `VerificationBasis` varchar(100) DEFAULT NULL AFTER `VerifiedBy`, ADD COLUMN `VerificationDate` datetime DEFAULT NULL AFTER `VerificationBasis`;', 'SELECT 1;');
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
