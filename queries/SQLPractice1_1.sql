SELECT customerID,
	CompanyName,
	Address,
	city,
	PostalCode,
	Country
FROM Customers
WHERE city IN ('london', 'paris')

	