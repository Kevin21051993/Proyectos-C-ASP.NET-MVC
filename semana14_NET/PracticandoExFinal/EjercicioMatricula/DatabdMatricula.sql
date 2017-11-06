use bdMatricula;
go
insert into TABESP values('01','Administracion');
insert into TABESP values('02','Ing. Sistemas');
insert into TABESP values('03','Derecho');
insert into TABESP values('04','Educacion');
insert into TABESP values('05','Economía');
insert into TABESP values('06','Física');
select * from TABESP;
select * from ALUMNO;
use bdMatricula;
go
insert into ALUMNO values('000001','C001','Sancho Navarro Kevin',1,270);
insert into ALUMNO values('000002','C001','Marchan Alexis',2,180);
insert into ALUMNO values('000003','C001','Yrigoyen Marcelo',3,360);

use bdMatricula;
go
insert into ALUMNO values('000004','C002','Sanchez Eduardo',2,300);
insert into ALUMNO values('000005','C002','Ferrer Patricio',3,400);
select * from CURSO;
use bdMatricula;
go
insert into CURSO values('C001','01','Comercio',360,50);
insert into CURSO values('C002','01','Productividad',400,50);
insert into CURSO values('C003','02','Algoritmo',500,50);
insert into CURSO values('C004','02','Base de Datos',600,50);
insert into CURSO values('C005','03','Leyes',650,50);
insert into CURSO values('C006','03','Ciencias Sociales',360,50);
insert into CURSO values('C007','04','Problemas de Aprendizaje',420,50);
insert into CURSO values('C008','04','Desarrollo cognitivo',440,50);
insert into CURSO values('C009','05','Macroeconomia',180,50);
insert into CURSO values('C010','05','Microeconomia',380,50);
insert into CURSO values('C011','06','Calculo',150,50);
insert into CURSO values('C012','06','Mecánica',700,50);
