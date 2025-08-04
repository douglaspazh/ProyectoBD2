create or alter procedure spGetAllFacturasByCliente
@ClienteID int
as
	select * into #Factura from Factura where ClienteID = @ClienteID
	select * into #Cliente from Cliente where ClienteID = @ClienteID

	select c.Nombre, c.Apellido, c.Documento,c.RTN, c.Correo, f.FacturaID, f.Fecha, CONCAT(f.Impuesto, '%') as Impuesto, CONCAT(ISNULL(f.Descuento, 0), '%') as Descuento
	from #Factura as f
	inner join #Cliente as c on c.ClienteID = f.FacturaID
	order by f.Fecha DESC
go