USE Gringotts

--Problem01
SELECT COUNT(*) AS [Count]
  FROM WizzardDeposits

--Problem02
SELECT MAX(MagicWandSize) AS LongestMgicWand 
  FROM WizzardDeposits

--Problem03
  SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
    FROM WizzardDeposits
GROUP BY DepositGroup

--Problem04
SELECT TOP(2) DepositGroup
  FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

--Problem05
SELECT DepositGroup, SUM(DepositAmount) AS TotalDepositAmount
  FROM WizzardDeposits
GROUP BY DepositGroup

--Problem06
SELECT DepositGroup, SUM(DepositAmount)
  FROM WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--Problem07
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
  FROM WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC

--Problem08
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
  FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

--Problem09
SELECT AgeGroupTable.AgeGroup, COUNT(AgeGroupTable.AgeGroup)
  FROM (
SELECT Age, 
  CASE 
  WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
  WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
  WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
  WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
  WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
  WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
  ELSE '[61+]'
   END AS AgeGroup
  FROM WizzardDeposits
) AS AgeGroupTable
GROUP BY AgeGroupTable.AgeGroup

--Problem10
SELECT LEFT(FirstName, 1)
  FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)

--Problem11
SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest
  FROM WizzardDeposits
 WHERE DepositStartDate >= '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired

--Problem12
SELECT SUM(k.Diff) AS SumDifference
  FROM(
SELECT 
wd.DepositAmount - (SELECT w.DepositAmount FROM WizzardDeposits AS w WHERE w.Id = wd.Id + 1) 
    AS Diff
  FROM WizzardDeposits AS wd) AS k