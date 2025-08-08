CREATE OR ALTER PROCEDURE spGetFincasByValue
    @Value NVARCHAR(50),
    @PageNumber INT,
    @PageSize INT
AS
    SELECT f.FincaID, f.Nombre, p.Nombre + ' ' + p.Apellido AS Productor, a.Nombre AS Departamento, m.Nombre AS Municipio, f.ExtencionTotal
    FROM Finca f
    JOIN Productor p ON f.ProductorID = p.ProductorID
    JOIN Municipio m ON f.MunicipioID = m.MunicipioID
    JOIN Departamento a ON m.DepartamentoID = a.DepartamentoID
    WHERE f.Nombre LIKE '%' + @Value + '%'
        OR p.Nombre LIKE '%' + @Value + '%'
        OR p.Apellido LIKE '%' + @Value + '%'
    ORDER BY f.Nombre
    -- Implementación de paginación
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO