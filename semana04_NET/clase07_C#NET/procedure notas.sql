Create PROCEDURE spadiAlu(@ape varchar(30),@nom varchar(30),@es char(3), @pro char(1))
as
begin
declare @coda char(5)
declare @cuenta int
select @cuenta=right(max(idalumno),4)+1 from alumno
set @coda='A'+ right('000'+ltrim(@cuenta),4)
insert into alumno values(@coda, @ape,@nom,@es,@pro)
end

go
Create PROCEDURE spmodiAlu(@cod char(5),@ape varchar(30),@nom varchar(30),@es char(3), @pro char(1))
as
begin
update alumno set apealumno=@ape, nomalumno=@nom,
idesp=@es, proce=@pro where idalumno=@cod
end

go
create PROCEDURE spDelAlu(@coda char(5))
as
begin
delete from alumno where idalumno=@coda;
end

go 
create procedure spnota(@cod char(5))
as
begin
select c.idcurso, nomcurso, exaparcial, exafinal, prom=(exaparcial+exafinal)/2,
obser=case
when (exaparcial+exafinal)/2>=12 then 'Aprobado'
else  'Desaprobado'
end
from curso c , notas n where c.idcurso=n.idcurso and idalumno=@cod
end

go

create procedure spcurso(@cod char(4))
as
begin
select a.IdAlumno, ApeAlumno, NomAlumno, exaparcial, exafinal, prom=(exaparcial+exafinal)/2, 
obser=case
when (exaparcial+exafinal)/2>=12 then 'Aprobado'
else  'Desaprobado'
end
from Alumno a, NOTAS n where a.IdAlumno=n.IdAlumno and IdCurso=@cod
end

















end

