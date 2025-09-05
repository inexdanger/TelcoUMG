create table tbl_Empleados(
	CodigoEmpleado int identity(1,1) not null,
	Nombre varchar(40),
	Dpi int,
	Direccion varchar(100),
	FechaIngreso Datetime,
	SalarioBase Decimal(10,2),
	TipoEmpleado varchar(15),
	Estado varchar(15)
);

create table tbl_Clientes(
	CodigoCliente int identity(1,1) not null,
	Nombre varchar(20),
	Apellido varchar(20),
	Dpi int,
	Telefono int,
	Email varchar(50),
	Estado varchar(15)
);

create table tbl_Proveedores(
	CodigoProveedor int identity(1,1) not null,
	Nombre varchar(40),
	Contacto varchar(40),
	Telefono int,
	Email varchar(40),
	Direccion varchar(100),
	Estado varchar(15)
);

--Query consultar base de datos

select * from tbl_Empleados;
select * from tbl_Clientes;

insert into tbl_Empleados (Nombre, Dpi, Direccion, FechaIngreso, SalarioBase, TipoEmpleado, Estado) values (@Nombre, @Dpi,@Direccion,@FechaIngreso,@SalarioBase,@TipoEmpleado,@Estado);
insert into tbl_Empleados (Nombre, Dpi, Direccion, FechaIngreso, SalarioBase, TipoEmpleado, Estado) values (@Nombre, @Dpi,@Direccion,@FechaIngreso,@SalarioBase,@TipoEmpleado,@Estado);


