GO
-- Procedimiento para eliminar un productor
CREATE OR ALTER PROCEDURE spDeleteProductor
    @ID   INT
AS
    BEGIN TRY
        -- Validación de existencia del productor
        IF NOT EXISTS (SELECT 1 FROM Productor WHERE ProductorID = @ID)
            THROW 50051, 'El productor no existe.', 1;

        -- Eliminación del productor
        BEGIN TRANSACTION
            DELETE FROM Productor WHERE ProductorID = @ID;
            SELECT 10000 AS Estado, 'Productor eliminado correctamente' AS Mensaje;
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
GO
