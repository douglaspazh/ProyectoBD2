CREATE OR ALTER PROCEDURE spInsertProductor
    @Nombre     VARCHAR(26), 
    @Apellido   VARCHAR(26), 
    @Telefono   VARCHAR(9), 
    @Correo     VARCHAR(151),
    @Documento  VARCHAR(14),
    @RTN        VARCHAR(21) = NULL
AS
    BEGIN TRY
        -- Validaciones de campos
		EXEC spValidarCampoVarchar 'Nombre', @Nombre, 0, 25;
		EXEC spValidarCampoVarchar 'Apellido', @Apellido, 0, 25;
		EXEC spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		EXEC spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		EXEC spValidarCorreo @Correo;
		EXEC spValidarCampoVarchar 'Documento', @Documento, 0, 13;

		IF @RTN != NULL
			EXEC spValidarCampoVarchar 'RTN', @RTN, 0, 20;
		
        IF (SELECT COUNT(Documento) FROM productor WHERE Documento = @Documento) > 0
			THROW 50050, 'Ya existe este registro.', 1;			

        -- Inserción del nuevo productor
        BEGIN TRANSACTION
			DECLARE @ID INT;
			SELECT @ID = ISNULL(MAX(ProductorID), 0) + 1 FROM Productor

			INSERT INTO Productor (ProductorID, Nombre, Apellido, Telefono, Correo, EstadoID, Documento, RTN) 
            VALUES (@ID, @Nombre, @Apellido, @Telefono, @Correo, 10001, @Documento, @RTN);

            SELECT 10000 as Estado, 'Productor agregado correctamente' AS Mensaje;
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
GO
