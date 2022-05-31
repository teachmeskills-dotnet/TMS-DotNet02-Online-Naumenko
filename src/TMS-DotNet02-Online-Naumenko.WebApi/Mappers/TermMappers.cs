using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class TermMappers
    {
        public static TermDto MapToDto(this TermViewModel term)
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

        public static IEnumerable<TermViewModel> MapToView(this IEnumerable<TermDto> terms)
        {
            foreach (var term in terms)
            {
                yield return new TermViewModel
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

        public static TermViewModel MapToView(this TermDto term)
        {
            return new TermViewModel
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
