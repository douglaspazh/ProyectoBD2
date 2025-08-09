create or alter view vGetProveedores
as
    select 
    ProveedorID, 
    CONCAT(Nombre, ' ', Apellido) as NombreCompleto
    from Proveedor
go