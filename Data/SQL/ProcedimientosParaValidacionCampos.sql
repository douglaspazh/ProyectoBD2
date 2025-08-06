--Procedimientos disponibles en este documento
--spValidarProducto
--spValidarBodega
--spValidarVoucher
--spValidarEstadoID
--spValidarCliente
--spValidarFecha
--spValidarCorreo
--spValidarCampoInt
--spValidarDecimal
--spValidarCampoVarchar


create or alter procedure spValidarProducto
@ProductoID varchar(13)
as
	if not exists(select ProductoID from Producto where ProductoID = @ProductoID)
		THROW 50051, 'No existe este producto', 1;
go
create or alter procedure spValidarBodega
@BodegaID varchar(3)
as
	if not exists(select BodegaID from Bodega where BodegaID = @BodegaID)
		THROW 50051, 'No existe esta Bodega', 1;
go

create or alter procedure spValidarVoucher
@NumeroVoucher varchar(12)
as
	if exists(select NumeroVoucher from Voucher where NumeroVoucher=@NumeroVoucher)
		THROW 50050, 'Ya existe este numero de voucher', 1;
go

create or alter procedure spValidarEstadoID
@EstadoID int,
@tipo int
as
	--Activo inactivo
	if @tipo = 1
	begin
		if @EstadoID <= 10000 or @EstadoID >=20000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end
	--Cosechas
	if @tipo = 2
	begin
		if @EstadoID <= 20000 or @EstadoID >=30000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end
	--Gestiones 
	if @tipo = 3
	begin
		if @EstadoID <= 30000 or @EstadoID >=40000
			THROW 50051, 'El estado ingresado es invalido', 1;
	end

go

create or alter procedure spValidarCliente
@ClienteID int
as
	if not exists(select ClienteID from Cliente where ClienteID = @ClienteID)
		THROW 50051, 'No existe este cliente', 1;
go

create or alter procedure spValidarFecha
@fecha varchar(20)
as
	if ISDATE(@fecha)=0
		THROW 50004, 'Fecha invalida', 1;
go

create or alter procedure spValidarCorreo
@correo varchar(50)
as
	 IF @correo NOT LIKE '%@gmail.com' 
	 AND @correo NOT LIKE '%@unah.hn'
	 AND @correo NOT LIKE '%@outlook.es'
	 AND @correo NOT LIKE '%@hotmail.com'
    BEGIN
        THROW 50003, 'El correo ingresado es invalido.', 1;
    END
go

create or alter procedure spValidarCampoInt
@campo int,
@Nombre varchar(20)
as
	declare @mensajeError varchar(500);

	if @campo is null
	begin
		set @mensajeError = 'El Campo ' + @nombre + ' no puede ser vacío';
		throw 50001, @mensajeError, 1;
	end
	if @campo <	0
	begin
		set @mensajeError = 'El Campo ' + @nombre + ' no puede ser negativo';
		throw 50002, @mensajeError, 1;
	end		
go

create or alter procedure spValidarDecimal
@nombre varchar(20),
@campo varchar(20)
as
	declare @aux DECIMAL(10,2)
	set @aux = TRY_CONVERT(DECIMAL(10,2), @campo)
	if @aux is null
	begin
		declare @mensajeError varchar(200)
		SET @mensajeError = 'El Campo ' + @nombre + ' debe ser un número válido entre 0 y 99,999,999.99.';
		THROW 50002, @mensajeError, 1;
	end
	if @aux <	0
	begin
		set @mensajeError = 'El Campo ' + @nombre + ' no puede ser negativo';
		throw 50002, @mensajeError, 1;
	end	
go

create or alter procedure spValidarCampoVarchar 
@nombre varchar(50), 
@campo varchar(50), 
@minimo int, 
@maximo int
as
	DECLARE @mensajeError VARCHAR(500);

	IF @campo IS NULL OR LTRIM(RTRIM(@campo)) = ''
	BEGIN
		SET @mensajeError = 'El Campo ' + @nombre + ' no puede ser vacío';
		THROW 50001, @mensajeError, 1;
	END
	IF len(@campo) > @maximo or len(@campo) < @minimo
	BEGIN
		SET @mensajeError = 'El Campo ' + @nombre + ' debe contener '+cast(@maximo as varchar(10))+' caracteres maximo.';
		if @maximo=@minimo
			SET @mensajeError = 'El Campo ' + @nombre + ' debe de contener '+cast(@maximo as varchar(10))+' caracteres.';	
		THROW 50002, @mensajeError, 1;
	END
go