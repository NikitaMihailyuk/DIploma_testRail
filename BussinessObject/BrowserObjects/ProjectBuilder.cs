using Bogus;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.BrowserObjects
{
    internal class ProjectBuilder
    {
        static Faker Faker = new();
        public CreateProjectModel CreateProject()
        {

            return new CreateProjectModel
            {
                name = Faker.Name.JobTitle(),
                announcement = Faker.Lorem.Text(),
                suite_mode = 1,
                group = "1"
            };
        }
    }
}
