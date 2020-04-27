Use Firma1
Go

alter table Client
	alter column Telefon nvarchar(250) not null;
go
alter table Client
	alter column Adresa nvarchar(250) not null;
go

alter table Factura
	add ProdusId int not null Foreign Key
	references Produs(Id)
go

sp_rename 'Factura.Data_emisa', 'DataEmisa', 'COLUMN' ; 
go
sp_rename 'Factura.Numar_Factura', 'NrFactura', 'COLUMN' ; 
go
sp_rename 'Factura.Valoare_lei', 'ValoareLei', 'COLUMN' ; 
go
sp_rename 'Factura.Client_Id', 'ClintId', 'COLUMN' ; 
go
sp_rename 'Factura.ClintId', 'ClientId', 'COLUMN' ; 
go

sp_rename 'Factura.NrFactura', 'Id', 'COLUMN';

alter table Factura
	alter column Id int not null;

alter table Factura
	Add Primary Key (ID);


alter table Client
	alter column Adresa nvarchar(250) null;

alter table Client
	alter column Telefon nvarchar(250) null;

insert into Client (Nume,Prenume,ID)
	values
	('Popescu','Mircea',1),
	('Ionescu','Sebastian',2),
	('Popa','Andrei',3),
	('Baciu','Sergiu',4);
go


insert into Produs (Id,Denumire,Pret,Stoc)
	values 
	(1,'Bere',5,1000),
	(2,'Whiskey',100,500),
	(3,'Cognac',120,375),
	(4,'Sampanie',300,220);
go
select * from Produs;
go

insert into Factura (Id,ClientId,ValoareLei,ProdusId)
	values
	(1,1,200,2),
	(2,2,50,1),
	(3,3,1200,3),
	(4,4,700,2);
go

select * from Client;
go
select * from Produs;
go
select * from Factura;
go

update Client
	set Nume = 'Marinescu'
	where ID = 2;

update Produs
	set Pret = 250
	where id = 4;

Delete from Factura
	where Id = 1 or Id = 2;

Select Denumire,Pret from Produs;
