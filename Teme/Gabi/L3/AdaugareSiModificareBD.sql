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
	('2016-10-27','2016-11-27','300'),
	('2018-12-29','2019-01-29','150'),
	('2020-06-16','2020-07-16','120');
go

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


delete from factura
where ID in (9,10)
go



select *
from Client
go

select Denumire,Pret
from Produs
go