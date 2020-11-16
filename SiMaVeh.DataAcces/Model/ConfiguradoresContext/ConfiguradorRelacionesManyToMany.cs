using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorRelacionesManyToMany : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //Si bien EF reconoce este tipo de relaciones automaticamente, esta configuracion explicita
            //facilita la implementacion de DataSeed en las relaciones.
            builder.Entity<Marca>()
                .HasMany(m => m.Categorias)
                .WithMany(c => c.Marcas)
                .UsingEntity<MarcaCategoriaMarca>(
                j => j
                    .HasOne(pt => pt.CategoriaMarca)
                    .WithMany()
                    .HasForeignKey(pt => pt.CategoriaMarcaId),
                j => j
                    .HasOne(pt => pt.Marca)
                    .WithMany()
                    .HasForeignKey(pt => pt.MarcaId));
        }
    }
}
