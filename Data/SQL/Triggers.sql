use GrupoNo1

create or alter trigger trEntradasPorInsumo
on CompraDetalle
after insert
as
begin
	declare @ID INT;
	select @ID = ISNULL(MAX(EntradaID), 0) + 1 from Entradas
	insert into Entradas (EntradaID,BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select @ID,i.BodegaID,i.ProductoID,i.Cantidad,c.Fecha,'I' from inserted i inner join
	Compra as c on c.CompraID=i.CompraID
end

create or alter trigger trEntradasPorCosecha
on EntradaCosecha
after insert
as
begin
	declare @ID INT,@CosechaID int,@ProductorID int,@Total decimal(10,2);
	select @CosechaID = CosechaID from inserted
	select @ID = ISNULL(MAX(EntradaID), 0) + 1 from Entradas
	update Cosecha set EstadoID=20003 where CosechaID=@CosechaID
	
	--Ingresar la entrada del producto al inventario
	insert into Entradas (EntradaID,BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select @ID,i.BodegaID,i.ProductoID,i.Cantidad,c.FechaIngreso,'C' from inserted i inner join
	EntradaCosecha as c on c.CosechaID=i.CosechaID
	select * from EntradaCosecha

	--Ingresar la liquidacion de la cosecha como pendiente
	insert into LiquidacionCosecha(CosechaID,ProductorID,TotalPagar,EstadoID)
	select @CosechaID,i.ProductoID,i.Cantidad*i.PrecioUnitario,30001 from inserted i
end
select * from salidas

create or alter trigger trSalidasPorFactura 
on FacturaDetalle  
after insert  
as  
begin  
	declare @ID INT;   
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'F' from inserted  
end

create or alter trigger trSalidasPorSolicitudInsumos
on SolicitudInsumosDetalle 
after insert  
as  
begin  
	declare @ID INT;  
	
	insert into Salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida,Tipo) 
	select BodegaID,ProductoID,Cantidad,CAST(GETDATE() AS DATE),'S' from inserted  
end
--Prueba del funcionamiento
spRecogerCosecha 2,'5A'
select * from cosecha
select * from EntradaCosecha
select * from Entradas




