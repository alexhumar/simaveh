using Microsoft.OData.UriParser;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.DataAccess.Model.Interfaces;
using System;
using System.Linq;

namespace SiMaVeh.Api.Utils
{
    /// <summary>
    /// UriParser
    /// </summary>
    internal class ODataUriParser : IUriParser
    {
        private readonly IModelBuilder modelBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="modelBuilder"></param>
        public ODataUriParser(IModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        /// <summary>
        /// GetKeyFromRelatedEntityUri
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        public TKey GetKeyFromRelatedEntityUri<TKey>(Uri uri)
        {
            try
            {
                var oDataUriParser = new Microsoft.OData.UriParser.ODataUriParser(modelBuilder.GetEdmModel(),
                    new Uri($"{uri.Scheme}://{uri.Host}:{uri.Port}/{UriConstants.PrefijoRutaOData}/"), uri);
                var oDataKeySegment = (KeySegment)oDataUriParser.ParsePath().LastSegment;

                if (oDataKeySegment != null && oDataKeySegment.Keys.Any())
                {
                    var clave = oDataKeySegment.Keys.FirstOrDefault().Value;

                    return (TKey)Convert.ChangeType(clave, typeof(TKey));
                }

                return default;
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}