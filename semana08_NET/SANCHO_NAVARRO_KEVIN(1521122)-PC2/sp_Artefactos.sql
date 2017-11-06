use bdArtefacto
go
--select * from Linea
select * from Artefacto
select * from Clientes
select * from proforma
delete from proforma

-------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_ArtefactosxLinea(@CODLIN char(2))
AS
BEGIN
SELECT * FROM Artefacto WHERE Lin_cod=@CODLIN
END
GO
-------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_Adi_Cli(@NOM varchar(25), @TEL numeric(7,0), @RUC numeric(11,0), @DIREC varchar(30))
AS
BEGIN
DECLARE @CODCLI CHAR(5), @CUENTA INT
SELECT @CODCLI=ISNULL(MAX(cli_cod),'0000') FROM Clientes
SET @CUENTA=RIGHT(@CODCLI,4)+1
SET @CODCLI='C'+RIGHT('0000'+LTRIM(@CUENTA),4)
INSERT INTO Clientes VALUES(@CODCLI,@NOM,@TEL,@RUC,@DIREC)
END
GO
-------------------------------------------------------------------------------------
/*
use bdArtefacto
go
exec sp_Adi_Cli 'Sancho Navarro Kevin', 9918122, 10000758675, 'Av.Huanacaure 365 Tahuantinsuyo'
*/
-------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_Modi_Cli(@COD char(5), @NOM varchar(25), @TEL numeric(7,0), @RUC numeric(11,0), @DIREC varchar(30))
AS
BEGIN
UPDATE Clientes
SET cli_nom=@NOM, cli_tel=@TEL, cli_ruc=@RUC, cli_dir=@DIREC
WHERE cli_cod=@COD
END
GO
-------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_Elim_Cli(@COD char(5))
AS
BEGIN
DELETE Clientes WHERE cli_cod=@COD
END
GO
----------------------------------------------------------------------------------------
--Probando
--use bdArtefacto
--go
--exec sp_Modi_Cli 'C0022', 'Sanchez Barrasa Tumia', 5554466, 10000018453, 'Av. Las Gardeniaz Tumbes Peru'
--exec sp_Elim_Cli 'C0022'
----------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_Adi_Prof(@CODCLI char(5), @CODART char(5), @PREC numeric(11,0), @TIPVEN varchar(1))
AS
BEGIN
DECLARE @NROPRO CHAR(5), @CUENTA INT
SELECT @NROPRO=ISNULL(MAX(nro_pro),'0000') FROM proforma
SET @CUENTA=RIGHT(@NROPRO,4)+1
SET @NROPRO='P'+RIGHT('0000'+LTRIM(@CUENTA),4)
INSERT INTO proforma VALUES(@NROPRO,@CODCLI,@CODART,@PREC,@TIPVEN)
END
GO
----------------------------------------------------------------------------------------
--Probando sp_Adi_Prof()--
/*
use bdArtefacto
go


exec sp_Adi_Prof 'C0009','A0005', 1790, 'A'
exec sp_Adi_Prof 'C0004','A0012', 790, 'C'
exec sp_Adi_Prof 'C0007','A0008', 190, 'B'
exec sp_Adi_Prof 'C0013','A0020', 420, 'B'
exec sp_Adi_Prof 'C0018','A0002', 1200, 'A'
exec sp_Adi_Prof 'C0004','A0012', 790, 'B'
*/

----------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_ListarProfConFormato(@VAR int)
AS
BEGIN
SELECT nro_pro, cli_cod, art_cod, precio, meses= case
											when tipo_ven='A' then 6
											when tipo_ven='B' then 12
											when tipo_ven='C' then 18
											end
FROM proforma
END
GO
----------------------------------------------------------------------------------------
use bdArtefacto
go
CREATE PROCEDURE sp_ListarProfConFormato2(@CODCLI char(5))
AS
BEGIN
SELECT nro_pro, cli_cod, art_cod, precio, meses= case
											when tipo_ven='A' then 6
											when tipo_ven='B' then 12
											when tipo_ven='C' then 18
											end, interes= case
											when tipo_ven='A' then 0.10*precio
											when tipo_ven='B' then 0.18*precio
											when tipo_ven='C' then 0.25*precio
											end,saldo= case
											when tipo_ven='A' then 1.10*precio
											when tipo_ven='B' then 1.18*precio
											when tipo_ven='C' then 1.25*precio
											end
FROM proforma
WHERE cli_cod=@CODCLI
END
GO
----------------------------------------------------------------------------------------
--Probando sp_ListarProfConFormato2
/*
use bdArtefacto
go
exec sp_ListarProfConFormato2 'C0009'
*/




