using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags.Interfaces
{
    /// <summary>
    /// Interfaz de CalculadorIdEquipamientoAirbags
    /// </summary>
    public interface ICalculadorIdEquipamientoAirbags
    {
        /// <summary>
        /// Calcular
        /// </summary>
        /// <param name="equipamientoAirbags"></param>
        /// <returns></returns>
        string Calcular(IEquipamientoAirbags equipamientoAirbags);
    }
}
