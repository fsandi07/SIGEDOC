
---------------------------- Creación del Esquema ----------------------------
CREATE SCHEMA DOTNET;	-- El esquema se crea solamente una vez y debe estar siempre como primera instrucción

------------------ Sentencias para Borrado de Tablas ------------------

DROP TABLE DOTNET.UserInfo;
DROP TABLE DOTNET.UserRole;

---------------------------- Creación de Tablas ----------------------------

-- Tabla de Roles de Usuario
CREATE TABLE DOTNET.UserRole (
	roleId INT NOT NULL PRIMARY KEY IDENTITY,
	displayName VARCHAR(15) NOT NULL,
	roleDescription VARCHAR(50)
)
;
-- Tabla de Usuarios
CREATE TABLE DOTNET.UserInfo (
	userId INT NOT NULL PRIMARY KEY IDENTITY,
	firstName VARCHAR(20) NOT NULL,
	lastName1 VARCHAR(20) NOT NULL,
	lastName2 VARCHAR(20) NOT NULL,
	userName VARCHAR(10) NOT NULL,
	password VARCHAR(15) NOT NULL,
	email VARCHAR(50) NOT NULL,
	role INT NOT NULL DEFAULT 1,
	FOREIGN KEY (userId) REFERENCES DOTNET.UserRole(roleId)
)
;

------------------ Creación de Índices ------------------

CREATE INDEX IDX_USER_ROLE_DISPLAY_NAME ON DOTNET.UserRole (displayName);
CREATE INDEX IDX_USER_INFO_USERNAME ON DOTNET.UserInfo (userName);
CREATE INDEX IDX_USER_INFO_EMAIL ON DOTNET.UserInfo (email);


---------------------------- Inserciones de Datos ----------------------------

-- Inserciones de Roles de Usuario
SET IDENTITY_INSERT DOTNET.UserRole ON;-- para yo especificar el ID del identity 
INSERT INTO DOTNET.UserRole (roleId, displayName, roleDescription) VALUES 
(1, 'MAIN', 'Maintainer'),
(2, 'ADMIN', 'Administrador'),
(3, 'OPER', 'Operador')
;
SET IDENTITY_INSERT DOTNET.UserRole OFF;

-- Inserciones Usuarios
INSERT INTO DOTNET.UserInfo (firstName, lastName1, lastName2, userName, password, email, role) VALUES 
('Fabio', 'Sandí', 'Sánchez', 'fsandi', 'fsandi07', 'fsandi07@gmail.com', 1),
('Melvin', 'Fallas', 'Cascante', 'mfallas', 'mfallas04', 'melfallas@yahoo.com', 2)
;

