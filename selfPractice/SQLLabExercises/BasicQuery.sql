USE Northwind
GO

-- Two dashes is single line comment

/*Paragraph comment
this is stilla  comment 
and still...
*/

SELECT *
FROM [Customers]

SELECT *
FROM Customers
WHERE Country = 'USA'

SELECT *
FROM Customers
WHERE Country != 'USA'

SELECT * 
FROM Customers
WHERE Country = 'USA' AND Region = 'OR'


-- Similar to Customers where country equal to USA AND country equal to UK
SELECT * 
FROM Customers
WHERE Country IN ('USA', 'UK')

SELECT * 
FROM Customers
WHERE Country NOT IN ('USA', 'UK')


SELECT * 
FROM Products
WHERE UnitPrice > 20.00

SELECT * 
FROM Products
WHERE UnitPrice <= 20.00

-- Between is inclusive
SELECT *
FROM Products
Where UnitPrice BETWEEN 10.00 AND 13.00

SELECT Products.CategoryID
FROM Products


-- Pattern Matching
SELECT *
FROM Customers
WHERE CompanyName LIKE 'A%'

SELECT *
FROM Customers
WHERE CompanyName LIKE '%Z%'

-- _ represents 1 character. So there should be one character before A. A should be second character
SELECT *
FROM Customers
WHERE CompanyName LIKE  '_A%'

--Want thrid character to be an O
SELECT *
FROM Customers
WHERE CompanyName LIKE  '__O%'

-- [] represents that the first character can be an A OR B.
SELECT *
FROM Customers
WHERE CompanyName LIKE  '[AB]%'

SELECT *
FROM Customers
WHERE CompanyName LIKE  '[A-K]%'

-- Second character can not be an N. ^ = not
SELECT *
FROM Customers
WHERE CompanyName LIKE  'A[^N]%'

SELECT *
FROM Customers
WHERE CompanyName LIKE  'A[^N-Z]%'


SELECT *
FROM Customers
WHERE Region IS Null