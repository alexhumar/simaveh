using FluentValidation;
using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Test.Helpers;
using SiMaVeh.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Test.Validators
{
    /// <summary>
    /// Para cada validador: una entidad valida no tiene errores, y cada regla violada por separado
    /// produce un error sobre la propiedad correspondiente.
    /// </summary>
    public class ValidadoresTests
    {
        public record Invalidacion(string Descripcion, string Propiedad, Action<object> Aplicar);

        public record Caso(IValidator Validador, Func<object> CrearValido, Invalidacion[] Invalidaciones);

        private static Invalidacion I<T>(string descripcion, string propiedad, Action<T> aplicar) => new(descripcion, propiedad, o => aplicar((T)o));

        private static Caso C<T>(AbstractValidator<T> validador, Func<T> crearValido, params Invalidacion[] invalidaciones) => new(validador, () => crearValido(), invalidaciones);

        private static readonly string textoLargo = new('x', 101);

        private static Invalidacion[] NombreObligatorio<T>(Action<T, string> setNombre) =>
        [
            I<T>("Nombre null", "Nombre", e => setNombre(e, null)),
            I<T>("Nombre vacio", "Nombre", e => setNombre(e, string.Empty)),
        ];

        private static Invalidacion[] TargetMantenimiento<T>() where T : TargetMantenimiento =>
        [
            .. NombreObligatorio<T>((e, v) => e.Nombre = v),
            I<T>("Descripcion null", "Descripcion", e => e.Descripcion = null),
            I<T>("Descripcion vacia", "Descripcion", e => e.Descripcion = string.Empty),
        ];

        private static Invalidacion[] Persona<T>() where T : Persona =>
        [
            .. NombreObligatorio<T>((e, v) => e.Nombre = v),
            I<T>("Apellido null", "Apellido", e => e.Apellido = null),
            I<T>("Apellido vacio", "Apellido", e => e.Apellido = string.Empty),
            I<T>("NumeroDocumento null", "NumeroDocumento", e => e.NumeroDocumento = null),
            I<T>("NumeroDocumento vacio", "NumeroDocumento", e => e.NumeroDocumento = string.Empty),
        ];

        private static Invalidacion[] TipoConDescripcion<T>(Action<T, string> setNombre, Action<T, string> setDescripcion) =>
        [
            .. NombreObligatorio(setNombre),
            I<T>("Descripcion de mas de 100 caracteres", "Descripcion", e => setDescripcion(e, textoLargo)),
        ];

        private static readonly Dictionary<string, Caso> casos = new()
        {
            ["Aceite"] = C(new ValidadorAceite(), () => Crear.Aceite(),
            [
                .. TargetMantenimiento<Aceite>(),
                I<Aceite>("Viscosidad alta negativa", "ViscosidadSAEAltaTemperatura", e => e.ViscosidadSAEAltaTemperatura = -1),
                I<Aceite>("Viscosidad baja negativa", "ViscosidadSAEBajaTemperatura", e => e.ViscosidadSAEBajaTemperatura = -1),
            ]),
            ["Automovil"] = C(new ValidadorAutomovil(), () => Crear.Automovil(),
                I<Automovil>("NumeroChasis null", "NumeroChasis", e => e.NumeroChasis = null),
                I<Automovil>("NumeroChasis vacio", "NumeroChasis", e => e.NumeroChasis = string.Empty),
                I<Automovil>("Patente null", "Patente", e => e.Patente = null),
                I<Automovil>("Patente vacia", "Patente", e => e.Patente = string.Empty),
                I<Automovil>("AnioFabricacion 1890", "AnioFabricacion", e => e.AnioFabricacion = 1890),
                I<Automovil>("Kilometraje negativo", "Kilometraje", e => e.Kilometraje = -1),
                I<Automovil>("Sin ModeloVehiculo", "ModeloVehiculo", e => e.ModeloVehiculo = null),
                I<Automovil>("Sin Usuario", "Usuario", e => e.Usuario = null)),
            ["CategoriaMarca"] = C(new ValidadorCategoriaMarca(), () => Crear.CategoriaMarca(), NombreObligatorio<CategoriaMarca>((e, v) => e.Nombre = v)),
            ["Direccion"] = C(new ValidadorDireccion(), () => Crear.Direccion(),
                I<Direccion>("Calle null", "Calle", e => e.Calle = null),
                I<Direccion>("Calle vacia", "Calle", e => e.Calle = string.Empty),
                I<Direccion>("NumeroCalle 0", "NumeroCalle", e => e.NumeroCalle = 0)),
            ["EntidadReparadora"] = C(new ValidadorEntidadReparadora(), () => Crear.EntidadReparadora(), NombreObligatorio<EntidadReparadora>((e, v) => e.Nombre = v)),
            ["EquipamientoAirbags"] = C(new ValidadorEquipamientoAirbags(), Crear.EquipamientoAirbags,
                I<EquipamientoAirbags>("DelanteroDerecho fuera del enum", "DelanteroDerecho", e => e.DelanteroDerecho = (TipoAirbagLateral)99),
                I<EquipamientoAirbags>("DelanteroIzquierdo fuera del enum", "DelanteroIzquierdo", e => e.DelanteroIzquierdo = (TipoAirbagLateral)99),
                I<EquipamientoAirbags>("TraseroDerecho fuera del enum", "TraseroDerecho", e => e.TraseroDerecho = (TipoAirbagLateral)99),
                I<EquipamientoAirbags>("TraseroIzquierdo fuera del enum", "TraseroIzquierdo", e => e.TraseroIzquierdo = (TipoAirbagLateral)99)),
            ["Fluido"] = C(new ValidadorFluido(), () => Crear.Fluido(), TargetMantenimiento<Fluido>()),
            ["FuenteEnergia"] = C(new ValidadorFuenteEnergia(), () => Crear.FuenteEnergia(), NombreObligatorio<FuenteEnergia>((e, v) => e.Nombre = v)),
            ["GrupoModelo"] = C(new ValidadorGrupoModelo(), () => Crear.GrupoModelo(), NombreObligatorio<GrupoModelo>((e, v) => e.Nombre = v)),
            ["Kit"] = C(new ValidadorKit(), () => Crear.Kit()),
            ["Localidad"] = C(new ValidadorLocalidad(), () => Crear.Localidad(),
            [
                .. NombreObligatorio<Localidad>((e, v) => e.Nombre = v),
                I<Localidad>("CPA null", "CPA", e => e.CPA = null),
                I<Localidad>("CPA vacio", "CPA", e => e.CPA = string.Empty),
            ]),
            ["Mantenimiento"] = C(new ValidadorMantenimiento(), () => Crear.Mantenimiento(),
                I<Mantenimiento>("Accion fuera del enum", "Accion", e => e.Accion = (AccionMantenimiento)99),
                I<Mantenimiento>("MontoRecambio negativo", "MontoRecambio", e => e.MontoRecambio = -1)),
            ["Marca"] = C(new ValidadorMarca(), () => Crear.Marca(), NombreObligatorio<Marca>((e, v) => e.Nombre = v)),
            ["ModeloVehiculo"] = C(new ValidadorModeloVehiculo(), () => Crear.ModeloVehiculo(),
                I<ModeloVehiculo>("Version null", "Version", e => e.Version = null),
                I<ModeloVehiculo>("Version vacia", "Version", e => e.Version = string.Empty)),
            ["Moneda"] = C(new ValidadorMoneda(), () => Crear.Moneda(), NombreObligatorio<Moneda>((e, v) => e.Nombre = v)),
            ["Neumatico"] = C(new ValidadorNeumatico(), () => Crear.Neumatico(),
                I<Neumatico>("AnchuraSeccionalNominal 0", "AnchuraSeccionalNominal", e => e.AnchuraSeccionalNominal = 0),
                I<Neumatico>("ConstruccionCarcasa fuera del enum", "ConstruccionCarcasa", e => e.ConstruccionCarcasa = (ConstruccionCarcasaNeumatico)99),
                I<Neumatico>("DiametroLLanta 0", "DiametroLLanta", e => e.DiametroLLanta = 0),
                I<Neumatico>("IndiceCarga 0", "IndiceCarga", e => e.IndiceCarga = 0),
                I<Neumatico>("IndiceVelocidad vacio", "IndiceVelocidad", e => e.IndiceVelocidad = string.Empty),
                I<Neumatico>("Modelo null", "Modelo", e => e.Modelo = null),
                I<Neumatico>("Tipo fuera del enum", "Tipo", e => e.Tipo = (TipoVehiculoNeumatico)99)),
            ["Pais"] = C(new ValidadorPais(), () => Crear.Pais(), NombreObligatorio<Pais>((e, v) => e.Nombre = v)),
            ["Partido"] = C(new ValidadorPartido(), () => Crear.Partido(), NombreObligatorio<Partido>((e, v) => e.Nombre = v)),
            ["PeriodicidadMantenimiento"] = C(new ValidadorPeriodicidadMantenimiento(), () => Crear.PeriodicidadMantenimiento(),
                I<PeriodicidadMantenimiento>("Anios 0", "Anios", e => e.Anios = 0),
                I<PeriodicidadMantenimiento>("Dias 0", "Dias", e => e.Dias = 0),
                I<PeriodicidadMantenimiento>("Kilometros 0", "Kilometros", e => e.Kilometros = 0),
                I<PeriodicidadMantenimiento>("Meses 0", "Meses", e => e.Meses = 0)),
            ["Pieza"] = C(new ValidadorPieza(), () => Crear.Pieza(), TargetMantenimiento<Pieza>()),
            ["PresionNeumatico"] = C(new ValidadorPresionNeumatico(), () => Crear.PresionNeumatico(),
                I<PresionNeumatico>("RuedasDelanteras 0", "RuedasDelanteras", e => e.RuedasDelanteras = 0),
                I<PresionNeumatico>("RuedasTraseras 0", "RuedasTraseras", e => e.RuedasTraseras = 0)),
            ["Provincia"] = C(new ValidadorProvincia(), () => Crear.Provincia(), NombreObligatorio<Provincia>((e, v) => e.Nombre = v)),
            ["Reparador"] = C(new ValidadorReparador(), () => Crear.Reparador(), Persona<Reparador>()),
            ["Repuesto"] = C(new ValidadorRepuesto(), () => Crear.Repuesto(),
                I<Repuesto>("CodigoIdentificador null", "CodigoIdentificador", e => e.CodigoIdentificador = null),
                I<Repuesto>("CodigoIdentificador vacio", "CodigoIdentificador", e => e.CodigoIdentificador = string.Empty)),
            ["ServicioReparador"] = C(new ValidadorServicioReparador(), () => Crear.ServicioReparador(),
                I<ServicioReparador>("FechaInicio posterior a FechaFin", "FechaInicio", e => e.FechaInicio = e.FechaFin.AddDays(1)),
                I<ServicioReparador>("FechaFin anterior a FechaInicio", "FechaFin", e => e.FechaFin = e.FechaInicio.AddDays(-1)),
                I<ServicioReparador>("KilometrajeVehiculo 0", "KilometrajeVehiculo", e => e.KilometrajeVehiculo = 0)),
            ["Telefono"] = C(new ValidadorTelefono(), () => Crear.Telefono(),
                I<Telefono>("Numero 0", "Numero", e => e.Numero = 0)),
            ["TipoCambio"] = C(new ValidadorTipoCambio(), () => Crear.TipoCambio(),
                I<TipoCambio>("CoeficienteCambio 0", "CoeficienteCambio", e => e.CoeficienteCambio = 0)),
            ["TipoDocumento"] = C(new ValidadorTipoDocumento(), () => Crear.TipoDocumento(), TipoConDescripcion<TipoDocumento>((e, v) => e.Nombre = v, (e, v) => e.Descripcion = v)),
            ["TipoEntidadReparadora"] = C(new ValidadorTipoEntidadReparadora(), () => Crear.TipoEntidadReparadora(), TipoConDescripcion<TipoEntidadReparadora>((e, v) => e.Nombre = v, (e, v) => e.Descripcion = v)),
            ["TipoFuenteEnergia"] = C(new ValidadorTipoFuenteEnergia(), () => Crear.TipoFuenteEnergia(), TipoConDescripcion<TipoFuenteEnergia>((e, v) => e.Nombre = v, (e, v) => e.Descripcion = v)),
            ["TipoTelefono"] = C(new ValidadorTipoTelefono(), () => Crear.TipoTelefono(), TipoConDescripcion<TipoTelefono>((e, v) => e.Nombre = v, (e, v) => e.Descripcion = v)),
            ["UbicacionPieza"] = C(new ValidadorUbicacionPieza(), () => Crear.UbicacionPieza()),
            ["Usuario"] = C(new ValidadorUsuario(), () => Crear.Usuario(), Persona<Usuario>()),
        };

        public static TheoryData<string> Validadores => new(casos.Keys.OrderBy(k => k));

        public static TheoryData<string, string> Invalidaciones
        {
            get
            {
                var data = new TheoryData<string, string>();
                foreach (var (validador, caso) in casos.OrderBy(c => c.Key))
                {
                    foreach (var invalidacion in caso.Invalidaciones)
                    {
                        data.Add(validador, invalidacion.Descripcion);
                    }
                }

                return data;
            }
        }

        private static FluentValidation.Results.ValidationResult Validar(Caso caso, object entidad) => caso.Validador.Validate(new ValidationContext<object>(entidad));

        [Theory]
        [MemberData(nameof(Validadores))]
        public void Validar_EntidadValida_NoTieneErrores(string validador)
        {
            var caso = casos[validador];

            var resultado = Validar(caso, caso.CrearValido());

            Assert.True(resultado.IsValid, string.Join("; ", resultado.Errors));
        }

        [Theory]
        [MemberData(nameof(Invalidaciones))]
        public void Validar_ReglaViolada_ReportaErrorEnLaPropiedad(string validador, string invalidacion)
        {
            var caso = casos[validador];
            var regla = caso.Invalidaciones.Single(i => i.Descripcion == invalidacion);
            var entidad = caso.CrearValido();
            regla.Aplicar(entidad);

            var resultado = Validar(caso, entidad);

            Assert.False(resultado.IsValid);
            Assert.Contains(resultado.Errors, e => e.PropertyName == regla.Propiedad);
        }

        [Fact]
        public void Validar_ServicioReparador_MismaFechaDeInicioYFin_EsValido()
        {
            var servicio = Crear.ServicioReparador();
            servicio.FechaFin = servicio.FechaInicio;

            Assert.True(new ValidadorServicioReparador().Validate(servicio).IsValid);
        }

        [Fact]
        public void Validar_Automovil_AnioFabricacion1891_EsValido()
        {
            var automovil = Crear.Automovil();
            automovil.AnioFabricacion = 1891;

            Assert.True(new ValidadorAutomovil().Validate(automovil).IsValid);
        }

        [Fact]
        public void Validar_TipoDocumento_DescripcionDe100CaracteresONull_EsValido()
        {
            Assert.True(new ValidadorTipoDocumento().Validate(new TipoDocumento { Nombre = "DNI", Descripcion = new string('x', 100) }).IsValid);
            Assert.True(new ValidadorTipoDocumento().Validate(new TipoDocumento { Nombre = "DNI" }).IsValid);
        }

        [Fact]
        public void Validar_Aceite_ViscosidadCero_EsValido()
        {
            var aceite = Crear.Aceite();
            aceite.ViscosidadSAEBajaTemperatura = 0;
            aceite.ViscosidadSAEAltaTemperatura = 0;

            Assert.True(new ValidadorAceite().Validate(aceite).IsValid);
        }
    }
}
