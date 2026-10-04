-- ============================================================
-- LOA E-CLEARANCE SYSTEM - CONSOLIDATED DATABASE
-- Latest consolidated schema & data for the VB.NET project
-- Database: loa_eclearance_latest
--
-- Features:
-- 1. Separated Students and Staff tables linked to Users
-- 2. CoursePrograms mapping courses to specific College Deans:
--    - BSIT   -> Dean - CCS
--    - BSHM, BSTM, CTHM -> Dean - CTHM
--    - BSA, BSBA        -> Dean - CBA
--    - BSCpE            -> Dean - COE (College of Engineering)
-- 3. Steps 1-5 Parallel Clearance (Guidance, Library, Clinic, Stock Room, NSTP)
-- 4. Step 6 College Dean gate (assigned per student's program)
-- 5. Steps 7-9 Sequential Clearance (Finance, Registrar, OAA)
-- ============================================================

SET SQL_MODE = 'NO_AUTO_VALUE_ON_ZERO';
SET time_zone = '+00:00';
SET FOREIGN_KEY_CHECKS = 0;

CREATE DATABASE IF NOT EXISTS loa_eclearance_latest
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
USE loa_eclearance_latest;

-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: loa_eclearance_
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clearancehistory`
--

DROP TABLE IF EXISTS `clearancehistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clearancehistory` (
  `HistoryID` int(11) NOT NULL AUTO_INCREMENT,
  `RecordID` int(11) NOT NULL,
  `ActionBy` int(11) DEFAULT NULL,
  `ActionType` varchar(50) NOT NULL,
  `OldStatus` varchar(30) DEFAULT NULL,
  `NewStatus` varchar(30) DEFAULT NULL,
  `Remarks` varchar(500) DEFAULT NULL,
  `ActionAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`HistoryID`),
  KEY `idx_history_record` (`RecordID`),
  KEY `idx_history_actor` (`ActionBy`),
  KEY `idx_history_action_at` (`ActionAt`),
  CONSTRAINT `fk_history_actor` FOREIGN KEY (`ActionBy`) REFERENCES `users` (`UserID`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_history_record` FOREIGN KEY (`RecordID`) REFERENCES `clearancerecords` (`RecordID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancehistory`
--

LOCK TABLES `clearancehistory` WRITE;
/*!40000 ALTER TABLE `clearancehistory` DISABLE KEYS */;
INSERT INTO `clearancehistory` VALUES (1,1,11,'Submitted','Pending','Under Review','Student confirmed completion of guidance requirement.','2026-10-01 19:45:24'),(2,10,12,'Submitted','Pending','Under Review','Student confirmed completion of guidance requirement.','2026-10-01 20:43:23'),(3,19,4,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-02 00:43:09'),(4,10,12,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-02 02:19:12'),(5,10,4,'Requirement Rejected','Under Review','Rejected','Please provide complete street address in your contact information.','2026-10-02 02:19:13'),(6,10,12,'Resubmitted','Rejected','Under Review','Student corrected and resubmitted guidance information.','2026-10-02 02:19:13'),(7,10,4,'Requirement Approved / Cleared','Under Review','Cleared','All requirements verified.','2026-10-02 02:19:13'),(8,2,11,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 16:53:15'),(9,38,15,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 17:37:56'),(10,5,11,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 17:52:53'),(11,1,11,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-02 17:53:32');
/*!40000 ALTER TABLE `clearancehistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clearancerecordfiles`
--

DROP TABLE IF EXISTS `clearancerecordfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clearancerecordfiles` (
  `FileID` int(11) NOT NULL AUTO_INCREMENT,
  `RecordID` int(11) NOT NULL,
  `StoredFilePath` varchar(500) NOT NULL,
  `OriginalFileName` varchar(255) NOT NULL,
  `UploadedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`FileID`),
  KEY `idx_record_files_record` (`RecordID`),
  CONSTRAINT `fk_record_files_record` FOREIGN KEY (`RecordID`) REFERENCES `clearancerecords` (`RecordID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancerecordfiles`
--

LOCK TABLES `clearancerecordfiles` WRITE;
/*!40000 ALTER TABLE `clearancerecordfiles` DISABLE KEYS */;
INSERT INTO `clearancerecordfiles` VALUES (1,2,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\2_20261003005315_1.png','Screenshot 2026-02-02 020635.png','2026-10-02 16:53:15'),(2,38,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_15\\38_20261003013756_1.png','Screenshot 2026-01-27 202500.png','2026-10-02 17:37:56'),(3,5,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\5_20261003015253_1.png','Screenshot 2026-01-20 012035.png','2026-10-02 17:52:53');
/*!40000 ALTER TABLE `clearancerecordfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clearancerecords`
--

DROP TABLE IF EXISTS `clearancerecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clearancerecords` (
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
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`RecordID`),
  UNIQUE KEY `uq_student_requirement_term` (`StudentID`,`RequirementID`,`TermID`),
  KEY `idx_record_requirement` (`RequirementID`),
  KEY `idx_record_term` (`TermID`),
  KEY `idx_record_reviewer` (`ReviewedBy`),
  KEY `idx_record_status` (`Status`),
  CONSTRAINT `fk_records_requirement` FOREIGN KEY (`RequirementID`) REFERENCES `clearancerequirements` (`RequirementID`) ON UPDATE CASCADE,
  CONSTRAINT `fk_records_reviewer` FOREIGN KEY (`ReviewedBy`) REFERENCES `users` (`UserID`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_records_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_records_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancerecords`
--

LOCK TABLES `clearancerecords` WRITE;
/*!40000 ALTER TABLE `clearancerecords` DISABLE KEYS */;
INSERT INTO `clearancerecords` VALUES (1,11,6,1,'Under Review',NULL,NULL,NULL,'2026-10-02 17:53:32',NULL,NULL,'2026-10-01 19:21:51'),(2,11,3,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\2_20261003005315_1.png','Screenshot 2026-02-02 020635.png','2026-10-02 16:53:15',NULL,NULL,'2026-10-01 19:21:51'),(3,11,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(4,11,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(5,11,7,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\5_20261003015253_1.png','Screenshot 2026-01-20 012035.png','2026-10-02 17:52:53',NULL,NULL,'2026-10-01 19:21:51'),(6,11,11,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(7,11,1,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(8,11,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(9,11,5,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(10,12,6,1,'Pending',NULL,NULL,NULL,NULL,4,NULL,'2026-10-01 20:42:53'),(11,12,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(12,12,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(13,12,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(14,12,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(15,12,11,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(16,12,1,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(17,12,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(18,12,5,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(19,13,6,1,'Cleared',NULL,NULL,NULL,'2026-10-02 00:38:34',4,'2026-10-02 00:43:08','2026-10-01 20:46:19'),(20,13,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(21,13,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(22,13,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(23,13,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(24,13,11,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(25,13,1,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(26,13,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(27,13,5,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(28,14,6,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(29,14,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(30,14,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(31,14,8,1,'Not Applicable',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(32,14,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(33,14,11,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(34,14,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(35,14,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(36,14,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(37,15,6,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(38,15,3,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_15\\38_20261003013756_1.png','Screenshot 2026-01-27 202500.png','2026-10-02 17:37:56',NULL,NULL,'2026-10-02 17:37:03'),(39,15,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(40,15,8,1,'Not Applicable',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(41,15,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(42,15,13,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(43,15,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(44,15,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(45,15,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03');
/*!40000 ALTER TABLE `clearancerecords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clearancerequirements`
--

DROP TABLE IF EXISTS `clearancerequirements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clearancerequirements` (
  `RequirementID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentID` int(11) NOT NULL,
  `RequirementName` varchar(150) NOT NULL,
  `Instructions` varchar(500) DEFAULT NULL,
  `RequiresFile` tinyint(1) NOT NULL DEFAULT 1,
  `AppliesToCourse` varchar(50) DEFAULT NULL,
  `RequiresNSTP` tinyint(1) NOT NULL DEFAULT 0,
  `SequenceOrder` int(11) NOT NULL DEFAULT 0,
  `RequirementLink` varchar(500) DEFAULT NULL,
  `ApplicableCourses` varchar(255) DEFAULT NULL,
  `ApplicableYearLevels` varchar(255) DEFAULT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`RequirementID`),
  KEY `idx_requirement_department` (`DepartmentID`),
  KEY `idx_requirement_sequence` (`SequenceOrder`),
  CONSTRAINT `fk_requirements_department` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancerequirements`
--

LOCK TABLES `clearancerequirements` WRITE;
/*!40000 ALTER TABLE `clearancerequirements` DISABLE KEYS */;
INSERT INTO `clearancerequirements` VALUES (1,1,'Finance Clearance','Settle all outstanding balances and submit the required proof if requested.',1,NULL,0,7,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(2,2,'Registrar Clearance','Student must have no outstanding balance or pending obligation required by the Registrar before clearance approval.',1,NULL,0,8,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(3,3,'Library Clearance','Submit a screenshot of the completed Library survey for verification and clearance approval.',1,NULL,0,2,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(4,4,'OSA Clearance','Inactive legacy clearance requirement.',0,NULL,0,0,NULL,NULL,NULL,0,'2026-10-01 19:13:15'),(5,5,'OAA Clearance','Obtain final academic affairs approval. All previous applicable clearance steps must be cleared.',1,NULL,0,9,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(6,6,'Guidance Clearance','Complete the required Guidance process and review or update your student information for the current academic year.',0,NULL,0,1,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(7,7,'NSTP Clearance','Complete the required NSTP clearance.',1,NULL,1,5,NULL,NULL,'1st Year,First Year,1',1,'2026-10-01 19:13:15'),(8,8,'CTHM Stock Room Clearance','Return or settle all required CTHM stock room items.',1,'CTHM,BSHM,BSTr',0,4,NULL,'CTHM,BSHM,BSTr,Hospitality,Tourism',NULL,1,'2026-10-01 19:13:15'),(9,9,'Clinic Clearance','Requirement pending confirmation from the Clinic office.',0,NULL,0,3,NULL,NULL,NULL,1,'2026-10-01 19:13:15'),(10,10,'College Dean Clearance','Submit proof of payment for the required organization fee.',1,NULL,0,6,NULL,NULL,NULL,0,'2026-10-01 19:13:15'),(11,11,'Dean - CCS Clearance','Submit required clearance documents for CCS students.',1,NULL,0,6,NULL,'BSIT',NULL,1,'2026-10-04 17:18:13'),(12,12,'Dean - CTHM Clearance','Submit required clearance documents for CTHM students.',1,NULL,0,6,NULL,'BSHM,BSTM,CTHM',NULL,1,'2026-10-04 17:18:13'),(13,13,'Dean - CBA Clearance','Submit required clearance documents for CBA students.',1,NULL,0,6,NULL,'BSA,BSBA',NULL,1,'2026-10-04 17:18:13'),(14,14,'Dean - COE Clearance','Submit required clearance documents for College of Engineering (BSCpE) students.',1,NULL,0,6,NULL,'BSCpE',NULL,1,'2026-10-04 17:18:13');
/*!40000 ALTER TABLE `clearancerequirements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courseprograms`
--

DROP TABLE IF EXISTS `courseprograms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courseprograms` (
  `ProgramID` int(11) NOT NULL AUTO_INCREMENT,
  `CourseCode` varchar(50) NOT NULL,
  `CourseName` varchar(150) DEFAULT NULL,
  `DeanDepartmentID` int(11) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`ProgramID`),
  UNIQUE KEY `CourseCode` (`CourseCode`),
  KEY `DeanDepartmentID` (`DeanDepartmentID`),
  CONSTRAINT `courseprograms_ibfk_1` FOREIGN KEY (`DeanDepartmentID`) REFERENCES `departments` (`DepartmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseprograms`
--

LOCK TABLES `courseprograms` WRITE;
/*!40000 ALTER TABLE `courseprograms` DISABLE KEYS */;
INSERT INTO `courseprograms` VALUES (1,'BSIT','Bachelor of Science in Information Technology',11,1,'2026-10-04 17:18:11'),(2,'BSHM','Bachelor of Science in Hospitality Management',12,1,'2026-10-04 17:18:11'),(3,'BSTM','Bachelor of Science in Tourism Management',12,1,'2026-10-04 17:18:11'),(4,'CTHM','College of Tourism and Hospitality Management',12,1,'2026-10-04 17:18:11'),(5,'BSA','Bachelor of Science in Accountancy',13,1,'2026-10-04 17:18:11'),(6,'BSBA','Bachelor of Science in Business Administration',13,1,'2026-10-04 17:18:11'),(7,'BSCpE','Bachelor of Science in Computer Engineering',14,1,'2026-10-04 17:18:11');
/*!40000 ALTER TABLE `courseprograms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departments` (
  `DepartmentID` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(100) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`DepartmentID`),
  UNIQUE KEY `uq_department_name` (`DepartmentName`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'Finance Office',1,'2026-10-01 19:13:14'),(2,'Registrar',1,'2026-10-01 19:13:14'),(3,'Library',1,'2026-10-01 19:13:14'),(4,'OSA',0,'2026-10-01 19:13:14'),(5,'OAA',1,'2026-10-01 19:13:14'),(6,'Guidance Office',1,'2026-10-01 19:13:14'),(7,'NSTP Office',1,'2026-10-01 19:13:14'),(8,'CTHM Stock Room',1,'2026-10-01 19:13:14'),(9,'Clinic',1,'2026-10-01 19:13:14'),(10,'College Dean',0,'2026-10-01 19:13:14'),(11,'Dean - CCS',1,'2026-10-04 17:18:10'),(12,'Dean - CTHM',1,'2026-10-04 17:18:10'),(13,'Dean - CBA',1,'2026-10-04 17:18:10'),(14,'Dean - COE',1,'2026-10-04 17:18:10');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `guidancestudentprofiles`
--

DROP TABLE IF EXISTS `guidancestudentprofiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `guidancestudentprofiles` (
  `GuidanceProfileID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `AcademicYear` varchar(50) NOT NULL,
  `TermID` int(11) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `ContactNo` varchar(50) DEFAULT NULL,
  `Email` varchar(150) DEFAULT NULL,
  `CivilStatus` varchar(50) DEFAULT NULL,
  `EmergencyContactName` varchar(150) DEFAULT NULL,
  `EmergencyContactNo` varchar(50) DEFAULT NULL,
  `Relationship` varchar(100) DEFAULT NULL,
  `AdditionalNotes` varchar(500) DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`GuidanceProfileID`),
  UNIQUE KEY `uq_student_academic_year` (`StudentID`,`AcademicYear`),
  KEY `idx_guidance_student` (`StudentID`),
  KEY `idx_guidance_year` (`AcademicYear`),
  CONSTRAINT `fk_guidance_profile_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guidancestudentprofiles`
--

LOCK TABLES `guidancestudentprofiles` WRITE;
/*!40000 ALTER TABLE `guidancestudentprofiles` DISABLE KEYS */;
INSERT INTO `guidancestudentprofiles` VALUES (1,13,'2026-2027',1,'brgy. putatan muntilupa city','09123543453','jancris@gmail.com','Single','jancris','09123123123','Father','','2026-10-02 00:38:32','2026-10-02 00:38:32'),(6,11,'2026-2027',1,'13 muntinlupta ciry','09323123123','stundte@gmail.com','Single','rwerwe','09123123122','Mother','','2026-10-02 17:53:31','2026-10-02 17:53:31');
/*!40000 ALTER TABLE `guidancestudentprofiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sections`
--

DROP TABLE IF EXISTS `sections`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sections` (
  `SectionID` int(11) NOT NULL AUTO_INCREMENT,
  `CourseID` int(11) DEFAULT NULL,
  `CourseName` varchar(100) NOT NULL,
  `SectionName` varchar(100) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`SectionID`),
  UNIQUE KEY `uq_course_section` (`CourseName`,`SectionName`),
  KEY `idx_sections_course` (`CourseName`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sections`
--

LOCK TABLES `sections` WRITE;
/*!40000 ALTER TABLE `sections` DISABLE KEYS */;
INSERT INTO `sections` VALUES (1,NULL,'BSIT','BSIT-1A',1),(2,NULL,'BSIT','BSIT-1B',1),(3,NULL,'BSIT','BSIT-2A',1),(4,NULL,'BSIT','BSIT-3A',1),(5,NULL,'BSIT','BSIT-4A',1),(6,NULL,'BSHM','BSHM-1A',1),(7,NULL,'BSHM','BSHM-2A',1),(8,NULL,'BSHM','BSHM-3A',1),(9,NULL,'CTHM','CTHM-1A',1),(10,NULL,'CTHM','CTHM-2A',1),(11,NULL,'CTHM','CTHM-3A',1),(12,NULL,'BSA','BSA-1A',1),(13,NULL,'BSA','BSA-2A',1),(14,NULL,'BSA','BSA-3A',1),(15,NULL,'BSBA','BSBA-1A',1),(16,NULL,'BSBA','BSBA-2A',1),(17,NULL,'BSCpE','BSCpE-1A',1),(18,NULL,'BSCpE','BSCpE-2A',1);
/*!40000 ALTER TABLE `sections` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `StaffID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`StaffID`),
  UNIQUE KEY `UserID` (`UserID`),
  KEY `DepartmentID` (`DepartmentID`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE,
  CONSTRAINT `staff_ibfk_2` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,2,9,1,'2026-10-01 19:13:14','2026-10-04 17:18:12'),(2,3,10,1,'2026-10-01 19:13:14','2026-10-04 17:18:12'),(3,4,6,1,'2026-10-01 19:20:42','2026-10-04 17:18:12'),(4,5,3,1,'2026-10-01 19:20:42','2026-10-04 17:18:12'),(5,6,9,1,'2026-10-01 19:20:42','2026-10-04 17:18:12'),(6,7,8,1,'2026-10-01 19:20:43','2026-10-04 17:18:12'),(7,8,7,1,'2026-10-01 19:20:43','2026-10-04 17:18:12'),(8,9,10,1,'2026-10-01 19:20:43','2026-10-04 17:18:12'),(9,10,5,1,'2026-10-01 19:20:43','2026-10-04 17:18:12'),(16,16,11,1,'2026-10-04 17:18:13','2026-10-04 17:18:13'),(17,17,12,1,'2026-10-04 17:18:13','2026-10-04 17:18:13'),(18,18,13,1,'2026-10-04 17:18:13','2026-10-04 17:18:13'),(19,19,14,1,'2026-10-04 17:18:14','2026-10-04 17:18:14');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `StudentID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL,
  `StudentNo` varchar(30) NOT NULL,
  `Course` varchar(100) NOT NULL,
  `Section` varchar(50) NOT NULL,
  `YearLevel` varchar(30) NOT NULL,
  `StudentType` varchar(30) NOT NULL DEFAULT 'Regular',
  `EnrolledInNSTP` tinyint(1) NOT NULL DEFAULT 0,
  `ContactNo` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `CivilStatus` varchar(30) DEFAULT NULL,
  `EmergencyContactName` varchar(100) DEFAULT NULL,
  `EmergencyContactNo` varchar(20) DEFAULT NULL,
  `Relationship` varchar(50) DEFAULT NULL,
  `AdditionalNotes` varchar(500) DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`StudentID`),
  UNIQUE KEY `UserID` (`UserID`),
  UNIQUE KEY `StudentNo` (`StudentNo`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,11,'1237-24','BSIT','BSIT-1A','1st Year','Regular',1,'09323123123','stundte@gmail.com','13 muntinlupta ciry',NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51','2026-10-04 17:18:12'),(2,12,'1392-43','BSIT','BSIT-1A','1st Year','New',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53','2026-10-04 17:18:12'),(3,13,'2342-23','BSIT','BSIT-1A','1st Year','New',0,'09123543453','jancris@gmail.com','brgy. putatan muntilupa city',NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19','2026-10-04 17:18:12'),(4,14,'1231-23','BSIT','BSIT-1A','1st Year','New',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12','2026-10-04 17:18:12'),(5,15,'2383-12','BSBA','BSBA-1A','1st Year','New',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03','2026-10-04 17:18:12');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `FullName` varchar(120) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Role` varchar(20) NOT NULL,
  `StudentNo` varchar(30) DEFAULT NULL,
  `Course` varchar(100) DEFAULT NULL,
  `Section` varchar(50) DEFAULT NULL,
  `YearLevel` varchar(30) DEFAULT NULL,
  `StudentType` varchar(30) DEFAULT NULL,
  `GuidanceInfoUpdateRequired` tinyint(1) NOT NULL DEFAULT 0,
  `EnrolledInNSTP` tinyint(1) NOT NULL DEFAULT 0,
  `DepartmentID` int(11) DEFAULT NULL,
  `ContactNo` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `CivilStatus` varchar(30) DEFAULT NULL,
  `EmergencyContactName` varchar(100) DEFAULT NULL,
  `EmergencyContactNo` varchar(20) DEFAULT NULL,
  `Relationship` varchar(50) DEFAULT NULL,
  `AdditionalNotes` varchar(500) DEFAULT NULL,
  `GuidanceInfoUpdated` tinyint(1) NOT NULL DEFAULT 0,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `uq_username` (`Username`),
  UNIQUE KEY `uq_student_no` (`StudentNo`),
  KEY `idx_user_department` (`DepartmentID`),
  KEY `idx_user_role` (`Role`),
  KEY `idx_student_course_year_section` (`Course`,`YearLevel`,`Section`),
  CONSTRAINT `fk_users_department` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin123','System Administrator',NULL,NULL,'Admin',NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:13:14'),(2,'clinic_staff','clinic123','Clinic Staff Officer',NULL,NULL,'Staff',NULL,NULL,NULL,NULL,NULL,0,0,9,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:13:14'),(3,'dean_staff','dean123','College Dean Staff',NULL,NULL,'Staff',NULL,NULL,NULL,NULL,NULL,0,0,10,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:13:14'),(4,'ryzza_mae','123','Ryzza Mae','Ryzza','Mae','Staff',NULL,NULL,NULL,NULL,NULL,0,0,6,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:42'),(5,'bea_borres','123','Bea Borres','Bea','Borres','Staff',NULL,NULL,NULL,NULL,NULL,0,0,3,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:42'),(6,'mommy_oni','123','Mommy Oni','Mommy','Oni','Staff',NULL,NULL,NULL,NULL,NULL,0,0,9,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:42'),(7,'tyler','123','Tyler','Tyler','','Staff',NULL,NULL,NULL,NULL,NULL,0,0,8,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:43'),(8,'fyang','123','Fyang','Fyang','','Staff',NULL,NULL,NULL,NULL,NULL,0,0,7,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:43'),(9,'rene','123','Rene','Rene','','Staff',NULL,NULL,NULL,NULL,NULL,0,0,10,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:43'),(10,'rick','123','Rick','Rick','','Staff',NULL,NULL,NULL,NULL,NULL,0,0,5,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 19:20:43'),(11,'jonn','123','Jonn reales','Jonn','reales','Student','1237-24','BSIT','BSIT-1A','1st Year',NULL,0,1,NULL,'09323123123','stundte@gmail.com','13 muntinlupta ciry',NULL,NULL,NULL,NULL,NULL,1,1,'2026-10-01 19:21:51'),(12,'sophia','123','Sophia Solis','Sophia','Solis','Student','1392-43','BSIT','BSIT-1A','1st Year','New',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-01 20:42:53'),(13,'jancris','123','Jancris Tiu','Jancris','Tiu','Student','2342-23','BSIT','BSIT-1A','1st Year','New',0,0,NULL,'09123543453','jancris@gmail.com','brgy. putatan muntilupa city',NULL,NULL,NULL,NULL,NULL,1,1,'2026-10-01 20:46:19'),(14,'vlad','123','vlad vlad','vlad','vlad','Student','1231-23','BSIT','BSIT-1A','1st Year','New',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-02 17:36:12'),(15,'jaii','123','jaii jaii','jaii','jaii','Student','2383-12','BSBA','BSBA-1A','1st Year','New',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-02 17:37:03'),(16,'dean_ccs','123','Dean - CCS Staff','Dean','CCS','Staff',NULL,NULL,NULL,NULL,NULL,0,0,11,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-04 17:18:13'),(17,'dean_cthm','123','Dean - CTHM Staff','Dean','CTHM','Staff',NULL,NULL,NULL,NULL,NULL,0,0,12,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-04 17:18:13'),(18,'dean_cba','123','Dean - CBA Staff','Dean','CBA','Staff',NULL,NULL,NULL,NULL,NULL,0,0,13,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-04 17:18:13'),(19,'dean_coe','123','Dean - COE Staff','Dean','BS','Staff',NULL,NULL,NULL,NULL,NULL,0,0,14,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,1,'2026-10-04 17:18:13');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'loa_eclearance_'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-05  1:38:51


SET FOREIGN_KEY_CHECKS = 1;

