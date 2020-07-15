using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    internal class ConfiguradorSiMaVehContext : IConfiguradorContext
    {
        private readonly IRecuperadorConfiguradoresContext recuperadorConfiguradoresContext;

        public ConfiguradorSiMaVehContext(IRecuperadorConfiguradoresContext recuperadorConfiguradoresContext)
        {
            this.recuperadorConfiguradoresContext = recuperadorConfiguradoresContext;
        }

        public void Configurar(ModelBuilder builder)
        {
            foreach (var configurador in recuperadorConfiguradoresContext.GetConfiguradoresContext())
            {
                configurador.Configurar(builder);
            }
        }
    }
}
