using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface ITermService
    {
        IEnumerable<TermDto> GetAll(FilterDto filter);

        Task CreateTerm(TermDto term);

        void DeleteTerm(int id);

        Task UpdateTerm(TermDto termDto);
    }
}
