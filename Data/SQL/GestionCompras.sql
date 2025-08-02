use GrupoNo1

create or alter procedure spValidarProducto
@ProductoID varchar(13)
as
	if not exists(select ProductoID from Producto where ProductoID = @ProductoID)
		THROW 50051, 'No existe este producto', 1;
go

create or alter procedure spValidarEstadoID
@EstadoID int,
@tipo int
as
	--Activo inactivo
	if @tipo = 1
	begin
		if @EstadoID <= 10000 or @EstadoID >=20000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end
	--Cosechas
	if @tipo = 2
	begin
		if @EstadoID <= 20000 or @EstadoID >=30000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end
	--Gestiones 
	if @tipo = 3
	begin
		if @EstadoID <= 30000 or @EstadoID >=40000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end

go

create or alter procedure spValidarFecha
@fecha varchar(20)
as
	if ISDATE(@fecha)=0
		THROW 50004, 'Fecha invalida', 1;
go

create or alter procedure spCrearBodega
@BodegaID varchar(3),
@Observaciones varchar(151) = null
as
	begin try
		if exists(select BodegaID from Bodega where BodegaID = @BodegaID)
				THROW 50050, 'Ya existe una bodega con este identificador', 1;
		exec spValidarCampoVarchar 'Nombre Bodega', @BodegaID, 0, 2;
		if @Observaciones is not null
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;

		BEGIN TRANSACTION

			insert into Bodega (BodegaID, Observaciones) 
				values (@BodegaID, @Observaciones)
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go

create or alter procedure spComprarInsumos
@ProveedorID int,
@Impuesto varchar(20) = null,
@Descuento varchar(20) = null,
@EstadoID int = null
as
	begin try
		if (select COUNT(ProveedorID) from Proveedor where ProveedorID = @ProveedorID) != 1
					THROW 50051, 'No existe este proveedor', 1;
		exec spValidarDecimal 'Impuesto', @Impuesto;
		exec spValidarDecimal 'Descuento', @Descuento;
		if @EstadoID is not null
			exec spValidarEstadoID @EstadoID, 3

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(CompraID), 0) + 1 from Compra
			insert into Compra (CompraID, ProveedorID,Impuesto,Descuento,Fecha,EstadoID) 
				values (@ID, @ProveedorID,@Impuesto,@Descuento, CAST(GETDATE() AS DATE),@EstadoID);
		COMMIT TRANSACTION
		select @ID as CompraID
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go


create or alter procedure spAgregarInsumoCompra
@CompraID int,
@ProductoID varchar(13),
@BodegaID varchar(3),
@Cantidad int,
@PrecioUnitario varchar(20)--decimal
as
begin try
		--Valida la existencia de un registro de esa compra
		if (select COUNT(CompraID) from Compra where CompraID = @CompraID) != 1
			THROW 50051, 'No existe esta compra', 1;
		if (select COUNT(BodegaID) from Bodega where BodegaID = @BodegaID) != 1
			THROW 50051, 'No existe esta Bodega', 1;
		exec spValidarCampoInt @Cantidad, 'Cantidad de insumos';
		--Validar que existe este producto
		exec spValidarProducto @ProductoID
		--Validar que el producto lo tenga el proveedor
		if not exists(select  proi.ProductoID from Compra as c
		inner join ProveedorInsumo as proi on c.ProveedorID = proi.ProveedorID where proi.ProductoID = @ProductoID and c.CompraID = @CompraID)
				THROW 50051, 'El productor no maneja este producto', 1;

		--Validar que el producto no este agotado
		declare @ProducP varchar(13), @EstadoP int,@msg varchar(150),@nomP varchar(50); 

		select  @EstadoP= proi.EstadoID,@ProducP=proi.ProductoID from Compra as c
		inner join ProveedorInsumo as proi on c.ProveedorID = proi.ProveedorID where proi.ProductoID = @ProductoID

		select @nomP = Nombre from Producto where ProductoID=@ProducP;
		if @EstadoP = 31002
		begin
			set @msg = 'El producto '+@nomP+' no esta disponible';
			THROW 50052, @msg, 1
		end

		exec spValidarDecimal 'Precio unitario', @PrecioUnitario;

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(CompraDetalleID), 0) + 1 from CompraDetalle
			insert into CompraDetalle (CompraDetalleID, CompraID,ProductoID,Cantidad,PrecioUnitario,BodegaID) 
				values (@ID, @CompraID,@ProductoID, @Cantidad, @PrecioUnitario ,@BodegaID)
		COMMIT TRANSACTION
		return @ID --Si todo sale bien, se retornara el id de la compra, para poder agregar los insumos
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go

--Insert realizados
insert into estado (EstadoID, Nombre,Observaciones) values(31001,'Disponible','El proveedor tiene disponible este producto')
insert into estado (EstadoID, Nombre,Observaciones) values(31002,'Agotado','El proveedor tiene agotado este producto')
insert into ProveedorInsumo (ProveedorID, ProductoID, EstadoID, Precio) values (2,'102345123412',31001,400)
insert into ProveedorInsumo (ProveedorID, ProductoID, EstadoID, Precio) values (2,'102315123412',31001,82)
insert into ProveedorInsumo (ProveedorID, ProductoID, EstadoID, Precio) values (3,'985894311353',31002,37)
insert into ProveedorInsumo (ProveedorID, ProductoID, EstadoID, Precio) values (2,'985894311253',31001,8)
exec spCrearBodega '5A'
exec spCrearBodega '5B'
exec spCrearBodega '25'
spComprarInsumos 3,0.15,0.15
	spAgregarInsumoCompra 2,'102345123412','5B',5,85.2