/* Usuario por defecto */
INSERT UsuariosSistema (Id, Correo, NombreCompleto, Contrasena, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'admin@fake.com','Administrador Sistema','632008c3b59e037f2e761675c88296e146add6240cb9d35ec6366041238417ea833675ce168e34a852457224a827a0ff2e723a95ae682458c6ef4baee2118c71', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

/* Tipos documentos */
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Cédula de Ciudadanía', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Cédula de Extranjería', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Pasaporte', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())
INSERT INTO TipoDocumento (Id, Tipo, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime) Values(NEWID(),'Otro', 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

/* Vacantes */
INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS001', 'Ingeniero Industrial ', 'Se requiere Ingeniero Industrial con mínimo 2 años de experiencia en Salud Ocupacional', 'EPM', 2500000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS002', 'Profesor de Química', 'Se requiere Químico con mínimo 3 años de experiencia en docencia.', 'INSTITUCIÓN EDUCATIVA IES', 1900000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS003' , 'Ingeniero de Desarrollo Junior ', 'Se requiere Ingeniero de Sistemas con mínimo 1 año de experiencia en Desarrollo de Software en tecnología JAVA.', 'XRM SERVICES', 2600000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS004' , 'Coordinador de Mercadeo', 'Se necesita Coordinador de Mercadeo con estudios Tecnológicos graduado y experiencia mínima de un año.', 'INSERCOL', 1350000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS005' , 'Profesor de Matemáticas', 'Se requiere Licenciado en Matemáticas o Ingeniero con mínimo 2 años de experiencia en docencia.', 'SENA', 1750000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS006', 'Mensajero ', 'Se requiere mensajero con moto, con documentos al día y buenas relaciones personales.', 'SERVIENTREGA', 950000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())

INSERT INTO Vacante (Id, Codigo, Cargo, Descripcion, Empresa, Salario, Disponibilidad, Activo, CreateBy, CreateTime, UpdateBy, UpdateTime)
VALUES (NEWID(), 'RS007' , 'Cajero ', 'Se requiere cajero para almacén de cadena con experiencia mínima de un año, debe disponer de tiempo por cambios de turnos.', 'ALMACENES ÉXITO', 850000, 1, 1, 'SISTEMA', GETDATE(),'SISTEMA', GETDATE())