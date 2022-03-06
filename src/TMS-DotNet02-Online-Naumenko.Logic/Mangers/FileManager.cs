using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mangers
{
    public class FileManager : IFileManager
    {
        private readonly IRepository<Data.Models.File> _fileRepository;
        private IQueryable<Data.Models.File> FileQuery =>
            _fileRepository.GetAll();

        public FileManager(IRepository<Data.Models.File> fileRepository)
        {
            _fileRepository = fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
        }

        public async Task<IEnumerable<FileDTO>> GetAllFilesAsync() => 
            GetFiles(await FileQuery.ToListAsync());

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

        private static IEnumerable<FileDTO> GetFiles(IEnumerable<Data.Models.File> files)
        {
            foreach (var file in files)
            {
                yield return new FileDTO
                {
                    Id = file.Id,
                    Name = file.Name,
                    Slug = file.Slug,
                    Link = file.Link,
                    FileExtensionId = file.FileExtensionId,
                    UserId = file.UserId,
                };
            }
        }
    }
}
