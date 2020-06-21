using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Utils
{
    /// <summary>
    /// EnumUtils
    /// </summary>
    public class EnumUtils
    {
        /// <summary>
        /// GetValues
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
