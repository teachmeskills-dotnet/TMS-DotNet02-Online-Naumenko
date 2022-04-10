using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FilterDto
    {
        public string Title { get; set; }

        public List<int> UserId { get; set; }

        public List<int> TermId { get; set; }
    }
}
