-- Procedimiento para insertar un nuevo productor
CREATE OR ALTER PROCEDURE spInsertProductor
    @Nombre         VARCHAR(100),
    @Telefono       VARCHAR(20),
    @Correo         VARCHAR(100),
    @EstadoID       INT
AS
    DECLARE @ID INT;

    IF NOT EXISTS(SELECT * FROM Productor WHERE Nombre = @Nombre)
        BEGIN
            SELECT @ID = ISNULL(MAX(ProductorID), 0) + 1 FROM Productor;
            INSERT INTO Productor (ProductorID, Nombre, Telefono, Correo, EstadoID)
            VALUES (@ID, @Nombre, @Telefono, @Correo, @EstadoID);
        END
GO
