using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IEnumerable<Term> GetAll(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Term entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<Term> ApplyFilter(IQueryable<Term> filteredTerms, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredTerms = filteredTerms.Where(term => term.Name.Contains(filter.Title));
            }

            if (filter.UserId != 0)
            {
                filteredTerms = filteredTerms.Where(term => term.UserId == filter.UserId);
            }

            return filteredTerms.AsNoTracking();
        }
    }
}
