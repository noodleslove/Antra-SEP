USE Northwind
GO

-- 1.
SELECT DISTINCT City
FROM dbo.Employees
WHERE City IN (SELECT City FROM dbo.Employees)
    AND City IN (SELECT City FROM dbo.Customers)

-- 2.
-- a)
SELECT DISTINCT City
FROM dbo.Customers
WHERE City NOT IN (
    SELECT DISTINCT City
    FROM dbo.Employees
)

-- b)
SELECT DISTINCT City
FROM dbo.Customers

EXCEPT

SELECT DISTINCT City
FROM dbo.Employees

-- 3.
SELECT p.ProductID, SUM(od.Quantity) AS TotalQuantity
FROM dbo.Orders o
    JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
    JOIN dbo.Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductID

-- 4.
SELECT c.City, SUM(od.Quantity) AS TotalQuantity
FROM Orders o
    JOIN Customers c ON o.CustomerID = c.CustomerID
    JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
WHERE c.City IN (SELECT City FROM Customers)
GROUP BY c.City

-- 5.
-- a)
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

-- b)
SELECT DISTINCT City
FROM Customers
WHERE City IN (
    SELECT City
    FROM Customers
    GROUP BY City
    HAVING COUNT(CustomerID) >= 2
)

-- 6.
SELECT o.CustomerID, COUNT(*) AS NumOfUniqueProduct
FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.CustomerID, od.ProductID
HAVING COUNT(*) >= 2

-- 7.
SELECT DISTINCT c.CustomerID
FROM Orders o
    JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.ShipCity <> c.City

-- 8.
-- top 5 most popular products
-- SELECT TOP 5 ProductID
-- FROM Orders o
--     JOIN [Order Details] od ON o.OrderID = od.OrderID
-- GROUP BY ProductID
-- ORDER BY SUM(Quantity) DESC

-- their average price
-- SELECT SUM(UnitPrice * Quantity * (1 - Discount)) / SUM(Quantity)
-- FROM Orders o
--     JOIN [Order Details] od ON o.OrderID = od.OrderID
-- WHERE od.ProductID = 59

-- customer city that ordered most quantity of it
-- SELECT TOP 1 City
-- FROM Orders o
--     JOIN [Order Details] od ON o.OrderID = od.OrderID
--     JOIN Customers c ON o.CustomerID = c.CustomerID
-- WHERE od.ProductID = ProductID
-- GROUP BY City
-- ORDER BY SUM(Quantity) DESC

SELECT
    p.ProductID,
    (
        SELECT SUM(UnitPrice * Quantity * (1 - Discount)) / SUM(Quantity)
        FROM Orders o
            JOIN [Order Details] od ON o.OrderID = od.OrderID
        WHERE od.ProductID = p.ProductID
    ) AS AvgPrice,
    (
        SELECT TOP 1 City
        FROM Orders o
            JOIN [Order Details] od ON o.OrderID = od.OrderID
            JOIN Customers c ON o.CustomerID = c.CustomerID
        WHERE od.ProductID = p.ProductID
        GROUP BY City
        ORDER BY SUM(Quantity) DESC
    ) AS TopOrderedCity
FROM Products p
WHERE p.ProductID IN (
    SELECT TOP 5 ProductID
    FROM Orders o
        JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY ProductID
    ORDER BY SUM(Quantity) DESC
)

-- 9.
-- a)
SELECT City
FROM Employees
WHERE City NOT IN (
    SELECT ShipCity
    FROM Orders
)

-- b)
SELECT City
FROM Employees

EXCEPT

SELECT ShipCity
FROM Orders

-- 10.
WITH MostQuantityCity AS (
    SELECT TOP 1 c.City
    FROM Orders o
        JOIN [Order Details] od ON o.OrderID = od.OrderID
        JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY c.City
    ORDER BY SUM(od.Quantity) DESC
),
MostOrdersCity AS (
    SELECT TOP 1 e.City
    FROM Orders o
        JOIN Employees e ON o.EmployeeID = e.EmployeeID
    GROUP BY e.City
    ORDER BY COUNT(o.OrderID) DESC
)
SELECT mq.City
FROM MostQuantityCity mq
JOIN MostOrdersCity mo ON mq.City = mo.City;

-- 11.
-- use DISTINCT or GROUP BY keyword to remove duplicate records from a table