use crm
go

select * 
from Customer
where Id = 999


--4.Faceti un inner join intre tabela Customer si tabela Order
select *
from [Order] inner join Customer
	on [Order].CustomerId = Customer.Id

--5.Faceti inner join intre tabela Customer si tabela OrderItem
select *
from [Order] inner join Customer
	on [Order].CustomerId = Customer.Id
	inner join OrderItem
	on [Order].Id = OrderItem.OrderId

--1. selectati toti clientii care nu au facut nici o comanda
select *
from Customer left join [Order]
	on Customer.Id = [Order].CustomerId
where [Order].Id is null

--2. selectati toti produsele care nu au fost incluse pe nici o comanda
select *
from Product left join OrderItem
	on Product.Id = OrderItem.ProductId
where [OrderItem].Id is null