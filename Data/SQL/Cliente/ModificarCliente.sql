use GrupoNo1

create or alter procedure spModificarCliente
@ClienteID int,
@Nombre varchar(26)=  null,
@Apellido varchar(26)=  null,
@Documento varchar(14)=  null,
@Direccion varchar(151) =  null,
@RTN varchar(15) = null,
@Telefono varchar(9)=null,
@Correo varchar(51) = null
as
	begin try
		if not exists(select ClienteID from cliente where ClienteID=@ClienteID)
			THROW 50051, 'No existe este cliente', 1;		
		BEGIN TRANSACTION
		if @Direccion is not null
		begin
			exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
			update Cliente set Nombre=@Nombre where ClienteID=@ClienteID
		end
		
		if  @Nombre is not null 
		begin
			exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
			update Cliente set Nombre=@Nombre where ClienteID=@ClienteID
		end
		if  @Apellido is not null 
		begin
			exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
			update Cliente set Apellido=@Apellido where ClienteID=@ClienteID
		end
		if  @Telefono is not null 
		begin
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
			update Cliente set Telefono=@Telefono where ClienteID=@ClienteID
		end
		if  @Correo is not null 
		begin
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
			exec spValidarCorreo @Correo;
			update Cliente set Correo=@Correo where ClienteID=@ClienteID
		end
		if  @Documento is not null 
		begin
			exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
			if (select COUNT(Documento) from Cliente where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
			update Cliente set Documento=@Documento where ClienteID=@ClienteID
		end
		if @RTN is not null 
		begin
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
			update Cliente set RTN=@RTN where ClienteID=@ClienteID
		end		
		
		
			SELECT '10000' as Estado, 'Se actualizo correctamente el cliente' AS Mensaje;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
