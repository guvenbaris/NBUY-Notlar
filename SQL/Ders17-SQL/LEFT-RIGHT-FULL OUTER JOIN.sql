--***** MÜLAKATTA ÇIKABÝLÝR ******
--***** ÝÞ HAYATINDA KESÝN ÇIKAR ******

SELECT * FROM tb_Alan;
SELECT * FROM tb_Sinif;
SELECT * FROM tb_Ogrenci;
SELECT * FROM tb_Ogretmen;

--INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID) 
--VALUES ('Seyhan','KARACA',1995,2);

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES('Aþýk','Veysel','03463211232',3);

-- INNER JOIN/JOIN iki tabloda ON ile belirtilen kolonlar dolu ise 
-- listeler.
-- Öðretmeni olan tüm öðrencileri listele (öðretmeni olmazsa listelemez veya öðretmenin öðrencisi yoksa listelemez). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci INNER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- LEFT JOIN (FROM'dan sonra ve ON'dan sonra yazdýðýmýz tablo adý SOLDAKÝ'dir.)
-- Tüm öðrencileri listele (öðretmeni olmasa da öðrencilerin tamamýný,öðretmenlerin sadece öðrencisi olanlarý
-- listeler). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci LEFT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- RIGHT JOIN: soldaki:öðrenci tablosundan öðretmeni olanlarý alýrken 
-- saðdaki tablo:öðretmenlerin tamamýný listeler.
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci RIGHT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- FULL OUTER JOIN: her iki tablodada karþýlýðýnda veri olmasýna bakmaksýzýn
-- tüm satýrlarý getirir.saðda ve solda NULL kolonlar olabilir.

SELECT 
CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as Öðrenci,
CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci
FULL OUTER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;
