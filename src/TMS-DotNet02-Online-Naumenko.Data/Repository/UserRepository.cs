using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbSet<User> _dbSet;
        private readonly DbContext _context;

        public UserRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<User>();
        }

        public async Task AddAsync(User entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public IEnumerable<User> Get(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public User GetById(int id)
        {
            var isEmpty = _dbSet.Find(id);

            IQueryable<User> users;

            if (isEmpty != null)
            {
                users = _dbSet.Where(user => user.Id == id);
            }
            else
            {
                users = null;
            }

            return users.FirstOrDefault();
        }

        public async Task<User> GetEntityAsync(Expression<Func<User, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Update(User entity)
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

        public void DeleteRange(IEnumerable<User> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        private IQueryable<User> ApplyFilter(IQueryable<User> filteredUsers, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredUsers = filteredUsers.Where(user => user.Name.Contains(filter.Title));
            }

            return filteredUsers.AsNoTracking();
        }
    }
}
