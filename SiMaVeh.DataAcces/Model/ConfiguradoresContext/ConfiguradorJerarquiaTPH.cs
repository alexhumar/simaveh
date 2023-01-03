using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class ConfiguradorJerarquiaTPH : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
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
    }
}
