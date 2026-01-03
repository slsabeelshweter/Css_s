
CREATE DATABASE Schoool;

CREATE TABLE Students (
    Student_ID INT IDENTITY PRIMARY KEY,
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    Date_Of_Birth DATE,
    Address VARCHAR(200),
    Email VARCHAR(100)
);


INSERT INTO Students VALUES
('Ali', 'Saleh', '2005-03-12', 'Amman', 'ali@email.com'),
('Mona', 'Ahmad', '2006-07-21', 'Irbid', 'mona@email.com'),
('Yousef', 'Hassan', '2005-11-03', 'Zarqa', 'yousef@email.com'),
('Rana', 'Omar', '2006-01-18', 'Salt', 'rana@email.com'),
('Khaled', 'Nasser', '2005-09-09', 'Aqaba', 'khaled@email.com');

select * from Students

CREATE TABLE Family_Info (
    Family_ID INT IDENTITY PRIMARY KEY,
    Student_ID INT,
    Father_Name VARCHAR(100),
    Phone_Number VARCHAR(20),
    Email VARCHAR(100),
    FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID)
);


INSERT INTO Family_Info VALUES
(1, 'Saleh Ali', '0791111111', 'father1@email.com'),
(2, 'Ahmad Mona', '0792222222', 'father2@email.com'),
(3, 'Hassan Yousef', '0793333333', 'father3@email.com'),
(4, 'Omar Rana', '0794444444', 'father4@email.com'),
(5, 'Nasser Khaled', '0795555555', 'father5@email.com');

select *from Family_Info


CREATE TABLE Courses (
    Course_ID INT IDENTITY PRIMARY KEY,
    Course_Name VARCHAR(100) NOT NULL,
    Description VARCHAR(255),
    Resource VARCHAR(100)
);

INSERT INTO Courses VALUES
('Mathematics', 'Basic Mathematics Course', 'Book'),
('Computer Science', 'Introduction to CS', 'Laptop'),
('Physics', 'General Physics', 'Lab'),
('English', 'Academic English', 'Book'),
('Biology', 'Basic Biology', 'Slides');

select *from Courses

CREATE TABLE Classes (
    Class_ID INT IDENTITY PRIMARY KEY,
    Class_Code VARCHAR(20),
    Room_Number VARCHAR(20),
    Schedule VARCHAR(50),
    Course_ID INT,
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
);


INSERT INTO Classes VALUES
('MATH101', 'A1', 'Sun-Tue 10:00', 1),
('CS101', 'Lab2', 'Mon-Wed 12:00', 2),
('PHY101', 'B3', 'Sun-Thu 09:00', 3),
('ENG101', 'C1', 'Mon-Wed 08:00', 4),
('BIO101', 'D2', 'Tue-Thu 11:00', 5);

select *from Classes


CREATE TABLE Assignments (
    Assignment_ID INT IDENTITY PRIMARY KEY,
    Assignment_Name VARCHAR(100),
    Description VARCHAR(255),
    Due_Date DATE,
    Status VARCHAR(20), 
    Student_ID INT,
    Course_ID INT,
    FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
);


INSERT INTO Assignments VALUES
('Homework 1', 'Math exercises', '2024-10-01', 'Pass', 1, 1),
('Project 1', 'Simple program', '2024-10-10', 'Failed', 2, 2),
('Lab Report', 'Physics experiment', '2024-10-05', 'Pass', 3, 3),
('Essay', 'English writing', '2024-10-12', 'Pass', 4, 4),
('Quiz', 'Biology quiz', '2024-10-08', 'Failed', 5, 5);

select*from Assignments


SELECT s.First_Name, s.Last_Name, f.Father_Name, f.Phone_Number
FROM Students s
JOIN Family_Info f ON s.Student_ID = f.Student_ID;


SELECT Assignment_Name, Status
FROM Assignments
WHERE Status = 'Failed';

SELECT c.Course_Name, cl.Class_Code, cl.Room_Number
FROM Courses c
JOIN Classes cl ON c.Course_ID = cl.Course_ID;
