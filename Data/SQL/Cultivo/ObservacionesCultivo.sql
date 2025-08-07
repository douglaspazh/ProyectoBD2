create or alter procedure spObservacionesCultivo 
@CultivoID int,
@Observaciones varchar(151) = null
as
	begin try
		if not exists(select @CultivoID from Cultivo where CultivoID=@CultivoID)
			THROW 50051, 'No existe este cultivo', 1;		
		BEGIN TRANSACTION

		if  @Observaciones is not null 
		begin
			exec spValidarCampoVarchar 'Observaciones', @CultivoID, 0, 150;
			update Cultivo set Observaciones=@Observaciones where CultivoID=@CultivoID
		end
			SELECT '10000' as Estado, 'Se actualizo correctamente el cultivo' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		rollback transaction
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go