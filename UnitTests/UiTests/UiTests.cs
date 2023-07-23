using Allure.Commons;
using DIploma_testRail.BussinessObject.BrowserObjects.PageObjects;
using DIploma_testRail.BussinessObject;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIploma_testRail.BussinessObject.BrowserObjects;

namespace DIploma_testRail.UnitTests.UiTests
{
    public class SalesForceTests : BaseBrowserTest
    {
        [Test(Description = "Failed coz random")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-negative")]

        public void ErrorLogin()
        {
            var user = UserBuilder.GetRandomUser();
            new LoginPage()
                .OpenPage()
                .Login(user);

          browserAssertHelper.LoginErrorAssert();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        public void GoodLogin()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user);
        }


        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        public void CreateProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user).
                OpenNewProjectPage().
                CreateProjectType1();
            browserAssertHelper.CreateNewProjectAssert();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        public void EditProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage().
                Login(user).
                OpenEditProjectPage().EditProject();

            browserAssertHelper.EditProjectAssert();
        }
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("TestRail")]
        [AllureSubSuite("TestRail-possitive")]
        public void DeleteProject()
        {
            var user = UserBuilder.GetTestRailUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .DeleteProject();

            browserAssertHelper.DeleteProjectAssert();
        }

    }
}
