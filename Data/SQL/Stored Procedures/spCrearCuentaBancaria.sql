
create or alter procedure spCrearCuentaBancaria
@NumeroCuenta varchar(25),
@BancoID int
as
	BEGIN TRY
		EXEC spValidarCampoInt @BancoID, 'BancoID'
		EXEC spValidarCampoVarchar @NumeroCuenta, 'Numero de cuenta', 10, 14

		if exists(select NumeroCuenta from CuentaBancaria where NumeroCuenta=@NumeroCuenta)
			THROW 50050, 'Este registro ya existe', 1;
		if not exists(select BancoID from Banco where BancoID = @BancoID)
			THROW 50051, 'El Banco solicitado no existe', 1;
		BEGIN TRANSACTION
			declare @ID int
			select @ID = ISNULL(MAX(CuentaID),0)+1 from CuentaBancaria
			insert into CuentaBancaria (CuentaID,NumeroCuenta,BancoID)
			values (@ID, @NumeroCuenta, @BancoID)
		COMMIT TRANSACTION
		SELECT 10000 as Estado, 'Cuenta bancaria creada exitosamente' as Mensaje
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje
	END CATCH