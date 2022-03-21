using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class TermService : ITermService
    {
        public Task<IEnumerable<TermDTO>> GetAllTermsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TermDTO> GetTermByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
