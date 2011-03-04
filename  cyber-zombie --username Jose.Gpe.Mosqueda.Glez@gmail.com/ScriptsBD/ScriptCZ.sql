CREATE DATABASE cz;
USE cz;
CREATE TABLE Tipos(Id_Tipo INT NOT NULL AUTO_INCREMENT,Nombre_Tipo VARCHAR(40),Descripcion_Tipo VARCHAR(40),Precio_Unitario DECIMAL(6,2),Unidad_Tipo VARCHAR(20),PRIMARY KEY(Id_Tipo))ENGINE=INNODB;
CREATE TABLE Equipos(Id_Equipo INT NOT NULL AUTO_INCREMENT,Id_Tipo INT NOT NULL,IP_Equipo VARCHAR(15),Nombre_Equipo VARCHAR(20),Caracteristicas_Equipo VARCHAR(300),PRIMARY KEY(Id_Equipo),FOREIGN KEY(Id_Tipo) REFERENCES Tipos(Id_Tipo) ON UPDATE CASCADE)ENGINE=INNODB;
CREATE TABLE Sesiones(Id_Sesion INT NOT NULL AUTO_INCREMENT,Id_Equipo INT NOT NULL,Fecha_Sesion DATE,Hora_Inicio TIME,Hora_Fin TIME,Total_Sesion DECIMAL(6,2),Total_SesionImp DECIMAL(6,2),Total DECIMAL(6,2),PRIMARY KEY(Id_Sesion),FOREIGN KEY(Id_Equipo) REFERENCES Equipos(Id_Equipo) ON UPDATE CASCADE)ENGINE=INNODB;
CREATE TABLE SesionImp(Id_Equipo INT NOT NULL,Id_Sesion INT NOT NULL,No_Impresiones INT,Precio_Unitario DECIMAL(6,2),Total_Precio DECIMAL(6,2),FOREIGN KEY(Id_Equipo) REFERENCES Equipos(Id_Equipo) ON UPDATE CASCADE,FOREIGN KEY(Id_Sesion) REFERENCES Sesiones(Id_Sesion) ON UPDATE CASCADE)ENGINE=INNODB;