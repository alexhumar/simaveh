using Microsoft.OData.UriParser;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.Api.Utils.Interfaces;
using System;
using System.Linq;

namespace SiMaVeh.Api.Utils
{
    /// <summary>
    /// UriParser
    /// </summary>
    public class UriParser : IUriParser
    {
        private readonly IODataModelBuilder odataModelBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="odataModelBuilder"></param>
        public UriParser(IODataModelBuilder odataModelBuilder)
        {
            this.odataModelBuilder = odataModelBuilder;
        }

        /// <summary>
        /// GetKeyFromRelatedEntityUri
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        public TKey GetKeyFromRelatedEntityUri<TKey>(Uri uri)
        {
            var oDataUriParser = new ODataUriParser(odataModelBuilder.GetEdmModel(),
                new Uri($"{uri.Scheme}://{uri.Host}:{uri.Port}/{UriConstants.PrefijoRutaOData}/"), uri);
            var oDataKeySegment = (KeySegment)oDataUriParser.ParsePath().LastSegment;

            if (oDataKeySegment != null && oDataKeySegment.Keys.Any())
            {
                var clave = oDataKeySegment.Keys.FirstOrDefault().Value;

                return (TKey)Convert.ChangeType(clave, typeof(TKey));
            }

            return default;
        }
    }
}