using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IFileService
    {
        Task Add(FileDto fileDto);

        IEnumerable<FileDto> Get(FilterDto filterDto);

        Task<FileDto> GetById(int id);

        Task Update(FileDto fileDto);

        void Delete(int id);
    }
}
