-- Procedimiento para obtener todos los estados
create or alter PROCEDURE spGetProveedorEstados
AS
BEGIN
    SELECT * FROM Estado
    WHERE CAST(EstadoId AS VARCHAR) LIKE '1%'
END;
