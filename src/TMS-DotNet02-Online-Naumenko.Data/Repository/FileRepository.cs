using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Models.File> GetAll(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Models.File entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<Models.File> ApplyFilter(IQueryable<Models.File> filteredFiles, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredFiles = filteredFiles.Where(file => file.Name.Contains(filter.Title));
            }

            if (filter.UserId != 0)
            {
                filteredFiles = filteredFiles.Where(file => file.UserId == filter.UserId);
            }

            return filteredFiles.AsNoTracking();
        }
    }
}
