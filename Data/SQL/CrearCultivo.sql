create or alter procedure spCrearCultivo 
@ProductoID varchar(13), 
@Nombre	varchar(51), 
@Observaciones varchar(151) = null,
@CantidadPorCosecha int
as
	begin try
		exec spValidarProducto @ProductoID
		exec spValidarCampoVarchar 'Nombre', @Nombre, 1, 50;
		exec spValidarCampoInt @CantidadPorCosecha, 'Cantidad por cosecha'
		if exists(select ProductoID from Cultivo where ProductoID = @ProductoID)
			THROW 50050, 'El cultivo ya existe para ese producto', 1;
		if @Observaciones != null
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;
		BEGIN TRANSACTION
			declare @ID int;
			select @ID = ISNULL(MAX(CultivoID), 0) + 1 from Cultivo
			insert into Cultivo (CultivoID, ProductoID, Nombre, Observaciones,CantidadPorCosecha) 
			Values (@ID, @ProductoID, @Nombre, @Observaciones,@CantidadPorCosecha)
			SELECT '10000' as Estado, 'Se creo correctamente el cultivo' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		rollback transaction
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go