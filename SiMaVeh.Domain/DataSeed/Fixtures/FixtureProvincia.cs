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
                fixturePais.FindByNombre(Pais.Argentina).Value.Key, new Dictionary<long, string>
                {
                    { 1, ProvinciaArgentina.BuenosAires },
                    { 2, ProvinciaArgentina.Catamarca },
                    { 3, ProvinciaArgentina.Chaco },
                    { 4, ProvinciaArgentina.Chubut },
                    { 5, ProvinciaArgentina.Cordoba },
                    { 6, ProvinciaArgentina.Corrientes },
                    { 7, ProvinciaArgentina.EntreRios },
                    { 8, ProvinciaArgentina.Formosa },
                    { 9, ProvinciaArgentina.Jujuy },
                    { 10, ProvinciaArgentina.LaPampa },
                    { 11, ProvinciaArgentina.LaRioja },
                    { 12, ProvinciaArgentina.Mendoza },
                    { 13, ProvinciaArgentina.Misiones },
                    { 14, ProvinciaArgentina.Neuquen },
                    { 15, ProvinciaArgentina.RioNegro },
                    { 16, ProvinciaArgentina.Salta },
                    { 17, ProvinciaArgentina.SanJuan },
                    { 18, ProvinciaArgentina.SanLuis },
                    { 19, ProvinciaArgentina.SantaCruz },
                    { 20, ProvinciaArgentina.SantaFe },
                    { 21, ProvinciaArgentina.SantiagoDelEstero },
                    { 22, ProvinciaArgentina.TierraDelFuego },
                    { 23, ProvinciaArgentina.Tucuman }
                }
            },
            {
                fixturePais.FindByNombre(Pais.Uruguay).Value.Key, new Dictionary<long, string>
                {
                    { 24, ProvinciaUruguay.Artigas },
                    { 25, ProvinciaUruguay.Canelones },
                    { 26, ProvinciaUruguay.CerroLargo },
                    { 27, ProvinciaUruguay.Colonia },
                    { 28, ProvinciaUruguay.Durazno },
                    { 29, ProvinciaUruguay.Flores },
                    { 30, ProvinciaUruguay.Florida },
                    { 31, ProvinciaUruguay.Lavalleja },
                    { 32, ProvinciaUruguay.Maldonado },
                    { 33, ProvinciaUruguay.Montevideo },
                    { 34, ProvinciaUruguay.Paysandú },
                    { 35, ProvinciaUruguay.RioNegro },
                    { 36, ProvinciaUruguay.Rivera },
                    { 37, ProvinciaUruguay.Rocha },
                    { 38, ProvinciaUruguay.Salto },
                    { 39, ProvinciaUruguay.SanJose },
                    { 40, ProvinciaUruguay.Soriano },
                    { 41, ProvinciaUruguay.Tacuarembó },
                    { 42, ProvinciaUruguay.TreintaYTres }
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
