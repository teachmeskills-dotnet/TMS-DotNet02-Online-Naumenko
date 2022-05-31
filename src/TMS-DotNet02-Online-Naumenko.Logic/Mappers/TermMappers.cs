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

        public static TermDto MapToDto(this Term term)
        {
            return new TermDto
            {
                Id = term.Id,
                Name = term.Name,
                Slug = term.Slug,
                Parent = term.Parent,
                UserId = term.UserId,
                TermTypeId = term.TermTypeId
            };
        }

        public static Term MapToDomain(this TermDto term)
        {
            return new Term
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
