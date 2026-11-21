using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces
{
    /// <summary>
    /// Configurador raiz del SiMaVehContext. No hereda de IConfiguradorContext a proposito:
    /// si lo hiciera, el escaneo lo incluiria en su propia lista de configuradores.
    /// </summary>
    public interface IConfiguradorSiMaVehContext
    {
        /// <summary>
        /// Configura el modelo.
        /// </summary>
        /// <param name="builder"></param>
        void Configurar(ModelBuilder builder);
    }
}
