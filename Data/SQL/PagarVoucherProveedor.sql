create or alter procedure spPagarVoucherProveedorDeposito
@VoucherProveedorID int,
@CuentaID int
as
	begin try
		if not exists(select VoucherProveedorID from VoucherProveedor where VoucherProveedorID=@VoucherProveedorID)
			THROW 50051, 'No existe este voucher', 1;	
		declare @CuentasDisponibles table(
			CuentaID int
		)
		insert into @CuentasDisponibles(CuentaID) 
		select cp.CuentaID from 
		(select ProveedorID from VoucherProveedor where VoucherProveedorID=@VoucherProveedorID) vp
		inner join Proveedor  p on vp.ProveedorID=p.ProveedorID
		inner join vCuentasProveedor cp on cp.ProveedorID=p.ProveedorID
		where cp.CuentaID=@CuentaID
		if not exists(select CuentaID from @CuentasDisponibles)
			THROW 50051, 'Esta cuenta no esta registrada para este proveedor', 1;	
		if (select v.EstadoID from Voucher v 
		inner join VoucherProveedor vp on vp.VoucherID=v.VoucherID where VoucherProveedorID=@VoucherProveedorID) = 30003
			THROW 50052, 'Este voucher ya esta pagado', 1;	
		BEGIN TRANSACTION
			declare @VoucherID int;
			select @VoucherID = v.VoucherID  from Voucher v 
			inner join VoucherProveedor vp on vp.VoucherID=v.VoucherID where VoucherProveedorID=@VoucherProveedorID;
			
			insert into Depositos (VoucherID,CuentaID,Monto,Fecha)
			select @VoucherID,@CuentaID,sum(Monto),CAST(GETDATE() AS DATE) from IngresosProveedor 
			where VoucherProveedorID=1
			group by VoucherProveedorID
			update Voucher set EstadoID=30003,TipoPagoID=1 where VoucherID=@VoucherID 
			
			SELECT 10000 as Estado,'El voucher ha sido pagado' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

create or alter procedure spPagarVoucherProveedorCheque
@VoucherProveedorID int,--
@BancoID int,--
@LugarEmision varchar(51),--
@Firma varchar(51)--
as
	begin try
		
		if not exists(select VoucherProveedorID from VoucherProveedor where VoucherProveedorID=@VoucherProveedorID)
			THROW 50051, 'No existe este voucher', 1;	
		if (select v.EstadoID from Voucher v
		inner join VoucherProveedor vp on vp.VoucherID=v.VoucherID where VoucherProveedorID=@VoucherProveedorID) = 30003
			THROW 50052, 'Este voucher ya esta pagado', 1;	
		if not exists(select BancoID from banco where BancoID=@BancoID)
			THROW 50051, 'No existe este banco', 1;	
		exec spValidarCampoVarchar 'Lugar Emision', @LugarEmision, 0, 50;
		exec spValidarCampoVarchar 'Firma', @Firma, 0, 50;
		BEGIN TRANSACTION
			declare @VoucherID int;
			select @VoucherID = v.VoucherID  from Voucher v 
			inner join VoucherProveedor vp on vp.VoucherID=v.VoucherID where VoucherProveedorID=@VoucherProveedorID;

			insert into Cheque (VoucherID,BancoID,LugarEmision,Denominacion,Firma)
			select @VoucherID,@BancoID,@LugarEmision,sum(Monto),@Firma from IngresosProveedor 
			where VoucherProveedorID=@VoucherProveedorID
			group by VoucherProveedorID
			update Voucher set EstadoID=30003,TipoPagoID=2 where VoucherID=@VoucherID 
			
			SELECT 10000 as Estado,'El voucher ha sido pagado' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go