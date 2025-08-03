CREATE OR ALTER PROCEDURE spCrearCuentaEntidad
@CuentaID INT,
@EntidadID INT,
@TipoEntidad VARCHAR(20) -- 'Productor' or 'Proveedor'
AS
BEGIN TRY
	EXEC spValidarCampoInt @CuentaID, 'CuentaID'
	EXEC spValidarCampoInt @EntidadID, 'EntidadID'

	if not exists (SELECT 1 FROM CuentaBancaria WHERE CuentaID = @CuentaID)
		THROW 50051, 'La cuenta bancaria no existe', 1;
	
	declare @ID INT;
	if @TipoEntidad = 'Productor'
		BEGIN
			if not exists (SELECT 1 FROM Productor WHERE ProductorID = @EntidadID)
				THROW 50051, 'El Productor referenciado no existe', 1;
	
			if exists (SELECT 1 FROM CuentaProductor WHERE CuentaID = @CuentaID AND ProductorID = @EntidadID)
				THROW 50050, 'Ya existe esta relación', 1;
	
			BEGIN TRANSACTION
				select @ID = ISNULL(MAX(CuentaProductorID),0)+1 FROM CuentaProductor;
				insert into CuentaProductor (CuentaProductorID, CuentaID, ProductorID)
				values (@ID, @CuentaID, @EntidadID);
			COMMIT TRANSACTION
	
			SELECT 10000 as Estado, 'Cuenta asociada al productor exitosamente' as Mensaje;
		END
		ELSE IF @TipoEntidad = 'Proveedor'
		BEGIN
			if not exists (SELECT 1 FROM Proveedor WHERE ProveedorID = @EntidadID)
				THROW 50051, 'El Proveedor referenciado no existe', 1;

			if exists (SELECT 1 FROM CuentaProveedor WHERE CuentaID = @CuentaID AND ProveedorID = @EntidadID)
				THROW 50050, 'Ya existe esta relación', 1;
	
			BEGIN TRANSACTION
				select @ID = ISNULL(MAX(CuentaProveedorID),0)+1 FROM CuentaProveedor;
				insert into CuentaProveedor (CuentaProveedorID, CuentaID, ProveedorID)
				values (@ID, @CuentaID, @EntidadID);
			COMMIT TRANSACTION
	
			SELECT 10000 as Estado, 'Cuenta asociada al proveedor exitosamente' as Mensaje;
		END
		ELSE
			THROW 50005, 'Tipo de entidad no válido. Debe ser ''Productor'' o ''Proveedor''.', 1;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		SELECT ERROR_NUMBER() AS Estado, ERROR_MESSAGE() AS Mensaje;
	END CATCH
GO