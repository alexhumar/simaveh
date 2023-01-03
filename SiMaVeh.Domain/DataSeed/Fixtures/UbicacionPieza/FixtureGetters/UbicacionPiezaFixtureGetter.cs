using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.FixtureGetters
{
    /// <summary>
    /// Fixture getter de ubicacion pieza
    /// </summary>
    public class UbicacionPiezaFixtureGetter : IUbicacionPiezaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosUbicacionPieza> ubicacionesPieza;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public UbicacionPiezaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            ubicacionesPieza = new List<DatosUbicacionPieza>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosUbicacionPieza> Get()
        {
            return ubicacionesPieza;
        }

        private void Initialize()
        {
            foreach (var valorIzquierda in Booleans.ValoresPosibles)
            {
                foreach (var valorSuperior in Booleans.ValoresPosibles)
                {
                    ubicacionesPieza.Add(datosEntidadBuilder.Build(valorIzquierda, valorSuperior));
                }
            }
        }
    }
}
