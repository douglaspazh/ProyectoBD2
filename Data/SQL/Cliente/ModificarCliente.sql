use GrupoNo1

create or alter procedure spModificarCliente
@ID int,
@Nombre varchar(26)= '',
@Apellido varchar(26)= '',
@Documento varchar(14)= '',
@Direccion varchar(151) = '',
@RTN varchar(15) = '',
@Telefono varchar(9)= '',
@Correo varchar(51) = ''	
as
	begin try
		if not exists(select ClienteID from cliente where ClienteID=@ID)
			THROW 50051, 'No existe este cliente', 1;		
		BEGIN TRANSACTION
		if @Direccion != ''
		begin
			exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
			update Cliente set Nombre=@Nombre where ClienteID=@ID
		end
		
		if  @Nombre != ''
		begin
			exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
			update Cliente set Nombre=@Nombre where ClienteID=@ID
		end
		if  @Apellido != '' 
		begin
			exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
			update Cliente set Apellido=@Apellido where ClienteID=@ID
		end
		if  @Telefono != '' 
		begin
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
			update Cliente set Telefono=@Telefono where ClienteID=@ID
		end
		if  @Correo != '' 
		begin
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
			exec spValidarCorreo @Correo;
			update Cliente set Correo=@Correo where ClienteID=@ID
		end
		if  @Documento != '' 
		begin
			exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
			if (select COUNT(Documento) from Cliente where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
			update Cliente set Documento=@Documento where ClienteID=@ID
		end
		if @RTN != ''
		begin
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
			update Cliente set RTN=@RTN where ClienteID=@ID
		end		

			SELECT 10000 as Estado, 'Se actualizo correctamente el cliente' AS Mensaje;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
