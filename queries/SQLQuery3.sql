SELECT COUNT(CategoryName) AS "Category Name"
FROM products, Categories
GROUP BY 
ORDER BY COUNT()DESC
