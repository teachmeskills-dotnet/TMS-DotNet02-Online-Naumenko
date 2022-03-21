using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IFileService
    {
        Task<int> AddFileAsync(FileDto fileDto);

        Task<FileDto> UpdateFileAsync(int fileId);

        Task<FileDto> DeleteFileAsync(int fileId);

        Task<FileDto> GetFileByIdAsync();

        Task<IEnumerable<FileDto>> GetAllFilesAsync();

        Task<IEnumerable<FileDto>> GetAllFilesByFileExtensionIdAsync(int fileExtensionId);
         
        Task<IEnumerable<FileDto>> GetAllFilesByUserIdAsync(int userId);
    }
}
