using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Provincia_CambiarPais
    {
        private Pais _argentina;
        private Pais _uruguay;

        [SetUp]
        public void Setup()
        {
            _argentina = new Pais { Id = 1, Nombre = NombrePais.Argentina };
            _uruguay = new Pais { Id = 2, Nombre = NombrePais.Uruguay };
        }

        [Test]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisSeteado()
        {
            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };

            Assert.IsNull(_buenosAires.Pais);
            Assert.That(_argentina.Provincias, !Contains.Item(_buenosAires));

            _buenosAires.Cambiar(_argentina);

            Assert.AreSame(_buenosAires.Pais, _argentina, "El pais de Buenos Aires no fue seteado a Argentina");
            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
        }

        [Test]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisModificado()
        {
            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };
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
            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };
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