	
	CREATE DATABASE Clienti

	USE Clienti

	CREATE TABLE Client
(
	ID INT Primary Key,
	Nume nvarchar(50) NOT NULL,
	Prenume nvarchar(50) NOT NULL, 
	Email nvarchar(20),
	Telefon nvarchar(15),
	Adresa nvarchar(50)

)

	CREATE TABLE Produs
(
	ID INT Primary Key,
	Denumire nvarchar(50) NOT NULL,
	Descriere nvarchar(50) NOT NULL, 
	Pret int NOT NULL,
	Stoc int NOT NULL
)
	CREATE TABLE Factura

(	ID INT Primary Key,
	DataEmiterii nvarchar(50),
	Valoare nvarchar(50),
	DataScadentei nvarchar(50),
	Client nvarchar(50)
	)
	
	DROP TABLE Produse

	 