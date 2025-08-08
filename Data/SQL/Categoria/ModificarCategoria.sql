create or alter procedure spModificarCategoria
@CategoriaID int,
@Nombre varchar(51)='',
@Observaciones varchar(151) = ''
as
	begin try

		if not exists(select CategoriaID from categoria where CategoriaID=@CategoriaID)
			THROW 50051, 'No existe esta categoria', 1;		
		BEGIN TRANSACTION
			if  @Nombre != '' 
			begin
				exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
				update Categoria set Nombre=@Nombre where CategoriaID=@CategoriaID
			end
			if  @Observaciones != ''  
			begin
				exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;
				update Categoria set Observaciones=@Observaciones where CategoriaID=@CategoriaID
			end
			SELECT '10000' as Estado, 'Se actualizo correctamente la categoria' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go