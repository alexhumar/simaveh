using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.FixtureGetters
{
    /// <summary>
    /// Fixture getter de fuente energia
    /// </summary>
    internal class FuenteEnergiaFixtureGetter : IFuenteEnergiaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly IMarcaFixtureGetter marcaFixtureGetter;
        private readonly ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter;
        private readonly ICollection<DatosFuenteEnergia> fuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="marcaFixtureGetter"></param>
        /// <param name="tipoFuenteEnergiaFixtureGetter"></param>
        public FuenteEnergiaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IMarcaFixtureGetter marcaFixtureGetter,
            ITipoFuenteEnergiaFixtureGetter tipoFuenteEnergiaFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.marcaFixtureGetter = marcaFixtureGetter;
            this.tipoFuenteEnergiaFixtureGetter = tipoFuenteEnergiaFixtureGetter;
            fuentesEnergia = new List<DatosFuenteEnergia>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosFuenteEnergia> Get()
        {
            return fuentesEnergia;
        }

        private void Initialize()
        {
            var marcaAxion = marcaFixtureGetter.FindByNombre(Constants.Marcas.Marca.Axion);
            var marcaNoEspecificada = marcaFixtureGetter.FindByNombre(Constants.Marcas.Marca.NoEspecificada);
            var marcaPetrobras = marcaFixtureGetter.FindByNombre(Constants.Marcas.Marca.Petrobras);
            var marcaShell = marcaFixtureGetter.FindByNombre(Constants.Marcas.Marca.Shell);
            var marcaYPF = marcaFixtureGetter.FindByNombre(Constants.Marcas.Marca.YPF);

            var tipoFuenteEnergiaBio = tipoFuenteEnergiaFixtureGetter.FindByNombre(Constants.TiposFuenteEnergia.TipoFuenteEnergia.Bio);
            var tipoFuenteEnergiaElectricidad = tipoFuenteEnergiaFixtureGetter.FindByNombre(Constants.TiposFuenteEnergia.TipoFuenteEnergia.Electricidad);
            var tipoFuenteEnergiaGasNatural = tipoFuenteEnergiaFixtureGetter.FindByNombre(Constants.TiposFuenteEnergia.TipoFuenteEnergia.GasNatural);
            var tipoFuenteEnergiaPetroleo = tipoFuenteEnergiaFixtureGetter.FindByNombre(Constants.TiposFuenteEnergia.TipoFuenteEnergia.Petroleo);

            fuentesEnergia.Add(datosEntidadBuilder.Build(1, Constants.FuentesEnergia.FuenteEnergia.Biodiesel, marcaPetrobras, tipoFuenteEnergiaBio));
            fuentesEnergia.Add(datosEntidadBuilder.Build(2, Constants.FuentesEnergia.FuenteEnergia.CargaElectricaConvencional, marcaNoEspecificada, tipoFuenteEnergiaElectricidad));
            fuentesEnergia.Add(datosEntidadBuilder.Build(3, Constants.FuentesEnergia.FuenteEnergia.CargaElectricaRapida, marcaNoEspecificada, tipoFuenteEnergiaElectricidad));
            fuentesEnergia.Add(datosEntidadBuilder.Build(4, Constants.FuentesEnergia.FuenteEnergia.CargaElectricaSemiRapida, marcaNoEspecificada, tipoFuenteEnergiaElectricidad));
            fuentesEnergia.Add(datosEntidadBuilder.Build(5, Constants.FuentesEnergia.FuenteEnergia.Diesel500, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(6, Constants.FuentesEnergia.FuenteEnergia.GNC, marcaAxion, tipoFuenteEnergiaGasNatural));
            fuentesEnergia.Add(datosEntidadBuilder.Build(7, Constants.FuentesEnergia.FuenteEnergia.GNC, marcaPetrobras, tipoFuenteEnergiaGasNatural));
            fuentesEnergia.Add(datosEntidadBuilder.Build(8, Constants.FuentesEnergia.FuenteEnergia.GNC, marcaShell, tipoFuenteEnergiaGasNatural));
            fuentesEnergia.Add(datosEntidadBuilder.Build(9, Constants.FuentesEnergia.FuenteEnergia.GNC, marcaYPF, tipoFuenteEnergiaGasNatural));
            fuentesEnergia.Add(datosEntidadBuilder.Build(10, Constants.FuentesEnergia.FuenteEnergia.GridDiesel, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(11, Constants.FuentesEnergia.FuenteEnergia.Infinia, marcaYPF, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(12, Constants.FuentesEnergia.FuenteEnergia.InfiniaDiesel, marcaYPF, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(13, Constants.FuentesEnergia.FuenteEnergia.NaftaGrid, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(14, Constants.FuentesEnergia.FuenteEnergia.NaftaPodium, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(15, Constants.FuentesEnergia.FuenteEnergia.NaftaPremium, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(16, Constants.FuentesEnergia.FuenteEnergia.NaftaRegular, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(17, Constants.FuentesEnergia.FuenteEnergia.NaftaSuper, marcaAxion, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(18, Constants.FuentesEnergia.FuenteEnergia.NaftaSuper, marcaShell, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(19, Constants.FuentesEnergia.FuenteEnergia.NaftaSuper, marcaYPF, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(20, Constants.FuentesEnergia.FuenteEnergia.PodiumDiesel, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(21, Constants.FuentesEnergia.FuenteEnergia.Quantium, marcaAxion, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(22, Constants.FuentesEnergia.FuenteEnergia.QuantiumDiesel, marcaAxion, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(23, Constants.FuentesEnergia.FuenteEnergia.S10Diesel, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(24, Constants.FuentesEnergia.FuenteEnergia.S500Diesel, marcaPetrobras, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(25, Constants.FuentesEnergia.FuenteEnergia.UltraDiesel, marcaYPF, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(26, Constants.FuentesEnergia.FuenteEnergia.VPowerDiesel, marcaShell, tipoFuenteEnergiaPetroleo));
            fuentesEnergia.Add(datosEntidadBuilder.Build(27, Constants.FuentesEnergia.FuenteEnergia.VPowerNafta, marcaShell, tipoFuenteEnergiaPetroleo));
        }
    }
}
