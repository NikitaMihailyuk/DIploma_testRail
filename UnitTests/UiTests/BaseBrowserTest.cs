using Allure.Commons;
using DIploma_testRail.Core;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIploma_testRail.BussinessObject.BrowserObjects;

namespace DIploma_testRail.UnitTests.UiTests
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class BaseBrowserTest
    {
        private AllureLifecycle allure;
        public BrowserAssertHelper browserAssertHelper = new BrowserAssertHelper();

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
