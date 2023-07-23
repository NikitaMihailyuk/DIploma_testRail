using Bogus;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;

namespace BussinessObject
{
    public class UserBuilder
    {
        static Faker Faker = new();


        public static UserModel GetTestRailUser()
        {
            return new UserModel
            {
             Name = Configuration.Browser.ListOfUsers[0].Name,
             Password = Configuration.Browser.ListOfUsers[0].Password
            };
        }

        public static UserModel GetStandartUserWithoutName()
        {
            return new UserModel
            {
                Name = " ",
                Password = TestContext.Parameters.Get("StandartUserPassword"),
            };

        }

        public static UserModel GetRandomUser()
        {
            return new UserModel
            {
                Name = Faker.Internet.Email(),
                Password = Faker.Internet.Password(),
            };

        }

        public static UserModel GetRandomUserWithPassword(string password) => new()
        {
            Name = Faker.Name.FullName(),
            Password = password,
        };


    }
}