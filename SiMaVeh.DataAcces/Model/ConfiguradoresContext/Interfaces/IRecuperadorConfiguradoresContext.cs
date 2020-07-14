using System.Collections.Generic;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces
{
    internal interface IRecuperadorConfiguradoresContext
    {
        IEnumerable<IConfiguradorContext> GetConfiguradoresContext();
    }
}
