using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Mantenimiento
    /// </summary>
    public class Mantenimiento : DomainMember<long>,
        IEntityChanger<Recambio, long, Mantenimiento, long>,
        IEntityChanger<Moneda, string, Mantenimiento, long>,
        IEntityChanger<ServicioReparador, long, Mantenimiento, long>,
        IEntityChanger<Reparador, long, Mantenimiento, long>
    {
        private readonly IEnumParser<AccionMantenimiento> accionMantenimientoParser;

        /// <summary>
        /// Accion
        /// </summary>
        public virtual AccionMantenimiento Accion { get; set; }

        /// <summary>
        /// Recambio
        /// </summary>
        public virtual Recambio Recambio { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Monto Recambio
        /// </summary>
        public virtual decimal MontoRecambio { get; set; }

        /// <summary>
        /// Moneda Monto Recambio
        /// </summary>
        public virtual Moneda MonedaMontoRecambio { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Servicio Reparador
        /// </summary>
        public virtual ServicioReparador ServicioReparador { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Reparador
        /// </summary>
        public virtual Reparador Reparador { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Constructor
        /// </summary>
        public Mantenimiento()
        {
            accionMantenimientoParser = new AccionMantenimientoParser();
        }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", accionMantenimientoParser.ToString(Accion), ") ", Recambio?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Mantenimiento item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Accion.Equals(item.Accion) && Recambio.Equals(item.Recambio) && ServicioReparador.Equals(item.ServicioReparador) && Reparador.Equals(item.Reparador)));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Mantenimiento).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar recambio
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Recambio entity)
        {
            if (entity != null)
            {
                Recambio = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar moneda
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Moneda entity)
        {
            if (entity != null)
            {
                MonedaMontoRecambio = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(ServicioReparador entity)
        {
            if (ServicioReparador != entity)
            {
                ServicioReparador?.Quitar(this);
                ServicioReparador = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        /// <summary>
        /// Cambiar reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Reparador entity)
        {
            if (entity != null)
            {
                Reparador = entity;
            }

            return this;
        }

        #endregion
    }
}
