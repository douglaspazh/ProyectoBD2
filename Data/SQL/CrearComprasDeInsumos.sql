create type dbo.InsumoCompra as table (
    ProductoID varchar(13),
    BodegaID varchar(3),
	Cantidad int,
	PrecioUnitario varchar(20)
);
declare @InsumosAgregar dbo.InsumoCompra;

-- Inserta datos en la variable tabla
INSERT INTO @ProductosAgregar (ProductoID, BodegaID, Cantidad, PrecioUnitario)
VALUES 
--Aqui agregar los registros de este producto

spComprarInsumos 1,@InsumosAgregar
create or alter procedure spComprarInsumos
@ProveedorID int,
@ProductosTable InsumoCompra readonly,
@Impuesto varchar(20) = null,
@Descuento varchar(20) = null
as
	begin try
		if (select COUNT(ProveedorID) from Proveedor where ProveedorID = @ProveedorID) != 1
					THROW 50051, 'No existe este proveedor', 1;
		exec spValidarDecimal 'Impuesto', @Impuesto;
		exec spValidarDecimal 'Descuento', @Descuento;

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(CompraID), 0) + 1 from Compra
			insert into Compra (CompraID, ProveedorID,Impuesto,Descuento,Fecha,EstadoID) 
				values (@ID, @ProveedorID,@Impuesto,@Descuento, CAST(GETDATE() AS DATE),null);
			--Agregar productos
			declare @ProductoID varchar(13), @BodegaID varchar(3), @Cantidad int,@PrecioUnitario varchar(20);

			declare CursorProducto cursor for 
			select ProductoID, BodegaID, 
			Cantidad ,PrecioUnitario from @ProductosTable

			open CursorProducto;
			fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@PrecioUnitario
			while @@FETCH_STATUS=0
			begin
				exec spAgregarInsumoCompra @ID,@ProductoID, @BodegaID, @Cantidad,@PrecioUnitario
				fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@PrecioUnitario
			end
			close CursorProducto;
			deallocate CursorProducto;
		COMMIT TRANSACTION
		select '10000' as Estado, 'Compra Agregada' as Mensaje, @ID as CompraID--Si todo sale bien, se retornara el id de la compra, para poder agregar los insumos
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
		exec spValidarBodega @BodegaID
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
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go
