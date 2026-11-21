using SiMaVeh.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SiMaVeh.DataAccess.Repository
{
    /// <summary>
    /// Repositorio generico de entidades de dominio.
    /// </summary>
    /// <typeparam name="TBe"></typeparam>
    /// <typeparam name="TBeId"></typeparam>
    public interface IRepository<TBe, TBeId> where TBe : DomainMember<TBeId>
    {
        /// <summary>
        /// Agrega una entidad y persiste los cambios.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Cantidad de registros afectados</returns>
        Task<int> AddAsync(TBe element);

        /// <summary>
        /// Obtiene la coleccion de entidades como IQueryable, para que OData aplique sus opciones de consulta.
        /// </summary>
        /// <returns></returns>
        IQueryable<TBe> GetQueryable();

        /// <summary>
        /// Busca una entidad por su key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>La entidad o null</returns>
        Task<TBe> FindAsync(TBeId key);

        /// <summary>
        /// Elimina una entidad y persiste los cambios.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Cantidad de registros afectados</returns>
        Task<int> RemoveAsync(TBe element);

        /// <summary>
        /// Actualiza los valores de una entidad existente y persiste los cambios.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Cantidad de registros afectados</returns>
        Task<int> UpdateAsync(TBe element);

        /// <summary>
        /// Persiste los cambios pendientes.
        /// </summary>
        /// <returns>Cantidad de registros afectados</returns>
        Task<int> SaveChangesAsync();
    }
}
