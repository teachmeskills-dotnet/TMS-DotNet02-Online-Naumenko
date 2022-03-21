using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface ITermService
    {
        Task<TermDto> GetTermByIdAsync();

        IEnumerable<TermDto> GetAllTerms();
    }
}
