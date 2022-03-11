--USE [Northwind]
--GO

--/****** Object:  Table [dbo].[Shippers]    Script Date: 7.12.2021 10:12:54 ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE [dbo].[ShippersBackup](
--	[ShipperID] [int] NOT NULL,
--	[CompanyName] [nvarchar](40) NOT NULL,
--	[Phone] [nvarchar](24) NULL,
-- )
--GO


--ALTER TRIGGER TR_AfterDeleteShippers
--ON Northwind.dbo.Shippers
--AFTER DELETE -- Tip ve hangi komuttan sonra �al��aca��.
--AS
--BEGIN
--	DECLARE @id INT;
--	DECLARE @name NVARCHAR(50);
--	DECLARE @phone NVARCHAR(24);
--	SELECT @id = [ShipperID] FROM DELETED;
--	SELECT @name = CompanyName FROM DELETED;
--	SELECT @phone = Phone FROM DELETED;
--	INSERT INTO  ShippersBackup (ShipperID,CompanyName,Phone)
--	VALUES (@id,@name,@phone);
--END


-- Tablomuza 10 adet kay�t ekledik.
--GO
--DECLARE @sayac INT;
--SET @sayac = 0;
--DECLARE @tel NVARCHAR(20);
--SET @tel = CONCAT('0216 123 123 ',@sayac);
--INSERT INTO Shippers (CompanyName,Phone)
--VALUES ('Furkan Ta��mac�l�k',@tel);
--SELECT @sayac= @sayac + 1;
--GO 10

--SELECT * FROM Shippers;

DELETE FROM Shippers WHERE CompanyName LIKE '%Furkan%';
DELETE FROM Shippers WHERE ShipperID IN(7);


SELECT * FROM Shippers;

SELECT * FROM ShippersBackup;

-- Shippers tablosuna bir kay�t eklendi�inde bu kayda ait 
-- CompanyName eklendi. �eklinde ekrana print yazd�ran trigger � yaz�n�z.

CREATE TRIGGER TR_InsertedShippers
ON Northwind.dbo.Shippers
AFTER INSERT
AS
BEGIN
	DECLARE @name NVARCHAR(40);
	Select @name = CompanyName from INSERTED;
	PRINT CONCAT(@name ,' Eklendi !')
END

INSERT INTO Shippers  values ('Tesla','4440444')