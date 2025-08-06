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
