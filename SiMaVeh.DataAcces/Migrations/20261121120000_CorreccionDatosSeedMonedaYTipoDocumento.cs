using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SiMaVeh.DataAccess.Model;

namespace SiMaVeh.DataAccess.Migrations
{
    /// <summary>
    /// Corrige dos datos de seed:
    /// - El codigo ISO del Bolivar Soberano estaba cargado como "VES7" seguido de un espacio de ancho cero (U+200B).
    ///   Como el codigo es la clave primaria de Monedas, se inserta "VES", se redirigen las claves foraneas
    ///   que referencian a la moneda y recien despues se elimina el codigo invalido.
    /// - La descripcion del tipo de documento DNI superaba los 100 caracteres que admite ValidadorTipoDocumento.
    /// </summary>
    /// <remarks>
    /// Migracion escrita a mano (SQL de MySQL): una migracion autogenerada incluiria ademas cambios de
    /// anotaciones pendientes desde la actualizacion de EF Core 5 a 8, ajenos a esta correccion.
    /// No tiene BuildTargetModel porque solo ejecuta SQL; el snapshot del modelo se actualizo a mano.
    /// </remarks>
    [DbContext(typeof(SiMaVehContext))]
    [Migration("20261121120000_CorreccionDatosSeedMonedaYTipoDocumento")]
    public partial class CorreccionDatosSeedMonedaYTipoDocumento : Migration
    {
        private const string CodigoInvalido = "VES7​";
        private const string CodigoCorrecto = "VES";
        private const string NombreMoneda = "Bolívar Soberano";

        private const long IdTipoDocumentoDNI = 1;
        private const string DescripcionDNIAnterior = "Documento nacional de identidad manual o digital (formato tarjeta o credencial virtual para dispositivos móviles)";
        private const string DescripcionDNINueva = "Documento nacional de identidad (tarjeta física o credencial digital en dispositivos móviles)";

        //Columnas que referencian a Monedas.Id
        private static readonly (string Tabla, string Columna)[] referenciasAMoneda =
        [
            ("Mantenimientos", "MonedaMontoRecambioId"),
            ("ServiciosReparadores", "MonedaMontoManoObraId"),
            ("TiposCambio", "MonedaOrigenId"),
            ("TiposCambio", "MonedaDestinoId"),
        ];

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ReemplazarCodigoMoneda(migrationBuilder, CodigoInvalido, CodigoCorrecto);
            ActualizarDescripcionDNI(migrationBuilder, DescripcionDNINueva);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            ReemplazarCodigoMoneda(migrationBuilder, CodigoCorrecto, CodigoInvalido);
            ActualizarDescripcionDNI(migrationBuilder, DescripcionDNIAnterior);
        }

        private static void ReemplazarCodigoMoneda(MigrationBuilder migrationBuilder, string codigoActual, string codigoNuevo)
        {
            migrationBuilder.Sql($"INSERT INTO `Monedas` (`Id`, `Nombre`) VALUES ('{codigoNuevo}', '{NombreMoneda}');");

            foreach (var (tabla, columna) in referenciasAMoneda)
            {
                migrationBuilder.Sql($"UPDATE `{tabla}` SET `{columna}` = '{codigoNuevo}' WHERE `{columna}` = '{codigoActual}';");
            }

            migrationBuilder.Sql($"DELETE FROM `Monedas` WHERE `Id` = '{codigoActual}';");
        }

        private static void ActualizarDescripcionDNI(MigrationBuilder migrationBuilder, string descripcion)
        {
            migrationBuilder.Sql($"UPDATE `TiposDocumento` SET `Descripcion` = '{descripcion}' WHERE `Id` = {IdTipoDocumentoDNI};");
        }
    }
}
