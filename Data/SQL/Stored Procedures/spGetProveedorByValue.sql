CREATE OR ALTER PROCEDURE spGetProveedorByValue
    @Value VARCHAR(50)
AS
    SELECT p.ProveedorID, p.Nombre, p.Apellido, p.Documento, p.RTN, p.Telefono, p.Correo, p.EstadoID, p.Direccion, p.PeriodoDePagoDias, p.TasaInteres, e.Nombre AS Estado
	FROM Proveedor p
	JOIN Estado e ON p.EstadoID = e.EstadoID
    WHERE p.Nombre LIKE '%' + @Value + '%' 
       OR p.Apellido LIKE '%' + @Value + '%'
       OR p.Documento LIKE '%' + @Value + '%'
GO
