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

        public Task AddAsync(Term entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Term> entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Term> GetAll(int userId)
        {
            return _dbSet.Where(term => term.UserId == userId);
        }

        public IEnumerable<Term> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Term entity)
        {
            throw new NotImplementedException();
        }
    }
}
