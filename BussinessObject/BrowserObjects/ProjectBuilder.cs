using Bogus;
using DIploma_testRail.BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects
{
    internal class ProjectBuilder
    {
        static Faker Faker = new();
        public CreateProjectModel CreateProject()
        {

            return new CreateProjectModel
            {
                Title = Faker.Name.JobTitle(),
                Description = Faker.Lorem.Text()

            };
        }
    }
}
