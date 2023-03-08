create  database sistema_licoreriaver1
go

use sistema_licoreriaver1
go

create table Personas
(
	idpersona		int identity(1,1)	primary key,
	apellidos		varchar(30)			not null,
	nombres			varchar(30)			not null,	
	DNI				char(8)		        not null,
	telefono		char(9)				not null,
	estado			bit					not null default 1,
	CONSTRAINT ck_DNI CHECK( DNI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT uk_DNI UNIQUE (DNI)
)
go





create table Empleados
(
	idempleado		int identity(1,1)	primary key,
	idpersona		int					not null, --FK
	nombreusuario	varchar(50)			not null,
	claveacceso		varchar(90)			not null,
	estado			bit					not null default 1,
	constraint fk_idpersona_empleados foreign key (idpersona) references Personas (idpersona),
	CONSTRAINT uk_nombreUsuario UNIQUE (nombreusuario),
	CONSTRAINT uk_idpersona UNIQUE (idpersona)
)
go





create table MediosPago
(
	idmediopago		int identity(1,1) primary key,
	mediopago		varchar(30)		not null
)
go
alter table MediosPago add CONSTRAINT uk_mediopago UNIQUE (mediopago)

create table Sedes
(
	idsede		int identity(1,1) primary key,
	ciudad		varchar(30)		not null,
	direccion	varchar(30)		not null,
	telefono	char(9)			not null,
	CONSTRAINT ck_telefono CHECK (telefono like '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
go



CREATE TABLE marcas
(
	idMarca			INT IDENTITY(1,1) PRIMARY KEY,
	nombreMarca		VARCHAR(50)		NOT NULL,
	CONSTRAINT uk_nombreMarca UNIQUE (nombreMarca)
)
GO

CREATE TABLE categoria
(
	idCategoria			INT IDENTITY(1,1) PRIMARY KEY,
	nombreCategoria		VARCHAR(50)		NOT NULL,
	CONSTRAINT uk_nombrecategoria UNIQUE (nombreCategoria)
)
GO

CREATE TABLE Productos
(
	idproducto			INT IDENTITY(1,1) PRIMARY KEY,
	idmarca				INT			 NOT NULL,
	idcategoria			INT			 NOT NULL,
	nombreproducto		VARCHAR(50)	 NOT NULL,
	descripcion			VARCHAR(100) NOT NULL,
	precio				DECIMAL(7,2) NOT NULL,
	stock				smallint	 NOT NULL,
	caducidad			DATE		 NOT NULL,
	estado			bit					not null default 1,
	CONSTRAINT R1_idmarca FOREIGN KEY (idmarca) REFERENCES marcas(idmarca),
	CONSTRAINT R2_idcategoria FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria),
	CONSTRAINT R4_precio CHECK (precio > 0),
	CONSTRAINT Re_stock CHECK (stock > 0)
)
GO



create table DetalleVenta
(
	iddetalleventa		int identity(1,1) primary key,
	idproducto			int				not null,
	cantidad			smallint		not null,
	precioventa			decimal(7,2)	not null,
	constraint fk_idproductos_detalleven foreign key (idproducto) references Productos (idproducto),
	CONSTRAINT R5_precioventa CHECK (precioventa > 0),
	CONSTRAINT ck_cantidad CHECK (cantidad > 0)
)
go

CREATE table Ventas 
(
	idventa			int identity(1,1) primary key,
	idmediopago		int			not null, --FK
	idsede			int			not null, --FK
	idcliente		int			not null, --FK
	idempleado		int			not null,  --FK
	iddetalleventa	int			not null,
	fechahora		datetime	not null default getdate(),
	tipocomprovante	varchar(30)	not null,
	numcomprovante	char(7)	not null,
	constraint fk_idmediopago_ventas foreign key (idmediopago) references MediosPago (idmediopago),
	constraint fk_idsede_ventas foreign key (idsede) references Sedes (idsede),
	constraint fk_idcliente_ventas foreign key (idcliente) references Personas (idpersona),
	constraint fk_idempleado_ventas foreign key (idempleado) references Empleados (idempleado),
	constraint fk_iddetalleventa_detalle foreign key(iddetalleventa) references DetalleVenta(iddetalleventa),
	constraint ck_tipocomprovante check (tipocomprovante in ('Boleta', 'Factura')),
	CONSTRAINT ck_numcomprovante CHECK (numcomprovante like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT uk_numcomprovante UNIQUE (numcomprovante)
)
go

CREATE TABLE Proveedores
(
	idproveedor		INT IDENTITY(1,1) PRIMARY KEY,
	nombreprov		VARCHAR(50)		NOT NULL,
	direccion		VARCHAR(50)		NOT NULL,
	RUC				CHAR(11)		NOT NULL,
	telefono		CHAR(9)			NOT NULL,
	CONSTRAINT uk_Ruc UNIQUE (RUC),
	CONSTRAINT ck1_telefono CHECK (telefono like '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_RUC CHECK (RUC LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

CREATE TABLE Compras 
(
	idcompras	INT IDENTITY(1,1) PRIMARY KEY,
	idproveedor	INT		NOT NULL,
	CONSTRAINT R6_idproveedor FOREIGN KEY (idproveedor) REFERENCES Proveedores(idproveedor)
)
GO

CREATE TABLE detalleCompra
(
	iddecompra		INT IDENTITY(1,1) PRIMARY KEY,
	idcompras		INT			 NOT NULL,
	idproductos		INT			 NOT NULL,
	cantidad		SMALLINT	 NOT NULL,
	preciocompra	DECIMAL(7,2) NOT NULL,
	CONSTRAINT r6_idcompras FOREIGN KEY (idcompras)	REFERENCES compras(idcompras),
	CONSTRAINT R7_idproducto FOREIGN KEY (idproductos) REFERENCES productos(idproducto),
	CONSTRAINT R8_cantidad CHECK (cantidad > 0),
	CONSTRAINT R9_preciocompra CHECK (precioCompra > 0)
)
GO




-- PROCEDIMIENTOS ALMACENADOS
use sistema_licoreriaver1
go

-- TABLA PERSONAS

CREATE PROCEDURE spu_registrar_personas
	@apellido	VARCHAR(30),
	@nombre		VARCHAR(30),
	@dni		CHAR(8),
	@telefono	CHAR(9)
AS BEGIN
	INSERT INTO Personas(apellidos, nombres, DNI, telefono) VALUES
		(@apellido, @nombre, @dni, @telefono)
END
GO

EXEC spu_registrar_personas 'casillas', 'aurelio', '68793745', '987654321'
EXEC spu_registrar_personas 'Rivera Huaman', 'aurelio', '68793746', '987654322'
GO


CREATE PROCEDURE spu_listar_personas
	@estado		BIT
AS BEGIN
	SELECT	idpersona,
	apellidos,
	nombres,
	dni,
	telefono FROM Personas 
WHERE estado = @estado

ORDER BY idpersona DESC
END
GO

EXEC spu_listar_personas 1
GO

CREATE PROCEDURE spu_modificar_personas
	@idpersona		INT,
	@apellidos		VARCHAR(30),
	@nombres		VARCHAR(30),
	@dni			CHAR(8),
	@telefono		CHAR(9)
AS BEGIN
	UPDATE Personas SET
		apellidos = @apellidos,
		nombres = @nombres,
		DNI = @dni,
		telefono = @telefono
WHERE idpersona = @idpersona
END
GO

EXEC spu_modificar_personas 10, 'Casillas Torres', 'aurelio', '68793745', '987654321'
GO

CREATE PROCEDURE spu_eliminar_presonas
	@idpersona int
AS BEGIN
	UPDATE Personas	SET
	estado = 0
WHERE idpersona = @idpersona
END
GO

EXEC spu_eliminar_presonas 10
GO

CREATE PROCEDURE spu_buscar_personas
@dni CHAR(8)
AS BEGIN
	SELECT
		Personas.idpersona,
		Personas.apellidos,
		Personas.nombres,
		Personas.DNI,
		Personas.telefono,
		Personas.estado
		FROM Personas
		WHERE Personas.estado = '1' AND Personas.DNI = @dni;
END
GO

EXEC spu_buscar_personas '89735243'
GO
	

-- TABLA EMPLEADOS

CREATE PROCEDURE spu_registrar_empleado
	@idpersona		INT,
	@nombreusuario	VARCHAR(50),
	@claveacceso	VARCHAR(90)
AS BEGIN
	INSERT INTO Empleados (idpersona, nombreusuario, claveacceso) VALUES
				(@idpersona, @nombreusuario, @claveacceso)
END
GO

EXEC spu_registrar_empleado 6, 'Jean', 'mateo123'
GO

CREATE PROCEDURE spu_listar_empleado
	@estado BIT
AS BEGIN
	SELECT 
	idpersona,
	nombreusuario,
	claveacceso 
	FROM Empleados 
	WHERE estado = @estado
ORDER BY idempleado DESC
END
GO

EXEC spu_listar_empleado 1
GO

CREATE PROCEDURE spu_modificar_Empleado
	@idpersona			INT,
	@claveacceso		VARCHAR(90)
AS BEGIN
	UPDATE Empleados SET
		idpersona = @idpersona,
		claveacceso = @claveacceso
WHERE idpersona = @idpersona
END
GO

EXEC spu_modificar_Empleado 6, '123456'
GO

CREATE PROCEDURE spu_eliminar_empleado
	@idempleado int
AS BEGIN
	UPDATE Empleados SET
	estado = 0
WHERE idempleado = @idempleado
END
GO

CREATE PROCEDURE spu_buscar_empleado
@idempleado INT
AS BEGIN
	SELECT 
		nombreusuario,
		claveacceso
		FROM Empleados
		WHERE Empleados.estado = '1' AND Empleados.idempleado = @idempleado;
END
GO

EXEC spu_buscar_empleado 2
GO



-- TABLA PRODUCTOS
CREATE PROCEDURE spu_registrar_producto
	@idmarca		INT,
	@idcategoria	INT,
	@nombreproducto	VARCHAR(50),
	@descripcion	VARCHAR(100),
	@precio			DECIMAL(7,2),
	@stock			SMALLINT,
	@caducidad		DATE
AS BEGIN
	INSERT INTO Productos(idmarca, idcategoria, nombreproducto, descripcion, precio, stock, caducidad) VALUES
				(@idmarca, @idcategoria, @nombreproducto, @descripcion, @precio, @stock, @caducidad)
END
GO

EXEC spu_registrar_producto '1', '1', 'Borgoña', 'Vino Tinto 1L', '30', '5', '02-03-2024'
GO



CREATE PROCEDURE spu_listar_producto
    @estado        bit
as begin
    select idproducto,
    nombreCategoria,
    nombreproducto,
    nombreMarca,
    descripcion,
    precio,
    stock,
    caducidad     from Productos
    inner join  categoria on Productos.idcategoria = categoria.idCategoria
    inner join marcas on Productos.idmarca = marcas.idMarca     
	where Productos.estado = @estado
    ORDER BY idproducto DESC
end
go 

exec spu_listar_producto 1
go

create PROCEDURE spu_modificar_producto
	@idproducto		 INT,
	@idMarca		 INT,
	@idCategoria	 INT,
	@nombreproducto  VARCHAR(50),
	@descripcion	 VARCHAR(100),
	@precio			 DECIMAL(7,2),
	@stock			 SMALLINT,
	@caducidad		 DATE
AS BEGIN
	UPDATE Productos SET
	idmarca = @idMarca,
	idcategoria = @idCategoria,
	nombreproducto	= @nombreproducto,
	descripcion = @descripcion,
	precio	= @precio,
	stock	= @stock,
	caducidad = @caducidad		
WHERE idproducto = @idproducto
END
GO

EXEC spu_modificar_producto 4, 2, 1, 'Borgoña', 'Vino seco 1L', '30', '10', '02-03-2024'
GO


SELECT * FROM Productos
GO

CREATE PROCEDURE spu_buscar_producto
    @idproducto        INT
as begin
    select idproducto,
    nombreCategoria,
    nombreproducto,
    nombreMarca,
    descripcion,
    precio,
    stock,
    caducidad     from Productos
    inner join  categoria on Productos.idcategoria = categoria.idCategoria
    inner join marcas on Productos.idmarca = marcas.idMarca     
	where Productos.idproducto = @idproducto
    ORDER BY idproducto DESC
end
go 

EXEC spu_buscar_producto 4
GO

SELECT * FROM Compras
GO

CREATE PROCEDURE spu_eliminar_productos
	@idproducto int
AS BEGIN
	UPDATE Productos	SET
	estado = 0
WHERE idproducto = @idproducto
END
GO

EXEC spu_eliminar_productos 4
GO

CREATE PROCEDURE spu_activar_productos
	@idproducto int
AS BEGIN
	UPDATE Productos	SET
	estado = 1
WHERE idproducto = @idproducto
END
GO

EXEC spu_activar_productos 4
GO


--TABLA VENTA

CREATE PROCEDURE spu_registrar_venta
	@idmediopago	 INT,
	@idsede			 INT,
	@idcliente  	 INT,
	@idempleado		 INT,
	@detalleventa	int,
	@tipocomprovante VARCHAR(30),
	@numcomprovante	 VARCHAR(7)
AS BEGIN
	INSERT INTO Ventas(idmediopago, idsede, idcliente, idempleado,iddetalleventa, tipocomprovante, numcomprovante) VALUES
				(@idmediopago, @idsede, @idcliente, @idempleado,@detalleventa, @tipocomprovante,  @numcomprovante)
END
GO

EXEC spu_registrar_venta 


select * from MediosPago 
GO

select * from DetalleVenta

select  Ventas.idventa,
		Empleados.nombreusuario as Cajero,
		CONCAT (Personas.apellidos, ' ',
		Personas.nombres) as Cliente,
		Productos.nombreproducto,
		DetalleVenta.cantidad,
		DetalleVenta.precioventa,
		DetalleVenta.cantidad * DetalleVenta.precioventa'Importe'
    from Ventas
	inner join Empleados on Ventas.idempleado = Empleados.idempleado
    inner join Personas on Ventas.idcliente = Personas.idpersona
    inner join DetalleVenta on Ventas.iddetalleventa = DetalleVenta.iddetalleventa
	inner join Productos on DetalleVenta.idproducto =Productos.idproducto
	where idventa = 1

go

insert into DetalleVenta ( idproducto, cantidad, precioventa) values 
	( 4, 3, 32.0)
go

INSERT INTO Sedes (ciudad, direccion, telefono) VALUES
				('Chincha Alta', 'Av. benavides #255', '928475629'),
				('Pueblo Nuevo', 'Jr. Arica # 506', '918724938'),
				('Tambo de Mora', 'Vilma Leon #320', '972653854')
GO

INSERT INTO MediosPago (mediopago) VALUES
				('Tarjeta'),
				('Efectivo'),
				('Yape'),
				('Plin')
GO

SELECT * FROM DetalleVenta

insert into ventas(idsede,idempleado,idcliente,iddetalleventa,idmediopago,tipocomprovante,numcomprovante) values
(1,2,6,1,2,'Boleta','0000123')

