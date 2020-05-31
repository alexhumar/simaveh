using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Interfaz data seeder
    /// </summary>
    public interface IDataSeeder
    {
        /// <summary>
        /// Seed data
        /// </summary>
        /// <param name="builder"></param>
        void SeedData(ModelBuilder builder);
    }
}
