using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models.Relations;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorRelacionesManyToMany : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
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

            builder.Entity<ModeloVehiculoRepuesto>()
                .HasKey(k => new { k.ModeloVehiculoId, k.RepuestoId });

            builder.Entity<ModeloVehiculoPresionNeumatico>()
                .HasKey(k => new { k.ModeloVehiculoId, k.PresionNeumaticoId });

            builder.Entity<ModeloVehiculoFuenteEnergia>()
                .HasKey(k => new { k.ModeloVehiculoId, k.FuenteEnergiaId });
        }
    }
}
