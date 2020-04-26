create database IPRO
go

use ipro 
go

--In baza de date IPRO creati tabela Cursant cu campurile: Id, Nume, DataNastere, Localitate, Tara;
create table Cursant
(
Id int primary key not null Identity(1,1),
Nume nvarchar(50) not null,
DataNastere date,
Localitate nvarchar(50),
Tara nvarchar(50) not null
);
go 

--Creati tabela Modul cu campurile: Id, Denumire, NumarOre, ZileCodding
create table Modul 
(
Id int primary key not null Identity(1,1),
Denumire nvarchar(50) not null,
NumarOre int,
ZileCoding int
);
go

--Creati tabela Grupa cu campurile: Id, ModulId, Denumire, DataStart, DataStartCodding;
create table Grupa 
(
Id int primary key not null Identity(1,1),
ModulId int not null,
Denumire nvarchar(50) not null,
DataStart date,
DataStartCoding date
);
go

--Creati tabela CursantGrupa cu campurile: Id, CursantId, GrupaId, NotaFinala, Continua;
create table CursantGrupa
(
Id int primary key not null Identity(1,1),
CursantId int not null,
GrupaId int not null,
NotaFinala int not null,
Continua bit
);
go

--Faceti legaturile dintre tabele ( Foreign Keys);
alter table Grupa
add foreign key (ModulId)
references Modul(Id)
go

alter table CursantGrupa 
add foreign key (CursantId)
references Cursant(Id)
go

alter table CursantGrupa
add foreign key (GrupaId)
references Grupa(Id)
go

--In tabela Cursant introduceti toti colegii tai din modulele 1,2,3;
insert into Cursant
(Nume, DataNastere, Localitate, Tara)
values
('Marius Marinescu',null,'Pitesti','Romania'),
('Victor Ioan','1994-08-21',null,'Romania'),
('Madalina Dumitrache',null,'London','UK'),
('Ana Maria',null,'Botosani','Romania'),
('Vlad Octavian',null,'Bucuresti','Romania'),
('Cosmin Sibiceanu',null,null,'Romania'),
('Bogdan Geagu','1993-01-01','Mioveni','Romania'),
('Pirvan Cristiana',null,'Rosiorii de Vede','Romania'),
('Mihaela Ionita','1990-05-10','Bucuresti','Romania'),
('Gabriel Hanu','2004-03-21','Focsani','Romania'),
('Avram Cristian','1977-02-26','Craiova','Romania'),
('Staicu Sorina',null,'Bucuresti','Romania'),
('Denisa Gindila','2002-10-14','Bucuresti','Romania'),
('Radu Cristian Fluerariu',null,'Buftea','Romania'),
('Dorin Varatic',null,null,'Romania'),
('Mely Nagi',null,null,'Romania'),
('Ionut Mitu',null,'Galati','Romania'),
('Mioara Manuela',null,'Bucuresti','Romania'),
('Alina Rudi',null,'Campina','Romania'),
('Letitia Provian','1989-03-20','Bucuresti','Romania'),
('Neflait Ovidiu Codreanu',null,'Vaslui','Romania'),
('Shirina-Maria Stefanescu-Albu',null,'Bucuresti','Romania'),
('Ovidiu Rudi','1986-05-01','Campina','Romania'),
('Alexandra Turica','1996-02-29','Sofia','Bulgaria'),
('Chera Ana-Maria',null,'Caras-Severin','Romania'),
('Ionescu Letitia',null,null,'Romania'),
('Alina Mihaela',null,'Timisoara','Romania')
go

--In tabela Modul introdu toate cele 4 module de la InvatamProgramare;
insert into Modul 
(Denumire,NumarOre,ZileCoding)
values
('M1','100','1'),
('M2','120','2'),
('M3','120','2'),
('M4','120','2'),
('G10M1','100','1')
go

--In tabela Grupa introduceti cele 3 Grupe in care ai participat dar si grupa G10M1;
insert into Grupa
(ModulId,Denumire,DataStart,DataStartCoding)
values
('1','G8M1','2019-10-31','2019-11-05'),
('2','G8M2','2020-01-14','2020-01-16'),
('3','G8M3','2020-04-06','2020-04-07'),
('5','G10M1','2020-04-05','2020-04-06')
go	

--In tabela CursantGrupa introduce-te pe tine in toate cele 3 grupe la care ai participat si macar inca 2-3 colegi;
insert into CursantGrupa
(CursantId,GrupaId,NotaFinala,Continua)
values
('10','2','10','True'),
('10','3','7','True'),
('10','4','8',''),
('5','2','10','True'),
('5','3','9','True'),
('5','4','7',''),
('7','2','10','True'),
('7','3','8','True'),
('7','4','7',''),
('11','2','10','True'),
('11','3','9','True'),
('11','4','7',''),
('20','2','10','True'),
('20','3','8','True'),
('20','4','9','')
go