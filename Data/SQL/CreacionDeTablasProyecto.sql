use GrupoNo1

--Agregar Listo
create table Productor(
	ProductorID int not null,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Documento varchar(13) not null,
	RTN varchar(14) null,
	Direccion varchar(150) not null,
	Telefono varchar(8) not null,
	Correo varchar(50) null,
	EstadoID int not null
)
create table Proveedor(
	ProveedorID int,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Documento varchar(13) not null,
	RTN varchar(14) null,
	Direccion varchar(150) not null,
	Telefono varchar(8) not null,
	Correo varchar(50) null,
	EstadoID int not null,
	PeriodoDePagoDias int not null,
	TasaInteres decimal(10,2) not null
)

create table Finca(
	FincaID int not null,
	ProductorID int not null,
	Nombre varchar(50) not null,
	ExtencionTotal decimal(10,2) not null,
	UnidadMedidaID int null CONSTRAINT Finca_UnidadMedida DEFAULT 1
)

create table Lote(
	LoteID int not null,
	FincaID int not null,
	Extencion decimal(10,2) not null,
	MaximoCosechas int not null,
	TipoSuelo varchar(50) null,
	TipoDeRiego varchar(50) null,
	UnidadMedidaID int null CONSTRAINT Lote_UnidadMedida DEFAULT 1
)
create table Cosecha(
	CosechaID int not null,
	LoteID int not null,
	CultivoID int not null,
	FechaInicio date null,
	FechaFinal date null,
	EstadoID int not null,
	CantidadCosechas int not null,
	Precio decimal(10,2) not null
)

create table Cultivo(
	CultivoID int not null,
	ProductoID varchar(12) not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null
)

create table Estado(
	EstadoID int not null,
	Nombre varchar(25) not null,
	Observaciones varchar(150) null
)
--Esta es una tabla a la que realmente deberian tener acceso solo los proveedores, pues 
--son datos que dependen de que tienen cada uno de ellos realmente. Cosa que nosotros como
--empresa no lo manejamos realmente, pero por cualquier cosa yo la agrego a manera de registros.


create table ProveedorInsumo(
	ProveedorID int not null,
	ProductoID varchar(12) not null,
	EstadoID int not null,--(Disponible, agotado)
	Precio decimal(10,2) not null,
)
create table Compra(
	CompraID int not null,
	ProveedorID int not null,
	Impuesto decimal(10,2) null,
	Descuento decimal(10,2) null,
	Fecha date not null,
	EstadoID int null CONSTRAINT Compra_sin_abono DEFAULT 30001
)

create table CompraDetalle(
	CompraDetalleID int not null,
	CompraID int not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	PrecioUnitario decimal(10,2) not null,
	BodegaID varchar(2) not null, --Al momento de la compra, se asigna tambien la bodega en la que sera ubicada
)

create table Bodega(
	BodegaID varchar(2) not null,
	Observaciones varchar(150) null,
)
create table BodegaDetalle(
	BodegaDetalleID int not null,
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	FechaEntrada datetime not null
)
create table TrasladoBodega(
	TrasladoBodegaID int not null,
	BodegaOrigenID varchar(2) not null,
	BodegaDestinoID varchar(2) not null,
	ProductoID int not null,
	Cantidad int not null,
)

create table EntradaCosecha(
	EntradaCosechaID int identity(1,1),
	CosechaID int not null,
	ProductoID varchar(12) not null,
	BodegaID varchar(2) not null,
	Cantidad int not null,
	PrecioUnitario int not null,
	FechaIngreso date null
	CONSTRAINT FechaIngreso_cosecha DEFAULT CAST(GETDATE() AS DATE)
)
create table Producto(
	ProductoID varchar(12) not null,
	Nombre varchar(50) not null,
	UnidadMedida varchar(10) not null,
	CategoriaID int null
)

create table UnidadMedida(
	UnidadMedidaID int not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null,
)
create table Categoria(
	CategoriaID int not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null
)

create table Entradas(
	EntradaID int not null,
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	FechaEntrada date not null,
	Tipo varchar(1) not null,
	 CONSTRAINT CK_TipoValido 
        CHECK (Tipo IN ('C', 'I')) 
	--C de cosechas
	--I de insumos
)

create table Cliente(
	ClienteID int not null,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Direccion varchar(150) null,
	Documento varchar(13) not null,
	RTN varchar(14) null,
	Telefono varchar(8) null,
	Correo varchar(50)null,
)

create table Factura(
	FacturaID int not null,
	ClienteID int not null,
	Fecha date not null,
	Impuesto decimal(10,2) null,
	Descuento decimal(10,2) null,
	Descripcion varchar(150) null 
)

create table FacturaDetalle(
	FacturaDetalleID int not null,
	FacturaID int not null,
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Precio decimal(10,2) not null,
	Cantidad int not null,
	Observaciones varchar(150) null
)

create table Salidas(
	SalidaID int identity(1,1),
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	FechaDeSalida date not null,
	Tipo varchar(1) not null
)

insert into salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida) values ('5B','102345123412', 7,CAST(GETDATE() AS DATE))
insert into salidas (BodegaID,ProductoID,Cantidad,FechaDeSalida) values ('5A','1', 1,CAST(GETDATE() AS DATE))
insert into Categoria (CategoriaID,Nombre) values (1,'Legumbres')
--Registro de unidad hectareas
insert into UnidadMedida (UnidadMedidaID, Nombre, Observaciones) values (1,'Hectarea','Campo por defecto de las extenciones de finca')