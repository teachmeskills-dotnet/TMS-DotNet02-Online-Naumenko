using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class FileMappers
    {
        public static IEnumerable<FileDto> MapToDto(this IEnumerable<Data.Models.File> files)
        {
            foreach (var file in files)
            {
                yield return new FileDto
                {
                    Id = file.Id,
                    Date = file.Date,
                    ModificationDate = file.ModificationDate,
                    Name = file.Name,
                    Slug = file.Slug,
                    Link = file.Link,
                    FileExtensionId = file.FileExtensionId,
                    UserId = file.UserId
                };
            }
        }

        public static Data.Models.File MapDtoTo(this FileDto file)
        {
            return new Data.Models.File
            {
                Id = file.Id,
                Date = file.Date,
                ModificationDate = file.ModificationDate,
                Name = file.Name,
                Slug = file.Slug,
                Link = file.Link,
                FileExtensionId = file.FileExtensionId,
                UserId = file.UserId
            };
        }
    }
}
