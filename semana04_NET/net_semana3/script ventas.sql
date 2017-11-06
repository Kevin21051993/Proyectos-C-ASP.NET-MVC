  
-- SCRIPT  DE  IMPLANTACION  DE  BD.
-- MS SQL SERVER  
-- CREACION DE BASE DE DATOS  (DATA y LOG)
set dateformat dmy
USE master
IF EXISTS(SELECT * FROM sysdatabases WHERE name='bdventas')
    begin
	DROP DATABASE bdventas
	--GO
    end
go
CREATE DATABASE bdventas
GO

-- Comprobar los devices creados
sp_helpdb bdventas
USE bdventas
GO
-- Creacion de las Tablas
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME='Articulos' AND TYPE ='U')
    DROP table  Articulos

CREATE TABLE Articulos (
	art_cod char (5) NOT NULL Primary key,
	art_nom varchar (30) NULL ,
	art_uni char (4) NULL ,
	art_pre numeric(10, 2) NULL ,
	art_stk int NULL )
GO
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME='Clientes' AND TYPE ='U')
    DROP table  Clientes

CREATE TABLE Clientes (
	cli_cod char (5) NOT NULL Primary Key check(cli_cod like 'C[0-9][0-9][0-9][0-9]'),
	cli_nom varchar (35) NULL ,
	cli_tel char(8) null ,
	cli_cor varchar(30) NULL , --correo electronico
	cli_dir varchar (30) NULL,
        cli_cre Numeric(8,1) null )


GO
-- tambien se puede alterar la tabla cuando se ha creado
--Alter Table Clientes
--add
--CONSTRAINT CK_Cliente_Telefono CHECK (Cli_tel like '[2345][0-9][0-9]-[0-9][0-9][0-9][0-9]')

go
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME='Fac_Cabe' AND TYPE ='U')
    DROP table  Fac_cabe


CREATE TABLE Fac_cabe (
	fac_num char (5) NOT NULL Primary Key,
	fac_fec datetime NULL ,
	cli_cod char (5) NULL ,
	fac_igv char (1) NULL check(fac_igv in('S','N')),
        ven_cod int  )
GO

IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME='Fac_deta' AND TYPE ='U')
    DROP table  Fac_deta

CREATE TABLE Fac_deta (
	fac_num char (5) NOT NULL ,
	art_cod char (5) NOT NULL  ,
	art_can  int NULL , 
        Primary Key(Fac_num,art_cod))
GO
-- Ingreso de Data a las Tablas


IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME='vendedor' AND TYPE ='U')
    DROP table  Vendedor

CREATE TABLE Vendedor(
	Ven_cod int identity(1,1) not null primary key,
	Ven_nom varchar (25) NULL ,
	Ven_Fig datetime NULL --fecha de ingreso 
         )

go 
INSERT INTO clientes VALUES ('C0001','Alvarez Peña,Angel','123-4567','importa@hotmail.com','Av. La Marina 1234',3500)
INSERT INTO clientes VALUES ('C0002','Ponte Gomez, ALEJANDRO','658-4503','alex@yahoo.com','Av. Pardo 456  ',2800)
INSERT INTO clientes VALUES ('C0003','Zuñiga Mateo,Carlos','567-4566',null,'Av. Principal 123 ',1200)
INSERT INTO clientes VALUES ('C0004','Tucto de Souza,Bernardo','567-4566',null,'Av. Principal 123 ',1200)
INSERT INTO clientes VALUES ('C0005','Vilela Bustamante,Percy', null    , 'obando@hotmail.com','Calle San Pedro 134',600)
INSERT INTO clientes VALUES ('C0007','Montes Diaz, MIGUEL','567-8356','importa02@hotmail.com','Jr. Naranjos 5689',3100)
INSERT INTO clientes VALUES ('C0008','Rojas Gallo, Jorge','789-4568','importa22@yahoo.com','Av. Habich 543    ',2700)
INSERT INTO clientes VALUES ('C0009','Garcia La Riva,Guiliana','789-4073','conde@idat.com','Av. Iquitos 228   ',3400)
INSERT INTO clientes VALUES ('C0011','Wong Atoccsa, Isarrael','768-5704',null,'Calle Cueva 432   ',null)
INSERT INTO clientes VALUES ('C0012','Liñan Arias, FERNANDO',null     ,'redondo@hotmail.com','Av. Javier Prado 114',600)
INSERT INTO clientes VALUES ('C0013','Vergara Hidalgo, Jose','567-8466','importa03@hotmail.com','Jr. Pio XII 112   ',null)
INSERT INTO clientes VALUES ('C0014','Bustamante Moptta, Diego','567-4566',null,'Av. Principal 123 ',1200)
INSERT INTO clientes VALUES ('C0015','Alvarado Cueva, Guiliana','456-3457','campos@yahoo.com','Jr. Dominico 554',5000)
INSERT INTO clientes VALUES ('C0016','Antero Flores, Gregorio','746-0647','ramirez@idat.com','Jr. Salavery 876  ',2100)
INSERT INTO clientes VALUES ('C0017','Diaz Mal Partida,Jose','567-4566',null,'Av. Guardia Civil 123 ',1200)
INSERT INTO clientes VALUES ('C0018','Gutierrez Pazos , Mauricio','897-5783','importa04@hotmail.com','Av. Habich 4567   ',800)
INSERT INTO clientes VALUES ('C0019','Mendoza Ramirez, Ester','958-3569','importa05@yahoo.com','Av. Wilson 678    ',2600)
INSERT INTO clientes VALUES ('C0020','Salazar Santiago, Merlo','654-6534','pardo@walla.com','Av. Pardo 567     ',4100)
INSERT INTO clientes VALUES ('C0021','Carrasco Lee, Laura','267-8958','importa05@hotmail.com','Av. Wilson 1267   ',700)

INSERT INTO clientes VALUES ('C0022','Rosas La Riva,Guiliana','789-4073','conde@idat.com','Av. Iquitos 228   ',400)
INSERT INTO clientes VALUES ('C0023','Caceres Atoccsa, Isarrael','768-5704',null,'Calle Cueva 432   ',null)
INSERT INTO clientes VALUES ('C0024','Sanchez Briceño, FERNANDO',null     ,'redondo@hotmail.com','Av. Javier Prado 114',1600)
INSERT INTO clientes VALUES ('C0025','Mego Mendoza, Jose','567-8466','importa03@hotmail.com','Jr. Pio XII 112   ',null)
INSERT INTO clientes VALUES ('C0026','Bustamante Porta, Diego','567-4566',null,'Av. Principal 123 ',1200)
INSERT INTO clientes VALUES ('C0027','Meza Cuadra, Guiliana','456-3457','campos@yahoo.com','Jr. Dominico 554',2000)
INSERT INTO clientes VALUES ('C0028','Portila Flores, Gregorio','746-0647','ramirez@idat.com','Jr. Salavery 876  ',2100)
INSERT INTO clientes VALUES ('C0029','Quiroz Salvador,Jose','567-4566',null,'Av. Guardia Civil 123 ',1200)
INSERT INTO clientes VALUES ('C0030','Sotelo Mateo , Mauricio','897-5783','importa04@hotmail.com','Av. Habich 4567   ',800)
INSERT INTO clientes VALUES ('C0031','Mendez landeo, Ester','958-3569','importa05@yahoo.com','Av. Wilson 678    ',2600)
INSERT INTO clientes VALUES ('C0032','Inafuku Salazar, Merlo','654-6534','pardo@walla.com','Av. Pardo 567     ',4100)
INSERT INTO clientes VALUES ('C0033','Chuquizita Leonardo, Laura','267-8958','importa05@hotmail.com','Av. Wilson 1267   ',700)


SELECT * FROM  clientes ORDER BY cli_cod

INSERT INTO articulos VALUES ('A0001','MOUSE GENIOUS       ','UNI', 25,235)
INSERT INTO articulos VALUES ('A0002','corel 2duo','UNI',2150,220)
INSERT INTO articulos VALUES ('A0003','corel 3duo    ','UNI',2500,220)
INSERT INTO articulos VALUES ('A0004','FUNDAS NAYLON       ','MTS', 40, 35)
INSERT INTO articulos VALUES ('A0005','MEMORIA ZIP 32      ','UNI', 60, 80)
INSERT INTO articulos VALUES ('A0006','TINTA BJC21 B/N     ','CAJ', 20, 20)
INSERT INTO articulos VALUES ('A0007','IMPRESORA EPSON 1234','UNI',355,120)
INSERT INTO articulos VALUES ('A0008','MONITOR SYNMASTER 3N','UNI',300, 33)
INSERT INTO articulos VALUES ('A0009','MONITOR VIEWSONIC   ','UNI',450, 92)
INSERT INTO articulos VALUES ('A0010','PENTIUM MMX 260     ','UNI',120, 97)
INSERT INTO articulos VALUES ('A0011','MOUSE MICROSOFT     ','UNI', 50,320)
INSERT INTO articulos VALUES ('A0012','MEMORIA DIM 640     ','UNI', 60, 25)
INSERT INTO articulos VALUES ('A0013','MEMORIA DIM 1280    ','UNI', 82, 25)

INSERT INTO articulos VALUES ('A0014','IMPRESORA CANON 1000','UNI',205,200)
INSERT INTO articulos VALUES ('A0015','IMPRESORA Sansung Laser','UNI',1805,200)

INSERT INTO articulos VALUES ('A0016','TINTA BJC21 COLOR   ','UNI', 20,120)
INSERT INTO articulos VALUES ('A0017','TINTA B/n  484   ','UNI', 20,120)
INSERT INTO articulos VALUES ('A0018','TINTA Color 624   ','UNI', 20,120)

INSERT INTO articulos VALUES ('A0019','TECLADO EPSON 102   ','UNI', 75,122)
INSERT INTO articulos VALUES ('A0020','MOUSE TECH          ','UNI', 30,190)

INSERT INTO articulos VALUES ('A0021','USB KISTON 128     ','UNI',160, 97)
INSERT INTO articulos VALUES ('A0022','USB DE 256         ','UNI',220, 20)
INSERT INTO articulos VALUES ('A0023','USB DE 512         ','UNI',260, 25)
INSERT INTO articulos VALUES ('A0024','AMPLIFICADOR TRINITON','UNI',100,20)
INSERT INTO articulos VALUES ('A0025','PARLANTES DE 50 watss ','UNI', 70,12)
INSERT INTO articulos VALUES ('A0026','TECLADO EPSON 102   ','UNI', 75,122)
INSERT INTO articulos VALUES ('A0027','MOUSE TECH          ','UNI', 30,190)




SELECT * FROM  articulos ORDER BY art_nom


INSERT INTO fac_cabe VALUES ('F0001','02/02/2009','C0007','S',1)
INSERT INTO fac_cabe VALUES ('F0002','03/04/2009','C0005','S',2)
INSERT INTO fac_cabe VALUES ('F0003','03/05/2009','C0016','N',2)
INSERT INTO fac_cabe VALUES ('F0004','08/12/2009','C0002','S',1)
INSERT INTO fac_cabe VALUES ('F0005','08/06/2009','C0005','N',3)
INSERT INTO fac_cabe VALUES ('F0006','09/12/2009','C0002','N',4)
INSERT INTO fac_cabe VALUES ('F0007','10/09/2009','C0016','N',5)
INSERT INTO fac_cabe VALUES ('F0008','12/02/2009','C0005','S',5)
INSERT INTO fac_cabe VALUES ('F0009','12/11/2009','C0020','N',6)
INSERT INTO fac_cabe VALUES ('F0010','01/06/2010','C0005','N',7)
INSERT INTO fac_cabe VALUES ('F0011','01/07/2010','C0012','N',10)
INSERT INTO fac_cabe VALUES ('F0012','01/11/2010','C0012','S',7)
INSERT INTO fac_cabe VALUES ('F0013','02/10/2010','C0002','S',6)
INSERT INTO fac_cabe VALUES ('F0014','02/01/2010','C0011','S',11)
INSERT INTO fac_cabe VALUES ('F0015','03/12/2010','C0018','N',12)
INSERT INTO fac_cabe VALUES ('F0016','03/03/2010','C0012','S',11)
INSERT INTO fac_cabe VALUES ('F0017','03/08/2010','C0001','N',13)
INSERT INTO fac_cabe VALUES ('F0018','03/01/2011','C0002','N',13)
INSERT INTO fac_cabe VALUES ('F0019','11/01/2011','C0001','S',14)
INSERT INTO fac_cabe VALUES ('F0020','05/01/2011','C0002','N',15)
INSERT INTO fac_cabe VALUES ('F0021','07/01/2011','C0003','S',16)
INSERT INTO fac_cabe VALUES ('F0022','12/02/2011','C0004','N',17)
INSERT INTO fac_cabe VALUES ('F0023','10/02/2011','C0005','S',19)
INSERT INTO fac_cabe VALUES ('F0024','09/02/2011','C0004','N',19)
INSERT INTO fac_cabe VALUES ('F0025','03/03/2011','C0005','S',11)
INSERT INTO fac_cabe VALUES ('F0026','05/03/2011','C0004','N',14)

INSERT INTO fac_cabe VALUES ('F0027','05/04/2011','C0005','N',1)
INSERT INTO fac_cabe VALUES ('F0028','05/05/2011','C0004','N',10)
INSERT INTO fac_cabe VALUES ('F0029','05/05/2011','C0005','N',4)
INSERT INTO fac_cabe VALUES ('F0030','05/06/2011','C0006','S',3)
INSERT INTO fac_cabe VALUES ('F0031','05/07/2011','C0004','N',4)
INSERT INTO fac_cabe VALUES ('F0032','05/07/2011','C0007','N',8)
INSERT INTO fac_cabe VALUES ('F0033','05/08/2011','C0008','S',7)
INSERT INTO fac_cabe VALUES ('F0034','05/08/2011','C0008','N',6)
INSERT INTO fac_cabe VALUES ('F0035','05/09/2011','C0004','N',7)
INSERT INTO fac_cabe VALUES ('F0036','05/10/2011','C0009','S',4)
INSERT INTO fac_cabe VALUES ('F0037','05/10/2011','C0010','N',11)
INSERT INTO fac_cabe VALUES ('F0038','05/12/2011','C0010','N',11)
INSERT INTO fac_cabe VALUES ('F0039','05/01/2012','C0015','S',9)
INSERT INTO fac_cabe VALUES ('F0040','05/01/2012','C0014','N',1)
INSERT INTO fac_cabe VALUES ('F0041','05/01/2012','C0005','S',3)
INSERT INTO fac_cabe VALUES ('F0042','05/02/2012','C0011','N',6)
INSERT INTO fac_cabe VALUES ('F0043','05/02/2012','C0014','S',11)
INSERT INTO fac_cabe VALUES ('F0044','05/02/2012','C0012','N',12)
INSERT INTO fac_cabe VALUES ('F0045','13/02/2012','C0007','N',4)
INSERT INTO fac_cabe VALUES ('F0046','14/02/2012','C0008','N',4)
INSERT INTO fac_cabe VALUES ('F0047','08/02/2012','C0009','N',3)
INSERT INTO fac_cabe VALUES ('F0048','09/02/2012','C0011','N',7)
INSERT INTO fac_cabe VALUES ('F0049','10/02/2012','C0019','N',8)
INSERT INTO fac_cabe VALUES ('F0050','15/02/2012','C0004','N',2)


SELECT * FROM fac_cabe

INSERT INTO fac_deta VALUES ('F0001','A0007',3)
INSERT INTO fac_deta VALUES ('F0001','A0001', 2)
INSERT INTO fac_deta VALUES ('F0002','A0002',16)
INSERT INTO fac_deta VALUES ('F0002','A0004', 4)
INSERT INTO fac_deta VALUES ('F0002','A0005', 6)
INSERT INTO fac_deta VALUES ('F0003','A0004', 5)
INSERT INTO fac_deta VALUES ('F0004','A0007',3)
INSERT INTO fac_deta VALUES ('F0004','A0002',2)
INSERT INTO fac_deta VALUES ('F0005','A0006', 12)
INSERT INTO fac_deta VALUES ('F0005','A0010',11)
INSERT INTO fac_deta VALUES ('F0005','A0011', 4)
INSERT INTO fac_deta VALUES ('F0005','A0014',11)
INSERT INTO fac_deta VALUES ('F0006','A0007',13)
INSERT INTO fac_deta VALUES ('F0007','A0020', 23)
INSERT INTO fac_deta VALUES ('F0008','A0020', 2)
INSERT INTO fac_deta VALUES ('F0009','A0001', 2)
INSERT INTO fac_deta VALUES ('F0010','A0006', 8)
INSERT INTO fac_deta VALUES ('F0010','A0005', 7)
INSERT INTO fac_deta VALUES ('F0010','A0011', 5)
INSERT INTO fac_deta VALUES ('F0011','A0005', 6)
INSERT INTO fac_deta VALUES ('F0011','A0004', 4)
INSERT INTO fac_deta VALUES ('F0011','A0010',13)
INSERT INTO fac_deta VALUES ('F0012','A0002',14)
INSERT INTO fac_deta VALUES ('F0013','A0014',21)
INSERT INTO fac_deta VALUES ('F0014','A0014',2)
INSERT INTO fac_deta VALUES ('F0015','A0007',3)
INSERT INTO fac_deta VALUES ('F0016','A0014',2)
INSERT INTO fac_deta VALUES ('F0016','A0006', 5)
INSERT INTO fac_deta VALUES ('F0017','A0006', 7)
INSERT INTO fac_deta VALUES ('F0017','A0011', 5)
INSERT INTO fac_deta VALUES ('F0018','A0012', 4)
INSERT INTO fac_deta VALUES ('F0018','A0002', 1)
INSERT INTO fac_deta VALUES ('F0018','A0004', 4)
INSERT INTO fac_deta VALUES ('F0018','A0005', 11)
INSERT INTO fac_deta VALUES ('F0019','A0008', 13)
INSERT INTO fac_deta VALUES ('F0019','A0007', 6)
INSERT INTO fac_deta VALUES ('F0019','A0006', 7)
INSERT INTO fac_deta VALUES ('F0020','A0007', 6)
INSERT INTO fac_deta VALUES ('F0020','A0009', 15)
INSERT INTO fac_deta VALUES ('F0021','A0009', 11)
INSERT INTO fac_deta VALUES ('F0021','A0004', 2)
INSERT INTO fac_deta VALUES ('F0021','A0007', 3)
INSERT INTO fac_deta VALUES ('F0022','A0001', 4)
INSERT INTO fac_deta VALUES ('F0023','A0003', 5)
INSERT INTO fac_deta VALUES ('F0023','A0006', 7)
INSERT INTO fac_deta VALUES ('F0024','A0007', 13)
INSERT INTO fac_deta VALUES ('F0024','A0003', 15)
INSERT INTO fac_deta VALUES ('F0025','A0008', 11)
INSERT INTO fac_deta VALUES ('F0026','A0010', 4)
INSERT INTO fac_deta VALUES ('F0026','A0011', 3)

INSERT INTO fac_deta VALUES ('F0027','A0001', 2)
INSERT INTO fac_deta VALUES ('F0027','A0003', 1)
INSERT INTO fac_deta VALUES ('F0028','A0006', 3)
INSERT INTO fac_deta VALUES ('F0029','A0008', 4)
INSERT INTO fac_deta VALUES ('F0030','A0009', 3)
INSERT INTO fac_deta VALUES ('F0031','A0011', 2)
INSERT INTO fac_deta VALUES ('F0032','A0010', 3)
INSERT INTO fac_deta VALUES ('F0033','A0013', 1)
INSERT INTO fac_deta VALUES ('F0033','A0014', 3)
INSERT INTO fac_deta VALUES ('F0034','A0013', 2)
INSERT INTO fac_deta VALUES ('F0035','A0012', 3)
INSERT INTO fac_deta VALUES ('F0036','A0001', 4)
INSERT INTO fac_deta VALUES ('F0037','A0003', 6)
INSERT INTO fac_deta VALUES ('F0038','A0001', 5)
INSERT INTO fac_deta VALUES ('F0039','A0004', 2)
INSERT INTO fac_deta VALUES ('F0039','A0007', 1)
INSERT INTO fac_deta VALUES ('F0040','A0001', 2)
INSERT INTO fac_deta VALUES ('F0040','A0004', 2)
INSERT INTO fac_deta VALUES ('F0041','A0005', 6)
INSERT INTO fac_deta VALUES ('F0042','A0007', 2)
INSERT INTO fac_deta VALUES ('F0042','A0011', 1)
INSERT INTO fac_deta VALUES ('F0043','A0010', 2)
INSERT INTO fac_deta VALUES ('F0044','A0012', 3)
INSERT INTO fac_deta VALUES ('F0045','A0014', 2)
INSERT INTO fac_deta VALUES ('F0046','A0012', 1)
INSERT INTO fac_deta VALUES ('F0047','A0001', 2)
INSERT INTO fac_deta VALUES ('F0048','A0004', 1)
INSERT INTO fac_deta VALUES ('F0049','A0007', 2)

INSERT INTO fac_deta VALUES ('F0050','A0011', 3)
INSERT INTO fac_deta VALUES ('F0050','A0012', 4)



go
INSERT INTO Vendedor VALUES ('Diaz Vera, Ana','12/03/78')
INSERT INTO Vendedor VALUES ('Pardo Campos, carlos','11/05/79')
INSERT INTO Vendedor VALUES ('LEE Moreno,  claudia','12/06/79')
INSERT INTO Vendedor VALUES ('Mendoza OBANDO, Maria','11/04/82' )
INSERT INTO Vendedor VALUES ('Narva Gomez, Mario','15/06/83')
INSERT INTO Vendedor VALUES ('Murillo Mancini, Juan','11/05/85')
INSERT INTO Vendedor VALUES ('Gonzales Vera, Erlinda','12/04/85')
INSERT INTO Vendedor VALUES ('Diaz Choque, Susy','11/12/98')
INSERT INTO Vendedor VALUES ('Huamani Rios, Liz','11/11/98')
INSERT INTO Vendedor VALUES ('Cama Peralta, Ana','10/02/99')
INSERT INTO Vendedor VALUES ('Campos Diaz, Juan','12/11/99')
INSERT INTO Vendedor VALUES ('Ramirez Cristobal, Pedro','13/11/00')
INSERT INTO Vendedor VALUES ('Camarena Rios, Daniel','12/03/00')
INSERT INTO Vendedor VALUES ('Perez Diaz, Juan','11/11/01')
INSERT INTO Vendedor VALUES ('Inga Lopez, Consuelo','12/12/01')
INSERT INTO Vendedor VALUES ('Cardenas Bacilio, Eva','11/10/02')

INSERT INTO Vendedor VALUES ('Cardenas Bacilio, Eva','11/10/98')
INSERT INTO Vendedor VALUES ('Martel Mendez, Mario','11/10/94')
INSERT INTO Vendedor VALUES ('Carrasco Lopez, Ana','11/10/96')
INSERT INTO Vendedor VALUES ('Porras Becerra, Eva','11/10/00')
INSERT INTO Vendedor VALUES ('Zamora Contreras, Flor','11/10/01')
INSERT INTO Vendedor VALUES ('Diaz Bacilio, Eva','11/10/96')

sELECT * FROM vENDEDOR
Select * from clientes