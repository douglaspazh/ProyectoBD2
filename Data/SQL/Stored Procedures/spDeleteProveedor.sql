

GO
-- Procedimiento para eliminar un proveedor
CREATE OR ALTER PROCEDURE spDeleteProveedor
    @ID   INT
AS
    BEGIN TRY
        -- Validación de existencia del proveedor
        IF NOT EXISTS (SELECT 1 FROM Proveedor WHERE ProveedorID = @ID)
            THROW 50051, 'El proveedor no existe.', 1;

        -- Eliminación del proveedor
        BEGIN TRANSACTION
            DELETE FROM Proveedor WHERE ProveedorID = @ID;
            SELECT 10000 AS Estado, 'Proveedor eliminado correctamente' AS Mensaje;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
GO