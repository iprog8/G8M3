USE IPRO
Go

--selecteaza toti cursantii care au participat la M1

select 

M.Denumire,
G.ModulID,
Cg.CursantId,
C.Nume,
C.Id

from Modul M inner join Grupa G
on M.Id=G.ModulID inner join CursantGrupa Cg
on G.Id=Cg.GrupaID inner join Cursant C
on C.Id=Cg.CursantID
where ModulId=1

