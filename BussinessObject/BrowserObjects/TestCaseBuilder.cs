﻿using Bogus;
using Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.BrowserObjects
{
    internal class TestCaseBuilder
    {
        private static Faker Faker = new();

        public TestCase TestCaseCreator()
        {
            return new TestCase
            {
                Title = Faker.Lorem.Word(),
                Type_id = 1,
                Template_id = 1,
                Priority_id = 1,
                Estimate = "60m",
                Milestone_id = "1",
                Custom_steps = Faker.Lorem.Text(),
                Custom_preconds = Faker.Lorem.Text(),
                Custom_steps_separated = new Custom_steps_separated { Content = Faker.Lorem.Text(), Expected = Faker.Lorem.Text() },
                Custom_expected = Faker.Lorem.Text()
            };
        }
    }
}
