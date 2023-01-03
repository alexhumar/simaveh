using System.Collections.Generic;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces
{
    public interface IRecuperadorConfiguradoresContext
    {
        IEnumerable<IConfiguradorContext> GetConfiguradoresContext();
    }
}
