
create type dbo.InsumoSolicitud as table (
    ProductoID varchar(13),
    BodegaID varchar(3),
	Cantidad int,
	Precio varchar(20)
);

--Este deberia ser el unico procedimiento que se deberia ejecutar
exec spCrearSolicitudInsumos
create or alter procedure spCrearSolicitudInsumos
@ProductorID int,
@ProductosTable InsumoSolicitud readonly
as
	begin try
		if not exists(select ProductorID from productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este Productor', 1;
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(SolicitudInsumosID), 0) + 1 from SolicitudInsumos

			insert into SolicitudInsumos (SolicitudInsumosID,ProductorID,EstadoID) values 
			(@ID,@ProductorID, 30001)

			--Agregar productos
			declare @ProductoID varchar(13), @BodegaID varchar(3), @Cantidad int,@Precio varchar(20);

			declare CursorProducto cursor for 
			select ProductoID, BodegaID, 
			Cantidad, Precio from @ProductosTable

			open CursorProducto;
			fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@Precio
			while @@FETCH_STATUS=0
			begin
				exec spAgregarInsumosSolicitud @ID,@ProductoID, @BodegaID, @Cantidad,@Precio
				fetch next from CursorProducto into @ProductoID, @BodegaID, @Cantidad,@Precio
			end
			close CursorProducto;
			deallocate CursorProducto;
			select '10000' as Estado, 'Solicitud ingresada' as Mensaje
		COMMIT TRANSACTION
		
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

create or alter procedure spAgregarInsumosSolicitud
@SolicitudInsumosID int,
@ProductoID varchar(13),
@BodegaID varchar(3),
@Cantidad int,
@Precio varchar(20)--decimal(10,2)
as
	begin try
		if (select COUNT(SolicitudInsumosID) from SolicitudInsumos where SolicitudInsumosID = @SolicitudInsumosID) != 1
				THROW 50051, 'No existe esta solicitud de insumos', 1;
		exec spValidarBodega @BodegaID
		exec spValidarProducto @ProductoID
		exec spValidarDecimal 'Precio', @Precio
		exec spvalidarCampoInt @Cantidad, 'cantidad productos'

		if (select COUNT(ProductoID) from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID) != 1
			THROW 50051, 'No existe este producto en esta bodega', 1;
		if(select Cantidad from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID)<@Cantidad
			THROW 50052, 'No existe esta cantidad de producto', 1;
		BEGIN TRANSACTION
			insert into SolicitudInsumosDetalle (SolicitudInsumosID,ProductoID,BodegaID,Cantidad,Precio) values 
			(@SolicitudInsumosID,@ProductoID,@BodegaID,@Cantidad, @Precio)
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

