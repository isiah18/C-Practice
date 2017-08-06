USE SWCCorp
GO

--Find the oldest two employees in the
--employee table.
SELECT TOP(2) *
FROM Employee
ORDER BY HireDate


--Find the 6 largest grants in the grant table,
--including ties.
SELECT TOP(6) WITH TIES *
FROM [Grant]
ORDER BY Amount DESC


--Display the 10 most expensive single-day
--trips found in the CurrentProducts table
--(Category = Overnight-Stay)

SELECT TOP(10) * 
FROM CurrentProducts
WHERE Category = 'Overnight-Stay'
ORDER BY RetailPrice DESC