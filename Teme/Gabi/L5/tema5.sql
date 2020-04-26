use crm 
go

--punctul 1
select 
O.Id as OrderId,
O.OrderNumber,
O.OrderDate,
C.Id as CustomerId,
C.FirstName + ' ' + C.LastName as [Name]
from Customer C left join [Order] O on O.CustomerId = C.Id
where O.Id is null
go

--punctul 2
--aici nu am stiut care produse nu sunt incluse pe nici o comanda si m am luat dupa 'isdicountinued'
select 
P.ProductName,
P.IsDiscontinued,
Oi.ProductId
from Product P left join OrderItem Oi on Oi.ProductId = P.Id
where Oi.Id is null
go

--punctul 3
select 
P.Id as ProductId,
P.ProductName,
P.UnitPrice,
Oi.Quantity,
Oi.UnitPrice
from Product P inner join OrderItem Oi on Oi.ProductId = P.Id
go

--punctul 4
select
C.FirstName + ' ' + C.LastName as [Name],
C.City + ' ' + C.Country as [Location],
O.OrderDate,
O.OrderNumber
from Customer C inner join [Order] O on C.Id = O.CustomerId
go

-- punctul 5
select
C.Id,
C.FirstName + ' ' + C.LastName as [Name],
C.City + ' ' + C.Country as [Location],
O.OrderDate,
O.OrderNumber,
Oi.Quantity,
Oi.UnitPrice
from Customer C inner join [Order] O on C.Id = O.CustomerId inner join OrderItem Oi on O.Id = OI.OrderId
order by C.Id
go
