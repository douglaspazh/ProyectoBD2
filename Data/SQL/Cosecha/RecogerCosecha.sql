create or alter procedure spRecogerCosecha
@CosechaID int,
@BodegaID varchar(3),
@Precio varchar(20)--decimal(10,2)
as
	begin try
		if not exists(select CosechaID from Cosecha where CosechaID = @CosechaID)
			THROW 50051, 'No existe este cosecha', 1;
		exec spValidarBodega @BodegaID;
		
		if(select EstadoID from cosecha where CosechaID = @CosechaID) = 20001
			THROW 50051, 'La cosecha no se puede recojer aun', 1;
		if(select EstadoID from cosecha where CosechaID = @CosechaID) = 20003
			THROW 50051, 'La cosecha ya fue entregada', 1;

		--Obtener el producto y la cantidad de la cosecha
		declare @ProductoID varchar(12), @Cantidad int,@CantidadPorCosecha int

		select @ProductoID= cu.ProductoID,@Cantidad=co.CantidadCosechas,@CantidadPorCosecha=cu.CantidadPorCosecha
		from (select CantidadCosechas,CultivoID from cosecha where CosechaID=@CosechaID) as co 
		inner join (select ProductoID,CultivoID,CantidadPorCosecha from cultivo) as cu on cu.CultivoID = co.CultivoID 

		exec spValidarDecimal 'precio de la cosecha',@Precio
		BEGIN TRANSACTION
			insert into EntradaCosecha (CosechaID ,ProductoID,BodegaID,Cantidad, Precio) 
				values (@CosechaID, @productoID,@BodegaID,@Cantidad*@CantidadPorCosecha,@Precio)
				SELECT '10000' as Estado, 'La cosecha se ha almacenado correctamente' AS Mensaje;
		COMMIT TRANSACTION
	end try
	begin catch
		if @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		select ERROR_NUMBER() as Estado, ERROR_MESSAGE() as Mensaje;
	end catch
go