CREATE OR ALTER PROCEDURE spUpdateProducto
    @ID VARCHAR(12),
    @Nombre VARCHAR(50),
    @CategoriaID INT,
    @ContenidoPorUnidad VARCHAR(16)
AS
BEGIN
    BEGIN TRY
        -- EXEC spValidarCampoEntero 'ID', @ID, 1, 2147483647;
        -- EXEC spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
        -- EXEC spValidarCampoEntero 'CategoriaID', @CategoriaID, 1, 2147483647;
        -- EXEC spValidarCampoVarchar 'ContenidoPorUnidad', @ContenidoPorUnidad, 0, 16;

        IF NOT EXISTS (SELECT 1 FROM Producto WHERE ProductoID = @ID)
            THROW 50052, 'No existe este producto', 1;

        BEGIN TRANSACTION

        UPDATE Producto
        SET Nombre = @Nombre,
            CategoriaID = @CategoriaID,
            ContenidoPorUnidad = @ContenidoPorUnidad
        WHERE ProductoID = @ID;

        SELECT 10000 AS Estado, 'Se actualizo correctamente el producto' AS Mensaje;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
END;