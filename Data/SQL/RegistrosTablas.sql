USE GrupoNo1
GO

--Registros Proveedor
EXEC spCrearProveedor 'Machetes','El Diablo','Choloma','66666666','macheldia@gmail.com','6666666666666', null, 31, '0.5'
EXEC spCrearProveedor 'Guadañas','La garra','Olancho','99999999','gualagarra@gmail.com','9199999999999', null, 31, '0.5'
EXEC spCrearProveedor 'Fertilizantes','Crecedor','Choloma','44444444','felcre@gmail.com','4444444444444', null, 31, '0.5'
EXEC spCrearProveedor 'Michael','Abonos','Atlantida','33333333','micabon@gmail.com','3333333333333', null, 31, '0.5'

--Registros Producto
EXEC spCrearProducto '102345123412', 'Frijoles', 'kilos', 2 
EXEC spCrearProducto '102345123512', 'Cafe', 'kilos', 2 
EXEC spCrearProducto '102315123412', 'Semilla de girasol', 'kilos', 2 
EXEC spCrearProducto '102345133412', 'Almendras', 'kilos', 2 