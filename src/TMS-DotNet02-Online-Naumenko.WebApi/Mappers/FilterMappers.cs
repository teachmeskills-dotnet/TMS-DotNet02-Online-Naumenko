using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class FilterMappers
    {
        public static FilterDto MapToDto(this FilterViewModel filter)
        {
            return new FilterDto
            {
                Title = filter.Title,
                UserId = filter.UserId,
                TermIds = filter.TermIds,
            };
        }

        public static FilterViewModel MapToView(this FilterDto filter)
        {
            return new FilterViewModel
            {
                Title = filter.Title,
                UserId = filter.UserId,
                TermIds = filter.TermIds,
            };
        }
    }
}
