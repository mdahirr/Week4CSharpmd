SELECT title + '. ' + FirstName + ' ' + LastName AS "Employee",
	city AS "City"
From Employees
WHERE city Like 'London'