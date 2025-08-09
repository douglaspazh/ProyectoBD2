CREATE OR ALTER PROCEDURE spGetProveedorByID

	@ID INT
AS
    SELECT p.ProveedorID, p.Nombre, p.Apellido, p.Telefono, p.Documento, 
	p.RTN, p.Correo, p.EstadoID, p.Direccion, p.PeriodoDePagoDias, p.TasaInteres
	FROM Proveedor p
	WHERE p.ProveedorID = @ID
GO

    @ID INT
AS
BEGIN
    SELECT * FROM Proveedor WHERE ProveedorID = @ID
END

