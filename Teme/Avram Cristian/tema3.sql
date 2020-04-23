use CRM
go

--3.Faceti un inner join intre tabela Produs si tabela OrderItem;
select *
from Product P inner join OrderItem O
	on P.Id = O.ProductId
--4.Faceti un inner join intre tabela Client si tabela Order;
select *
from Customer C inner join [Order] O
	on C.Id = O.CustomerId
--5.Faceti inner join intre tabela Client si tabela OrderItem.
select *
from Customer C inner join 
	[Order] O on C.Id = O.CustomerId inner join 
	OrderItem Oi on O.Id = Oi.OrderId

select *
from Customer C inner join [Order] O
	on C.Id = O.CustomerId
	where O.OrderNumber is null

--1 Selectati toti clientii care nu au facut nici o comanda. Hint: Left/Right Join.
--Logica mea ma indreapta la urmatorul rationament: am tabela "Customer"(cerinta fiind legata de "selecteaza toti clientii" si o alta tabela. Nu stiu cu care sa fac join-ul.
--Ceea ce ma gadesc este ca trebuie sa joinez de asmenea natura incat sa pot conditiona cu where OrderNumer is null sau OrderItemID is null.
--Doar ca acesta nu poate fi null. :) Deci ramane sa joinez cumva ca sa am acces la Ordernumber. Am incercat sa fac join intre Customer si Order
--ca sa conditionez cu where OrderNumber is null. Dar query-ul nu-mi mai intoarce nimic.:)
