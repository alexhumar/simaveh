using SiMaVeh.Api.Utils.Interfaces;
using System.Reflection;

namespace SiMaVeh.Api.Utils
{
    /// <summary>
    /// Lee la version del ensamblado de la Api. La version se define una sola vez en Directory.Build.props;
    /// el SDK la copia a los atributos del ensamblado y agrega a InformationalVersion el hash del commit.
    /// </summary>
    public class InformacionVersion : IInformacionVersion
    {
        private const string NombreAplicacion = "SiMaVeh";

        /// <summary>
        /// Constructor
        /// </summary>
        public InformacionVersion()
        {
            var ensamblado = typeof(InformacionVersion).Assembly;
            var versionInformativa = ensamblado.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            Build = versionInformativa ?? ensamblado.GetName().Version?.ToString(3) ?? string.Empty;
            //La parte posterior al '+' es metadata del build (hash del commit); la version semantica es lo anterior.
            Version = Build.Split('+')[0];
        }

        /// <inheritdoc/>
        public string Aplicacion => NombreAplicacion;

        /// <inheritdoc/>
        public string Version { get; }

        /// <inheritdoc/>
        public string Build { get; }

        /// <summary>
        /// Representacion para logs (por ejemplo "SiMaVeh 0.8.0+hash").
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Aplicacion} {Build}";
    }
}
