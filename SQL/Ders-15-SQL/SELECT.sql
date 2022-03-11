USE DB_Test; --  Veritabanýný seçtik.

-- SELECT * FROM tb_ogrenci;  -- Tüm öðrencilerin tüm 
-- kolonlarýný getirir.

--SELECT ad,soyad FROM tb_ogrenci; -- Tüm öðrencilerin ad soyad 
---- kolonlarýný getir.

--SELECT ID,ad,soyad FROM DB_Test.dbo.tb_ogrenci;
--SELECT ID,ad,soyad FROM [DB_Test].[dbo].[tb_ogrenci];

SELECT ID,ad,soyad FROM tb_ogrenci WHERE ad = 'Ömer Ali';
-- ad ý Ömer Ali olanlarýn ID ad soyad bilgisini getir.

SELECT *  FROM tb_ogrenci WHERE ID>2;
-- ID si 2 den büyük olan kayýtlarý getir.

SELECT TOP 2 * FROM tb_ogrenci WITH(NOLOCK);
-- en üstteki 2 kaydý getir. NOLOCK ile veri tabanýnýn kilitlenmesini önleriz. 
-- Bizim sorgumuz sunucuyu uzunca meþgul etse de diðer kullanýcýlar sorgu yapabilir.

SELECT * FROM tb_ogrenci ORDER BY ID ASC;
-- ID ye göre artan sýra ile yaz.


SELECT * FROM tb_ogrenci ORDER BY ID DESC;
-- ID ye göre artan sýra ile yaz.

SELECT TOP 2 * FROM tb_ogrenci WITH(NOLOCK) ORDER BY ID DESC ;
-- ID ye göre azalan sýrala ve ilk 2 deðeri al.

SELECT * FROM tb_ogrenci WHERE ID BETWEEN 2 and 5;
-- ID si 2 ve 5 arasýnda olanlarý getir.

SELECT * FROM tb_ogrenci WHERE ID IN(3,4,5);
-- ID si 3,4 veya 5 olanlarý getir.

SELECT * FROM tb_ogrenci WHERE ID NOT IN(3,4,5);
-- ID si 3,4 veya 5 olmayanlarý getir.

SELECT * FROM tb_ogrenci WHERE ID=1 OR ID=4; 
-- ID si 1 veya 4 olanlarý getir.

SELECT * FROM tb_ogrenci WHERE ID=1 AND ad = 'Ömer'; 
-- ID si 1 ve adý Ömer olanlarý getir.

--SELECT * FROM tb_ogrenci WHERE CONTAINS(ad,'Ömer');
SELECT * FROM tb_ogrenci WHERE ad LIKE '%Ömer%';
--Ýçerisinde Ömer Olanlarý getir.

--WHERE CustomerName LIKE 'a%' 	Finds any values that start with "a"
--WHERE CustomerName LIKE '%a' 	Finds any values that end with "a"
--WHERE CustomerName LIKE '%or%' 	Finds any values that have "or" in any position
--WHERE CustomerName LIKE '_r%' 	Finds any values that have "r" in the second position
--WHERE CustomerName LIKE 'a_%' 	Finds any values that start with "a" and are at least 2 characters in length
--WHERE CustomerName LIKE 'a__%' 	Finds any values that start with "a" and are at least 3 characters in length
--WHERE ContactName LIKE 'a%o' 	Finds any values that start with "a" and ends with "o"
-