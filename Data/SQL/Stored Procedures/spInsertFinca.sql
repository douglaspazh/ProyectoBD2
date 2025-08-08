CREATE OR ALTER PROCEDURE spInsertFinca
    @ProductorID INT,
    @MunicipioID INT,
    @Nombre VARCHAR(51),
    @Ubicacion VARCHAR(150),
    @ExtencionTotal DECIMAL(18, 2)
AS
	begin try
		if (select COUNT(ProductorID) from productor where ProductorID = @ProductorID) != 1
				THROW 50051, 'No existe este productor', 1;
		if not exists (select MunicipioID from municipio where MunicipioID = @MunicipioID)
				THROW 50051, 'No existe este municipio', 1;
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
		exec spValidarDecimal 'Extension Total',@ExtencionTotal;
        -- exec spValidarCampoVarchar 'Ubicacion', @Ubicacion, 0, 150;
		begin transaction
			declare @ID INT;
			select @ID = ISNULL(MAX(FincaID), 0) + 1 from Finca
			
			insert into Finca (FincaID, ProductorID,Nombre,MunicipioID, Ubicacion, ExtencionTotal) 
			values (@ID, @ProductorID,@Nombre,@MunicipioID,@Ubicacion,@ExtencionTotal)
			SELECT 10000 as Estado, 'Se creo correctamente la finca' AS Mensaje;
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go