using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.DataAccess.Test.Helpers;
using SiMaVeh.Domain.Models;
using System.Linq;

namespace SiMaVeh.DataAccess.Test.Model
{
    /// <summary>
    /// Migracion manual que corrige los datos de seed (codigo de moneda VES y descripcion del DNI).
    /// El script se genera con el proveedor MySQL sin conectarse a ninguna base.
    /// </summary>
    public class MigracionesTests(ModeloMySql modelo) : IClassFixture<ModeloMySql>
    {
        private const string MigracionAnterior = "20201116200021_InitialDataSeed";
        private const string MigracionCorreccion = "20261121120000_CorreccionDatosSeedMonedaYTipoDocumento";
        private const string CodigoInvalido = "VES7​";

        private readonly SiMaVehContext contexto = modelo.Get<SiMaVehContext>();

        [Fact]
        public void MigracionDeCorreccion_EsLaUltimaRegistrada()
        {
            Assert.Equal(MigracionCorreccion, contexto.Database.GetMigrations().Last());
        }

        [Fact]
        public void Up_InsertaVESRedirigeLasReferenciasYBorraElCodigoInvalido()
        {
            var script = contexto.GetService<IMigrator>().GenerateScript(MigracionAnterior, MigracionCorreccion);

            var insert = script.IndexOf("INSERT INTO `Monedas` (`Id`, `Nombre`) VALUES ('VES', 'Bolívar Soberano');");
            var delete = script.IndexOf($"DELETE FROM `Monedas` WHERE `Id` = '{CodigoInvalido}';");
            Assert.True(insert >= 0, script);
            Assert.True(delete > insert, "El codigo invalido se debe borrar despues de insertar el nuevo y redirigir las referencias");
            Assert.Contains($"UPDATE `Mantenimientos` SET `MonedaMontoRecambioId` = 'VES' WHERE `MonedaMontoRecambioId` = '{CodigoInvalido}';", script);
            Assert.Contains($"UPDATE `ServiciosReparadores` SET `MonedaMontoManoObraId` = 'VES' WHERE `MonedaMontoManoObraId` = '{CodigoInvalido}';", script);
            Assert.Contains($"UPDATE `TiposCambio` SET `MonedaOrigenId` = 'VES' WHERE `MonedaOrigenId` = '{CodigoInvalido}';", script);
            Assert.Contains($"UPDATE `TiposCambio` SET `MonedaDestinoId` = 'VES' WHERE `MonedaDestinoId` = '{CodigoInvalido}';", script);
            Assert.Contains("UPDATE `TiposDocumento` SET `Descripcion` = 'Documento nacional de identidad (tarjeta física o credencial digital en dispositivos móviles)' WHERE `Id` = 1;", script);
        }

        [Fact]
        public void Down_RestauraLosDatosAnteriores()
        {
            var script = contexto.GetService<IMigrator>().GenerateScript(MigracionCorreccion, MigracionAnterior);

            Assert.Contains($"INSERT INTO `Monedas` (`Id`, `Nombre`) VALUES ('{CodigoInvalido}', 'Bolívar Soberano');", script);
            Assert.Contains($"UPDATE `TiposCambio` SET `MonedaOrigenId` = '{CodigoInvalido}' WHERE `MonedaOrigenId` = 'VES';", script);
            Assert.Contains("DELETE FROM `Monedas` WHERE `Id` = 'VES';", script);
            Assert.Contains("Documento nacional de identidad manual o digital (formato tarjeta o credencial virtual para dispositivos móviles)", script);
        }

        [Fact]
        public void Seed_UsaLosDatosCorregidos()
        {
            var monedas = modelo.Model.FindEntityType(typeof(Moneda)).GetSeedData().Select(s => (string)s["Id"]).ToList();
            var dni = modelo.Model.FindEntityType(typeof(TipoDocumento)).GetSeedData().Single(s => (string)s["Nombre"] == "DNI");

            Assert.Contains("VES", monedas);
            Assert.DoesNotContain(CodigoInvalido, monedas);
            Assert.True(((string)dni["Descripcion"]).Length <= 100);
        }
    }
}
