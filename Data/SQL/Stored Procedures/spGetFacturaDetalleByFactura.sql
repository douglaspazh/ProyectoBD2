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