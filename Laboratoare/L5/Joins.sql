use crm
go

-- inner join simplu
select * -- * = toate coloanele
from Supplier S inner join 
Product P on S.Id = P.SupplierId

-- inner join cu selectare de coloane
select 
	S.Id as SupplierIdFromSupplier,
	P.SupplierId,
	P.Id as ProductId,
	S.CompanyName,
	P.ProductName,
	P.UnitPrice
from Supplier S inner join 
Product P on S.Id = P.SupplierId

-- alt exemplu de inner join
select * 
from Customer C inner join 
	[Order] O on C.Id = O.CustomerId

-- exemplu gresit de inner join
select * 
from Customer C inner join
	Supplier S on C.Id = S.Id

-- selectam produsele cumparate de un client cu ID-ul 1 (3 inner joins)
select
	C.Id as CustomerId,
	C.FirstName + ', ' + C.LastName as [Name],
	--O.Id as OrderId,
	--O.OrderNumber,
	P.Id,
	P.ProductName
from Customer C inner join
	[Order] O on C.Id = O.CustomerId inner join
	OrderItem Oi on O.Id = Oi.OrderId inner join
	Product P on P.Id = Oi.ProductId

order by C.Id, Oi.ProductId 


-- selectam produsele cumparate de un client cu ID-ul 1 (3 inner joins)
select
	O.Id as OrderId,
	O.OrderNumber,
	O.OrderDate,
	P.Id as ProductId,
	P.ProductName
from [Order] O inner join
	OrderItem Oi on O.Id = Oi.OrderId inner join
	Product P on P.Id = Oi.ProductId
order by O.Id, Oi.ProductId 

-- selectam produsele cumparate de un client cu ID-ul 1 (3 inner joins) fara alias-uri
select
	[Order].Id as OrderId,
	[Order].OrderNumber,
	[Order].OrderDate,
	Product.Id as ProductId,
	Product.ProductName
from [Order] inner join
	OrderItem on [Order].Id = OrderItem.OrderId inner join
	Product on Product.Id = OrderItem.ProductId
order by [Order].Id, OrderItem.ProductId 

-- left join cu selectare de coloane
select 
	S.Id as SupplierIdFromSupplier,
	S.CompanyName,
	P.*
from Supplier S left join Product P on S.Id = P.SupplierId


-- righ join cu selectare de coloane
select 
	S.Id as SupplierIdFromSupplier,
	S.CompanyName,
	P.*
from Product P right join Supplier S on S.Id = P.SupplierId