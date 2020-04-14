-- =================================================
-- Autor:			Erwin Justiniano - Eduardo Flores
-- Fecha:			09/10/2014
-- Descripción:		SalesProject
-- Versión:			1.1.1
-- =================================================

PRINT 'INICIANDO CREACION DE LA BASE DE DATOS'

USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'SalesProject')
	DROP DATABASE SalesProject
GO

IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = 'SalesProject')
	CREATE DATABASE SalesProject;
GO

USE SalesProject
GO

PRINT 'FIN CREACION BASE DE DATOS'
GO
-----------------------------------------------------------------------------

PRINT 'INICIANDO CREACION DE ESQUEMAS'


-- Esquema para tablas de parámetros
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'PAR')
	Exec('CREATE SCHEMA PAR')
GO

PRINT 'FIN CREACION DE ESQUEMAS'
GO
-----------------------------------------------------------------------------

PRINT 'INICIANDO CREACION DE TABLAS'

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblPersonas' AND xtype='U')
	DROP TABLE [PAR].[tblPersonas]
	GO
CREATE TABLE [PAR].[tblPersonas]
(
	pkPersona						int IDENTITY(1,1) NOT NULL,
	txtNit							varchar(100) NOT NULL,
	txtNombreCompleto				varchar(100) NOT NULL,
	txtDireccion					varchar(100) NULL,
	txtTelefono						varchar(100) NULL,
	txtCelular						varchar(100) NULL,
	txtCorreo						varchar(100) NULL,
	bitEstado						bit NOT NULL DEFAULT 1,
	dateFechaCreacion				datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion			datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion			int NOT NULL,
	intIdUsuarioModificacion		int NOT NULL,
	CONSTRAINT pk_tblPersonas PRIMARY KEY (pkPersona),	
	CONSTRAINT un_tblPersonas_Nit UNIQUE (txtNit)
) 
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblEmpleados' AND xtype='U')
	DROP TABLE [PAR].[tblEmpleados]
GO

CREATE TABLE [PAR].[tblEmpleados]
(
	pkEmpleado			int IDENTITY(1,1) NOT NULL,
	fkPersona			int NOT NULL,
	txtContraseña		VARBINARY(100) NOT NULL,
	CONSTRAINT pk_tblEmpleados PRIMARY KEY(pkEmpleado), 
	CONSTRAINT fk_tblEmpleados_idPersona FOREIGN KEY (fkPersona) REFERENCES [PAR].[tblPersonas](pkPersona) ON DELETE CASCADE  
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblAdministrador' AND xtype='U')
	DROP TABLE [PAR].[tblAdministrador]
GO

CREATE TABLE [PAR].[tblAdministrador]
(
	pkAdministrador			int IDENTITY(1,1) NOT NULL,
	fkPersona				int NOT NULL,
	txtContraseña			VARBINARY(100) NOT NULL,
	CONSTRAINT pk_tblAdministrador PRIMARY KEY(pkAdministrador), 
	CONSTRAINT fk_tblAdministrador_idPersona FOREIGN KEY (fkPersona) REFERENCES [PAR].[tblPersonas](pkPersona) ON DELETE CASCADE  
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblProveedores' AND xtype='U')
	DROP TABLE [PAR].[tblProveedores]
GO

CREATE TABLE [PAR].[tblProveedores]
(
	pkProveedor				int IDENTITY(1,1) NOT NULL,
	fkPersona				int NOT NULL,
	txtDescripcion			varchar(1000) NOT NULL,
	CONSTRAINT pk_tblProveedores PRIMARY KEY(pkProveedor), 
	CONSTRAINT fk_tblProveedores_idProveedor FOREIGN KEY (fkPersona) REFERENCES [PAR].[tblPersonas](pkPersona) ON DELETE CASCADE  
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblParametroClientes' AND xtype='U')
	DROP TABLE [PAR].[tblParametroClientes]
GO

CREATE TABLE [PAR].[tblParametroClientes]
(
	pkParametroCliente					int IDENTITY(1,1) NOT NULL,
	txtDescripcion						varchar(1000) NOT NULL,
	bitEstado							bit NOT NULL DEFAULT 1,
	dateFechaCreacion					datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion				datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion				int NOT NULL,
	intIdUsuarioModificacion			int NOT NULL,
	CONSTRAINT pk_tblParametroCliente PRIMARY KEY(pkParametroCliente)   
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblClientes' AND xtype='U')
	DROP TABLE [PAR].[tblClientes]
GO

CREATE TABLE [PAR].[tblClientes]
(
	pkCliente						int IDENTITY(1,1) NOT NULL,
	fkPersona						int NOT NULL,
	fkParametroCliente				int NOT NULL,
	CONSTRAINT pk_tblCliente PRIMARY KEY(pkCliente), 
	CONSTRAINT fk_tblCliente_id_Persona FOREIGN KEY (fkPersona) REFERENCES [PAR].[tblPersonas](pkPersona) ON DELETE CASCADE,
	CONSTRAINT fk_tblCliente_id_ParametroCliente FOREIGN KEY (fkParametroCliente) REFERENCES [PAR].[tblParametroClientes](pkParametroCliente) ON DELETE CASCADE
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblDescuentos' AND xtype='U')
	DROP TABLE [PAR].[tblDescuentos]
GO

CREATE TABLE [PAR].[tblDescuentos]
(
	pkDescuento								int IDENTITY(1,1) NOT NULL,
	txtNombre								varchar(250) NOT NULL,
	dateFechaInicio							Date NOT NULL,
	dateFechaFin							Date NOT NULL,
	intDescuento							int NOT NULL,
	txtDescripcion							varchar(1000),
	bitEstado								bit NOT NULL DEFAULT 1,
	dateFechaCreacion						datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion					datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion					int NOT NULL,
	intIdUsuarioModificacion				int NOT NULL,
	CONSTRAINT pk_tblDescuentos PRIMARY KEY(pkDescuento)  
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblMonedas' AND xtype='U')
	DROP TABLE [PAR].[tblMonedas]
GO

CREATE TABLE [PAR].[tblMonedas]
(
	pkMoneda							int IDENTITY(1,1) NOT NULL,
	decTipoCambio						decimal	NOT NULL,
	bitEstado							bit NOT NULL DEFAULT 1,
	dateFechaCreacion					datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion				datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion				int NOT NULL,
	intIdUsuarioModificacion			int NOT NULL,
	CONSTRAINT pk_tblMoneda PRIMARY KEY(pkMoneda)  
)
GO
IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblMarcas' AND xtype='U')
	DROP TABLE [PAR].[tblMarcas]
GO

CREATE TABLE [PAR].[tblMarcas]
(
	pkMarca									int IDENTITY(1,1) NOT NULL,
	txtNombre								varchar(250) NOT NULL,
	dateFechaCreacion						datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion					datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion					int NOT NULL,
	intIdUsuarioModificacion				int NOT NULL,
	CONSTRAINT pk_tblMarcas PRIMARY KEY(pkMarca)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblModelos' AND xtype='U')
	DROP TABLE [PAR].[tblModelos]
GO

CREATE TABLE [PAR].[tblModelos]
(
	pkModelo								int IDENTITY(1,1) NOT NULL,
	txtNombre								varchar(250) NOT NULL,
	dateFechaCreacion						datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion					datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion					int NOT NULL,
	intIdUsuarioModificacion				int NOT NULL,
	CONSTRAINT pk_tblModelos PRIMARY KEY(pkModelo)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblTallas' AND xtype='U')
	DROP TABLE [PAR].[tblTallas]
GO

CREATE TABLE [PAR].[tblTallas]
(
	pkTalla									int IDENTITY(1,1) NOT NULL,
	txtNombre								varchar(250) NOT NULL,
	dateFechaCreacion						datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion					datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion					int NOT NULL,
	intIdUsuarioModificacion				int NOT NULL,
	CONSTRAINT pk_tblTallas PRIMARY KEY(pkTalla)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblProductos' AND xtype='U')
	DROP TABLE [PAR].[tblProductos]
GO

CREATE TABLE [PAR].[tblProductos]
(
	pkProducto								int IDENTITY(1,1) NOT NULL,
	fkProveedor								int NOT NULL,
	txtCodigo								varchar(100) NOT NULL,
	txtNombre								varchar(250) NOT NULL,
	txtDescripcion							varchar(1000) NULL,
	intCantidad								int NOT NULL,
	decValorCompra							DECIMAL (18,2),
	decValorVenta							DECIMAL (18,2),
	bitEstado								bit NOT NULL DEFAULT 1,
	intGenero								int NOT NULL,
	fkMarca									int NOT NULL,
	fkModelo								int NOT NULL,
	fkTalla									int NOT NULL,
	dateFechaCreacion						datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion					datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion					int NOT NULL,
	intIdUsuarioModificacion				int NOT NULL,
	CONSTRAINT pk_tblProductos PRIMARY KEY(pkProducto),
	CONSTRAINT un_tblProductos_Codigo UNIQUE (txtCodigo), 
	CONSTRAINT fk_tblProductos_id_Proveedor FOREIGN KEY (fkProveedor) REFERENCES [PAR].[tblProveedores](pkProveedor) on delete cascade,
	CONSTRAINT fk_tblProductos_id_Marca FOREIGN KEY (fkMarca) REFERENCES [PAR].[tblMarcas](pkMarca) on delete cascade,
	CONSTRAINT fk_tblProductos_id_Modelo FOREIGN KEY (fkModelo) REFERENCES [PAR].[tblModelos](pkModelo) on delete cascade,
	CONSTRAINT fk_tblProductos_id_Talla FOREIGN KEY (fkTalla) REFERENCES [PAR].[tblTallas](pkTalla) on delete cascade
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblFacturas' AND xtype='U')
	DROP TABLE [PAR].[tblFacturas]
GO

CREATE TABLE [PAR].[tblFacturas]
(
	pkFactura							int IDENTITY(1,1) NOT NULL,
	fkCliente							int NOT NULL,
	fkEmpleado							int NOT NULL,
	fkDescuento							int NOT NULL,
	fkMoneda							int NOT NULL,
	txtNroFactura						varchar (10),
	txtNroAutorizacion					varchar (20),
	txtLlave							varbinary (256), 
	decTotal							decimal (18,2),
	bitEstado							bit NOT NULL DEFAULT 1,
	dateFechaCreacion					datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion				datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion				int NOT NULL,
	intIdUsuarioModificacion			int NOT NULL,
	CONSTRAINT pk_tblFactura PRIMARY KEY(pkFactura), 
	CONSTRAINT fk_tblFactura_id_Cliente FOREIGN KEY (fkCliente) REFERENCES [PAR].[tblClientes](pkCliente),
	CONSTRAINT fk_tblFactura_id_Empleado FOREIGN KEY (fkEmpleado) REFERENCES [PAR].[tblEmpleados](pkEmpleado),
	CONSTRAINT fk_tblFactura_id_Descuento FOREIGN KEY (fkDescuento) REFERENCES [PAR].[tblDescuentos](pkDescuento),
	CONSTRAINT fk_tblFactura_id_Moneda FOREIGN KEY (fkMoneda) REFERENCES [PAR].[tblMonedas](pkMoneda) 
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblDetalleVentas' AND xtype='U')
	DROP TABLE [PAR].[tblDetalleVentas]
GO

CREATE TABLE [PAR].[tblDetalleVentas]
(
	pkDetalleVenta					int IDENTITY(1,1) NOT NULL,
	fkProducto						int NOT NULL,
	fkFactura						int NOT NULL,
	intCantidad						int NOT NULL,
	decimalTotal					decimal(18,2),
	CONSTRAINT pk_tblDetalleVenta PRIMARY KEY(pkDetalleVenta), 
	CONSTRAINT fk_tblDetalleVenta_id_Producto FOREIGN KEY (fkProducto) REFERENCES [PAR].[tblProductos](pkProducto),
	CONSTRAINT fk_tblDetalleVenta_id_Factura FOREIGN KEY (fkFactura) REFERENCES [PAR].[tblFacturas](pkFactura) ON DELETE CASCADE
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblOfertas' AND xtype='U')
	DROP TABLE [PAR].[tblOfertas]
GO

CREATE TABLE [PAR].[tblOfertas]
(
	pkOferta							int IDENTITY(1,1)	NOT NULL,
	txtNombre							varchar(250)		NOT NULL,
	dateFechaInicio						date				NOT NULL,
	dateFechafin						date				NOT NULL,
	txtDescripcion						varchar(1000)		NOT NULL,
	bitEstado							bit NOT NULL DEFAULT 1,
	dateFechaCreacion					datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion				datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion				int NOT NULL,
	intIdUsuarioModificacion			int NOT NULL,
	CONSTRAINT pk_tblOfertas PRIMARY KEY(pkOferta)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblVariacionesPrecioProducto' AND xtype='U')
	DROP TABLE [PAR].[tblVariacionesPrecioProducto]
GO

CREATE TABLE [PAR].[tblVariacionesPrecioProducto]
(
	pkVariacion						int IDENTITY(1,1) NOT NULL,
	fkProducto						int NOT NULL,
	intCantidad						int NOT NULL,
	decValorCompra					DECIMAL (18,2),
	decValorVenta					DECIMAL (18,2),
	dateFechaCreacion				datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion			datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion			int NOT NULL,
	intIdUsuarioModificacion		int NOT NULL,
	CONSTRAINT pk_tblVariacionesPrecioProducto PRIMARY KEY(pkVariacion), 
	CONSTRAINT fk_tblVariacionesPrecioProducto_id_Producto FOREIGN KEY (fkProducto) REFERENCES [PAR].[tblProductos](pkProducto) ON DELETE CASCADE
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblLibroCompras' AND xtype='U')
	DROP TABLE [PAR].[tblLibroCompras]
GO

CREATE TABLE [PAR].[tblLibroCompras]
(
	pkLibro							int IDENTITY(1,1) NOT NULL,
	txtMes							varchar(2),
	txtAño							varchar(4),
	CONSTRAINT pk_tblLibroCompras PRIMARY KEY(pkLibro)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblDetalleLibroCompras' AND xtype='U')
	DROP TABLE [PAR].[tblDetalleLibroCompras]
GO

CREATE TABLE [PAR].[tblDetalleLibroCompras]
(
	pkRegistro						int IDENTITY(1,1) NOT NULL,
	intEspecificacion				int DEFAULT 1,
	intNro							int NOT NULL,
	dateFechaFactura				datetime NOT NULL,
	txtNitProeveedor				varchar(15),
	txtNombreRazon					varchar(100),
	txtNroFactura					varchar(15),
	txtNroDUI						varchar(16),
	txtNroAutorizacion				varchar(15),
	decImporteTotal					decimal (18,2),
	decImporteNOSujeto				decimal (18,2),
	decSubTotal						decimal (18,2),
	decDescuentos					decimal (18,2),
	decImporteBaseCF				decimal (18,2),
	decCreditoFiscal				decimal (18,2),
	txtCodigoControl				varchar (17),
	txtTipoCompra					varchar(2),
	fkLibro							int NOT NULL,
	dateFechaCreacion				datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion			datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion			int NOT NULL,
	intIdUsuarioModificacion		int NOT NULL,
	CONSTRAINT pk_tblDetalleLibroCompras PRIMARY KEY(pkRegistro),
	CONSTRAINT fk_tblLibroCompras_id_Libro FOREIGN KEY (fkLibro) REFERENCES [PAR].[tblLibroCompras](pkLibro) ON DELETE CASCADE
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblLibroVentas' AND xtype='U')
	DROP TABLE [PAR].[tblLibroVentas]
GO

CREATE TABLE [PAR].[tblLibroVentas]
(
	pkLibro							int IDENTITY(1,1) NOT NULL,
	txtMes							varchar(2),
	txtAño							varchar(4),
	CONSTRAINT pk_tblLibroVentas PRIMARY KEY(pkLibro)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblDetalleLibroVentas' AND xtype='U')
	DROP TABLE [PAR].[tblDetalleLibroVentas]
GO

CREATE TABLE [PAR].[tblDetalleLibroVentas]
(
	pkRegistro						int IDENTITY(1,1) NOT NULL,
	intEspecificacion				int DEFAULT 3,
	intNro							int NOT NULL,
	dateFechaFactura				datetime NOT NULL,
	txtNroFactura					varchar(15),
	txtNroAutorizacion				varchar(15),
	txtEstado						varchar(2) DEFAULT 'V',
	txtNitCliente					varchar	(13),
	txtNombreRazon					varchar(100),
	decImporteTotal					decimal (18,2),
	decImporteImpuestos				decimal (18,2),
	decExportacionesExentos			decimal (18,2),
	decVentasTasaCero				decimal (18,2),
	decSubTotal						decimal (18,2),
	decDescuentos					decimal (18,2),
	decImporteBaseDF				decimal (18,2),
	decDebitoFiscal					decimal (18,2),
	txtCodigoControl				varchar (17),
	fkLibro							int NOT NULL,
	dateFechaCreacion				datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion			datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion			int NOT NULL,
	intIdUsuarioModificacion		int NOT NULL,
	CONSTRAINT pk_tblDetalleLibroVentas PRIMARY KEY(pkRegistro),
	CONSTRAINT fk_tblLibroVentas_id_Libro FOREIGN KEY (fkLibro) REFERENCES [PAR].[tblLibroVentas](pkLibro) ON DELETE CASCADE
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblLLavesFacturas' AND xtype='U')
	DROP TABLE [PAR].[tblLLavesFacturas]
GO

CREATE TABLE [PAR].[tblLLavesFacturas]
(
	pkLlave								int IDENTITY(1,1) NOT NULL,
	txtNroAutorizacion					varchar (20),
	txtLlave							varbinary (256),
	dateFechaLimite						datetime, 
	dateFechaCreacion					datetime NOT NULL DEFAULT GETDATE(),
	dateFechaModificacion				datetime NOT NULL DEFAULT GETDATE(),
	intIdUsuarioCreacion				int NOT NULL,
	intIdUsuarioModificacion			int NOT NULL,
	CONSTRAINT pk_tblLlavesFacturas PRIMARY KEY(pkLlave)
)
GO

IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'tblGanancias' AND xtype='U')
	DROP TABLE [PAR].[tblGanancias]
GO

CREATE TABLE [PAR].[tblGanancias]
(
	pkGanancias								int IDENTITY(1,1) NOT NULL,
	fkProducto								int NOT NULL,
	intCantidad								int NOT NULL,
	decValorVenta							decimal(18,2),
	decValorCompra							decimal(18,2),
	dateFechaVenta							datetime NOT NULL DEFAULT GETDATE(),
	decTotal								decimal(18,2)
	CONSTRAINT pk_tblGanancias PRIMARY KEY(pkGanancias)
)
GO


IF EXISTS(SELECT name FROM SalesProject..sysobjects WHERE name = N'Version' AND xtype='U')
	DROP TABLE [PAR].[Version]
GO
	
CREATE TABLE [PAR].[Version]
(
	id int identity(1,1) NOT NULL, 
	-- Ejemplo de version: 1.0.0
	version varchar(20) NOT NULL,
	comentario varchar(200) NULL, 
	fecha datetime NOT NULL DEFAULT GETDATE(),
	CONSTRAINT pk_Version PRIMARY KEY(id),
	CONSTRAINT un_version UNIQUE (version)
)
GO

PRINT 'FIN CREACION DE TABLAS'
GO


PRINT 'INICIANDO CONFIGURACION DE USUARIO'

IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'Erwin_Eduardo')
	CREATE LOGIN [Erwin_Eduardo] WITH PASSWORD = '123456789*'
GO

CREATE USER [Erwin_Eduardo] FOR LOGIN [Erwin_Eduardo] WITH DEFAULT_SCHEMA=[dbo]
GO

GRANT CONNECT TO [Erwin_Eduardo]
GO

EXEC sp_addrolemember N'db_datareader', N'Erwin_Eduardo'
GO
EXEC sp_addrolemember N'db_datawriter', N'Erwin_Eduardo'
GO

GRANT EXECUTE ON SCHEMA:: DBO TO [Erwin_Eduardo]
GO 

GRANT EXECUTE ON SCHEMA:: PAR TO [Erwin_Eduardo]
GO

ALTER AUTHORIZATION ON DATABASE::SalesProject TO [sa];
GO

PRINT 'FIN CONFIGURACION DE USUARIO'



PRINT 'CONFIGURANDO VERSION DE BASE DE DATOS'
INSERT INTO [PAR].[Version](version, comentario) VALUES('1.1.1', 'Versión corregida y aumentada')
GO

USE [SalesProject]
GO