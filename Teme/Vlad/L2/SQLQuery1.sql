--create database Clienti

-- use clienti 

create table Client (
	Nume nvarchar(50) not null,
	Prenume nvarchar(50),
	Email nvarchar(250),
	Telefon int not null,
	Adresa text);

create table Produs (
	Id INT Primary Key,
	Denumire nvarchar(50),
	Descriere nvarchar(100),
	Pret Money,
	Stoc int);

create table Factura (
	Data_emisa date,
	Numar_Factura int,
	Client_Id int Not null,
	Valoare_lei Money );

alter database Clienti
	modify name = Firma1

alter table Client
	add ID INT PRIMARY KEY;

alter table Factura
	Add FOREIGN KEY (Client_ID) References Client(Id);
	

	