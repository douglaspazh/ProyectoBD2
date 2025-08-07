create type dbo.InsumoCompra as table (
    ProductoID varchar(13),
    BodegaID varchar(3),
	Cantidad int,
	Precio varchar(20)--decimal(10,2)
);
declare @InsumosAgregar dbo.InsumoCompra;

-- Inserta datos en la variable tabla
INSERT INTO @InsumosAgregar (ProductoID, BodegaID, Cantidad, Precio)
VALUES ()
--Aqui agregar los registros de este producto

spComprarInsumos 1,@InsumosAgregar
create or alter procedure spComprarInsumos
@ProveedorID int,
@ProductosTable InsumoCompra readonly,
@Impuesto varchar(20) = null,--decimal(10,2)
@Descuento varchar(20) = null--decimal(10,2)
as
	begin try
		if (select COUNT(ProveedorID) from Proveedor where ProveedorID = @ProveedorID) != 1
					THROW 50051, 'No existe este proveedor', 1;
		exec spValidarDecimal 'Impuesto', @Impuesto;
		exec spValidarDecimal 'Descuento', @Descuento;

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(CompraID), 0) + 1 from Compra
			insert into Compra (CompraID, ProveedorID,Impuesto,Descuento,Fecha) 
				values (@ID, @ProveedorID,@Impuesto,@Descuento, CAST(GETDATE() AS DATE));
			--Agregar productos
			declare @ProductoID varchar(13), @BodegaID varchar(3), @Cantidad int,@Precio varchar(20);

			declare CursorProducto cursor for 
			select ProductoID, BodegaID, 
			Cantidad ,Precio from @ProductosTable

			open CursorProducto;
			fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@Precio
			while @@FETCH_STATUS=0
			begin
				exec spAgregarInsumoCompra @ID,@ProductoID, @BodegaID, @Cantidad,@Precio
				fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@Precio
			end
			close CursorProducto;
			deallocate CursorProducto;
			select '10000' as Estado, 'Compra Agregada' as Mensaje
		COMMIT TRANSACTION
		
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
@Precio varchar(20)--decimal(10,2)
as
begin try
		--Valida la existencia de un registro de esa compra
		if (select COUNT(CompraID) from Compra where CompraID = @CompraID) != 1
			THROW 50051, 'No existe esta compra', 1;
		exec spValidarBodega @BodegaID
		exec spValidarCampoInt @Cantidad, 'Cantidad de insumos';
		--Validar que existe este producto
		exec spValidarProducto @ProductoID

		exec spValidarDecimal 'Precio', @Precio;

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(CompraDetalleID), 0) + 1 from CompraDetalle
			insert into CompraDetalle (CompraDetalleID, CompraID,ProductoID,Cantidad,Precio,BodegaID) 
				values (@ID, @CompraID,@ProductoID, @Cantidad, @Precio ,@BodegaID)
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go
