/* Usuario por defecto */
INSERT UsuariosSistema (Id, Correo, NombreCompleto, Contrasena, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'admin@fake.com','Administrador Sistema','632008c3b59e037f2e761675c88296e146add6240cb9d35ec6366041238417ea833675ce168e34a852457224a827a0ff2e723a95ae682458c6ef4baee2118c71', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

/* Tipos documentos */
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'C�dula de Ciudadan�a', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'C�dula de Extranjer�a', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Pasaporte', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Otro', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

/* Vacantes */
INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS001', 'Ingeniero Industrial ', 'Se requiere Ingeniero Industrial con m�nimo 2 a�os de experiencia en Salud Ocupacional', 'EPM', 2500000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS002', 'Profesor de Qu�mica', 'Se requiere Qu�mico con m�nimo 3 a�os de experiencia en docencia.', 'INSTITUCI�N EDUCATIVA IES', 1900000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS003' , 'Ingeniero de Desarrollo Junior ', 'Se requiere Ingeniero de Sistemas con m�nimo 1 a�o de experiencia en Desarrollo de Software en tecnolog�a JAVA.', 'XRM SERVICES', 2600000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS004' , 'Coordinador de Mercadeo', 'Se necesita Coordinador de Mercadeo con estudios Tecnol�gicos graduado y experiencia m�nima de un a�o.', 'INSERCOL', 1350000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS005' , 'Profesor de Matem�ticas', 'Se requiere Licenciado en Matem�ticas o Ingeniero con m�nimo 2 a�os de experiencia en docencia.', 'SENA', 1750000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS006', 'Mensajero ', 'Se requiere mensajero con moto, con documentos al d�a y buenas relaciones personales.', 'SERVIENTREGA', 950000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS007' , 'Cajero ', 'Se requiere cajero para almac�n de cadena con experiencia m�nima de un a�o, debe disponer de tiempo por cambios de turnos.', 'ALMACENES �XITO', 850000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())