-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 29, 2026 at 11:52 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `loa_eclearance;`
--

-- --------------------------------------------------------

--
-- Table structure for table `academicterms`
--

CREATE TABLE IF NOT EXISTS `academicterms` (
  `TermID` int(11) NOT NULL AUTO_INCREMENT,
  `AcademicYear` varchar(20) NOT NULL,
  `Semester` varchar(30) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT '0',
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`TermID`),
  UNIQUE KEY `AcademicYear` (`AcademicYear`,`Semester`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `academicterms`
--

INSERT INTO `academicterms` (`TermID`, `AcademicYear`, `Semester`, `IsActive`, `StartDate`, `EndDate`, `CreatedAt`) VALUES
(1, '2026-2027', '1st Semester', 1, NULL, NULL, '2026-09-29 09:08:39');

-- --------------------------------------------------------

--
-- Table structure for table `clearancehistory`
--

CREATE TABLE IF NOT EXISTS `clearancehistory` (
  `HistoryID` int(11) NOT NULL AUTO_INCREMENT,
  `RecordID` int(11) NOT NULL,
  `ActionBy` int(11) DEFAULT NULL,
  `ActionType` varchar(50) NOT NULL,
  `OldStatus` varchar(30) DEFAULT NULL,
  `NewStatus` varchar(30) DEFAULT NULL,
  `Remarks` varchar(500) DEFAULT NULL,
  `ActionAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`HistoryID`),
  KEY `RecordID` (`RecordID`),
  KEY `ActionBy` (`ActionBy`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `clearancerecords`
--

CREATE TABLE IF NOT EXISTS `clearancerecords` (
  `RecordID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `RequirementID` int(11) NOT NULL,
  `TermID` int(11) NOT NULL,
  `Status` varchar(30) NOT NULL DEFAULT 'Pending',
  `Remarks` varchar(500) DEFAULT NULL,
  `SubmittedFilePath` varchar(500) DEFAULT NULL,
  `SubmittedFileName` varchar(255) DEFAULT NULL,
  `SubmittedAt` timestamp NULL DEFAULT NULL,
  `ReviewedBy` int(11) DEFAULT NULL,
  `ReviewedAt` timestamp NULL DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RecordID`),
  UNIQUE KEY `StudentID` (`StudentID`,`RequirementID`,`TermID`),
  KEY `RequirementID` (`RequirementID`),
  KEY `TermID` (`TermID`),
  KEY `ReviewedBy` (`ReviewedBy`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `clearancerequirements`
--

CREATE TABLE IF NOT EXISTS `clearancerequirements` (
  `RequirementID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentID` int(11) NOT NULL,
  `RequirementName` varchar(150) NOT NULL,
  `Instructions` varchar(500) DEFAULT NULL,
  `RequiresFile` tinyint(1) NOT NULL DEFAULT '1',
  `AppliesToCourse` varchar(50) DEFAULT NULL,
  `RequiresNSTP` tinyint(1) NOT NULL DEFAULT '0',
  `IsActive` tinyint(1) NOT NULL DEFAULT '1',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RequirementID`),
  KEY `DepartmentID` (`DepartmentID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `clearancerequirements`
--

INSERT INTO `clearancerequirements` (`RequirementID`, `DepartmentID`, `RequirementName`, `Instructions`, `RequiresFile`, `AppliesToCourse`, `RequiresNSTP`, `IsActive`, `CreatedAt`) VALUES
(1, 1, 'Finance Clearance', 'Settle all outstanding balances and submit the required proof if requested.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(2, 2, 'Registrar Clearance', 'Complete all registrar-related clearance requirements.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(3, 3, 'Library Clearance', 'Return all borrowed books and settle any library obligations.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(4, 4, 'OSA Clearance', 'Complete all requirements from the Office of Student Affairs.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(5, 5, 'OAA Clearance', 'Complete all academic affairs clearance requirements.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(6, 6, 'Guidance Clearance', 'Complete the required non-confidential clearance requirement.', 1, NULL, 0, 1, '2026-09-29 09:10:00'),
(7, 7, 'NSTP Clearance', 'Complete the required NSTP clearance.', 1, NULL, 1, 1, '2026-09-29 09:10:00'),
(8, 8, 'CTHM Stock Room Clearance', 'Return or settle all required CTHM stock room items.', 1, 'CTHM', 0, 1, '2026-09-29 09:10:00');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE IF NOT EXISTS `departments` (
  `DepartmentID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(100) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT '1',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`DepartmentID`),
  UNIQUE KEY `DepartmentName` (`DepartmentName`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`DepartmentID`, `DepartmentName`, `IsActive`, `CreatedAt`) VALUES
(1, 'Finance Office', 1, '2026-09-29 09:08:59'),
(2, 'Registrar', 1, '2026-09-29 09:08:59'),
(3, 'Library', 1, '2026-09-29 09:08:59'),
(4, 'OSA', 1, '2026-09-29 09:08:59'),
(5, 'OAA', 1, '2026-09-29 09:08:59'),
(6, 'Guidance Office', 1, '2026-09-29 09:08:59'),
(7, 'NSTP Office', 1, '2026-09-29 09:08:59'),
(8, 'CTHM Stock Room', 1, '2026-09-29 09:08:59');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `PasswordHash` varchar(64) NOT NULL,
  `FullName` varchar(120) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Role` varchar(20) NOT NULL,
  `StudentNo` varchar(30) DEFAULT NULL,
  `Course` varchar(100) DEFAULT NULL,
  `YearLevel` varchar(30) DEFAULT NULL,
  `EnrolledInNSTP` tinyint(1) NOT NULL DEFAULT '0',
  `DepartmentID` int(11) DEFAULT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT '1',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `StudentNo` (`StudentNo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `PasswordHash`, `FullName`, `FirstName`, `LastName`, `Role`, `StudentNo`, `Course`, `YearLevel`, `EnrolledInNSTP`, `DepartmentID`, `IsActive`, `CreatedAt`) VALUES
(1, 'admin', 'admin123', '', 'System Administrator', NULL, NULL, 'Admin', NULL, NULL, NULL, 0, NULL, 1, '2026-09-29 08:55:10');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `clearancehistory`
--
ALTER TABLE `clearancehistory`
  ADD CONSTRAINT `clearancehistory_ibfk_1` FOREIGN KEY (`RecordID`) REFERENCES `clearancerecords` (`RecordID`),
  ADD CONSTRAINT `clearancehistory_ibfk_2` FOREIGN KEY (`ActionBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `clearancerecords`
--
ALTER TABLE `clearancerecords`
  ADD CONSTRAINT `clearancerecords_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `clearancerecords_ibfk_2` FOREIGN KEY (`RequirementID`) REFERENCES `clearancerequirements` (`RequirementID`),
  ADD CONSTRAINT `clearancerecords_ibfk_3` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`),
  ADD CONSTRAINT `clearancerecords_ibfk_4` FOREIGN KEY (`ReviewedBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `clearancerequirements`
--
ALTER TABLE `clearancerequirements`
  ADD CONSTRAINT `clearancerequirements_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
