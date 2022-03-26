using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    internal class PostRepository : Repository<Post>
    {
        private readonly DbContext _context;
        private readonly DbSet<Post> _dbSet;

        public PostRepository(MainContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Post>();
        }

        public override IEnumerable<Post> GetAll()
        {
            var posts = _dbSet.Where(x => x.UserId == 1);
            return posts;
        }

        public override async Task AddAsync(Post post)
        {
            await _dbSet.AddAsync(post);
        }
    }
}
