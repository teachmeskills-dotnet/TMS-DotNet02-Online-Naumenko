using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public class PostRepository : Repository<Post>
    {
        private readonly DbSet<Post> _dbSet;
        private readonly DbContext _context;

        public PostRepository(MainContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Post>();
        }

        public IEnumerable<Post> GetAll(int userId)
        {
            return _dbSet.ToList();
        }
    }
}
