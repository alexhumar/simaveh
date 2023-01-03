using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model
{
    public class SiMaVehContext : DbContext
    {
        private readonly IConfiguradorSiMaVehContext configuradorSiMaVehContext;
        private readonly IDataSeeder dataSeeder;

        public SiMaVehContext(DbContextOptions<SiMaVehContext> options,
            IDataSeeder dataSeeder,
            IConfiguradorSiMaVehContext configuradorSiMaVehContext) : base(options)
        {
            this.configuradorSiMaVehContext = configuradorSiMaVehContext;
            this.dataSeeder = dataSeeder;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            configuradorSiMaVehContext.Configurar(builder);
            dataSeeder.SeedData(builder);
        }

        /// <summary>
        /// Aceites
        /// </summary>
        public DbSet<Aceite> Aceites { get; set; }

        /// <summary>
        /// Automoviles
        /// </summary>
        public DbSet<Automovil> Automoviles { get; set; }

        /// <summary>
        /// Categor�as Marca
        /// </summary>
        public DbSet<CategoriaMarca> CategoriasMarca { get; set; }

        /// <summary>
        /// Direcciones
        /// </summary>
        public DbSet<Direccion> Direcciones { get; set; }

        /// <summary>
        /// Entidades Reparadoras
        /// </summary>
        public DbSet<EntidadReparadora> EntidadesReparadoras { get; set; }

        /// <summary>
        /// Equipamientos Airbags
        /// </summary>
        public DbSet<EquipamientoAirbags> EquipamientosAirbags { get; set; }

        /// <summary>
        /// Fluidos
        /// </summary>
        public DbSet<Fluido> Fluidos { get; set; }

        /// <summary>
        /// Fuentes Energia
        /// </summary>
        public DbSet<FuenteEnergia> FuentesEnergia { get; set; }

        /// <summary>
        /// Grupos Modelo
        /// </summary>
        public DbSet<GrupoModelo> GruposModelo { get; set; }

        /// <summary>
        /// Kits
        /// </summary>
        public DbSet<Kit> Kits { get; set; }

        /// <summary>
        /// Localidades
        /// </summary>
        public DbSet<Localidad> Localidades { get; set; }

        /// <summary>
        /// Mantenimientos
        /// </summary>
        public DbSet<Mantenimiento> Mantenimientos { get; set; }

        /// <summary>
        /// Marcas
        /// </summary>
        public DbSet<Marca> Marcas { get; set; }

        /// <summary>
        /// ModelosVehiculo
        /// </summary>
        public DbSet<ModeloVehiculo> ModelosVehiculo { get; set; }

        /// <summary>
        /// Monedas
        /// </summary>
        public DbSet<Moneda> Monedas { get; set; }

        /// <summary>
        /// Neumaticos
        /// </summary>
        public DbSet<Neumatico> Neumaticos { get; set; }

        /// <summary>
        /// Paises
        /// </summary>
        public DbSet<Pais> Paises { get; set; }

        /// <summary>
        /// Partidos
        /// </summary>
        public DbSet<Partido> Partidos { get; set; }

        /// <summary>
        /// Periodicidades Mantenimiento
        /// </summary>
        public DbSet<PeriodicidadMantenimiento> PeriodicidadesMantenimiento { get; set; }

        /// <summary>
        /// Personas
        /// </summary>
        public DbSet<Persona> Personas { get; set; }

        /// <summary>
        /// Piezas
        /// </summary>
        public DbSet<Pieza> Piezas { get; set; }

        /// <summary>
        /// Presiones Neumaticos
        /// </summary>
        public DbSet<PresionNeumatico> PresionesNeumaticos { get; set; }

        /// <summary>
        /// Provincias
        /// </summary>
        public DbSet<Provincia> Provincias { get; set; }

        /// <summary>
        /// Recambios
        /// </summary>
        public DbSet<Recambio> Recambios { get; set; }

        /// <summary>
        /// Reparadores
        /// </summary>
        public DbSet<Reparador> Reparadores { get; set; }

        /// <summary>
        /// Repuestos
        /// </summary>
        public DbSet<Repuesto> Repuestos { get; set; }

        /// <summary>
        /// Servicios Reparadores
        /// </summary>
        public DbSet<ServicioReparador> ServiciosReparadores { get; set; }

        /// <summary>
        /// Targets Mantenimiento
        /// </summary>
        public DbSet<TargetMantenimiento> TargetsMantenimiento { get; set; }

        /// <summary>
        /// Telefonos
        /// </summary>
        public DbSet<Telefono> Telefonos { get; set; }

        /// <summary>
        /// Tipos Cambio
        /// </summary>
        public DbSet<TipoCambio> TiposCambio { get; set; }

        /// <summary>
        /// Tipos Documento
        /// </summary>
        public DbSet<TipoDocumento> TiposDocumento { get; set; }

        /// <summary>
        /// Tipos Entidad Reparadora
        /// </summary>
        public DbSet<TipoEntidadReparadora> TiposEntidadReparadora { get; set; }

        /// <summary>
        /// Tipos Fuente Energia
        /// </summary>
        public DbSet<TipoFuenteEnergia> TiposFuenteEnergia { get; set; }

        /// <summary>
        /// Tipos Telefono
        /// </summary>
        public DbSet<TipoTelefono> TiposTelefono { get; set; }

        /// <summary>
        /// Ubicaciones Pieza
        /// </summary>
        public DbSet<UbicacionPieza> UbicacionesPieza { get; set; }

        /// <summary>
        /// Usuarios
        /// </summary>
        public DbSet<Usuario> Usuarios { get; set; }

        /// <summary>
        /// Vehiculos
        /// </summary>
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
