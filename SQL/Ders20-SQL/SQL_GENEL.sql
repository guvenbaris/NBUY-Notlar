
--UNION: Dikey birle�tirme. Ayn� kolonlar� tekrar yazmaz.
SELECT 'M��teri' AS Tip, City AS Sehir,Country, CONCAT('�irket Ad�: ',Customers.CompanyName) AS [�irket/Yetkili Ad] FROM Customers 
WHERE Country='France'
UNION
SELECT 'Tedarik�i' AS Tip, City,Country,CONCAT('Yetkili Ad�: ',Suppliers.ContactName) AS [�irket/Yetkili Ad] FROM Suppliers 
WHERE Country='France';

SELECT 'M��teri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION
SELECT 'Tedarik�i' AS Tip, City,Country FROM Suppliers WHERE Country='France';


--UNION ALL: Dikey birle�tirme. Ayn� kolonlar� tekrar eder.
SELECT 'M��teri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION ALL
SELECT 'Tedarik�i' AS Tip, City,Country FROM Suppliers WHERE Country='France';


-- Hangi �lkelerden m��terim var?
SELECT DISTINCT(Country) FROM Customers ORDER BY Country;

-- JSON FORMATINDA VER� �EKME
--SELECT * FROM Categories FOR JSON AUTO;
----[{"CategoryID":1,"CategoryName":"Beverages","Description":"Soft drinks, coffees, teas, beers, and ales"},
--{"CategoryID":2,"CategoryName":"Condiments","Description":"Sweet and savory sauces, relishes, spreads, and seasonings"},
--{"CategoryID":3,"CategoryName":"Confections","Description":"Desserts, candies, and sweet breads"},
--{"CategoryID":4,"CategoryName":"Dairy Products","Description":"Cheeses"},
--{"CategoryID":5,"CategoryName":"Grains\/Cereals","Description":"Breads, crackers, pasta, and cereal"},
--{"CategoryID":6,"CategoryName":"Meat\/Poultry","Description":"Prepared meats"},
--{"CategoryID":7,"CategoryName":"Produce","Description":"Dried fruit and bean curd"},
--{"CategoryID":8,"CategoryName":"Seafood","Description":"Seaweed and fish"}]

-- XML FORMATINDA VER� �EKME
SELECT * FROM Categories FOR XML AUTO;
SELECT * FROM Categories FOR XML PATH('XML');



--> ANLIK OLARAK OLU�TURULUR VE SORGU BU Sanal Tablodan �ekilebilir.
WITH AzKalanUrunler AS(
  SELECT Products.ProductName,Products.UnitsInStock, Products.CategoryID
  FROM Products WHERE UnitsInStock<50)
SELECT ProductName,UnitsInStock FROM AzKalanUrunler WHERE CategoryID=2;

-- Orders tablosundaki Fransa sipari�lerinin i�inde
-- 3 numaral� ta��ma �irketi ile ta��nacak olan sipari�leri listeleyin.
-- WITH kullanarak.
WITH FransaSiparis AS
(SELECT * FROM Orders Where Orders.ShipCountry='France')
--SELECT * FROM FransaSiparis WHERE ShipVia=3
-- Arkaplanda �al���lan veriyi kilitlemez. Ba�ka �al��malar� engellemez.
SELECT * FROM Orders WITH (NOLOCK);

-- Hangi Sipari�in Toplam Ka� para oldu�unu Siparis,Tutar isimli
-- ge�ici tabloda tutunuz.
-- Daha sonra bunlar� artan s�ralama ile ge�ici tablodan �ekiniz.
-- WITH ile...
WITH SiparisTutar AS
(
SELECT [Order Details].OrderID as [Sipari� ID], SUM(UnitPrice*Quantity) as [Toplam Tutar] FROM [Order Details]
GROUP BY [Order Details].OrderID
)
SELECT * FROM SiparisTutar ORDER BY [Toplam Tutar] ASC FOR XML AUTO;
--SELECT * FROM [Order Details];

--TRANSACTION nedir ne i�e yarar, nas�l  kullan�l�r.