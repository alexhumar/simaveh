using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixtureProvincia : IFixtureProvincia
    {
        private readonly IFixturePais fixturePais;

        private Dictionary<long, Dictionary<long, string>> Provincias => new Dictionary<long, Dictionary<long, string>>()
        {
            {
                fixturePais.FindByNombre(NombrePais.Argentina).Value.Key, new Dictionary<long, string>
                {
                    { 1, NombreProvinciaArgentina.BuenosAires },
                    { 2, NombreProvinciaArgentina.Catamarca },
                    { 3, NombreProvinciaArgentina.Chaco },
                    { 4, NombreProvinciaArgentina.Chubut },
                    { 5, NombreProvinciaArgentina.Cordoba },
                    { 6, NombreProvinciaArgentina.Corrientes },
                    { 7, NombreProvinciaArgentina.EntreRios },
                    { 8, NombreProvinciaArgentina.Formosa },
                    { 9, NombreProvinciaArgentina.Jujuy },
                    { 10, NombreProvinciaArgentina.LaPampa },
                    { 11, NombreProvinciaArgentina.LaRioja },
                    { 12, NombreProvinciaArgentina.Mendoza },
                    { 13, NombreProvinciaArgentina.Misiones },
                    { 14, NombreProvinciaArgentina.Neuquen },
                    { 15, NombreProvinciaArgentina.RioNegro },
                    { 16, NombreProvinciaArgentina.Salta },
                    { 17, NombreProvinciaArgentina.SanJuan },
                    { 18, NombreProvinciaArgentina.SanLuis },
                    { 19, NombreProvinciaArgentina.SantaCruz },
                    { 20, NombreProvinciaArgentina.SantaFe },
                    { 21, NombreProvinciaArgentina.SantiagoDelEstero },
                    { 22, NombreProvinciaArgentina.TierraDelFuego },
                    { 23, NombreProvinciaArgentina.Tucuman }
                }
            },
            {
                fixturePais.FindByNombre(NombrePais.Uruguay).Value.Key, new Dictionary<long, string>
                {
                    { 24, NombreProvinciaUruguay.Artigas },
                    { 25, NombreProvinciaUruguay.Canelones },
                    { 26, NombreProvinciaUruguay.CerroLargo },
                    { 27, NombreProvinciaUruguay.Colonia },
                    { 28, NombreProvinciaUruguay.Durazno },
                    { 29, NombreProvinciaUruguay.Flores },
                    { 30, NombreProvinciaUruguay.Florida },
                    { 31, NombreProvinciaUruguay.Lavalleja },
                    { 32, NombreProvinciaUruguay.Maldonado },
                    { 33, NombreProvinciaUruguay.Montevideo },
                    { 34, NombreProvinciaUruguay.Paysandú },
                    { 35, NombreProvinciaUruguay.RioNegro },
                    { 36, NombreProvinciaUruguay.Rivera },
                    { 37, NombreProvinciaUruguay.Rocha },
                    { 38, NombreProvinciaUruguay.Salto },
                    { 39, NombreProvinciaUruguay.SanJose },
                    { 40, NombreProvinciaUruguay.Soriano },
                    { 41, NombreProvinciaUruguay.Tacuarembó },
                    { 42, NombreProvinciaUruguay.TreintaYTres }
                }
            }
        };

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureProvincia()
        {
            fixturePais = new FixturePais();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetProvincias()
        {
            return Provincias;
        }

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            KeyValuePair<long, string>? result = null;

            foreach (var provinciasPais in Provincias)
            {
                KeyValuePair<long, string>? provincia = provinciasPais.Value.FirstOrDefault(v => v.Value == nombre);

                if (provincia != null)
                {
                    result = provincia;
                    break;
                }
            }

            return result;
        }
    }
}
