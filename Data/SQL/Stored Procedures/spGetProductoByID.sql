CREATE OR ALTER PROCEDURE spGetProductoByID
    @ID VARCHAR(12)
AS
    SELECT *
    FROM Producto
    WHERE ProductoID = @ID;
GO