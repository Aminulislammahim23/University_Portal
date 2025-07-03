CREATE TABLE Students (
    StudentID VARCHAR(20) PRIMARY KEY,
    FullName VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(20),
    DOB DATE,
    Gender VARCHAR(10),
    Address TEXT,
    DepartmentID VARCHAR(10),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Departments (
    DepartmentID VARCHAR(10) PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Courses (
    CourseID VARCHAR(20) PRIMARY KEY,
    CourseName VARCHAR(100),
    DepartmentID VARCHAR(10),
    CreditHours INT,
    FacultyID VARCHAR(20),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);

CREATE TABLE Courses (
    CourseID VARCHAR(20) PRIMARY KEY,
    CourseName VARCHAR(100),
    DepartmentID VARCHAR(10),
    CreditHours INT,
    FacultyID VARCHAR(20),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);

CREATE TABLE Faculty (
    FacultyID VARCHAR(20) PRIMARY KEY,
    FullName VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(20),
    DepartmentID VARCHAR(10),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
    StudentID VARCHAR(20),
    CourseID VARCHAR(20),
    EnrollmentDate DATE,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Grades (
    GradeID INT PRIMARY KEY IDENTITY(1,1),
    EnrollmentID INT,
    Grade VARCHAR(5),
    FOREIGN KEY (EnrollmentID) REFERENCES Enrollments(EnrollmentID)
);

CREATE TABLE Users (
    UserID VARCHAR(20) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARCHAR(255),
    Role VARCHAR(20), -- e.g., Student, Faculty, Admin
    LinkedID VARCHAR(20), -- StudentID or FacultyID
    FOREIGN KEY (LinkedID) REFERENCES Students(StudentID) -- or Faculty(FacultyID), depending on role
);
