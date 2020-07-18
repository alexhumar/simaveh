using System;

namespace SiMaVeh.Api.Utils.Interfaces
{
    /// <summary>
    /// Interfaz de UriParser
    /// </summary>
    internal interface IUriParser
    {
        /// <summary>
        /// GetKeyFromRelatedEntityUri
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        TKey GetKeyFromRelatedEntityUri<TKey>(Uri uri);
    }
}
