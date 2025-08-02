-- Procedimiento para obtener todos los estados
create or alter PROCEDURE spGetProductorEstados
AS
BEGIN
    SELECT * FROM Estado
    WHERE CAST(EstadoId AS VARCHAR) LIKE '1%'
END;
