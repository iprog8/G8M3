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

	CREATE TABLE Modul
(
	ID INT Primary Key,
	Denumire nvarchar(50) NOT NULL,
	NumarOre int NOT NULL, 
	ZileCoddingNOT int NOT NULL
	
)
	CREATE TABLE Grupa

(	ID INT Primary Key,
	ModulID int NOT NULL,
	Denumire nvarchar(50) NOT NULL,
	DataStart date NOT NULL,
	DataStartCodding date NOT NULL

	)

	CREATE TABLE IPRO.dbo.CursantGrupa

(	ID INT Primary Key,
	CursantID int NOT NULL,
	GrupaID int NOT NULL,
	Denumire nvarchar(50) NOT NULL,
	NotaFinala int NOT NULL,
	Continua bit  NOT NULL

	)
	-- seteaza FK
	
	ALTER TABLE Grupa
	ADD foreign key (ModulId)
	REFERENCES Modul (Id)


	ALTER TABLE CursantGrupa
	ADD foreign key (CursantId)
	REFERENCES Cursant(Id)


	ALTER TABLE CursantGrupa
	ADD foreign key (GrupaId)
	REFERENCES Grupa(Id)

	--selecteaza toate grupele de M1

	select 
	G.Id as GrupaId,
	G.Denumire,
	G.ModulId,
	M.Id as ModulId,
	M.Denumire

	from Grupa G inner join 
	Modul M on M.Id = G.ModulId

	--selecteaza toti cursantii de la grupa G8M2

	select


	from 



	
	