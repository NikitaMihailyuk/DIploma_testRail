using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TestCase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Section_id { get; set; }
        public int Template_id { get; set; }
        public int Type_id { get; set; }
        public int Priority_id { get; set; }
        public string Estimate { get; set; }
        public string Milestone_id { get; set; }
        public string Refs { get; set; }
        public string Custom_preconds { get; set; }
        public string Custom_steps { get; set; }
        public string Custom_expected { get; set; }
        public Custom_steps_separated Custom_steps_separated { get; set;}
    }
}
