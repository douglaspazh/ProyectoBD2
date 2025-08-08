CREATE OR ALTER PROCEDURE spUpdateLote
    @ID INT,
    @FincaID INT,
    @Extencion DECIMAL(18, 2),
    @TipoSuelo VARCHAR(50),
    @TipoRiego VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        IF (SELECT COUNT(LoteID) FROM Lote WHERE LoteID = @ID) != 1
            THROW 50051, 'No existe este lote', 1;

        EXEC spValidarDecimal 'Extencion', @Extencion;
        EXEC spValidarCampoVarchar 'Tipo Suelo', @TipoSuelo, 0, 50;
        EXEC spValidarCampoVarchar 'Tipo Riego', @TipoRiego, 0, 50;

        BEGIN TRANSACTION;
        UPDATE Lote
        SET FincaID = @FincaID,
            Extencion = @Extencion,
            TipoSuelo = @TipoSuelo,
            TipoDeRiego = @TipoRiego
        WHERE LoteID = @ID;
        SELECT 10000 AS Estado, 'Se actualizo correctamente el lote' AS Mensaje;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
END;