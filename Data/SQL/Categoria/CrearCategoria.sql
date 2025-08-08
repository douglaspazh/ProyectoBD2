create or alter procedure spCrearCategoria
@Nombre varchar(51),
@Observaciones varchar(151) = ''
as
	begin try
		exec spValidarCampoVarchar 'Nombre Categoria', @Nombre, 0, 50;
		if @Observaciones != ''
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;

		BEGIN TRANSACTION

			insert into Categoria (Nombre, Observaciones) 
				values (@Nombre, @Observaciones)
				SELECT '10000' as Estado, 'Se agrego correctamente la categoria' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go