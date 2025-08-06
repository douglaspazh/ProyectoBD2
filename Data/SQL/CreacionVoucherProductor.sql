create type dbo.IngresoProductorR as table (
    LiquidacionID int
);
create type dbo.DeduccionProductorR as table (
    SolicitudInsumosID int
);

--Este es el unico procedimiento que deberian de ejecutar
exec spCrearVoucherProductor
create or alter procedure spCrearVoucherProductorAbonarCosecha
@NumeroVoucher varchar(13),
@ProductorID int,
@LiquidacionID int,
@MontoAbonar varchar(20),-- decimal(10,2)
@Fecha date
as
	begin try
		exec spValidarCampoVarchar 'Numero Vocher', @NumeroVoucher, 0, 12;
		exec spValidarVoucher @NumeroVoucher
		if not exists(select ProductorID from productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este productor', 1;	
		exec spValidarFecha @Fecha
		exec spValidarDecimal 'Monto a abonar',@MontoAbonar
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(VoucherID), 0) + 1 from Voucher
			insert into Voucher(VoucherID,NumeroVoucher, Fecha) 
			values (@ID,@NumeroVoucher,@Fecha);
			insert into VoucherProductor(VoucherID,ProductorID) 
			values (@ID,@ProductorID);
			exec spAgregarIngresoProductorVoucher @ID,@LiquidacionID,@MontoAbonar

			SELECT '10000' as Estado, 'Se creo correctamente el voucher para el productor' AS Mensaje
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

create or alter procedure spCrearVoucherProductor
@NumeroVoucher varchar(13),
@ProductorID int,
@IngresosTable IngresoProductorR readonly,
@DeduccionesTable DeduccionProductorR readonly,
@Fecha date
as
	begin try
		exec spValidarCampoVarchar 'Numero Vocher', @NumeroVoucher, 0, 12;
		exec spValidarVoucher @NumeroVoucher
		if not exists(select ProductorID from productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este productor', 1;	
		exec spValidarFecha @Fecha

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(VoucherID), 0) + 1 from Voucher
			insert into Voucher(VoucherID,NumeroVoucher, Fecha) 
			values (@ID,@NumeroVoucher,@Fecha);
			insert into VoucherProductor(VoucherID,ProductorID) 
			values (@ID,@ProductorID);
			
			
			--Agregar ingresos
			declare @LiquidacionID int

			declare CursorIngresos cursor for 
			select LiquidacionID from @IngresosTable

			open CursorIngresos;
			fetch next from CursorIngresos into @LiquidacionID
			while @@FETCH_STATUS=0
			begin
				exec spAgregarIngresoProductorVoucher @ID,@LiquidacionID
				fetch next from CursorIngresos into @LiquidacionID
			end
			close CursorIngresos;
			deallocate CursorIngresos;
			--Agregar deducciones
			declare @SolicitudInsumosID int

			declare CursorDeducciones cursor for 
			select @SolicitudInsumosID from @IngresosTable

			open CursorDeducciones;
			fetch next from CursorDeducciones into @SolicitudInsumosID
			while @@FETCH_STATUS=0
			begin
				exec spAgregarDeduccionProductorVoucher @ID,@SolicitudInsumosID
				fetch next from CursorDeducciones into @SolicitudInsumosID
			end
			close CursorDeducciones;
			deallocate CursorDeducciones;
			declare @VPID as int
			select @VPID=VoucherProductorID from VoucherProductor where VoucherID=@ID
			
			SELECT '10000' as Estado, 'Se creo correctamente el voucher para el productor' AS Mensaje
			if(select TotalPagar from vTotalPagarVoucherProductor where VoucherProductorID=@VPID) = 0
			begin
				--Se cambia el voucher a pagado, y el tipo de pago es complemento de pago
				update Voucher set EstadoID=30003,TipoPagoID=3 where VoucherID=@ID 
				SELECT '10000' as Estado, 'Se actualizo el voucher a pagado por complemento de pago' AS Mensaje
			end
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go


create or alter procedure spAgregarIngresoProductorVoucher
@VoucherID int,
@LiquidacionID int,
@MontoPagar decimal(10,2)= null--Agregado
as
	begin try
		if not exists(select v.VoucherID from voucher v inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID)
			THROW 50051, 'No existe este voucher para productor', 1;	
			
		if not exists(select LiquidacionID from LiquidacionCosecha where LiquidacionID= @LiquidacionID)
			THROW 50051, 'No existe este registro para liquidar cosecha', 1;

		declare @VoucherProductorID int,@ProductorID int;

		select @VoucherProductorID=vp.VoucherProductorID,@ProductorID=vp.ProductorID from voucher v 
		inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID

		if not exists(select ProductorID from LiquidacionCosecha where ProductorID=@ProductorID and LiquidacionID=@LiquidacionID)
			THROW 50051, 'Esta cosecha no pertenece a este productor', 1;
		if exists(select LiquidacionID from IngresosProductor where LiquidacionID= @LiquidacionID and VoucherProductorID=@VoucherProductorID)
			THROW 50050, 'Ya existe un ingreso para esta liquidacion en el voucher', 1;
		if (select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID = @LiquidacionID) = 0.00
			THROW 50052, 'La cosecha ya esta pagada', 1;
		declare @montoT decimal(10,2);
		if @MontoPagar is null--agregado
			select @montoT=SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID = @LiquidacionID
		else
		begin
			if (select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID = @LiquidacionID)<@MontoPagar
				THROW 50052, 'El monto ingresado supera el de la deuda', 1;
			select @montoT=@MontoPagar
		end
		BEGIN TRANSACTION
			insert into IngresosProductor (VoucherProductorID,LiquidacionID,Monto) 
			values (@VoucherProductorID,@LiquidacionID,@montoT);
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

create or alter procedure spAgregarDeduccionProductorVoucher
@VoucherID int,
@SolicitudInsumosID int
as
	begin try
		if not exists(select v.VoucherID from voucher v inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID)
			THROW 50051, 'No existe este voucher para productor', 1;	
			
		if not exists(select SolicitudInsumosID from SolicitudInsumos where SolicitudInsumosID= @SolicitudInsumosID)
			THROW 50051, 'No existe este registro de insumos', 1;
		declare @VoucherProductorID int;
		if not exists(select SolicitudInsumosID from vSaldoPendienteInsumos where SolicitudInsumosID= @SolicitudInsumosID)
			THROW 50051, 'La solicitud no tiene productos agregdos, por ende, no hay deuda', 1;
		select @VoucherProductorID=vp.VoucherProductorID from voucher v 
		inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID

		if exists(select SolicitudInsumosID from DeduccionProductor where SolicitudInsumosID= @SolicitudInsumosID and VoucherProductorID=@VoucherProductorID)
			THROW 50050, 'Ya existe un ingreso para esta liquidacion en el voucher', 1;

		--select * from IngresosProductor inp 
		--inner join LiquidacionCosecha as lc on lc.LiquidacionID=inp.LiquidacionID
		if (select SaldoPendiente from vSaldoPendienteInsumos where SolicitudInsumosID = @SolicitudInsumosID) = 0.00
			THROW 50052, 'La cosecha ya esta pagada', 1;
		declare @montoT decimal(10,2);
		select @montoT=SaldoPendiente from vSaldoPendienteInsumos where SolicitudInsumosID = @SolicitudInsumosID
		if(select TotalPagar-@montoT from vTotalPagarVoucherProductor where VoucherProductorID=@VoucherProductorID) < 0
				THROW 50052, 'No se puede ingresar esta deduccion, pues resultaria en un saldo negativo a pagar', 1;
		BEGIN TRANSACTION
			insert into DeduccionProductor (VoucherProductorID,SolicitudInsumosID,Monto) 
			values (@VoucherProductorID,@SolicitudInsumosID,@montoT);
			
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go