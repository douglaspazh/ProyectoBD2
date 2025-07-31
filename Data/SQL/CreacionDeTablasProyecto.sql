use GrupoNo1

create table Productor(
	ProductorID int,
	Nombre varchar(50),
	Direccion varchar(50),
	Telefono varchar(8),
	Correo varchar(50),
	EstadoID int
)
create table Proveedor(
	ProveedorID int,
	Nombre varchar(50),
	Direccion varchar(50),
	Telefono varchar(8),
	Correo varchar(50),
	EstadoID int,
	PeriodoDePagoDias int
)
create table Finca(
	FincaID int,
	ProductorID int,
	Nombre varchar(50),
	ExtencionTotal decimal(10,2)
)

create table Lote(
	LoteID int,
	FincaID int,
	Extencion decimal(10,2),
	MaximoCosechas int,
	TipoSuelo varchar(50),
	TipoDeRiego varchar(50)
)

create table Cosecha(
	CosechaID int,
	LoteID int,
	CultivoID int,
	FechaInicio date,
	FechaFinal date,
	EstadoID int,
	CantidadCosechas int,
	Precio decimal(10,2)
)

create table Cultivo(
	CultivoID int,
	Nombre varchar(50),
	Observaciones varchar(150)
)

create table Estado(
	EstadoID int,
	Nombre varchar(25),
	Observaciones varchar(150)
)

--Esta es una tabla a la que realmente deberian tener acceso solo los proveedores, pues 
--son datos que dependen de que tienen cada uno de ellos realmente. Cosa que nosotros como
--empresa no lo manejamos realmente, pero por cualquier cosa yo la agrego a manera de registros.
create table ProveedorInsumo(
	ProveedorID int,
	ProductoID int,
	EstadoID int,
	Precio decimal(10,2),
	CantidadDisponible int
)

create table Compra(
	CompraID int,
	ProveedorID int,
	impuesto decimal(10,2),
	Fecha date
)

create table CompraDetalle(
	CompraDetalleID int,
	CompraID int,
	ProductoID int,
	Cantidad int,
	PrecioUnitario decimal(10,2),
	BodegaID int, --Al momento de la compra, se asigna tambien la bodega en la que sera ubicada
)

create table Bodega(
	BodegaID int,
	CapacidadAlmacen int,
	Observaciones varchar(150),
)
create table BodegaDetalle(
	BodegaDetalleID int,
	BodegaID int,
	ProductoID int,
	Cantidad int,
	FechaEntrada datetime
)
create table TrasladoBodega(
	TrasladoBodegaID int,
	BodegaOrigenID int,
	BodegaDestinoID int,
	ProductoID int,
	Cantidad int
)

create table EntradaCosecha(
	EntradaCosechaID int,
	CosechaID int,
	ProductoID int,
	Cantidad int,
	PrecioUnitario int,
	FechaIngreso date
)
--tablas de asignacion del producto a las bodegas,
--se manejara asi para tener mas flexibilidad a la hora de ubicar el producto en las bodegas

create table CosechaBodega(
	EntradaCosechaID int,
	BodegaID int,
	Cantidad int
)

create table CompraBodega(
	CompraDetalleID int,
	BodegaID int,
	Cantidad int
)

create table Producto(
	ProductoID int,
	Nombre varchar(50),
	UnidadMedida varchar(10),
	CategoriaID int
)

