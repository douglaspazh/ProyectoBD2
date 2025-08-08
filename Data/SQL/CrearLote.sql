create or alter procedure spCrearLote
@FincaID int,
@Extencion varchar(20),--decimal(10,2)
@TipoSuelo varchar(51) = '',
@TipoDeRiego varchar(51) = ''
as
	begin try
		--Validaciones
		if (select COUNT(FincaID) from finca where FincaID = @FincaID) != 1
				THROW 50051, 'No existe esta finca', 1;
		exec spValidarCampoVarchar 'Tipo de suelo', @TipoSuelo, 0, 50;
		exec spValidarCampoVarchar 'Tipo de riego', @TipoDeRiego, 0, 50;
		exec spValidarDecimal 'Extencion',@Extencion;

		--Evaluacion del terreno disponible
		declare @ext DECIMAL(10,2),@extotal DECIMAL(10,2),@sumext DECIMAL(10,2)

		set @ext = convert(decimal(10,2), @Extencion);

		select @extotal = ExtencionTotal from Finca where FincaID = @FincaID
		
		select @sumext = sum(Extencion) from finca as f
		inner join lote as l on l.FincaID=f.FincaID
		group by l.FincaID

		declare @msg varchar(200)
		
		if isnull(@sumext,0.0)=@extotal
		begin
			set @msg = 'No hay terreno disponible';
			THROW 50052, @msg, 1
		end
		if isnull(@sumext,0.0)+@ext>@extotal
		begin
			set @msg = concat('La extencion del terreno disponible es de ',@extotal-isnull(@sumext,0.0));
			THROW 50052, @msg, 1
		end
		begin transaction
			declare @ID INT;
			select @ID = ISNULL(MAX(LoteID), 0) + 1 from Lote
			
			insert into Lote (LoteID, FincaID,Extencion,TipoSuelo,TipoDeRiego) 
			values (@ID, @FincaID,@ext,@TipoSuelo,@TipoDeRiego)
			SELECT 10000 as Estado, 'Se creo correctamente el lote' AS Mensaje;
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go