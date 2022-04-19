using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces
{
    public interface IOptionRepository
    {
        IEnumerable<Option> GetAll();

        Task SaveChangesAsync();

        void Update(Option entity);
    }
}
