--setam baza de date pe care lucram
use CLIENTI
go

--introduce date in tabela Client
insert into Client
	( nume, prenume, email, telefon, adresa)
VALUES
	('Geagu', 'Bogdan', 'bogdan@', '0751245', 'str Plutonier'),
	('Geagu', 'Costel', 'costel@', '0751244', 'str Mugureilor'),
	('Geagu', 'Camelia', 'camelia@', '0751243', 'str Mugureilor'),
	('Pirvan', 'Cristiana', 'cristiana@', '0751245', 'str Plutonier');
go

--introduce date in tabela Produs
insert into Produs
	(Denumire, Descriere, Pret, Stoc, ProdusID)
values
	('Mere','de la Ana','4','1500','1'),
	('Pere','de la Dana','6','2500','2'),
	('Prune','de la Alexandra','7','1200','3'),
	('Nuci','de la Cristina','12','700','4');
go

--introduce date in tabela Factura
insert into Factura
	(Seria_NR, Data_Emiterii, Nume_Firma, Nume_Beneficiar, Produs, Cantitate, Pret_unitar_faraTVA, Valoarea, Valoarea_TVA)
VALUES
	('4512545','2020-04-04','Supeco','Trade&Business','Humus','500','7','8.52','1.52'),
	('1515321','2020-02-03','Pepco','BCR','Verzisori','9999','1','1.16','0.16'),
	('1235453','2020-12-02','Adibas','Spuma','Snike','230','180','189','9'),
	('8127452','2020-15-01','MAI','NaughtyCivilians&Co','Tonfa','1300','182','197','15');
go
-- ERROR Conversion failed when converting date and/or time from character string.

--modificare date in tabela Client dupa Nume
UPDATE Client SET
	Nume = 'Geagu'
	where ID = 2
go

--modificare date in tabela Produs in Pret dupa ID
UPDATE Produs SET
	Pret = '7'
	where ID = 10
go

--stergere date in tabela Factura dupa ID a primele 2 randuri
DELETE FROM Factura
	where ID in (1,2)
go

--selectarea tuturor clientilor din tabela Client
SELECT Nume, Prenume
	from Client
go

--selectarea numelui produsului si pretul din tabela Produs
SELECT Denumire, Pret
	from Produs
go