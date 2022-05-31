using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly DbSet<Post> _dbSet;
        private readonly DbContext _context;
        private MainContext _mainContext;

        public PostRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Post>();
            _mainContext = context;
        }

        public async Task AddAsync(Post entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public IEnumerable<Post> Get(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public async Task<Post> GetByIdAsync(Expression<Func<Post, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Delete(int id)
        {
            var isEmpty = _dbSet.Find(id);

            if (isEmpty != null)
            {
                _dbSet.Remove(isEmpty);
            }
        }

        public void DeleteRange(IEnumerable<Post> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        private IEnumerable<Post> ApplyFilter(IQueryable<Post> filteredPosts, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredPosts = filteredPosts.Where(post => post.Title.Contains(filter.Title));
            }

            if (filter.UserId != null && filter.UserId != 0)
            {
                filteredPosts = filteredPosts.Where(post => post.UserId == filter.UserId);
            }

            if(filter.TermIds != null && filter.TermIds.Count > 0)
            {
                foreach (var termId in filter.TermIds)
                {
                    filteredPosts = filteredPosts
                        .Include(x => x.PostTerms)
                        .Where(post => post.PostTerms
                        .Select(postTerm => postTerm.TermId)
                        .Contains(termId));
                }
            }

            IEnumerable<Post> posts = filteredPosts.Include(table => table.User).Include(table => table.PostTerms).Include(table => table.File).ToList();
            
            return posts;
        }
    }
}
