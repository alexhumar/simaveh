using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.Models;
using System;
using System.Linq;

namespace SiMaVeh.DataAccess.Test.Model
{
    /// <summary>
    /// Las relaciones many-to-many configuradas en ConfiguradorRelacionesManyToMany se persisten
    /// a traves de sus entidades intermedias y se pueden leer desde ambos lados.
    /// </summary>
    public sealed class RelacionesManyToManyTests : IDisposable
    {
        private readonly BaseDatosEnMemoria baseDatos = new();

        public void Dispose() => baseDatos.Dispose();

        private T Leer<T>(Func<SiMaVehContext, T> consulta) =>
            baseDatos.EnNuevoScope(sp => consulta(sp.GetRequiredService<SiMaVehContext>()));

        private void Guardar(params object[] entidades)
        {
            baseDatos.Contexto.AddRange(entidades);
            baseDatos.Contexto.SaveChanges();
        }

        [Fact]
        public void Kit_Repuestos()
        {
            var kit = new Kit { Id = 1, Nombre = "Distribucion" };
            kit.Agregar(new Repuesto { Id = 10, CodigoIdentificador = "Correa" }).Agregar(new Repuesto { Id = 11, CodigoIdentificador = "Tensor" });
            Guardar(kit);

            Assert.Equal([10L, 11L], Leer(ctx => ctx.Kits.Find(1L).Repuestos.Select(r => r.Id).OrderBy(i => i).ToList()));
            Assert.Equal([1L], Leer(ctx => ctx.Repuestos.Find(10L).Kits.Select(k => k.Id).ToList()));
        }

        [Fact]
        public void Marca_Categorias()
        {
            var marca = new Marca { Id = 1, Nombre = "Ford" };
            marca.Agregar(new CategoriaMarca { Id = 5, Nombre = "Autos" });
            Guardar(marca);

            Assert.Equal([5L], Leer(ctx => ctx.Marcas.Find(1L).Categorias.Select(c => c.Id).ToList()));
            Assert.Equal([1L], Leer(ctx => ctx.CategoriasMarca.Find(5L).Marcas.Select(m => m.Id).ToList()));
        }

        [Fact]
        public void ModeloVehiculo_Recomendaciones()
        {
            var modelo = new ModeloVehiculo { Id = 1, Version = "1.6" };
            modelo.Agregar(new Aceite { Id = 20, Nombre = "5W30" })
                .Agregar(new FuenteEnergia { Id = 30, Nombre = "Super" })
                .Agregar(new Repuesto { Id = 40, CodigoIdentificador = "Filtro" })
                .Agregar(new PresionNeumatico { Id = 50, RuedasDelanteras = 30, RuedasTraseras = 32 });
            Guardar(modelo);

            var (aceites, fuentes, repuestos, presiones) = Leer(ctx =>
            {
                var m = ctx.ModelosVehiculo.Find(1L);
                return (m.AceitesRecomendados.Single().Id, m.FuentesEnergiaRecomendadas.Single().Id, m.RepuestosRecomendados.Single().Id, m.PresionesNeumaticoRecomendadas.Single().Id);
            });
            Assert.Equal((20L, 30L, 40L, 50L), (aceites, fuentes, repuestos, presiones));
            Assert.Equal(1L, Leer(ctx => ctx.Aceites.Find(20L).RecomendacionesModeloVehiculo.Single().Id));
            Assert.Equal(1L, Leer(ctx => ctx.FuentesEnergia.Find(30L).RecomendacionesModeloVehiculo.Single().Id));
            Assert.Equal(1L, Leer(ctx => ctx.Repuestos.Find(40L).RecomendacionesModeloVehiculo.Single().Id));
            Assert.Equal(1L, Leer(ctx => ctx.PresionesNeumaticos.Find(50L).RecomendacionesModeloVehiculo.Single().Id));
        }

        [Fact]
        public void EntidadReparadora_Reparadores()
        {
            var taller = new EntidadReparadora { Id = 1, Nombre = "Taller" };
            taller.Agregar(new Reparador { Id = 7, Nombre = "Juan", Apellido = "Perez", NumeroDocumento = "1" });
            Guardar(taller);

            Assert.Equal([7L], Leer(ctx => ctx.EntidadesReparadoras.Find(1L).Reparadores.Select(r => r.Id).ToList()));
            Assert.Equal([1L], Leer(ctx => ctx.Reparadores.Find(7L).EntidadesReparadoras.Select(e => e.Id).ToList()));
        }

        [Fact]
        public void EntidadesIntermedias_SeCreanPorCadaVinculo()
        {
            var kit = new Kit { Id = 1, Nombre = "Kit" };
            kit.Agregar(new Repuesto { Id = 10, CodigoIdentificador = "A" }).Agregar(new Repuesto { Id = 11, CodigoIdentificador = "B" });
            Guardar(kit);

            var vinculos = Leer(ctx => ctx.Set<KitRepuesto>().Select(kr => new { kr.KitId, kr.RepuestoId }).OrderBy(kr => kr.RepuestoId).ToList());

            Assert.Equal(2, vinculos.Count);
            Assert.All(vinculos, v => Assert.Equal(1L, v.KitId));
            Assert.Equal([10L, 11L], vinculos.Select(v => v.RepuestoId));
        }
    }
}
