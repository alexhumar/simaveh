using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.Interfaces;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Test.Model
{
    /// <summary>
    /// Operaciones sobre relaciones ($ref): OperadorEntidadesRelacionadas y los servicios
    /// RelatedEntityAdder/Changer/Remover que delegan en el, contra EF InMemory.
    /// </summary>
    public sealed class EntidadesRelacionadasTests : IDisposable
    {
        private readonly BaseDatosEnMemoria baseDatos = new();

        public EntidadesRelacionadasTests()
        {
            var ctx = baseDatos.Contexto;
            var argentina = new Pais { Id = 1, Nombre = "Argentina" };
            var uruguay = new Pais { Id = 2, Nombre = "Uruguay" };
            var buenosAires = new Provincia { Id = 1, Nombre = "Buenos Aires" }.Cambiar(argentina);
            var cordoba = new Provincia { Id = 2, Nombre = "Cordoba" }.Cambiar(argentina);
            new Partido { Id = 1, Nombre = "Quilmes" }.Cambiar(buenosAires);
            new Partido { Id = 2, Nombre = "Rio Cuarto" }.Cambiar(cordoba);
            ctx.AddRange(argentina, uruguay);
            ctx.AddRange(new Moneda { Id = "USD", Nombre = "Dolar" }, new Moneda { Id = "ARS", Nombre = "Peso" });
            ctx.Add(new TipoCambio { Id = 1, CoeficienteCambio = 1000, Fecha = new DateTime(2024, 1, 1) });
            ctx.SaveChanges();
        }

        public void Dispose() => baseDatos.Dispose();

        private T Leer<T>(Func<SiMaVehContext, T> consulta) =>
            baseDatos.EnNuevoScope(sp => consulta(sp.GetRequiredService<SiMaVehContext>()));

        #region Igualdad con proxies de EF

        [Fact]
        public void Igualdad_EntidadCargadaPorEF_EsIgualAUnaInstanciaConElMismoId()
        {
            var cargada = Leer(ctx => ctx.Paises.Find(1L));

            //Con lazy loading, EF devuelve un proxy (subclase generada en Castle.Proxies).
            Assert.Equal("Castle.Proxies", cargada.GetType().Namespace);
            Assert.Equal(new Pais { Id = 1 }, cargada);
            Assert.Equal(cargada, new Pais { Id = 1 });
            Assert.Equal(new Pais { Id = 1 }.GetHashCode(), cargada.GetHashCode());
            Assert.NotEqual(new Pais { Id = 2 }, cargada);
        }

        [Fact]
        public void Igualdad_ColeccionCargadaPorEF_ContieneInstanciasConElMismoId()
        {
            var partidos = Leer(ctx => ctx.Provincias.Find(1L).Partidos.ToList());

            Assert.Contains(new Partido { Id = 1 }, partidos);
            Assert.DoesNotContain(new Partido { Id = 2 }, partidos);
        }

        #endregion

        #region GenericEntityGetter

        [Fact]
        public async Task GenericEntityGetter_DevuelveLaEntidadONull()
        {
            var getter = baseDatos.Get<IGenericEntityGetter>();

            Assert.Equal("Argentina", (await getter.TryGetEntity<Pais, long>(1)).Nombre);
            Assert.Equal("Dolar", (await getter.TryGetEntity<Moneda, string>("USD")).Nombre);
            Assert.Null(await getter.TryGetEntity<Pais, long>(99));
        }

        #endregion

        #region OperadorEntidadesRelacionadas

        [Fact]
        public async Task Operador_AmbasEntidadesExisten_AplicaLaAccionYPersiste()
        {
            var operador = baseDatos.Get<IOperadorEntidadesRelacionadas>();
            Provincia destinoRecibido = null;
            Pais relacionadaRecibida = null;

            var resultado = await operador.AplicarAsync<Provincia, long, Pais, long>(1, 2, (provincia, pais) =>
            {
                destinoRecibido = provincia;
                relacionadaRecibida = pais;
                provincia.Cambiar(pais);
            });

            Assert.True(resultado);
            Assert.Equal(1, destinoRecibido.Id);
            Assert.Equal(2, relacionadaRecibida.Id);
            Assert.Equal(2, Leer(ctx => ctx.Provincias.Find(1L).Pais.Id));
        }

        [Fact]
        public async Task Operador_DestinoInexistente_DevuelveFalseSinAplicarLaAccion()
        {
            var operador = baseDatos.Get<IOperadorEntidadesRelacionadas>();
            var invocada = false;

            var resultado = await operador.AplicarAsync<Provincia, long, Pais, long>(99, 1, (_, _) => invocada = true);

            Assert.False(resultado);
            Assert.False(invocada);
        }

        [Fact]
        public async Task Operador_RelacionadaInexistente_DevuelveFalseSinAplicarLaAccion()
        {
            var operador = baseDatos.Get<IOperadorEntidadesRelacionadas>();
            var invocada = false;

            var resultado = await operador.AplicarAsync<Provincia, long, Pais, long>(1, 99, (_, _) => invocada = true);

            Assert.False(resultado);
            Assert.False(invocada);
            Assert.Equal(1, Leer(ctx => ctx.Provincias.Find(1L).Pais.Id));
        }

        [Fact]
        public async Task Operador_SoloDestino_AplicaLaAccionYPersiste()
        {
            var operador = baseDatos.Get<IOperadorEntidadesRelacionadas>();

            var resultado = await operador.AplicarAsync<TipoCambio, long>(1, tipoCambio => tipoCambio.CoeficienteCambio = 1500);

            Assert.True(resultado);
            Assert.Equal(1500, Leer(ctx => ctx.TiposCambio.Find(1L).CoeficienteCambio));
        }

        [Fact]
        public async Task Operador_SoloDestinoInexistente_DevuelveFalse()
        {
            var operador = baseDatos.Get<IOperadorEntidadesRelacionadas>();
            var invocada = false;

            Assert.False(await operador.AplicarAsync<TipoCambio, long>(99, _ => invocada = true));
            Assert.False(invocada);
        }

        #endregion

        #region RelatedEntityAdder / Remover / Changer

        [Fact]
        public async Task Adder_AgregaElPartidoALaProvinciaYLoQuitaDeLaAnterior()
        {
            var adder = baseDatos.Get<IRelatedEntityAdder>();

            var resultado = await adder.TryAddRelatedEntityAsync<Provincia, long, Partido, long>(1, 2);

            Assert.True(resultado);
            Assert.Equal(1, Leer(ctx => ctx.Partidos.Find(2L).Provincia.Id));
            Assert.Equal([1L, 2L], Leer(ctx => ctx.Provincias.Find(1L).Partidos.Select(p => p.Id).OrderBy(i => i).ToList()));
            Assert.Empty(Leer(ctx => ctx.Provincias.Find(2L).Partidos.ToList()));
        }

        [Fact]
        public async Task Adder_EntidadInexistente_DevuelveFalse()
        {
            var adder = baseDatos.Get<IRelatedEntityAdder>();

            Assert.False(await adder.TryAddRelatedEntityAsync<Provincia, long, Partido, long>(99, 1));
            Assert.False(await adder.TryAddRelatedEntityAsync<Provincia, long, Partido, long>(1, 99));
        }

        [Fact]
        public async Task Remover_QuitaElPartidoDeLaColeccion()
        {
            var remover = baseDatos.Get<IRelatedEntityRemover>();

            var resultado = await remover.TryRemoveRelatedEntityAsync<Provincia, long, Partido, long>(1, 1);

            Assert.True(resultado);
            Assert.Empty(Leer(ctx => ctx.Provincias.Find(1L).Partidos.ToList()));
            Assert.Null(Leer(ctx => ctx.Partidos.Find(1L).Provincia));
        }

        [Fact]
        public async Task Remover_QuitaLaReferenciaDelDestino()
        {
            var remover = baseDatos.Get<IRelatedEntityRemover>();

            var resultado = await remover.TryRemoveRelatedEntityAsync<Partido, long, Provincia, long>(1);

            Assert.True(resultado);
            Assert.Null(Leer(ctx => ctx.Partidos.Find(1L).Provincia));
        }

        [Fact]
        public async Task Remover_EntidadInexistente_DevuelveFalse()
        {
            var remover = baseDatos.Get<IRelatedEntityRemover>();

            Assert.False(await remover.TryRemoveRelatedEntityAsync<Provincia, long, Partido, long>(99, 1));
            Assert.False(await remover.TryRemoveRelatedEntityAsync<Partido, long, Provincia, long>(99));
        }

        [Fact]
        public async Task Changer_CambiaElPaisDeLaProvincia()
        {
            var changer = baseDatos.Get<IRelatedEntityChanger>();

            var resultado = await changer.TryChangeRelatedEntityAsync<Provincia, long, Pais, long>(2, 2);

            Assert.True(resultado);
            Assert.Equal(2, Leer(ctx => ctx.Provincias.Find(2L).Pais.Id));
            Assert.Equal([1L], Leer(ctx => ctx.Paises.Find(1L).Provincias.Select(p => p.Id).ToList()));
        }

        [Fact]
        public async Task Changer_ConAccion_CambiaLasMonedasDelTipoDeCambio()
        {
            var changer = baseDatos.Get<IRelatedEntityChanger>();

            var origen = await changer.TryChangeRelatedEntityAsync<TipoCambio, long, Moneda, string>(1, "USD", (tc, m) => tc.CambiarMonedaOrigen(m));
            var destino = await changer.TryChangeRelatedEntityAsync<TipoCambio, long, Moneda, string>(1, "ARS", (tc, m) => tc.CambiarMonedaDestino(m));

            Assert.True(origen);
            Assert.True(destino);
            Assert.Equal(("USD", "ARS"), Leer(ctx =>
            {
                var tc = ctx.TiposCambio.Find(1L);
                return (tc.MonedaOrigen.Id, tc.MonedaDestino.Id);
            }));
        }

        [Fact]
        public async Task Changer_MonedaInexistente_DevuelveFalse()
        {
            var changer = baseDatos.Get<IRelatedEntityChanger>();

            Assert.False(await changer.TryChangeRelatedEntityAsync<TipoCambio, long, Moneda, string>(1, "EUR", (tc, m) => tc.CambiarMonedaOrigen(m)));
            Assert.Null(Leer(ctx => ctx.TiposCambio.Find(1L).MonedaOrigen));
        }

        #endregion
    }
}
