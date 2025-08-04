use GrupoNo1

exec spCrearSolicitudInsumos 3
create or alter procedure spCrearSolicitudInsumos
@ProductorID int
as
	begin try
		if not exists(select ProductorID from productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este Productor', 1;
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(SolicitudInsumosID), 0) + 1 from SolicitudInsumos

			insert into SolicitudInsumos (SolicitudInsumosID,ProductorID,EstadoID) values 
			(@ID,@ProductorID, 30001)
			select '10000' as Estado, 'Solicitud ingresada' as Mensaje, @ID as SolicitudInsumosID--Si todo sale bien, se retornara el id de la compra, para poder agregar los insumos
		COMMIT TRANSACTION
		
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
select * from vStockActual
exec spAgregarInsumosSolicitud 2,'102345123412','5B',8,41
select * from vStockActual
select * from salidas
create or alter procedure spAgregarInsumosSolicitud
@SolicitudInsumosID int,--
@ProductoID varchar(12),--
@BodegaID varchar(12),--
@Cantidad int,
@Precio varchar(20)
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

