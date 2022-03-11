--Stored Procedure: SQL dilinde yazýlýmdaki metotlara karþýlýk gelen ifadedir.
--					SP kýsaltmasý ile bilinir. Parametreli veya parametresiz olabilir.
--					Aldýðý parametreleri sorgularda kullanabilir.
--					Geriye deðer döndürebilir.(OUTPUT)
--					Belirli iþleri yapan sorgularý SP ler ile 1 defa yazarak sürekli kullanýrýz.


--STORED PROCEDURE TANIMLANMASI

--CREATE PROCEDURE GetCategories -- CREATE PROC da kullanlýabilir.
--AS
--BEGIN
--SELECT * FROM Northwind.dbo.Categories;
--END


-- STORED PROCEDURE KULLANIMI
-- EXECUTE Northwind.dbo.GetCategories;
--EXECUTE GetCategories;  -- EXEC GetCategories;

--ALTER PROC SearchOnCategories(@name NVARCHAR(50)) AS
--BEGIN
--	DECLARE @sayi  INT;
--	SELECT @sayi = COUNT(*) FROM Northwind.dbo.Categories WHERE Categories.CategoryName = @name;
--	IF (@sayi>0)
--		BEGIN
--			SELECT * FROM Northwind.dbo.Categories WHERE Categories.CategoryName = @name;
--			SELECT STR(@sayi) + ' adet kayýt bulundu.'
--		END
--	ELSE
--		BEGIN
--			PRINT 'Herhangi bir kayýt bulunamadý!'
--		END
--END

--EXEC Northwind.dbo.SearchOnCategories 'Elma';
--EXECUTE Northwind.dbo.SearchOnCategories 'Beverages';

-- Order Details tablosundan unit price ve quantity alt sýnýrýna göre sorgu çekecek SP yi yazýnýz.
-- Örnek : EXEC GetOrderDetails 10,15; -- UnitPrice 10 ve üzeri Quantity 15 ve üzeri olanlarý getir.


--CREATE PROC SP_GetOrderDetails
--(
--	@unitPriceLimit INT,@quantityLimit INT
--)
--AS
--BEGIN
--	SELECT * FROM [Order Details] WHERE [Order Details].UnitPrice>=@unitPriceLimit AND [Order Details].Quantity>=@quantityLimit;
--END



--EXECUTE SP_GetOrderDetails 10,5;


-- Categories tablosuna kayýt eklemesi yapan SP yi yazýnýz.
-- Parametreler name,desc,pict

--CREATE PROCEDURE SP_AddCategory 
--(
--	@name NVARCHAR(50),@desc NVARCHAR(max),@pict IMAGE
--)
--AS
--BEGIN
--	INSERT INTO Northwind.dbo.Categories (CategoryName,Description,Picture)
--	VALUES (@name,@desc,@pict);
--END

--EXEC SP_AddCategory 'Technology','Tecnology devices like computers,cameras...','foto.png';

--SELECT * FROM Categories;


-- Categories tablosundan silme iþlemi yapan SP yi yazýnýz.
-- parametre olarak ID alsýn.

--CREATE PROC SP_DeleteCategory (@ID INT) AS
--BEGIN
--	SELECT * FROM Northwind.dbo.Categories;
--	DELETE FROM Northwind.dbo.Categories WHERE CategoryID = @ID;
--	SELECT * FROM Northwind.dbo.Categories;
--END


--EXEC SP_DeleteCategory 9;

-- Categories tablosundaki kayýtlarý update etmemizi saðlayan SP yi yazýnýz.


--ALTER PROC SP_UpdateCategory 
--(@ID INT,@name NVARCHAR(50),@desc NVARCHAR(50),@pict IMAGE) AS
--BEGIN
--	UPDATE Categories SET CategoryName=@name,Description=@desc,Picture=@pict WHERE CategoryID=@ID;
--	SELECT 'Etiklenen satýr sayýsý: '+STR(@@ROWCOUNT);
--END

--EXEC SP_UpdateCategory 12,'Sports','Sport products like basketball shoes...','Test';



--SELECT * FROM Categories;
--EXEC SP_AddCategory 'ASD','ASD','ASD';
--GO
--UPDATE Categories SET CategoryName='Test',Description='Test',Picture='Test' WHERE CategoryID=12;
--SELECT @@ROWCOUNT
--GO


-- Kaç kategori olduðunu döndüren SP yi yazýnýz.

--CREATE PROCEDURE SP_GetCategoryCount (@count INT OUTPUT) AS
--BEGIN
--	SELECT @count = COUNT(*) FROM Categories;
--END


DECLARE @sayi INT; -- Boþ deðiþken tanýmladýk.
EXECUTE SP_GetCategoryCount @sayi OUTPUT; -- SP den gelen deðeri @sayi deðiþkenine atadýk.
PRINT 'Categories tablosundaki kayýt sayýsý : '+STR(@sayi);

-- Kendisine gönderilen 2 adet sayýyý toplayýp sonucu döndüren Sp yi yazýnýz.
--Kendisine gönderilen 2 adet sayýyý toplayýp sonucu döndüren sp ;
CREATE PROC topla (@sayý1 int, @sayý2 int, @sonuc int output) AS
BEGIN
	SET @sonuc = @sayý1+@sayý2;
END
-- SP yi çaðýrýrken.

DECLARE @sonuc INT;
EXECUTE topla 3,4,@sonuc OUTPUT;
PRINT 'Toplama sonucu : '+STR(@sonuc);













