using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.ApiObjects.Models
{
    internal class Project
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public Counts Counts { get; set; }
    }
}
