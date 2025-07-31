use GrupoNo1
--Codigos de error
--50001 el campo esta vacio
--50002 tamaño incorrecto del campo
--50003 correo invalido
--50050 registro duplicado
--50051 registro inexistente
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

create or alter procedure spCrearProductor
@Nombre varchar(26), 
@Apellido varchar(26), 
@Direccion varchar(51), 
@Telefono varchar(9), 
@Correo varchar(51),
@Documento varchar(14),
@RTN varchar(21) = null
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
		exec spValidarCampoVarchar 'Apellido', @Apellido, 0, 50;
		exec spValidarCampoVarchar 'Direccion', @Direccion, 0, 150;
		exec spValidarCampoVarchar 'Telefono', @Telefono, 8, 8;
		exec spValidarCampoVarchar 'Correo', @Correo, 0, 50;
		exec spValidarCorreo @Correo;
		exec spValidarCampoVarchar 'Documento', @Documento, 0, 13;
		if @RTN != null
			exec spValidarCampoVarchar 'RTN', @Correo, 0, 20;
		if (select COUNT(Documento) from productor where Documento = @Documento) > 1
			THROW 50050, 'Ya existe este registro.', 1;			
		BEGIN TRANSACTION
			declare @ID INT;
			select @ID = ISNULL(MAX(ProductorID), 0) + 1 from Productor
			insert into Productor (ProductorID,Nombre,Apellido,Direccion,Telefono,Correo,EstadoID,Documento, RTN) values (@ID,@Nombre, @Apellido, @Direccion, @Telefono, @Correo,1001,@Documento,@RTN)
			
		COMMIT TRANSACTION

	end try
	begin catch
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
--Nota: Los campos decimal, se tomaran como un varchar inicialmente para facilitar su validacion
create or alter procedure spCrearFinca
@PId int,
@Nombre varchar(51), 
@ExtencionTotal varchar(20)
as
	begin try
		exec spValidarCampoVarchar 'Nombre', @Nombre, 0, 50;
		exec spValidarDecimal 'Extension Total',@ExtencionTotal;
		declare @ext DECIMAL(10,2)
		set @ext = CONVERT(DECIMAL(10,2), @ExtencionTotal);
		begin transaction
			declare @ID INT;
			select @ID = ISNULL(MAX(FincaID), 0) + 1 from Finca
			if (select COUNT(ProductorID) from productor where ProductorID = @PId) != 1
				THROW 50051, 'No existe este registro.', 1;
			insert into Finca (FincaID, ProductorID,Nombre,ExtencionTotal) values (@ID, @PId,@Nombre,@ext)
		commit transaction 
	end try
	begin catch	
		IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION; 
		SELECT ERROR_NUMBER() as Estado,ERROR_MESSAGE() AS Mensaje;
	end catch
go
--Prueba del procedimento almacenado
---spCrearProductor 'Alejandro Josue', 'Chavez Irias', 'a', '97589431','alejnadro@unah.hn','0501200311847'

--Ver los constraint de una tabla
--EXEC sp_helpconstraint 'Productor';

--Agregado de los estados activo e inactivo
insert into estado (EstadoID, Nombre, Observaciones) values (10001, 'Activo', 'Indica que el registro esta activo')
insert into estado (EstadoID, Nombre, Observaciones) values (10002, 'Inactivo', 'Indica que el registro esta inactivo')

--Constraints
--recomiendo no agregarlos aun, por si se ocupa hacer una modificacion a alguna tabla
--pero igualmente es bueno tenerlos ya preparados
ALTER TABLE Productor
    ADD CONSTRAINT PK_Productor PRIMARY KEY (ProductorID);
ALTER TABLE Finca
    ADD CONSTRAINT PK_Finca PRIMARY KEY (FincaID)
ALTER TABLE Estado
    ADD CONSTRAINT PK_Estado PRIMARY KEY (EstadoID)
ALTER TABLE Productor
	ADD CONSTRAINT FK_Productor_Estado FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID);
ALTER TABLE Finca
    ADD CONSTRAINT FK_Finca_Productor FOREIGN KEY (ProductorID) REFERENCES Productor(ProductorID);
