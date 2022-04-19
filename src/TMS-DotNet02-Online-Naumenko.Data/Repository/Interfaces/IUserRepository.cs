using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<User> entity);

        IEnumerable<User> GetAll(Filter filter);

        public Task<User> GetEntityAsync(Expression<Func<User, bool>> predicate);

        Task SaveChangesAsync();

        void Update(User entity);

        public IQueryable<User> ApplyFilter(IQueryable<User> filteredUsers, Filter filter);
    }
}
