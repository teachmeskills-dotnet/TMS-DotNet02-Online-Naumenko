using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class OptionMappers
    {
        public static OptionDto MapToDto(this OptionViewModel option)
        {
            return new OptionDto
            {
                Id = option.Id,
                Name = option.Name,
                Value = option.Value
            };
        }

        public static IEnumerable<OptionViewModel> MapToView(this IEnumerable<OptionDto> options)
        {
            foreach (var option in options)
            {
                yield return new OptionViewModel
                {
                    Id = option.Id,
                    Name = option.Name,
                    Value = option.Value
                };
            }
        }
    }
}
