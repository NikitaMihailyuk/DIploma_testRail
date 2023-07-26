using Allure.Commons;
using Core;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.BrowserObjects;

namespace UnitTests.UiTests
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.Fixtures)]
    public class BaseBrowserTest
    {
        private AllureLifecycle allure;

        [OneTimeSetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;

        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
                byte[] bytes = screenshot.AsByteArray;
                allure.AddAttachment("Screenshot", "image/png", bytes);
            }
            Browser.Instance.CloseBrowser();
        }
    }
}
