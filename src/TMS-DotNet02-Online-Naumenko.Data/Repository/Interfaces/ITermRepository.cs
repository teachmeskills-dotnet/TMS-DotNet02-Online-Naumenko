using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface ITermRepository
    {
        Task AddAsync(Term entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Term> entity);

        IEnumerable<Term> GetAll(Filter filter);

        public Task<Term> GetEntityAsync(Expression<Func<Term, bool>> predicate);

        Task SaveChangesAsync();

        void Update(Term entity);

        public IQueryable<Term> ApplyFilter(IQueryable<Term> filteredTerms, Filter filter);
    }
}
