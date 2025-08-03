create or alter procedure spCrearCuentaBancaria
@NumeroCuenta varchar(25),
@BancoID int,
@CuentaID int output
as
	BEGIN TRY
		EXEC spValidarCampoVarchar 'Numero de cuenta', @NumeroCuenta, 10, 14

		if exists(select NumeroCuenta from CuentaBancaria where NumeroCuenta=@NumeroCuenta)
			THROW 50050, 'Este registro ya existe', 1;
		
		if not exists(select BancoID from Banco where BancoID = @BancoID)
			THROW 50051, 'El Banco solicitado no existe', 1;
		
		BEGIN TRANSACTION
			select @CuentaID = ISNULL(MAX(CuentaID),0)+1 from CuentaBancaria
			insert into CuentaBancaria (CuentaID,NumeroCuenta,BancoID)
			values (@CuentaID, @NumeroCuenta, @BancoID)
		COMMIT TRANSACTION
		SELECT 10000 as Estado, 'Cuenta bancaria creada exitosamente' as Mensaje
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje
	END CATCH
GO