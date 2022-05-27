using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class FileMappers
    {
        public static FileDto MapToDto(this FileViewModel file)
        {
            return new FileDto
            {
                Id = file.Id,
                Date = file.Date,
                ModificationDate = file.ModificationDate,
                Name = file.Name,
                Slug = file.Slug,
                Path = file.Link,
                FileExtensionId = file.FileExtensionId,
                UserId = file.UserId
            };
        }

        public static IEnumerable<FileViewModel> MapToView(this IEnumerable<FileDto> files)
        {
            foreach (var file in files)
            {
                yield return new FileViewModel
                {
                    Id = file.Id,
                    Date = file.Date,
                    ModificationDate = file.ModificationDate,
                    Name = file.Name,
                    Slug = file.Slug,
                    Link = file.Path,
                    FileExtensionId = file.FileExtensionId,
                    UserId = file.UserId
                };
            }
        }

        public static FileViewModel MapToView(this FileDto file)
        {
            return new FileViewModel
            {
                Id = file.Id,
                Date = file.Date,
                ModificationDate = file.ModificationDate,
                Name = file.Name,
                Slug = file.Slug,
                Link = file.Path,
                FileExtensionId = file.FileExtensionId,
                UserId = file.UserId
            };
        }
    }
}
