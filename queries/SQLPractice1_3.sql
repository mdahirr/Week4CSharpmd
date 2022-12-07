SELECT productName,
	QuantityPerUnit,
	CompanyName,
	Country
FROM products, Suppliers
WHERE QuantityPerUnit like '%bottles'