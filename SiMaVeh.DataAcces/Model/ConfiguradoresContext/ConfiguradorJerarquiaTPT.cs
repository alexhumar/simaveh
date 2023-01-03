using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class ConfiguradorJerarquiaTPT : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            builder.Entity<Vehiculo>().ToTable("Vehiculos");
            builder.Entity<Automovil>().ToTable("Automoviles");
            builder.Entity<TargetMantenimiento>().ToTable("TargetsMantenimiento");
            builder.Entity<Pieza>().ToTable("Piezas");
            builder.Entity<Fluido>().ToTable("Fluidos");
            builder.Entity<Aceite>().ToTable("Aceites");
            builder.Entity<Persona>().ToTable("Personas");
            builder.Entity<Reparador>().ToTable("Reparadores");
            builder.Entity<Usuario>().ToTable("Usuarios");
            builder.Entity<Recambio>().ToTable("Recambios");
            builder.Entity<Kit>().ToTable("Kits");
            builder.Entity<Repuesto>().ToTable("Repuestos");
        }
    }
}
