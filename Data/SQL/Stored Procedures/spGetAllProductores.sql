-- Este procedimiento obtiene todos los productores junto con su estado actual.
-- Se unen las tablas Productor y Estado para obtener el nombre del estado.
CREATE OR ALTER PROCEDURE spGetAllProductores
AS
    SELECT p.ProductorID, p.Nombre, p.Telefono, p.Correo, p.EstadoID, e.Nombre AS Estado, p.FechaRegistro
    FROM Productor p
    JOIN Estado e ON p.EstadoID = e.EstadoID
    ORDER BY p.Nombre;
GO