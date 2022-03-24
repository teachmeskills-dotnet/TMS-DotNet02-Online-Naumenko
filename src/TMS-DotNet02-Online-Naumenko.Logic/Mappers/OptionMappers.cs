using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class OptionMappers
    {
        public static IEnumerable<OptionDto> MapToDto(this IEnumerable<Option> options)
        {
            foreach (var option in options)
            {
                yield return new OptionDto
                {
                    Id = option.Id,
                    Name = option.Name,
                    Value = option.Value
                };
            }
        }
    }
}
