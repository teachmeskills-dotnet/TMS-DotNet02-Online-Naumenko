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
        public Task<int> AddFileAsync(FileDto fileDto)
        {
            throw new NotImplementedException();
        }

        public Task<FileDto> DeleteFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDto>> GetAllFilesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDto>> GetAllFilesByFileExtensionIdAsync(int fileExtensionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileDto>> GetAllFilesByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<FileDto> GetFileByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FileDto> UpdateFileAsync(int fileId)
        {
            throw new NotImplementedException();
        }
    }
}
