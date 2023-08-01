using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public override string? ToString()
        {
            return $"Name: {Name} Password:{Password}";
        }
    }
}
