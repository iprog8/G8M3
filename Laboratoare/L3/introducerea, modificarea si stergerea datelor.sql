--setam baza de date pe care lucram
use crm
go

--introduce date in tabela customer
INSERT INTO Customer
	(FirstName, LastName, City, Country, Phone)
values
	('Ion', 'Popescu', 'Bucuresti', 'Romania', '07...')

--introduce date in tabela customer fara specificare de campuri
INSERT INTO Customer
values
	('Maria', 'Popa', 'Bucuresti', 'Romania', '07...')
	
--introduce date in tabela customer doar cu coloanele obligatorii
INSERT INTO Customer
	(FirstName, LastName)
values
	('Dan', 'Popa')
	
--introduce date in tabela customer in ordine random
INSERT INTO Customer
	(FirstName, LastName, Country)
values
	('Dana', 'Popescu', 'Romania')


--modificare date in tabela customer dupa id
UPDATE Customer Set
	FirstName = 'Ioan',
	LastName = 'Dumitrescu'
where Id = 92

--modificare date in tabela customer dupa id
UPDATE Customer Set
	FirstName = 'Mara'
where Id = 93

--
update Customer  set
	City = 'Constanta'

where FirstName = 'Dan' and
	LastName = 'Popa'

-- sterge din tabela customer dupa id
DELETE FROM Customer
where Id = 94

-- seterge din tabela customer mai multe inregistrari
delete from customer
where FirstName = 'dana' and
	LastName = 'popescu'

-- da-mi toate datele din tabela customer
select *
from Customer

-- selectare anuminte randuri: clientii din franta
select *
from Customer
where Country = 'France'

-- selectam anuminte coloane: FirstName, LastName, Country
select FirstName, LastName, Country
from Customer

-- selectam anumite coloane si randuri
select FirstName, LastName, City
from Customer
where Country = 'France'

-- delete from OrderItem

