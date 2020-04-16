
	USE Clienti
	go

	INSERT INTO Client
	(ID, Nume, Prenume, Email)
	values
	('1', 'Ionescu', 'Vasile', 'ionescu@gmail.com')

	INSERT INTO Client
	(ID, Nume, Prenume, Email)
	values
	('2', 'Popescu', 'Ion', 'popescu@gmail.com')

	INSERT INTO Client
	(ID, Nume, Prenume, Email)
	values
	('3', 'Sava', 'Ion', 'sava@gmail.com')

	INSERT INTO Client
	(ID, Nume, Prenume, Email)
	values
	('4', 'Popa', 'Vlad', 'popa@gmail.com')

	
	
	
	INSERT INTO Factura
	(ID, DataEmiterii, Valoare, DataScadentei)
	values
	('1', '07.04.2020', '200', '07.05.2020')

	INSERT INTO Factura
	(ID, DataEmiterii, Valoare, DataScadentei)
	values
	('1', '07.04.2020', '200', '07.05.2020')


	INSERT INTO Produs
	(ID, Denumire, Descriere, Pret, Stoc)
	values
	('1', 'Ciocolata', 'Lapte', '60', '35')

	UPDATE Client Set
	Nume = 'Georgescu'
where Id = 2

	UPDATE Produs Set
	Pret = 6
where Id = 4

	DELETE FROM Factura
where Id = 1


	DELETE FROM Factura
where Id = 2

	select Nume, Prenume
from Client

	select *
from Client

	select Denumire, Pret
from Produs


	