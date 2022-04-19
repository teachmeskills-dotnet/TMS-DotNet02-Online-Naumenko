using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class TermService : ITermService
    {
        private readonly ITermRepository _termRepository;

        public TermService(ITermRepository termRepository)
        {
            _termRepository = termRepository ?? throw new ArgumentNullException(nameof(termRepository));
        }

        public IEnumerable<TermDto> GetAll(FilterDto filter)
        {
            return _termRepository.GetAll(filter.MapDtoTo()).MapToDto();
        }

        public async Task CreateTerm(TermDto term)
        {
            await _termRepository.AddAsync(term.MapDtoTo());
            await _termRepository.SaveChangesAsync();
        }

        public void DeleteTerm(int id)
        {
            _termRepository.Delete(id);
            _termRepository.SaveChangesAsync();
        }

        public async Task UpdateTerm(TermDto termDto)
        {
            termDto = termDto ?? throw new ArgumentNullException(nameof(termDto));

            var term = await _termRepository.GetEntityAsync(post => post.Id == termDto.Id);

            term.Name = termDto.Name;
            term.Slug = termDto.Slug;
            term.Parent = termDto.Parent;

            await _termRepository.SaveChangesAsync();
        }
    }
}
