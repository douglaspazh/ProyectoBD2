create or alter procedure spCrearProveedor
@Nombre varchar(26), 
@Apellido varchar(26), 
@Documento varchar(14),
@Direccion varchar(151), 
@Telefono varchar(9), 
@Correo varchar(51),
@PeriodoDePagoDias int,--decimal(10,2)
@TasaInteres varchar(20),
@RTN varchar(15) = null
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		exec spValidarCorreo @Correo;
		exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		exec spValidarCampoInt @PeriodoDePagoDias,'Periodo de pago';
		exec spValidarDecimal 'Tasa de interes',@TasaInteres;
		
		if @RTN != null
			exec spValidarCampoVarchar 'RTN', @RTN, 0, 14;
		if (select COUNT(Documento) from proveedor where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(ProveedorID), 0) + 1 from proveedor
			insert into Proveedor (ProveedorID,Nombre,Apellido,Direccion,Telefono,Correo,EstadoID,Documento, RTN,PeriodoDePagoDias,TasaInteres)
			values (@ID,@Nombre, @Apellido, @Direccion, @Telefono, @Correo,1001,@Documento,@RTN,@PeriodoDePagoDias,@TasaInteres)
			SELECT '10000' as Estado, 'Se agrego correctamente el proveedor' AS Mensaje;
		COMMIT TRANSACTION
		
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go