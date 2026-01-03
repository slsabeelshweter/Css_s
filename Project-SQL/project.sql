create database CourseRegistration


CREATE TABLE Departments (
    Department_ID INT IDENTITY PRIMARY KEY,
    Department_Name VARCHAR(50) NOT NULL
);
INSERT INTO Departments (Department_Name) VALUES
('Computer Science'),('Information Systems'),('Engineering'),('Business'),('Mathematics');

select * from Departments

CREATE TABLE Instructors (
    Instructor_ID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Department_ID INT,
    Email VARCHAR(50),
    FOREIGN KEY (Department_ID) REFERENCES Departments(Department_ID)
);

INSERT INTO Instructors (Name, Department_ID, Email) VALUES
('Dr. mahmoud', 1, 'mahmoud@yu.edu'),
('Dr. manal', 2, 'manal@yu.edu'),
('Dr. Omar', 3, 'omar@yu.edu'),
('Dr. Sara', 4, 'sara@yu.edu'),
('Dr. hesham', 1, 'hesham@yu.edu');

select * from Instructors


CREATE TABLE Courses (
    Course_ID INT IDENTITY PRIMARY KEY,
    Course_Name VARCHAR(50) NOT NULL,
    Instructor_ID INT,
    Credits INT,
    Department_ID INT,
    FOREIGN KEY (Instructor_ID) REFERENCES Instructors(Instructor_ID),
    FOREIGN KEY (Department_ID) REFERENCES Departments(Department_ID)
);

INSERT INTO Courses (Course_Name, Instructor_ID, Credits, Department_ID) VALUES
('Database Systems', 1, 3, 1),
('Web Development', 5, 3, 1),
('Networks', 3, 3, 3),
('Business Management', 4, 3, 4),
('Calculus', 2, 3, 5);

select * from Courses


CREATE TABLE Students (
    Student_ID INT IDENTITY PRIMARY KEY,
    First_Name VARCHAR(50),
    Last_Name VARCHAR(50),
    Email VARCHAR(500),
    Phone_Number VARCHAR(20),
    Enrollment_Date DATE
);

INSERT INTO Students (First_Name, Last_Name, Email, Phone_Number, Enrollment_Date) VALUES
('Ali', 'omari', 'aliomari@email.com', '0795462001', '2023-05-02'),
('farah', 'bataineh', 'farah_ba@email.com', '0790632002', '2023-12-07'),
('amani', 'taweel', 'amanita@email.com', '0790687003', '2023-09-27'),
('reda', 'abualhaijaa', 'reda@email.com', '0790062154', '2023-06-25'),
('Khaled', 'Nasser', 'khaled@email.com', '0796541205', '2023-09-01');

select * from Students

CREATE TABLE Enrollments (
    Enrollment_ID INT IDENTITY PRIMARY KEY,
    Student_ID INT,
    Course_ID INT,
    Enrollment_Date DATE,
    Status VARCHAR(20),
    FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
);

INSERT INTO Enrollments (Student_ID, Course_ID, Enrollment_Date, Status) VALUES
(1, 1, '2023-09-10', 'Enrolled'),
(2, 1, '2023-09-10', 'Completed'),
(3, 2, '2023-09-12', 'Enrolled'),
(4, 3, '2023-09-15', 'Withdrawn'),
(5, 5, '2023-09-15', 'Completed');

select * from Enrollments

CREATE TABLE Course_Requirements (
    Course_ID INT,
    Prerequisite_Course_ID INT,
    PRIMARY KEY (Course_ID, Prerequisite_Course_ID),
    FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID),
    FOREIGN KEY (Prerequisite_Course_ID) REFERENCES Courses(Course_ID)
);


INSERT INTO Course_Requirements (Course_ID, Prerequisite_Course_ID) VALUES
(2, 1),
(3, 1);

select * from Course_Requirements

SELECT s.First_Name, s.Last_Name
FROM Students s
JOIN Enrollments e ON s.Student_ID = e.Student_ID
WHERE e.Course_ID = 1;

SELECT Course_Name
FROM Courses
WHERE Department_ID = 1;

SELECT s.First_Name, s.Last_Name
FROM Students s
JOIN Enrollments e ON s.Student_ID = e.Student_ID
WHERE e.Course_ID = 1 AND e.Status = 'Completed';
