using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Pais_AgregarProvincia
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
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisConProvinciaAgregada()
        {
            Assert.IsEmpty(_argentina.Provincias);

            var _buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            _argentina.Agregar(_buenosAires);

            Assert.That(_argentina.Provincias, Contains.Item(_buenosAires));
            Assert.AreSame(_buenosAires.Pais, _argentina);
        }

        [Test]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisCambiadoConProvinciaAgregada()
        {
            Assert.IsEmpty(_argentina.Provincias);
            Assert.IsEmpty(_uruguay.Provincias);

            var _buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

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