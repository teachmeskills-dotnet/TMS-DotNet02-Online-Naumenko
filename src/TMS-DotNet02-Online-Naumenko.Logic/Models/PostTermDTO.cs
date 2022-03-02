using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class PostTermDTO
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public PostDTO? Post { get; set; }

        public int TermId { get; set; }

        public TermDTO? Term { get; set; }
    }
}
