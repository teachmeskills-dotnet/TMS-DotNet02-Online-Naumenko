using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class TermService : ITermService
    {
        private readonly IRepository<Term> _termRepository;

        public TermService(IRepository<Term> termRepository)
        {
            _termRepository = termRepository ?? throw new ArgumentNullException(nameof(termRepository));
        }

        public IEnumerable<TermDto> GetAllTerms()
        {
            return _termRepository.GetAll().MapToDto();
        }

        public Task<TermDto> GetTermByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
