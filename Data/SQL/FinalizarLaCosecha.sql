create or alter procedure spCosechaFinalizada
@CosechaID int,
@FechaFinal date
as
	begin try    
		if not exists(select CosechaID from Cosecha where CosechaID = @CosechaID)     
			THROW 50051, 'No existe esta cosecha', 1;      
		if (select EstadoID from Cosecha where CosechaID = @CosechaID) = 20002     
			THROW 50052, 'Esta cosecha ya esta finalizada', 1;    
		if (select EstadoID from Cosecha where CosechaID = @CosechaID) = 20003     
			THROW 50052, 'Esta cosecha ya esta finalizada y fue recolectada', 1;       

		EXEC spValidarFecha @FechaFinal;

		declare @FechaInicio date;
		select @FechaInicio=FechaInicio from Cosecha where CosechaID = @CosechaID
		
		if @FechaInicio >= @FechaFinal
			THROW 50004, 'La fecha final de la cosecha es igual o más vieja que la fecha de inicio', 1;
			
			BEGIN TRANSACTION     
				update Cosecha set EstadoID=20002, FechaFinal=@FechaFinal where CosechaID = @CosechaID
				SELECT '10000' as Estado, 'Se ha actualizado el estado de la cosecha a finalizada' AS Mensaje;         
			COMMIT TRANSACTION   
		end try     
		begin catch        
			if @@TRANCOUNT > 0    
				ROLLBACK TRANSACTION    
			select ERROR_NUMBER() as Estado, 
		ERROR_MESSAGE() as Mensaje;   
		end catch
go
