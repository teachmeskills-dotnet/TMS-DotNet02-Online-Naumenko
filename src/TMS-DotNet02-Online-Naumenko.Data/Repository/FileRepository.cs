using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class FileRepository : IFileRepository
    {
        private readonly DbSet<Models.File> _dbSet;
        private readonly DbContext _context;

        public FileRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Models.File>();
        }

        public Task AddAsync(Models.File entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Models.File> entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.File> GetAll(int userId)
        {
            return _dbSet.Where(post => post.UserId == userId);
        }

        public IEnumerable<Models.File> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Models.File entity)
        {
            throw new NotImplementedException();
        }
    }
}
