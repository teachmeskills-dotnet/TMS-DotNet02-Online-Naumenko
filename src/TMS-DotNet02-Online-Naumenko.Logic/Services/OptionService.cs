using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class OptionService : IOptionService
    {
        private readonly IOptionRepository _optionRepository;

        public OptionService(IOptionRepository optionRepository)
        {
            _optionRepository = optionRepository ?? throw new ArgumentNullException(nameof(optionRepository));
        }

        public IEnumerable<OptionDto> GetAll(FilterDto filter)
        {
            return _optionRepository.GetAll(filter.MapDtoTo()).MapToDto();
        }

        public async Task UpdateOption(OptionDto optionDto)
        {
            optionDto = optionDto ?? throw new ArgumentNullException(nameof(optionDto));

            var option = await _optionRepository.GetEntityAsync(option => option.Id == optionDto.Id);

            option.Value = optionDto.Value;

            await _optionRepository.SaveChangesAsync();
        }
    }
}
