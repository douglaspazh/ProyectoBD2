 CREATE OR ALTER PROCEDURE spInsertProveedor
@Nombre varchar(26), 
@Apellido varchar(26), 
@Documento varchar(14),
@Direccion varchar(151), 
@Telefono varchar(9), 
@Correo varchar(51),
@PeriodoDePagoDias int,--decimal(10,2)
@TasaInteres varchar(20),
@RTN varchar(15) = NULl
AS
    BEGIN TRY
        -- Validaciones de campos
		EXEC spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		EXEC spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		EXEC spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		EXEC spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		EXEC spValidarCorreo @Correo;
		EXEC spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		EXEC spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		EXEC spValidarCampoVarchar 'Tasa de Interes', @TasaInteres, 0,19;


		IF @RTN != NULL
			EXEC spValidarCampoVarchar 'RTN', @RTN, 0, 20;
		
        IF (SELECT COUNT(Documento) FROM proveedor WHERE Documento = @Documento) > 0
			THROW 50050, 'Ya existe este registro.', 1;			

        -- Inserci�n del nuevo productor
        BEGIN TRANSACTION
			DECLARE @ID INT;
			SELECT @ID = ISNULL(MAX(ProveedorID), 0) + 1 FROM Proveedor

			INSERT INTO Proveedor (ProveedorID, Nombre, Apellido, Telefono, Correo, EstadoID, Documento, RTN,Direccion,PeriodoDePagoDias, TasaInteres) 
            VALUES (@ID, @Nombre, @Apellido, @Telefono, @Correo, 10001, @Documento, @RTN, @Direccion, @PeriodoDePagoDias, @TasaInteres);

            SELECT 10000 as Estado, 'Proveedor agregado correctamente' AS Mensaje;
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
GO
