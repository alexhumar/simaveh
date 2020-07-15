using Microsoft.EntityFrameworkCore;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces
{
    internal interface IConfiguradorContext
    {
        void Configurar(ModelBuilder builder);
    }
}
