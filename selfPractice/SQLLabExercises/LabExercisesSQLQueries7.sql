USE Northwind
GO
--In Northwind, print a list of products, the value
--of the stock (unit price * quantity) and sort it by
--the value from highest to lowest.
SELECT (UnitPrice * UnitsInStock) AS Value
FROM Products
ORDER BY Value DESC

--2. In Northwind, get a list of employees with a
--column called NameLastFirst which is
--formatted as LastName, FirstName. Sort it
--alpha by last name, then first name.
SELECT (LastName + ', ' + FirstName) AS NameLastFirst
FROM Employees
ORDER BY NameLastFirst

--3. Take your query from #1 and create columns to
--value the stock in Canadian dollars, Japanese
--yen, euros, and pesos given today’s exchange
--rates.
SELECT (UnitPrice * UnitsInStock) AS Value, ((UnitPrice * UnitsInStock) * 0.91) AS EURO, ((UnitPrice * UnitsInStock) *1.37) AS Canada, 
((UnitPrice * UnitsInStock) * 112.37) AS Yen, ((UnitPrice * UnitsInStock) * 18.13) AS Peso
FROM Products
ORDER BY Value DESC
