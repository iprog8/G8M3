use clienti
go
insert into client
	( nume, prenume, email, telefon, adresa)
VALUES
	('avram', 'cristian', 'whiskyman_cv@yahoo.com', '0728181218', 'Craiova'),
	('avram', 'stefan', 'whiskyman_cv@yahoo.com', '0728181217', 'Craiova' ),
	('avram', 'dumitru', 'whiskyman_cv@yahoo.com', '0728181216', 'Craiova'),
	('avram', 'nicolita', 'whiskyman_cv@yahoo.com', '0728181215', 'Craiova');


insert into factura
	(DataEmitereFactura, TermenDePlata)
VALUES
	('2010-11-11', '30'),
	('2011-10-12', '07'),
	('2012-10-13', '45'),
	('2013-09-14', '30');


insert into produs
	(denumire, descriere, pret, stoc)
values
	('bere','doza','3', '20'),
	('mere','caserola','2', '203'),
	('pere','caserola','3', '320'),
	('portocale','plasa','4', '240');
go

UPDATE client Set
	nume = 'Popescu'
where Id = 7
--m-am mai jucat si, in cazul meu, al doilea a devenit al saptelea.(cum resetam id-ul?)
go
update produs  set
	pret = '5'
where ID = 6
--aceasi situatie ca mai sus
go

DELETE FROM factura
where Id in (17,18)
--aceasi situatie ca mai sus
go

select nume, prenume 
from client
go

select denumire,pret
from produs
go

