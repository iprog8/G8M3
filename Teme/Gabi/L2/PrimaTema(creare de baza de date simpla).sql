--creare baza de date
create database Clienti

-- mutare pe baza de date creata 
use Clienti

-- creare tabele
create table Client 
(
	ID int Primary Key not null,
	Nume nvarchar(50) not null,
	Prenume nvarchar(50),
	Telefon nvarchar (15),
	Adresa nvarchar(250),
)

create table Produs 
(
	ID int Primary Key not null,
	Denumire nvarchar(50) not null,
	Descriere nvarchar(100),
	Pret money,
	Stoc int,
)

create table factura 
(
	ID int Primary Key not null,
	DataEmisa date not null,
	DataScadenta date not null,
	Perioada date,
	Suma money,
)



