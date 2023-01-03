using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces
{
    public interface IConfiguradorContext
    {
        void Configurar(ModelBuilder builder);
    }
}
