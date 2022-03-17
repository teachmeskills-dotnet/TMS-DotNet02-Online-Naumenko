using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IFileService
    {
        Task<int> AddFileAsync(FileDTO fileDto);

        Task<FileDTO> UpdateFileAsync(int fileId);

        Task<FileDTO> DeleteFileAsync(int fileId);

        Task<FileDTO> GetFileByIdAsync();

        Task<IEnumerable<FileDTO>> GetAllFilesAsync();

        Task<IEnumerable<FileDTO>> GetAllFilesByFileExtensionIdAsync(int fileExtensionId);
         
        Task<IEnumerable<FileDTO>> GetAllFilesByUserIdAsync(int userId);
    }
}
