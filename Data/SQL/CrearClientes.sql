use GrupoNo1

create or alter procedure spCrearCliente
@Nombre varchar(26),
@Apellido varchar(26),
@Documento varchar(14),
@Direccion varchar(151) =  null,
@RTN varchar(15) = null,
@Telefono varchar(9)=null,
@Correo varchar(51) = null
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		if @Direccion is not null
			exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		if @Telefono is not null
			exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		if @Correo is not null
			exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		exec spValidarCorreo @Correo;
		exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		if @RTN is not null
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
		if (select COUNT(Documento) from Cliente where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(ClienteID), 0) + 1 from Cliente
			insert into cliente (ClienteID,Nombre,Apellido,Direccion,Telefono,Correo,Documento, RTN) values 
			(@ID,@Nombre, @Apellido, @Direccion, @Telefono, @Correo,@Documento,@RTN)
			SELECT '10000' as Estado, 'Se creo correctamente el cliente' AS Mensaje;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
