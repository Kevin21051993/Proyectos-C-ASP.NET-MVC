use BDCLINICA2
go
select * from Citas;
select * from Medicos;
select * from tabesp;


USE BDCLINICA2
GO

Create PROCEDURE sp_AdiCita(@codMed char(4),@nomPac varchar(40),@tipo int, @costEsp numeric(6,1))
as
begin

declare @pago int
declare @nroCita int
select @nroCita=max(nrocita) from Citas
SET @nroCita=@nroCita+1;

SET @pago=case
when @tipo=1 then @costEsp
when @tipo=2 then @costEsp*0.8
when @tipo=3 then @costEsp*0.5
end

insert into Citas values(@nroCita, @codMed,@nomPac,@tipo,@pago)

end