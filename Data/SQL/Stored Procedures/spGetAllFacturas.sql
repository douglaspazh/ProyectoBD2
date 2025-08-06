create or alter procedure spGetAllFacturas
@PageNumber int,
@PageSize int 
as
	select c.Nombre, c.Apellido, c.Documento,c.RTN, c.Correo, f.FacturaID, f.Fecha, CONCAT(f.Impuesto, '%') as Impuesto, CONCAT(ISNULL(f.Descuento, 0), '%') as Descuento
	from Factura as f
	inner join Cliente as c on c.ClienteID = f.FacturaID
	order by f.Fecha DESC
	OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
go