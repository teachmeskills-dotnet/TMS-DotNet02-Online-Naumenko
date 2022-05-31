using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IFileRepository
    {
        Task AddAsync(Models.File entity);

        IEnumerable<Models.File> Get(Filter filter);

        public Task<Models.File> GetByIdAsync(Expression<Func<Models.File, bool>> predicate);

        void Delete(int id);

        void DeleteRange(IEnumerable<Models.File> entity);

        Task SaveChangesAsync();
    }
}
