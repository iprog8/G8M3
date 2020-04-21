-- crearea bazei de date
CREATE DATABASE CLIENTI
go

-- folosirea bazei de date creata
use CLIENTI
go

-- crearea unei tabele/tabel/(table)
create table Client
(
	ID INT PRIMARY KEY IDENTITY(1,1),   -- ID setat ca primary key --> not null
	Nume nvarchar(50) NOT NULL,         -- setarea unei coloane not null
	Prenume nvarchar(50) NOT NULL,
	Email nvarchar(50),
	Telefon nvarchar(15) NOT NULL,
	Adresa nvarchar(250)
)
go
create table Produs
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Denumire nvarchar(250) NOT NULL,
	Descriere nvarchar(250) NOT NULL,
	Pret nvarchar(10) NOT NULL,
	Stoc nvarchar(10) NOT NULL
)
go
create table Factura
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Seria_NR nvarchar(30) NOT NULL,
	Data_Emiterii date,
	Nume_Firma nvarchar(100) NOT NULL,
	Nume_Beneficiar nvarchar(100) NOT NULL,
	Produs nvarchar(50) NOT NULL,
	Cantitate int,
	Pret_unitar_faraTVA nvarchar(20) NOT NULL,
	Valoarea nvarchar(20) NOT NULL,
	Valoarea_TVA nvarchar(20) NOT NULL
)

-- adaugare coloana de legatura in tabela Produs
alter table Produs
	add ProdusID int NOT NULL
go

-- setare cheie straina/ foreign key (FK)
alter table Produs				
	add foreign key (ProdusID)		
	references Produs(ID)