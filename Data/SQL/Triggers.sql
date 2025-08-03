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
	declare @ID INT,@CosechaID int;
	select @CosechaID = CosechaID from inserted
	select @ID = ISNULL(MAX(EntradaID), 0) + 1 from Entradas
	update Cosecha set EstadoID=20003 where CosechaID=@CosechaID

	insert into Entradas (EntradaID,BodegaID,ProductoID,Cantidad,FechaEntrada, Tipo)
	select @ID,i.BodegaID,i.ProductoID,i.Cantidad,c.FechaIngreso,'C' from inserted i inner join
	EntradaCosecha as c on c.CosechaID=i.CosechaID
end

--Prueba del funcionamiento
spRecogerCosecha 2,'5A'
select * from cosecha
select * from EntradaCosecha
select * from Entradas



