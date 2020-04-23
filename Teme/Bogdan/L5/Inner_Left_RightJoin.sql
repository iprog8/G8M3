--1. Selectarea tuturor clientilor care nu au facut nici o comanda

use CRM
go
select 
C.FirstName + ' ' + C.LastName as [Name],
O.OrderDate
from Customer C left join 
[Order] O on C.Id = O.CustomerId
where OrderDate is NULL


--2. Selectarea tuturor produselor care nu au fost incluse pe nici o comanda

use CRM
go
select
P.ProductName,
Package,
Quantity
from Product P left join 
OrderItem Oi on P.Id = Oi.ProductId
where Quantity is NULL


--3. inner join intre tabela Produs si tabela OrderItem

use CRM
go
select * 
from Product P inner join 
OrderItem Oi on P.Id = Oi.ProductId


--4. inner join intre tabela Client si tabela Order

use CRM
go
select 
CustomerId as [ID Client],
C.FirstName + ' ' + C.LastName as [Nume],
C.City + ' ' + C.Country as [Locatie],
O.OrderDate as [Data comenzii],
O.OrderNumber as [Nr. Comenzii]
from Customer C inner join 
[Order] O on C.Id = O.CustomerId


--5.  inner join intre tabela Client si tabela OrderItem

use CRM
go
select 
CustomerId as [ID Client],
C.FirstName + ' ' + C.LastName as [Nume],
C.City + ' ' + C.Country as [Locatie],
O.OrderDate as [Data comenzii],
O.OrderNumber as [Nr. Comenzii],
Oi.UnitPrice as [Pret],
Oi.Quantity as [Cantitate]
from Customer C inner join 
[Order] O on C.Id = O.CustomerId inner join
OrderItem Oi on O.Id = Oi.OrderId
order by CustomerId


