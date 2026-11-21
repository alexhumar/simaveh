namespace SiMaVeh.Api.Utils.Interfaces
{
    /// <summary>
    /// Informacion de version de la aplicacion (definida en Directory.Build.props).
    /// </summary>
    public interface IInformacionVersion
    {
        /// <summary>
        /// Nombre de la aplicacion.
        /// </summary>
        string Aplicacion { get; }

        /// <summary>
        /// Version semantica (por ejemplo 0.8.0).
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Version con el identificador del build (por ejemplo 0.8.0+hash del commit).
        /// </summary>
        string Build { get; }
    }
}
