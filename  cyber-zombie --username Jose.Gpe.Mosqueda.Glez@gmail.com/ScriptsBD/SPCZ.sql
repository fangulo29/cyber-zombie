USE cz;

CREATE PROCEDURE Ins_Tipo(Nombre VARCHAR(40),Descripcion VARCHAR(40),Precio DECIMAL(6,2),Unidad VARCHAR(20))
INSERT INTO Tipos VALUES(DEFAULT,Nombre,Descripcion,Precio,Unidad);

CREATE PROCEDURE Act_Tipo(Id INT,Nombre VARCHAR(40),Descripcion VARCHAR(40),Precio DECIMAL(6,2),Unidad VARCHAR(20))
UPDATE Tipos SET Nombre_Tipo=Nombre,Descripcion_Tipo=Descripcion,Precio_Unitario=Precio,Unidad_Tipo=Unidad WHERE Id_Tipo = Id;

CREATE PROCEDURE Eli_Tipo(Id INT)
DELETE FROM Tipos WHERE Id_Tipo=Id;

CREATE PROCEDURE Buscar_Tipos()
SELECT * FROM Tipos;

CREATE PROCEDURE Buscar_Tipo(Id INT)
SELECT * FROM Tipos WHERE Id_Tipo=Id;

CREATE PROCEDURE Ins_Equipo(Tipo INT,IP VARCHAR(15),Nombre VARCHAR(20),Caracteristicas VARCHAR(300))
INSERT INTO Equipos VALUES(DEFAULT,IP,Nombre,Caracteristicas);

CREATE PROCEDURE Act_Equipo(Id INT,Tipo INT,IP VARCHAR(15),Nombre VARCHAR(20),Caracteristicas VARCHAR(300))
UPDATE Equipos SET Id_Tipo=Tipo,IP_Equipo=IP,Nombre_Equipo=Nombre,Caracteristicas_Equipo=Caracteristicas WHERE Id_Equipo=Id;

CREATE PROCEDURE Eli_Equipo(Id INT)
DELETE FROM Equipos WHERE Id_Equipo=Id;

CREATE PROCEDURE Buscar_Equipos()
SELECT * FROM Equipos;

CREATE PROCEDURE Buscar_Equipo(Id INT)
SELECT * FROM Equipos WHERE Id_Equipo=Id;

CREATE PROCEDURE Ins_Sesion(Equipo INT,Fecha DATE,Inicio TIME,Fin TIME,Tot_Ses DECIMAL(6,2),Tot_SesImp DECIMAL(6,2),Total DECIMAL(6,2))
INSERT INTO Sesiones VALUES(DEFAULT,Fecha,Inicio,Fin,Tot_Ses,Tot_SesImp,Total);

CREATE PROCEDURE Act_Sesion(Id INT,Equipo INT,Fecha DATE,Inicio TIME,Fin TIME,Tot_Ses DECIMAL(6,2),Tot_SesImp DECIMAL(6,2),Tot DECIMAL(6,2))
UPDATE Sesiones SET Id_Equipo=Equipo,Fecha_Sesion=Fecha,Hora_Inicio=Inicio,Hora_Fin=Fin,Total_Sesion=Tot_Ses,Total_SesionImp=Tot_SesImp,Total=Tot WHERE Id_Sesion=Id;

CREATE PROCEDURE Eli_Sesion(Id INT)
DELETE FROM Sesiones WHERE Id_Sesion=Id;

CREATE PROCEDURE Buscar_Sesiones()
SELECT * FROM Sesiones;

CREATE PROCEDURE Buscar_Sesion(Id INT)
SELECT * FROM Sesiones WHERE Id_Sesion=Id;

CREATE PROCEDURE Ins_SesionImp(Equipo INT,Sesion INT,Impresiones INT,Precio DECIMAL(6,2),Total DECIMAL(6,2))
INSERT INTO SesionesImp VALUES(Equipo,Sesion,Impresiones,Precio,Total);

CREATE PROCEDURE Eli_SesionImp(Sesion INT)
DELETE FROM SesionesImp WHERE Id_Sesion=Sesion;

CREATE PROCEDURE Buscar_SesionesImp(Sesion INT)
SELECT * FROM SesionesImp WHERE Id_Sesion=Sesion;