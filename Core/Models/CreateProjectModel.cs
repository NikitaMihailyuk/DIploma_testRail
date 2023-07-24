using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CreateProjectModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string announcement { get; set; }
        public bool show_announcement { get; set; }
        public int suite_mode { get; set; }
        public string group { get; set; }
    }
}
