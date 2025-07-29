CREATE TABLE Finca(
	FincaID         int NOT NULL,
	ProductorID     int NOT NULL,
	Nombre          varchar(50) NOT NULL,
	Direccion       varchar(50) NOT NULL,
	ExtensionTotal  decimal(10,2) NOT NULL,
    FechaRegistro   DATE DEFAULT CAST(GETDATE() AS DATE) NOT NULL
)

ALTER TABLE Finca
    ADD CONSTRAINT PK_Finca PRIMARY KEY (FincaID);
ALTER TABLE Finca
    ADD CONSTRAINT FK_Finca_Productor FOREIGN KEY (ProductorID) REFERENCES Productor(ProductorID);

