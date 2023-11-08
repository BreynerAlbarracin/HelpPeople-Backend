# Prueba Tecnica para Help People
Author: Breyner Albarracin Lozada

## NetCore
### `dotnet build`
El proyecto fue construido usando ASP.NET CORE 6 como base del framework acompañado de Entity Framework y MediatR para implementar CQRS, por defecto el proyecto corre sobre el protocolo https usando el puerto 7048.

### `CORS`
Por defecto solo se integro al proyecto como permiso de cors http://localhost:3000 que es la ruta por defecto que sua el proyecto frontend que acompaña la prueba

### `Update-database`
Es necesario ejecutar el comando Update-database desde visual studio con el fin de crear y correr las migrations de la aplicación, asegurese tambien de tener permisos sobre el servidor donde se aloja la base de datos, por defecto se configuro en el appsettings.json una base de datos apuntando a localhost.

### `SQL`
Es altamente recomendable ejecutar el archivo **Script-Data-Seed.sql** en la base de datos luego de ser creada para cargar la data semilla inicial que incluye los tipos de documento y las vacantes acorde a lo informado por la prueba.

### `Usuario`
El usuario de pruebas se incluye en el .sql, sin embargo, la clave se almacena como un hash SHA512 codificado como Hex por lo que a continuación dejo las credenciales necesarias para el login en el aplicativo:
 ``````
Correo: admin@fake.com
Contraseña: admin1234
``````
