--Tablas Cuentas y Vouchers
create table CuentaProductor(
	CuentaProductorID int identity(1,1),
	CuentaID int not null,
	ProductorID int not null,
)

create table CuentaProveedor(
	CuentaProveedorID int identity(1,1),
	CuentaID int not null,
	ProveedorID int not null,
)

create table CuentaBancaria(
	CuentaID int not null,
	NumeroCuenta varchar(20) not null,
	BancoID int not null,
)

create table Banco(
	BancoID int not null,
	Nombre varchar(50) not null,
)


create table Cheques(
	ChequesID int identity(1,1),
	VoucherID int not null,
	BancoID int not null,
	Moneda varchar(1) not null constraint moneda_lempira default 'L',
	LugarEmision varchar(50) not null,
	FechaEmision date not null constraint fecha_emision default CAST(GETDATE() AS DATE),
	Denominacion decimal(10,2) not null,
	Firma varchar(50) not null,
)

create table Depositos(
	DepositosID int identity(1,1),
	VoucherID int not null,
	CuentaID int not null,
	Monto decimal(10,2) not null,
	Fecha date
)

create table Voucher(
	VoucherID int not null,
	NumeroVoucher varchar(12) not null,
	Fecha date not null,
	EstadoID int not null constraint No_Pagado default 30001
)

create table VoucherProductor(
	VoucherProductorID int identity(1,1),
	VoucherID int not null,
	ProductorID int not null
)
create table VoucherProveedor(
	VoucherProveedorID int identity(1,1),
	VoucherID int not null,
	ProveedorID int not null
)
create table DeduccionProductor(
	DeduccionProductorID int identity(1,1),
	VoucherProductorID int not null,
	SolicitudInsumosID int not null,
	Monto decimal (10,2) not null
)

create table IngresosProductor(
	IngresosProductorID int identity(1,1),
	VoucherProductorID int not null,
	LiquidacionID int not null,
	Monto decimal (10,2) not null
)

create table LiquidacionAbonos(
	LiquidacionAbonoID int identity(1,1),
	LiquidacionID int,
	Monto decimal(10,2),
	Fecha date
)

create table CompraAbonos(
	CompraAbonosID int identity(1,1),
	CompraID int not null,
	Monto decimal(10,2) not null,
	Fecha date not null
)

create table IngresosProveedor(
	IngresosProveedorID int identity(1,1),
	VoucherProveedorID int not null,
	CompraID int not null,
	Monto decimal (10,2) not null
)

