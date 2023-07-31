using Allure.Commons;
using BussinessObject;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.BrowserObjects.PageObjects;

namespace UnitTests.UiTests
{
    public class UiTests : BaseBrowserTest
    {
        #region Project 
        [Test(Description = "Failed coz random")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-negative")]
        [Category("Smoke")]
        public void ErrorLogin()
        {
            var user = UserBuilder.GetRandomUser();
            new LoginPage()
                .OpenPage()
                .Login(user).LoginErrorAssert();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void GoodLogin()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .AssertUserName();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void CreateProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewProjectPage()
                .CreateProjectType1()
                .SuccesMessageAssert(DataHelper.succesCreateProjectMessage);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("Smoke")]
        public void EditProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenEditProjectPage()
                .EditProject()
                .SuccesMessageAssert(DataHelper.succesUpdateProjectMessage);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        [Category("ALL")]
        public void DeleteProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .DeleteProject()
                .SuccesMessageAssert(DataHelper.succesDeleteProjectMessage);
        }
        #endregion Project 
        #region Tests

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
            var user = UserBuilder.GetTestRailUser();
            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenTestCasePage()
                .CreateTestCase();
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
            var user = UserBuilder.GetTestRailUser();
            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenTestCasePage()
                .DeleteTestCase();
        }
        #endregion Tests 
    }
}
