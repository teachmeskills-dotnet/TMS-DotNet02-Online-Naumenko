using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IFileRepository
    {
        IEnumerable<Models.File> GetAll();

        Task AddAsync(Models.File entity);

        void Update(Models.File entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Models.File> entity);

        Task SaveChangesAsync();
    }
}
