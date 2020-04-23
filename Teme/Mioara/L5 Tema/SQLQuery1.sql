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




