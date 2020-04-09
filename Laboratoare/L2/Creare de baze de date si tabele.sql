-- crearea bazei de date
CREATE DATABASE Curs2

--redenumirea bazei de date
ALTER DATABASE Curs2 Modify Name = Curs

--sterge baza de date
DROP DATABASE Curs

-- schimba baza de date curenta (cu care lucrez)
USE Curs

-- crearea unei tabele/tabel/(table)
CREATE TABLE Cursant
(
	ID INT Primary Key,
	Nume nvarchar(50) NOT NULL,
	Prenume nvarchar(50),
	DataNasterii date,
	CursuriParcurse int
)

-- crearea unei tabele intr-o baza de date specificata
create table Curs.dbo.Cursuri 
(
	ID INT Primary key,
	Denumire nvarchar(50) NOT NULL,
	Descrire nvarchar(250)
)

-- adaugarea unei coloane la tabel
ALTER TABLE Cursant
	ADD Email int

-- stergerea unei coloane din tabel
ALTER TABLE Cursant
	DROP COLUMN Email

-- modificarea tipului de coloana
alter table cursant
	alter column email nvarchar(100)

-- creaza tabela fara Cheie primara (PK)
create table Curs.dbo.Cursuri2 
(
	ID INT,
	Denumire nvarchar(50) NOT NULL,
	Descrire nvarchar(250)
)

-- setam coloana ID not null
alter table cursuri2
	alter column id int not null

-- setez cheie primara (PK)
alter table Cursuri2
	ADD primary key (ID)

-- adauga coloana de legatura in tabela cursant
alter table cursant
	add CursID int

-- setare cheie straina/ foreign key (FK)
alter table cursant					-- ce tabela modifica
	add foreign key (cursid)		-- ce camp devine FK
	references cursuri(denumire)			-- din ce tabela vine FK si care este aceasta *campul trebuie sa fie PK in tabela din care vine

-- setare FK oracle
ALTER TABLE products
ADD CONSTRAINT fk_supplier
  FOREIGN KEY (supplier_id)
  REFERENCES supplier(supplier_id);

-- sterge un tabel
drop table Cursuri2

-- create tabel oracle
CREATE TABLE customers
( 
  customer_id int NOT NULL,
  customer_name varchar(50) NOT NULL,
  city varchar(50)
)