using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Relations;

namespace SiMaVeh.DataAccess.Model
{
    public class SiMaVehContext : DbContext
    {
        protected IDataSeeder DataSeeder { get; set; }

        public SiMaVehContext(DbContextOptions<SiMaVehContext> options) : base(options)
        {
            //Esto no pude hacerlo funcionar con inyeccion de dependencias.
            DataSeeder = new DataSeeder();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //TODO: todas estas acciones estaria bueno llevarlas a clases aparte. De hecho,
            //la configuracion de la jerarquia a tablas denota una suerte de strategy.

            #region TODO: estrategia de persistencia de jerarquias en varias tablas (TPT)

            //Se debe invocar al método ToTable de las clases derivadas en pos de
            //activar la modalidad (TPT - Table Per Type). 
            //Esto al dia de hoy (04/05/2020) no es soportado por EF Core, pero lo será
            //en versiones posteriores.

            //builder.Entity<Automovil>().ToTable("Automoviles");
            //builder.Entity<Pieza>().ToTable("Piezas");
            //builder.Entity<Fluido>().ToTable("Fluidos");
            //builder.Entity<Aceite>().ToTable("Aceites");
            //builder.Entity<Reparador>().ToTable("Reparadores");
            //builder.Entity<Usuario>().ToTable("Usuarios");
            //builder.Entity<Kit>().ToTable("Kits");
            //builder.Entity<Repuesto>().ToTable("Repuestos");

            #endregion

            ConfigurarJerarquiasTPH(builder);
            ConfigurarPropiedadesCalculadas(builder);
            ConfigurarIDsAutogenerados(builder);
            ConfigurarRelacionesManyToMany(builder);
            SembrarDatos(builder);
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
        /// Categorías Marca
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

        #region private

        private void ConfigurarJerarquiasTPH(ModelBuilder builder)
        {
            builder.Entity<Persona>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Reparador>("R")
                .HasValue<Usuario>("U");

            builder.Entity<Recambio>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Kit>("K")
                .HasValue<Repuesto>("R");

            builder.Entity<TargetMantenimiento>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Aceite>("A")
                .HasValue<Fluido>("F")
                .HasValue<Pieza>("P");

            builder.Entity<Vehiculo>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Automovil>("A");
        }

        private void ConfigurarPropiedadesCalculadas(ModelBuilder builder)
        {
            //Los Ignore son para que el LazyLoading ignore las propiedades calculadas y
            //no tire excepcion al notar que no tienen setter.
            builder.Entity<CategoriaMarca>().Ignore(c => c.Marcas);
            builder.Entity<EntidadReparadora>().Ignore(e => e.Reparadores);
            builder.Entity<Kit>().Ignore(k => k.Repuestos);
            builder.Entity<Marca>().Ignore(m => m.Categorias);
            builder.Entity<Repuesto>().Ignore(r => r.Kits);
            builder.Entity<Reparador>().Ignore(r => r.EntidadesReparadoras);
        }

        private void ConfigurarIDsAutogenerados(ModelBuilder builder)
        {
            //El Id de estas entidades se genera en base al valor de sus propiedades.
            builder.Entity<EquipamientoAirbags>()
                .Property(e => e.Id).ValueGeneratedNever();
            builder.Entity<UbicacionPieza>()
                .Property(u => u.Id).ValueGeneratedNever();
        }

        private void ConfigurarRelacionesManyToMany(ModelBuilder builder)
        {
            //Esto es necesario ya que EF Core al dia de hoy (14/01/2019)
            //no soporta relaciones Many-To-Many con colecciones directamente.
            //Hay que modelarlas con un objeto relacion.
            builder.Entity<ReparadorEntidadReparadora>()
                .HasKey(k => new { k.ReparadorId, k.EntidadReparadoraId });

            builder.Entity<KitRepuesto>()
                .HasKey(k => new { k.KitId, k.RepuestoId });

            builder.Entity<MarcaCategoriaMarca>()
                .HasKey(k => new { k.CategoriaMarcaId, k.MarcaId });
        }

        private void SembrarDatos(ModelBuilder builder)
        {
            DataSeeder.SeedData(builder);
        }

        #endregion
    }
}
