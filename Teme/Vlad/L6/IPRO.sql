-- In baza de date IPRO creati tabela Cursant cu campurile: Id, Nume, DataNastere, Localitate, Tara;
create database IPRO
go

use IPRO
go


create table Cursant (
	Id int primary key Identity (1,1),
	Nume nvarchar(50) not null,
	DataNastere date , 
	Localitate nvarchar(50),
	Tara nvarchar(50) );
go

--Creati tabela Modul cu campurile: Id, Denumire, NumarOre, ZileCodding
create table Modul (
	Id int primary key Identity (1,1),
	Denumire nvarchar(50) not null,
	NumarOre int,
	ZileCoding int 
);
go

--Creati tabela Grupa cu campurile: Id, ModulId, Denumire, DataStart, DataStartCodding;
create table Grupa (
	Id int primary key Identity (1,1),
	ModulId int foreign key references Modul(Id),
	Denumire nvarchar(50) not null,
	DataStart date,
	DataStartCoding date
);
go

--Creati tabela CursantGrupa cu campurile: Id, CursantId, GrupaId, NotaFinala, Continua;
create table CursantGrupa (
	Id int primary key Identity (1,1),
	CursantId int foreign key references Cursant(Id),
	GrupaId int foreign key references Grupa(Id),
	NotaFinala int not null, 
	Continua bit
);
go

-- In tabela Cursant introduceti toti colegii tai din modulele 1,2,3;
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
('Dorin Varatic',null,null,'Republica Moldova'),
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
('Alina Mihaela',null,'Timisoara','Romania');
go

-- In tabela Modul introdu toate cele 4 module de la InvatamProgramare;
insert into Modul 
(Denumire,NumarOre,ZileCoding)
values
('M1','100','1'),
('M2','120','2'),
('M3','120','2'),
('M4','120','2'),
('G10M1','100','1');
go

-- In tabela Grupa introduceti cele 3 Grupe in care ai participat dar si grupa G10M1;
insert into Grupa
(ModulId,Denumire,DataStart,DataStartCoding)
values
('1','G8M1','2019-10-31','2019-11-05'),
('2','G8M2','2020-01-14','2020-01-16'),
('3','G8M3','2020-04-06','2020-04-07'),
('4','G8M4','2020-06-05','2020-04-08'),
('5','G10M1','2020-04-05','2020-04-06') ;
go	

-- In tabela CursantGrupa introduce-te pe tine in toate cele 3 grupe la care ai participat si macar inca 2-3 colegi;
insert into CursantGrupa
(CursantId,GrupaId,NotaFinala,Continua)
values
('5','1','8','1'),
('5','2','9','1'),
('5','3','8','1'),
('7','1','10','1'),
('7','2','8','1'),
('7','3','7','0'),
('10','1','10','1'),
('10','2','7','1'),
('10','3','8','0'),
('11','1','10','1'),
('11','2','9','1'),
('11','3','7','1'),
('20','1','10','1'),
('20','2','8','1'),
('20','3','9','0') ;
go


/*select * from Cursant
select * from Grupa
select * from Modul
select * from CursantGrupa*/

--Selectati toate grupele de modulul 1; Hint: inner join
select * from Grupa
select * from Modul
SELECT * FROM 
	Modul Md inner join 
	Grupa Gr on Md.Id = Gr.ModulId
where Gr.Denumire like '%M1%';

--Selectati toti cursantii de la grupa G8M2; Hint: inner join
select * from 
	Cursant Crs inner join 
	CursantGrupa CrsGrp on Crs.Id = CrsGrp.CursantId 
	inner join 
	Grupa Gr on Gr.Id = CrsGrp.GrupaId

where Gr.Denumire = 'G8M2';


-- Modulele cu care nu s-a facut nici o grupa pana acum; Hint: left join
select *
from Modul M left join Grupa G on M.Id = G.ModulId
where G.ModulId is null;
go /* ..? ar fi trebuit sa fie modulul 4,dar e deja adaugat in tabela.*/

--Selectati toti cursantii care nu au participat la nici o grupa; Hint: right join
select 
	CrsGrp.CursantId as CursantID,
	CrsGrp.Id as CursantGrupaID,
	Crs.Nume as Nume,
	Crs.ID as CursantID
from  CursantGrupa CrsGrp right join 
	Cursant Crs on Crs.Id = CrsGrp.CursantId 
where CrsGrp.CursantId is null

--Selectati toti cursantii care au participat la M1; Hint: 3 inner join
select * from 
	Cursant Crs inner join 
	CursantGrupa CrsGrp on Crs.Id = CrsGrp.CursantId 
	inner join 
	Grupa Gr on Gr.Id = CrsGrp.GrupaId

where Gr.Denumire = 'G8M1';

--Selectati toti cursantii;
select * from Cursant

--Selectati numarul total al cursantilor; Hint: agregare
select count(*) NrDeCursanti from Cursant

--Selectati toti cursantii din Romania;
select * 
	from Cursant
	where Tara = 'Romania'
--Selectati numarul cursantilor din Romania; Hint: agregare + grupare
select Tara,count(Tara) NrCursantiRo 
	from Cursant
	where Tara = 'Romania'
	group by Tara

--Selectati toti cursantii a caror nota este mai mare de 7;
select * from 
	Cursant Crs inner join
	CursantGrupa CrsGrp on Crs.ID = CrsGrp.CursantId 
	where NotaFinala > 7

--Calculati media notelor tuturor cursantilor; Hint: agregare

select 
	avg(NotaFinala) MediaFinala from
	CursantGrupa
	 

--Calculat media notelor pe fiecare cursant; Hint: agregare + grupare*/
select 
	Crs.Nume,
	avg(CrsGrp.NotaFinala) MediaFinala from
	Cursant Crs inner join
	CursantGrupa CrsGrp on Crs.ID = CrsGrp.CursantId 
	group by Crs.Nume;