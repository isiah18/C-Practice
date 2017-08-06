USE SWCCorpGO-- Write a query to show every combination of employee and location.SELECT *FROM EmployeeCROSS JOIN Location-- Find a list of all the Employees who have never found a Grant.SELECT *FROM EmployeeLEFT JOIN [Grant]ON Employee.EmpID = [Grant].EmpIDWHERE [Grant].GrantID IS NULL-- Lab: Create a Customer TableCREATE TABLE Customer(	CustomerID int NOT NULL, 	CustomerType nvarchar(15) NOT NULL, 	FirstName nvarchar(20), 	LastName nvarchar(20),	CompanyName nvarchar(25))INSERT INTO Customer(CustomerID, CustomerType, FirstName, LastName, CompanyName)
VALUES (1, 'Consumer', 'Mark', 'Williams', NULL)
INSERT INTO Customer(CustomerID, CustomerType, FirstName, LastName, CompanyName)
VALUES (2, 'Consumer', 'Lee', 'Young', NULL)
INSERT INTO Customer(CustomerID, CustomerType, FirstName, LastName, CompanyName)
VALUES (3, 'Consumer', 'Patricia', 'Martin', NULL)
INSERT INTO Customer(CustomerID, CustomerType, FirstName, LastName, CompanyName)
VALUES (4, 'Consumer', 'Mary', 'Lopez', NULL)
INSERT INTO Customer(CustomerID, CustomerType, FirstName, LastName, CompanyName)
VALUES (5, 'Business', NULL, 'Williams', 'MoreTechnology.com')
-- Sally (employeeID 11) is getting married. Change her last name to Green.UPDATE Employee	SET LastName = 'Green'	WHERE Employee.EmpID = 11SELECT * FROM EmployeeWHERE Employee.EmpID = 11-- All the employees in the Spokane location are becoming contractors.
-- Update their status field to External.SELECT *FROM EmployeeINNER JOIN Location ON Employee.LocationID = Location.LocationIDWHERE Location.City = 'Spokane'UPDATE Employee	SET [Status] = 'External'	FROM Employee	INNER JOIN Location	ON Employee.LocationID = Location.LocationID	WHERE Location.City = 'Spokane'-- The location for Seattle has a typo. Update the street field to read 111 1st Ave.SELECT *FROM LocationUPDATE Location	SET Street = '111 1st Ave.'	WHERE City = 'Seattle'-- A new policy requires that grants for employees in Boston be made for $20,000. There are two
-- Boston records which aren’t set to $20,000. Please fix them!SELECT * FROM [GRANT]SELECT *FROM [Grant]INNER JOIN EmployeeON [Grant].EmpID = Employee.EmpIDINNER JOIN Location ON Employee.LocationID = Location.LocationIDWHERE Location.City = 'Boston'UPDATE [Grant]	SET Amount = 20000	FROM [Grant]	INNER JOIN Employee	ON [Grant].EmpID = Employee.EmpID	INNER JOIN Location	ON Employee.LocationID = Location.LocationID	WHERE Location.City = 'Boston'-- SWCCorp is not teaching long classes for management any more. Delete all records
-- where the duration is more than 20 hours.
SELECT *
FROM MgmtTraining

DELETE MgmtTraining
	WHERE ClassDurationHours > 20


-- Write a parameterized query to select the grant information from SWCCorp’s Grant
-- table to show grants between a minimum and maximum value.
SELECT * FROM [Grant]

DECLARE @MinValue int
DECLARE @MaxValue int
SET @MinValue = 14000
SET @MaxValue = 19000

SELECT * 
FROM [Grant]
WHERE Amount BETWEEN @MinValue AND @MaxValue


-- SWCCorp needs a stored procedure called GetProductListByCategory that should take in
-- the category name as a parameter.
SELECT * FROM CurrentProducts

CREATE PROCEDURE GetProductListByCategory
(
	@CategoryName nvarchar(20)
) AS

SELECT * 
FROM CurrentProducts
WHERE Category = @CategoryName

GO

DECLARE @CategoryName nvarchar(20)
SET @CategoryName = 'Medium-Stay'

EXEC GetProductListByCategory @CategoryName



-- SWCCorp needs a stored procedure called GetGrantsByEmployee that takes in the
-- LastName as a parameter and returns the EmployeeId, FirstName, LastName,
-- GrantName, and Amount for that employee’s grants.
SELECT LastName FROM Employee INNER JOIN [Grant] ON Employee.EmpID = [Grant].EmpID

CREATE PROCEDURE GetGrantsByEmployee
(
	@LastName nvarchar(20)
) AS

SELECT Employee.EmpID, FirstName, LastName, GrantName, Amount
FROM Employee
INNER JOIN [Grant]
ON Employee.EmpID = [Grant].EmpID
WHERE Employee.LastName = @LastName

GO

DECLARE @LastName nvarchar(20)
SET @LastName = 'Brown'

EXEC GetGrantsByEmployee @LastName
