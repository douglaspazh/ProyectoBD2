--Tablas Insumos
create table SolicitudInsumos(
	SolicitudInsumosID int not null,
	ProductorID int not null,
	FechaEntrega date,
	FechaPago date not null,
	EstadoID int not null,
)

create table ProductorPagos(
	ProductorPagosID int not null,
	SolicitudInsumosID int not null,
	Abono decimal(10,2) not null,
	Fecha date not null
)

create table SolicitudInsumosDetalle(
	SolicitudInsumosDetalleID int not null,
	ProductoID int not null,
	Cantidad decimal(10,2) not null,
	Precio decimal(10,2) not null,
	Impuesto decimal(10,2) null
)

create table LiquidacionCosecha(
	LiquidacionID int not null,
	CosechaID int not null,
	ProductorID int not null,
	TotalPagar decimal(10,2) not null,
		EstadoID int not null
)