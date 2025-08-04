use GrupoNo1

create or alter trigger trEntradasPorInsumo
on CompraDetalle
after insert
as
begin
	declare @ID INT;
	select @ID = ISNULL(MAX(EntradaID), 0) + 1 from Entradas
	insert into Entradas (EntradaID,BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select @ID,i.BodegaID,i.ProductoID,i.Cantidad,c.Fecha,'I' from inserted i inner join
	Compra as c on c.CompraID=i.CompraID
end

create or alter trigger trEstadoLiquidacion
on LiquidacionAbonos
after insert
as
begin
	declare @id int;
	select @id =LiquidacionID from inserted
	if(select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID=@id) = 0.00
		--Cosecha liquidada
		update LiquidacionCosecha set EstadoID=30003 where LiquidacionID=@id
	else
	--Cosecha parcialmente liquidada
	update LiquidacionCosecha set EstadoID=30002 where LiquidacionID=@id
end

create or alter trigger trEstadoCompra
on CompraAbonos
after insert
as
begin
	declare @id int;
	select * from CompraAbonos
	select @id =LiquidacionID from inserted
	if(select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID=@id) = 0.00
		--Cosecha liquidada
		update LiquidacionCosecha set EstadoID=30003 where LiquidacionID=@id
	else
	--Cosecha parcialmente liquidada
	update LiquidacionCosecha set EstadoID=30002 where LiquidacionID=@id
	
end

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
	select * from s

end



create or alter trigger trEntradasPorCosecha
on EntradaCosecha
after insert
as
begin
	declare @ID INT,@CosechaID int,@ProductorID int,@Total decimal(10,2);
	select @CosechaID = CosechaID from inserted
	select @ID = ISNULL(MAX(EntradaID), 0) + 1 from Entradas
	update Cosecha set EstadoID=20003 where CosechaID=@CosechaID
	
	--Ingresar la entrada del producto al inventario
	insert into Entradas (EntradaID,BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select @ID,i.BodegaID,i.ProductoID,i.Cantidad,c.FechaIngreso,'C' from inserted i inner join
	EntradaCosecha as c on c.CosechaID=i.CosechaID

	--Ingresar la liquidacion de la cosecha como pendiente
	insert into LiquidacionCosecha(CosechaID,ProductorID,TotalPagar,EstadoID)
	select @CosechaID,i.ProductoID,i.Cantidad*i.PrecioUnitario,30001 from inserted i
end
select * from salidas

create or alter trigger trSalidasPorFactura 
on FacturaDetalle  
after insert  
as  
begin     
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'F' from inserted  
end

create or alter trigger trSalidasPorSolicitudInsumos
on SolicitudInsumosDetalle 
after insert  
as  
begin  
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'S' from inserted  
end
create or alter trigger trAbonosVoucher
on Voucher
after update
as
begin
	set nocount on;

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
		fetch next from VoucherCursor into @VoucherID, @EstadoID;
		end
	end
	close VoucherCursor;
	deallocate VoucherCursor;
end

--Prueba del funcionamiento
spRecogerCosecha 2,'5A'
select * from cosecha
select * from EntradaCosecha
select * from Entradas




