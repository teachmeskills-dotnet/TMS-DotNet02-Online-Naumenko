using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface ITermRepository
    {
        Task AddAsync(Term entity);

        IEnumerable<Term> Get(Filter filter);

        public Task<Term> GetByIdAsync(Expression<Func<Term, bool>> predicate);

        void Delete(int id);

        void DeleteRange(IEnumerable<Term> entity);

        Task SaveChangesAsync();
    }
}
