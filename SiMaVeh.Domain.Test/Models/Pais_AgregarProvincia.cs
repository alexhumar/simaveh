using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Pais_AgregarProvincia
    {
        private Pais _argentina;

        [SetUp]
        public void Setup()
        {
            _argentina = new Pais { Id = 1, Nombre = NombrePais.Argentina };
        }

        [Test]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisConProvinciaAgregada()
        {
            Assert.IsEmpty(_argentina.Provincias);

            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };

            _argentina.Agregar(_buenosAires);

            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
            Assert.AreSame(_buenosAires.Pais, _argentina);
        }
    }
}