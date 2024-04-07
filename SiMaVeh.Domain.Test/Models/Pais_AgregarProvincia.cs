using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Pais_AgregarProvincia
    {
        private Pais argentina;
        private Pais uruguay;

        [SetUp]
        public void Setup()
        {
            argentina = new Pais { Id = 1, Nombre = DataSeed.Constants.Paises.Pais.Argentina };
            uruguay = new Pais { Id = 2, Nombre = DataSeed.Constants.Paises.Pais.Uruguay };
        }

        [Test]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisConProvinciaAgregada()
        {
            Assert.That(argentina.Provincias, Is.Empty);

            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            argentina.Agregar(buenosAires);

            Assert.That(argentina.Provincias, Contains.Item(buenosAires));
            Assert.That(buenosAires.Pais, Is.EqualTo(argentina));
        }

        [Test]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisCambiadoConProvinciaAgregada()
        {
            Assert.That(argentina.Provincias, Is.Empty);
            Assert.That(uruguay.Provincias, Is.Empty);

            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            uruguay.Agregar(buenosAires);

            Assert.That(uruguay.Provincias, Contains.Item(buenosAires));
            Assert.That(buenosAires.Pais, Is.EqualTo(uruguay));
            Assert.That(argentina.Provincias, Is.Empty);

            argentina.Agregar(buenosAires);

            Assert.That(argentina.Provincias, Contains.Item(buenosAires));
            Assert.That(buenosAires.Pais, Is.EqualTo(argentina));
            Assert.That(uruguay.Provincias, Is.Empty);
        }
    }
}