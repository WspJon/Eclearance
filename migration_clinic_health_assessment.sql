-- =====================================================================
-- Migration Script: Clinic Digital Health Assessment Module
-- Description: Non-destructive addition of clinichealthassessments table
-- =====================================================================

CREATE TABLE IF NOT EXISTS `clinichealthassessments` (
  `AssessmentID` int(11) NOT NULL AUTO_INCREMENT,
  `RecordID` int(11) NOT NULL,
  `StudentID` int(11) NOT NULL,
  `TermID` int(11) NOT NULL,
  `AcademicYear` varchar(50) NOT NULL,
  `HasMedicalCondition` tinyint(1) NOT NULL DEFAULT 0,
  `MedicalConditionDetails` text DEFAULT NULL,
  `HasAllergies` tinyint(1) NOT NULL DEFAULT 0,
  `AllergiesDetails` text DEFAULT NULL,
  `HasMedications` tinyint(1) NOT NULL DEFAULT 0,
  `MedicationsDetails` text DEFAULT NULL,
  `HasHealthConcerns` tinyint(1) NOT NULL DEFAULT 0,
  `HealthConcernsDetails` text DEFAULT NULL,
  `EmergencyContactName` varchar(150) NOT NULL,
  `Relationship` varchar(100) NOT NULL,
  `EmergencyContactNo` varchar(50) NOT NULL,
  `IsConfirmed` tinyint(1) NOT NULL DEFAULT 0,
  `IsDraft` tinyint(1) NOT NULL DEFAULT 0,
  `SubmittedAt` datetime DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UpdatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`AssessmentID`),
  UNIQUE KEY `uq_clinic_record` (`RecordID`),
  KEY `idx_clinic_student` (`StudentID`),
  KEY `idx_clinic_term` (`TermID`),
  CONSTRAINT `fk_clinic_assessment_record` FOREIGN KEY (`RecordID`) REFERENCES `clearancerecords` (`RecordID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_clinic_assessment_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_clinic_assessment_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Update Clinic instructions if generic
UPDATE `clearancerequirements` 
SET `Instructions` = 'Complete the digital Health Assessment Form. Submit additional medical certificates or examination results only if requested by Clinic staff.'
WHERE `DepartmentID` = 9 AND (`Instructions` IS NULL OR `Instructions` LIKE '%pending confirmation%');
