
--insert date dintr-o tabela existenta *tabelele trebuie sa existe
insert into ProductBackup ( ProductName, UnitPrice)
select ProductName, UnitPrice from Product

--crearea tabelei backup
create table ProductBackup (
	ProductName nvarchar(50),
	UnitPrice decimal(12,2)
)

--insert date bulk cu creare de tabel
select Id, UnitPrice, GETDATE() as 'LastDate'
INTO ProductPriceHistory
from Product

--insert date dintr-o tabela existenta *tabelele trebuie sa existe
insert into ProductPriceHistory ( Id, UnitPrice, LastDate)
select Id, UnitPrice, GETDATE() from Product

--=====================
--Clauza where

-- selecteaza toti clientii cu telefon necunoscut (Null)
select *
from Customer
where Phone is null

-- selecteaza toti clientii cu telefon cunoscut
select *
from Customer
where Phone is not  null

-- selecteaza clientii care incep cu litera a
select *
from Customer
where FirstName like 'a%'

-- selecteaza clientii care au penultima litera a si ultima litera necunoscuta
select * 
from Customer
where FirstName like '%a_'


-- selecteaza toate comenzile unde pretul este diferit de 440
select * 
from [Order]
where TotalAmount <> 440 -- != 

-- selecteaza toti clientii care nu sunt din USA
select * 
from Customer
where Country <> 'USA'

-- selecteaza toti clientii care nu sunt din USA sau UK
select * 
from Customer
where Country <> 'USA' and
	Country <> 'UK'

-- selecteaza toti clientii care sunt din USA sau Paris
select * 
from Customer
where Country = 'USA'
	or City = 'Paris'

-- selecteaza furnizorii din usa si canada care nu au fax
select * 
from Supplier
where (Country = 'usa'
	or Country = 'Canada')
	and fax is null

-- selecteaza furnizorii din usa si canada care nu au fax
select * 
from Supplier
where Country in ('usa', 'Canada', 'France')
	and fax is null

-- selectam toate comenzile mai mici de 400 lei
select *
from [Order]
where TotalAmount < 400


-- selectam toate comenzile mai mari de 600 lei
select *
from [Order]
where TotalAmount > 600

-- selectam toate comenzile intre 400 si 600
select * 
from [Order]
where TotalAmount >= 400
	AND TotalAmount <= 600
	
-- selectam toate comenzile intre 400 si 600
select * 
from [Order]
where TotalAmount between 400 and 600

-- folosirea aliasurilor pe tabele
select
	P.Id,
	P.ProductName,
	UnitPrice,
	SupplierId,
	Package,
	IsDiscontinued
from Product as P
where P.IsDiscontinued = 0

-- utilizarea alias-urilor pe coloane
select
	Product.Id as ProductId,
	ProductName,
	UnitPrice,
	UnitPrice * 0.3 as Profit,
	SupplierId,
	Package,
	IsDiscontinued
from Product
where IsDiscontinued = 0

-- ordonarea crescator dupa o coloana
select * 
from Customer
order by FirstName asc
--order by FirstName

-- ordonarea descrescator dupa o coloana
select * 
from Customer
order by FirstName desc

-- ordonarea descrescator dupa o coloana numerica
select * 
from Product
order by UnitPrice desc


-- ordonarea descrescator dupa doua sau mai multe coloane
select * 
from Customer
order by Country desc, City asc


-- afisare primelor 12 cele mai ieftine produse
select top 12 * 
from Product
order by UnitPrice asc
