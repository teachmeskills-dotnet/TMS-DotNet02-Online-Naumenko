using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
        }

        public IEnumerable<FileDto> GetAll(FilterDto filter)
        {
            return _fileRepository.GetAll(filter.MapDtoTo()).MapToDto();
        }

        public async Task AddFile(FileDto file)
        {
            await _fileRepository.AddAsync(file.MapDtoTo());
            await _fileRepository.SaveChangesAsync();
        }

        public void DeleteFile(int id)
        {
            _fileRepository.Delete(id);
            _fileRepository.SaveChangesAsync();
        }

        public async Task UpdateFile(FileDto fileDto)
        {
            fileDto = fileDto ?? throw new ArgumentNullException(nameof(fileDto));

            var file = await _fileRepository.GetEntityAsync(file => file.Id == fileDto.Id);

            file.Date = fileDto.Date;
            file.ModificationDate = fileDto.ModificationDate;
            file.Name = fileDto.Name;
            file.Slug = fileDto.Slug;

            await _fileRepository.SaveChangesAsync();
        }
    } 
}
