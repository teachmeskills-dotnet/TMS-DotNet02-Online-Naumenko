using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class TermMappers
    {
        public static IEnumerable<TermDto> MapToDto(this IEnumerable<Term> terms)
        {
            foreach (var term in terms)
            {
                yield return new TermDto
                {
                    Id = term.Id,
                    Name = term.Name,
                    Slug = term.Slug,
                    Parent = term.Parent,
                    UserId = term.UserId,
                    TermTypeId = term.TermTypeId
                };
            }
        }
    }
}
