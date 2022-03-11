-- VIEW: Sanal tablo oluþturmamýzý saðlar. Aþaðýdaki gibi karmaþýk ve uzun sorgularý 
-- view olarak tanýmladýðýmýzda sanki o detaylý sorgunun sonucu bir tabloymuþçasýna 
-- tablodan veri çekebiliriz.

---- VIEW TANIMLAMA
--CREATE VIEW OgrenciOgretmen AS
--	SELECT 
--	CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as Öðrenci,
--	CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
--	FROM tb_Ogrenci INNER JOIN tb_Ogretmen
--	ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;



---- VIEW DÜZENLEME
--ALTER VIEW OgrenciOgretmen AS
--	SELECT 
--	CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as Öðrenci,
--	CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
--	FROM tb_Ogrenci INNER JOIN tb_Ogretmen
--	ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- VIEW SORGULAMA
-- Tüm kolonlarý getir.
--SELECT * FROM OgrenciOgretmen;

---- Belirli kolonlarý getir.
--SELECT Öðrenci FROM OgrenciOgretmen;
--SELECT Öðretmen FROM OgrenciOgretmen;