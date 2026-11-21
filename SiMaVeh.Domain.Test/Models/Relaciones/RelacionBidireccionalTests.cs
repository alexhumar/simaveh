using System.Collections.Generic;

namespace SiMaVeh.Domain.Test.Models.Relaciones
{
    /// <summary>
    /// Contrato comun de las relaciones bidireccionales uno-a-muchos del dominio
    /// (ICollectionManager en el padre + IEntityChanger en el hijo).
    /// Cada relacion concreta hereda de esta clase y solo indica como crear y vincular las entidades;
    /// xUnit ejecuta todos los [Fact] heredados para cada clase concreta.
    /// </summary>
    public abstract class RelacionBidireccionalTests<TPadre, THijo>
        where TPadre : class
        where THijo : class
    {
        protected abstract TPadre CrearPadre(long id);

        protected abstract THijo CrearHijo(long id);

        protected abstract ICollection<THijo> Hijos(TPadre padre);

        protected abstract TPadre PadreDe(THijo hijo);

        protected abstract object Agregar(TPadre padre, THijo hijo);

        protected abstract object Quitar(TPadre padre, THijo hijo);

        protected abstract object Cambiar(THijo hijo, TPadre padre);

        [Fact]
        public void Agregar_HijoNuevo_VinculaAmbosLados()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);

            var resultado = Agregar(padre, hijo);

            Assert.Same(padre, resultado);
            Assert.Contains(hijo, Hijos(padre));
            Assert.Same(padre, PadreDe(hijo));
        }

        [Fact]
        public void Agregar_MismoHijoDosVeces_NoLoDuplica()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);

            Agregar(padre, hijo);
            Agregar(padre, hijo);

            Assert.Single(Hijos(padre));
        }

        [Fact]
        public void Agregar_VariosHijos_LosVinculaATodos()
        {
            var padre = CrearPadre(1);
            var hijo1 = CrearHijo(1);
            var hijo2 = CrearHijo(2);

            Agregar(padre, hijo1);
            Agregar(padre, hijo2);

            Assert.Equal(2, Hijos(padre).Count);
            Assert.Same(padre, PadreDe(hijo1));
            Assert.Same(padre, PadreDe(hijo2));
        }

        [Fact]
        public void Agregar_Null_NoModificaLaColeccion()
        {
            var padre = CrearPadre(1);

            var resultado = Agregar(padre, null);

            Assert.Same(padre, resultado);
            Assert.Empty(Hijos(padre));
        }

        [Fact]
        public void Agregar_HijoDeOtroPadre_LoMueveAlNuevoPadre()
        {
            var padreAnterior = CrearPadre(1);
            var padreNuevo = CrearPadre(2);
            var hijo = CrearHijo(1);
            Agregar(padreAnterior, hijo);

            Agregar(padreNuevo, hijo);

            Assert.Same(padreNuevo, PadreDe(hijo));
            Assert.Contains(hijo, Hijos(padreNuevo));
            Assert.DoesNotContain(hijo, Hijos(padreAnterior));
        }

        [Fact]
        public void Quitar_HijoAgregado_DesvinculaAmbosLados()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);
            Agregar(padre, hijo);

            var resultado = Quitar(padre, hijo);

            Assert.Same(padre, resultado);
            Assert.Empty(Hijos(padre));
            Assert.Null(PadreDe(hijo));
        }

        [Fact]
        public void Quitar_HijoDeOtroPadre_NoAfectaAlOtroPadre()
        {
            var padre = CrearPadre(1);
            var otroPadre = CrearPadre(2);
            var hijo = CrearHijo(1);
            Agregar(otroPadre, hijo);

            Quitar(padre, hijo);

            Assert.Same(otroPadre, PadreDe(hijo));
            Assert.Contains(hijo, Hijos(otroPadre));
        }

        [Fact]
        public void Quitar_Null_NoModificaLaColeccion()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);
            Agregar(padre, hijo);

            var resultado = Quitar(padre, null);

            Assert.Same(padre, resultado);
            Assert.Single(Hijos(padre));
        }

        [Fact]
        public void Cambiar_APadre_VinculaAmbosLados()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);

            var resultado = Cambiar(hijo, padre);

            Assert.Same(hijo, resultado);
            Assert.Same(padre, PadreDe(hijo));
            Assert.Contains(hijo, Hijos(padre));
        }

        [Fact]
        public void Cambiar_AOtroPadre_LoQuitaDelAnterior()
        {
            var padreAnterior = CrearPadre(1);
            var padreNuevo = CrearPadre(2);
            var hijo = CrearHijo(1);
            Cambiar(hijo, padreAnterior);

            Cambiar(hijo, padreNuevo);

            Assert.Same(padreNuevo, PadreDe(hijo));
            Assert.Contains(hijo, Hijos(padreNuevo));
            Assert.DoesNotContain(hijo, Hijos(padreAnterior));
        }

        [Fact]
        public void Cambiar_ANull_DesvinculaAmbosLados()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);
            Cambiar(hijo, padre);

            Cambiar(hijo, null);

            Assert.Null(PadreDe(hijo));
            Assert.Empty(Hijos(padre));
        }

        [Fact]
        public void Cambiar_AlMismoPadre_NoDuplica()
        {
            var padre = CrearPadre(1);
            var hijo = CrearHijo(1);
            Cambiar(hijo, padre);

            Cambiar(hijo, padre);

            Assert.Single(Hijos(padre));
            Assert.Same(padre, PadreDe(hijo));
        }

        [Fact]
        public void Cambiar_HijoSinPadreANull_NoHaceNada()
        {
            var hijo = CrearHijo(1);

            var resultado = Cambiar(hijo, null);

            Assert.Same(hijo, resultado);
            Assert.Null(PadreDe(hijo));
        }
    }
}
