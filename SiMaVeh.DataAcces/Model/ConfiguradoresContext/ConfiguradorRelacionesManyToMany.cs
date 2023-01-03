using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class ConfiguradorRelacionesManyToMany : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //Si bien EF reconoce este tipo de relaciones automaticamente, esta configuracion explicita
            //facilita la implementacion de DataSeed en las relaciones, y permite mas control sobre las tablas generadas.

            builder.Entity<Kit>()
                .HasMany(k => k.Repuestos)
                .WithMany(r => r.Kits)
                .UsingEntity<KitRepuesto>(
                j => j
                    .HasOne(e => e.Repuesto)
                    .WithMany()
                    .HasForeignKey(pt => pt.RepuestoId),
                j => j
                    .HasOne(e => e.Kit)
                    .WithMany()
                    .HasForeignKey(pt => pt.KitId));

            builder.Entity<Marca>()
                .HasMany(m => m.Categorias)
                .WithMany(c => c.Marcas)
                .UsingEntity<MarcaCategoriaMarca>(
                j => j
                    .HasOne(e => e.CategoriaMarca)
                    .WithMany()
                    .HasForeignKey(pt => pt.CategoriaMarcaId),
                j => j
                    .HasOne(e => e.Marca)
                    .WithMany()
                    .HasForeignKey(pt => pt.MarcaId));

            builder.Entity<ModeloVehiculo>()
                .HasMany(m => m.AceitesRecomendados)
                .WithMany(a => a.RecomendacionesModeloVehiculo)
                .UsingEntity<ModeloVehiculoAceite>(
                j => j
                    .HasOne(e => e.Aceite)
                    .WithMany()
                    .HasForeignKey(pt => pt.AceiteId),
                j => j
                    .HasOne(e => e.ModeloVehiculo)
                    .WithMany()
                    .HasForeignKey(pt => pt.ModeloVehiculoId));

            builder.Entity<ModeloVehiculo>()
                .HasMany(m => m.FuentesEnergiaRecomendadas)
                .WithMany(f => f.RecomendacionesModeloVehiculo)
                .UsingEntity<ModeloVehiculoFuenteEnergia>(
                j => j
                    .HasOne(e => e.FuenteEnergia)
                    .WithMany()
                    .HasForeignKey(pt => pt.FuenteEnergiaId),
                j => j
                    .HasOne(e => e.ModeloVehiculo)
                    .WithMany()
                    .HasForeignKey(pt => pt.ModeloVehiculoId));

            builder.Entity<ModeloVehiculo>()
                .HasMany(m => m.PresionesNeumaticoRecomendadas)
                .WithMany(p => p.RecomendacionesModeloVehiculo)
                .UsingEntity<ModeloVehiculoPresionNeumatico>(
                j => j
                    .HasOne(e => e.PresionNeumatico)
                    .WithMany()
                    .HasForeignKey(pt => pt.PresionNeumaticoId),
                j => j
                    .HasOne(e => e.ModeloVehiculo)
                    .WithMany()
                    .HasForeignKey(pt => pt.ModeloVehiculoId));

            builder.Entity<ModeloVehiculo>()
                .HasMany(m => m.RepuestosRecomendados)
                .WithMany(r => r.RecomendacionesModeloVehiculo)
                .UsingEntity<ModeloVehiculoRepuesto>(
                j => j
                    .HasOne(e => e.Repuesto)
                    .WithMany()
                    .HasForeignKey(pt => pt.RepuestoId),
                j => j
                    .HasOne(e => e.ModeloVehiculo)
                    .WithMany()
                    .HasForeignKey(pt => pt.ModeloVehiculoId));

            builder.Entity<EntidadReparadora>()
                .HasMany(e => e.Reparadores)
                .WithMany(r => r.EntidadesReparadoras)
                .UsingEntity<ReparadorEntidadReparadora>(
                j => j
                    .HasOne(e => e.Reparador)
                    .WithMany()
                    .HasForeignKey(pt => pt.ReparadorId),
                j => j
                    .HasOne(e => e.EntidadReparadora)
                    .WithMany()
                    .HasForeignKey(pt => pt.EntidadReparadoraId));
        }
    }
}
