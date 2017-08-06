--Write a parameterized query to select the
--grant information from SWCCorp’s Grant
--table to show grants between a minimum
--and maximum value.

DECLARE @MinValue int
DECLARE @MaxValue int

SET @MinValue = 10000
SET @MaxValue = 20000

SELECT *
FROM [Grant]
WHERE Amount BETWEEN @MinValue AND @MaxValue
