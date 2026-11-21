using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Base de los seeders: cada seeder solo define sus datos y la base los aplica sobre la entidad correspondiente.
    /// </summary>
    /// <typeparam name="TEntidad">Entidad (o entidad de relacion) a la que pertenecen los seeds</typeparam>
    public abstract class SeederBase<TEntidad> : IAplicadorSeed where TEntidad : class
    {
        /// <summary>
        /// Obtiene los seeds de la entidad.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<object> GetSeeds();

        /// <inheritdoc/>
        public void Aplicar(ModelBuilder builder)
        {
            builder.Entity<TEntidad>().HasData(GetSeeds());
        }
    }
}
