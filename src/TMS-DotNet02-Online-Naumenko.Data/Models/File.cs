using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class File
    {
        public int Id { get; set; }

        public int Author { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateModification { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Url { get; set; }

        public int PostParent { get; set; }
    }
}
