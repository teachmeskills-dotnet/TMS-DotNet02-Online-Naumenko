using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<User> entity);

        IEnumerable<User> GetAll(Filter filter);

        Task SaveChangesAsync();

        void Update(User entity);

        public IQueryable<User> ApplyFilter(IQueryable<User> filteredUsers, Filter filter);
    }
}
