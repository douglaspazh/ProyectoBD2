use GrupoNo1


select * from proveedor
select * from productor
select * from producto
select * from bodega

select * from vStockActual
select * from compradetalle
select * from compra
declare @InsumosAgregar dbo.InsumoCompra;

--Primer prueba de compra de insumos para generar stock
INSERT INTO @InsumosAgregar (ProductoID, BodegaID, Cantidad, Precio) VALUES
('000000000001', '5A', 50, 1200),   -- Frijoles en Bodega 5A
('000000000002', '5B', 75, 950),    -- Maíz en Bodega 5B
('000000000003', '25', 120, 800),   -- Papas en Bodega 25
('000000000004', '5A', 65, 1500),   -- Naranjas en Bodega 5A
('000000000005', '5B', 40, 1100),   -- Yuca en Bodega 5B
('000000000006', '25', 85, 1300),   -- Cebollas en Bodega 25
('000000000007', '5A', 55, 1800),   -- Pepinos en Bodega 5A
('000000000008', '5B', 90, 1000),   -- Trigo en Bodega 5B
('000000000001', '25', 60, 1250),   -- Frijoles en Bodega 25
('000000000002', '5A', 70, 980),    -- Maíz en Bodega 5A
('000000000003', '5B', 110, 850),   -- Papas en Bodega 5B
('000000000004', '25', 45, 1550),   -- Naranjas en Bodega 25
('000000000005', '5A', 35, 1150),   -- Yuca en Bodega 5A
('000000000006', '5B', 95, 1350),   -- Cebollas en Bodega 5B
('000000000007', '25', 50, 1850),   -- Pepinos en Bodega 25
('000000000008', '5A', 80, 1050),   -- Trigo en Bodega 5A
('000000000001', '5B', 65, 1300),   -- Frijoles en Bodega 5B
('000000000002', '25', 85, 990),    -- Maíz en Bodega 25
('000000000003', '5A', 100, 870),   -- Papas en Bodega 5A
('000000000004', '5B', 55, 1600);   -- Naranjas en Bodega 5B
--Primer prueba
exec spComprarInsumos 1,@InsumosAgregar,0.15,0.15

declare @InsumosAgregar dbo.InsumoCompra;

INSERT INTO @InsumosAgregar (ProductoID, BodegaID, Cantidad, Precio) VALUES
('000000000001', '5A', 45, 1250),   -- Frijoles en Bodega 5A
('000000000002', '25', 60, 920),    -- Maíz en Bodega 25
('000000000003', '5B', 85, 780),    -- Papas en Bodega 5B
('000000000004', '5A', 55, 1450),   -- Naranjas en Bodega 5A
('000000000005', '25', 30, 1080),   -- Yuca en Bodega 25
('000000000006', '5B', 75, 1280),   -- Cebollas en Bodega 5B
('000000000007', '25', 40, 1750),   -- Pepinos en Bodega 25
('000000000008', '5A', 70, 980),    -- Trigo en Bodega 5A
('000000000001', '5B', 50, 1200),   -- Frijoles en Bodega 5B
('000000000002', '5A', 65, 950);    -- Maíz en Bodega 5A
--segunda prueba prueba
exec spComprarInsumos 2,@InsumosAgregar,0.15,0.15

--Prueba de creacion del voucher de la segunda compra
declare @compraid dbo.IngresoProveedorR ;
insert into @compraid (CompraID) values(2)

exec spCrearVoucherProveedor '123456789',2,'2025-06-09',@compraid
select * from ingresosproveedor
select * from vCuentasProveedor

exec spPagarVoucherProveedorDeposito 3, 7

--Verificacion del cambio en las tablas correspondientes luego del pago
EXEC spCalculoUtilidad;
select * from voucher

select * from compra
select * from depositos
select * from compraabonos


select * from finca
select * from lote
select * from cosecha
exec spCosechaFinalizada 1, '2025-08-06' 
exec spRecogerCosecha 1,'5A',46
select * from vStockActual



