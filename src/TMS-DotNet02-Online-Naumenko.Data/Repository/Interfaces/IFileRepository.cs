using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IFileRepository
    {
        Task AddAsync(Models.File entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<Models.File> entity);

        IEnumerable<Models.File> GetAll(Filter filter);

        Task SaveChangesAsync();

        void Update(Models.File entity);

        public IQueryable<Models.File> ApplyFilter(IQueryable<Models.File> filteredFiles, Filter filter);
    }
}
