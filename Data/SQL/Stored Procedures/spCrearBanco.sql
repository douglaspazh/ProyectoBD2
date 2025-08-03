create or alter procedure spCrearBanco
@Nombre varchar(60)
as
	BEGIN TRY
		exec spValidarCampoVarchar 'Nombre', @Nombre, 3, 50
	
		if exists (select Nombre from Banco where Nombre=@Nombre)
			THROW 50050, 'Este registro ya existe', 1;
	
		BEGIN TRANSACTION
			declare @ID int
			select @ID = ISNULL(MAX(BancoID),0)+1 from Banco
			insert into Banco(BancoID,Nombre,EstadoID)
			values (@ID, @Nombre, 10001) --Al crear el Banco se asume que esta activo
		COMMIT TRANSACTION
		SELECT 10000 as Estado, 'Banco creado exitosamente' as Mensaje
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje
	END CATCH