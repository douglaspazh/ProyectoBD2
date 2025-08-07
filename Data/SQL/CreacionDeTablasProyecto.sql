use GrupoNo1
-- Transaccion correcta:
--10000 operacion realizada correctamente
--Codigos de error:
--50001 el campo esta vacio
--50002 tamaño incorrecto del campo
--50003 correo invalido
--50004 Fechas incompatibles
--50005 Dato incompatible
--50050 registro duplicado
--50051 registro inexistente
--50052 problemas logisticos
--Tabla lista
create table Productor(
	ProductorID int not null,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Documento varchar(13) not null,
	RTN varchar(14) null,
	Telefono varchar(8) not null,
	Correo varchar(50) null,
	EstadoID int not null
)
--Crear procedimientos para cambiar el estadoId del proveedor y del productor
--Listo
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
--tabla lista
create table Finca(
	FincaID int not null,
	ProductorID int not null,
	Nombre varchar(50) not null,
	MunicipioID int not null,
	ExtencionTotal decimal(10,2) not null,
	UnidadMedidaID int null CONSTRAINT Finca_UnidadMedida DEFAULT 1
)

--listo
CREATE TABLE Departamento (
    DepartamentoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL
);
--listo
CREATE TABLE Municipio (
    MunicipioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    DepartamentoID INT NOT NULL,
    FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID)
);
--Listo
create table Lote(
	LoteID int not null,
	FincaID int not null,
	Extencion decimal(10,2) not null,
	TipoSuelo varchar(50) null,
	TipoDeRiego varchar(50) null,
	UnidadMedidaID int null CONSTRAINT Lote_UnidadMedida DEFAULT 1
)

--listo
create table Cosecha(
	CosechaID int not null,
	LoteID int not null,
	CultivoID int not null,
	FechaInicio date null,
	FechaFinal date null,
	EstadoID int not null,
	CantidadCosechas int not null,
)

--listo
create table Cultivo(
	CultivoID int not null,
	ProductoID varchar(12) not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null,
	CantidadPorCosecha int not null
)

--listo
create table Estado(
	EstadoID int not null,
	Nombre varchar(25) not null,
	Observaciones varchar(150) null
)
--Esta es una tabla a la que realmente deberian tener acceso solo los proveedores, pues 
--son datos que dependen de que tienen cada uno de ellos realmente. Cosa que nosotros como
--empresa no lo manejamos realmente, pero por cualquier cosa yo la agrego a manera de registros.


--create table ProveedorInsumo(
--	ProveedorID int not null,
--	ProductoID varchar(12) not null,
--	EstadoID int not null,--(Disponible, agotado)
--	Precio decimal(10,2) not null,
--)
--listo
create table Producto(
	ProductoID varchar(12) not null,
	Nombre varchar(50) not null,
	ContenidoPorUnidad varchar(15) not null,
	CategoriaID int null
)
--listo
create table Categoria(
	CategoriaID int identity(1,1),
	Nombre varchar(50) not null,
	Observaciones varchar(150) null
)
--Listo
create table Bodega(
	BodegaID varchar(2) not null,
	Observaciones varchar(150) null,
)
--listo
create table Compra(
	CompraID int not null,
	ProveedorID int not null,
	Impuesto decimal(10,2) null,
	Descuento decimal(10,2) null,
	Fecha date not null,
	EstadoID int null CONSTRAINT Compra_sin_abono DEFAULT 30001
)
--listo
create table CompraDetalle(
	CompraDetalleID int not null,
	CompraID int not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	Precio decimal(10,2) not null,
	BodegaID varchar(2) not null, --Al momento de la compra, se asigna tambien la bodega en la que sera ubicada
)

--listo
create table EntradaCosecha(
	EntradaCosechaID int identity(1,1),
	CosechaID int not null,
	ProductoID varchar(12) not null,
	BodegaID varchar(2) not null,
	Cantidad int not null,
	Precio decimal(10,2) not null,
	FechaIngreso date null
	CONSTRAINT FechaIngreso_cosecha DEFAULT CAST(GETDATE() AS DATE)
)
--Listo
create table Entradas(
	EntradaID int identity(1,1),
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	FechaEntrada date not null,
	Tipo varchar(1) not null,
	 CONSTRAINT CK_eTipoValido 
        CHECK (Tipo IN ('C', 'I')) 
	--C de cosechas
	--I de insumos
)

--listo
create table UnidadMedida(
	UnidadMedidaID int not null,
	Nombre varchar(50) not null,
	Observaciones varchar(150) null,
)
--Listo
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
--listo
create table Factura(
	FacturaID int not null,
	ClienteID int not null,
	Fecha date not null,
	Impuesto decimal(10,2) null,
	Descuento decimal(10,2) null,
	Descripcion varchar(150) null 
)
--listo
create table FacturaDetalle(
	FacturaDetalleID int not null,
	FacturaID int not null,
	ProductoID varchar(12) not null,
	BodegaID varchar(2) not null,
	Precio decimal(10,2) not null,
	Cantidad int not null,
	Observaciones varchar(150) null
)
--Listo
create table Salidas(
	SalidaID int identity(1,1),
	BodegaID varchar(2) not null,
	ProductoID varchar(12) not null,
	Cantidad int not null,
	FechaDeSalida date not null,
	Tipo varchar(1) not null
	CONSTRAINT CK_sTipoValido 
        CHECK (Tipo IN ('F', 'S'))
)

--Registro de unidad hectareas
insert into UnidadMedida (UnidadMedidaID, Nombre, Observaciones) values (1,'Hectarea','Campo por defecto de las extenciones de finca')