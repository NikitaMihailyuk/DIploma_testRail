using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DIploma_testRail.Core.Configuration
{
    internal interface IConfiguration
    {
        string SectionName { get; }
    }
}
