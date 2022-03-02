using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IOptionManager
    {
        Task<IEnumerable<Option>> GetAllOptionAsync();
    }
}
