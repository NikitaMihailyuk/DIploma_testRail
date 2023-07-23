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
                Title = Faker.Name.JobTitle(),
                Description = Faker.Lorem.Text()

            };
        }
    }
}
