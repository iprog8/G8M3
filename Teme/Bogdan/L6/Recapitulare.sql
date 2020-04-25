
--In baza de date IPRO creati tabela Cursant cu campurile: Id, Nume, DataNastere, Localitate, Tara;

create database IPRO
go

create table Cursant 
(
	Id int primary key,
	Nume nvarchar(50),
	DataNastere date,
	Localitate nvarchar(150),
	Tara nvarchar(50)
)
go


--Creati tabela Modul cu campurile: Id, Denumire, NumarOre, ZileCodding

create table Modul
(
	Id int primary key,
	Denumire nvarchar(50),
	NumarOre int,
	ZileCodding int
)
go


--Creati tabela Grupa cu campurile: Id, ModulId, Denumire, DataStart, DataStartCodding;
--Faceti legaturile dintre tabele ( Foreign Keys);

create table Grupa
(
	Id int primary key,
	ModulId int foreign key references Modul(Id),
	Denumire nvarchar(50),
	DataStart date,
	DataStartCodding date
)
go


--Creati tabela CursantGrupa cu campurile: Id, CursantId, GrupaId, NotaFinala, Continua;

create table CursantGrupa
(
	Id int primary key,
	CursantId int foreign key references Cursant(Id),
	GrupaId int foreign key references Grupa(Id),
	NotaFinala nvarchar(20),
	Continua nvarchar(3)
)
go

use IPRO
go


--In tabela Cursant introduceti toti colegii tai din modulele 1,2,3;

insert into Cursant
	(Id, Nume, DataNastere, Localitate, Tara)
values
	('1','Geagu Bogdan','19931111','Mioveni','Romania'),
	('2','Pirvan Cristiana','19931010','Rosiorii de Vede','Romania'),
	('3','Staicu Sorina','20000909','Bucuresti','Romania'),
	('4','Avram Cristian','19970226','Craiova','Romania'),
	('5','Vlad Octavian','19880808','Bucuresti','Romania'),
	('6','Mioara Manuela','19850707','Bucuresti','Romania'),
	('7','Letiția Provian','19890320','Bucuresti','Romania'),
	('8','Shirina-Maria Stefanescu-Albu','19861212','Bucuresti','Romania'),
	('9','Gabriel Hanu','20030606','Focsani','Romania'),
	('10','Alina Rudi','19900505','Campina','Romania'),
	('11','Meli Nagy','19780404','Bucuresti','Romania'),
	('12','Mădălina Dumitrache','19980303','London','UK'),
	('13','Denisa Gindila','20021014','Bucuresti','Romania'),
	('14','Neflait Ovidiu Codreanu','19791203','Vaslui','Romania'),
	('15','Mihaela Ionita','19900510','Bucuresti','Romania'),
	('16','Ionescu Letitia','19900303','Bucuresti','Romania'),
	('17','Ovidiu Rudi','19960501','Campina','Romania');
go


--In tabela Modul introdu toate cele 4 module de la InvatamProgramare;

insert into Modul
	(Id, Denumire, NumarOre, ZileCodding)
values
	('1','M1: Introducere in lumea programarii','120','1'),
	('2','M2: Web-ul este viitorul','120','2'),
	('3','M3: OOP','120','2'),
	('4','M4','120','2'),
	('5','G10M1','120','1')
go


--In tabela Grupa introduceti cele 3 Grupe in care ai participat dar si grupa G10M1;

insert into Grupa
	(Id, ModulId, Denumire, DataStart, DataStartCodding)
values
	('1','1','G8M1','20191031','20191105'),
	('2','2','G8M2','20200114','20200116'),
	('3','3','G8M3','20200406','20200407'),
	('4','5','G10M1','20200405','20200406');
go


--In tabela CursantGrupa introduce-te pe tine in toate cele 3 grupe la care ai participat si macar inca 2-3 colegi;

insert into CursantGrupa
	(Id, CursantId, GrupaId, NotaFinala, Continua)
values
	('1','1','1','10','Da'),
	('2','3','1','10','Da'),
	('3','4','2','10','Da'),
	('4','2','1','9','Da'),
	('5','1','2','7','Da'),
	('6','3','2','10','Nu'),
	('7','2','2','8','Da'),
	('8','1','3','',''),
	('9','4','2','10','Da'),
	('10','2','3','',''),
	('11','12','1','7','Nu'),
	('12','5','1','10','Da'),
	('13','4','3','',''),
	('14','11','1','9','Da'),
	('15','5','3','',''),
	('16','7','2','9','Da'),
	('17','15','1','8','Nu'),
	('18','6','2','9','Da'),
	('19','5','2','10','Da'),
	('20','14','2','7','Nu'),
	('21','7','3','',''),
	('22','9','2','10','Da'),
	('23','6','3','',''),
	('24','14','1','7','Da'),
	('25','9','1','10','Da'),
	('26','6','1','9','Da'),
	('27','10','2','10','Nu'),
	('28','9','3','',''),
	('29','7','1','9','Da'),
	('30','8','1','8','Nu');
go
