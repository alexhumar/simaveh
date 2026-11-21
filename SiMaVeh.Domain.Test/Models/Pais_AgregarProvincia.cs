using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Pais_AgregarProvincia
    {
        private readonly Pais argentina;
        private readonly Pais uruguay;

        //xUnit crea una instancia nueva de la clase por cada test: el constructor reemplaza al [SetUp] de NUnit.
        public Pais_AgregarProvincia()
        {
            argentina = new Pais { Id = 1, Nombre = DataSeed.Constants.Paises.Pais.Argentina };
            uruguay = new Pais { Id = 2, Nombre = DataSeed.Constants.Paises.Pais.Uruguay };
        }

        [Fact]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisConProvinciaAgregada()
        {
            Assert.Empty(argentina.Provincias);

            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            argentina.Agregar(buenosAires);

            Assert.Contains(buenosAires, argentina.Provincias);
            Assert.Equal(argentina, buenosAires.Pais);
        }

        [Fact]
        public void AgregarProvincia_BsAsAArgentina_RetornaPaisCambiadoConProvinciaAgregada()
        {
            Assert.Empty(argentina.Provincias);
            Assert.Empty(uruguay.Provincias);

            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            uruguay.Agregar(buenosAires);

            Assert.Contains(buenosAires, uruguay.Provincias);
            Assert.Equal(uruguay, buenosAires.Pais);
            Assert.Empty(argentina.Provincias);

            argentina.Agregar(buenosAires);

            Assert.Contains(buenosAires, argentina.Provincias);
            Assert.Equal(argentina, buenosAires.Pais);
            Assert.Empty(uruguay.Provincias);
        }
    }
}
