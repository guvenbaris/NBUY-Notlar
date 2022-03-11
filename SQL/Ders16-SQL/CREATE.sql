-- CREATE DATABASE OKUL_VT; -- OKUL_VT isminde bir veritabaný oluþturduk.

-- DROP DATABASE OKUL_VT; -- OKUL_VT veritabanýný siler.

USE OKUL_VT; -- OKUL_VT veritabanýný kullan.

-- Tablo oluþturuyoruz.

--CREATE TABLE tb_Ogrenci 
--(
--	numara int,
--	ad nvarchar(50),
--	soyad nvarchar(50),
--	dogumYili smallint,
--	sinif varchar(5)
--);

-- Tabloyu düzenliyoruz.
-- nuamra yý primary key yaptýk.
ALTER TABLE tb_Ogrenci ALTER COLUMN ad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN soyad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN dogumYili smallint NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN sinif varchar(5) NOT NULL;

ALTER TABLE tb_Ogrenci DROP CONSTRAINT  PK__tb_Ogren__FD77822034462A74;
ALTER TABLE tb_Ogrenci DROP numara;
ALTER TABLE tb_Ogrenci ADD numara int NOT NULL IDENTITY(1,1) PRIMARY KEY;
ALTER TABLE tb_Ogrenci DROP numara;


--Kurs Numarasý : Mehmet Demir

--Kurs Numarasý : 1090998
--Kurs Saatleri : l08:30   -   15:05

