using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.Model.ConfiguradoresContext.Interfaces;

namespace SiMaVeh.DataAccess.Model.ConfiguradoresContext
{
    public class ConfiguradorPropiedadesCalculadas : IConfiguradorContext
    {
        public void Configurar(ModelBuilder builder)
        {
            //Configurar aqui los Ignore, en caso de ser necesarios, para que el LazyLoading 
            //ignore las propiedades calculadas y no tire excepcion al notar que no tienen setter.
            //Ejemplo:
            //builder.Entity<CategoriaMarca>().Ignore(c => c.Marcas);
        }
    }
}
