create type dbo.IngresoProveedorR as table (
    CompraID int
);


--Este es el unico procedimiento que deberian ejecutar para crear un voucher de proveedor
exec spCrearVoucherProveedor
create or alter procedure spCrearVoucherProveedor
@NumeroVoucher varchar(13),
@ProveedorID int,
@Fecha date,
@IngresosTable IngresoProveedorR readonly
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

			--Agregar ingresos
			declare @CompraID int

			declare CursorIngresos cursor for 
			select CompraID from @IngresosTable

			open CursorIngresos;
			fetch next from CursorIngresos into @CompraID
			while @@FETCH_STATUS=0
			begin
				exec spAgregarIngresoProveedorVoucher @ID,@CompraID
				fetch next from CursorIngresos into @CompraID
			end
			close CursorIngresos;
			deallocate CursorIngresos;
			SELECT '10000' as Estado, 'Se creo correctamente el voucher para el proveedor' AS Mensaje, @ID as VoucherID;
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

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