--creare baza de date
create database Clienti
go
-- mutare pe baza de date creata 
use Clienti
go
-- creare tabele
create table Client 
(
	ID int Primary Key not null Identity(1,1),
	Nume nvarchar(50) not null,
	Prenume nvarchar(50),
	Telefon nvarchar (15),
	Adresa nvarchar(250),
)
go
create table Produs 
(
	ID int Primary Key not null Identity(1,1),
	Denumire nvarchar(50) not null,
	Descriere nvarchar(100),
	Pret money,
	Stoc int,
)
go
create table factura 
(
	ID int Primary Key not null Identity(1,1),
	DataEmisa date not null,
	DataScadenta date not null,
	Perioada date,
	Suma money,
)
go
