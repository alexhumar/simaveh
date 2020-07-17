using Microsoft.OData.UriParser;
using SiMaVeh.Api.Constants;
using SiMaVeh.DataAccess.Model;
using System;
using System.Linq;

namespace SiMaVeh.Api.Utils
{
    /// <summary>
    /// UriParser
    /// </summary>
    public class UriParser
    {
        /// <summary>
        /// GetKeyFromRelatedEntityUri
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static TKey GetKeyFromRelatedEntityUri<TKey>(Uri uri)
        {
            try
            {
                var oDataUriParser = new ODataUriParser(SiMaVehModelBuilder.GetEdmModel(),
                    new Uri($"{uri.Scheme}://{uri.Host}:{uri.Port}/{UriConstants.PrefijoRutaOData}/", UriKind.RelativeOrAbsolute),
                    new Uri(uri.AbsoluteUri, UriKind.RelativeOrAbsolute));
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