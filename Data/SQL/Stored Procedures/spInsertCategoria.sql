CREATE OR ALTER PROCEDURE spInsertCategoria
    @Nombre VARCHAR(50),
    @Observaciones VARCHAR(255)
AS
BEGIN
    BEGIN TRY
        EXEC spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;

        BEGIN TRANSACTION
        IF EXISTS (SELECT 1 FROM Categoria WHERE Nombre = @Nombre)
            THROW 50051, 'Ya existe una categoria con este nombre', 1;

        DECLARE @ID INT;
        SET @ID = (SELECT ISNULL(MAX(CategoriaID), 0) + 1 FROM Categoria);

        INSERT INTO Categoria (CategoriaID, Nombre, Observaciones)
        VALUES (@ID, @Nombre, @Observaciones);

        SELECT 10000 AS Estado, 'Se creo correctamente la categoria' AS Mensaje;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
END;