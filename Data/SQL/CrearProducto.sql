create or alter procedure spCrearProducto
@ProductoID varchar(13),
@Nombre varchar(51),
@ContenidoPorUnidad varchar(16),
@CategoriaID int = null
as
	begin try
		exec spValidarCampoVarchar 'Codigo de producto', @ProductoID, 12, 12;--Se utiliza a manera de codigo de barras
		if exists(select ProductoID from producto where ProductoID = @ProductoID)
				THROW 50050, 'El codigo ingresado ya existe', 1;
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
		exec spValidarCampoVarchar 'contenido por unidad', @ContenidoPorUnidad, 0, 10;

		if @CategoriaID is not null
		begin 
			if not exists(select CategoriaID from categoria where CategoriaID = @CategoriaID)
				THROW 50051, 'No existe esta categoria', 1;
		end
		BEGIN TRANSACTION

			insert into Producto (ProductoID, Nombre, ContenidoPorUnidad, CategoriaID) 
				values (@ProductoID, @Nombre, @ContenidoPorUnidad, @CategoriaID)
				SELECT '10000' as Estado, 'Se creo correctamente el producto' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go