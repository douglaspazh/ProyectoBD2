CREATE OR ALTER PROCEDURE spInsertLote
    @FincaID INT,
    @Extencion DECIMAL(10, 2),
    @TipoSuelo VARCHAR(50),
    @TipoRiego VARCHAR(50)
AS
	begin try
		if (select COUNT(FincaID) from Finca where FincaID = @FincaID) != 1
			THROW 50051, 'No existe esta finca', 1;
		exec spValidarDecimal 'Extencion', @Extencion;
		exec spValidarCampoVarchar 'Tipo Suelo', @TipoSuelo, 0, 50;
		exec spValidarCampoVarchar 'Tipo Riego', @TipoRiego, 0, 50;

		begin transaction
			declare @ID INT;
			select @ID = ISNULL(MAX(LoteID), 0) + 1 from Lote
			insert into Lote (LoteID, FincaID, Extencion, TipoSuelo, TipoDeRiego) 
			values (@ID, @FincaID, @Extencion, @TipoSuelo, @TipoRiego)
			SELECT 10000 as Estado, 'Se creo correctamente el lote' AS Mensaje;
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go