using Bogus;
using BussinessObject.ApiObjects.Services;
using Core;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Newtonsoft.Json;

namespace UnitTests.ApiTests
{

    internal class ApiTests : BaseApiTest
    {

        protected TestCaseService caseService;
        protected ProjectService projectService;

        [OneTimeSetUp]
        public void InitialService()
        {
            caseService = new TestCaseService();
            projectService = new ProjectService();
        }

        [Test]
        public void GetRuns()
        {
            var response = caseService.GetRuns(1);
            Console.WriteLine(response.Content);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }


        [Test]
        public void InvalidToken()
        {
            var response = caseService.GetAlltestRunsinvalid(1);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
            Assert.That(response.StatusDescription, Is.EqualTo("Unauthorized"));
        }

        [Test]
        public void GetTestCase()
        {
            int testId = 2287;

            var response = caseService.GetTestCase(testId);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            TestCase? testData = JsonConvert.DeserializeObject<TestCase>(response.Content);
            Assert.AreEqual(testId, testData.Id);
        }

        [Test]
        public void CreateTestCase()
        {
            int section_id = 186;


            var response = caseService.CreateTestCase(section_id);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }



        [Test]
        public void DeleteTestCase()
        {
            //  2271 and other
            int testCaseID = 2271;
            var response = caseService.DeleteTestCase(testCaseID);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }
        [Test]
        public void UpdateTestCase()
        {
            int testCaseID = 2287;
            var response = caseService.UpdateTestCase(testCaseID);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void GetProject()
        {
            int idProject = 1;
            var response = projectService.GetProject(idProject);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void GetProjects()
        {
            var response = projectService.GetProjects();
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void AddProjects()
        {
            var response = projectService.CreateProject();
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void UpdateProject()
        {
            int idProject = 8;
            var response = projectService.UpdateProject(idProject);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }
        [Test]
        public void DeleteProject()
        {
            int idProject = 7;
            var response = projectService.DeleteProject(idProject);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

    }
}
