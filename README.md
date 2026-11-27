# Api REST con tecnologia OData para la administracion y registro de mantenimientos vehiculares.

## Comenzar:
- Clonar el repositorio.
- Instalar un motor mysql compatible (por ejemplo MariaDB).
- Configurar un usuario especifico de sql para no utilizar el usuario root en caso que se considere pertinente.
- Crear en el motor una base de datos denominada: simaveh.
- En caso de ser necesario ajustar el connectionstring del appsettings.json.
- Al ejecutarse la solucion se generaran las tablas del modelo de datos y se inicializaran las tablas "fixture" con los datos necesarios para comenzar a utilizar la API.

## Contrato de la API:
Con la API en ejecucion (por defecto en https://localhost:5001):
- `/openapi.json` y `/openapi.yaml`: contrato OpenAPI 3.0 con todas las operaciones que la API atiende. Sirve para generar clientes y tipos para un frontend (por ejemplo con openapi-typescript, orval o NSwag).
- `/swagger`: Swagger UI para explorar y probar las operaciones desde el navegador.
- `/simaveh/$metadata`: contrato OData (CSDL) con entidades, propiedades, claves y relaciones, para clientes OData nativos.
