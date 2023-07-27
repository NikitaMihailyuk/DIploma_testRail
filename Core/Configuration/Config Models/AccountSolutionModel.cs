using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration.Config_Models
{
    public class AccountSolutionModel : IConfiguration
    {
        public string SectionName => "Account";
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string? ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
