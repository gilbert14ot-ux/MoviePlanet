# MoviePlanet
Proyecto Web API sobre peliculas, creado en C#, ASP.NET Core Web API y consumido por Swagger.


# Tecnologias utilizadas 
- C#
- ASP.NET Core Web API
- .NET
- Swagger
- Git y Github

# Arquitectura del proyecto
El proyecto utiliza una arquitectura de tres capas para organizar las responsabilidades:

- MoviePlanet.API: contiene los controladores y los endpoints de la API.
- MoviePlanet.Application: contiene las interfaces, repositorios y servicios que gestionan la logica de la aplicacion.
- MoviePlanet.Domain: contiene las entidades del sistema.

# Funcionalidades 
La API permite realizar estas operaciones:

| Metodo HTTP | Endpoint | Descripcion |
| --- | --- | --- |
| POST | /api/Peliculas | Crear una pelicula |
| GET | /api/Peliculas | Obtener todas las peliculas |
| GET | /api/Peliculas/{id} | Obtener una pelicula por su ID |
| PUT | /api/Peliculas/{id} | Actualizar una pelicula |
| DELETE | /api/Peliculas/{id} | Eliminar una pelicula | 

# Documentacion de la API
El proyecto utiliza Swagger para visualizar y probar los endpoints disponibles.
Una vez ejecutada la aplicacion, se accede a:
https://localhost:{puerto}/swagger
Remplazando {puerto} por el puerto indicado a la hora de iniciar la aplicacion.
