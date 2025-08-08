
create or alter procedure spCrearBodega
@BodegaID varchar(3),
@Observaciones varchar(151) = ''
as
	begin try
		if exists(select BodegaID from Bodega where BodegaID = @BodegaID)
				THROW 50050, 'Ya existe una bodega con este identificador', 1;
		exec spValidarCampoVarchar 'Nombre Bodega', @BodegaID, 0, 2;
		if @Observaciones != ''
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;

		BEGIN TRANSACTION

			insert into Bodega (BodegaID, Observaciones) 
				values (@BodegaID, @Observaciones)
				SELECT 10000 as Estado, 'Se creo correctamente la bodega' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go