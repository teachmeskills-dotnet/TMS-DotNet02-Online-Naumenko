using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IOptionRepository
    {
        IEnumerable<Option> Get(Filter filter);

        public Task<Option> GetByIdAsync(Expression<Func<Option, bool>> predicate);

        Task SaveChangesAsync();
    }
}
