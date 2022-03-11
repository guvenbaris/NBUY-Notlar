USE Northwind;
SELECT COUNT(*) FROM Customers; -- Ka� m��teri var?
SELECT SUM(Products.UnitsInStock*Products.UnitPrice) as ToplamTutar FROM Products;
-- Stoktaki �r�nlerin toplam tutar�

SELECT AVG(Products.UnitPrice) FROM Products; -- Ortalama Birim Fiyat�
SELECT MIN(Products.UnitPrice) FROM Products; -- En d���k Birim Fiyat�
SELECT MAX(Products.UnitPrice) FROM Products; -- En y�ksek Birim Fiyat�


-- GROUP BY --

SELECT Customers.CompanyName,Customers.Country FROM Customers 
ORDER BY Customers.Country; -- Ayr� ayr� listeledik.
-- Hangi �lkeden ka� m��terim var?
SELECT COUNT(*) as M��teriSayisi,Customers.Country FROM Customers GROUP BY Country;

-- 5 ten fazla m��terinin oldu�u �lkeler hangileri?
SELECT COUNT(*) as M��teriSayisi ,Customers.Country as �lke FROM Customers 
GROUP BY Customers.Country HAVING COUNT(CustomerID)>5;

-- Products : Hangi kategoriden ka� �r�n var?

SELECT COUNT(Products.ProductID),CategoryID FROM Products
GROUP BY Products.CategoryID;

SELECT COUNT(Products.ProductID),Categories.CategoryName FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName;


-- Her kategorideki �r�nlerin toplam mal de�eri nedir?
SELECT * FROM Products;
SELECT SUM(Products.UnitsInStock*Products.UnitPrice) as Toplam�r�nDe�eri,Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID=Categories.CategoryID
GROUP BY Categories.CategoryName;


-- Her bir �r�nden ka� adet sipari� verilmi�?
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;
-- Yukar�daki soruya ek olarak 1998 5. ay ve sonras�n�n sipari�lerini filtrelesin.

SELECT SUM([Order Details].Quantity),[Order Details].ProductID,Orders.OrderDate FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;



SELECT COUNT(*) FROM Products WHERE CategoryID IS NULL; -- CategoryID si NULL
-- olanlar� getir.



