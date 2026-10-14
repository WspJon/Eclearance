-- Non-destructive Migration: Add studenttermenrollments table
-- Tracks chronological term enrollment (Enrolled, Not Enrolled)
-- Informational only: does NOT restrict clearance processing

CREATE TABLE IF NOT EXISTS `studenttermenrollments` (
  `EnrollmentID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `TermID` int(11) NOT NULL,
  `EnrollmentStatus` varchar(30) NOT NULL,
  `Remarks` varchar(255) DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`EnrollmentID`),
  UNIQUE KEY `uq_student_term_enrollment` (`StudentID`, `TermID`),
  KEY `idx_enrollment_student` (`StudentID`),
  KEY `idx_enrollment_term` (`TermID`),
  CONSTRAINT `fk_enrollment_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_enrollment_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
