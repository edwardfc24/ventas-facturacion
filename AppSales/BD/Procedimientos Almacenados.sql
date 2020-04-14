-- =============================================
-- Autor:			Erwin Justiniano - Eduardo Flores
-- Fecha:			09/10/2014
-- Descripción:		Procedimientos Almacenados
-- Versión:			1.0.0
-- =============================================

USE SalesProject
GO

PRINT 'CREATE PROCEDURES'
PRINT '----------------------------------------------------------------------------------------------'
PRINT 'PROCEDURES INSERT'
PRINT 'CREATE PROCEDURE INSERT_PERSON'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Person]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Person]
END
GO

CREATE PROCEDURE [PAR].[Insert_Person]
@pkPerson				int OUTPUT,
@txtNit					varchar(100),
@txtFullName			varchar(100),
@txtAddress				varchar(100),
@txtTelephone			varchar(100),
@txtCellPhone			varchar(100),
@txtEmail				varchar(100),
@intIdUsuario			int
AS
BEGIN
INSERT INTO [PAR].[tblPersonas](txtNit,txtNombreCompleto,txtDireccion,txtTelefono,txtCelular,txtCorreo,
								intIdUsuarioCreacion,intIdUsuarioModificacion) 
values (@txtNit,@txtFullName,@txtAddress,@txtTelephone,@txtCellPhone,@txtEmail,@intIdUsuario,@intIdUsuario)
SET @pkPerson = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_PERSON'


PRINT 'CREATE PROCEDURE INSERT_PARAMETERCLIENT'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_ParameterClient]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_ParameterClient]
END
GO

CREATE PROCEDURE [PAR].[Insert_ParameterClient]
@pkParameterClient				int OUTPUT,
@txtDescription					varchar(100),
@intIdUsuario					int
AS
BEGIN
INSERT INTO [PAR].[tblParametroClientes](txtDescripcion,intIdUsuarioCreacion,intIdUsuarioModificacion) 
values (@txtDescription,@intIdUsuario,@intIdUsuario)
SET @pkParameterClient = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_PARAMETERCLIENT'

PRINT 'CREATE PROCEDURE INSERT_CLIENT'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_client]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_client]
END
GO

CREATE PROCEDURE [PAR].[Insert_client]
@pkClient				int OUTPUT,
@fkPerson				int,
@fkParameterClient		int
AS
BEGIN
INSERT INTO [PAR].[tblClientes](fkPersona,fkParametroCliente) values (@fkPerson,@fkParameterClient)
SET @pkClient = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_CLIENT'


PRINT 'CREATE PROCEDURE INSERT_EMPLOYEE'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Employee]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Employee]
END
GO

CREATE PROCEDURE [PAR].[Insert_Employee]
@pkEmployee				int OUTPUT,
@fkPerson				int,
@txtPassword			varchar(100)
AS
BEGIN
INSERT INTO [PAR].[tblEmpleados](fkPersona,txtContraseña) values (@fkPerson,CONVERT(VARBINARY(100),@txtPassword))
SET @pkEmployee = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_EMPLOYEE'

PRINT 'CREATE PROCEDURE INSERT_ADMIN'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Admin]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Admin]
END
GO

CREATE PROCEDURE [PAR].[Insert_Admin]
@pkAdmin				int OUTPUT,
@fkPerson				int,
@txtPassword			varchar(100)
AS
BEGIN
INSERT INTO [PAR].[tblAdministrador](fkPersona,txtContraseña) values (@fkPerson,CONVERT(VARBINARY(100),@txtPassword))
SET @pkAdmin = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_ADMIN'


PRINT 'CREATE PROCEDURE INSERT_PROVIDER'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Provider]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Provider]
END
GO

CREATE PROCEDURE [PAR].[Insert_Provider]
@pkProvider					int OUTPUT,
@fkPerson					int,
@txtDescription				varchar(1000)
AS
BEGIN
INSERT INTO [PAR].[tblProveedores](fkPersona,txtDescripcion) values (@fkPerson,@txtDescription)
SET @pkProvider = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_PROVIDER'


PRINT 'CREATE PROCEDURE INSERT_PRODUCT'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Product]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Product]
END
GO

CREATE PROCEDURE [PAR].[Insert_Product]
@pkProduct					int OUTPUT,
@fkProvider					int,
@txtCode					varchar(100),
@txtName					varchar(100),
@txDescription				varchar(100),
@intTotal					int,
@decPurchaseValue			decimal (18,2),
@decSaleValue				decimal (18,2), 
@intSex						int,
@fkMarck					int,
@fkModel					int,
@fkSize						int,
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblProductos](fkProveedor,txtCodigo,txtNombre,txtDescripcion,intCantidad,decValorCompra,decValorVenta,intGenero,fkMarca,fkModelo,fkTalla, 
								intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@fkProvider,@txtCode,@txtName,@txDescription,@intTotal,@decPurchaseValue,@decSaleValue,@intSex,@fkMarck,@fkModel,@fkSize,@intIdUsuario,@intIdUsuario)
SET @pkProduct = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_PRODUCT'

PRINT 'CREATE PROCEDURE INSERT_MARK'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Mark]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Mark]
END
GO

CREATE PROCEDURE [PAR].[Insert_Mark]
@pkMark						int OUTPUT,
@txtName					varchar(100),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblMarcas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@txtName,@intIdUsuario,@intIdUsuario)
SET @pkMark = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_MARK'

PRINT 'CREATE PROCEDURE INSERT_MODEL'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Model]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Model]
END
GO

CREATE PROCEDURE [PAR].[Insert_Model]
@pkModel					int OUTPUT,
@txtName					varchar(100),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblModelos](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@txtName,@intIdUsuario,@intIdUsuario)
SET @pkModel = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_MODEL'

PRINT 'CREATE PROCEDURE INSERT_SIZE'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Size]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Size]
END
GO

CREATE PROCEDURE [PAR].[Insert_Size]
@pkSize						int OUTPUT,
@txtName					varchar(100),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblTallas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@txtName,@intIdUsuario,@intIdUsuario)
SET @pkSize = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_SIZE'

PRINT 'CREATE PROCEDURE INSERT_COIN'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Coin]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Coin]
END
GO

CREATE PROCEDURE [PAR].[Insert_Coin]
@pkCoin					int OUTPUT,
@decimalTypeCoin		decimal,
@intIdUsuario			int
AS
BEGIN
INSERT INTO [PAR].[tblMonedas](decTipoCambio,intIdUsuarioCreacion,intIdUsuarioModificacion) 
			values (@decimalTypeCoin,@intIdUsuario,@intIdUsuario)
SET @pkCoin = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_COIN'


PRINT 'CREATE PROCEDURE INSERT_SALE'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Sale]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Sale]
END
GO

CREATE PROCEDURE [PAR].[Insert_Sale]
@pkSale						int OUTPUT,
@fkClient					int,
@fkEmpleado					int,
@fkDiscount					int,
@fkCoin						int,
@txtCheckNumber				varchar(10),
@txtAutorizationNumber		varchar(20),
@txtKey						varchar(256),
@decTotal					decimal (18,2),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblFacturas](fkCliente,fkEmpleado,fkDescuento,fkMoneda,txtNroFactura,txtNroAutorizacion,txtLlave,decTotal,intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@fkClient,@fkEmpleado,@fkDiscount,@fkCoin,@txtCheckNumber,@txtAutorizationNumber,CONVERT(VARBINARY(256),@txtKey),@decTotal,@intIdUsuario,@intIdUsuario)
SET @pkSale = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_SALE'


PRINT 'CREATE PROCEDURE INSERT_DETAILSALE'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_DetailSale]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_DetailSale]
END
GO

CREATE PROCEDURE [PAR].[Insert_DetailSale]
@pkDetailSale		int OUTPUT,
@fkProduct			int,
@fkSale				int,
@intAmount			int,
@decTotal			decimal (18,2)
AS
BEGIN
INSERT INTO [PAR].[tblDetalleVentas](fkProducto,fkFactura,intCantidad,decimalTotal)
 values (@fkProduct,@fkSale,@intAmount,@decTotal)
SET @pkDetailSale = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_DETAILSALE'

PRINT 'CREATE PROCEDURE INSERT_DISCOUNT'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Discount]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Discount]
END
GO

CREATE PROCEDURE [PAR].[Insert_Discount]
@pkDiscount					int OUTPUT,
@txtName					varchar(250),
@dateStartDate				date,
@dateEndDate				date,
@intDiscount				int,
@txtDescription				varchar(1000),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].tblDescuentos(txtNombre,dateFechaInicio,dateFechaFin,intDescuento,txtDescripcion,
								intIdUsuarioCreacion,intIdUsuarioModificacion)
values (@txtName,@dateStartDate,@dateEndDate,@intDiscount,@txtDescription,@intIdUsuario,@intIdUsuario)
SET @pkDiscount = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_DISCOUNT'


PRINT 'CREATE PROCEDURE INSERT_OFFER'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Offer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Offer]
END
GO

CREATE PROCEDURE [PAR].[Insert_Offer]
@pkOffer					int OUTPUT,
@txtName					varchar(250),
@dateStartDate				date,
@dateEndDate				date,
@txtDescription				varchar(1000),
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblOfertas](txtNombre,dateFechaInicio,dateFechafin,txtDescripcion,
							intIdUsuarioCreacion,intIdUsuarioModificacion)
values (@txtName,@dateStartDate,@dateEndDate,@txtDescription,@intIdUsuario,@intIdUsuario)
SET @pkOffer = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_OFFER'

PRINT 'CREATE PROCEDURE INSERT_VARIATIONSPRICEPRODUCT'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_VariationPriceProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_VariationPriceProduct]
END
GO

CREATE PROCEDURE [PAR].[Insert_VariationPriceProduct]
@pkVariation					int OUTPUT,
@fkProducto						int,
@intQuantity					int,
@decPurchaseValue				decimal (18,2),
@decSellValue					decimal (18,2)
AS
BEGIN
INSERT INTO [PAR].[tblVariacionesPrecioProducto](fkProducto,intCantidad,decValorCompra,decValorVenta, intIdUsuarioCreacion,intIdUsuarioModificacion)
values (@fkProducto,@intQuantity,@decPurchaseValue,@decSellValue,0,0)
SET @pkVariation = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_VARIATIONSPRICEPRODUCT'

PRINT 'CREATE PROCEDURE INSERT_LIBROCOMPRAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_LibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_LibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Insert_LibroCompras]
@pkLibro						int OUTPUT,
@txtMes							varchar(2),
@txtAño							varchar(4)
AS
BEGIN
INSERT INTO [PAR].[tblLibroCompras](txtMes,txtAño)
values (@txtMes,@txtAño)
SET @pkLibro = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_LIBROCOMPRAS'

PRINT 'CREATE PROCEDURE INSERT_DETALLELIBROCOMPRAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_DetalleLibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_DetalleLibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Insert_DetalleLibroCompras]
@pkRegistro						int OUTPUT,
@intNro							int,
@dateFechaFactura				datetime,
@txtNitProeveedor				varchar(15),
@txtNombreRazon					varchar(100),
@txtNroFactura					varchar(15),
@txtNroDUI						varchar(16),
@txtNroAutorizacion				varchar(15),
@decImporteTotal				decimal (18,2),
@decImporteNOSujeto				decimal (18,2),
@decSubTotal					decimal (18,2),
@decDescuentos					decimal (18,2),
@decImporteBaseCF				decimal (18,2),
@decCreditoFiscal				decimal (18,2),
@txtCodigoControl				varchar (17),
@txtTipoCompra					varchar(2),
@fkLibro						int,
@intIdUsuario					int
AS
BEGIN
INSERT INTO [PAR].[tblDetalleLibroCompras](intNro,dateFechaFactura,txtNitProeveedor,txtNombreRazon,txtNroFactura,txtNroDUI,txtNroAutorizacion,decImporteTotal,decImporteNOSujeto,decSubTotal,decDescuentos,decImporteBaseCF,decCreditoFiscal,txtCodigoControl,txtTipoCompra,fkLibro,intIdUsuarioCreacion,intIdUsuarioModificacion)
values (@intNro,@dateFechaFactura,@txtNitProeveedor,@txtNombreRazon,@txtNroFactura,@txtNroDUI,@txtNroAutorizacion,@decImporteTotal,@decImporteNOSujeto,@decSubTotal,@decDescuentos,@decImporteBaseCF,@decCreditoFiscal,@txtCodigoControl,@txtTipoCompra,@fkLibro,@intIdUsuario,@intIdUsuario)
SET @pkRegistro = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_DETALLELIBROCOMPRAS'

PRINT 'CREATE PROCEDURE INSERT_LIBROVENTAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_LibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_LibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Insert_LibroVentas]
@pkLibro						int OUTPUT,
@txtMes							varchar(2),
@txtAño							varchar(4)
AS
BEGIN
INSERT INTO [PAR].[tblLibroVentas](txtMes,txtAño)
values (@txtMes,@txtAño)
SET @pkLibro = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_LIBROVENTAS'

PRINT 'CREATE PROCEDURE INSERT_DETALLELIBROVENTAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_DetalleLibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_DetalleLibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Insert_DetalleLibroVentas]
@pkRegistro						int OUTPUT,
@intNro							int,
@dateFechaFactura				datetime,
@txtNroFactura					varchar(15),
@txtNroAutorizacion				varchar(15),
@txtNitCliente					varchar	(13),
@txtNombreRazon					varchar(100),
@decImporteTotal				decimal (18,2),
@decImporteImpuestos			decimal (18,2),
@decExportacionesExentos		decimal (18,2),
@decVentasTasaCero				decimal (18,2),
@decSubTotal					decimal (18,2),
@decDescuentos					decimal (18,2),
@decImporteBaseDF				decimal (18,2),
@decDebitoFiscal				decimal (18,2),
@txtCodigoControl				varchar(17),
@fkLibro						int,
@intIdUsuario					int
AS
BEGIN
INSERT INTO [PAR].[tblDetalleLibroVentas](intNro,dateFechaFactura,txtNroFactura,txtNroAutorizacion,txtNitCliente,txtNombreRazon,decImporteTotal,decImporteImpuestos,decExportacionesExentos,decVentasTasaCero,decSubTotal,decDescuentos,decImporteBaseDF,decDebitoFiscal,txtCodigoControl,fkLibro,intIdUsuarioCreacion,intIdUsuarioModificacion)
values (@intNro,@dateFechaFactura,@txtNroFactura,@txtNroAutorizacion,@txtNitCliente,@txtNombreRazon,@decImporteTotal,@decImporteImpuestos,@decExportacionesExentos,@decVentasTasaCero,@decSubTotal,@decDescuentos,@decImporteBaseDF,@decDebitoFiscal,@txtCodigoControl,@fkLibro,@intIdUsuario,@intIdUsuario)
SET @pkRegistro = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_DETALLELIBROVENTAS'

PRINT 'CREATE PROCEDURE INSERT_LLAVEFACTURA'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_LlaveFactura]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_LlaveFactura]
END
GO

CREATE PROCEDURE [PAR].[Insert_LlaveFactura]
@pkLlave						int OUTPUT,
@txtNroAutorizacion				varchar (20),
@txtLlave						varchar (256),
@dateFechaLimite				datetime, 
@intIdUsuario				int
AS
BEGIN
INSERT INTO [PAR].[tblLLavesFacturas](txtNroAutorizacion,txtLlave,dateFechaLimite,intIdUsuarioCreacion,intIdUsuarioModificacion)
 values (@txtNroAutorizacion,CONVERT(VARBINARY(256),@txtLlave),@dateFechaLimite,@intIdUsuario,@intIdUsuario)
SET @pkLlave = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_LLAVEFACTURA'

PRINT 'CREATE PROCEDURE INSERT_GANANCIAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Insert_Ganancias]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Insert_Ganancias]
END
GO

CREATE PROCEDURE [PAR].[Insert_Ganancias]
@pkGanancia				int OUTPUT,
@fkProducto				int,
@intCantidad			int,
@decValorCompra			decimal(18,2),
@decValorVenta			decimal(18,2),
@decTotal				decimal(18,2)
AS
BEGIN
INSERT INTO [PAR].[tblGanancias](fkProducto, intCantidad, decValorCompra, decValorVenta, decTotal) 
values (@fkProducto, @intCantidad, @decValorCompra, @decValorVenta, @decTotal)
SET @pkGanancia = SCOPE_IDENTITY() 
END
GO
PRINT 'END PROCEDURE INSERT_GANANCIAS'

PRINT 'END PROCEDURES INSERT'
PRINT '----------------------------------------------------------------------------------------------'
PRINT 'CREATE PROCEDURES UPDATE'

PRINT 'CREATE PROCEDURE UPDATE_PERSON'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Person]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Person]
END
GO

CREATE PROCEDURE [PAR].[Update_Person]
@pkPerson					int,
@txtNit						varchar(100),
@txtFullName				varchar(100),
@txtAddress					varchar(100),
@txtTelephone				varchar(100),
@txtCellPhone				varchar(100),
@txtEmail					varchar(100),
@intIdUsuario				int
AS
BEGIN
Update [PAR].[tblPersonas] set txtNit=@txtNit, txtNombreCompleto=@txtFullName, txtDireccion=@txtAddress,txtTelefono=@txtTelephone,
								txtCelular=@txtCellPhone,txtCorreo=@txtEmail,dateFechaModificacion= GETDATE(),
								intIdUsuarioModificacion=@intIdUsuario
where pkPersona=@pkPerson
END
GO
PRINT 'END PROCEDURE UPDATE_PERSON'

PRINT 'CREATE PROCEDURE UPDATE_CLIENT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Client]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Client]
END
GO

CREATE PROCEDURE [PAR].[Update_Client]
@fkPerson				int,
@fkParameterPerson		int
AS
BEGIN
Update [PAR].[tblClientes] set fkParametroCliente=@fkParameterPerson
where fkPersona=@fkPerson
END
GO
PRINT 'END PROCEDURE UPDATE_CLIENT'


PRINT 'CREATE PROCEDURE UPDATE_EMPLOYEE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Employee]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Employee]
END
GO

CREATE PROCEDURE [PAR].[Update_Employee]
@fkPerson				int,
@txtPassword			varchar(100)
AS
BEGIN
Update [PAR].[tblEmpleados] set txtContraseña=CONVERT(VARBINARY(100),@txtPassword)
where fkPersona=@fkPerson
END
GO
PRINT 'END PROCEDURE UPDATE_EMPLOYEE'


PRINT 'CREATE PROCEDURE UPDATE_ADMIN'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Admin]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Admin]
END
GO

CREATE PROCEDURE [PAR].[Update_Admin]
@fkPerson				int,
@txtPassword			varchar(100)
AS
BEGIN
Update [PAR].[tblAdministrador] set txtContraseña=CONVERT(VARBINARY(100),@txtPassword)
where fkPersona=@fkPerson
END
GO
PRINT 'END PROCEDURE UPDATE_ADMIN'

PRINT 'CREATE PROCEDURE UPDATE_PROVIDER'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Provider]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Provider]
END
GO

CREATE PROCEDURE [PAR].[Update_Provider]
@fkPerson			int,
@txtDescription		varchar(1000)
AS
BEGIN
Update [PAR].[tblProveedores] set txtDescripcion=@txtDescription
where fkPersona=@fkPerson
END
GO
PRINT 'END PROCEDURE UPDATE_PROVIDER'

PRINT 'CREATE PROCEDURE UPDATE_PRODUCT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Product]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Product]
END
GO

CREATE PROCEDURE [PAR].[Update_Product]
@pkProduct			int,
@fkProvider			int,
@txtCode			varchar(100),
@txtName			varchar(100),
@txtDescription		varchar(1000),
@intQuantity		int,
@decPurchaseValue	decimal (18,2),
@decSaleValue		decimal (18,2), 
@intSex				int,
@fkMarck			int,
@fkModel			int,
@fkSize				int,
@intIdUsuario		int
AS
BEGIN
Update [PAR].[tblProductos] set fkProveedor=@fkProvider, txtCodigo=@txtCode,txtNombre=@txtName,txtDescripcion=@txtDescription,
								intCantidad=@intQuantity, decValorCompra=@decPurchaseValue, decValorVenta=@decSaleValue,
								intGenero=@intSex, fkMarca=@fkMarck, fkModelo=@fkModel, fkTalla=@fkSize,
								intIdUsuarioModificacion=@intIdUsuario, dateFechaModificacion=getdate()
where pkProducto=@pkProduct
END
GO
PRINT 'END PROCEDURE UPDATE_PRODUCT'

PRINT 'CREATE PROCEDURE UPDATE_MARK'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Mark]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Mark]
END
GO

CREATE PROCEDURE [PAR].[Update_Mark]
@pkMark				int,
@txtName			varchar(100),
@intIdUsuario		int
AS
BEGIN
Update [PAR].[tblMarcas] set	txtNombre=@txtName,intIdUsuarioModificacion=@intIdUsuario, dateFechaModificacion=getdate()
where pkMarca=@pkMark
END
GO
PRINT 'END PROCEDURE UPDATE_MARK'

PRINT 'CREATE PROCEDURE UPDATE_MODEL'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Model]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Model]
END
GO

CREATE PROCEDURE [PAR].[Update_Model]
@pkModel			int,
@txtName			varchar(100),
@intIdUsuario		int
AS
BEGIN
Update [PAR].[tblModelos] set	txtNombre=@txtName,intIdUsuarioModificacion=@intIdUsuario, dateFechaModificacion=getdate()
where pkModelo=@pkModel
END
GO
PRINT 'END PROCEDURE UPDATE_MODEL'

PRINT 'CREATE PROCEDURE UPDATE_SIZE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Size]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Size]
END
GO

CREATE PROCEDURE [PAR].[Update_Size]
@pkSize				int,
@txtName			varchar(100),
@intIdUsuario		int
AS
BEGIN
Update [PAR].[tblTallas] set	txtNombre=@txtName,intIdUsuarioModificacion=@intIdUsuario, dateFechaModificacion=getdate()
where pkTalla=@pkSize
END
GO
PRINT 'END PROCEDURE UPDATE_SIZE'

PRINT 'CREATE PROCEDURE UPDATE_DISCOUNT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Discount]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Discount]
END
GO

CREATE PROCEDURE [PAR].[Update_Discount]
@pkDiscount			int,
@txtName			varchar(250),
@dateStartDate		date,
@dateEndDate		date,
@intDiscount		int,
@txtDescription		varchar(1000),
@intIdUsuario		int
AS
BEGIN
Update [PAR].[tblDescuentos] set txtNombre=@txtName, dateFechaInicio=@dateStartDate,dateFechaFin=@dateEndDate,
								 intDescuento=@intDiscount,txtDescripcion=@txtDescription,intIdUsuarioModificacion=@intIdUsuario,
								 dateFechaModificacion=GETDATE()
where pkDescuento=@pkDiscount
END
GO
PRINT 'END PROCEDURE UPDATE_DISCOUNT'


PRINT 'CREATE PROCEDURE UPDATE_OFFER'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Offer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Offer]
END
GO

CREATE PROCEDURE [PAR].[Update_Offer]
@pkOffer			int,
@txtName			varchar(100),
@dateStartDate		date,
@dateEndDate		date,
@txtDescription		varchar(1000),
@intIDUsuario		int
AS
BEGIN
Update [PAR].[tblOfertas] set txtNombre=@txtName, dateFechaInicio=@dateStartDate,dateFechafin=@dateEndDate,
							  txtDescripcion=@txtDescription, intIdUsuarioModificacion=@intIDUsuario,
							  dateFechaModificacion=GETDATE()
where pkOferta=@pkOffer
END
GO
PRINT 'END PROCEDURE UPDATE_OFFER'

PRINT 'CREATE PROCEDURE UPDATE_PARAMETERCLIENT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_ParameterClient]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_ParameterClient]
END
GO

CREATE PROCEDURE [PAR].[Update_ParameterClient]
@pkParameterClient		int,
@txtDescription			varchar(1000),
@intIdUsuario			int
AS
BEGIN
Update [PAR].[tblParametroClientes] set txtDescripcion=@txtDescription,intIdUsuarioModificacion=@intIdUsuario,
										dateFechaModificacion=GETDATE()
where pkParametroCliente=@pkParameterClient
END
GO
PRINT 'END PROCEDURE UPDATE_PARAMETERCLIENT'


PRINT 'CREATE PROCEDURE UPDATE_COIN'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_Coin]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_Coin]
END
GO

CREATE PROCEDURE [PAR].[Update_Coin]
@pkCoin					int,
@decimalCoinType		decimal (18,2),
@intIdUsuario			int
AS
BEGIN
Update [PAR].[tblMonedas] set decTipoCambio=@decimalCoinType, intIdUsuarioModificacion=@intIdUsuario,
							  dateFechaModificacion=GETDATE()
where pkMoneda=@pkCoin
END
GO
PRINT 'END PROCEDURE UPDATE_COIN'


PRINT 'CREATE PROCEDURE UPDATE_VARIATIONSPRICEPRODUCT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_VariationPriceProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_VariationPriceProduct]
END
GO

CREATE PROCEDURE [PAR].[Update_VariationPriceProduct]
@pkVariation					int,
@fkProducto						int,
@intQuantity					int,
@decPurchaseValue				decimal (18,2),
@intIdUsuario					int
AS
BEGIN
Update [PAR].[tblVariacionesPrecioProducto] set fkProducto= @fkProducto,intCantidad=@intQuantity,decValorCompra=@decPurchaseValue,
								intIdUsuarioModificacion=@intIdUsuario,dateFechaModificacion=GETDATE()
where pkVariacion=@pkVariation
END
GO
PRINT 'END PROCEDURE UPDATE_VARIATIONSPRICEPRODUCT'

PRINT 'CREATE PROCEDURE UPDATE_LIBROCOMPRAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_LibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_LibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Update_LibroCompras]
@pkLibro						int,
@txtMes							varchar(2),
@txtAño							varchar(4)
AS
BEGIN
UPDATE [PAR].[tblLibroCompras]
SET txtMes = @txtMes,
	txtAño = @txtAño
WHERE pkLibro = @pkLibro
END
GO
PRINT 'END PROCEDURE UPDATE_LIBROCOMPRAS'

PRINT 'CREATE PROCEDURE UPDATE_DETALLELIBROCOMPRAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_DetalleLibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_DetalleLibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Update_DetalleLibroCompras]
@pkRegistro						int,
@intNro							int,
@dateFechaFactura				datetime,
@txtNitProeveedor				varchar(15),
@txtNombreRazon					varchar(100),
@txtNroFactura					varchar(15),
@txtNroDUI						varchar(16),
@txtNroAutorizacion				varchar(15),
@decImporteTotal				decimal (18,2),
@decImporteNOSujeto				decimal (18,2),
@decSubTotal					decimal (18,2),
@decDescuentos					decimal (18,2),
@decImporteBaseCF				decimal (18,2),
@decCreditoFiscal				decimal (18,2),
@txtCodigoControl				varchar (17),
@txtTipoCompra					varchar(2),
@fkLibro						int,
@intIdUsuario					int
AS
BEGIN
UPDATE [PAR].[tblDetalleLibroCompras]
SET intNro = @intNro,
	dateFechaFactura = @dateFechaFactura,
	txtNitProeveedor = @txtNitProeveedor,
	txtNombreRazon = @txtNombreRazon,
	txtNroFactura = @txtNroFactura,
	txtNroDUI = @txtNroDUI,
	txtNroAutorizacion = @txtNroAutorizacion,
	decImporteTotal = @decImporteTotal,
	decImporteNOSujeto = @decImporteNOSujeto,
	decSubTotal = @decSubTotal,
	decDescuentos = @decDescuentos,
	decImporteBaseCF = @decImporteBaseCF,
	decCreditoFiscal = @decCreditoFiscal,
	txtCodigoControl = @txtCodigoControl,
	txtTipoCompra = @txtTipoCompra,
	fkLibro = @fkLibro,
	dateFechaModificacion =  GETDATE(),
	intIdUsuarioModificacion = @intIdUsuario
WHERE pkRegistro = @pkRegistro
END
GO
PRINT 'END PROCEDURE UPDATE_DETALLELIBROCOMPRAS'

PRINT 'CREATE PROCEDURE UPDATE_LIBROVENTAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_LibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_LibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Update_LibroVentas]
@pkLibro						int,
@txtMes							varchar(2),
@txtAño							varchar(4)
AS
BEGIN
UPDATE [PAR].[tblLibroVentas]
SET txtMes = @txtMes,
	txtAño = @txtAño
WHERE pkLibro = @pkLibro
END
GO
PRINT 'END PROCEDURE UPDATE_LIBROVENTAS'

PRINT 'CREATE PROCEDURE UPDATE_DETALLELIBROVENTAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_DetalleLibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_DetalleLibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Update_DetalleLibroVentas]
@pkRegistro						int,
@intNro							int,
@dateFechaFactura				datetime,
@txtNroFactura					varchar(15),
@txtNroAutorizacion				varchar(15),
@txtEstado						varchar(2),
@txtNitCliente					varchar	(13),
@txtNombreRazon					varchar(100),
@decImporteTotal				decimal (18,2),
@decImporteImpuestos			decimal (18,2),
@decExportacionesExentos		decimal (18,2),
@decVentasTasaCero				decimal (18,2),
@decSubTotal					decimal (18,2),
@decDescuentos					decimal (18,2),
@decImporteBaseDF				decimal (18,2),
@decDebitoFiscal				decimal (18,2),
@txtCodigoControl				varchar (17),
@fkLibro						int,
@intIdUsuario					int
AS
BEGIN
UPDATE [PAR].[tblDetalleLibroVentas]
SET intNro = @intNro,
	dateFechaFactura = @dateFechaFactura,
	txtNroFactura = @txtNroFactura,
	txtNroAutorizacion = @txtNroAutorizacion,
	txtEstado = @txtEstado,
	txtNitCliente = @txtNitCliente,
	txtNombreRazon = @txtNombreRazon,
	decImporteTotal = @decImporteTotal,
	decImporteImpuestos = @decImporteImpuestos,
	decExportacionesExentos = @decExportacionesExentos,
	decVentasTasaCero = @decVentasTasaCero,
	decSubTotal = @decSubTotal,
	decDescuentos = @decDescuentos,
	decImporteBaseDF = @decImporteBaseDF,
	decDebitoFiscal = @decDebitoFiscal,
	txtCodigoControl = @txtCodigoControl,
	fkLibro = @fkLibro,
	dateFechaModificacion =  GETDATE(),
	intIdUsuarioModificacion = @intIdUsuario
WHERE pkRegistro = @pkRegistro
END
GO
PRINT 'END PROCEDURE UPDATE_DETALLELIBROVENTAS'

PRINT 'CREATE PROCEDURE UPDATE_LLAVEFACTURA'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Update_LlaveFactura]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Update_LlaveFactura]
END
GO

CREATE PROCEDURE [PAR].[Update_LlaveFactura]
@pkLlave						int,
@txtNroAutorizacion				varchar (20),
@txtLlave						varchar (256),
@dateFechaLimite				datetime, 
@intIdUsuario				int
AS
BEGIN
UPDATE [PAR].[tblLlavesFacturas]
SET txtNroAutorizacion = @txtNroAutorizacion,
	txtLlave = CONVERT(varbinary(256),@txtLlave),
	dateFechaModificacion =  GETDATE(),
	intIdUsuarioModificacion = @intIdUsuario
WHERE pkLlave = @pkLlave
END
GO
PRINT 'END PROCEDURE UPDATE_LLAVEFACTURA'

PRINT 'END PROCEDURES UPDATE'

PRINT '-----------------------------------------------------------------------------------'

PRINT 'START PROCEDURES DELETE'

PRINT 'CREATE PROCEDURE DELETE_PERSON'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Person]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Person]
END
GO

CREATE PROCEDURE [PAR].[Delete_Person]
@pkPerson			int
AS
BEGIN
Delete from [PAR].[tblPersonas] 
where pkPersona=@pkPerson
END
GO
PRINT 'END PROCEDURE DELETE_PERSON'



PRINT 'CREATE PROCEDURE DELETE_PRODUCT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Product]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Product]
END
GO

CREATE PROCEDURE [PAR].[Delete_Product]
@pkProduct			int
AS
BEGIN
Delete from [PAR].[tblProductos] 
where pkProducto=@pkProduct
END
GO
PRINT 'END PROCEDURE DELETE_PRODUCT'

PRINT 'CREATE PROCEDURE DELETE_MARK'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Mark]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Mark]
END
GO

CREATE PROCEDURE [PAR].[Delete_Mark]
@pkMark				int
AS
BEGIN
Delete from [PAR].[tblMarcas] 
where pkMarca=@pkMark
END
GO
PRINT 'END PROCEDURE DELETE_MARK'

PRINT 'CREATE PROCEDURE DELETE_MODEL'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Model]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Model]
END
GO

CREATE PROCEDURE [PAR].[Delete_Model]
@pkModel				int
AS
BEGIN
Delete from [PAR].[tblModelos] 
where pkModelo=@pkModel
END
GO
PRINT 'END PROCEDURE DELETE_MODEL'

PRINT 'CREATE PROCEDURE DELETE_SIZE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Size]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Size]
END
GO

CREATE PROCEDURE [PAR].[Delete_Size]
@pkSize				int
AS
BEGIN
Delete from [PAR].[tblTallas] 
where pkTalla=@pkSize
END
GO
PRINT 'END PROCEDURE DELETE_SIZE'

PRINT 'CREATE PROCEDURE DELETE_DISCOUNT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Discount]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Discount]
END
GO

CREATE PROCEDURE [PAR].[Delete_Discount]
@pkDiscount			int
AS
BEGIN
Delete from [PAR].[tblDescuentos] 
where pkDescuento=@pkDiscount
END
GO
PRINT 'END PROCEDURE DELETE_DISCOUNT'


PRINT 'CREATE PROCEDURE DELETE_PARAMETERCLIENT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_ParameterClient]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_ParameterClient]
END
GO

CREATE PROCEDURE [PAR].[Delete_ParameterClient]
@pkParameterClient		int
AS
BEGIN
Delete from [PAR].[tblParametroClientes] 
where pkParametroCliente=@pkParameterClient
END
GO
PRINT 'END PROCEDURE DELETE_PARAMETERCLIENT'


PRINT 'CREATE PROCEDURE DELETE_SALE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Sale]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Sale]
END
GO

CREATE PROCEDURE [PAR].[Delete_Sale]
@pkSales		int
AS
BEGIN
Delete from [PAR].[tblFacturas] 
where pkFactura=@pkSales
END
GO
PRINT 'END PROCEDURE DELETE_SALE'


PRINT 'CREATE PROCEDURE DELETE_OFFER'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Offer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Offer]
END
GO

CREATE PROCEDURE [PAR].[Delete_Offer]
@pkOffer		int
AS
BEGIN
Delete from [PAR].[tblOfertas] 
where pkOferta=@pkOffer
END
GO
PRINT 'END PROCEDURE DELETE_OFFER'


PRINT 'CREATE PROCEDURE DELETE_COIN'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_Coin]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_Coin]
END
GO

CREATE PROCEDURE [PAR].[Delete_Coin]
@pkCoin		int
AS
BEGIN
Delete from [PAR].[tblMonedas] 
where pkMoneda=@pkCoin
END
GO
PRINT 'END PROCEDURE DELETE_COIN'

PRINT 'CREATE PROCEDURE DELETE_VARIATIONSPRICEPRODUCT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_VariationPriceProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_VariationPriceProduct]
END
GO

CREATE PROCEDURE [PAR].[Delete_VariationPriceProduct]
@pkVariation		int
AS
BEGIN
Delete from [PAR].[tblVariacionesPrecioProducto] 
where pkVariacion=@pkVariation
END
GO
PRINT 'END PROCEDURE DELETE_VARIATIONSPRICEPRODUCT'

PRINT 'CREATE PROCEDURE DELETE_LIBROCOMPRAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_LibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_LibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Delete_LibroCompras]
@pkLibro		int
AS
BEGIN
Delete from [PAR].[tblLibroCompras] 
where pkLibro=@pkLibro
END
GO
PRINT 'END PROCEDURE DELETE_LIBROCOMPRAS'

PRINT 'CREATE PROCEDURE DELETE_DETALLELIBROCOMPRAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_DetalleLibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_DetalleLibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Delete_DetalleLibroCompras]
@pkRegistro		int
AS
BEGIN
Delete from [PAR].[tblDetalleLibroCompras] 
where pkRegistro=@pkRegistro
END
GO
PRINT 'END PROCEDURE DELETE_DETALLELIBROCOMPRAS'

PRINT 'CREATE PROCEDURE DELETE_LIBROVENTAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_LibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_LibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Delete_LibroVentas]
@pkLibro		int
AS
BEGIN
Delete from [PAR].[tblLibroVentas] 
where pkLibro=@pkLibro
END
GO
PRINT 'END PROCEDURE DELETE_LIBROVENTAS'

PRINT 'CREATE PROCEDURE DELETE_DETALLELIBROVENTAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_DetalleLibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_DetalleLibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Delete_DetalleLibroVentas]
@pkRegistro		int
AS
BEGIN
Delete from [PAR].[tblDetalleLibroVentas] 
where pkRegistro=@pkRegistro
END
GO
PRINT 'END PROCEDURE DELETE_DETALLELIBROVENTAS'

PRINT 'CREATE PROCEDURE DELETE_LLAVEFACTURA'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Delete_LlaveFactura]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Delete_LlaveFactura]
END
GO

CREATE PROCEDURE [PAR].[Delete_LlaveFactura]
@pkLlave						int
AS
BEGIN
DELETE FROM [PAR].[tblLlavesFacturas]
WHERE pkLlave = @pkLlave
END
GO
PRINT 'END PROCEDURE DELETE_LLAVEFACTURA'

PRINT 'END PROCEDURES DELETE'

PRINT 'START PROCEDURES GET'


PRINT 'CREATE PROCEDURE GET_ALLPERSONS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllPersons]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllPersons]
END
GO

CREATE PROCEDURE [PAR].[Get_AllPersons]
AS
BEGIN
SELECT	P.pkPersona, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo
FROM	[PAR].[tblPersonas] P
where	P.bitEstado = 1 		
END
GO
PRINT 'END PROCEDURE GET_ALLPERSONS'


PRINT 'CREATE PROCEDURE GET_ALLCLIENTS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllClients]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllClients]
END
GO

CREATE PROCEDURE [PAR].[Get_AllClients]
AS
BEGIN
SELECT  P.pkPersona, C.pkCliente, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PC.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblClientes] C, [PAR].[tblParametroClientes] PC
where	P.pkPersona= C.fkPersona
and		PC.pkParametroCliente=C.fkParametroCliente
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLCLIENTS'

PRINT 'CREATE PROCEDURE GET_CLIENTBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ClientByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ClientByID]
END
GO

CREATE PROCEDURE [PAR].[Get_ClientByID]
@pkCliente			int
AS
BEGIN
SELECT  P.pkPersona, C.pkCliente, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PC.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblClientes] C, [PAR].[tblParametroClientes] PC
where	C.pkCliente = @pkCliente
and		P.pkPersona= C.fkPersona
and		PC.pkParametroCliente=C.fkParametroCliente
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_CLIENTBYID'

PRINT 'CREATE PROCEDURE GET_CLIENTBYNIT'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ClientByNit]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ClientByNit]
END
GO

CREATE PROCEDURE [PAR].[Get_ClientByNit]
@txtNit			varchar(100)
AS
BEGIN
SELECT  P.pkPersona, C.pkCliente, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PC.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblClientes] C, [PAR].[tblParametroClientes] PC
where	P.txtNit = @txtNit
and		P.pkPersona= C.fkPersona
and		PC.pkParametroCliente=C.fkParametroCliente
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_CLIENTBYNIT'

PRINT 'CREATE PROCEDURE GET_ALLPROVIDERS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllProviders]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllProviders]
END
GO

CREATE PROCEDURE [PAR].[Get_AllProviders]
AS
BEGIN
SELECT  P.pkPersona, PV.pkProveedor , P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PV.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblProveedores] PV
where	P.pkPersona= PV.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLPROVIDERS'

PRINT 'CREATE PROCEDURE GET_PROVIDERBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProviderByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProviderByID]
END
GO

CREATE PROCEDURE [PAR].[Get_ProviderByID]
@pkProvider			int
AS
BEGIN
SELECT  P.pkPersona, PV.pkProveedor , P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PV.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblProveedores] PV
where	PV.pkProveedor = @pkProvider
and		P.pkPersona= PV.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PROVIDERBYID'

PRINT 'CREATE PROCEDURE GET_PROVIDERBYNAME'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProviderByName]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProviderByName]
END
GO

CREATE PROCEDURE [PAR].[Get_ProviderByName]
@txtNombre			varchar(100)
AS
BEGIN
SELECT  P.pkPersona, PV.pkProveedor , P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo,PV.txtDescripcion
FROM	[PAR].[tblPersonas] P, [PAR].[tblProveedores] PV
where	P.pkPersona= PV.fkPersona
and		P.txtNombreCompleto LIKE @txtNombre
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PROVIDERBYNAME'

PRINT 'CREATE PROCEDURE GET_ALLEMPLOYEES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllEmployees]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllEmployees]
END
GO

CREATE PROCEDURE [PAR].[Get_AllEmployees]
AS
BEGIN
SELECT  P.pkPersona, E.pkEmpleado, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo, CONVERT(VARCHAR(100),E.txtContraseña) AS 'txtContraseña'
FROM	[PAR].[tblPersonas] P, [PAR].[tblEmpleados] E
where	P.pkPersona= E.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLEMPLOYEES'

PRINT 'CREATE PROCEDURE GET_EMPLOYEEBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_EmployeeByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_EmployeeByID]
END
GO

CREATE PROCEDURE [PAR].[Get_EmployeeByID]
@pkEmpleado			int
AS
BEGIN
SELECT  P.pkPersona, E.pkEmpleado, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo, CONVERT(VARCHAR(100),E.txtContraseña) AS 'txtContraseña'
FROM	[PAR].[tblPersonas] P, [PAR].[tblEmpleados] E
where	E.pkEmpleado = @pkEmpleado
and		P.pkPersona= E.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_EMPLOYEEBYID'

PRINT 'CREATE PROCEDURE GET_ALLADMINS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllAdmins]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllAdmins]
END
GO

CREATE PROCEDURE [PAR].[Get_AllAdmins]
AS
BEGIN
SELECT  P.pkPersona, A.pkAdministrador, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo, CONVERT(VARCHAR(100),A.txtContraseña) AS 'txtContraseña'
FROM	[PAR].[tblPersonas] P, [PAR].[tblAdministrador] A
where	P.pkPersona= A.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLADMINS'

PRINT 'CREATE PROCEDURE GET_ADMINBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AdminByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AdminByID]
END
GO

CREATE PROCEDURE [PAR].[Get_AdminByID]
@pkAdministrador			int
AS
BEGIN
SELECT  P.pkPersona, A.pkAdministrador, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo, CONVERT(VARCHAR(100),A.txtContraseña) AS 'txtContraseña'
FROM	[PAR].[tblPersonas] P, [PAR].[tblAdministrador] A
where	A.pkAdministrador = @pkAdministrador
and		P.pkPersona= A.fkPersona
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ADMINBYID'

PRINT 'CREATE PROCEDURE GET_EMPLOYEEBYNAME'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_EmployeeByName]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_EmployeeByName]
END
GO

CREATE PROCEDURE [PAR].[Get_EmployeeByName]
@txtNombre			varchar(100)
AS
BEGIN
SELECT  P.pkPersona, E.pkEmpleado, P.txtNit, P.txtNombreCompleto, P.txtDireccion, P.txtTelefono, P.txtCelular, P.txtCorreo, CONVERT(VARCHAR(100),E.txtContraseña) AS 'txtContraseña'
FROM	[PAR].[tblPersonas] P, [PAR].[tblEmpleados] E
where	P.pkPersona= E.fkPersona
and		P.txtNombreCompleto LIKE @txtNombre
and		P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_EMPLOYEEBYNAME'

PRINT 'CREATE PROCEDURE GET_ALLOFFERS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllOffers]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllOffers]
END
GO

CREATE PROCEDURE [PAR].[Get_AllOffers]
AS
BEGIN
SELECT pkOferta, txtNombre, dateFechaInicio, dateFechafin, txtDescripcion
FROM [PAR].[tblOfertas]
END
GO
PRINT 'END PROCEDURE GET_ALLOFFERS'

PRINT 'CREATE PROCEDURE GET_OFFERBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_OfferByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_OfferByID]
END
GO

CREATE PROCEDURE [PAR].[Get_OfferByID]
@pkOferta			int
AS
BEGIN
SELECT pkOferta, txtNombre, dateFechaInicio, dateFechafin, txtDescripcion
FROM [PAR].[tblOfertas]
WHERE pkOferta= @pkOferta
END
GO
PRINT 'END PROCEDURE GET_OFFERBYID'

PRINT 'CREATE PROCEDURE GET_ALLCOINS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllCoins]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllCoins]
END
GO

CREATE PROCEDURE [PAR].[Get_AllCoins]
AS
BEGIN
SELECT pkMoneda, decTipoCambio
FROM [PAR].[tblMonedas]
END
GO
PRINT 'END PROCEDURE GET_ALLCOINS'

PRINT 'CREATE PROCEDURE GET_COINBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_CoinByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_CoinByID]
END
GO

CREATE PROCEDURE [PAR].[Get_CoinByID]
@pkCoin				int
AS
BEGIN
SELECT pkMoneda, decTipoCambio
FROM [PAR].[tblMonedas]
WHERE pkMoneda= @pkCoin
END
GO
PRINT 'END PROCEDURE GET_COINBYID'

PRINT 'CREATE PROCEDURE GET_ALLPARAMETROCLIENTES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllParametroClientes]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllParametroClientes]
END
GO

CREATE PROCEDURE [PAR].[Get_AllParametroClientes]
AS
BEGIN
SELECT pkParametroCliente,txtDescripcion
FROM [PAR].[tblParametroClientes]
where bitEstado = 1
END
GO
PRINT 'END PROCEDURE GET_ALLPARAMETROCLIENTES'

PRINT 'CREATE PROCEDURE GET_CLIENTPARAMETERBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ClientParameterByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ClientParameterByID]
END
GO

CREATE PROCEDURE [PAR].[Get_ClientParameterByID]
@pkParameter				int
AS
BEGIN
SELECT pkParametroCliente,txtDescripcion
FROM [PAR].[tblParametroClientes]
where pkParametroCliente = @pkParameter
and	bitEstado = 1
END
GO
PRINT 'END PROCEDURE GET_CLIENTPARAMETERBYID'

PRINT 'CREATE PROCEDURE GET_ALLPRODUCTOS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllProductos]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllProductos]
END
GO

CREATE PROCEDURE [PAR].[Get_AllProductos]
AS
BEGIN
SELECT P.pkProducto,P.fkProveedor,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkMarca, P.fkModelo, P.fkTalla
		,PE.txtNombreCompleto 
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE
where Pr.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLPRODUCTOS'

PRINT 'CREATE PROCEDURE GET_ALLPRODUCTOSCOMPLETO'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllProductosCompleto]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllProductosCompleto]
END
GO

CREATE PROCEDURE [PAR].[Get_AllProductosCompleto]
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where Pr.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and   P.fkTalla = T.pkTalla
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_ALLPRODUCTOSCOMPLETO'

PRINT 'CREATE PROCEDURE GET_PRODUCTBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductByID]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductByID]
@pkProducto			int
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.pkProducto = @pkProducto
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and   P.fkTalla = T.pkTalla
and	  P.bitEstado=1
and	  Pr.pkProveedor=P.fkProveedor
END
GO
PRINT 'END PROCEDURE GET_PRODUCTBYID'

PRINT 'CREATE PROCEDURE GET_ALLGANANCIAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllGanancias]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllGanancias]
END
GO

CREATE PROCEDURE [PAR].[Get_AllGanancias]
AS
BEGIN
SELECT pkGanancias, fkProducto, intCantidad, decValorCompra, decValorVenta, decTotal
FROM [PAR].[tblGanancias]
END
GO
PRINT 'END PROCEDURE GET_ALLGANANCIAS'

PRINT 'CREATE PROCEDURE GET_PRODUCTBYCODE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductByCode]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductByCode]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductByCode]
@txtCode		varchar(100)
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.txtCodigo = @txtCode
and   Pr.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and   P.fkTalla = T.pkTalla
and	  P.bitEstado=1

END
GO
PRINT 'END PROCEDURE GET_PRODUCTBYCODE'

PRINT 'CREATE PROCEDURE GET_PRODUCTSBYNAME'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductsByName]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductsByName]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductsByName]
@txtNombre			varchar(100)
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.txtNombre LIKE '%'+@txtNombre+'%'
and   PR.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and   P.fkTalla = T.pkTalla
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PRODUCTSBYNAME'


PRINT 'CREATE PROCEDURE GET_PRODUCTSBYSIZE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductsBySize]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductsBySize]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductsBySize]
@talla			int
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.fkTalla = @talla
and   P.fkTalla = T.pkTalla
and   PR.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PRODUCTSBYSIZE'

PRINT 'CREATE PROCEDURE GET_PRODUCTSBYMODEL'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductsByModel]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductsByModel]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductsByModel]
@modelo			int
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.fkModelo = @modelo
and   P.fkModelo = Mo.pkModelo
and   P.fkTalla = T.pkTalla
and   PR.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and	  P.fkMarca = M.pkMarca
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PRODUCTSBYMODEL'

PRINT 'CREATE PROCEDURE GET_PRODUCTSBYMARK'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductsByMark]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductsByMark]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductsByMark]
@marca		int
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.fkMarca = @marca
and   P.fkMarca = M.pkMarca
and   P.fkModelo = Mo.pkModelo
and   P.fkTalla = T.pkTalla
and   PR.pkProveedor=P.fkProveedor
and	  PR.fkPersona = PE.pkPersona
and	  P.bitEstado=1
END
GO
PRINT 'END PROCEDURE GET_PRODUCTSBYMARK'

PRINT 'CREATE PROCEDURE GET_ALLSALES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllSales]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllSales]
END
GO

CREATE PROCEDURE [PAR].[Get_AllSales]
AS
BEGIN
SELECT	pkFactura, fkCliente, fkEmpleado, fkDescuento, fkMoneda, txtNroFactura, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', decTotal, intIdUsuarioCreacion
FROM [PAR].[tblFacturas] 
END
GO
PRINT 'END PROCEDURE GET_ALLSALES'

PRINT 'CREATE PROCEDURE GET_SALEBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_SaleById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_SaleById]
END
GO

CREATE PROCEDURE [PAR].[Get_SaleById]
@pkFactura				int
AS
BEGIN
SELECT	pkFactura, fkCliente, fkEmpleado, fkDescuento, fkMoneda, txtNroFactura, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', decTotal, intIdUsuarioCreacion
FROM [PAR].[tblFacturas] 
WHERE pkFactura = @pkFactura
END
GO
PRINT 'END PROCEDURE GET_SALEBYID'

PRINT 'CREATE PROCEDURE GET_LASTSALE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LastSale]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LastSale]
END
GO

CREATE PROCEDURE [PAR].[Get_LastSale]
AS
BEGIN
SELECT TOP 1 pkFactura, fkCliente, fkEmpleado, fkDescuento, fkMoneda, txtNroFactura, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', decTotal, intIdUsuarioCreacion
FROM [PAR].[tblFacturas] 
ORDER BY pkFactura DESC
END
GO
PRINT 'END PROCEDURE GET_LASTSALE'

PRINT 'CREATE PROCEDURE GET_ALLDETAILSALES'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllDetailSales]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllDetailSales]
END
GO

CREATE PROCEDURE [PAR].[Get_AllDetailSales]
AS
BEGIN
SELECT * 
FROM [PAR].[tblDetalleVentas]
END
GO
PRINT 'END PROCEDURE GET_ALLDETAILSALES'

PRINT 'CREATE PROCEDURE GET_DETAILSALEBYIDBILL'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DetailSaleByIdBill]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DetailSaleByIdBill]
END
GO

CREATE PROCEDURE [PAR].[Get_DetailSaleByIdBill]
@pkBill			int
AS
BEGIN
SELECT * 
FROM [PAR].[tblDetalleVentas]
WHERE fkFactura = @pkBill
END
GO
PRINT 'END PROCEDURE GET_DETAILSALEBYIDBILL'

PRINT 'CREATE PROCEDURE GET_ALLMARKS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllMarks]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllMarks]
END
GO

CREATE PROCEDURE [PAR].[Get_AllMarks]
AS
BEGIN
SELECT pkMarca, txtNombre
FROM [PAR].[tblMarcas]
END
GO
PRINT 'END PROCEDURE GET_ALLMARKS'

PRINT 'CREATE PROCEDURE GET_MARKBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_MarkByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_MarkByID]
END
GO

CREATE PROCEDURE [PAR].[Get_MarkByID]
@pkMark				int
AS
BEGIN
SELECT pkMarca, txtNombre
FROM [PAR].[tblMarcas]
WHERE pkMarca = @pkMark
END
GO
PRINT 'END PROCEDURE GET_MARKBYID'

PRINT 'CREATE PROCEDURE GET_ALLMODELS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllModels]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllModels]
END
GO

CREATE PROCEDURE [PAR].[Get_AllModels]
AS
BEGIN
SELECT pkModelo, txtNombre
FROM [PAR].[tblModelos]
END
GO
PRINT 'END PROCEDURE GET_ALLMODELS'

PRINT 'CREATE PROCEDURE GET_MODELBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ModelByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ModelByID]
END
GO

CREATE PROCEDURE [PAR].[Get_ModelByID]
@pkModel				int
AS
BEGIN
SELECT pkModelo, txtNombre
FROM [PAR].[tblModelos]
WHERE pkModelo = @pkModel
END
GO
PRINT 'END PROCEDURE GET_MODELBYID'

PRINT 'CREATE PROCEDURE GET_ALLSIZES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllSizes]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllSizes]
END
GO

CREATE PROCEDURE [PAR].[Get_AllSizes]
AS
BEGIN
SELECT pkTalla, txtNombre
FROM [PAR].[tblTallas]
END
GO
PRINT 'END PROCEDURE GET_ALLSIZES'


PRINT 'CREATE PROCEDURE GET_ALLDISCOUNTS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllDiscounts]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllDiscounts]
END
GO

CREATE PROCEDURE [PAR].[Get_AllDiscounts]
AS
BEGIN
SELECT pkDescuento, txtNombre, dateFechaInicio, dateFechaFin, intDescuento,txtDescripcion
FROM [PAR].[tblDescuentos]
END
GO
PRINT 'END PROCEDURE GET_ALLDISCOUNTS'

PRINT 'CREATE PROCEDURE GET_DISCOUNTBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DiscountByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DiscountByID]
END
GO

CREATE PROCEDURE [PAR].[Get_DiscountByID]
@pkDiscount			int
AS
BEGIN
SELECT pkDescuento, txtNombre, dateFechaInicio, dateFechaFin, intDescuento,txtDescripcion
FROM [PAR].[tblDescuentos]
WHERE pkDescuento = @pkDiscount
END
GO
PRINT 'END PROCEDURE GET_DISCOUNTBYID'

PRINT 'CREATE PROCEDURE GET_SIZEBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_SizeByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_SizeByID]
END
GO

CREATE PROCEDURE [PAR].[Get_SizeByID]
@pkSize				int
AS
BEGIN
SELECT pkTalla, txtNombre
FROM [PAR].[tblTallas]
WHERE pkTalla = @pkSize
END
GO
PRINT 'END PROCEDURE GET_SIZEBYID'

PRINT 'CREATE PROCEDURE GET_ALLLIBROCOMPRAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllLibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllLibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Get_AllLibroCompras]
AS
BEGIN
SELECT *
FROM [PAR].[tblLibroCompras]
END
GO
PRINT 'END PROCEDURE GET_ALLLIBROCOMPRAS'

PRINT 'CREATE PROCEDURE GET_LIBROCOMPRASBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LibroComprasByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LibroComprasByID]
END
GO

CREATE PROCEDURE [PAR].[Get_LibroComprasByID]
@pkLibro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblLibroCompras]
WHERE pkLibro = @pkLibro
END
GO
PRINT 'END PROCEDURE GET_LIBROCOMPRASBYID'

PRINT 'CREATE PROCEDURE GET_ALLDETALLELIBROCOMPRAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllDetalleLibroCompras]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllDetalleLibroCompras]
END
GO

CREATE PROCEDURE [PAR].[Get_AllDetalleLibroCompras]
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroCompras]
END
GO
PRINT 'END PROCEDURE GET_ALLDETALLELIBROCOMPRAS'

PRINT 'CREATE PROCEDURE GET_DETALLELIBROCOMPRASBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DetalleLibroComprasByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DetalleLibroComprasByID]
END
GO

CREATE PROCEDURE [PAR].[Get_DetalleLibroComprasByID]
@pkRegistro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroCompras]
WHERE pkRegistro = @pkRegistro
END
GO
PRINT 'END PROCEDURE GET_DETALLELIBROCOMPRASBYID'

PRINT 'CREATE PROCEDURE GET_DETALLELIBROCOMPRASBYIDLIBRO'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DetalleLibroComprasByIdLibro]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DetalleLibroComprasByIdLibro]
END
GO

CREATE PROCEDURE [PAR].[Get_DetalleLibroComprasByIdLibro]
@idLibro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroCompras]
WHERE fkLibro= @idlibro
END
GO
PRINT 'END PROCEDURE GET_DETALLELIBROCOMPRASBYIDLIBRO'

PRINT 'CREATE PROCEDURE GET_ALLLIBROVENTAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllLibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllLibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Get_AllLibroVentas]
AS
BEGIN
SELECT *
FROM [PAR].[tblLibroVentas]
END
GO
PRINT 'END PROCEDURE GET_ALLLIBROVENTAS'

PRINT 'CREATE PROCEDURE GET_LIBROVENTASBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LibroVentasByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LibroVentasByID]
END
GO

CREATE PROCEDURE [PAR].[Get_LibroVentasByID]
@pkLibro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblLibroVentas]
WHERE pkLibro = @pkLibro
END
GO
PRINT 'END PROCEDURE GET_LIBROVENTASBYID'

PRINT 'CREATE PROCEDURE GET_ALLDETALLELIBROVENTAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllDetalleLibroVentas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllDetalleLibroVentas]
END
GO

CREATE PROCEDURE [PAR].[Get_AllDetalleLibroVentas]
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroVentas]
END
GO
PRINT 'END PROCEDURE GET_ALLDETALLELIBROVENTAS'

PRINT 'CREATE PROCEDURE GET_DETALLELIBROVENTASBYID'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DetalleLibroVentasByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DetalleLibroVentasByID]
END
GO

CREATE PROCEDURE [PAR].[Get_DetalleLibroVentasByID]
@pkRegistro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroVentas]
WHERE pkRegistro = @pkRegistro
END
GO
PRINT 'END PROCEDURE GET_DETALLELIBROVENTASBYID'

PRINT 'CREATE PROCEDURE GET_DETALLELIBROVENTASBYIDLIBRO'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_DetalleLibroVentasByIdLibro]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_DetalleLibroVentasByIdLibro]
END
GO

CREATE PROCEDURE [PAR].[Get_DetalleLibroVentasByIdLibro]
@idLibro			int
AS
BEGIN
SELECT *
FROM [PAR].[tblDetalleLibroVentas]
WHERE fkLibro = @idLibro
END
GO
PRINT 'END PROCEDURE GET_DETALLELIBROVENTASBYIDLIBRO'

PRINT 'CREATE PROCEDURE GET_ADMINBYNITPASS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AdminByNitPass]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AdminByNitPass]
END
GO

CREATE PROCEDURE [PAR].[Get_AdminByNitPass]
@txtNit				varchar(100),
@txtPassword		varchar(100)
AS
BEGIN
SELECT A.pkAdministrador
FROM [PAR].[tblPersonas] P, [PAR].[tblAdministrador] A
WHERE P.pkPersona = A.fkPersona
AND P.txtNit = @txtNit
AND A.txtContraseña = CONVERT(varbinary(100),@txtPassword)
END
GO
PRINT 'END PROCEDURE GET_ADMINBYNITPASS'

PRINT 'CREATE PROCEDURE GET_EMPLOYEEBYNITPASS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_EmployeeByNitPass]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_EmployeeByNitPass]
END
GO

CREATE PROCEDURE [PAR].[Get_EmployeeByNitPass]
@txtNit				varchar(100),
@txtPassword		varchar(100)
AS
BEGIN
SELECT E.pkEmpleado
FROM [PAR].[tblPersonas] P, [PAR].[tblEmpleados] E
WHERE P.pkPersona = E.fkPersona
AND P.txtNit = @txtNit
AND E.txtContraseña = CONVERT(varbinary(100),@txtPassword)
END
GO
PRINT 'END PROCEDURE GET_EMPLOYEEBYNITPASS'


PRINT 'CREATE PROCEDURE GET_ADMINBYNITPASS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AdminByNitPass]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AdminByNitPass]
END
GO

CREATE PROCEDURE [PAR].[Get_AdminByNitPass]
@txtNit				varchar(100),
@txtPassword		varchar(100)
AS
BEGIN
SELECT A.pkAdministrador
FROM [PAR].[tblPersonas] P, [PAR].[tblAdministrador] A
WHERE P.pkPersona = A.fkPersona
AND P.txtNit = @txtNit
AND A.txtContraseña = CONVERT(varbinary(100),@txtPassword)
END
GO
PRINT 'END PROCEDURE GET_ADMINBYNITPASS'

PRINT 'CREATE PROCEDURE GET_ALLLLAVESFACTURAS'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllLlavesFacturas]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllLlavesFacturas]
END
GO

CREATE PROCEDURE [PAR].[Get_AllLlavesFacturas]
AS
BEGIN
SELECT pkLlave, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', dateFechaLimite
FROM [PAR].[tblLlavesFacturas]
END
GO
PRINT 'END PROCEDURE GET_ALLLLAVESFACTURAS'

PRINT 'CREATE PROCEDURE GET_LLAVEFACTURABYID'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LlaveFacturaById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LlaveFacturaById]
END
GO

CREATE PROCEDURE [PAR].[Get_LlaveFacturaById]
@pkLlave						int
AS
BEGIN
SELECT pkLlave, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', dateFechaLimite
FROM [PAR].[tblLlavesFacturas]
WHERE pkLlave = @pkLlave
END
GO
PRINT 'END PROCEDURE GET_LLAVEFACTURABYID'

PRINT 'CREATE PROCEDURE GET_LASTLLAVEFACTURA'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LastLlaveFactura]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LastLlaveFactura]
END
GO

CREATE PROCEDURE [PAR].[Get_LastLlaveFactura]
AS
BEGIN
SELECT TOP 1 pkLlave, txtNroAutorizacion, CONVERT(VARCHAR(256),txtLlave) AS 'txtLlave', dateFechaLimite
FROM [PAR].[tblLlavesFacturas]
ORDER BY pkLlave DESC
END
GO
PRINT 'END PROCEDURE GET_LASTLLAVEFACTURA'

PRINT 'CREATE PROCEDURE GET_LASTLIBROVENTA'

IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_LastLibroVenta]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_LastLibroVenta]
END
GO

CREATE PROCEDURE [PAR].[Get_LastLibroVenta]
AS
BEGIN
SELECT TOP 1 *
FROM [PAR].[tblLibroVentas]
ORDER BY pkLibro DESC
END
GO
PRINT 'END PROCEDURE GET_LASTLIBROVENTA'

PRINT 'CREATE PROCEDURE GET_NOMBREPROVEEDORES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_NombreProveedores]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_NombreProveedores]
END
GO

CREATE PROCEDURE [PAR].[Get_NombreProveedores]
AS
BEGIN
SELECT PR.pkProveedor ,P.txtNombreCompleto
from [PAR].[tblProveedores] PR, [PAR].tblPersonas P
where P.pkPersona=PR.fkPersona
END
GO
PRINT 'END PROCEDURE GET_NOMBREPROVEEDORES'


PRINT 'CREATE PROCEDURE GET_STOCKPRODUCTOS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_StockProductos]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_StockProductos]
END
GO

CREATE PROCEDURE [PAR].[Get_StockProductos]
AS
BEGIN
SELECT txtCodigo, txtNombre, txtDescripcion, intCantidad
FROM [PAR].[tblProductos]
order by intCantidad asc
END
GO
PRINT 'END PROCEDURE GET_STOCKPRODUCTOS'

PRINT 'CREATE PROCEDURE GET_PRODUCTSMORESALE'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ProductsMoreSale]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ProductsMoreSale]
END
GO

CREATE PROCEDURE [PAR].[Get_ProductsMoreSale]
AS
BEGIN
SELECT P.txtNombre, M.txtNombre as txtNombreMarca, T.txtNombre as txtNombreTalla, sum(V.intCantidad) as intCantidad
FROM [PAR].[tblProductos] P, [PAR].[tblDetalleVentas] V, [PAR].[tblMarcas] M, [PAR].[tblTallas] T  
WHERE P.fkMarca = M.pkMarca
AND P.fkTalla = T.pkTalla
and P.pkProducto = V.fkProducto
GROUP BY P.txtNombre, M.txtNombre, T.txtNombre
order by intCantidad desc
END
GO
PRINT 'END PROCEDURE GET_PRODUCTSMORESALE'

PRINT 'CREATE PROCEDURE GET_SALESBETWEENDATES'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_SalesBetweenDates]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_SalesBetweenDates]
END
GO

CREATE PROCEDURE [PAR].[Get_SalesBetweenDates]
@dtFechaInicio			datetime,
@dtFechaFin				datetime
AS
BEGIN
SELECT *
FROM [PAR].[tblFacturas]
WHERE dateFechaCreacion BETWEEN @dtFechaInicio AND @dtFechaFin
ORDER BY dateFechaCreacion DESC
END
GO
PRINT 'END PROCEDURE GET_SALESBETWEENDATES'

PRINT 'END PROCEDURES GET'

PRINT 'CREATE PROCEDURE VALIDARSTOCK'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[ValidarStock]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[ValidarStock]
END
GO

CREATE PROCEDURE [PAR].[ValidarStock]
@pkProducto			int,
@cantidad			int
AS
BEGIN
SELECT P.pkProducto,P.txtCodigo,P.txtNombre,P.txtDescripcion,P.intCantidad,P.decValorCompra,P.decValorVenta, P.intGenero, P.fkProveedor,P.fkMarca,P.fkModelo,P.fkTalla, PE.txtNombreCompleto, M.txtNombre, T.txtNombre, Mo.txtNombre
FROM [PAR].[tblProductos] P, [PAR].[tblProveedores] PR, [PAR].[tblPersonas] PE, [PAR].[tblMarcas] M, [PAR].[tblTallas] T, [PAR].[tblModelos] Mo
where P.pkProducto = @pkProducto
and   P.intCantidad >= @cantidad
and	  PR.fkPersona = PE.pkPersona
and   P.fkModelo = Mo.pkModelo
and	  P.fkMarca = M.pkMarca
and   P.fkTalla = T.pkTalla
and	  P.bitEstado=1
and	  Pr.pkProveedor=P.fkProveedor
END
GO
PRINT 'END PROCEDURE VALIDARSTOCK'

PRINT 'CREATE PROCEDURE GET_ALLVARIACIONESPRECIOPRODUCTO'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_AllVariacionesPrecioProducto]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_AllVariacionesPrecioProducto]
END
GO

CREATE PROCEDURE [PAR].[Get_AllVariacionesPrecioProducto]
AS
BEGIN
SELECT pkVariacion, fkProducto, intCantidad, decValorCompra, decValorVenta
FROM [PAR].[tblVariacionesPrecioProducto]
END
GO
PRINT 'END PROCEDURE GET_ALLVARIACIONESPRECIOPRODUCTO'

PRINT 'CREATE PROCEDURE GET_REPORTEGANANCIAS'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ReporteGanancias]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ReporteGanancias]
END
GO

CREATE PROCEDURE [PAR].[Get_ReporteGanancias]
@dateFechaInicio			date,
@dateFechaFin				date

AS
BEGIN
select P.txtCodigo, P.txtNombre, sum(G.intCantidad) as cantidadProductosVendidos, sum(G.decTotal) as totalVendido, sum((G.decValorVenta*G.intCantidad) - (G.decValorCompra*G.intCantidad)) as totalComprado, (sum(G.decTotal)-sum((G.decValorVenta-G.decValorCompra)*G.intCantidad)) as Ganacias
from [PAR].[tblGanancias] G, [PAR].[tblProductos] P
where G.fkProducto = P.pkProducto
and G.dateFechaVenta BETWEEN @dateFechaInicio AND @dateFechaFin
group by P.txtCodigo, P.txtNombre
order by cantidadProductosVendidos desc
END
GO
PRINT 'END PROCEDURE GET_REPORTEGANANCIAS'

PRINT 'CREATE PROCEDURE GET_REPORTESTOCK'
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'[PAR].[Get_ReporteStock]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
BEGIN
	DROP PROCEDURE [PAR].[Get_ReporteStock]
END
GO

CREATE PROCEDURE [PAR].[Get_ReporteStock]
AS
BEGIN
select txtCodigo, txtNombre, txtDescripcion, intCantidad
from [PAR].[tblProductos]
order by intCantidad asc
END
GO
PRINT 'END PROCEDURE GET_REPORTESTOCK'


PRINT 'END PROCEDURES'

