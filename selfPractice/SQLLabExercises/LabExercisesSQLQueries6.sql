USE Northwind
GO

--Write a query showing the customer and
--order information for customer AROUT.
SELECT *
FROM Customers
INNER JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
WHERE Customers.CustomerID = 'AROUT'

--2. Write a query that combines Orders, Order
--Details, and Products. Show the OrderID,
--OrderDate, Order UnitPrice, Product Unit
--Price, Quantity, Discount, and
--ProductName.
SELECT Orders.OrderID, OrderDate, [Order Details].UnitPrice, Products.UnitPrice, [Order Details].Quantity, [Order Details].Discount, Products.ProductName
FROM Orders 
INNER JOIN [Order Details]
ON Orders.OrderID = [Order Details].OrderID
INNER JOIN Products
ON [Order Details].ProductID = Products.ProductID
