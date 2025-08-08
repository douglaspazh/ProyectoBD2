create or alter procedure spCrearFinca
@ProductorID int,
@MunicipioID int,
@Nombre varchar(51), 
@ExtencionTotal varchar(20)--decimal(10,2)
as
	begin try
		if (select COUNT(ProductorID) from productor where ProductorID = @ProductorID) != 1
				THROW 50051, 'No existe este productor', 1;
		if not exists (select MunicipioID from municipio where MunicipioID = @MunicipioID)
				THROW 50051, 'No existe este municipio', 1;
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
		exec spValidarDecimal 'Extension Total',@ExtencionTotal;
		begin transaction
			declare @ID INT;
			select @ID = ISNULL(MAX(FincaID), 0) + 1 from Finca
			
			insert into Finca (FincaID, ProductorID,Nombre,MunicipioID, ExtencionTotal) 
			values (@ID, @ProductorID,@Nombre,@MunicipioID,@ExtencionTotal)
			SELECT 10000 as Estado, 'Se creo correctamente la finca' AS Mensaje;
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go