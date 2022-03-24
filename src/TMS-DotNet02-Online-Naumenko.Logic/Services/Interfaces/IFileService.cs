using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IFileService
    {
        IEnumerable<FileDto> GetAll();
    }
}
