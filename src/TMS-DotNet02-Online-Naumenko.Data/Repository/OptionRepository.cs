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
    public class OptionRepository : IOptionRepository
    {
        private readonly DbSet<Option> _dbSet;
        private readonly DbContext _context;

        public OptionRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Option>();
        }

        public IEnumerable<Option> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Option entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
