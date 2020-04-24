-- numararea randurilor
select 
	count(*) NumberOfCustomers 
from Customer

-- media comenzilor
select 
	avg(totalAmount)
from [Order]

--comanda cea mai mica
select
	min(totalamount)
from [Order]

-- cea mai mare comanda
select 
	max(totalamount)
from [Order]

-- count cu distinct
select 
	count(distinct CustomerId) Clienti
from [Order]

--totalul vanzarilor
select
	sum(TotalAmount)
from [Order]

-- agregarile intr-o singura interograre
select 
	count(*) NumarComenzi,
	count(distinct CustomerId) Clienti,
	count(*) / count(distinct CustomerId) MediaDeComenziPeClient,
	avg(totalAmount) ComandaMedie,
	min(totalamount) [Comanda Minima],
	max(totalamount) 'Comanda maxima',
	sum(TotalAmount) as VanzariTotale
from [Order]

select 
	count(distinct CustomerId) Clienti
from [Order]

-- group by
select 
	CustomerId,
	COUNT(CustomerId) as NumarComenzi,
	avg(totalamount) as ComandaMediePeClient,
	sum(totalamount) as SumaCheltuita
from [Order]

group by customerid
order by CustomerId


-- group by
select
	CustomerId,
	COUNT(Id) as NumarComenzi
from [Order]

group by customerid
order by CustomerId

-- group by
select
	OrderDate,
	COUNT(Id) as NumarComenzi
from [Order]

group by OrderDate
order by CustomerId

-- selectarea numarului de clienti pe fiecare tara (grupati pe tara)
select 
	Country,
	count(Country) as CsutomersFromCountry
from Customer
group by Country

-- having e folosit doar pentru functii de agregare
-- selectarea numarului de clienti pe fiecare tara (grupati pe tara)
select 
	Country,
	count(Country) as CsutomersFromCountry
from Customer
--where Country = 'USA'
group by Country
having count(country) > 10

-- functia scalara upper
select 
	id,
	FirstName,
	UPPER(LastName) as LastName2
from Customer

-- functia scalara upper 2
select 
	id,
	FirstName + ', ' + UPPER(LastName) as LastName2
from Customer

-- select left / right
select LEFT('hai sa mai facem o bauta', 8) + '...'
select  '...' + RIGHT('hai sa mai facem o bauta', 8)

-- date functions
select 
	OrderDate as DataCurenta,
	Datepart(year, OrderDate) as [Year],
	Datepart(MONTH, OrderDate) as [Month]
from [Order]

-- date functions
select 
	Datepart(year, OrderDate) as [Year],
	sum(TotalAmount) as Vanzari
from [Order]
group by Datepart(year, OrderDate)
order by [year]

-- date functions
select 
	Datepart(MONTH, OrderDate) as MONTH,
	sum(TotalAmount) as Vanzari
from [Order]
group by Datepart(MONTH, OrderDate)
order by MONTH

-- functii de conversie
select 
	TotalAmount,
	Cast(TotalAmount as int) as TotalAmountInt,
	Cast(TotalAmount as varchar) as TotalAmountText
from [Order]

select Cast(15.85 as varchar)
select cast('2020-04-23' as datetime)