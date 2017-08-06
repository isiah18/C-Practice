USE Northwind
GO

-- Find the max unit price for each product by category.
SELECT MAX(UnitPrice) AS MaxUnitPrice
FROM Products
INNER JOIN Categories
ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName

-- Find customers with more than 10 orders.
SELECT Customers.CustomerID
FROM Customers
INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
GROUP BY Customers.CustomerID
HAVING Count(*) < 10

--Find employees that have more than 100
--orders. Only the name and count should be
--outputted 
SELECT Employees.FirstName, Count(*) AS OrderCount
FROM Employees
INNER JOIN Orders
ON Employees.EmployeeID = Orders.EmployeeID
GROUP BY Employees.FirstName
HAVING Count(*) > 100