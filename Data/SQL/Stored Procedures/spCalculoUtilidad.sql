
create or alter procedure spCalculoUtilidad
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IngresosTotal DECIMAL(18,2);
    DECLARE @GastosTotal DECIMAL(18,2);
    DECLARE @Utilidad DECIMAL(18,2);

   SELECT @IngresosTotal = ISNULL(SUM(fd.Precio * fd.Cantidad), 0)+ ISNULL(SUM(sd.Precio * sd.Cantidad), 0)
		FROM FacturaDetalle fd FULL OUTER JOIN SolicitudInsumosDetalle sd ON 1 = 0;
		   
   SELECT @GastosTotal =ISNULL(SUM(cd.PrecioUnitario * cd.Cantidad), 0)+ ISNULL(SUM(ec.PrecioUnitario * ec.Cantidad), 0)
		FROM CompraDetalle cd FULL OUTER JOIN EntradaCosecha ec ON 1 = 0;

   SET @Utilidad = @IngresosTotal - @GastosTotal;

   SELECT 
        @IngresosTotal AS IngresosTotales,
        @GastosTotal AS GastosTotales,
        @Utilidad AS Utilidad;
END;

EXEC spCalculoUtilidad;
