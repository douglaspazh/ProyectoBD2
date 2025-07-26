GO
-- Procedimiento para eliminar un productor
CREATE OR ALTER PROCEDURE spDeleteProductor
    @ID   INT
AS
    DELETE FROM Productor
    WHERE ProductorID = @ID;
GO
