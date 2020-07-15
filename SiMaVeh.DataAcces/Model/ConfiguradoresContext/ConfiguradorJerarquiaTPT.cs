using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorJerarquiaTPT : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //Se debe invocar al método ToTable de las clases derivadas en pos de
            //activar la modalidad (TPT - Table Per Type). 
            //Esto al dia de hoy (04/05/2020) no es soportado por EF Core, pero lo será
            //en versiones posteriores.
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
