using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class FileService : IFileService
    {
        public Task<int> AddFileAsync(FileDTO fileDto)
        {
            throw new NotImplementedException();
        }

        public Task<FileDTO> DeleteFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDTO>> GetAllFilesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDTO>> GetAllFilesByFileExtensionIdAsync(int fileExtensionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDTO>> GetAllFilesByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<FileDTO> GetFileByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FileDTO> UpdateFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}
