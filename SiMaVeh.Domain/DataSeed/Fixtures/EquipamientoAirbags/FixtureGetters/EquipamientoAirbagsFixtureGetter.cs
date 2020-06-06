using SiMaVeh.Domain.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Utils;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.FixtureGetters
{
    /// <summary>
    /// Fixture getter de equipamiento airbags
    /// </summary>
    internal class EquipamientoAirbagsFixtureGetter : IEquipamientoAirbagsFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEquipamientoAirbags> equipamientosAirbags;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public EquipamientoAirbagsFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            equipamientosAirbags = new List<DatosEquipamientoAirbags>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEquipamientoAirbags> Get()
        {
            return equipamientosAirbags;
        }

        private void Initialize()
        {
            foreach (var conductor in Booleans.ValoresPosibles)
            {
                foreach (var acompanante in Booleans.ValoresPosibles)
                {
                    foreach (var delanteroIzquierdo in EnumUtils.GetValues<TipoAirbagLateral>())
                    {
                        foreach (var delanteroDerecho in EnumUtils.GetValues<TipoAirbagLateral>())
                        {
                            foreach (var traseroIzquierdo in EnumUtils.GetValues<TipoAirbagLateral>())
                            {
                                foreach (var traseroDerecho in EnumUtils.GetValues<TipoAirbagLateral>())
                                {
                                    equipamientosAirbags.Add(datosEntidadBuilder.Build(conductor, acompanante, delanteroIzquierdo, delanteroDerecho, traseroIzquierdo, traseroDerecho));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
