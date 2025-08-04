--Procedimiento crear cuenta para Productores
create or alter procedure spCrearCuentaProductor
@ProductorID int,
@BancoID int,
@NumeroCuenta varchar(25)
as
	BEGIN TRY
		if not exists(select ProductorID from Productor where ProductorID=@ProductorID)
			THROW 50051, 'El productor referenciado no existe', 1;
		
		declare @CuentaID int;

		EXEC spCrearCuentaBancaria @NumeroCuenta, @BancoID, @CuentaID output

		BEGIN TRANSACTION
			insert into CuentaProductor (CuentaID,ProductorID)
			values (@CuentaID, @ProductorID)
		COMMIT TRANSACTION
		SELECT 10000 as Estado, 'Cuenta de productor creada exitosamente' as Mensaje
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje
	END CATCH
GO 

--Procedimiento crear cuenta para Proveedores
exec spCrearCuentaProveedor 2,3,'475344758957' 
exec spCrearCuentaProveedor 2,3,'852334758957' 
exec spCrearCuentaProveedor 2,3,'152344758957' 
select * from Banco
create or alter procedure spCrearCuentaProveedor
@ProveedorID int,
@BancoID int,
@NumeroCuenta varchar(25)
as
	BEGIN TRY
	
		if not exists(select ProveedorID from Proveedor where ProveedorID=@ProveedorID)
			THROW 50051, 'El Proveedor referenciado no existe', 1;

		declare @CuentaID int;

		EXEC spCrearCuentaBancaria @NumeroCuenta, @BancoID, @CuentaID output
	
		BEGIN TRANSACTION
			insert into CuentaProveedor (CuentaID,ProveedorID)
			values (@CuentaID, @ProveedorID)
		COMMIT TRANSACTION
		SELECT 10000 as Estado, 'Cuenta de Proveedor creada exitosamente' as Mensaje
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje
	END CATCH
GO