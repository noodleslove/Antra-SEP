--WHERE VS. HAVING
--1. Both will be used to filter the record. But having will only apply to group as a whole but Where is applied to individual rows.
--2. Where goes before aggregation, but having goes after aggregation
--SQL execution order

--SELECT fileds, aggregate(fields)
--FROM table JOIN table2 ON...
--WHERE criteri -- optional
--GROUP BY fields —= use when we have both aggregated and non aggregated fields
--HAVING criteria --optional
--ORDER BY by fields DESC - optional
--FROM/JOIN ---> WHERE ---> GROUP BY ---> HAVING --> SELECT---> DISTINCT---> ORDER BY


--DISTINCT:
--COUNT DISTINCT:

SELECT c. ContactName, COUNT(o.OrderId) AS NumofOrders
FROM Orders o JOIN Customers c ON o. CustomerId = c. CustomerId
GROUP BY c. ContactName
ORDER BY NumofOrders DESC

--subquery
SELECT c.ContactName, (SELECT Count (o.orderId)
    FROM orders o
    WHERE o. customeriD = c. CustomerId) AS TotalNum0f0rders
FROM Customers c
Order by TotalNum0f0rders DESC

--group by is a very very expensive resource

SELECT c.ContactName, C.City, c. Country, COUNT(o. OrderId) AS  NumofOrders
FROM Orders o LEFT JOIN Customers c ON o. CustomerId = c. CustomerId
GROUP BY c. ContactName, c.City, c. Country
ORDER BY NumofOrders DESC

--derived table
SELECT c.ContactName, c.City, c.Country, dt.TotalNumOfOrders
FROM Customers c LEFT JOIN (
SELECT CustomerId, Count(OrderId) As TotalNumOfOrders
    FROM Orders
    GROUP BY CustomerId
) dt ON c. CustomerId = dt. CustomerId

--differences
--1. Union will remove duplicate values but union all will not
--2. If you use union, the records from the first column will be sorted ascendingly automatically.
--3. Union can not be used in recursive cte but union all can.

--Window Function:
--RANK() :


--product with the 2nd highest price

--DENSE_RANK(): if you do not want the value gap, use DENSE_RANK()
SELECT ProductId, ProductName, UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC) RNK, DENSE_RANK() OVER(ORDER BY UnitPrice DESC) DENSE_RANK
FROM Products

--ROW_NUMBER(): it will return the ranking of the sorted record starting from 1
SELECT ProductId, ProductName, UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC) RNK, DENSE_RANK() OVER(ORDER BY UnitPrice DESC) DENSE_RANK,
ROW_NUMBER() OVER(ORDER BY UnitPrice DESC) RowNum
FROM Products

--partition by: divides the result set into partitions and perfrom calculations on each subset. it is always used in conjuction with the window functions
--list customers from every country with the ranking for number of orders



--- find top 3 customers from every country with maximum orders

--cte: common table expression: a temporary name result set to make our query more readable