using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class FilterMappers
    {
        public static FilterDto MapToDto(this Filter filter)
        {
            return new FilterDto
            {
                Title = filter.Title,
                UserId = filter.UserId,
                TermIds = filter.TermIds,
            };
        }

        public static Filter MapToDomain(this FilterDto filter)
        {
            return new Filter
            {
                Title = filter.Title,
                UserId = filter.UserId,
                TermIds = filter.TermIds,
            };
        }
    }
}
