--Tablas Insumos
create table SolicitudInsumos(
	SolicitudInsumosID int not null,
	ProductorID int not null,
	FechaSolicitud date null CONSTRAINT FechaSolicitud_insumos DEFAULT CAST(GETDATE() AS DATE),
	FechaPago date null,
	EstadoID int not null,
)

create table ProductorPagos(
	ProductorPagosID int identity(1,1),
	SolicitudInsumosID int not null,
	Abono decimal(10,2) not null,
	Fecha date not null
)

create table SolicitudInsumosDetalle(
	SolicitudInsumosDetalleID int identity(1,1),
	SolicitudInsumosID int,
	ProductoID varchar(12) not null,
	BodegaID varchar(2) not null,
	Cantidad int not null,
	Precio decimal(10,2) not null,
	Impuesto decimal(10,2) null
)

create table LiquidacionCosecha(
	LiquidacionID int identity(1,1),
	CosechaID int not null,
	ProductorID int not null,
	TotalPagar decimal(10,2) not null,
	EstadoID int not null
)