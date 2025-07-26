-- Procedimiento para actualizar un productor existente
CREATE OR ALTER PROCEDURE spUpdateProductor
    @ID         INT,
    @Nombre     VARCHAR(50),
    @Telefono   VARCHAR(15),
    @Correo     VARCHAR(50),
    @EstadoID   INT
AS
    -- Verifica si el productor existe
    IF NOT EXISTS(SELECT * FROM Productor WHERE ProductorID = @ID)
        RETURN;

    UPDATE Productor
    SET Nombre = @Nombre,
        Telefono = @Telefono,
        Correo = @Correo,
        EstadoID = @EstadoID
    WHERE ProductorID = @ID;
GO
