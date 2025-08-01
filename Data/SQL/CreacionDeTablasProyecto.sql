use GrupoNo1
--Agregar Listo
create table Productor(
	ProductorID int not null,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Documento varchar(13) not null,
	RTN varchar(20) null,
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
	RTN varchar(20) null,
	Direccion varchar(150) not null,
	Telefono varchar(8) not null,
	Correo varchar(50) null,
	EstadoID int not null,
	PeriodoDePagoDias int not null
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
	ProductoID int not null,
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

--En tentativa de eliminar
--create table ProveedorInsumo(
--	ProveedorID int not null,
--	ProductoID int not null,
--	EstadoID int not null,
--	Precio decimal(10,2) not null,
--	CantidadDisponible int not null
--)

create table Compra(
	CompraID int not null,
	ProveedorID int not null,
	impuesto decimal(10,2) null,
	Fecha date not null
)

create table CompraDetalle(
	CompraDetalleID int not null,
	CompraID int not null,
	ProductoID int not null,
	Cantidad int not null,
	PrecioUnitario decimal(10,2) not null,
	BodegaID int not null, --Al momento de la compra, se asigna tambien la bodega en la que sera ubicada
)

create table Bodega(
	BodegaID int not null,
	CapacidadAlmacen int not null,
	Observaciones varchar(150) null,
)
create table BodegaDetalle(
	BodegaDetalleID int not null,
	BodegaID int not null,
	ProductoID int not null,
	Cantidad int not null,
	FechaEntrada datetime not null
)
create table TrasladoBodega(
	TrasladoBodegaID int not null,
	BodegaOrigenID int not null,
	BodegaDestinoID int not null,
	ProductoID int not null,
	Cantidad int not null,
)

create table EntradaCosecha(
	EntradaCosechaID int not null,
	CosechaID int not null,
	ProductoID int not null,
	BodegaID int not null,
	Cantidad int not null,
	PrecioUnitario int not null,
	FechaIngreso date not null,
)

create table Producto(
	ProductoID int not null,
	Nombre varchar(50) not null,
	UnidadMedida varchar(10) not null,
	CategoriaID int not null
)

create table UnidadMedida(
	UnidadMedidaID int not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null,
)

--Registro de unidad hectareas
insert into UnidadMedida (UnidadMedidaID, Nombre, Observaciones) values (1,'Hectarea','Campo por defecto de las extenciones de finca')