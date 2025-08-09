
CREATE OR ALTER PROCEDURE spObtenerClientes
	@PageNumber INT,
	@PageSize INT
AS
    select * from cliente
	order by Nombre
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
exec spObtenerClientes 1,6

CREATE OR ALTER PROCEDURE spObtenerClientesConID
	@ID INT
AS
    select * from cliente where ClienteID=@ID
GO

CREATE OR ALTER PROCEDURE spObtenerVentas
	@PageNumber INT,
	@PageSize INT
AS
    
	
	select dbo.ObtenerNombreProducto(fd.ProductoID) as Producto,fd.BodegaID as Bodega,fd.Precio,fd.Cantidad,'Pagado' as EstadoPago,'Factura' as SalioPor,f.Fecha from facturadetalle fd
	inner join (select facturaId,Fecha from factura f) f on f.facturaId=fd.facturaId
	union
	select  dbo.ObtenerNombreProducto(sidd.ProductoID) as Producto,sidd.BodegaID as Bodega,sidd.Precio,sidd.Cantidad,dbo.ObtenerNombreEstado(si.EstadoID) as EstadoPago,
	'Insumos a Productor' as SalioPor,si.FechaSolicitud as Fecha from Solicitudinsumosdetalle sidd
	inner join (select SolicitudInsumosID,FechaSolicitud,EstadoID from Solicitudinsumos) si on si.SolicitudInsumosID=sidd.SolicitudInsumosID
	order by Fecha
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO

CREATE or alter FUNCTION dbo.ObtenerNombreEstado
(
    @EstadoID INT
)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @NombreEstado VARCHAR(100);
    
    SELECT @NombreEstado = Nombre
    FROM Estado
    WHERE EstadoID = @EstadoID;
    
    RETURN ISNULL(@NombreEstado, 'Estado no encontrado');
END

CREATE or alter FUNCTION dbo.ObtenerNombreProducto
(
    @ProductoID INT
)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @Nombre VARCHAR(100);
    
    SELECT @Nombre = Nombre
    FROM producto
    WHERE ProductoID = @ProductoID;
    
    RETURN ISNULL(@Nombre, 'producto no encontrado');
END


CREATE OR ALTER PROCEDURE spObtenerVentas
	@PageNumber INT,
	@PageSize INT
AS
	select  dbo.ObtenerNombreProducto(sidd.ProductoID) as Producto,sidd.BodegaID as Bodega,sidd.Precio,sidd.Cantidad,dbo.ObtenerNombreEstado(si.EstadoID) as EstadoPago,
	'Insumos a Productor' as SalioPor,si.FechaSolicitud as Fecha from Solicitudinsumosdetalle sidd
	inner join (select SolicitudInsumosID,FechaSolicitud,EstadoID from Solicitudinsumos) si on si.SolicitudInsumosID=sidd.SolicitudInsumosID
	order by Fecha
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO

CREATE OR ALTER PROCEDURE spObtenerBodega
AS
	select BodegaID  from bodega
GO

CREATE OR ALTER PROCEDURE spObtenerProducto
AS
	select Nombre,ProductoID  from producto
GO
CREATE OR ALTER PROCEDURE spObtenerProveedor
AS
	select ProveedorID,CONCAT(Nombre,' ',Apellido) as NombreProveedor from proveedor where EstadoID=10001
GO
CREATE OR ALTER PROCEDURE spObtenerCompras
	@PageNumber INT,
	@PageSize INT
AS
	select * from vCompras
	order by Fecha
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
select * from vStockActual
select * from vGetProductorEstados
select * from producto

CREATE OR ALTER PROCEDURE spObtenerProductoDisponible
AS
	select p.ProductoID,p.Nombre from producto p
	inner join vStockActual vsa on vsa.ProductoID=p.ProductoID
	group by  p.ProductoID,p.Nombre
GO
select * from vStockActual
CREATE OR ALTER PROCEDURE spObtenerBodegaCantidadStock
@ProductoID int
AS
	select ProductoID,BodegaID,Cantidad from vStockActual where ProductoID=@ProductoID
GO

CREATE OR ALTER PROCEDURE spObtenerBodegaCantidadStockBodega
@ProductoID int,
@BodegaID varchar(2)
AS
	select ProductoID,BodegaID,Cantidad from vStockActual where ProductoID=@ProductoID and BodegaID=@BodegaID
GO

CREATE OR ALTER PROCEDURE spObtenerStock
	@PageNumber INT,
	@PageSize INT
AS
	select dbo.ObtenerNombreProducto(ProductoID) NombreProducto,BodegaID as Bodega, Cantidad from vStockActual
	order by NombreProducto
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO
select * from SolicitudInsumos
CREATE OR ALTER PROCEDURE spObtenerComprasPendientes
	@PageNumber INT,
	@PageSize INT
AS
	select *,dbo.ObtenerTotalComprasPendientes(CompraID)as TotalPagar from vCompras where dbo.ObtenerTotalComprasPendientes(CompraID)>0
	order by Fecha
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO

CREATE OR ALTER PROCEDURE spObtenerComprasPagadas
	@PageNumber INT,
	@PageSize INT
AS
	select * from vCompras where dbo.ObtenerTotalComprasPendientes(CompraID)=0
	order by Fecha
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
GO


CREATE or alter FUNCTION dbo.ObtenerNombreProductor
(
    @ProductorID INT
)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @Nombre VARCHAR(100);
    
    SELECT @Nombre = Nombre
    FROM productor
    WHERE ProductorID = @ProductorID;
    
    RETURN ISNULL(@Nombre, 'productor no encontrado');
END

CREATE or alter FUNCTION dbo.ObtenerNombreProveedor
(
    @ProveedorID INT
)
RETURNS VARCHAR(100)
AS
BEGIN
    DECLARE @Nombre VARCHAR(100);
    
    SELECT @Nombre = Nombre
    FROM proveedor
    WHERE ProveedorID  = @ProveedorID ;
    
    RETURN ISNULL(@Nombre, 'proveedor no encontrado');
END

CREATE or alter FUNCTION dbo.ConvertirPorcentual
(
    @campo decimal(10,2)
)
RETURNS VARCHAR(100)
AS
BEGIN
    RETURN ISNULL(CONCAT(@campo*100,'%'), 'Errorsito');
END


CREATE or alter FUNCTION dbo.ObtenerTotalComprasPendientes
(
    @CompraID int
)
RETURNS decimal(10,2)
AS
BEGIN
	DECLARE @Total decimal(10,2);
	select @Total=(Subtotal-Descuento+ImpuestoTotal+(DiasMora*InteresMora*(Subtotal-Descuento+ImpuestoTotal))) 
	from vComprasPendientes 
	where CompraID=@CompraID
    RETURN ISNULL(@Total, 0);
END

