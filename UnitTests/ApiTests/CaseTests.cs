using Bogus;
using BussinessObject.ApiObjects.Services;
using Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Newtonsoft.Json;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NLog;

namespace UnitTests.ApiTests
{

    internal class ApiTests : BaseApiTest
    {
        protected TestCaseService caseService;
        protected ProjectService projectService;
        Logger logger = LogManager.GetCurrentClassLogger();


        [OneTimeSetUp]
        public void InitialService()
        {
            caseService = new TestCaseService();
            projectService = new ProjectService();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void GetRuns()
        {
            var response = caseService.GetRuns(1);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-negative")]
        [Category("Smoke")]
        public void InvalidToken()
        {
            var response = caseService.GetAlltestRunsinvalid(1);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.That(response.StatusDescription, Is.EqualTo("Unauthorized"));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void GetTestCase()
        {
            int testId = 1;

            var response = caseService.GetTestCase(testId);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);

            TestCase? testData = JsonConvert.DeserializeObject<TestCase>(response.Content);
            Assert.AreEqual(testId, testData.Id);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void CreateTestCase()
        {
            int section_id = 1;

            var response = caseService.CreateTestCase(section_id);
            logger.Info(response.Content.ToString);
            logger.Info(response.Content.ToString);


            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("All")]
        public void DeleteTestCase()
        {
            //  2271 and other
            int testCaseID = 2271;
            var response = caseService.DeleteTestCase(testCaseID);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void UpdateTestCase()
        {
            int testCaseID = 1;
            var response = caseService.UpdateTestCase(testCaseID);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void GetProject()
        {
            int idProject = 1;
            var response = projectService.GetProject(idProject);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void GetProjects()
        {
            var response = projectService.GetProjects();
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void AddProjects()
        {
            var response = projectService.CreateProject();
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void UpdateProject()
        {
            int idProject = 27;
            var response = projectService.UpdateProject(idProject);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void DeleteProject()
        {
            int idProject = 7;
            var response = projectService.DeleteProject(idProject);
            logger.Info(response.Content.ToString);
            logger.Info(response.StatusCode.ToString);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }
    }
}
