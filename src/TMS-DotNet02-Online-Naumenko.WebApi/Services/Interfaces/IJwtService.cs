using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Services.Interfaces
{
    public interface IJwtService
    {
        Tokens Generate(LoginViewModel login);
    }
}
