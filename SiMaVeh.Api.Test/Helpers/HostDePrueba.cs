using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OData.Edm;
using SiMaVeh.Api.Constants;
using SiMaVeh.Api.Contrato;
using SiMaVeh.Api.Contrato.Interfaces;
using SiMaVeh.Api.Extensions;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Utils;
using SiMaVeh.Api.Utils.Interfaces;
using SiMaVeh.Domain.BusinessLogic.Entities;
using System.Threading.Tasks;

namespace SiMaVeh.Api.Test.Helpers
{
    /// <summary>
    /// Host HTTP en memoria (TestServer) con la misma configuracion de MVC/OData que Startup, sin base de datos.
    /// Sirve para probar todo lo que no necesita repositorios: version, $metadata, contrato OpenAPI y Swagger UI.
    /// </summary>
    public static class HostDePrueba
    {
        public static async Task<IHost> CrearAsync()
        {
            var edmModel = new SiMaVehODataModelBuilder(new EntityTypeGetter()).GetEdmModel();

            return await new HostBuilder()
                .ConfigureWebHost(web => web
                    .UseTestServer()
                    .ConfigureServices(services =>
                    {
                        services.AddSingleton<IEdmModel>(edmModel);
                        services.AddSingleton<IInformacionVersion, InformacionVersion>();
                        services.AddSingleton<IGeneradorContratoOpenApi, GeneradorContratoOpenApi>();
                        services.AddControllers(o => o.EnableEndpointRouting = false)
                            .AddApplicationPart(typeof(Startup).Assembly)
                            //El MetadataController de OData vive en su propio ensamblado y hay que registrarlo para que $metadata responda.
                            .AddApplicationPart(typeof(Microsoft.AspNetCore.OData.Routing.Controllers.MetadataController).Assembly)
                            .AddOData(o => o.AddRouteComponents(UriConstants.PrefijoRutaOData, edmModel));
                    })
                    .Configure(app =>
                    {
                        app.ConfigurarSwaggerUI();
                        app.UseRouting();
                        app.UseEndpoints(e => e.MapControllers());
                    }))
                .StartAsync(TestContext.Current.CancellationToken);
        }
    }
}
