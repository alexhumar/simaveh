using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Pais_AgregarProvincia
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
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisConProvinciaAgregada()
        {
            Assert.IsEmpty(_argentina.Provincias);

            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };

            _argentina.Agregar(_buenosAires);

            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
            Assert.AreSame(_buenosAires.Pais, _argentina);
        }

        [Test]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisCambiadoConProvinciaAgregada()
        {
            Assert.IsEmpty(_argentina.Provincias);
            Assert.IsEmpty(_uruguay.Provincias);

            var _buenosAires = new Provincia { Id = 1, Nombre = NombreProvincia.BuenosAires };

            _uruguay.Agregar(_buenosAires);

            Assert.That(_uruguay.Provincias, Contains.Item(_buenosAires));
            Assert.AreSame(_buenosAires.Pais, _uruguay);
            Assert.IsEmpty(_argentina.Provincias);

            _argentina.Agregar(_buenosAires);

            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
            Assert.AreSame(_buenosAires.Pais, _argentina);
            Assert.IsEmpty(_uruguay.Provincias);
        }
    }
}