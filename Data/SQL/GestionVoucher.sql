use GrupoNo1
create or alter procedure spValidarVoucher
@NumeroVoucher varchar(12)
as
	if exists(select NumeroVoucher from Voucher where NumeroVoucher=@NumeroVoucher)
		THROW 50050, 'Ya existe este numero de voucher', 1;
go

create or alter procedure spCrearVoucherProductor
@NumeroVoucher varchar(13),
@ProductorID int,
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
			SELECT '10000' as Estado, 'Se creo correctamente el voucher para el productor' AS Mensaje, @ID as VoucherID;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go


create or alter procedure spCrearVoucherProveedor
@NumeroVoucher varchar(13),
@ProveedorID int,
@Fecha date
as
	begin try
		exec spValidarCampoVarchar 'Numero Vocher', @NumeroVoucher, 0, 12;
		exec spValidarVoucher @NumeroVoucher
		if not exists(select ProveedorID from Proveedor where ProveedorID=@ProveedorID)
			THROW 50051, 'No existe este proveedor', 1;	
		exec spValidarFecha @Fecha

		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(VoucherID), 0) + 1 from Voucher
			insert into Voucher(VoucherID,NumeroVoucher, Fecha) 
			values (@ID,@NumeroVoucher,@Fecha);

			insert into VoucherProveedor (VoucherID,ProveedorID) values (@ID,@ProveedorID);
			SELECT '10000' as Estado, 'Se creo correctamente el voucher para el proveedor' AS Mensaje, @ID as VoucherID;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

select * from VoucherProductor
select * from IngresosProductor--
select * from LiquidacionAbonos
select * from LiquidacionCosecha
select * from Voucher

exec spAgregarIngresoProductorVoucher 1, 1
select * from IngresosProductor
select * from LiquidacionAbonos
select * from LiquidacionCosecha

create or alter procedure spAgregarIngresoProductorVoucher
@VoucherID int,
@LiquidacionID int
as
	begin try
		if not exists(select v.VoucherID from voucher v inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID)
			THROW 50051, 'No existe este voucher para productor', 1;	
			
		if not exists(select LiquidacionID from LiquidacionCosecha where LiquidacionID= @LiquidacionID)
			THROW 50051, 'No existe este registro para liquidar cosecha', 1;
		--Implementar el pedirlo cuando se agregen con variables tabla
		declare @VoucherProductorID int;

		select @VoucherProductorID=vp.VoucherProductorID from voucher v 
		inner join VoucherProductor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID

		if exists(select LiquidacionID from IngresosProductor where LiquidacionID= @LiquidacionID and VoucherProductorID=@VoucherProductorID)
			THROW 50050, 'Ya existe un ingreso para esta liquidacion en el voucher', 1;

		--select * from IngresosProductor inp 
		--inner join LiquidacionCosecha as lc on lc.LiquidacionID=inp.LiquidacionID
		if (select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID = @LiquidacionID) = 0.00
			THROW 50052, 'La cosecha ya esta pagada', 1;
		declare @montoT decimal(10,2);
		select @montoT=SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID = @LiquidacionID
		--Funcionalidad de abonarCosecha
		--declare @Md decimal(10,2);
		--set @Md= convert(decimal(10,2), @Monto);
		--if (select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID= @LiquidacionID) < @Md
		--	THROW 50052, 'El monto ingresado es superior a la deuda', 1;
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

select * from ProductorPagos
select * from IngresosProductor
select * from DeduccionProductor
select * from SolicitudInsumos
exec spAgregarDeduccionProductorVoucher 1,2
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
select * from IngresosProveedor
exec spAgregarIngresoProveedorVoucher 3,2
create or alter procedure spAgregarIngresoProveedorVoucher
@VoucherID int,
@CompraID int
as
	begin try
		if not exists(select v.VoucherID from voucher v inner join VoucherProveedor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID)
			THROW 50051, 'No existe este voucher para proveedor', 1;	
			
		if not exists(select CompraID from Compra where CompraID =@CompraID)
			THROW 50051, 'No existe este registro de compra', 1;
		--Implementar el pedirlo cuando se agregen con variables tabla
		declare @VoucherProveedorID int;

		select @VoucherProveedorID=vp.VoucherProveedorID from voucher v 
		inner join VoucherProveedor vp on vp.VoucherID = v.VoucherID where vp.VoucherID=@VoucherID

		if exists(select CompraID from IngresosProveedor where CompraID=@CompraID and VoucherProveedorID=@VoucherProveedorID)
			THROW 50050, 'Ya existe un ingreso para esta compra', 1;

		--select * from IngresosProductor inp 
		--inner join LiquidacionCosecha as lc on lc.LiquidacionID=inp.LiquidacionID
		if not exists(select CompraID from vComprasPendientes where CompraID= @CompraID)
			THROW 50052, 'Esta compra ya esta pagada', 1;
		declare @montoT decimal(10,2);
		select @montoT=((Subtotal+ImpuestoTotal-Descuento)*case when DiasMora!=0 then InteresMora+1 else 1 end)
		from vComprasPendientes where CompraID= @CompraID
		--Funcionalidad de abonarCosecha
		--declare @Md decimal(10,2);
		--set @Md= convert(decimal(10,2), @Monto);
		--if (select SaldoPendiente from vSaldoPendienteCosecha where LiquidacionID= @LiquidacionID) < @Md
		--	THROW 50052, 'El monto ingresado es superior a la deuda', 1;
		BEGIN TRANSACTION
			insert into IngresosProveedor (VoucherProveedorID,CompraID,Monto) 
			values (@VoucherProveedorID,@CompraID,@montoT);
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
select SolicitudInsumosID from SolicitudInsumos
select * from SolicitudInsumosDetalle

create or alter procedure spAgregarDeduccionProductor
@VoucherID int,
@LiquidacionID int,
@Monto varchar(20)