CREATE TABLE Productor(
	ProductorID     INT NOT NULL,
	Nombre          VARCHAR(50),
	Telefono        VARCHAR(8),
	Correo          VARCHAR(50),
	EstadoID        INT,
    FechaRegistro   DATE DEFAULT CAST(GETDATE() AS DATE) NOT NULL
)

ALTER TABLE Productor
    ADD CONSTRAINT PK_Productor PRIMARY KEY (ProductorID);
ALTER TABLE Productor
	ADD CONSTRAINT FK_Productor_Estado FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID);


-- drop table Productor
