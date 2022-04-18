using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                TermsId = filter.TermIds,
            };
        }

        public static Filter MapDtoTo(this FilterDto filter)
        {
            return new Filter
            {
                Title = filter.Title,
                UserId = filter.UserId,
                TermIds = filter.TermsId,
            };
        }
    }
}
