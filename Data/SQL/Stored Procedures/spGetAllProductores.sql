-- Este procedimiento obtiene todos los productores junto con su estado actual.
-- Se unen las tablas Productor y Estado para obtener el nombre del estado.
CREATE OR ALTER PROCEDURE spGetAllProductores
	@PageNumber INT,
	@PageSize INT
AS
    SELECT p.ProductorID, p.Nombre, p.Apellido, p.Documento, p.RTN, p.Telefono, p.Correo, p.EstadoID, e.Nombre AS Estado
	FROM Productor p
	JOIN Estado e ON p.EstadoID = e.EstadoID
	ORDER BY p.Nombre
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
