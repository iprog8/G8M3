create database IPRO
go
use IPRO
go
create table Cursant
(
ID int Primary Key not null Identity(1,1),
Nume nvarchar(50) not null,
DataNastere date not null,
Localitate nvarchar (30) not null,
Tara nvarchar(20) not null,
)
go
create table Modul
(
ID int Primary Key not null Identity(1,1),
Denumire nvarchar(50) not null,
NumarOre int  null,
ZileCoding int  null,
)
go
create table Grupa
(
ID int Primary Key not null Identity(1,1),
ModulID int not null,
Denumire nvarchar(50) not null,
DataStart date ,
DataStartCodding date ,
)
go
create table CursantGrupa 
(
ID int Primary Key not null Identity(1,1),
CursantID int not null,
GrupaID int not null,
NotaFInala float ,
Continua bit ,
)
go


alter table CursantGrupa
	add foreign key (CursantID)
	references Cursant(ID)
go

alter table CursantGrupa
	add foreign key (GrupaID)
	references Grupa(ID)
go

alter table Grupa
	add foreign key (ModulID)
	references Modul(ID)
go
INSERT INTO Cursant
	( Nume, DataNastere, Localitate, Tara)
VALUES
	('Avram','1977-02-26', 'Craiova', 'Romania'),
	('Stefanescu','1995-01-01', 'Bucuresti', 'Romania'),
	('Neflait','1979-12-03', 'Vaslui', 'Romania'),
	('Provian','1990-03-20', 'Bucuresti', 'Romania'),
	('Strat','1978-08-16', 'Barlad', 'Romania'),
	('Mitu','1985-01-01', 'Galati', 'Romania'),
	('Nagy','1970-01-01', 'Targu Mures', 'Romania'),
	('Varatic','1990-01-01', 'Bucuresti', 'Romania'),
	('Flerariu','2000-01-01', 'Buftea', 'Romania'),
	('Gandila','2002-10-14', 'Bacau', 'Romania'),
	('Soso','1990-01-01', 'Bucuresti', 'Romania'),
	('Hanu','2004-01-01', 'Bucuresti', 'Romania'),
	('Ionita','1990-05-10', 'Bucuresti', 'Romania'),
	('Parvan','1993-01-01', 'Rosiori de Vede', 'Romania'),
	('Geagu','1993-01-01', 'Mioveni', 'Romania'),
	('Sibiceanu','1993-01-01', 'Bucuresti', 'Romania'),
	('Vlad','1990-06-24', 'Bucuresti', 'Romania'),
	('Ana','1998-01-01', 'Botosani', 'Romania'),
	('Dumitrache','2020-01-01', 'Bucuresti', 'Romania'),
	('Ioan','1994-08-21', 'Bucuresti', 'Romania'),
	('Marinescu','1980-01-01', 'Pitesti', 'Romania');

go

INSERT INTO Modul
	( Denumire, NumarOre, ZileCoding)
VALUES
	('Intro',28, 1),
	('WebDev',32, 2),
	('OOP',32, 2),
	('ASP', NULL, NULL);
go

INSERT INTO Grupa
	( ModulID, Denumire, DataStart, DataStartCodding)
VALUES
	(1,'G8M1','2019-10-28', '2019-11-24'),
	(2,'G8M2','2020-01-21', '2020-03-15'),
	(3,'G8M3','2020-04-07', NULL),
	(1,'G10M1', NULL, NULL);
go
INSERT INTO CursantGrupa
	( CursantID, GrupaID, NotaFInala, Continua)
VALUES
	(1, 1, 8, 1),
	(1, 2, 5, 1),
	(1, 3, NULL, 1),
	(4, 1, 8, 1),
	(4, 2, 7, 1),
	(4, 3, NULL, 1),
	(11, 1, 6, 1),
	(11, 2, 7, 0),
	(12, 1, 8, 1),
	(12, 2, 9, 1),
	(12, 3, NULL, 1),
	(10, 1, NULL, 0);
go

-- 1 Selectez toate grupele de modulul 1

select *
from Modul M inner join Grupa G
	on M.ID = G.ModulID
where ModulID=1

-- 2 Selectez toti cursantii de la grupa G8M2
select *
from Cursant C inner join CursantGrupa CG
	on C.ID = CG.CursantID 
where GrupaID = 2

-- 3 Selectez modulele cu care nu s-a facut nicio grupa pana acum

select *
from Modul M left join Grupa G
	on M.ID = G.ModulID
where NumarOre is NULL

-- 6 Selectez toti cursantii;

select *
from Cursant

-- 7 Selectez numarul total al cursantilor

select
	 count(*) NumarDeCursanti
from Cursant

-- 8 Selectez toti cursantii din Romania;

select *
	from Cursant
where Tara = 'Romania'

-- 10 Selectez toti cursantii a caror nota este mai mare de 7

select *
	from Cursant C inner join CursantGrupa CG
		on C.ID = CG.CursantID
where NotaFInala > 7

-- 11 Calculez media notelor tuturor cursantilor

select 
	avg(NotaFInala) MediaNotelorFinale
from CursantGrupa



--Selectez toti cursantii care nu au participat la nici o grupa

Select *
	from CursantGrupa CG right join Cursant C
		on  CG.CursantID = C.ID
		where CG.CursantID is NULL


-- Selectez toti cursantii care au participat la M1

select *
	from Grupa G inner join CursantGrupa CG
		on G.ID = CG.GrupaID
				 inner join Cursant C
				 on CG.ID = C.ID
	where ModulID = 1


--Selectez numarul cursantilor din Romania

select 
	COUNT(ID) as NumarulCursantilor
	from Cursant
	group by Tara

-- Calculez media notelor pe fiecare cursant

select
	avg(NotaFInala) as MediaNotelorFinalePerCursant
	from Cursant C inner join CursantGrupa CG
			on C.ID = CG.CursantID
	group by Nume