CREATE OR ALTER PROCEDURE spGetAllFincas
    @PageNumber INT,
    @PageSize INT
AS
    BEGIN
        SELECT f.FincaID, f.Nombre, p.Nombre + ' ' + p.Apellido AS ProductorNombre, a.Nombre as Departamento, m.Nombre AS Municipio, f.ExtensionTotal
        FROM Finca f
        JOIN Productor p ON f.ProductorID = p.ProductorID
        JOIN Departamento a ON m.DepartamentoID = a.DepartamentoID
        JOIN Municipio m ON f.MunicipioID = m.MunicipioID
        ORDER BY f.Nombre
        -- Implementación de paginación
        OFFSET (@PageNumber - 1) * @PageSize ROWS
        FETCH NEXT @PageSize ROWS ONLY;
    END
GO