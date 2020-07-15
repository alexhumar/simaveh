using System;
using System.Text.RegularExpressions;

namespace SiMaVeh.Api.Utils
{
    /// <summary>
    /// UriParser
    /// </summary>
    public static class UriParser
    {
        /// <summary>
        /// GetKeyFromUri
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="entityName"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static TKey GetKeyFromUri<TKey>(string entityName, Uri uri)
        {
            //Este patron me termina quedando por ejemplo @"(Provincias\()(\w+)(\))"
            //Si yo tengo la uri /simaveh/Provincias(1) me quedan 4 grupos despues de procesar el string:
            //0 - Provincias(1). 1 - Provincias(. 2 - 1. 3 - ).
            //Me alcanza con tomar el grupo 2!
            var pattern = string.Format(@"({0}\()(\w+)(\))", entityName);
            var match = Regex.Match(uri.AbsoluteUri, pattern);
            var key = "0";

            if (match.Success)
            {
                key = match.Groups[2].Value;
            }

            try
            {
                return (TKey)Convert.ChangeType(key, typeof(TKey));
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}