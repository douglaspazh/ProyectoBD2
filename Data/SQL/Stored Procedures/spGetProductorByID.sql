
CREATE OR ALTER PROCEDURE spGetProductorByID
	@ID INT
AS
    SELECT p.ProductorID, p.Nombre, p.Apellido, p.Telefono, p.Documento, p.RTN, p.Correo, p.EstadoID
	FROM Productor p
	WHERE p.ProductorID = @ID
GO
