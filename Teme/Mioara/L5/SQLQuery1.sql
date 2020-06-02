use crm
go
--selecteaza toti clientii care nu au facut nicio comanda
select 
	C.Id as CustomerId,
	C.FirstName + ', ' + C.LastName as [Name],
	O.Id as OrderId
from Customer C left join [Order] O on  C.Id=O.CustomerId
where TotalAmount is null

--selecteaza toate produsele care nu au fost incluse pe nicio comanda	
select
P.Id as ProductId,
P.ProductName,
Oi.OrderId
from Product P inner join OrderItem Oi
on P.Id=Oi.ProductId
where OrderId is null

--inner join 1 intre tabela produs si tabela OrderItem 
select
P.Id as ProductId,
Oi.Id as OrderItemId,
P.ProductName,
P.SupplierId,
P.UnitPrice,
P.Package, 
P.IsDiscontinued,

Oi.OrderId,
Oi.ProductId,
Oi.UnitPrice,
Oi.Quantity
from Product P inner join OrderItem Oi
on P.Id=Oi.ProductId 

--inner join 2 intre tabela produs si tabela OrderItem 
select*
from Product P inner join OrderItem Oi
on P.Id=Oi.ProductId 

 --inner join 1 intre tabela Customer si tabela Order
 select*
 from Customer C inner join [Order] O
 on C.Id=O.CustomerId

  --inner join 2 intre tabela Customer si tabela Order
 select
 C.Id as CostumerId,
 C.FirstName,
 C.LastName,
 C.City,
 C.Country,
 C.Phone,
 O.Id as OrderID,
 O.OrderDate,
 O.OrderNumber,
 O.CustomerId,
 O.TotalAmount
 from Customer C inner join [Order] O
 on C.Id=O.CustomerId

 --inner join intre Customer si OrderItem

 select*
 from [Order] O inner join OrderItem Oi
 on O.Id=Oi.OrderId

 --inner join 2 intre tabela Order si tabela OrderItem
 select
 O.Id as OrderId,
 O.OrderDate,
 O.OrderNumber,
 O.CustomerId,
 O.TotalAmount,
 Oi.Id as OrderItemId,
 Oi.OrderId,
 Oi.ProductId,
 Oi.UnitPrice,
 Oi.Quantity
 
 from [Order] O inner join OrderItem Oi
 on O.Id=Oi.OrderId


 



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
	NumarOre nvarchar(50) NOT NULL, 
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

