create or alter procedure spCrearCosecha   
@LoteID int,  
@CultivoID int,  
@FechaInicio date = '', --En caso de que la cosecha sea mas antigua que la fecha actual, se especifica
@CantidadCosechas int 
as   
	begin try    
		if not exists(select LoteID from Lote where LoteID = @LoteID)     
			THROW 50051, 'No existe el lote solicitado', 1;      
			
		if not exists(select CultivoID from Cultivo where CultivoID = @CultivoID)     
		THROW 50051, 'No existe el cultivo solicitado', 1;  
		
		if @FechaInicio != ''
			EXEC spValidarFecha @FechaInicio;
	
		if @CantidadCosechas = 0     
			THROW 50001, 'La cantidad esperada de cosechas debe ser mayor a 0', 1;       
		
		if (select EstadoID from Cosecha where LoteID = @LoteID) = 20001     
			THROW 50052, 'El lote seleccionado esta ocupado por un cultivo en crecimiento', 1;        
		
		if (select EstadoID from Cosecha where LoteID = @LoteID) = 20002     
			THROW 50052, 'El lote seleccionado esta ocupado por un cultivo aun no cosechado y entregado', 1        
      
			BEGIN TRANSACTION    declare @ID int;    
				select @ID = ISNULL(MAX(CosechaID), 0)+1 from Cosecha    
				insert into Cosecha (CosechaID, LoteID, CultivoID, FechaInicio, EstadoID, CantidadCosechas)      
				values (@ID, @LoteID, @CultivoID, ISNULL(@FechaInicio,CAST(GETDATE() AS DATE)), 20001, @CantidadCosechas) 
				--Se crea el registro asumiendo que el la cosecha esta recien plantada.
				--Quizas mas adelante se puede manejar con un ComboBox en la pantalla pertinente
				SELECT '10000' as Estado, 'Se creo correctamente la cosecha' AS Mensaje;         
			COMMIT TRANSACTION   
		end try     
		begin catch        
			if @@TRANCOUNT > 0    
				ROLLBACK TRANSACTION    
			select ERROR_NUMBER() as Estado, 
		ERROR_MESSAGE() as Mensaje;   
		end catch
GO