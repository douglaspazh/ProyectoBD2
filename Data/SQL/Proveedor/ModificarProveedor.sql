create or alter procedure spModificarProveedor
@ProveedorID int,
@Nombre varchar(26), 
@Apellido varchar(26), 
@Documento varchar(14),
@Direccion varchar(151), 
@Telefono varchar(9), 
@Correo varchar(51),
@RTN varchar(15) = null
as
	begin try
		if not exists(select ProveedorID from Proveedor where ProveedorID=@ProveedorID)
			THROW 50051, 'No existe este Proveedor', 1;		
		BEGIN TRANSACTION

		if  @Direccion is not null 
		begin
			exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
			update Proveedor set Direccion=@Direccion where ProveedorID=@ProveedorID
		end
		if  @Nombre is not null 
		begin
			exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
			update Proveedor set Nombre=@Nombre where ProveedorID=@ProveedorID
		end
		if  @Apellido is not null 
		begin
			exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
			update Proveedor set Apellido=@Apellido where ProveedorID=@ProveedorID
		end
		if  @Telefono is not null 
		begin
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
			update Proveedor set Telefono=@Telefono where ProveedorID=@ProveedorID
		end
		if  @Correo is not null 
		begin
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
			exec spValidarCorreo @Correo;
			update Proveedor set Correo=@Correo where ProveedorID=@ProveedorID
		end
		if  @Documento is not null 
		begin
			exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
			if (select COUNT(Documento) from Proveedor where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
			update Proveedor set Documento=@Documento where ProveedorID=@ProveedorID
		end
		if @RTN is not null 
		begin
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
			update Proveedor set RTN=@RTN where ProveedorID=@ProveedorID
		end
			SELECT '10000' as Estado, 'Se actualizo correctamente el Proveedor' AS Mensaje;
		COMMIT TRANSACTION
		
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go