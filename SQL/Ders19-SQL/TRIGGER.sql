-- TRIGGER: Çaðýrýlmaksýzýn þartlar saðlandýðýnda otomatik çalýþan SQL
--          sorgularý yazmamýzý saðlar. þartlar saðlandýðýnda çalýþan sorgu bloklarý.
--          AFTER TRIGGER: Belirli bir sorgu çalýþrsa arkasýnda çalýþsýn þeklinde tanýmladýðýmýz
--                        TRIGGER yapýsýdýr. ÖRN: Categories tablosuna her INSERT yapýldýðýnda
--						  sorgusu otomatik çalýþsýn.
--			INSTEAD OF TRIGGER: Belirli bir tabloda çalýþan bir sorgu çaðýrýldýðýnda o sorgu 
--								çalýþmasýn bizim TRIGGER ile tanýmladýðýmýz sorgu çalýþsýn.

--CREATE TRIGGER TR_BlockDeleteCategory -- Trigger adýný belirttik.
--ON Northwind.dbo.Categories  -- Hangi tabloda çalýþacaðýný belirttik.
--INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda çalýþacaðýný belirttik.
--AS
--BEGIN
--	PRINT 'Bu tabloda silme iþlemi engellendi !!'
--END


ALTER TRIGGER TR_BlockDeleteCategory -- Trigger adýný belirttik.
ON Northwind.dbo.Categories  -- Hangi tabloda çalýþacaðýný belirttik.
INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda çalýþacaðýný belirttik.
AS
BEGIN
	DECLARE @catAdi NVARCHAR(50);	
	SELECT @catAdi = CategoryName FROM DELETED;  -- DELETED tablosu geçici(temp) olarak silinmeye çalýþan
	PRINT @catAdi+ ' silinmeye çalýþýldý.'
END

USE Northwind;
--SELECT * FROM Categories;
DELETE FROM Categories WHERE CategoryID=8; -- Seafood silinmeye çalýþýldý.
ENABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DELETE FROM Categories WHERE CategoryID=12;

SELECT * FROM Categories;
--

-- CategoriesBackup isimli bir tablo oluþturun. 
-- Categories tablosundan veri silinmeye çalýþýldýðýnda önce silinmeye çalýþýlan veriyi bu yeni tabloya 
-- insert edin.
-- Daha sonra silinmeye çalýþýlan satýrý silin.
