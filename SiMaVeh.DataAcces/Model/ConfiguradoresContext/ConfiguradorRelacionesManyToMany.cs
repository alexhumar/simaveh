using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorRelacionesManyToMany : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //Esto es necesario ya que EF Core al dia de hoy (14/01/2019)
            //no soporta relaciones Many-To-Many con colecciones directamente.
            //Hay que modelarlas con un objeto relacion.

            //NO ME ESTA TOMANDO ESTA RELACION MANY TO MANY... NI LAS QUE NO DICEN: CREADA POR EFCORE.
            builder.Entity<Marca>().HasMany(m => m.Categorias).WithMany(c => c.Marcas);
            builder.Entity<CategoriaMarca>().HasMany(c => c.Marcas).WithMany(m => m.Categorias);

            builder.Entity<Reparador>().HasMany(r => r.EntidadesReparadoras).WithMany(e => e.Reparadores);
            builder.Entity<EntidadReparadora>().HasMany(e => e.Reparadores).WithMany(r => r.EntidadesReparadoras);

            builder.Entity<Kit>().HasMany(k => k.Repuestos).WithMany(r => r.Kits);
            builder.Entity<Repuesto>().HasMany(r => r.Kits).WithMany(k => k.Repuestos);

            //builder.Entity<ReparadorEntidadReparadora>()
            //    .HasKey(k => new { k.ReparadorId, k.EntidadReparadoraId });

            //builder.Entity<KitRepuesto>()
            //    .HasKey(k => new { k.KitId, k.RepuestoId });

            //builder.Entity<MarcaCategoriaMarca>()
            //    .HasKey(k => new { k.CategoriaMarcaId, k.MarcaId });

            //CREADA POR EFCORE
            //builder.Entity<ModeloVehiculoRepuesto>()
            //    .HasKey(k => new { k.ModeloVehiculoId, k.RepuestoId });

            //CREADA POR EFCORE
            //builder.Entity<ModeloVehiculoPresionNeumatico>()
            //    .HasKey(k => new { k.ModeloVehiculoId, k.PresionNeumaticoId });

            //CREADA POR EFCORE
            //builder.Entity<ModeloVehiculoFuenteEnergia>()
            //    .HasKey(k => new { k.ModeloVehiculoId, k.FuenteEnergiaId });

            //CREADA POR EFCORE
            //builder.Entity<ModeloVehiculoAceite>()
            //    .HasKey(k => new { k.ModeloVehiculoId, k.AceiteId });
        }
    }
}
