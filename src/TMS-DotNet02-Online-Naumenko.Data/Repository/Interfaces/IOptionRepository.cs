using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IOptionRepository
    {
        IEnumerable<Option> GetAll(Filter filter);

        public Task<Option> GetEntityAsync(Expression<Func<Option, bool>> predicate);

        Task SaveChangesAsync();

        void Update(Option entity);
    }
}
