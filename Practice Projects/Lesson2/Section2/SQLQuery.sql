DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Subjects;
DROP TABLE IF EXISTS Classes;

CREATE TABLE Student (
	StudentID DECIMAL(12) PRIMARY KEY NOT NULL,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
);

CREATE TABLE Subjects (
	SubjectsID DECIMAL(12) PRIMARY KEY NOT NULL,
	Subject VARCHAR(255) NOT NULL,
);

CREATE TABLE Classes (
	ClassID DECIMAL(12) PRIMARY KEY NOT NULL,
	Class VARCHAR(255) NOT NULL
);

CREATE UNIQUE INDEX studentID_index ON Student (StudentID);
CREATE UNIQUE INDEX subjectsID_index ON Subjects (SubjectsID);
CREATE UNIQUE INDEX classesID_index on Classes (ClassID);