-- Create Intake Table
CREATE TABLE Intake (
    ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) not null,
    StartDate DATE not null,
    EndDate as DATEADD(month, 12, startdate) PERSISTED,
	constraint DateCheck CHECK(StartDate < EndDate),
);

-- Create Department Table
CREATE TABLE Department (
    ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) not null,
    Describe NVARCHAR(255)
);

-- Create Person Table
CREATE TABLE Person(
	ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) not null,
    Email NVARCHAR(255) UNIQUE not null check(Email like '%___@___%.__%'),
	NID NVARCHAR(14) UNIQUE not null CHECK (LEN(NID) = 14 AND NID LIKE '%[0-9]%'),
    Address NVARCHAR(255) not null,
    Gender CHAR(1) check(Gender in ('F','M')),
	Salary DECIMAL(18, 2),
    DOB DATE check(DATEDIFF(year,DOB,getdate()) between 22 and 70),
	Phone NVARCHAR(15),
	Role NVARCHAR(30) NOT NULL check(Role in ('Admin','Student','Instructor')),
	Password NVARCHAR(255) not null check(len(Password) >= 3), 
	DeptID INT,
	FOREIGN KEY (DeptID) REFERENCES Department(ID) on delete set null,
)

-- Create Student Table
CREATE TABLE Student (
    StdID INT PRIMARY KEY,
    IntakeID INT,
	College NVARCHAR(255)
    FOREIGN KEY (IntakeID) REFERENCES Intake(ID) on delete set null,
	FOREIGN KEY (StdID) REFERENCES Person(ID) on delete cascade
);

-- Create Instructor Table
CREATE TABLE Instructor (
    InsID INT PRIMARY KEY,
	Hiredate DATE,
	FOREIGN KEY (InsID) REFERENCES Person(ID) on delete cascade
);

-- Create Course Table
CREATE TABLE Course (
    ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Hours INT check(hours between 3 and 100),
);

-- Create Topic Table
CREATE TABLE Topic (
    ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) not null,
    CrsID INT not null,
    FOREIGN KEY (CrsID) REFERENCES Course(ID) on delete cascade
);

-- Create Teaches Table
CREATE TABLE Std_Crs(
	StdID INT not null,
	CrsID INT not null,
	primary key(StdID,CrsID),
	FOREIGN KEY (StdID) REFERENCES Student(StdID) on delete cascade,
	FOREIGN KEY (CrsID) REFERENCES Course(ID) on delete cascade
)


-- Create Teaches Table
CREATE TABLE Ins_Crs(
	InsID INT not null,
	CrsID INT not null,
	primary key(InsID,CrsID),
	FOREIGN KEY (InsID) REFERENCES Instructor(InsID) on delete cascade,
	FOREIGN KEY (CrsID) REFERENCES Course(ID) on delete cascade
)

-- Create Exam Table
CREATE TABLE Exam (
    ID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100),
    StartDate DATETIME NOT NULL,
    EndDate AS DATEADD(HOUR, 1, startdate) PERSISTED,
    CrsID INT NOT NULL,
    FOREIGN KEY (CrsID) REFERENCES Course(ID) ON DELETE CASCADE,
);

-- Create Student_Exam Table
CREATE TABLE Student_Exam (
    StdID INT,
    ExamID INT,
    Grade INT, 
    PRIMARY KEY (StdID, ExamID),
    FOREIGN KEY (StdID) REFERENCES Student(StdID) ON DELETE CASCADE,
    FOREIGN KEY (ExamID) REFERENCES Exam(ID) ON DELETE CASCADE
);

-- Create Question Table
CREATE TABLE Question (
    ID INT IDENTITY PRIMARY KEY,
    Body NVARCHAR(MAX) NOT NULL,
    Type NVARCHAR(10) NOT NULL CHECK(Type IN ('T/F','MCQ')),
    Degree INT NOT NULL CHECK(Degree BETWEEN 1 AND 5), 
    CorrectChoice INT NOT NULL CHECK(CorrectChoice BETWEEN 1 AND 4),
	CrsID INT NOT NULL,
	isDeleted BIT DEFAULT 0,
	FOREIGN KEY (CrsID) REFERENCES Course(ID) ON DELETE CASCADE
);


-- Create Choice Table
CREATE TABLE Choice (
    QID INT,
    Choice INT CHECK(Choice BETWEEN 1 AND 4),
	Body NVARCHAR(MAX) NOT NULL,
    PRIMARY KEY (QID, Choice),
    FOREIGN KEY (QID) REFERENCES Question(ID) ON DELETE CASCADE
);

-- Create Take_Exam Table
CREATE TABLE Answer_Exam (
    ExamID INT,
    QID INT,
    StdID INT,
    Answer INT DEFAULT 0,
    PRIMARY KEY (ExamID, QID, StdID), 
    FOREIGN KEY (ExamID) REFERENCES Exam(ID) on delete cascade,
    FOREIGN KEY (QID) REFERENCES Question(ID),
    FOREIGN KEY (StdID) REFERENCES Student(StdID) on delete cascade
);
SELECT * FROM dbo.Person