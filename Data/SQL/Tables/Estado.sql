-- This file contains the SQL code for creating the Estado table in a database.
-- The table includes an ID, a name, and observations.
CREATE TABLE Estado(
	EstadoID    INT NOT NULL,
	Nombre      VARCHAR(25),
	Observaciones VARCHAR(150)
)

ALTER TABLE Estado
    ADD CONSTRAINT PK_Estado PRIMARY KEY (EstadoID)
