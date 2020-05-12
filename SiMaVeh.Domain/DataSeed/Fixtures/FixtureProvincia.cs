using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

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
    }
}
