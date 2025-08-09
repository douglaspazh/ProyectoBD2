CREATE OR ALTER PROCEDURE spGetAllProductos
    @PageNumber INT,
    @PageSize INT
AS
    SELECT p.ProductoID, p.Nombre, c.Nombre as Categoria, p.ContenidoPorUnidad
    FROM Producto p
    JOIN Categoria c ON p.CategoriaID = c.CategoriaID
    ORDER BY p.ProductoID
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
