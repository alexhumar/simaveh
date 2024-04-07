using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class RecuperadorConfiguradoresContext : IRecuperadorConfiguradoresContext
    {
        public IEnumerable<IConfiguradorContext> GetConfiguradoresContext()
        {
            return
            [
                //new ConfiguradorJerarquiaTPH(),
                new ConfiguradorPropiedadesCalculadas(),
                new ConfiguradorJerarquiaTPT(),
                new ConfiguradorIDsAutogenerados(),
                new ConfiguradorRelacionesManyToMany()
            ];
        }
    }
}
