USE Northwind
GO

-- TEMP TABLE
-- create local temp table
CREATE TABLE #LocalTemp
(
    Num INT
)
DECLARE @Var INT = 1
WHILE(@Var <= 10)
BEGIN
    INSERT INTO #LocalTemp
        (Num)
    VALUES(@Var)
    SET @Var = @Var + 1
END

-- select temp table
SELECT *
FROM #LocalTemp

-- see all temp tables
SELECT *
FROM tempdb.sys.tables


-- create global table
CREATE TABLE ##GlobalTemp
(
    Num int
)
DECLARE @Var2 int = 1
WHILE(@Var2 <= 10)
BEGIN
    INSERT INTO ##GlobalTemp
        (Num)
    VALUES(@Var2)
    SET @Var2 = @Var2 + 1
END

-- select temp table
SELECT *
FROM ##GlobalTemp

-- see all temp tables
SELECT *
FROM tempdb.sys.tables

-- TABLE VARIABLE
-- create table variable
DECLARE @WeekDays TABLE(
    DayNum INT,
    DayAbb VARCHAR(20),
    WeekName VARCHAR(20)
)
INSERT INTO @WeekDays
VALUES
    (1, 'Mon', 'Monday'),
    (2, 'Tue', 'Tuesday')

-- select variable
SELECT *
FROM @WeekDays
GO

-- VIEW
-- create view
CREATE OR ALTER VIEW "Top 10 Most Order Customers"
AS
    SELECT TOP 10
        c.CustomerID,
        MAX(c.ContactName) AS ContactName,
        MAX(c.City) AS City,
        SUM(od.Quantity) AS TotalQuantity
    FROM Orders o
        JOIN [Order Details] od ON o.OrderID = od.OrderID
        JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY c.CustomerID
    ORDER BY 4 DESC
GO

-- select view
SELECT *
FROM "Top 10 Most Order Customers"
GO


-- PROCEDURE
-- example
CREATE PROC SpHello
AS
BEGIN
PRINT 'Hello, World!'
END

-- run
EXEC SpHello
GO

-- input proc
CREATE PROC SpAddNumbers
@a INT,
@b INT
AS
PRINT @a + @b

-- run
EXEC SpAddNumbers 10, 20
GO

-- output proc
CREATE OR ALTER PROC SpGetName
@Id INT,
@EName VARCHAR(20) OUT 
AS
BEGIN
SELECT @EName = FirstName + ' ' + LastName 
FROM Employees
WHERE EmployeeID = @id
END

-- run
BEGIN
DECLARE @En VARCHAR(20)
EXEC SpGetName 2, @En OUT
PRINT @En
END
GO


-- FUNCTION
-- create function
CREATE FUNCTION GetTotalRevenue(
    @Price MONEY,
    @Discount REAL,
    @Quantity INT
) RETURNS MONEY
AS
BEGIN
DECLARE @Revenue MONEY
SET @Revenue = @Price * (1 - @Discount) * @Quantity
RETURN @Revenue
END
GO

-- run
SELECT
    UnitPrice,
    Quantity,
    Discount,
    dbo.GetTotalRevenue(UnitPrice, Discount, Quantity) AS Revenue 
FROM [Order Details]


-- PAGINATION
-- offset
SELECT CustomerId, ContactName, City
FROM Customers 
ORDER BY CustomerId
OFFSET 90 ROWS

-- offset & fetch next
SELECT CustomerId, ContactName, City
FROM Customers 
ORDER BY CustomerId
OFFSET 10 ROWS
FETCH NEXT 10 ROWS ONLY

-- offset/fetch next must be used with order by


-- DDL
-- create
CREATE TABLE Employee(
    Id INT PRIMARY KEY ,
    EName VARCHAR(20) NOT NULL,
    Age INT
)

-- insert, pk is sorted automatically
INSERT INTO EMPLOYEE VALUES (4, 'Fred', 25)
INSERT INTO EMPLOYEE VALUES (3, 'Peter', 19)
INSERT INTO EMPLOYEE VALUES (5, 'Fiona', 55)
INSERT INTO EMPLOYEE VALUES (1, 'Sam', 45)

-- select
SELECT *
FROM Employee

INSERT INTO Employee
VALUES(6, 'Monster', 6000)
INSERT INTO Employee
VALUES(7, 'Monster', -6000)

DELETE Employee

-- CONSTRAINT
-- add to existing table
ALTER TABLE Employee
ADD CONSTRAINT Chk_Age_Employee CHECK (Age BETWEEN 18 AND 60)
-- or add to new table
-- CREATE TABLE Employee(
--     Id INT PRIMARY KEY ,
--     EName VARCHAR(20) NOT NULL,
--     Age INT,
--     CONSTRAINT Chk_Age_Employee CHECK (Age BETWEEN 18 AND 60)
-- )

-- check constraint
INSERT INTO Employee VALUES (1, 'Fred', 30)
GO

DROP TABLE Employee

-- foreign key
-- set to null if fk is removed
CREATE TABLE Employee
(
    Id INT PRIMARY KEY,
    EmployeeName varchar(20),
    Age int CHECK(Age BETWEEN 18 and 65),
    DepartmentId INT FOREIGN KEY REFERENCES Department(id) ON DELETE SET NULL
)

DROP TABLE Employee

-- delete record if fk is removed
CREATE TABLE Employee
(
    Id INT PRIMARY KEY,
    EmployeeName varchar(20),
    Age INT CHECK(Age BETWEEN 18 and 65),
    DepartmentId INT FOREIGN KEY REFERENCES Department(id) ON DELETE CASCADE
)


-- composite primary key
CREATE TABLE Student
(
    Id INT PRIMARY KEY,
    StudentName VARCHAR(20)
)

CREATE TABLE Class
(
    ID INT PRIMARY KEY,
    ClassName VARCHAR(20)
)

CREATE TABLE Enrollment
(
    StudentId INT NOT NULL,
    ClassId INT NOT NULL,
    CONSTRAINT PK_Enrollment PRIMARY KEY(StudentId, ClassId),
    CONSTRAINT FK_Enrollement_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
    CONSTRAINT FK_Enrollement_Class FOREIGN KEY(ClassId) REFERENCES Class(Id)
)


-- INDEX
CREATE TABLE Customer
(
    Id INT,
    FullName VARCHAR(20),
    City VARCHAR(20),
    Country VARCHAR(20)
)

SELECT *
FROM Customer

CREATE CLUSTERED INDEX Cluster_IX_Customer_ID ON Customer(Id)

INSERT INTO Customer
VALUES(3, 'David', 'Chicago', 'USA')
INSERT INTO Customer
VALUES(1, 'Fred', 'Sterling', 'USA')

CREATE INDEX Noncluster_IX_Customer_City ON Customer(City)


-- clear tables
DROP TABLE IF EXISTS Employee
DROP TABLE IF EXISTS Enrollment
DROP TABLE IF EXISTS Student
DROP TABLE IF EXISTS Class
DROP TABLE IF EXISTS Customer

DROP VIEW IF EXISTS "Top 10 Most Order Customers"

