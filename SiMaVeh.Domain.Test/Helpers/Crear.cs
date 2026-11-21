using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;
using System;

namespace SiMaVeh.Domain.Test.Helpers
{
    /// <summary>
    /// Fabrica de entidades de dominio con datos validos, para usar en los tests.
    /// Cada metodo recibe el Id para poder crear instancias distinguibles entre si.
    /// </summary>
    public static class Crear
    {
        public static Aceite Aceite(long id = 1) => new() { Id = id, Nombre = $"Aceite {id}", Descripcion = "Aceite sintetico", ViscosidadSAEBajaTemperatura = 5, ViscosidadSAEAltaTemperatura = 30 };

        public static Automovil Automovil(long id = 1) => new() { Id = id, Patente = $"AA{id:000}BB", NumeroChasis = $"CH{id}", AnioFabricacion = 2015, Kilometraje = 1000, ModeloVehiculo = ModeloVehiculo(id), Usuario = Usuario(id) };

        public static CategoriaMarca CategoriaMarca(long id = 1) => new() { Id = id, Nombre = $"Categoria {id}" };

        public static Direccion Direccion(long id = 1) => new() { Id = id, Calle = $"Calle {id}", NumeroCalle = 100 };

        public static EntidadReparadora EntidadReparadora(long id = 1) => new() { Id = id, Nombre = $"Taller {id}" };

        public static EquipamientoAirbags EquipamientoAirbags() => new() { Conductor = true, Acompanante = true, DelanteroIzquierdo = TipoAirbagLateral.Lateral, DelanteroDerecho = TipoAirbagLateral.Lateral, TraseroIzquierdo = TipoAirbagLateral.NoPosee, TraseroDerecho = TipoAirbagLateral.NoPosee };

        public static Fluido Fluido(long id = 1) => new() { Id = id, Nombre = $"Fluido {id}", Descripcion = "Liquido refrigerante" };

        public static FuenteEnergia FuenteEnergia(long id = 1) => new() { Id = id, Nombre = $"Nafta {id}" };

        public static GrupoModelo GrupoModelo(long id = 1) => new() { Id = id, Nombre = $"Grupo {id}" };

        public static Kit Kit(long id = 1) => new() { Id = id, Nombre = $"Kit {id}", Descripcion = "Kit de distribucion" };

        public static Localidad Localidad(long id = 1) => new() { Id = id, Nombre = $"Localidad {id}", CPA = $"B{id:0000}ABC" };

        public static Mantenimiento Mantenimiento(long id = 1) => new() { Id = id, Accion = AccionMantenimiento.Reemplazo, MontoRecambio = 10 };

        public static Marca Marca(long id = 1) => new() { Id = id, Nombre = $"Marca {id}" };

        public static ModeloVehiculo ModeloVehiculo(long id = 1) => new() { Id = id, Version = $"Version {id}" };

        public static Moneda Moneda(string id = "ARS") => new() { Id = id, Nombre = $"Moneda {id}" };

        public static Neumatico Neumatico(long id = 1) => new() { Id = id, Modelo = $"Modelo {id}", Tipo = TipoVehiculoNeumatico.Pasajero, ConstruccionCarcasa = ConstruccionCarcasaNeumatico.Radial, AnchuraSeccionalNominal = 195, RelacionAnchoAlto = 65, DiametroLLanta = 15, IndiceCarga = 91, IndiceVelocidad = "H" };

        public static Pais Pais(long id = 1) => new() { Id = id, Nombre = $"Pais {id}" };

        public static Partido Partido(long id = 1) => new() { Id = id, Nombre = $"Partido {id}" };

        public static PeriodicidadMantenimiento PeriodicidadMantenimiento(long id = 1) => new() { Id = id, Kilometros = 10000, Dias = 1, Meses = 1, Anios = 1 };

        public static Pieza Pieza(long id = 1) => new() { Id = id, Nombre = $"Pieza {id}", Descripcion = "Pastilla de freno" };

        public static PresionNeumatico PresionNeumatico(long id = 1) => new() { Id = id, RuedasDelanteras = 30, RuedasTraseras = 32 };

        public static Provincia Provincia(long id = 1) => new() { Id = id, Nombre = $"Provincia {id}" };

        public static Reparador Reparador(long id = 1) => new() { Id = id, Nombre = "Juan", Apellido = $"Perez {id}", NumeroDocumento = $"{20000000 + id}" };

        public static Repuesto Repuesto(long id = 1) => new() { Id = id, CodigoIdentificador = $"REP-{id}" };

        public static ServicioReparador ServicioReparador(long id = 1) => new() { Id = id, FechaInicio = new DateTime(2024, 1, 1), FechaFin = new DateTime(2024, 1, 2), KilometrajeVehiculo = 50000 };

        public static Telefono Telefono(long id = 1) => new() { Id = id, Numero = 44440000 + (int)id };

        public static TipoCambio TipoCambio(long id = 1) => new() { Id = id, CoeficienteCambio = 1000, Fecha = new DateTime(2024, 1, 1) };

        public static TipoDocumento TipoDocumento(long id = 1) => new() { Id = id, Nombre = $"DNI {id}", Descripcion = "Documento" };

        public static TipoEntidadReparadora TipoEntidadReparadora(long id = 1) => new() { Id = id, Nombre = $"Taller {id}", Descripcion = "Tipo" };

        public static TipoFuenteEnergia TipoFuenteEnergia(long id = 1) => new() { Id = id, Nombre = $"Combustible {id}", Descripcion = "Tipo" };

        public static TipoTelefono TipoTelefono(long id = 1) => new() { Id = id, Nombre = $"Celular {id}", Descripcion = "Tipo" };

        public static UbicacionPieza UbicacionPieza(bool izquierda = true, bool superior = true) => new() { Izquierda = izquierda, Superior = superior };

        public static Usuario Usuario(long id = 1) => new() { Id = id, Nombre = "Ana", Apellido = $"Gomez {id}", NumeroDocumento = $"{30000000 + id}" };
    }
}
