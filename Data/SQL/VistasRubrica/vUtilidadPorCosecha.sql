USE GrupoNo1
go
create or alter view vUtilidadPorCosecha as
select
    c.CosechaID,
    cu.Nombre as TipoCultivo,
    c.LoteID,
    c.CultivoID,
    isnull(ec.KilosCosechados, 0) as KilosCosechados,
    isnull(lc.CostoTotalProductor, 0) as CostoTotalProductor,
    isnull(sid.CostoInsumos, 0) as CostoInsumos,
    isnull(fd.IngresosVentas, 0) as IngresosVentas,
    isnull(fd.IngresosVentas, 0) - (isnull(lc.CostoTotalProductor, 0) + isnull(sid.CostoInsumos, 0)) as UtilidadNeta
from Cosecha c
    --Subqueries para hacer agregaciones previas a cada join
left join (
    SELECT CosechaID, SUM(Cantidad) AS KilosCosechados
    FROM EntradaCosecha
    GROUP BY CosechaID
) ec ON ec.CosechaID = c.CosechaID

left join (
    SELECT CosechaID, SUM(TotalPagar) AS CostoTotalProductor
    FROM LiquidacionCosecha
    GROUP BY CosechaID
) lc ON lc.CosechaID = c.CosechaID

left join (
    SELECT ec.CosechaID, SUM(sid.Cantidad * sid.Precio) AS CostoInsumos
    FROM EntradaCosecha ec
    JOIN SolicitudInsumosDetalle sid ON sid.ProductoID = ec.ProductoID
    GROUP BY ec.CosechaID
) sid ON sid.CosechaID = c.CosechaID

left join (
    SELECT ec.CosechaID, SUM(fd.Cantidad * fd.Precio) AS IngresosVentas
    FROM EntradaCosecha ec
    JOIN FacturaDetalle fd ON fd.ProductoID = ec.ProductoID
    GROUP BY ec.CosechaID
) fd ON fd.CosechaID = c.CosechaID

left join Cultivo cu on c.CultivoID = cu.CultivoID
go

select * from vUtilidadPorCosecha