USE SWCCorp
GO
--SWCCorp needs a stored procedure called
--GetProductListByCategory that should take in
--the category name as a parameter.


CREATE PROCEDURE GetProductListByCategory
(
	@CategoryName nvarchar(20)
) AS

SELECT * 
FROM CurrentProducts
WHERE Category = @CategoryName

GO


--2. SWCCorp needs a stored procedure called
--GetGrantsByEmployee that takes in the
--LastName as a parameter and returns the
--EmployeeId, FirstName, LastName,
--GrantName, and Amount for that employee’s
--grants.
USE SWCCorp
GO

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




