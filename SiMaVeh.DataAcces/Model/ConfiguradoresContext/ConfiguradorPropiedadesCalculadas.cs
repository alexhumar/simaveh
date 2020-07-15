using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorPropiedadesCalculadas : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
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
    }
}
