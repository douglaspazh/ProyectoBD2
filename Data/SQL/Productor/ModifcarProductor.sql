create or alter procedure spModificarProductor
@ProductorID int,
@Nombre varchar(26)=null, 
@Apellido varchar(26)=null,  
@Telefono varchar(9)=null, 
@Correo varchar(51)=null,
@Documento varchar(14)=null, 
@RTN varchar(15) = null
as
	begin try
		if not exists(select ProductorID from Productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este productor', 1;		
		BEGIN TRANSACTION

		if  @Nombre is not null 
		begin
			exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
			update Productor set Nombre=@Nombre where ProductorID=@ProductorID
		end
		if  @Apellido is not null 
		begin
			exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
			update Productor set Apellido=@Apellido where ProductorID=@ProductorID
		end
		if  @Telefono is not null 
		begin
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
			update Productor set Telefono=@Telefono where ProductorID=@ProductorID
		end
		if  @Correo is not null 
		begin
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
			exec spValidarCorreo @Correo;
			update Productor set Correo=@Correo where ProductorID=@ProductorID
		end
		if  @Documento is not null 
		begin
			exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
			if (select COUNT(Documento) from productor where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
			update Productor set Documento=@Documento where ProductorID=@ProductorID
		end
		if @RTN is not null 
		begin
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
			update Productor set RTN=@RTN where ProductorID=@ProductorID
		end
			SELECT '10000' as Estado, 'Se actualizo correctamente el productor' AS Mensaje;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go