USE AdventureWorks2019
GO

-- 1.
SELECT COUNT(*)
FROM Production.Product

-- 2.
SELECT COUNT(*)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

-- 3.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

-- 4.
SELECT COUNT(*)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

-- 5.
SELECT SUM(Quantity)
FROM PRoduction.ProductInventory

-- 6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

-- 7.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

-- 8.
SELECT AVG(Quantity)
FROM Production.ProductInventory
WHERE LocationID = 10

-- 9.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

-- 10.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf

-- 11.
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

-- 12.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c
    JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

-- 13.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c
    JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')

----------------------

USE Northwind
GO

-- 14.
SELECT DISTINCT p.ProductID, p.ProductName
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    JOIN Products p ON od.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())

-- 15.
SELECT TOP 5 ShipPostalCode, SUM(od.Quantity) AS TotalQuantity
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY ShipPostalCode
ORDER BY 2 DESC

-- 16.
SELECT TOP 5 ShipPostalCode, SUM(od.Quantity) AS TotalQuantity
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY ShipPostalCode
ORDER BY 2 DESC

-- 17.
SELECT City, COUNT(*) AS NumCustomer
FROM Customers c
GROUP BY City

-- 18.
SELECT City, COUNT(*) AS NumCustomer
FROM Customers c
GROUP BY City
HAVING COUNT(*) > 2

-- 19.
SELECT c.ContactName, o.OrderDate
FROM Orders o
    JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01';

-- 20.
SELECT c.CustomerID, c.ContactName, MAX(o.OrderDate) AS MostRecentOrder
FROM Orders o
    RIGHT OUTER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.CustomerID, c.ContactName

-- 21.
SELECT c.CustomerID, c.ContactName, ISNULL(SUM(od.Quantity), 0) AS TotalQuantity
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    RIGHT OUTER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.CustomerID, c.ContactName

-- 22.
SELECT c.CustomerID, c.ContactName, ISNULL(SUM(od.Quantity), 0) AS TotalQuantity
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    RIGHT OUTER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.CustomerID, c.ContactName
HAVING SUM(od.Quantity) > 100

-- 23.
SELECT s.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM Suppliers s CROSS JOIN Shippers sh

-- 24.
SELECT o.OrderDate, p.ProductName
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate;

-- 25.
SELECT e1.FirstName + ' ' + e1.LastName AS FirstEmployee, e1.Title, e2.FirstName + ' ' + e2.LastName AS SecondEmployee, e2.Title
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID <> e2.EmployeeID

-- 26.
SELECT FirstName + ' ' + LastName AS ManagerName
FROM Employees e
WHERE e.EmployeeID IN (SELECT ReportsTo
    FROM Employees e
    GROUP BY ReportsTo
    HAVING COUNT(*) > 2)

-- 27.
SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Customer' AS Type
FROM Customers

UNION ALL

SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Supplier' AS Type
FROM Suppliers