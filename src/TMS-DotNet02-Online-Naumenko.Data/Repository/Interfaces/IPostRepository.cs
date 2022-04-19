using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IPostRepository
    {
        Task AddAsync(Post entity);

        void Update(Post entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Post> entity);

        IEnumerable<Post> GetAll(Filter filter);

        public Task<Post> GetEntityAsync(Expression<Func<Post, bool>> predicate);

        Task SaveChangesAsync();

        public IQueryable<Post> ApplyFilter(IQueryable<Post>filteredPosts, Filter filter);
    }
}
