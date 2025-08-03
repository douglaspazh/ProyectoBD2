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

create table Voucher(
	VoucherID int not null,
	NumeroVoucher varchar(12) not null,
	Fecha date not null
)

create table Cheques(
	ChequesID int not null,
	VoucherID int not null,
	BancoID int not null,
	Moneda varchar(3) not null, --USD, L, GBP... O como lo manejemos, tentativo a cambiar
	LugarEmision varchar(50) not null,
	FechaEmision date not null,
	Denominacion decimal(10,2) not null,
	Firma varchar(50) not null,
)

create table Depositos(
	DepositosID int not null,
	VoucherID int not null,
	CuentaID int not null,
	Monto decimal(10,2) not null,
	Fecha date
)

create table VoucherProductor(
	VoucherProductorID int not null,
	VoucherID int not null,
	ProductorID int not null
)

create table DeduccionProductor(
	DeduccionProductorID int not null,
	VoucherProductorID int not null,
	SolicitudInsumosID int not null,
	Monto decimal (10,2) not null
)

create table IngersosProductor(
	IngresosProductorID int not null,
	VoucherProductorID int not null,
	EntradaCosechaID int not null,
	Monto decimal (10,2) not null
)

create table VoucherProveedor(
	VoucherProveedorID int not null,
	VoucherID int not null,
	ProveedorID int not null
)

create table IngresosProveedor(
	IngresosProveedorID int not null,
	VoucherProveedorID int not null,
	CompraID int not null,
	Monto decimal (10,2) not null
)

