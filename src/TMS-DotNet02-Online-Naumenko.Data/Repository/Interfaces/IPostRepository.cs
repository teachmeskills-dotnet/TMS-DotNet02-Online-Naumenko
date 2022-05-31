using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IPostRepository
    {
        Task AddAsync(Post entity);

        IEnumerable<Post> Get(Filter filter);

        public Task<Post> GetByIdAsync(Expression<Func<Post, bool>> predicate);

        void Delete(int id);

        void DeleteRange(IEnumerable<Post> entity);

        Task SaveChangesAsync();
    }
}
