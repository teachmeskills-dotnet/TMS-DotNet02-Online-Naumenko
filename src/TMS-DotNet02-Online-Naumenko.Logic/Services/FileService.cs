using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class FileService : IFileService
    {
        private readonly IRepository<Data.Models.File> _fileRepository;

        public FileService(IRepository<Data.Models.File> fileRepository)
        {
            _fileRepository = fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
        }
        public IEnumerable<FileDto> GetAll()
        {
            return _fileRepository.GetAll().MapToDto();
        }
    }
}
