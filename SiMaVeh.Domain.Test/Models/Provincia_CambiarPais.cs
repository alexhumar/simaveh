using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Provincia_CambiarPais
    {
        private Domain.Models.Pais _argentina;
        private Domain.Models.Pais _uruguay;

        [SetUp]
        public void Setup()
        {
            _argentina = new Domain.Models.Pais { Id = 1, Nombre = DataSeed.Constants.Paises.Pais.Argentina };
            _uruguay = new Domain.Models.Pais { Id = 2, Nombre = DataSeed.Constants.Paises.Pais.Uruguay };
        }

        [Test]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisSeteado()
        {
            var _buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            Assert.IsNull(_buenosAires.Pais);
            Assert.That(_argentina.Provincias, !Contains.Item(_buenosAires));

            _buenosAires.Cambiar(_argentina);

            Assert.AreSame(_buenosAires.Pais, _argentina, "El pais de Buenos Aires no fue seteado a Argentina");
            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
        }

        [Test]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisModificado()
        {
            var _buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            _buenosAires.Cambiar(_uruguay);

            Assert.AreEqual(_buenosAires.Pais, _uruguay);
            Assert.That(_uruguay.Provincias, Contains.Item(_buenosAires));
            Assert.That(_argentina.Provincias, !Contains.Item(_buenosAires));

            _buenosAires.Cambiar(_argentina);

            Assert.AreEqual(_buenosAires.Pais, _argentina);
            Assert.That(_uruguay.Provincias, !Contains.Item(_buenosAires));
            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
        }

        [Test]
        public void CambiarPais_ANull_RetornaProvinciaSinPais()
        {
            var _buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            _buenosAires.Cambiar(_argentina);

            Assert.AreEqual(_buenosAires.Pais, _argentina);
            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));

            _buenosAires.Cambiar(null);

            Assert.IsNull(_buenosAires.Pais);
            Assert.That(_argentina.Provincias, !Contains.Item(_buenosAires));
            Assert.IsEmpty(_argentina.Provincias);
        }
    }
}