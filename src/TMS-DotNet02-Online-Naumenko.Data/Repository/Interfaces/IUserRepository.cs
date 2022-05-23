using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User entity);

        IEnumerable<User> Get(Filter filter);

        User GetById(int id);

        public Task<User> GetEntityAsync(Expression<Func<User, bool>> predicate);

        void Update(User entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<User> entity);

        Task SaveChangesAsync();
    }
}
