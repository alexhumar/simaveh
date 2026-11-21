using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Clase base DomainMember.
    /// </summary>
    /// <remarks>
    /// Las entidades se comparan por identidad: dos entidades son iguales si son del mismo tipo y tienen
    /// el mismo Id ya asignado. Una entidad transitoria (sin Id, todavia no persistida) solo es igual a si misma.
    /// La igualdad por atributos (por ejemplo, el mismo Nombre) no corresponde a una entidad: los duplicados
    /// se deben validar aparte.
    /// </remarks>
    public class DomainMember<TBeId>
    {
        private const string NamespaceProxiesEF = "Castle.Proxies";

        private int? hashCode;

        /// <summary>
        /// Id
        /// </summary>
        public virtual TBeId Id { get; set; }

        /// <summary>
        /// Indica si la entidad todavia no tiene Id asignado (no fue persistida).
        /// </summary>
        public bool EsTransitoria => Id is null || EqualityComparer<TBeId>.Default.Equals(Id, default) || (Id is string texto && texto.Length == 0);

        /// <summary>
        /// Igualdad por identidad: mismo tipo y mismo Id asignado.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is not DomainMember<TBeId> otra)
            {
                return false;
            }

            if (ReferenceEquals(this, otra))
            {
                return true;
            }

            if (TipoReal(this) != TipoReal(otra) || EsTransitoria || otra.EsTransitoria)
            {
                return false;
            }

            return EqualityComparer<TBeId>.Default.Equals(Id, otra.Id);
        }

        /// <summary>
        /// Hash consistente con Equals. Se calcula una sola vez y se conserva, para que una entidad transitoria
        /// que se persiste (y recibe su Id) mientras esta dentro de un HashSet no cambie de hash.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            hashCode ??= EsTransitoria
                ? RuntimeHelpers.GetHashCode(this)
                : HashCode.Combine(TipoReal(this), Id);

            return hashCode.Value;
        }

        /// <summary>
        /// Tipo de la entidad sin el proxy de lazy loading de EF (Castle), para que una entidad cargada
        /// por EF sea igual a una instancia comun con el mismo Id.
        /// </summary>
        private static Type TipoReal(object entidad)
        {
            var tipo = entidad.GetType();

            return tipo.Namespace == NamespaceProxiesEF ? tipo.BaseType : tipo;
        }
    }
}
