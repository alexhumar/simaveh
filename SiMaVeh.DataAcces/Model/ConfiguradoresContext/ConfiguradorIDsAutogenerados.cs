using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorIDsAutogenerados : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //El Id de estas entidades se genera en base al valor de sus propiedades.
            builder.Entity<EquipamientoAirbags>()
                .Property(e => e.Id).ValueGeneratedNever();
            builder.Entity<UbicacionPieza>()
                .Property(u => u.Id).ValueGeneratedNever();
        }
    }
}
