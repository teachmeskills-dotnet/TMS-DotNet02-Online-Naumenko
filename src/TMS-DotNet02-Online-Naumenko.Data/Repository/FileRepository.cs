using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
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

        public async Task AddAsync(Models.File entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public IEnumerable<Models.File> Get(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public Models.File GetById(int id)
        {
            var isEmpty = _dbSet.Find(id);

            IQueryable<Models.File> files;

            if (isEmpty != null)
            {
                files = _dbSet.Where(file => file.Id == id);
            }
            else
            {
                files = null;
            }

            return files.FirstOrDefault();
        }

        public async Task<Models.File> GetEntityAsync(Expression<Func<Models.File, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Update(Models.File entity)
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

        public void DeleteRange(IEnumerable<Models.File> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        private IQueryable<Models.File> ApplyFilter(IQueryable<Models.File> filteredFiles, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredFiles = filteredFiles.Where(file => file.Name.Contains(filter.Title));
            }

            if (filter.UserId != null && filter.UserId != 0)
            {
                filteredFiles = filteredFiles.Where(file => file.UserId == filter.UserId);
            }

            return filteredFiles.AsNoTracking();
        }
    }
}
