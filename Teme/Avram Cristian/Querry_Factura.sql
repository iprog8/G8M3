create database clienti
use clienti
create table client
(
ID int Primary Key,
nume nvarchar(50),
prenume nvarchar(50),
email nvarchar(50),
telefon nvarchar(20),
adresa nvarchar(300)
)

create table produs
(
ID int Primary Key,
denumire nvarchar(50),
descriere nvarchar(50),
pret int,
stoc int
)

create table factura
(
ID int Primary Key not null,
ClientID int not null,
ProdusID int not null,
DataEmitereFactura date,
TermenDePlata int

)

alter table factura
	add foreign key (ClientID)
	references client(id)

alter table factura
	add foreign key (ProdusID)
	references produs(id)
