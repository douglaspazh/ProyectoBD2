use GrupoNo1
--Cuando se agrega un producto a la tabla de CompraDetalle
--este se almacena como entrada de produdcto al inventario de tipo I
create or alter trigger trEntradasPorInsumo--Listo
on CompraDetalle
after insert
as
begin
	--Debido a que los registros de compra detalles se van ingresando de uno en uno
	--se pueden manejar de esta manera
	
	insert into Entradas (BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select i.BodegaID,i.ProductoID,i.Cantidad,c.Fecha,'I' from inserted i inner join
	Compra as c on c.CompraID=i.CompraID
end

--Cuando se registra una entrada de cosecha, se cambia el estado de la Cosecha
--a entregado
--Y se registra la entrada del producto al inventario de tipo C
create or alter trigger trEntradasPorCosecha
on EntradaCosecha
after insert
as
begin
	--Debido a que los registros de entradacosecha se van ingresando de uno en uno
	--se pueden manejar de esta manera
	declare @CosechaID int,@ProductorID int,@Total decimal(10,2);
	select @CosechaID = CosechaID from inserted
	--Actualizar la cosecha a entregado
	update Cosecha set EstadoID=20003 where CosechaID=@CosechaID
	
	--Ingresar la entrada del producto al inventario
	insert into Entradas (BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select i.BodegaID,i.ProductoID,i.Cantidad,c.FechaIngreso,'C' from inserted i inner join
	EntradaCosecha as c on c.CosechaID=i.CosechaID

	--Ingresar la liquidacion de la cosecha como pendiente
	insert into LiquidacionCosecha(CosechaID,ProductorID,TotalPagar,EstadoID)
	select @CosechaID,i.ProductoID,i.Cantidad*i.Precio,30001 from inserted i
end

--Cuando se realiza un abono a una cosecha, se valida el valor del SaldoPendiente
--Para asignarle el estado de Parcial o Cancelado dependiendo
--De si este saldo pendiente es 0 o aun existe deuda
create or alter trigger trEstadoLiquidacion
on LiquidacionAbonos
after insert
as
begin
	--Cosecha parcialmente liquidada
	update lc 
	set EstadoID=
	case 
		when sp.SaldoPendiente = 0.00 then 30003 -- Liquidados
        else 30002 -- Parcialmente liquidados
    END 
	from LiquidacionCosecha as lc
	inner join LiquidacionAbonos as la on la.LiquidacionID=lc.LiquidacionID
	inner join vSaldoPendienteCosecha as sp on sp.LiquidacionID=lc.LiquidacionID
end

--Cuando se realiza un abono a una compra, se valida el valor del SaldoPendiente
--Para asignarle el estado de Parcial o Cancelado dependiendo
--De si este saldo pendiente es 0 o aun existe deuda
create or alter trigger trEstadoCompra
on CompraAbonos
after insert
as
begin
	update c
	set EstadoID=
	case 
		when sp.SaldoPendiente = 0.00 then 30003 -- Liquidados
        else 30002 -- Parcialmente liquidados
    END 
	from Compra as c
	INNER JOIN CompraAbonos ca ON ca.CompraID = c.CompraID
	INNER JOIN vSaldoPendienteCompra sp ON sp.CompraID = c.CompraID;
end
--Cuando registremos un abono por parte del productor a una solicitud de insumos, se valida el valor del SaldoPendiente
--Para asignarle el estado de Parcial o Cancelado dependiendo
--De si este saldo pendiente es 0 o aun existe deuda
create or alter trigger trEstadoPagoInsumos
on ProductorPagos
after insert
as
begin
	--Insumos liquidados
	update si
	set EstadoID=
	case 
		when v.SaldoPendiente = 0.00 then 30003 -- Liquidados
        else 30002 -- Parcialmente liquidados
    END 
	from SolicitudInsumos as si
	INNER JOIN ProductorPagos i ON si.SolicitudInsumosID = i.SolicitudInsumosID
	INNER JOIN vSaldoPendienteInsumos v ON si.SolicitudInsumosID = v.SolicitudInsumosID;

end


--Registramos las salidas cada que se agrega un producto a
--la tabla facturaDetalle
create or alter trigger trSalidasPorFactura --Listo
on FacturaDetalle  
after insert  
as  
begin     
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'F' from inserted  
end
--Registramos las salidas cada que se agrega un producto a
--una solicitud de insumos
create or alter trigger trSalidasPorSolicitudInsumos--Listo
on SolicitudInsumosDetalle 
after insert  
as  
begin  
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'S' from inserted  
end
--Este se ejecuta cuando el estado del voucher se actualiza a pagado,
--para efectuar los respectivos registros de pagos de insumos, pagos de cosecha
--o las deducciones de insumos que se realizan en el voucher establecido
create or alter trigger trAbonosVoucher
on Voucher
after update
as
begin

	declare @VoucherID int, @EstadoID int;
	declare VoucherCursor cursor for
	select VoucherID, EstadoID from inserted;

	open VoucherCursor;

	fetch next from VoucherCursor into @VoucherID, @EstadoID;

	while @@FETCH_STATUS = 0
	begin
		if @EstadoID=30003
		begin
			select * from voucher
			if exists(select * from VoucherProductor where VoucherID=@VoucherID)
			begin 
				--Pago de las cosechas del voucher
				insert LiquidacionAbonos(LiquidacionID,Monto,Fecha)
				select ipp.LiquidacionID,ipp.Monto,CAST(GETDATE() AS DATE) from VoucherProductor vp
				inner join IngresosProductor ipp on ipp.VoucherProductorID=vp.VoucherProductorID
				where vp.VoucherID=@VoucherID

				--Registro de los pagos de los insumos del productor
				insert ProductorPagos(SolicitudInsumosID,Abono,Fecha)
				select d.SolicitudInsumosID,d.Monto,CAST(GETDATE() AS DATE) from VoucherProductor vp 
				inner join DeduccionProductor d on d.VoucherProductorID=vp.VoucherProductorID		
				where vp.VoucherID=@VoucherID
			end
			if exists(select * from VoucherProveedor where VoucherID=@VoucherID)
			begin 
				--Cambiar el estado de la compra a pagado	
				insert CompraAbonos (CompraID,Monto,Fecha)
				select ipp.CompraID,ipp.Monto,CAST(GETDATE() AS DATE) from VoucherProveedor v  
				inner join IngresosProveedor ipp on ipp.VoucherProveedorID=v.VoucherProveedorID
				where v.VoucherID=@VoucherID;		
			end
		
		end
		fetch next from VoucherCursor into @VoucherID, @EstadoID;
	end
	close VoucherCursor;
	deallocate VoucherCursor;
end




