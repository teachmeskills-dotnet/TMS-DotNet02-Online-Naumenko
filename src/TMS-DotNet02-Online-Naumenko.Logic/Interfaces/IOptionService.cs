using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IOptionService
    {
        Task<IEnumerable<Option>> GetAllOptionAsync();
    }
}
