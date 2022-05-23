using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class TermRepository : ITermRepository
    {
        private readonly DbSet<Term> _dbSet;
        private readonly DbContext _context;

        public TermRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Term>();
        }

        public async Task AddAsync(Term entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public IEnumerable<Term> Get(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public Term GetById(int id)
        {
            var isEmpty = _dbSet.Find(id);

            IQueryable<Term> terms;

            if (isEmpty != null)
            {
                terms = _dbSet.Where(term => term.Id == id);
            }
            else
            {
                terms = null;
            }

            return terms.FirstOrDefault();
        }

        public async Task<Term> GetEntityAsync(Expression<Func<Term, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Update(Term entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var isEmpty = _dbSet.Find(id);

            if (isEmpty != null)
            {
                _dbSet.Remove(isEmpty);
            }
        }

        public void DeleteRange(IEnumerable<Term> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        private IQueryable<Term> ApplyFilter(IQueryable<Term> filteredTerms, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredTerms = filteredTerms.Where(term => term.Name.Contains(filter.Title));
            }

            if (filter.UserId != null && filter.UserId != 0)
            {
                filteredTerms = filteredTerms.Where(term => term.UserId == filter.UserId);
            }

            return filteredTerms.AsNoTracking();
        }
    }
}
