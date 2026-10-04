-- Migration script: Separate Students and Staff, add 4 Dean departments and course mappings
USE loa_eclearance_;

-- 1. Insert new Dean Departments if they don't already exist
INSERT INTO Departments (DepartmentName, IsActive)
SELECT 'Dean - CCS', 1
WHERE NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentName = 'Dean - CCS');

INSERT INTO Departments (DepartmentName, IsActive)
SELECT 'Dean - CTHM', 1
WHERE NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentName = 'Dean - CTHM');

INSERT INTO Departments (DepartmentName, IsActive)
SELECT 'Dean - CBA', 1
WHERE NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentName = 'Dean - CBA');

INSERT INTO Departments (DepartmentName, IsActive)
SELECT 'Dean - COE', 1
WHERE NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentName = 'Dean - COE');

-- Optional: mark legacy generic 'College Dean' department inactive for future assignments
UPDATE Departments SET IsActive = 0 WHERE DepartmentName = 'College Dean';

-- 2. Create CoursePrograms table for Dean mapping
CREATE TABLE IF NOT EXISTS CoursePrograms (
    ProgramID INT AUTO_INCREMENT PRIMARY KEY,
    CourseCode VARCHAR(50) NOT NULL UNIQUE,
    CourseName VARCHAR(150) NULL,
    DeanDepartmentID INT NOT NULL,
    IsActive TINYINT(1) NOT NULL DEFAULT 1,
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (DeanDepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert course mappings
INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSIT', 'Bachelor of Science in Information Technology', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CCS'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSHM', 'Bachelor of Science in Hospitality Management', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CTHM'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSTM', 'Bachelor of Science in Tourism Management', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CTHM'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'CTHM', 'College of Tourism and Hospitality Management', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CTHM'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSA', 'Bachelor of Science in Accountancy', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CBA'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSBA', 'Bachelor of Science in Business Administration', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CBA'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

INSERT INTO CoursePrograms (CourseCode, CourseName, DeanDepartmentID, IsActive)
SELECT 'BSCpE', 'Bachelor of Science in Computer Engineering', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - COE'
ON DUPLICATE KEY UPDATE DeanDepartmentID = VALUES(DeanDepartmentID), IsActive = 1;

-- 3. Create Students table
CREATE TABLE IF NOT EXISTS Students (
    StudentID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL UNIQUE,
    StudentNo VARCHAR(30) NOT NULL UNIQUE,
    Course VARCHAR(100) NOT NULL,
    Section VARCHAR(50) NOT NULL,
    YearLevel VARCHAR(30) NOT NULL,
    StudentType VARCHAR(30) NOT NULL DEFAULT 'Regular',
    EnrolledInNSTP TINYINT(1) NOT NULL DEFAULT 0,
    ContactNo VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    Address VARCHAR(255) NULL,
    CivilStatus VARCHAR(30) NULL,
    EmergencyContactName VARCHAR(100) NULL,
    EmergencyContactNo VARCHAR(20) NULL,
    Relationship VARCHAR(50) NULL,
    AdditionalNotes VARCHAR(500) NULL,
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Copy existing student records into Students
INSERT INTO Students (UserID, StudentNo, Course, Section, YearLevel, StudentType, EnrolledInNSTP, ContactNo, Email, Address, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, AdditionalNotes, CreatedAt)
SELECT UserID, StudentNo, Course, Section, YearLevel, COALESCE(StudentType, 'Regular'), COALESCE(EnrolledInNSTP, 0), ContactNo, Email, Address, CivilStatus, EmergencyContactName, EmergencyContactNo, Relationship, AdditionalNotes, CreatedAt
FROM Users
WHERE Role = 'Student'
ON DUPLICATE KEY UPDATE
StudentNo = VALUES(StudentNo),
Course = VALUES(Course),
Section = VALUES(Section),
YearLevel = VALUES(YearLevel);

-- 4. Create Staff table
CREATE TABLE IF NOT EXISTS Staff (
    StaffID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL UNIQUE,
    DepartmentID INT NOT NULL,
    IsActive TINYINT(1) NOT NULL DEFAULT 1,
    CreatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Copy existing staff records into Staff
INSERT INTO Staff (UserID, DepartmentID, IsActive, CreatedAt)
SELECT UserID, DepartmentID, IsActive, CreatedAt
FROM Users
WHERE Role = 'Staff' AND DepartmentID IS NOT NULL
ON DUPLICATE KEY UPDATE
DepartmentID = VALUES(DepartmentID),
IsActive = VALUES(IsActive);

-- 5. Insert Clearance Requirements for the 4 Deans
-- Deactivate old generic College Dean requirement (RequirementID = 10)
UPDATE ClearanceRequirements SET IsActive = 0 WHERE RequirementName = 'College Dean Clearance' OR DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'College Dean');

-- Insert Dean - CCS Clearance
INSERT INTO ClearanceRequirements (DepartmentID, RequirementName, Instructions, RequiresFile, SequenceOrder, ApplicableCourses, IsActive)
SELECT d.DepartmentID, 'Dean - CCS Clearance', 'Submit required clearance documents for CCS students.', 1, 6, 'BSIT', 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CCS'
AND NOT EXISTS (SELECT 1 FROM ClearanceRequirements WHERE RequirementName = 'Dean - CCS Clearance');

-- Insert Dean - CTHM Clearance
INSERT INTO ClearanceRequirements (DepartmentID, RequirementName, Instructions, RequiresFile, SequenceOrder, ApplicableCourses, IsActive)
SELECT d.DepartmentID, 'Dean - CTHM Clearance', 'Submit required clearance documents for CTHM students.', 1, 6, 'BSHM,BSTM,CTHM', 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CTHM'
AND NOT EXISTS (SELECT 1 FROM ClearanceRequirements WHERE RequirementName = 'Dean - CTHM Clearance');

-- Insert Dean - CBA Clearance
INSERT INTO ClearanceRequirements (DepartmentID, RequirementName, Instructions, RequiresFile, SequenceOrder, ApplicableCourses, IsActive)
SELECT d.DepartmentID, 'Dean - CBA Clearance', 'Submit required clearance documents for CBA students.', 1, 6, 'BSA,BSBA', 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CBA'
AND NOT EXISTS (SELECT 1 FROM ClearanceRequirements WHERE RequirementName = 'Dean - CBA Clearance');

-- Insert Dean - COE Clearance
INSERT INTO ClearanceRequirements (DepartmentID, RequirementName, Instructions, RequiresFile, SequenceOrder, ApplicableCourses, IsActive)
SELECT d.DepartmentID, 'Dean - COE Clearance', 'Submit required clearance documents for College of Engineering (BSCpE) students.', 1, 6, 'BSCpE', 1
FROM Departments d WHERE d.DepartmentName = 'Dean - COE'
AND NOT EXISTS (SELECT 1 FROM ClearanceRequirements WHERE RequirementName = 'Dean - COE Clearance');

-- 6. Insert Dean Staff accounts into Users and Staff
-- dean_ccs
INSERT INTO Users (Username, Password, FullName, FirstName, LastName, Role, DepartmentID, IsActive)
SELECT 'dean_ccs', '123', 'Dean - CCS Staff', 'Dean', 'CCS', 'Staff', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CCS'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

INSERT INTO Staff (UserID, DepartmentID, IsActive)
SELECT u.UserID, u.DepartmentID, 1
FROM Users u WHERE u.Username = 'dean_ccs'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

-- dean_cthm
INSERT INTO Users (Username, Password, FullName, FirstName, LastName, Role, DepartmentID, IsActive)
SELECT 'dean_cthm', '123', 'Dean - CTHM Staff', 'Dean', 'CTHM', 'Staff', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CTHM'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

INSERT INTO Staff (UserID, DepartmentID, IsActive)
SELECT u.UserID, u.DepartmentID, 1
FROM Users u WHERE u.Username = 'dean_cthm'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

-- dean_cba
INSERT INTO Users (Username, Password, FullName, FirstName, LastName, Role, DepartmentID, IsActive)
SELECT 'dean_cba', '123', 'Dean - CBA Staff', 'Dean', 'CBA', 'Staff', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - CBA'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

INSERT INTO Staff (UserID, DepartmentID, IsActive)
SELECT u.UserID, u.DepartmentID, 1
FROM Users u WHERE u.Username = 'dean_cba'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

-- dean_coe
INSERT INTO Users (Username, Password, FullName, FirstName, LastName, Role, DepartmentID, IsActive)
SELECT 'dean_coe', '123', 'Dean - COE Staff', 'Dean', 'COE', 'Staff', d.DepartmentID, 1
FROM Departments d WHERE d.DepartmentName = 'Dean - COE'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

INSERT INTO Staff (UserID, DepartmentID, IsActive)
SELECT u.UserID, u.DepartmentID, 1
FROM Users u WHERE u.Username = 'dean_coe'
ON DUPLICATE KEY UPDATE DepartmentID = VALUES(DepartmentID);

-- 7. Update active term Step 6 ClearanceRecords to point to the correct course-specific Dean requirement
-- For BSIT students:
UPDATE ClearanceRecords cr
JOIN Users u ON cr.StudentID = u.UserID
JOIN ClearanceRequirements old_req ON cr.RequirementID = old_req.RequirementID
JOIN ClearanceRequirements new_req ON new_req.RequirementName = 'Dean - CCS Clearance'
SET cr.RequirementID = new_req.RequirementID
WHERE (old_req.SequenceOrder = 6 OR old_req.RequirementName = 'College Dean Clearance')
  AND u.Course = 'BSIT';

-- For BSHM, BSTM, CTHM students:
UPDATE ClearanceRecords cr
JOIN Users u ON cr.StudentID = u.UserID
JOIN ClearanceRequirements old_req ON cr.RequirementID = old_req.RequirementID
JOIN ClearanceRequirements new_req ON new_req.RequirementName = 'Dean - CTHM Clearance'
SET cr.RequirementID = new_req.RequirementID
WHERE (old_req.SequenceOrder = 6 OR old_req.RequirementName = 'College Dean Clearance')
  AND (u.Course LIKE '%HM%' OR u.Course LIKE '%TM%' OR u.Course LIKE '%CTHM%');

-- For BSA, BSBA students:
UPDATE ClearanceRecords cr
JOIN Users u ON cr.StudentID = u.UserID
JOIN ClearanceRequirements old_req ON cr.RequirementID = old_req.RequirementID
JOIN ClearanceRequirements new_req ON new_req.RequirementName = 'Dean - CBA Clearance'
SET cr.RequirementID = new_req.RequirementID
WHERE (old_req.SequenceOrder = 6 OR old_req.RequirementName = 'College Dean Clearance')
  AND (u.Course LIKE '%BA%' OR u.Course LIKE '%BSA%');

-- For BSCpE students:
UPDATE ClearanceRecords cr
JOIN Users u ON cr.StudentID = u.UserID
JOIN ClearanceRequirements old_req ON cr.RequirementID = old_req.RequirementID
JOIN ClearanceRequirements new_req ON new_req.RequirementName = 'Dean - COE Clearance'
SET cr.RequirementID = new_req.RequirementID
WHERE (old_req.SequenceOrder = 6 OR old_req.RequirementName = 'College Dean Clearance')
  AND (u.Course LIKE '%CpE%' OR u.Course = 'BS' OR u.Course LIKE '%Computer Eng%');
