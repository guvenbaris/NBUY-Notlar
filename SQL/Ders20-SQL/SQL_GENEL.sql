
--UNION: Dikey birleþtirme. Ayný kolonlarý tekrar yazmaz.
SELECT 'Müþteri' AS Tip, City AS Sehir,Country, CONCAT('Þirket Adý: ',Customers.CompanyName) AS [Þirket/Yetkili Ad] FROM Customers 
WHERE Country='France'
UNION
SELECT 'Tedarikçi' AS Tip, City,Country,CONCAT('Yetkili Adý: ',Suppliers.ContactName) AS [Þirket/Yetkili Ad] FROM Suppliers 
WHERE Country='France';

SELECT 'Müþteri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION
SELECT 'Tedarikçi' AS Tip, City,Country FROM Suppliers WHERE Country='France';


--UNION ALL: Dikey birleþtirme. Ayný kolonlarý tekrar eder.
SELECT 'Müþteri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION ALL
SELECT 'Tedarikçi' AS Tip, City,Country FROM Suppliers WHERE Country='France';


-- Hangi ülkelerden müþterim var?
SELECT DISTINCT(Country) FROM Customers ORDER BY Country;

-- JSON FORMATINDA VERÝ ÇEKME
--SELECT * FROM Categories FOR JSON AUTO;
----[{"CategoryID":1,"CategoryName":"Beverages","Description":"Soft drinks, coffees, teas, beers, and ales"},
--{"CategoryID":2,"CategoryName":"Condiments","Description":"Sweet and savory sauces, relishes, spreads, and seasonings"},
--{"CategoryID":3,"CategoryName":"Confections","Description":"Desserts, candies, and sweet breads"},
--{"CategoryID":4,"CategoryName":"Dairy Products","Description":"Cheeses"},
--{"CategoryID":5,"CategoryName":"Grains\/Cereals","Description":"Breads, crackers, pasta, and cereal"},
--{"CategoryID":6,"CategoryName":"Meat\/Poultry","Description":"Prepared meats"},
--{"CategoryID":7,"CategoryName":"Produce","Description":"Dried fruit and bean curd"},
--{"CategoryID":8,"CategoryName":"Seafood","Description":"Seaweed and fish"}]

-- XML FORMATINDA VERÝ ÇEKME
SELECT * FROM Categories FOR XML AUTO;
SELECT * FROM Categories FOR XML PATH('XML');



--> ANLIK OLARAK OLUÞTURULUR VE SORGU BU Sanal Tablodan Çekilebilir.
WITH AzKalanUrunler AS(
  SELECT Products.ProductName,Products.UnitsInStock, Products.CategoryID
  FROM Products WHERE UnitsInStock<50)
SELECT ProductName,UnitsInStock FROM AzKalanUrunler WHERE CategoryID=2;

-- Orders tablosundaki Fransa sipariþlerinin içinde
-- 3 numaralý taþýma þirketi ile taþýnacak olan sipariþleri listeleyin.
-- WITH kullanarak.
WITH FransaSiparis AS
(SELECT * FROM Orders Where Orders.ShipCountry='France')
--SELECT * FROM FransaSiparis WHERE ShipVia=3
-- Arkaplanda çalýþýlan veriyi kilitlemez. Baþka çalýþmalarý engellemez.
SELECT * FROM Orders WITH (NOLOCK);

-- Hangi Sipariþin Toplam Kaç para olduðunu Siparis,Tutar isimli
-- geçici tabloda tutunuz.
-- Daha sonra bunlarý artan sýralama ile geçici tablodan çekiniz.
-- WITH ile...
WITH SiparisTutar AS
(
SELECT [Order Details].OrderID as [Sipariþ ID], SUM(UnitPrice*Quantity) as [Toplam Tutar] FROM [Order Details]
GROUP BY [Order Details].OrderID
)
SELECT * FROM SiparisTutar ORDER BY [Toplam Tutar] ASC FOR XML AUTO;
--SELECT * FROM [Order Details];

--TRANSACTION nedir ne iþe yarar, nasýl  kullanýlýr.