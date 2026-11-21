# AGENTS.md

Este archivo orienta a los agentes de código (Claude Code, Codex, Copilot, Cursor, etc.) al trabajar con el código de este repositorio.

## Descripción general

SiMaVeh es una API REST OData en ASP.NET Core (.NET 8) para la administración y el registro de mantenimientos vehiculares. El código, los identificadores, los comentarios y los mensajes de commit están en español; respetar esa convención.

## Comandos

```bash
dotnet build SiMaVeh.sln
dotnet run --project SiMaVeh.Api            # https://localhost:5001/simaveh, http://localhost:5000/simaveh
dotnet test SiMaVeh.Domain.Test
dotnet test SiMaVeh.Domain.Test --filter "FullyQualifiedName~Pais_AgregarProvincia"   # un solo fixture/test
```

Los tests usan NUnit 4 (estilo de restricciones con `Assert.That`) y solo cubren el proyecto Domain (comportamiento de las relaciones entre entidades).

### Base de datos / migraciones

- Requiere MySQL/MariaDB con una base de datos llamada `simaveh`. El connection string es `ConnectionStrings:DefaultConnection` en [SiMaVeh.Api/appsettings.json](SiMaVeh.Api/appsettings.json). Proveedor: Pomelo, con `ServerVersion.AutoDetect`, por lo que se necesita una BD accesible incluso al arrancar.
- Al iniciar, `Startup.Configure` llama a `Database.Migrate()`, así que las migraciones pendientes (incluidos los datos de seed) se aplican automáticamente.
- Las migraciones están en `SiMaVeh.DataAcces/Migrations`. Según [Documentation/Migrations/Migrations.txt](Documentation/Migrations/Migrations.txt) (Package Manager Console, proyecto predeterminado = SiMaVeh.DataAccess):
  - `Add-Migration <nombre> -context SiMaVeh.DataAccess.Model.SiMaVehContext -o Migrations`
  - Revertir: `Update-Database <migracion_anterior>` y luego `Remove-Migration`
  - Equivalente por CLI: `dotnet ef migrations add <nombre> --project SiMaVeh.DataAcces --startup-project SiMaVeh.Api --context SiMaVehContext -o Migrations`. El proyecto de inicio es necesario porque `SiMaVehContext` recibe su seeder y su configurador por inyección de dependencias.
- Los datos de seed se aplican mediante `HasData`. **Cualquier cambio en los datos de los fixtures requiere una nueva migración.**

Nota: la carpeta del proyecto DataAccess está mal escrita como `SiMaVeh.DataAcces/`, pero el archivo csproj y el namespace son `SiMaVeh.DataAccess`.

## Arquitectura

Tres proyectos: **Api → DataAccess → Domain** (Api también referencia a Domain directamente).

### Inyección de dependencias
Lamar reemplaza al contenedor por defecto (`UseLamar()` en Program.cs). Cada proyecto tiene un `ServiceRegistry` (`ApiRegistry`, `DataAccessRegistry`, `DomainRegistry`) y cada uno usa `Scan(... WithDefaultConventions())`, de modo que `IFoo` → `Foo` se resuelve automáticamente. Los mapeos genéricos o que no siguen la convención deben registrarse explícitamente, por ejemplo `IValidator<T>` en DomainRegistry e `IDomainSeeder<T, TId>` en DataAccessRegistry.

### Domain (`SiMaVeh.Domain`)
- Todas las entidades derivan de `DomainMember<TId>` (mayormente `long`; `Moneda`, `UbicacionPieza` y `EquipamientoAirbags` usan claves `string`). Todas las propiedades son `virtual` porque están habilitados los proxies de lazy loading de EF.
- Las relaciones bidireccionales se mantienen consistentes dentro de las propias entidades mediante `IEntityChanger<...>.Cambiar(...)` e `ICollectionManager<...>.Agregar/Quitar(...)`. Cada lado actualiza al otro; por ejemplo, `Provincia.Cambiar(pais)` quita la provincia del Pais anterior y la agrega al nuevo. Usar estos métodos en lugar de asignar las propiedades de navegación directamente. Los setters de navegación siguen siendo públicos porque OData los necesita.
- Las entidades sobrescriben `Equals`/`GetHashCode`, y las colecciones son `ISet<>`.
- Los validadores de FluentValidation están en `Validators/Validador<Entidad>.cs`, se registran en `DomainRegistry` y se ejecutan mediante `AddFluentValidationAutoValidation` (los errores aparecen en `ModelState`).
- `EntityTypeGetter` mapea cada nombre de tipo a su nombre de entity set de OData (constantes en `Constants/EntitySet`). Lo usan el constructor del modelo EDM y los controllers para comparar valores de `navigationProperty`.
- `DataSeed/` contiene los datos de los fixtures (países, provincias, partidos, localidades, marcas, monedas, etc.). La cadena es: `Constants/<X>` (nombres) → `Fixtures/<X>/FixtureGetters/*FixtureGetter` (construye objetos `DatosEntidad` con IDs fijos, a veces separados por país como `Argentina/` o `Uruguay/`) → `*FixtureGettersProvider` → `Fixture<X>`.

### DataAccess (`SiMaVeh.DataAcces`)
- `SiMaVehContext.OnModelCreating` delega en `IConfiguradorSiMaVehContext` (que agrupa los configuradores de `Model/ConfiguradoresContext`: IDs autogenerados, jerarquías TPH/TPT, propiedades calculadas, relaciones many-to-many) y en `IDataSeeder`.
- Las entidades intermedias de las relaciones many-to-many están en `Model/Relations` (por ejemplo `MarcaCategoriaMarca`).
- `DataSeed/Seeders/<X>Seeder` convierte los fixtures de Domain en objetos anónimos para `HasData`. Para agregar una entidad con seed: agregar el fixture en Domain, luego el seeder, su registro en `DataAccessRegistry`, una llamada en `DataSeeder.SeedData` y, por último, una migración.
- `Repository<TBe, TBeId>` es un repositorio genérico de EF. Los controllers lo instancian directamente; no se inyecta.
- `RelatedEntityAdder/Changer/Remover` y `GenericEntityGetter` dan soporte a las operaciones `$ref` de OData.

### Api (`SiMaVeh.Api`)
- Prefijo de ruta OData: `simaveh` (`UriConstants.PrefijoRutaOData`). El modelo EDM se construye en `Model/SiMaVehODataModelBuilder.cs`. **Cada entidad nueva que se exponga necesita un `EntitySet` allí**, y las clases base abstractas (`Recambio`, `Vehiculo`) se declaran con `.Abstract()` sin entity set. Los comentarios de ese archivo explican el conflicto conocido entre `$expand` y `PageSize`.
- `Controllers/GenericController<TBe, TBeId>` provee Get, Get(key), Post, Put, Patch, Delete y métodos `DeleteRef` sin implementar (501). Los controllers concretos (`<Plural>Controller`, con el nombre del entity set) heredan de él y agregan getters de propiedades de navegación (`GetPais`, `GetPartidos`, ...) y `CreateRef`/`DeleteRef`. En estos, `navigationProperty` se compara con los nombres de `entityTypeGetter` y el trabajo se delega en `IODataRelatedEntityAdder/Changer/Remover`, que parsean la URI del `$ref` (`Utils/UriParser`). [ProvinciasController.cs](SiMaVeh.Api/Controllers/ProvinciasController.cs) es el ejemplo de referencia.
- Las dependencias de los controllers vienen agrupadas en un único `IControllerParameter` (`Controllers/Parametrization`).
- Los errores los maneja un middleware de excepciones propio (`ErrorManagement/Middlewares`, conectado mediante `app.ConfigureCustomExceptionMiddleware()`), y `ErrorsBuilder` da formato a los errores de `ModelState`.
- El logging usa NLog (`nlog.config`).

### Agregar una entidad nueva (checklist de punta a punta)
1. Domain: modelo que derive de `DomainMember<TId>`, más los métodos de relación, el validador, su registro en `DomainRegistry`, una constante en `EntitySet` y una entrada en `EntityTypeGetter`.
2. DataAccess: `DbSet` en `SiMaVehContext`, los cambios necesarios en configuradores o entidades intermedias, y luego una migración.
3. Api: `EntitySet` en `SiMaVehODataModelBuilder` y un controller que herede de `GenericController`.
