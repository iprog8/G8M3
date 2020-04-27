select * from Customer 
go
-- Selectati toti clientii care nu au facut nici o comanda
select 
	Cs.FirstName + ' ' + Cs.LastName as [Name],
	Cs.Id as CustomerId,
	Ord.Id as OrderId,
	Ord.TotalAmount
from Customer Cs left join
[Order] Ord on	Cs.Id = Ord.CustomerId
where Ord.CustomerId is Null
order by Ord.CustomerId

--Selectati toate produsele care nu au fost incluse pe nici o comanda
select
	Prd.Id as ProductId,
	Prd.ProductName,
	OI.OrderID as OrderID,
	OI.id as OrderItemID
from Product Prd left join
OrderItem OI on	Prd.Id = OI.ProductId
where OI.ProductId is null
order by ProductID

-- Faceti un inner join intre tabela Produs si tabela OrderItem;
select *
from Product Prd inner join
	OrderItem OI on	Prd.Id = OI.ProductId
order by ProductID

-- Faceti un inner join intre tabela Client si tabela Order;
select 
	Cs.FirstName + ' ' + Cs.LastName as [Name],
	Cs.Id as CustomerId,
	Ord.Id as OrderID,
	Ord.TotalAmount as Total
from Customer Cs inner join
	[Order] Ord on	CS.Id = Ord.CustomerId
order by CustomerID

-- Faceti inner join intre tabela Client si tabela OrderItem.
select 
	Cs.FirstName + ' ' + Cs.LastName as [Name],
	Cs.Id as CustomerId,
	Ord.Id as OrderID,
	Ord.TotalAmount as Total,
	OI.ID as OrderItemID,
	OI.ProductId as Product
from Customer Cs inner join
	[Order] Ord on	CS.Id = Ord.CustomerId inner join
	OrderItem as OI on Ord.Id = OI.Id
order by CustomerID