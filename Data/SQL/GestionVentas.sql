use GrupoNo1

create or alter procedure spValidarCliente
@ClienteID int
as
	if not exists(select ClienteID from Cliente where ClienteID = @ClienteID)
		THROW 50051, 'No existe este cliente', 1;
go
create or alter procedure spCrearCliente
@Nombre varchar(26),
@Apellido varchar(26),
@Direccion varchar(151) =  null,
@Documento varchar(14),
@RTN varchar(15) = null,
@Telefono varchar(9)=null,
@Correo varchar(51) = null
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		if @Direccion is not null
			exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		if @Telefono is not null
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		if @Correo is not null
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		exec spValidarCorreo @Correo;
		exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		if @RTN is not null
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
		if (select COUNT(Documento) from Cliente where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(ClienteID), 0) + 1 from Cliente
			insert into cliente (ClienteID,Nombre,Apellido,Direccion,Telefono,Correo,Documento, RTN) values 
			(@ID,@Nombre, @Apellido, @Direccion, @Telefono, @Correo,@Documento,@RTN)
			
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
--Prueba de agregar un cliente
exec spCrearCliente   'Guillermo','Fernandez',null,'0501998701187',null,'98653520',null

create or alter procedure spGenerarFactura
@ClienteID int,
@Descripcion varchar(151) =  null,
@Impuesto varchar(20) = null,
@Descuento varchar(20) = null
as
	begin try
		exec spValidarCliente @ClienteID
		if @Descripcion is not null
			exec spValidarCampoVarchar 'Descripcion', @Descripcion, 0, 150;
		if @Impuesto is not null
			exec spValidarDecimal 'Impuesto', @Impuesto;
		if @Descuento is not null
			exec spValidarDecimal 'Descuento', @Descuento;
			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(FacturaID), 0) + 1 from factura
			insert into factura (FacturaID,ClienteID,Fecha,Impuesto,Descuento,Descripcion) values 
			(@ID,@ClienteID, CAST(GETDATE() AS DATE), @Impuesto, @Descuento, @Descuento)
		COMMIT TRANSACTION
		select '10000' as Estado, 'Factura creada' as Mensaje, @ID  as FacturaID--Si todo sale bien, se retornara el id de la compra, para poder agregar los insumos
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

--Prueba de coomo se actualiza el stock y se agregan registros a la tabla salidas
select * from vStockActual
exec spAgregarProductoFactura 1, '5B','102345123412',15.2,2
select * from vStockActual

create or alter procedure spAgregarProductoFactura
@FacturaID int,--a
@BodegaID varchar(2),--a
@ProductoID varchar(12),--a
@Precio varchar(20),--a
@Cantidad int,--a
@Observaciones varchar(151) = null--a
as
	begin try
		if (select COUNT(FacturaID) from Factura where FacturaID = @FacturaID) != 1
				THROW 50051, 'No existe esta factura', 1;
		exec spValidarBodega @BodegaID
		exec spValidarProducto @ProductoID
		exec spValidarDecimal 'Precio', @Precio
		exec spvalidarCampoInt @Cantidad, 'cantidad productos'

		if (select COUNT(ProductoID) from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID) != 1
			THROW 50051, 'No existe este producto en esta bodega', 1;
		if(select Cantidad from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID)<@Cantidad
			THROW 50052, 'No existe esta cantidad de producto', 1;
		
		if @Observaciones is not null
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;
			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(FacturaDetalleID), 0) + 1 from FacturaDetalle
			insert into FacturaDetalle (FacturaDetalleID,FacturaID,BodegaID,ProductoID,Precio,Cantidad,Observaciones) values 
			(@ID,@FacturaID,@BodegaID,@ProductoID, @Precio, @Cantidad, @Observaciones)
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
