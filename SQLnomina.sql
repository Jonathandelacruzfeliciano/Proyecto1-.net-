
CREATE DATABASE Nomina
use nomina

CREATE TABLE Nominas(
	Id_nom int primary key IDENTITY(1,1) NOT NULL,
	Nombre varchar(30) NOT NULL,
	Apellido varchar(30) NOT NULL,
	Cargo varchar(50) NOT NULL,
	SueldoBruto varchar(50) NOT NULL,
	HorasExt int NULL,
	PrecioHoraExt int NULL,
	PagoHorasExt int NULL,
	BonoTransporte int NULL,
	SeguroMedico float NOT NULL,
	AdelantoSueldo int NULL,
	SueldoNeto float NOT NULL,
	Id_Empl int
)
select * from Nominas
insert into Nominas values('Josue','Peralta',' Desarrollador','45000','15','100','1500','500','650','22000','43000','1')

CREATE TABLE Empleados(
	Id_Empl int primary key IDENTITY(1,1) NOT NULL,
	Nombre varchar(30) NOT NULL,
	Apellido varchar(30) NOT NULL,
	Direccion varchar(100) NOT NULL,
	Telefono varchar(20) NULL,
	FechaIngreso datetime NOT NULL,
	Cargo varchar(50) NOT NULL,
	Departamento varchar(50) NOT NULL,
	Salario varchar(50) NOT NULL,
	Cedula varchar(30) NOT NULL,
	Id_Usu int,
)
insert into Empleados values('Martinez ','Santana','Av.inde.Esq.25','809 878 2345','2022-02-17 00:00:00.000','Secretaria','Empleomania','15000','503 2374 0927','1')

select * from Empleados
CREATE TABLE Usuarios(
	Id_Usu int primary key IDENTITY(1,1) NOT NULL,
	Nombre varchar(30) NOT NULL,
	Apellido varchar(30) NOT NULL,
	Usuario varchar(50) NOT NULL,
	Contraseña varchar(50) NOT NULL,
)
 insert into Usuarios values('carlo','Cao','yoni','12345')
select * from Usuarios


select *
       from Usuarios us
inner join Empleados em 
       on us.Id_Usu = em.Id_Usu
inner join Nominas nn 
      on nn.Id_nom = nn.Id_nom