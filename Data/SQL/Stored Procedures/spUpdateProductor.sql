CREATE OR ALTER PROCEDURE spUpdateProductor
	@ID INT,
	@Nombre VARCHAR(26), 
	@Apellido VARCHAR(26), 
	@Direccion VARCHAR(51), 
	@Telefono VARCHAR(9), 
	@Correo VARCHAR(151),
	@Documento VARCHAR(14),
	@Estado INT,
	@RTN VARCHAR(21) = NULL
AS
    BEGIN TRY
	    -- Validaciones de campos
		EXEC spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		EXEC spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		EXEC spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		EXEC spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		EXEC spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		EXEC spValidarCorreo @Correo;
		EXEC spValidarCampoVarchar 'Documento', @Documento, 0, 13;

		IF @RTN != NULL
			EXEC spValidarCampoVarchar 'RTN', @RTN, 0, 20;

		IF (SELECT COUNT(Documento) FROM Productor WHERE Documento = @Documento AND ProductorID <> @ID) > 0
			THROW 50050, 'Ya existe este registro.', 1;			

		-- Actualización del productor
		BEGIN TRANSACTION
            UPDATE Productor 
                SET Nombre = @Nombre,
                    Apellido = @Apellido,
                    Direccion = @Direccion,
                    Telefono = @Telefono,
                    Correo = @Correo,
                    Documento = @Documento,
                    RTN = @RTN,
                    EstadoID = @Estado
                WHERE ProductorID = @ID;

            SELECT 10000 as Estado, 'Productor actualizado correctamente' AS Mensaje;
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
	END CATCH
GO
