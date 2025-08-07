--Ver el inventario de todos los productos

create or alter view vStockActual AS
	select ProductoID, BodegaID, sum(Cantidad) as Cantidad from
	(
	select ProductoID,BodegaID,sum(cantidad)*-1 as Cantidad,'S'as Tipo from salidas group by BodegaID, ProductoID 
	union all 
	select ProductoID,BodegaID,sum(cantidad) as Cantidad,'E'as Tipo from entradas group by BodegaID, ProductoID
	) as mov group by BodegaID, ProductoID

create or alter view vSaldoPendienteCosecha as
	select LiquidacionID,sum(sp) as SaldoPendiente from (select LiquidacionID, Monto*-1 as sp from LiquidacionAbonos
	union
	select LiquidacionID, TotalPagar as sp from LiquidacionCosecha) as pendiente group by LiquidacionID


create or alter view vSaldoPendienteInsumos as
	select SolicitudInsumosID, sum(t) as SaldoPendiente from (
	select sd.SolicitudInsumosID, convert(decimal(10,2), sum(sd.Cantidad*sd.Precio*(s.Impuesto+1))) as t 
	from SolicitudInsumosDetalle sd inner join SolicitudInsumos s on s.SolicitudInsumosID=sd.SolicitudInsumosID 
	group by sd.SolicitudInsumosID
	union
	select SolicitudInsumosID,sum(Abono)*-1 as t  from ProductorPagos group by SolicitudInsumosID) as pendiente group by SolicitudInsumosID

create or alter view vSaldoPendienteCompra
as
	select CompraID,sum(s) as SaldoPendiente from (select CompraID,Monto*-1 as s from compraAbonos)
	union
	select CompraID,((Subtotal+ImpuestoTotal-Descuento)*case when DiasMora!=0 then InteresMora+1 else 1 end) s
	from vComprasPendientes) as m group by CompraID

create or alter view vComprasPendientes as
	select c.CompraID,
	--subtotal
	(select sum(cd.Cantidad*cd.Precio)as Subtotal from CompraDetalle as cd
	where cd.CompraID = c.CompraID)
	as Subtotal,
	--impuesto
	(select sum(cd.Cantidad*cd.Precio)*c.impuesto from CompraDetalle as cd
	where cd.CompraID = c.CompraID)
	--Descuento
	as ImpuestoTotal, 
	(select sum(cd.Cantidad*cd.Precio)*c.Descuento from CompraDetalle as cd
	where cd.CompraID = c.CompraID)
	as Descuento,
	CASE 
        WHEN DATEADD(DAY, p.PeriodoDePagoDias, c.Fecha) < GETDATE() THEN 'VENCIDO'
        ELSE 'VIGENTE'
    END AS EstadoPago,
	CASE 
        WHEN DATEADD(DAY, p.PeriodoDePagoDias, c.Fecha) < GETDATE() 
        THEN DATEDIFF(DAY, DATEADD(DAY, p.PeriodoDePagoDias, c.Fecha), GETDATE())
        ELSE 0
    END AS DiasMora,
	CASE 
        WHEN DATEADD(DAY, p.PeriodoDePagoDias, c.Fecha) < GETDATE() 
        THEN DATEDIFF(DAY, DATEADD(DAY, p.PeriodoDePagoDias, c.Fecha), GETDATE())*(p.TasaInteres)/360
        ELSE 0
    END AS InteresMora
	from Compra as c 
	inner join Proveedor as p on c.ProveedorID = p.ProveedorID
	where c.EstadoID=30001

create or alter view vTotalPagarVoucherProductor
as
	select di.VoucherProductorID,sum(di.Monto)as TotalPagar from (select VoucherProductorID, sum(Monto*-1) as Monto from DeduccionProductor group by VoucherProductorID
	union
	select VoucherProductorID, sum(Monto) as Monto from IngresosProductor group by VoucherProductorID) as di group by VoucherProductorID

create or alter view vCuentasProveedor
as
	select cb.CuentaID,cp.ProveedorID,cb.NumeroCuenta from CuentaBancaria as cb
	inner join CuentaProveedor as cp on cb.CuentaID=cp.CuentaID

create or alter view vCuentasProductor
as
	select cb.CuentaID,cp.ProductorID,cb.NumeroCuenta from CuentaBancaria as cb
	inner join CuentaProductor as cp on cb.CuentaID=cp.CuentaID
--Vistas creadas
select * from vSaldoPendienteCosecha
select * from vSaldoPendienteInsumos
select * from vStockActual
select * from vComprasPendientes
select * from vSaldoPendienteCompra
select * from vTotalPagarVoucherProductor
select * from vCuentasProveedor
select * from vCuentasProductor


