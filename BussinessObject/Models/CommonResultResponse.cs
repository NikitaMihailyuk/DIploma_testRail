using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.ApiObjects.Models
{
    internal class CommonResultResponse<T>
    {
        public bool Status { get; set; }
        public T Result { get; set; }
    }
}
