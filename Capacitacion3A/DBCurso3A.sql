CREATE DATABASE Curso3A;

USE Curso3A;

CREATE TABLE Persona(
	ci int primary key not null,
	paterno varchar(30),
	materno varchar(30),
	nombres varchar(50) not null,
	celular int not null,
	direccion varchar(100),
	profesion varchar(20),
	fechaNacimiento Date,
	estado bit not null,
	fechaCreacion DATETIME not null,
	fechaModificacion DATETIME not null,
	ultimoUsuario int not null
);
 CREATE TABLE Administrativo(
	ciPersona int not null primary key,
	usuario varchar(50) not null,
	contrasena varchar(256) not null,
	cargo varchar(30) not null,
	nivel tinyint not null,
	FOREIGN KEY (ciPersona) REFERENCES Persona(ci)
 );

 CREATE TABLE Estudiante(
	ciPersona int not null primary key,
	FOREIGN KEY (ciPersona) REFERENCES Persona(ci)
 );

 CREATE TABLE Docente(
	ciPersona int not null primary key,
	usuario varchar(50) not null,
	contrasena varchar(256) not null,
	nivel tinyint not null,
	FOREIGN KEY (ciPersona) REFERENCES Persona(ci)
 );

 CREATE TABLE Curso(
	idCurso int primary key not null IDENTITY(10001,1),
	nombres varchar(200) not null,
	tipo varchar(20) not null,
	cargaHoraria smallint,
	descripcion varchar not null,
	horario varchar(100) not null,
	costo tinyint not null,
	ciDocente int not null,
	estado bit not null,
	fechaCreacion DATETIME not null,
	fechaModificacion DATETIME not null,
	ultimoUsuario int not null,
	FOREIGN KEY (ciDocente) REFERENCES Docente(ciPersona) 
 );

CREATE TABLE Inscripcion(
	idIncripcion int primary key not null IDENTITY(1,1),
	fechaHora DATETIME not null,
	pago smallint,
	ciEstudiante int not null,
	ciAdministrativo int not null,
	idCurso int not null,
	estado bit not null,
	fechaCreacion DATETIME not null,
	fechaModificacion DATETIME not null,
	ultimoUsuario int not null,
	FOREIGN KEY (ciEstudiante) REFERENCES Estudiante(ciPersona),
	FOREIGN KEY (ciAdministrativo) REFERENCES Administrativo(ciPersona),
	FOREIGN KEY (idCurso) REFERENCES Curso(idCurso)
);

-- Lista de Administrativo
SELECT p.ci AS 'C.I.', UPPER(p.paterno) AS 'PATERNO', UPPER(p.materno) AS 'MATERNO', UPPER(p.nombres) AS 'NOMBRES', UPPER(p.celular) AS 'NOMBRES', UPPER(a.cargo) AS 'CARGO'
FROM Administrativo a, Persona p
WHERE A.ciPersona = P.ci
ORDER BY p.fechaCreacion DESC;


-- Mostrar el C.i. Administrativo que tiene el usuario ABC y contrasena 123
SELECT ciPersona 
FROM Administrativo
WHERE usuario LIKE 'ABC' AND contrasena LIKE '123';
-- AGREGAR PERSONA
SET DATEFORMAT 'DMY';
INSERT INTO Persona VALUES
(9961393,'churqui','mamani','alvaro noel',62342619,'Z.Nuevo Amanecer','informatica','16-09-2000',1,GETDATE(),GETDATE(),9961393)

--AGREGAR ADMINISTRATIVO
INSERT INTO Administrativo VALUES
(9961393,'acm160900','123','sistemas',0)	

SELECT * FROM Persona;
SELECT * FROM Administrativo;
