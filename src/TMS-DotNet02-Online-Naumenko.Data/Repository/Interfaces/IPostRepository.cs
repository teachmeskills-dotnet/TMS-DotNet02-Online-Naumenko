using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IPostRepository
    {
        Task AddAsync(Post entity);

        IEnumerable<Post> Get(Filter filter);

        Post GetById(int id);

        public Task<Post> GetEntityAsync(Expression<Func<Post, bool>> predicate);

        void Update(Post entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Post> entity);

        Task SaveChangesAsync();
    }
}
