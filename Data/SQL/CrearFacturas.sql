--Una vez se ejecuta, ya queda almacenado el type en la base de datos
create type dbo.ProductoFactura as table (
    ProductoID varchar(12),
    BodegaID varchar(3),
	Precio decimal(10,2),
	Cantidad int,
	Observaciones varchar(150) null
);
declare @ProductosAgregar dbo.ProductoFactura;

-- Inserta datos en la variable tabla
INSERT INTO @ProductosAgregar (ProductoID, BodegaID, Precio, Cantidad,Observaciones)
VALUES 
	--Son solo ejemplos
    --(1, 'Producto A', 1500.00, '2023-01-15'),
    --(2, 'Producto B', 750.50, '2023-02-20'),
    --(3, 'Producto C', 2300.75, '2023-03-10');
spGenerarFactura 3,@ProductosAgregar
select * from factura
create or alter procedure spGenerarFactura
@ClienteID int,
@ProductosTable ProductoFactura readonly,
@Descripcion varchar(151) =  null,
@Impuesto varchar(20) = null,
@Descuento varchar(20) = null
as
	begin try
		exec spValidarCliente @ClienteID
		if @Descripcion is not null
			exec spValidarCampoVarchar 'Descripcion', @Descripcion, 0, 150;
		if @Impuesto is not null
			exec spValidarDecimal 'Impuesto', @Impuesto;
		if @Descuento is not null
			exec spValidarDecimal 'Descuento', @Descuento;
			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(FacturaID), 0) + 1 from factura
			insert into factura (FacturaID,ClienteID,Fecha,Impuesto,Descuento,Descripcion) values 
			(@ID,@ClienteID, CAST(GETDATE() AS DATE), @Impuesto, @Descuento, @Descuento)
			--Proceso para agregar los productos a la factura
			declare @ProductoID varchar(12),@BodegaID varchar(3),@Precio decimal(10,2),
			@Cantidad int,@Observaciones varchar(150);

			declare CursorProducto cursor for 
			select ProductoID,BodegaID,Precio,Cantidad,Observaciones from @ProductosTable
			open CursorProducto;
			fetch next from CursorProducto into @ProductoID,@BodegaID,@Precio,@Cantidad,@Observaciones
			while @@FETCH_STATUS=0
			begin
				exec spAgregarProductoFactura @ID,@ProductoID,@BodegaID,@Precio,@Cantidad,@Observaciones
				fetch next from CursorProducto into @ProductoID,@BodegaID,@Precio,@Cantidad,@Observaciones
			end
			close CursorProducto;
			deallocate CursorProducto;
		COMMIT TRANSACTION
		
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go

--Prueba de coomo se actualiza el stock y se agregan registros a la tabla salidas
select * from vStockActual
exec spAgregarProductoFactura 1, '5B','102345123412',15.2,2
select * from vStockActual

create or alter procedure spAgregarProductoFactura
@FacturaID int,--a
@ProductoID varchar(12),--a
@BodegaID varchar(2),--a
@Precio varchar(20),--a
@Cantidad int,--a
@Observaciones varchar(151) = null--a
as
	begin try
		if (select COUNT(FacturaID) from Factura where FacturaID = @FacturaID) != 1
				THROW 50051, 'No existe esta factura', 1;
		exec spValidarBodega @BodegaID
		exec spValidarProducto @ProductoID
		exec spValidarDecimal 'Precio', @Precio
		exec spvalidarCampoInt @Cantidad, 'cantidad productos'

		if (select COUNT(ProductoID) from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID) != 1
			THROW 50051, 'No existe este producto en esta bodega', 1;
		if(select Cantidad from vStockActual where ProductoID = @ProductoID and @BodegaID=BodegaID)<@Cantidad
			THROW 50052, 'No existe esta cantidad de producto', 1;
		
		if @Observaciones is not null
			exec spValidarCampoVarchar 'Observaciones', @Observaciones, 0, 150;
			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(FacturaDetalleID), 0) + 1 from FacturaDetalle
			insert into FacturaDetalle (FacturaDetalleID,FacturaID,BodegaID,ProductoID,Precio,Cantidad,Observaciones) values 
			(@ID,@FacturaID,@BodegaID,@ProductoID, @Precio, @Cantidad, @Observaciones)

		COMMIT TRANSACTION
	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
