using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IFileService
    {
        IEnumerable<FileDto> GetAll(FilterDto filter);

        Task AddFile(FileDto file);

        void DeleteFile(int id);

        Task UpdateFile(FileDto fileDto);
    }
}
