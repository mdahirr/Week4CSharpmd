SELECT COUNT(orderID) AS "No of Orders > 100 from US or UK"
FROM Orders
WHERE Freight > 100.00 and ShipCountry = 'USA' OR ShipCountry = 'UK'