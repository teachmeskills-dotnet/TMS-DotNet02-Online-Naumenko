 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IFileManager
    {
        Task<FileDTO> GetFileByIdAsync();

        Task<IEnumerable<FileDTO>> GetAllFilesAsync();

        Task<IEnumerable<FileDTO>> GetAllFilesByFileExtensionIdAsync(int fileExtensionId);

        Task<IEnumerable<FileDTO>> GetAllFilesByUserIdAsync(int userId);
    }
}
