USE GrupoNo1
go

create or alter view vSaldoPorProductor as
select
    p.ProductorID,
    p.Nombre + ' ' + p.Apellido as NombreProductor,
    isnull(sum(lc.TotalPagar), 0) as TotalLiquidaciones,
    isnull(sum(la.MontoAbonado), 0) as TotalAbonado,
    isnull(sum(lc.TotalPagar), 0) - isnull(sum(la.MontoAbonado), 0) as SaldoCosechas,
    isnull(spi.SaldoPendienteInsumos, 0) as SaldoInsumos,
    (isnull(sum(lc.TotalPagar), 0) - isnull(sum(la.MontoAbonado), 0)) - isnull(spi.SaldoPendienteInsumos, 0) as SaldoNeto
from Productor p
left join LiquidacionCosecha lc on lc.ProductorID = p.ProductorID
left join (
    SELECT LiquidacionID, SUM(Monto) AS MontoAbonado
    FROM LiquidacionAbonos
    GROUP BY LiquidacionID
) la on la.LiquidacionID = lc.LiquidacionID
left join (
    SELECT si.ProductorID, SUM(vsp.SaldoPendiente) AS SaldoPendienteInsumos
    FROM SolicitudInsumos si
    JOIN vSaldoPendienteInsumos vsp ON vsp.SolicitudInsumosID = si.SolicitudInsumosID
    group by si.ProductorID
) spi on spi.ProductorID = p.ProductorID
group by p.ProductorID, p.Nombre, p.Apellido, spi.SaldoPendienteInsumos;
go

select * from vSaldoPorProductor