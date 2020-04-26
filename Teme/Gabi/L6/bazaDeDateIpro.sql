create database IPRO
go

use ipro 
go

--prima parte
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
('10','1','10','True'),
('10','2','7','True'),
('10','3','8',''),
('5','1','10','True'),
('5','2','9','True'),
('5','3','7',''),
('7','1','10','True'),
('7','2','8','True'),
('7','3','7',''),
('11','1','10','True'),
('11','2','9','True'),
('11','3','7',''),
('20','1','10','True'),
('20','2','8','True'),
('20','3','9','')
go

--Partea a doua
--Selectati toate grupele de modulul 1; Hint: inner join
select *
from Grupa G inner join Modul M on G.ModulId = M.Id
where G.Denumire like '%M1%';
go

--Selectati toti cursantii de la grupa G8M2; Hint: inner join	
select *
from Cursant C inner join CursantGrupa Cg on C.Id = Cg.CursantId 
where Cg.GrupaId = 2;
go

--Selectati Modulele cu care nu s-a facut nici o grupa pana acum; Hint: left join
select *
from Modul M left join Grupa G on M.Id = G.ModulId
where G.ModulId is null;
go

--Selectati toti cursantii care nu au participat la nici o grupa; Hint: right join
select *
from Cursant C left join CursantGrupa Cg on C.Id = Cg.CursantId 
where Cg.CursantId is null;
go

--Selectati toti cursantii care au participat la M1; Hint: 3 inner join
select *
from Cursant C left join CursantGrupa Cg on C.Id = Cg.CursantId
inner join Grupa G on G.Id = Cg.GrupaId
inner join Modul M on M.Id = G.ModulId
where M.Denumire = 'M1';
go

--Selectati toti cursantii;
select *
from Cursant
go

--Selectati numarul total al cursantilor; Hint: agregare
select 
	count(*) NumarulCursantilor 
from Cursant
go

--Selectati toti cursantii din Romania;
select *
from Cursant C
where C.Tara = 'Romania';
go

--Selectati numarul cursantilor din Romania; Hint: agregare + grupare
select
	Tara,
	count(Tara) as NumarCursantiRomania
from Cursant C
group by Tara
go

--Selectati toti cursantii a caror nota este mai mare de 7;
select *
from Cursant C inner join CursantGrupa CG on C.Id = Cg.CursantId
where Cg.NotaFinala > 7;
go

--Calculati media notelor tuturor cursantilor; Hint: agregare
select 
	avg(NotaFinala) as MedieNoteCursanti
from CursantGrupa
go

--Calculati media notelor pe fiecare cursant; Hint: agregare + grupare
select 
	C.Nume,
	Cg.CursantId,
	avg(Cg.NotaFinala) as MedieNotePerCursant
from CursantGrupa Cg inner join Cursant C on C.Id = Cg.CursantId
group by Cg.CursantId, C.Nume
go