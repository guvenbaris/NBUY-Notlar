
--USE Northwind; -- Sorgu gönderilen veritabanýný Northwind yap.

-- Northwind veritabanýndan Ürünler ve Ürün kategorilerini getiren INNER JOIN li sorguyu yazýnýz.
-- Daha sonra ProductWithCategory isminde bir VIEW ile 
-- Products tablosundan ProductID,ProductName,SupplierID,UnitPrice,UnitsInStock ve 
-- Categories tablosundan CategoryName,Description kolonlarýný listeleyiniz.

--CREATE VIEW ProductWithCategory AS
--	SELECT Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,
--	Products.UnitsInStock,Categories.CategoryName,Categories.Description
--	FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID;

-- SELECT * FROM ProductWithCategory;

-- Yukarýdaki sorguya ek olarak Suppliers tablosundan CompanyName(Supplier) ve Phone(Supplier Phone) 
-- bilgisini getiecek þekilde
-- P_CategorySupplier isminde bir VIEW tanýmlayýnýz.

--CREATE VIEW P_CategorySupplier AS
--	SELECT Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,
--	Products.UnitsInStock,Categories.CategoryName,Categories.Description,
--	Suppliers.CompanyName as 'Supplier', Suppliers.Phone as 'Supplier Phone'
--	FROM Products 
--	INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
--	INNER JOIN Suppliers  ON Products.SupplierID = Suppliers.SupplierID;

--SELECT * FROM P_CategorySupplier;

SELECT * FROM Orders;

-- Orders tablosunda OrderDate'i  1998 olanlarý döndüren VIEW yazýnýz.


 CREATE VIEW Orders1998 AS
 SELECT 
 Orders.OrderID,Orders.CustomerID,Orders.OrderDate ,
 CONCAT (Employees.FirstName,' ',Employees.LastName) AS Employee
 FROM Orders 
 INNER JOIN Employees
 ON Orders.EmployeeID=Employees.EmployeeID
 WHERE Orders.OrderDate LIKE('%1998%');

SELECT * FROM Orders1998;



--Orders tablosunda USA'a gönderilen sipariþler için: OrderID,CustomerID ve Employee Name ve Surname
-- Yukarýdaki verileri VIEW olusturarak gösteriniz.

 CREATE VIEW OrdersUSA AS
 SELECT 
 Orders.OrderID,Orders.CustomerID,Orders.OrderDate ,Orders.ShipCountry,
 CONCAT (Employees.FirstName,' ',Employees.LastName) AS Employee
 FROM Orders 
 INNER JOIN Employees
 ON Orders.EmployeeID=Employees.EmployeeID
 WHERE Orders.ShipCountry='USA';

 SELECT * FROM OrdersUSA;



 SELECT * FROM Orders;
 SELECT * FROM [Order Details] WHERE OrderID=10248;
 SELECT (UnitPrice*Quantity) as TotalPrice FROM [Order Details] WHERE OrderID=10248;

 -- Almanya'ya yapýlan satýþlardan 200 dolardan fazla olanlarýn TotalPrice,CustomerID,ShipCity
 -- Bilgilerini yazdýran VIEW tanýmlayýnýz.
 SELECT * FROM [Orders];
 SELECT * FROM [Order Details];

CREATE VIEW OrdersGermany200 AS
 SELECT  ([Order Details].UnitPrice*[Order Details].Quantity) as TotalPrice, Orders.CustomerID,Orders.ShipCity
 FROM Orders INNER JOIN [Order Details] ON Orders.OrderID= [Order Details].OrderID
 WHERE ([Order Details].UnitPrice*[Order Details].Quantity)>200 AND Orders.ShipCountry='Germany';


 SELECT * FROM OrdersGermany200;