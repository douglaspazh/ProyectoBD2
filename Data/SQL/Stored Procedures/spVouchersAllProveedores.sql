create procedure spVouchersAllProveedor
    @ProveedorID int = null, --Al llamar directamente este procedimiento no se envia parametro para que consulte a toda la tabla
    @PageNumber int,
    @PageSize int
as
begin
    create table #Vouchers (
        VoucherID int,
        NumeroVoucher varchar(13),
        Fecha date,
        EstadoID int,
        TipoPagoID int
    );

    insert into #Vouchers
    select v.VoucherID, v.NumeroVoucher, v.Fecha, v.EstadoID, v.TipoPagoID
    from Voucher v
    inner join VoucherProveedor vpr on v.VoucherID = vpr.VoucherID
    where @ProveedorID is null or vpr.ProveedorID = @ProveedorID;

    select
        tv.VoucherID,
        tv.NumeroVoucher,
        tv.Fecha as FechaCreacion,
        e.Nombre as Estado,
        pr.ProveedorID,
        pr.Nombre + ' ' + pr.Apellido as NombreProveedor,
        pr.Documento,
        pr.RTN,
        isnull(ipd.total_ingresos, 0) as TotalIngresos,
        0 as TotalDeducciones,
        isnull(ipd.total_ingresos, 0) as TotalPagar,
        case 
            when tv.TipoPagoID = 1 then 'depósito' 
            when tv.TipoPagoID = 2 then 'cheque'
        end as MetodoPago,
        d.Fecha as FechaPago,
        b.Nombre as Banco,
        d.CuentaID
    from #Vouchers tv
    inner join VoucherProveedor vpr on tv.VoucherID = vpr.VoucherID
    inner join Proveedor pr on vpr.ProveedorID = pr.ProveedorID
    left join Estado e on tv.EstadoID = e.EstadoID
    left join (
        select VoucherProveedorID, sum(Monto) as total_ingresos
        from IngresosProveedor
        where VoucherProveedorID in (
            select VoucherProveedorID
            from VoucherProveedor
            where VoucherID in (select VoucherID from #Vouchers)
        )
        group by VoucherProveedorID
    ) ipd on vpr.VoucherProveedorID = ipd.VoucherProveedorID
    left join Depositos d on tv.VoucherID = d.VoucherID
    left join Cheques c on tv.VoucherID = c.VoucherID
    left join Banco b on c.BancoID = b.BancoID
    order by tv.Fecha desc
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;

    drop table #Vouchers;
end;
go

--Al buscar Vouchers de un Productor en especifico, llamar este procedimiento, solo existe para mejor legibilidad

create or alter procedure spGetVouchersByProveedor
@ProveedorID int,
@PageNumber int,
@PageSize int 
AS
BEGIN
   EXEC spVouchersAllProveedor @ProveedorID,@PageNumber, @PageSize
END;