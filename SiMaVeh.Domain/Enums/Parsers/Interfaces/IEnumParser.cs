using System;

namespace SiMaVeh.Domain.Enums.Parsers.Interfaces
{
    /// <summary>
    /// Interfaz de Enum Parser
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEnumParser<T> where T : Enum
    {
        /// <summary>
        /// ToString 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string ToString(T value);
    }
}
