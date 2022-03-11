USE Northwind;
GO -- Programlamadaki bloklar gibi.
DECLARE @sayi int; -- deðiþken tanýmladýk.  Sadece buradaki GO bloklarý içinde geçerli.
SET @sayi= 15; -- deðiþkene deðer atadýk.
-- PRINT @sayi; --  Normal yazý olarak ekrana yazdýrdýk.
-- SELECT @sayi; -- Tablo olarak ekrana yazdýrdýk.
GO

GO
DECLARE @kategoriSayisi int;
--SELECT @kategoriSayisi =  COUNT(*) FROM Categories;  -- Count(*) satýr sayýsýný getirir.
SELECT @kategoriSayisi =  COUNT(Categories.CategoryID) FROM Categories; -- yukarýdaki ile ayný iþi yapar.
PRINT @kategoriSayisi;
GO


PRINT GETDATE(); -- Tarih yazar.

DECLARE @sayi int;
SET @sayi= 10; -- tipi int.
PRINT CONVERT(NVARCHAR(5),@sayi)
PRINT CONVERT(NVARCHAR(3),123) -- 123 sayýsýný NVARCHAR'a çevir ekrana yaz.

PRINT TRY_CONVERT(NVARCHAR(3),1493) -- 1493 sayýsýný NVARCHAR'a çevirebilirse çevirir. Çeviremezse hata vermez.

SELECT @sayi = CAST('34' AS INT) -- Castin ile tip dönüþümü
DECLARE @HECE NVARCHAR(20);
SELECT @HECE =RIGHT('mehmet',3) -- SAÐDAKÝ 3 KARAKTERÝ AL.
PRINT @HECE; -- et

SELECT @HECE = LEFT('mehmet',3)  -- SOLDAKÝ 3 karakteri alsýn.
PRINT @HECE;

SELECT @HECE = SUBSTRING('KADIKÖY',0,5);
PRINT @HECE;

PRINT REPLICATE('*',5) -- *'I 5 DEFA TEKRAR ET.


-- DATE FONKSÝYONLARI
PRINT DATEDIFF(DD,'05.24.1993',GETDATE()) -- GÜN OLARAK  -- GÜN OLARAK FARK. MM YY DD
PRINT DATEDIFF(YY,'05.24.1993',GETDATE()) -- YIL OLARAK  -- GÜN OLARAK FARK. MM YY DD
PRINT DATEDIFF(MM,'05.24.1993',GETDATE()) -- AY OLARAK  -- GÜN OLARAK FARK. MM YY DD

PRINT CAST(DATEPART(DD,'09.09.1990') AS NVARCHAR(MAX)) + '.'+CONVERT(NVARCHAR(MAX),DATEPART(MM,'09.09.1990'))+'.'+ TRY_CONVERT(NVARCHAR(MAX),DATEPART(YYYY,'09.09.1990'))
-- TARIHIN PARÇALARINI ALDIK.
PRINT DATENAME(MM,GETDATE()) -- AYIN ADI

PRINT DAY(GETDATE())
PRINT MONTH(GETDATE())
PRINT YEAR(GETDATE())
PRINT EOMONTH(GETDATE()) -- BU AYIN SON GÜNÜ
PRINT CURRENT_TIMESTAMP --Jan  4 2020  9:18AM,   Dec  2 2021  2:15PM

PRINT UPPER('mehmet')-- büyüt
PRINT LOWER('MEHMET')-- KÜÇÜLT

PRINT ROUND(14.7,0) --15
PRINT ROUND(14.2,0) --14 0: VIRGÜLDEN SONRA KAÇ KARAKTER OLACAK.


PRINT ASCII('V');
PRINT CHAR(86);
PRINT UNICODE('V');


PRINT CHARINDEX('KÖY','KADIKÖY'); --5

PRINT LTRIM('   BJK'); --BJK -- soldaki boþluklarý siler.
PRINT RTRIM('BJK   '); --BJK

PRINT CONCAT('MEHMET ','DEMÝR',99); --Birleþtirir.


DECLARE @ondalikli FLOAT
SET @ondalikli = 14.9939775;
PRINT STR(@ondalikli,7,2); -- tip dönüþtürerek yazdýrdýk.

-- CASE


DECLARE @durum nvarchar(5);
SET @durum = 'evet';
SELECT CASE @durum WHEN 'evet' THEN 'Durum Evet' END DÜRÜM; -- þart saðlanýyorsa...

--- KOÞUL KONTROLÜ

DECLARE @sayi2 int;
SET @sayi2=99;
IF(@sayi2<100)
BEGIN -- Blok baþlangýcý
	PRINT 'sayi 100"den küçüktür' 
END -- Blok bitiþi
ELSE
BEGIN
	PRINT 'sayi 100 veya büyüktür'
END

-- DÖNGÜLER


DECLARE @Sayac TINYINT
SET @Sayac=10
WHILE (@Sayac>0)
BEGIN
    PRINT @Sayac
    SELECT @Sayac=@Sayac-1
END


GO
	DECLARE @Sayac INT
	SET @Sayac=0
	WHILE (@Sayac<10) 
	BEGIN 
		SELECT @Sayac=@Sayac+1 
		IF(@Sayac*@Sayac>10)
			BEGIN
				PRINT 'Sayýnýn karesi 10 deðerini geçti.'
				BREAK --döngüden cýk -- CONTINUE
			END
	END
GO

DECLARE @kategoriAdi nvarchar(max);
SELECT CategoryName , IIF(CategoryName='Beverages','Yiyecekler','Ýçecek') as Türkçe FROM Categories;


IF EXISTS(SELECT * FROM Orders WHERE ShipCountry = 'France')
BEGIN
PRINT 'Fransa mevcuttur' 
END

PRINT @@MAX_CONNECTIONS 

PRINT @@LANGID

PRINT @@SERVERNAME

PRINT @@SERVICENAME

PRINT @@MICROSOFTVERSION

