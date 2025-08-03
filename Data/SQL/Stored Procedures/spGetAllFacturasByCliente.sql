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

create or alter procedure spGetFacturaDetalleByFactura
@FacturaID int
as
	select * into #Factura from Factura where FacturaID = @FacturaID
	select * into #FacturaDetalle from FacturaDetalle where FacturaDetalleID = @FacturaID
	
	select  p.Nombre, p.ProductoID, fd.Cantidad, p.UnidadMedida, c.Nombre as Categoria, fd.BodegaID as Bodega
	from #Factura as f 
	inner join #FacturaDetalle as fd on f.FacturaID = fd.FacturaID
	inner join Producto as p on fd.ProductoID = p.ProductoID
	inner join Categoria as c on p.CategoriaID = c.CategoriaID
go