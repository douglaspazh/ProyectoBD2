-- Procedimiento para obtener un productor por nombre o correo
-- Se utiliza un parámetro de entrada para filtrar los resultados.
CREATE OR ALTER PROCEDURE spGetProductorByValue
    @Value VARCHAR(50)
AS
    SELECT p.ProductorID, p.Nombre, p.Telefono, p.Correo, p.EstadoID, e.Nombre AS Estado, p.FechaRegistro
    FROM Productor p
    INNER JOIN Estado e ON p.EstadoID = e.EstadoID
    WHERE p.Nombre LIKE '%' + @Value + '%' OR p.Correo LIKE '%' + @Value + '%'
GO
