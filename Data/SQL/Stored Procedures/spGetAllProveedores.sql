


CREATE OR ALTER PROCEDURE spGetAllProveedores
	@PageNumber INT,
	@PageSize INT
AS
    SELECT p.ProveedorID, p.Nombre, p.Apellido, p.Documento, p.RTN, p.Telefono, p.Correo,p.Direccion p.EstadoID, p.PeriodoDePagoDias, p.TasaInteres, e.Nombre AS Estado
	FROM Proveedor p
	JOIN Estado e ON p.EstadoID = e.EstadoID
	ORDER BY p.Nombre
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
