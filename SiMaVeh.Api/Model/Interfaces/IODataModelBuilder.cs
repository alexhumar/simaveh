using Microsoft.OData.Edm;

namespace SiMaVeh.Api.Model.Interfaces
{
    public interface IODataModelBuilder
    {
        /// <summary>
        /// Obtiene el modelo Edm
        /// </summary>
        /// <returns></returns>
        IEdmModel GetEdmModel();
    }
}
