using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces
{
    /// <summary>
    /// Aplica los datos de seed de una entidad sobre el modelo de EF.
    /// Las implementaciones se descubren automaticamente por escaneo del ensamblado.
    /// </summary>
    public interface IAplicadorSeed
    {
        /// <summary>
        /// Registra los datos de seed en el ModelBuilder (HasData).
        /// </summary>
        /// <param name="builder"></param>
        void Aplicar(ModelBuilder builder);
    }
}
