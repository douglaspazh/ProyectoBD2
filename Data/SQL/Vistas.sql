--Ver el inventario de todos los productos
create or alter view vStockActual AS
select ProductoID, BodegaID, sum(Cantidad) as Cantidad from
(
select ProductoID,BodegaID,sum(cantidad)*-1 as Cantidad,'S'as Tipo from salidas group by BodegaID, ProductoID 
union all 
select ProductoID,BodegaID,sum(cantidad) as Cantidad,'E'as Tipo from entradas group by BodegaID, ProductoID
) as mov