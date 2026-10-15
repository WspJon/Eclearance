-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: eclearance_latest
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
-- Current Database: `eclearance_latest`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `eclearance_latest` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;

USE `eclearance_latest`;

--
-- Table structure for table `academicterms`
--

DROP TABLE IF EXISTS `academicterms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `academicterms` (
  `TermID` int(11) NOT NULL AUTO_INCREMENT,
  `AcademicYear` varchar(20) NOT NULL,
  `Semester` varchar(30) NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 0,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`TermID`),
  UNIQUE KEY `uq_academic_term` (`AcademicYear`,`Semester`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicterms`
--

LOCK TABLES `academicterms` WRITE;
/*!40000 ALTER TABLE `academicterms` DISABLE KEYS */;
INSERT INTO `academicterms` VALUES (1,'2026-2027','1st Semester',1,NULL,NULL,'2026-10-03 19:37:37'),(2,'2025-2026','2nd Semester',0,NULL,NULL,'2026-10-01 00:00:00');
/*!40000 ALTER TABLE `academicterms` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancehistory`
--

LOCK TABLES `clearancehistory` WRITE;
/*!40000 ALTER TABLE `clearancehistory` DISABLE KEYS */;
INSERT INTO `clearancehistory` VALUES (1,1,11,'Submitted','Pending','Under Review','Student confirmed completion of guidance requirement.','2026-10-01 19:45:24'),(2,10,12,'Submitted','Pending','Under Review','Student confirmed completion of guidance requirement.','2026-10-01 20:43:23'),(3,19,4,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-02 00:43:09'),(4,10,12,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-02 02:19:12'),(5,10,4,'Requirement Rejected','Under Review','Rejected','Please provide complete street address in your contact information.','2026-10-02 02:19:13'),(6,10,12,'Resubmitted','Rejected','Under Review','Student corrected and resubmitted guidance information.','2026-10-02 02:19:13'),(7,10,4,'Requirement Approved / Cleared','Under Review','Cleared','All requirements verified.','2026-10-02 02:19:13'),(8,2,11,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 16:53:15'),(9,38,15,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 17:37:56'),(10,5,11,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-02 17:52:53'),(11,1,11,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-02 17:53:32'),(13,55,10001,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-11 15:11:19'),(14,64,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(15,65,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(16,66,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(17,67,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(18,68,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(19,69,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(20,70,NULL,'Requirement Added',NULL,'Pending','Office of Student Affairs clearance enabled. Awaiting student request; no concern is presumed.','2026-10-13 00:17:17'),(21,10,12,'Information Submitted','Pending','Under Review','Student submitted yearly guidance information for review.','2026-10-13 00:21:55'),(22,11,12,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-13 00:22:05'),(23,65,12,'Clearance Requested','Pending','Under Review','Student requested Office of Student Affairs verification.','2026-10-13 00:22:16'),(24,12,12,'Submitted Assessment','Pending','Under Review','Student submitted digital Health Assessment Form. Attached supporting document: Screenshot 2026-01-24 162953.png','2026-10-13 00:23:40'),(25,11,5,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-13 00:29:14'),(26,10,4,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-13 00:35:23'),(27,65,10002,'Requirement Approved / Cleared','Under Review','Cleared','Staff verified: no unresolved concerns. ','2026-10-13 00:36:56'),(28,12,6,'Returned for Completion','Under Review','Rejected','kulang','2026-10-13 00:38:08'),(29,12,12,'Resubmitted Assessment','Rejected','Under Review','Student submitted digital Health Assessment Form. Attached supporting document: Screenshot 2026-01-24 162953.png','2026-10-13 00:38:24'),(30,12,6,'Requirement Approved / Cleared','Under Review','Cleared','kulang','2026-10-13 00:38:37'),(31,15,12,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-13 01:14:49'),(32,15,16,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-13 01:15:39'),(33,16,12,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-13 01:16:05'),(34,16,12,'Submission Cancelled','Under Review','Pending','Student cancelled the submission to make corrections.','2026-10-13 01:25:48'),(35,16,12,'Submitted','Pending','Under Review','Uploaded 1 file(s) for review.','2026-10-13 01:25:54'),(36,16,10004,'Requirement Approved / Cleared','Under Review','Cleared','Requirement Approved / Cleared','2026-10-13 01:26:46'),(37,16,NULL,'Approval Undone','Cleared','Pending','Finance approval reset at the user request for testing.','2026-10-13 01:39:38'),(38,18,NULL,'Prerequisite Reset','Pending','Locked','Locked because Finance clearance was reset for testing.','2026-10-13 01:39:38'),(39,17,NULL,'Prerequisite Reset','Pending','Locked','Locked because Finance clearance was reset for testing.','2026-10-13 01:39:38'),(41,16,12,'Clearance Requested','Pending','Under Review','Student requested Finance Office verification.','2026-10-13 01:40:27'),(42,16,10004,'Requirement Approved / Cleared','Under Review','Cleared','Finance verified: all balances settled. ','2026-10-13 01:48:56');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancerecordfiles`
--

LOCK TABLES `clearancerecordfiles` WRITE;
/*!40000 ALTER TABLE `clearancerecordfiles` DISABLE KEYS */;
INSERT INTO `clearancerecordfiles` VALUES (1,2,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\2_20261003005315_1.png','Screenshot 2026-02-02 020635.png','2026-10-02 16:53:15'),(2,38,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_15\\38_20261003013756_1.png','Screenshot 2026-01-27 202500.png','2026-10-02 17:37:56'),(3,5,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\5_20261003015253_1.png','Screenshot 2026-01-20 012035.png','2026-10-02 17:52:53'),(4,11,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\11_0e1565fc_1.png','Screenshot 2026-01-25 022624.png','2026-10-13 00:22:05'),(5,12,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\12_20261013082339_Screenshot 2026-01-24 162953.png','Screenshot 2026-01-24 162953.png','2026-10-13 00:23:40'),(6,15,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\15_4488ae19_1.png','Screenshot 2026-01-21 024255.png','2026-10-13 01:14:49'),(8,16,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\16_7cebe514_1.png','Screenshot 2026-01-28 133314.png','2026-10-13 01:25:54');
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
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clearancerecords`
--

LOCK TABLES `clearancerecords` WRITE;
/*!40000 ALTER TABLE `clearancerecords` DISABLE KEYS */;
INSERT INTO `clearancerecords` VALUES (1,11,6,1,'Under Review',NULL,NULL,NULL,'2026-10-02 17:53:32',NULL,NULL,'2026-10-01 19:21:51'),(2,11,3,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\2_20261003005315_1.png','Screenshot 2026-02-02 020635.png','2026-10-02 16:53:15',NULL,NULL,'2026-10-01 19:21:51'),(3,11,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(4,11,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(5,11,7,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_11\\5_20261003015253_1.png','Screenshot 2026-01-20 012035.png','2026-10-02 17:52:53',NULL,NULL,'2026-10-01 19:21:51'),(6,11,11,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(7,11,1,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(8,11,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(9,11,5,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51'),(10,12,6,1,'Cleared',NULL,NULL,NULL,'2026-10-13 00:21:55',4,'2026-10-13 00:35:23','2026-10-01 20:42:53'),(11,12,3,1,'Cleared',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\11_0e1565fc_1.png','Screenshot 2026-01-25 022624.png','2026-10-13 00:22:05',5,'2026-10-13 00:29:14','2026-10-01 20:42:53'),(12,12,9,1,'Cleared','kulang','D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\12_20261013082339_Screenshot 2026-01-24 162953.png','Screenshot 2026-01-24 162953.png','2026-10-13 00:38:24',6,'2026-10-13 00:38:37','2026-10-01 20:42:53'),(13,12,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(14,12,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(15,12,11,1,'Cleared',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\15_4488ae19_1.png','Screenshot 2026-01-21 024255.png','2026-10-13 01:14:49',16,'2026-10-13 01:15:39','2026-10-01 20:42:53'),(16,12,1,1,'Cleared',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_12\\16_7cebe514_1.png','Screenshot 2026-01-28 133314.png','2026-10-13 01:40:27',10004,'2026-10-13 01:48:56','2026-10-01 20:42:53'),(17,12,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(18,12,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:42:53'),(19,13,6,1,'Cleared',NULL,NULL,NULL,'2026-10-02 00:38:34',4,'2026-10-02 00:43:08','2026-10-01 20:46:19'),(20,13,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(21,13,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(22,13,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(23,13,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(24,13,11,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(25,13,1,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(26,13,2,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(27,13,5,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19'),(28,14,6,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(29,14,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(30,14,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(31,14,8,1,'Not Applicable',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(32,14,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(33,14,11,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12'),(34,14,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(35,14,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(36,14,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:13'),(37,15,6,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(38,15,3,1,'Under Review',NULL,'D:\\Downloads\\Eclearance\\Eclearance\\Eclearance\\bin\\Debug\\net8.0-windows\\Uploads\\Student_15\\38_20261003013756_1.png','Screenshot 2026-01-27 202500.png','2026-10-02 17:37:56',NULL,NULL,'2026-10-02 17:37:03'),(39,15,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(40,15,8,1,'Not Applicable',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(41,15,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(42,15,13,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(43,15,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(44,15,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(45,15,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03'),(46,10000,6,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(47,10000,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(48,10000,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(49,10000,8,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(50,10000,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(51,10000,12,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(52,10000,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(53,10000,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(54,10000,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23'),(55,10001,6,1,'Under Review',NULL,NULL,NULL,'2026-10-11 15:11:19',NULL,NULL,'2026-10-11 15:10:14'),(56,10001,3,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(57,10001,9,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(58,10001,8,1,'Not Applicable',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(59,10001,7,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(60,10001,13,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(61,10001,1,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(62,10001,2,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(63,10001,5,1,'Locked',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-11 15:10:14'),(64,11,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17'),(65,12,4,1,'Cleared',NULL,NULL,NULL,'2026-10-13 00:22:16',10002,'2026-10-13 00:36:56','2026-10-13 00:17:17'),(66,13,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17'),(67,14,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17'),(68,15,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17'),(69,10000,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17'),(70,10001,4,1,'Pending',NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-13 00:17:17');
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
  `DisplayOrder` int(11) NOT NULL DEFAULT 0,
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
INSERT INTO `clearancerequirements` VALUES (1,1,'Finance Clearance','Finance staff will verify your payment status. Clearance will be approved once all outstanding balances are settled.',0,NULL,0,7,NULL,NULL,NULL,1,'2026-10-01 19:13:15',8),(2,2,'Registrar Clearance','Registrar staff will review your clearance after Finance approval.',0,NULL,0,8,NULL,NULL,NULL,1,'2026-10-01 19:13:15',9),(3,3,'Library Clearance','Submit a screenshot of the completed Library survey for verification and clearance approval.',1,NULL,0,2,NULL,NULL,NULL,1,'2026-10-01 19:13:15',2),(4,4,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,NULL,0,2,'https://example.com/student-evaluation',NULL,NULL,1,'2026-10-01 19:13:15',3),(5,5,'OAA Clearance','OAA staff will review your clearance after Registrar approval.',0,NULL,0,9,NULL,NULL,NULL,1,'2026-10-01 19:13:15',10),(6,6,'Guidance Clearance','Complete the required Guidance process and review or update your student information for the current academic year.',0,NULL,0,1,NULL,NULL,NULL,1,'2026-10-01 19:13:15',1),(7,7,'NSTP Clearance','Complete the required NSTP clearance.',1,NULL,1,5,NULL,NULL,'1st Year,First Year,1',1,'2026-10-01 19:13:15',6),(8,8,'CTHM Stock Room Clearance','Return or settle all required CTHM stock room items.',1,'CTHM,BSHM,BSTM',0,4,NULL,'CTHM,BSHM,BSTM,Hospitality,Tourism',NULL,1,'2026-10-01 19:13:15',5),(9,9,'Clinic Clearance','Complete the digital Health Assessment Form. Submit additional medical certificates or examination results only if requested by Clinic staff.',0,NULL,0,3,NULL,NULL,NULL,1,'2026-10-01 19:13:15',4),(10,10,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,NULL,0,6,'https://example.com/student-evaluation',NULL,NULL,0,'2026-10-01 19:13:15',7),(11,11,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,'BSIT',0,6,'https://example.com/student-evaluation','BSIT',NULL,1,'2026-10-04 17:18:13',7),(12,12,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,'BSHM,BSTM,CTHM',0,6,'https://example.com/student-evaluation','BSHM,BSTM,CTHM',NULL,1,'2026-10-04 17:18:13',7),(13,13,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,'BSA,BSBA',0,6,'https://example.com/student-evaluation','BSA,BSBA',NULL,1,'2026-10-04 17:18:13',7),(14,14,'Student Evaluation Survey','Complete the student evaluation survey using the provided link. After completing the survey, take a screenshot of the submission confirmation page and upload it as proof of completion.',1,'BSCpE',0,6,'https://example.com/student-evaluation','BSCpE',NULL,1,'2026-10-04 17:18:13',7);
/*!40000 ALTER TABLE `clearancerequirements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clinichealthassessments`
--

DROP TABLE IF EXISTS `clinichealthassessments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clinichealthassessments` (
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
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`AssessmentID`),
  UNIQUE KEY `uq_clinic_record` (`RecordID`),
  KEY `idx_clinic_student` (`StudentID`),
  KEY `idx_clinic_term` (`TermID`),
  CONSTRAINT `fk_clinic_assessment_record` FOREIGN KEY (`RecordID`) REFERENCES `clearancerecords` (`RecordID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_clinic_assessment_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_clinic_assessment_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clinichealthassessments`
--

LOCK TABLES `clinichealthassessments` WRITE;
/*!40000 ALTER TABLE `clinichealthassessments` DISABLE KEYS */;
INSERT INTO `clinichealthassessments` VALUES (1,12,12,1,'2026-2027',0,'',1,'',1,'',1,'','sophia','Mother','09123453453',1,0,'2026-10-13 08:38:23','2026-10-13 00:23:40','2026-10-13 00:38:23');
/*!40000 ALTER TABLE `clinichealthassessments` ENABLE KEYS */;
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
INSERT INTO `departments` VALUES (1,'Finance Office',1,'2026-10-01 19:13:14'),(2,'Registrar',1,'2026-10-01 19:13:14'),(3,'Library',1,'2026-10-01 19:13:14'),(4,'Office of Student Affairs',1,'2026-10-01 19:13:14'),(5,'OAA',1,'2026-10-01 19:13:14'),(6,'Guidance Office',1,'2026-10-01 19:13:14'),(7,'NSTP Office',1,'2026-10-01 19:13:14'),(8,'CTHM Stock Room',1,'2026-10-01 19:13:14'),(9,'Clinic',1,'2026-10-01 19:13:14'),(10,'College Dean',0,'2026-10-01 19:13:14'),(11,'CCS',1,'2026-10-04 17:18:10'),(12,'CTHM',1,'2026-10-04 17:18:10'),(13,'CBA',1,'2026-10-04 17:18:10'),(14,'COE',1,'2026-10-04 17:18:10');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guidancestudentprofiles`
--

LOCK TABLES `guidancestudentprofiles` WRITE;
/*!40000 ALTER TABLE `guidancestudentprofiles` DISABLE KEYS */;
INSERT INTO `guidancestudentprofiles` VALUES (1,13,'2026-2027',1,'brgy. putatan muntilupa city','09123543453','jancris@gmail.com','Single','jancris','09123123123','Father','','2026-10-02 00:38:32','2026-10-02 00:38:32'),(6,11,'2026-2027',1,'13 muntinlupta ciry','09323123123','stundte@gmail.com','Single','rwerwe','09123123122','Mother','','2026-10-02 17:53:31','2026-10-02 17:53:31'),(7,10001,'2026-2027',1,'14 pacita','09123543345','esther@gmail.com','Single','esther','09123345345','Mother','','2026-10-11 15:11:19','2026-10-11 15:11:19'),(8,12,'2026-2027',1,'123 muntilupa city','09234234234','sophia@gmail.com','Single','sophia','09123453453','Mother','','2026-10-13 00:21:55','2026-10-13 00:21:55');
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
) ENGINE=InnoDB AUTO_INCREMENT=10003 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,2,9,1,'2026-10-01 11:13:14','2026-10-04 09:18:12'),(3,4,6,1,'2026-10-01 11:20:42','2026-10-04 09:18:12'),(4,5,3,1,'2026-10-01 11:20:42','2026-10-04 09:18:12'),(5,6,9,1,'2026-10-01 11:20:42','2026-10-04 09:18:12'),(6,7,8,1,'2026-10-01 11:20:43','2026-10-04 09:18:12'),(7,8,7,1,'2026-10-01 11:20:43','2026-10-04 09:18:12'),(9,10,5,1,'2026-10-01 11:20:43','2026-10-04 09:18:12'),(16,16,11,1,'2026-10-04 09:18:13','2026-10-04 09:18:13'),(17,17,12,1,'2026-10-04 09:18:13','2026-10-04 09:18:13'),(18,18,13,1,'2026-10-04 09:18:13','2026-10-04 09:18:13'),(19,19,14,1,'2026-10-04 09:18:14','2026-10-04 09:18:14'),(10000,10002,4,1,'2026-10-13 00:36:21','2026-10-13 00:36:21'),(10001,10003,13,1,'2026-10-13 01:16:37','2026-10-13 01:16:37'),(10002,10004,1,1,'2026-10-13 01:26:31','2026-10-13 01:26:31');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,11,'1237-24','BSIT','BSIT-1A','1st Year','Regular',1,'09323123123','stundte@gmail.com','13 muntinlupta ciry',NULL,NULL,NULL,NULL,NULL,'2026-10-01 19:21:51','2026-10-04 17:18:12'),(2,12,'1392-43','BSIT','BSIT-1A','1st Year','New',0,'09234234234','sophia@gmail.com','123 muntilupa city','Single','sophia','09123453453','Mother','','2026-10-01 20:42:53','2026-10-13 00:21:55'),(3,13,'2342-23','BSIT','BSIT-1A','1st Year','New',0,'09123543453','jancris@gmail.com','brgy. putatan muntilupa city',NULL,NULL,NULL,NULL,NULL,'2026-10-01 20:46:19','2026-10-04 17:18:12'),(4,14,'1231-23','BSIT','BSIT-1A','1st Year','New',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:36:12','2026-10-04 17:18:12'),(5,15,'2383-12','BSBA','BSBA-1A','1st Year','New',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-02 17:37:03','2026-10-04 17:18:12'),(7,10000,'1328-23','CTHM','CTHM-1A','1st Year','New',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2026-10-07 14:39:23','2026-10-07 14:39:23'),(8,10001,'1334-25','BSA','BSA-1A','1st Year','New',1,'09123543345','esther@gmail.com','14 pacita','Single','esther','09123345345','Mother','','2026-10-11 15:10:14','2026-10-11 15:11:19');
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
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `UpdatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `uq_username` (`Username`),
  KEY `idx_user_role` (`Role`)
) ENGINE=InnoDB AUTO_INCREMENT=10005 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin123','System Administrator',NULL,NULL,'Admin',1,'2026-10-01 19:13:14','2026-10-07 14:57:04'),(2,'clinic_staff','clinic123','Clinic Staff Officer',NULL,NULL,'Staff',1,'2026-10-01 19:13:14','2026-10-07 14:57:04'),(4,'ryzza_mae','123','Ryzza Mae','Ryzza','Mae','Staff',1,'2026-10-01 19:20:42','2026-10-07 14:57:04'),(5,'bea_borres','123','Bea Borres','Bea','Borres','Staff',1,'2026-10-01 19:20:42','2026-10-07 14:57:04'),(6,'mommy_oni','123','Mommy Oni','Mommy','Oni','Staff',1,'2026-10-01 19:20:42','2026-10-07 14:57:04'),(7,'tyler','123','Tyler','Tyler','','Staff',1,'2026-10-01 19:20:43','2026-10-07 14:57:04'),(8,'fyang','123','Fyang','Fyang','','Staff',1,'2026-10-01 19:20:43','2026-10-07 14:57:04'),(10,'rick','123','Rick','Rick','','Staff',1,'2026-10-01 19:20:43','2026-10-07 14:57:04'),(11,'jonn','123','Jonn reales','Jonn','reales','Student',1,'2026-10-01 19:21:51','2026-10-07 14:57:04'),(12,'sophia','123','Sophia Solis','Sophia','Solis','Student',1,'2026-10-01 20:42:53','2026-10-07 14:57:04'),(13,'jancris','123','Jancris Tiu','Jancris','Tiu','Student',1,'2026-10-01 20:46:19','2026-10-07 14:57:04'),(14,'vlad','123','vlad vlad','vlad','vlad','Student',1,'2026-10-02 17:36:12','2026-10-07 14:57:04'),(15,'jaii','123','jaii jaii','jaii','jaii','Student',1,'2026-10-02 17:37:03','2026-10-07 14:57:04'),(16,'dean_ccs','123','CCS Staff','Dean','CCS','Staff',1,'2026-10-04 17:18:13','2026-10-07 14:57:04'),(17,'dean_cthm','123','CTHM Staff','Dean','CTHM','Staff',1,'2026-10-04 17:18:13','2026-10-07 14:57:04'),(18,'dean_cba','123','CBA Staff','Dean','CBA','Staff',1,'2026-10-04 17:18:13','2026-10-07 14:57:04'),(19,'dean_coe','123','COE Staff','Dean','BS','Staff',1,'2026-10-04 17:18:13','2026-10-07 14:57:04'),(10000,'renamin','123','rish renami','rish','renami','Student',1,'2026-10-07 14:39:21','2026-10-07 14:57:04'),(10001,'esther','123','Esther Dela Cruz','Esther','Dela Cruz','Student',1,'2026-10-11 15:10:14','2026-10-11 15:10:14'),(10002,'mavs','123','Maverick',NULL,NULL,'Staff',1,'2026-10-13 00:36:19','2026-10-13 00:36:19'),(10003,'doom','123','doom',NULL,NULL,'Staff',1,'2026-10-13 01:16:37','2026-10-13 01:16:37'),(10004,'daniel','123','daniel',NULL,NULL,'Staff',1,'2026-10-13 01:26:31','2026-10-13 01:26:31');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studenttermenrollments`
--

DROP TABLE IF EXISTS `studenttermenrollments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studenttermenrollments` (
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
  UNIQUE KEY `uq_student_term_enrollment` (`StudentID`,`TermID`),
  KEY `idx_enrollment_student` (`StudentID`),
  KEY `idx_enrollment_term` (`TermID`),
  KEY `idx_enrollment_verifier` (`VerifiedBy`),
  CONSTRAINT `fk_enrollment_student` FOREIGN KEY (`StudentID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_enrollment_term` FOREIGN KEY (`TermID`) REFERENCES `academicterms` (`TermID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_enrollment_verifier` FOREIGN KEY (`VerifiedBy`) REFERENCES `users` (`UserID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'eclearance_latest'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-13  9:55:52
