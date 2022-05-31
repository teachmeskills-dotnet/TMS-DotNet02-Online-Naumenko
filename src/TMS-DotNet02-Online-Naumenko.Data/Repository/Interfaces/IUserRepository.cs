using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User entity);

        IEnumerable<User> Get(Filter filter);

        public Task<User> GetByAsync(Expression<Func<User, bool>> predicate);

        void Delete(int id);

        void DeleteRange(IEnumerable<User> entity);

        Task SaveChangesAsync();
    }
}
