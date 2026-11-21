using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Test.Models
{
    public class Provincia_CambiarPais
    {
        private readonly Pais argentina;
        private readonly Pais uruguay;

        public Provincia_CambiarPais()
        {
            argentina = new Pais { Id = 1, Nombre = DataSeed.Constants.Paises.Pais.Argentina };
            uruguay = new Pais { Id = 2, Nombre = DataSeed.Constants.Paises.Pais.Uruguay };
        }

        [Fact]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisSeteado()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };

            Assert.Null(buenosAires.Pais);
            Assert.DoesNotContain(buenosAires, argentina.Provincias);

            buenosAires.Cambiar(argentina);

            Assert.Equal(argentina, buenosAires.Pais);
            Assert.Contains(buenosAires, argentina.Provincias);
        }

        [Fact]
        public void CambiarPais_AArgenina_RetornaProvinciaConPaisModificado()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            buenosAires.Cambiar(uruguay);

            Assert.Equal(uruguay, buenosAires.Pais);
            Assert.Contains(buenosAires, uruguay.Provincias);
            Assert.DoesNotContain(buenosAires, argentina.Provincias);

            buenosAires.Cambiar(argentina);

            Assert.Equal(argentina, buenosAires.Pais);
            Assert.DoesNotContain(buenosAires, uruguay.Provincias);
            Assert.Contains(buenosAires, argentina.Provincias);
        }

        [Fact]
        public void CambiarPais_ANull_RetornaProvinciaSinPais()
        {
            var buenosAires = new Provincia { Id = 1, Nombre = ProvinciaArgentina.BuenosAires };
            buenosAires.Cambiar(argentina);

            Assert.Equal(argentina, buenosAires.Pais);
            Assert.Contains(buenosAires, argentina.Provincias);

            buenosAires.Cambiar(null);

            Assert.Null(buenosAires.Pais);
            Assert.DoesNotContain(buenosAires, argentina.Provincias);
            Assert.Empty(argentina.Provincias);
        }
    }
}
