CREATE DATABASE IPRO
	go

	USE IPRO
	go

	CREATE TABLE Cursant
(
	ID INT Primary Key,
	Nume nvarchar(50) NOT NULL,
	DataNastere date,
	Localitate nvarchar(30),
	Tara nvarchar(20)
)
go

	CREATE TABLE Modul
(
	ID INT Primary Key,
	Denumire nvarchar(50) NOT NULL,
	NumarOre int NOT NULL, 
	ZileCoddingNOT int NOT NULL
	
)
go
	CREATE TABLE Grupa

(	ID INT Primary Key,
	ModulID int NOT NULL,
	Denumire nvarchar(50) NOT NULL,
	DataStart date NOT NULL,
	DataStartCodding date NOT NULL

	)
	go

	CREATE TABLE IPRO.dbo.CursantGrupa

(	ID INT Primary Key,
	CursantID int NOT NULL,
	GrupaID int NOT NULL,
	Denumire nvarchar(50) NOT NULL,
	NotaFinala int NOT NULL,
	Continua bit  NOT NULL

	)
	go

	 
	-- seteaza FK
	
	ALTER TABLE Grupa
	ADD foreign key (ModulId)
	REFERENCES Modul (Id)
	go


	ALTER TABLE CursantGrupa
	ADD foreign key (CursantId)
	REFERENCES Cursant(Id)
	go

	ALTER TABLE CursantGrupa
	ADD foreign key (GrupaId)
	REFERENCES Grupa(Id)
	go

	--selecteaza toate grupele de M1

	select
	G.Id as GrupaId,
	G.Denumire,
	G.ModulId,
	M.Id as ModulId,
	M.Denumire
	
	from Grupa G inner join 
	Modul M on M.Id=G.ModulId
	where ModulID=1
	go


	
	--selecteaza toti cursantii de la grupa G8M2

	select
	C.Id,
	C.Nume,
	Cg.GrupaId,
	Cg.Denumire

	from Cursant C inner join CursantGrupa Cg
	on C.Id=Cg.CursantID
	where GrupaId=2

	--selecteaza modulele cu care nu s-a facut nicio grupa pana acum

	select*


	from Modul M left join Grupa G
	on M.Id=G.ModulId
	where G.ModulID is null

	--selecteaza toti cursantii care nu au participat la nicio grupa
	
	select*
	from Cursant C left join CursantGrupa Cg
	on C.Id=Cg.CursantId
	where GrupaId is null

	
	--selecteaza toti cursantii care  au participat la M1 (varianta cu Right join)

	select*
	from Cursant C right join CursantGrupa Cg
	on C.Id=Cg.CursantId
	where GrupaId=1

	--selecteaza toti cursantii care  au participat la M1 (varianta cu 3 inner join)

	--selectati toti cursantii
	
	select*
	from Cursant

	--selectati numarul total al cursantilor (agregare)

	select
	Count(*) NrTotalCursanti
	from Cursant


	--selectati toti cursantii din Romania

	select*
	from Cursant
	where Tara='Romania'

	--selectati nr cursantilor din Romania (agregare + grupare)

	select
	count(*) NrCursantiDinRomania
	from Cursant
	where Tara='Romania'


	--selectati toti cursantii a caror nota este mi mare de 7

	select
	CursantId,
	C.Nume,
	Cg.CursantId,
	Cg.NotaFinala
	
	from CursantGrupa Cg inner join Cursant C
	on C.Id=Cg.CursantId
	where NotaFinala > 7

	--calculati media notelor tuturor cursantilor (agregare)

	select
	avg(NotaFinala) MediaNotelorCursantilor
	from CursantGrupa

	--calculati media notelor ptr fiecare cursant (agregare+grupare)

	
	select
	CursantId,
	avg(NotaFinala) MedieCursant
	from CursantGrupa
	group by CursantId
	






	
	