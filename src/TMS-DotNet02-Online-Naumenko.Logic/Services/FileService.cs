﻿using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
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

        public async Task Add(FileDto fileDto)
        {
            await _fileRepository.AddAsync(fileDto.MapToDomain());
            await _fileRepository.SaveChangesAsync();
        }

        public IEnumerable<FileDto> Get(FilterDto filterDto)
        {
            return _fileRepository.Get(filterDto.MapToDomain()).MapToDto();
        }

        public async Task<FileDto> GetById(int id)
        {
            return (await _fileRepository.GetByIdAsync(file => file.Id == id)).MapToDto();
        }

        public async Task Update(FileDto fileDto)
        {
            fileDto = fileDto ?? throw new ArgumentNullException(nameof(fileDto));

            var file = await _fileRepository.GetByIdAsync(file => file.Id == fileDto.Id);

            file.Date = fileDto.Date;
            file.ModificationDate = fileDto.ModificationDate;
            file.Name = fileDto.Name;
            file.Slug = fileDto.Slug;
            file.Path = fileDto.Path;
            file.FileExtensionId = fileDto.FileExtensionId;
            file.UserId = fileDto.UserId;

            await _fileRepository.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _fileRepository.Delete(id);
            _fileRepository.SaveChangesAsync();
        }
    } 
}
