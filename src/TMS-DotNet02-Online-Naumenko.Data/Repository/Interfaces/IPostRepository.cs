using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll(Filter filter);

        Task AddAsync(Post entity);

        void Update(Post entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Post> entity);

        Task SaveChangesAsync();

        public IQueryable<Post> ApplyFilter(IQueryable<Post>filteredPosts, Filter filter);
    }
}
