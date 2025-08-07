create or alter procedure spCrearProductor
@Nombre varchar(26), 
@Apellido varchar(26), 
@Telefono varchar(9), 
@Correo varchar(51)=null,
@Documento varchar(14),
@RTN varchar(15) = null
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		exec spValidarCorreo @Correo;
		exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		if @RTN != null
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
		if (select COUNT(Documento) from productor where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(ProductorID), 0) + 1 from Productor
			insert into Productor (ProductorID,Nombre,Apellido,Telefono,Correo,EstadoID,Documento, RTN)
			values (@ID,@Nombre, @Apellido, @Telefono, @Correo,1001,@Documento,@RTN)
			SELECT '10000' as Estado, 'Se agrego correctamente el productor' AS Mensaje;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go