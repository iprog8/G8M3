use Clienti
go

insert into Client
	(Nume,Prenume,Telefon,Adresa)
values
	('Ion','Tudor','0726312822','Focsani'),
	('Mario','Aldea','0784132681','Bucuresti'),
	('Andrei','Hanu','0745628973','Craiova'),
	('Mircea','Eliade','0712723498','Iasi');
go

insert into factura
	(DataEmisa,DataScadenta,Suma)
values
	('2014-04-12','2014-05-12','240'),
	('2016-10-74','2016-11-74','300'),
	('2018-12-29','2019-01-29','150'),
	('2020-06-16','2020-07-16','120');
go
-- aici nu pot executa deoarece imi da eroarea asta : 'Conversion failed when converting date and/or time from character string.'
insert into Produs 
	(Denumire,Descriere,Pret,Stoc)
values
	('Tastatura','Gaming','214','40'),
	('Usa','Metalica','599','100'),
	('Procesor','Viteze mari','500','200'),
	('Farfurii','Plastic','5','500');
go

update Client
set Nume = 'Ioana'
where ID = 2
go

update Produs
set Pret = '3'
where ID = 4
go

-- aici nu am cum sa rulez din cauza erorii
delete from factura
where ID in (1,2)
go
-- asa ar fi trebuit sa arate daca nu imi dadea eroarea


select *
from Client
go

select Denumire,Pret
from Produs
go