﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class OptionRepository : IOptionRepository
    {
        private readonly DbSet<Option> _dbSet;
        private readonly DbContext _context;

        public OptionRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Option>();
        }

        public IEnumerable<Option> Get(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public async Task<Option> GetByIdAsync(Expression<Func<Option, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        private IEnumerable<Option> ApplyFilter(IQueryable<Option> filteredOptions, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredOptions = filteredOptions.Where(option => option.Name.Contains(filter.Title));
            }

            return filteredOptions.AsNoTracking().ToList();
        }
    }
}
