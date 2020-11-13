using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorJerarquiaTPT : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            builder.Entity<Automovil>().ToTable("Automoviles");
            builder.Entity<Pieza>().ToTable("Piezas");
            builder.Entity<Fluido>().ToTable("Fluidos");
            builder.Entity<Aceite>().ToTable("Aceites");
            builder.Entity<Reparador>().ToTable("Reparadores");
            builder.Entity<Usuario>().ToTable("Usuarios");
            builder.Entity<Kit>().ToTable("Kits");
            builder.Entity<Repuesto>().ToTable("Repuestos");
        }
    }
}
