using NUnit.Framework;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Provincia_CambiarPais
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
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisSeteado()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            Assert.IsNull(buenosAires.Pais);
            Assert.That(argentina.Provincias, !Contains.Item(buenosAires));

            buenosAires.Cambiar(argentina);

            Assert.AreSame(buenosAires.Pais, argentina, "El pais de Buenos Aires no fue seteado a Argentina");
            Assert.That(argentina.Provincias, Contains.Item(buenosAires));
        }

        [Test]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisModificado()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            buenosAires.Cambiar(uruguay);

            Assert.AreEqual(buenosAires.Pais, uruguay);
            Assert.That(uruguay.Provincias, Contains.Item(buenosAires));
            Assert.That(argentina.Provincias, !Contains.Item(buenosAires));

            buenosAires.Cambiar(argentina);

            Assert.AreEqual(buenosAires.Pais, argentina);
            Assert.That(uruguay.Provincias, !Contains.Item(buenosAires));
            Assert.That(argentina.Provincias, Contains.Item(buenosAires));
        }

        [Test]
        public void CambiarPais_ANull_RetornaProvinciaSinPais()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            buenosAires.Cambiar(argentina);

            Assert.AreEqual(buenosAires.Pais, argentina);
            Assert.That(argentina.Provincias, Contains.Item(buenosAires));

            buenosAires.Cambiar(null);

            Assert.IsNull(buenosAires.Pais);
            Assert.That(argentina.Provincias, !Contains.Item(buenosAires));
            Assert.IsEmpty(argentina.Provincias);
        }
    }
}