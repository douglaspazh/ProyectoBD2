-- Procedimiento para obtener un productor por nombre o correo
-- Se utiliza un parámetro de entrada para filtrar los resultados.
CREATE OR ALTER PROCEDURE spGetProductorByValue
    @Value VARCHAR(50)
AS
    SELECT p.ProductorID, p.Nombre, p.Apellido, p.Documento, p.RTN, p.Telefono, p.Correo, p.EstadoID, e.Nombre AS Estado
	FROM Productor p
	JOIN Estado e ON p.EstadoID = e.EstadoID
    WHERE p.Nombre LIKE '%' + @Value + '%' 
       OR p.Apellido LIKE '%' + @Value + '%'
       OR p.Documento LIKE '%' + @Value + '%'
GO
