using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class ConfiguradorSiMaVehContext(IRecuperadorConfiguradoresContext recuperadorConfiguradoresContext) : IConfiguradorSiMaVehContext
    {
        private readonly IRecuperadorConfiguradoresContext recuperadorConfiguradoresContext = recuperadorConfiguradoresContext;

        public void Configurar(ModelBuilder builder)
        {
            foreach (var configurador in recuperadorConfiguradoresContext.GetConfiguradoresContext())
            {
                configurador.Configurar(builder);
            }
        }
    }
}
