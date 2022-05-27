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

        public async Task Add(TermDto termDto)
        {
            await _termRepository.AddAsync(termDto.MapToDomain());
            await _termRepository.SaveChangesAsync();
        }

        public IEnumerable<TermDto> Get(FilterDto filterDto)
        {
            return _termRepository.Get(filterDto.MapToDomain()).MapToDto();
        }

        public async Task<TermDto> GetById(int id)
        {
            return (await _termRepository.GetByIdAsync(term => term.Id == id)).MapToDto();
        }

        public async Task Update(TermDto termDto)
        {
            termDto = termDto ?? throw new ArgumentNullException(nameof(termDto));

            var term = await _termRepository.GetByIdAsync(post => post.Id == termDto.Id);

            term.Name = termDto.Name;
            term.Slug = termDto.Slug;
            term.Parent = termDto.Parent;

            await _termRepository.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _termRepository.Delete(id);
            _termRepository.SaveChangesAsync();
        }
    }
}
