use SalesProject;

--TALLAS
insert into [PAR].[tblTallas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('3 meses',1,1);
insert into [PAR].[tblTallas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('5 meses',1,1);
insert into [PAR].[tblTallas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('1 mese',1,1);

--MARCAS
insert into [PAR].[tblMarcas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Tommy',1,1);
insert into [PAR].[tblMarcas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Carolina Herrera',1,1);
insert into [PAR].[tblMarcas](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Roberto Cavalli',1,1);

--MODELOS
insert into [PAR].[tblModelos](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Conjunto Rosa',1,1);
insert into [PAR].[tblModelos](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Conjunto Azul',1,1);
insert into [PAR].[tblModelos](txtNombre,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Conjuto Pick',1,1);

--OFERTAS
insert into [PAR].[tblOfertas](txtNombre,txtDescripcion,dateFechaInicio,dateFechafin,intIdUsuarioCreacion,intIdUsuarioModificacion)
					values('2X1','Llevate 2 prendas y paga por 1','2014/11/21','2014/11/30',1,1);

--DESCUENTOS
insert into [PAR].[tblDescuentos](txtNombre,dateFechaInicio,dateFechaFin,intDescuento,txtDescripcion,intIdUsuarioCreacion,
								intIdUsuarioModificacion) values('50% de descuento','2014/11/21','2014/11/30',50,
								'Descuento en todas las prendas',0,0);

--PARAMETRO CLIENTE
insert into [PAR].[tblParametroClientes](txtDescripcion,intIdUsuarioCreacion,intIdUsuarioModificacion)values('Normal',1,1);


--PERSONAS
insert into[PAR].[tblPersonas](txtNit,txtNombreCompleto,txtDireccion,txtTelefono,txtCelular,txtCorreo,intIdUsuarioCreacion,
								intIdUsuarioModificacion)values('1516070','Erwin Justiniano Mauriel','Av.Banzer',
								'3526898','60011111','justinianoerwin@gmail.com',1,1);
insert into[PAR].[tblPersonas](txtNit,txtNombreCompleto,txtDireccion,txtTelefono,txtCelular,txtCorreo,intIdUsuarioCreacion,
								intIdUsuarioModificacion)values('1523478','David Baldivieso Melgar','Av.Banzer',
								'3214578','79658632','baldivieso@gmail.com',1,1);
insert into[PAR].[tblPersonas](txtNit,txtNombreCompleto,txtDireccion,txtTelefono,txtCelular,txtCorreo,intIdUsuarioCreacion,
								intIdUsuarioModificacion)values('1259635','Jose Quispe Mamani','Av.Banzer',
								'3267458','7414578','quispema@gmail.com',1,1);
insert into[PAR].[tblPersonas](txtNit,txtNombreCompleto,txtDireccion,txtTelefono,txtCelular,txtCorreo,intIdUsuarioCreacion,
								intIdUsuarioModificacion)values('1111111','Admin','Minilulis',
								'72653366','72653366','eduardofc24@gmail.com',1,1);
--CLIENTES
insert into [PAR].[tblClientes](fkPersona,fkParametroCliente)values(1,1);

--EMPLEADOS
insert into [PAR].[tblEmpleados](fkPersona,txtContraseña)values(2,CONVERT(VARBINARY(100),'erwin'));

--PROVEEDORES
insert into [PAR].[tblProveedores](fkPersona,txtDescripcion)values(3,'Proveedor1');
--ADMINISTRADOR
insert into [PAR].[tblAdministrador](fkPersona,txtContraseña)values(4,CONVERT(VARBINARY(100),'admin'));

--PRODUCTOS
insert into [PAR].[tblProductos](fkProveedor,txtCodigo,txtNombre,txtDescripcion,intCantidad,decValorCompra,decValorVenta,intGenero
								,fkMarca,fkModelo,fkTalla,intIdUsuarioCreacion,intIdUsuarioModificacion)values(1,'9012354678',
								'Camisa Casual','Camisa casual para ñinos',20,10.20,15.20,0,1,1,1,1,1);
--MONEDA
insert into [PAR].[tblMonedas](decTipoCambio,intIdUsuarioCreacion,intIdUsuarioModificacion)values(12.20,1,1);

