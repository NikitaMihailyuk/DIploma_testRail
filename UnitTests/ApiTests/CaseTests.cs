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

    internal class CaseTests : BaseApiTest
    {

        protected TestCaseService caseService;


        [OneTimeSetUp]
        public void InitialService()
        {
            caseService = new TestCaseService();
        }

        [Test]
        public void GetRuns()
        {
            var offset = 1;

            var response = caseService.GetRuns(offset);
            Console.WriteLine(response.Content);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }


        [Test]
        public void InvalidToken()
        {
            var offset = 1;


            var response = caseService.GetAlltestRunsinvalid(offset);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
            Assert.That(response.StatusDescription, Is.EqualTo("Unauthorized"));
        }

        [Test]
        public void GetTestCase()
        {
           int testId = 2268;

            var response = caseService.GetTestCase(testId);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
            TestCase? testData = JsonConvert.DeserializeObject<TestCase>(response.Content);
            Assert.AreEqual(testId, testData.Id);
        }

         [Test]
        public void CreateTestCase()
        {
            int section_id = 185;
           

            var response = caseService.CreateTestCase(section_id);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
        }



        [Test]
        public void DeleteTestCase()
        {
            //  2271 and other
            int testCaseID = 2271;
            var response = caseService.DeleteTestCase(testCaseID);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
        }
        [Test]
        public void UpdateTestCase()
        {
            int testCaseID = 2271;
            var response = caseService.UpdateTestCase(testCaseID);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorException);
            Console.WriteLine(response.StatusCode);
        }
    }
}
