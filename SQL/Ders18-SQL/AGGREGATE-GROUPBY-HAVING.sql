USE Northwind;
SELECT COUNT(*) FROM Customers; -- Kaç müþteri var?
SELECT SUM(Products.UnitsInStock*Products.UnitPrice) as ToplamTutar FROM Products;
-- Stoktaki ürünlerin toplam tutarý

SELECT AVG(Products.UnitPrice) FROM Products; -- Ortalama Birim Fiyatý
SELECT MIN(Products.UnitPrice) FROM Products; -- En düþük Birim Fiyatý
SELECT MAX(Products.UnitPrice) FROM Products; -- En yüksek Birim Fiyatý


-- GROUP BY --

SELECT Customers.CompanyName,Customers.Country FROM Customers 
ORDER BY Customers.Country; -- Ayrý ayrý listeledik.
-- Hangi ülkeden kaç müþterim var?
SELECT COUNT(*) as MüþteriSayisi,Customers.Country FROM Customers GROUP BY Country;

-- 5 ten fazla müþterinin olduðu ülkeler hangileri?
SELECT COUNT(*) as MüþteriSayisi ,Customers.Country as Ülke FROM Customers 
GROUP BY Customers.Country HAVING COUNT(CustomerID)>5;

-- Products : Hangi kategoriden kaç ürün var?

SELECT COUNT(Products.ProductID),CategoryID FROM Products
GROUP BY Products.CategoryID;

SELECT COUNT(Products.ProductID),Categories.CategoryName FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName;


-- Her kategorideki ürünlerin toplam mal deðeri nedir?
SELECT * FROM Products;
SELECT SUM(Products.UnitsInStock*Products.UnitPrice) as ToplamÜrünDeðeri,Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID=Categories.CategoryID
GROUP BY Categories.CategoryName;


-- Her bir üründen kaç adet sipariþ verilmiþ?
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;
-- Yukarýdaki soruya ek olarak 1998 5. ay ve sonrasýnýn sipariþlerini filtrelesin.

SELECT SUM([Order Details].Quantity),[Order Details].ProductID,Orders.OrderDate FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;



SELECT COUNT(*) FROM Products WHERE CategoryID IS NULL; -- CategoryID si NULL
-- olanlarý getir.



