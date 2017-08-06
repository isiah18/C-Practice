USE SWCCorp
GO
--Show all the records from the Grant Table, sorted
--alphabetically by Grant Name.
SELECT * 
FROM [Grant]
ORDER BY GrantName

--2. Show all the employees in the Employee table from
--newest hire to oldest.
SELECT * 
FROM Employee
ORDER BY HireDate DESC

--3. Query the Current Products table for just the
--ProductName and Category fields, ordered from most
--expensive to least expensive retail price.
SELECT ProductName, Category
FROM CurrentProducts
ORDER BY RetailPrice DESC

--4. Sort the grant table from highest to lowest amount. If
--there is a tie, sort the ties alphabetically by grant name.
SELECT * 
FROM [Grant]
ORDER BY Amount DESC, GrantName

--5. Join the Employee and Location tables using an Outer
--Join that shows all employee records even if they have no
--location; show the FirstName, LastName, and City such
--that NULL cities show up first.
SELECT FirstName, LastName, City
FROM Employee
FULL OUTER JOIN Location 
ON Employee.LocationID = Location.LocationID 
ORDER BY City 
