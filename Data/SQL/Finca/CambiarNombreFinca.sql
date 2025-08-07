create or alter procedure spCambiarNombreFinca
@FincaID int,
@Nombre varchar(51)= null
as
	begin try
		if not exists(select FincaID from Finca where FincaID = @FincaID)
				THROW 50051, 'No existe esta finca', 1;
		begin transaction
			if @Nombre is not null
			begin
				exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;		
				update Finca set Nombre=@Nombre where FincaID = @FincaID
			end
			SELECT '10000' as Estado, 'Se actualizo correctamente el nombre de la finca' AS Mensaje;
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go