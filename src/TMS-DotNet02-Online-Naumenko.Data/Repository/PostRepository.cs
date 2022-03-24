using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    internal class PostRepository : Repository<Post>
    {
        private readonly DbContext _context;

        public PostRepository(MainContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Post> GetAll()
        {
            var posts = _context.Set<Post>().Where(x => x.UserId == 1);
            return posts;
        }
    }
}
