using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    /// <summary>
    /// Aplica todos los configuradores del contexto registrados (descubiertos por escaneo del ensamblado).
    /// Para agregar una configuracion alcanza con crear una clase que implemente IConfiguradorContext.
    /// </summary>
    /// <param name="configuradores"></param>
    public class ConfiguradorSiMaVehContext(IEnumerable<IConfiguradorContext> configuradores) : IConfiguradorSiMaVehContext
    {
        private readonly IEnumerable<IConfiguradorContext> configuradores = configuradores;

        /// <summary>
        /// Configura el modelo aplicando cada uno de los configuradores.
        /// </summary>
        /// <param name="builder"></param>
        public void Configurar(ModelBuilder builder)
        {
            foreach (var configurador in configuradores)
            {
                configurador.Configurar(builder);
            }
        }
    }
}
