using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.DataSeed
{
    public interface IDataSeeder
    {
        void SeedData(ModelBuilder builder);
    }
}
