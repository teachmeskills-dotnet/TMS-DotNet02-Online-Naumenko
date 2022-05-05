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
        private readonly MainContext db;
        
        public PostRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<Post>();
            db = context;
        }

        public async Task AddAsync(Post entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(int id)
        {
            var isEmpty = _dbSet.Find(id);

            if (isEmpty != null) {
                _dbSet.Remove(isEmpty);
            }
        }

        public void DeleteRange(IEnumerable<Post> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public IEnumerable<Post> GetAll(Filter filter)
        {
            return ApplyFilter(_dbSet, filter);
        }

        public async Task<Post> GetEntityAsync(Expression<Func<Post, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Post entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<Post> ApplyFilter(IQueryable<Post> filteredPosts, Filter filter)
        {
            if (filter.Title != null)
            {
                filteredPosts = filteredPosts.Where(post => post.Title.Contains(filter.Title));
            }

            if (filter.UserId != null)
            {
                filteredPosts = filteredPosts.Where(post => post.UserId == filter.UserId);
            }

            if(filter.TermIds != null)
            {
                //filteredPosts = db.Posts.Include(p => p.PostTerms).Where(postTerm => filter.TermIds.All(postTerm.PostTerms.Select(term => term)));

                //var tags = filteredPosts.Include(x => x.PostTerms).Where(post => post.PostTerms.All(term => term.TermId == 4));

                //var tags = filteredPosts.Include(x => x.PostTerms).Where(post => post.PostTerms.Select(postTerm => postTerm.TermId).Contains(4));

                foreach (var termId in filter.TermIds)
                {
                    filteredPosts = filteredPosts.Include(x => x.PostTerms).Where(post => post.PostTerms.Select(postTerm => postTerm.TermId).Contains(termId));
                }

                //filteredPosts = filteredPosts.Where(post => post.PostTerms.All(term => filter.TermIds.Contains(term.TermId)));

                /*filteredPosts = filteredPosts
                .Where(post => filter.TermIds
                .All(term => post.PostTerms
                .Select(postTerm => postTerm.TermId)
                .Contains(term)));*/
                /*filteredPosts = filteredPosts
                    .Include(post => post.PostTerms)
                    .Where(post => filter.TermIds
                    .All(postTerm => post.PostTerms
                    .Select(term => term.TermId)
                    .Contains(postTerm)));*/
            }

            return filteredPosts.AsNoTracking();
        }
    }
}
