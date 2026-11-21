using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Test.Models.Relaciones
{
    public class Pais_Provincias : RelacionBidireccionalTests<Pais, Provincia>
    {
        protected override Pais CrearPadre(long id) => Crear.Pais(id);
        protected override Provincia CrearHijo(long id) => Crear.Provincia(id);
        protected override ICollection<Provincia> Hijos(Pais padre) => padre.Provincias;
        protected override Pais PadreDe(Provincia hijo) => hijo.Pais;
        protected override object Agregar(Pais padre, Provincia hijo) => padre.Agregar(hijo);
        protected override object Quitar(Pais padre, Provincia hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Provincia hijo, Pais padre) => hijo.Cambiar(padre);
    }

    public class Provincia_Partidos : RelacionBidireccionalTests<Provincia, Partido>
    {
        protected override Provincia CrearPadre(long id) => Crear.Provincia(id);
        protected override Partido CrearHijo(long id) => Crear.Partido(id);
        protected override ICollection<Partido> Hijos(Provincia padre) => padre.Partidos;
        protected override Provincia PadreDe(Partido hijo) => hijo.Provincia;
        protected override object Agregar(Provincia padre, Partido hijo) => padre.Agregar(hijo);
        protected override object Quitar(Provincia padre, Partido hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Partido hijo, Provincia padre) => hijo.Cambiar(padre);
    }

    public class Partido_Localidades : RelacionBidireccionalTests<Partido, Localidad>
    {
        protected override Partido CrearPadre(long id) => Crear.Partido(id);
        protected override Localidad CrearHijo(long id) => Crear.Localidad(id);
        protected override ICollection<Localidad> Hijos(Partido padre) => padre.Localidades;
        protected override Partido PadreDe(Localidad hijo) => hijo.Partido;
        protected override object Agregar(Partido padre, Localidad hijo) => padre.Agregar(hijo);
        protected override object Quitar(Partido padre, Localidad hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Localidad hijo, Partido padre) => hijo.Cambiar(padre);
    }

    public class Usuario_Telefonos : RelacionBidireccionalTests<Usuario, Telefono>
    {
        protected override Usuario CrearPadre(long id) => Crear.Usuario(id);
        protected override Telefono CrearHijo(long id) => Crear.Telefono(id);
        protected override ICollection<Telefono> Hijos(Usuario padre) => padre.Telefonos;
        protected override Usuario PadreDe(Telefono hijo) => (Usuario)hijo.Persona;
        protected override object Agregar(Usuario padre, Telefono hijo) => padre.Agregar(hijo);
        protected override object Quitar(Usuario padre, Telefono hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Telefono hijo, Usuario padre) => hijo.Cambiar((Persona)padre);
    }

    public class Reparador_Telefonos : RelacionBidireccionalTests<Reparador, Telefono>
    {
        protected override Reparador CrearPadre(long id) => Crear.Reparador(id);
        protected override Telefono CrearHijo(long id) => Crear.Telefono(id);
        protected override ICollection<Telefono> Hijos(Reparador padre) => padre.Telefonos;
        protected override Reparador PadreDe(Telefono hijo) => (Reparador)hijo.Persona;
        protected override object Agregar(Reparador padre, Telefono hijo) => padre.Agregar(hijo);
        protected override object Quitar(Reparador padre, Telefono hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Telefono hijo, Reparador padre) => hijo.Cambiar((Persona)padre);
    }

    public class Usuario_Vehiculos : RelacionBidireccionalTests<Usuario, Automovil>
    {
        protected override Usuario CrearPadre(long id) => Crear.Usuario(id);
        protected override Automovil CrearHijo(long id) => new() { Id = id, Patente = $"AA{id:000}BB" };
        protected override ICollection<Automovil> Hijos(Usuario padre) => new List<Automovil>(System.Linq.Enumerable.OfType<Automovil>(padre.Vehiculos));
        protected override Usuario PadreDe(Automovil hijo) => hijo.Usuario;
        protected override object Agregar(Usuario padre, Automovil hijo) => padre.Agregar(hijo);
        protected override object Quitar(Usuario padre, Automovil hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Automovil hijo, Usuario padre) => hijo.Cambiar(padre);
    }

    public class Vehiculo_ServiciosReparadores : RelacionBidireccionalTests<Automovil, ServicioReparador>
    {
        protected override Automovil CrearPadre(long id) => new() { Id = id, Patente = $"AA{id:000}BB" };
        protected override ServicioReparador CrearHijo(long id) => Crear.ServicioReparador(id);
        protected override ICollection<ServicioReparador> Hijos(Automovil padre) => padre.ServiciosReparadores;
        protected override Automovil PadreDe(ServicioReparador hijo) => (Automovil)hijo.Vehiculo;
        protected override object Agregar(Automovil padre, ServicioReparador hijo) => padre.Agregar(hijo);
        protected override object Quitar(Automovil padre, ServicioReparador hijo) => padre.Quitar(hijo);
        protected override object Cambiar(ServicioReparador hijo, Automovil padre) => hijo.Cambiar((Vehiculo)padre);
    }

    public class EntidadReparadora_ServiciosReparadores : RelacionBidireccionalTests<EntidadReparadora, ServicioReparador>
    {
        protected override EntidadReparadora CrearPadre(long id) => Crear.EntidadReparadora(id);
        protected override ServicioReparador CrearHijo(long id) => Crear.ServicioReparador(id);
        protected override ICollection<ServicioReparador> Hijos(EntidadReparadora padre) => padre.ServiciosReparadores;
        protected override EntidadReparadora PadreDe(ServicioReparador hijo) => hijo.EntidadReparadora;
        protected override object Agregar(EntidadReparadora padre, ServicioReparador hijo) => padre.Agregar(hijo);
        protected override object Quitar(EntidadReparadora padre, ServicioReparador hijo) => padre.Quitar(hijo);
        protected override object Cambiar(ServicioReparador hijo, EntidadReparadora padre) => hijo.Cambiar(padre);
    }

    public class ServicioReparador_Mantenimientos : RelacionBidireccionalTests<ServicioReparador, Mantenimiento>
    {
        protected override ServicioReparador CrearPadre(long id) => Crear.ServicioReparador(id);
        protected override Mantenimiento CrearHijo(long id) => Crear.Mantenimiento(id);
        protected override ICollection<Mantenimiento> Hijos(ServicioReparador padre) => padre.Mantenimientos;
        protected override ServicioReparador PadreDe(Mantenimiento hijo) => hijo.ServicioReparador;
        protected override object Agregar(ServicioReparador padre, Mantenimiento hijo) => padre.Agregar(hijo);
        protected override object Quitar(ServicioReparador padre, Mantenimiento hijo) => padre.Quitar(hijo);
        protected override object Cambiar(Mantenimiento hijo, ServicioReparador padre) => hijo.Cambiar(padre);
    }

    public class Repuesto_PeriodicidadesMantenimiento : RelacionBidireccionalTests<Repuesto, PeriodicidadMantenimiento>
    {
        protected override Repuesto CrearPadre(long id) => Crear.Repuesto(id);
        protected override PeriodicidadMantenimiento CrearHijo(long id) => Crear.PeriodicidadMantenimiento(id);
        protected override ICollection<PeriodicidadMantenimiento> Hijos(Repuesto padre) => padre.PeriodicidadesMantenimiento;
        protected override Repuesto PadreDe(PeriodicidadMantenimiento hijo) => hijo.Repuesto;
        protected override object Agregar(Repuesto padre, PeriodicidadMantenimiento hijo) => padre.Agregar(hijo);
        protected override object Quitar(Repuesto padre, PeriodicidadMantenimiento hijo) => padre.Quitar(hijo);
        protected override object Cambiar(PeriodicidadMantenimiento hijo, Repuesto padre) => hijo.Cambiar(padre);
    }
}
