using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Builders
{
    /// <summary>
    /// Builder de Datos Entidad
    /// </summary>
    public class DatosEntidadBuilder : IDatosEntidadBuilder
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="calculadorIdEquipamientoAirbags"></param>
        /// <param name="calculadorIdUbicacionPieza"></param>
        public DatosEntidadBuilder(CalculadorIdEquipamientoAirbags calculadorIdEquipamientoAirbags,
            CalculadorIdUbicacionPieza calculadorIdUbicacionPieza)
        {
            this.calculadorIdEquipamientoAirbags = calculadorIdEquipamientoAirbags;
            this.calculadorIdUbicacionPieza = calculadorIdUbicacionPieza;
        }

        private readonly CalculadorIdEquipamientoAirbags calculadorIdEquipamientoAirbags;
        private readonly CalculadorIdUbicacionPieza calculadorIdUbicacionPieza;

        /// <summary>
        /// Build datos entidad general
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        public DatosEntidad Build(long id, string nombre, string descripcion = null)
        {
            return new DatosEntidad
            {
                Descripcion = descripcion,
                Id = id,
                Nombre = nombre
            };
        }

        /// <summary>
        /// Build datos moneda
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosMoneda Build(string id, string nombre)
        {
            return new DatosMoneda
            {
                Id = id,
                Nombre = nombre
            };
        }

        /// <summary>
        /// Build datos marca
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="categorias"></param>
        /// <returns></returns>
        public DatosMarca Build(long id, string nombre, IEnumerable<DatosEntidad> categorias)
        {
            var datosMarca = new DatosMarca
            {
                Id = id,
                Nombre = nombre
            };
            datosMarca.Categorias.AddRange(categorias);

            return datosMarca;
        }

        /// <summary>
        /// Build datos ubicacion pieza
        /// </summary>
        /// <param name="izquierda"></param>
        /// <param name="superior"></param>
        /// <returns></returns>
        public DatosUbicacionPieza Build(bool izquierda, bool superior)
        {
            var result = new DatosUbicacionPieza
            {
                Izquierda = izquierda,
                Superior = superior
            };
            result.Id = calculadorIdUbicacionPieza.Calcular(result);

            return result;
        }

        /// <summary>
        /// Build datos equipamiento airbags
        /// </summary>
        /// <param name="conductor"></param>
        /// <param name="acompanante"></param>
        /// <param name="delanteroIzquierdo"></param>
        /// <param name="delanteroDerecho"></param>
        /// <param name="traseroIzquierdo"></param>
        /// <param name="traseroDerecho"></param>
        /// <returns></returns>
        public DatosEquipamientoAirbags Build(bool conductor, bool acompanante, TipoAirbagLateral delanteroIzquierdo,
            TipoAirbagLateral delanteroDerecho, TipoAirbagLateral traseroIzquierdo, TipoAirbagLateral traseroDerecho)
        {
            var result = new DatosEquipamientoAirbags
            {
                Acompanante = acompanante,
                Conductor = conductor,
                DelanteroDerecho = delanteroDerecho,
                DelanteroIzquierdo = delanteroIzquierdo,
                TraseroDerecho = traseroDerecho,
                TraseroIzquierdo = traseroIzquierdo
            };
            result.Id = calculadorIdEquipamientoAirbags.Calcular(result);

            return result;
        }
    }
}
