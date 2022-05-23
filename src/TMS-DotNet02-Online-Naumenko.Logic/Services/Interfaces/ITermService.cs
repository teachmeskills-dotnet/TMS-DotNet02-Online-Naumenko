using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface ITermService
    {
        Task Add(TermDto termDto);

        IEnumerable<TermDto> Get(FilterDto filterDto);

        TermDto GetById(int id);

        Task Update(TermDto termDto);

        void Delete(int id);
    }
}
