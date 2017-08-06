USE Northwind
GO

-- Select all of the fields and rows.
SELECT *
FROM Products

--Find all the product information for the product with the name Queso Cabrales
SELECT *
FROM Products
WHERE ProductName = 'Queso Cabrales'

-- Using one query, display the name and number of units in stock for the products
-- Laughing Lumberjack Lager, Outback Lager,and Ravioli Angelo.
SELECT ProductName, UnitsInStock
FROM Products
WHERE ProductName IN ('Laughing Lumberjack Lager', 'Outback Lager', 'Ravioli Angelo')



-- Select all the order information for the customer QUEDE. 
SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'

-- Select the orders whose freight is more than $100.00.SELECT *FROM OrdersWHERE Freight > 100.00-- Select the orders shipping to the USA whose freight is between $10 and $20.SELECT *FROM OrdersWHERE ShipCountry = 'USA' AND Freight BETWEEN 10 AND 20-- Get a list of each employee and their territories.SELECT FirstName, LastName, TerritoryDescriptionFROM EmployeesINNER JOIN EmployeeTerritoriesON Employees.EmployeeID = EmployeeTerritories.EmployeeIDINNER JOIN TerritoriesON EmployeeTerritories.TerritoryID = Territories.TerritoryID-- Get the Customer Name, Order Date, and each order detail’s Product name for USA customers onlySELECT CompanyName, OrderDate, ProductNameFROM CustomersINNER JOIN OrdersON Customers.CustomerID = Orders.CustomerIDINNER JOIN [Order Details]ON Orders.OrderID = [Order Details].OrderIDINNER JOIN ProductsON [Order Details].ProductID = Products.ProductIDWhere Orders.ShipCountry = 'USA'