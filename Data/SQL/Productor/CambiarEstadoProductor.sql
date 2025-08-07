create or alter procedure spEstadoInactivoProductor
@ProductorID int
as
	begin try
		if not exists(select ProductorID from Productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este productor', 1;		
			if (select EstadoID from Productor where ProductorID=@ProductorID)=10002
			THROW 50052, 'Este productor ya esta inactivo', 1;		
		BEGIN TRANSACTION
			update productor set EstadoID=10002 where ProductorID=@ProductorID
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

create or alter procedure spEstadoActivoProductor
@ProductorID int
as
	begin try
		if not exists(select ProductorID from Productor where ProductorID=@ProductorID)
			THROW 50051, 'No existe este productor', 1;		
			if (select EstadoID from Productor where ProductorID=@ProductorID)=10001
			THROW 50052, 'Este productor ya esta activo', 1;		
		BEGIN TRANSACTION
			update productor set EstadoID=10001 where ProductorID=@ProductorID
		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go