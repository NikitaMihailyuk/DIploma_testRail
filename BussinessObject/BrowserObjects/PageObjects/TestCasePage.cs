using BussinessObject.BrowserObjects.SeleniumElements;
using Core.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NLog;

namespace BussinessObject.BrowserObjects.PageObjects
{
    public class TestCasePage
    {

        private Button createTestCaseButton = new(By.XPath("//*[@id='sidebar-cases-add']"));
        private Input title = new("title");
        private Input custom_preconds_display = new ("custom_preconds_display");
        private Input custom_steps_display = new("custom_steps_display");
        private Input custom_expected_display = new("custom_expected_display");

        private Button saveButton = new("accept");
        TestCaseBuilder testCaseBuilder = new TestCaseBuilder();

        [AllureStep]
        public TestCasePage OpenTestCasePage()
        {
            return this;
        }

        [AllureStep]
        public void CreateTestCase()
        {
            createTestCaseButton.GetElement().Click();
            var testCaseData = testCaseBuilder.TestCaseCreator();
            title.GetElement().SendKeys(testCaseData.Title);
            custom_preconds_display.GetElement().SendKeys(testCaseData.Custom_preconds);
            custom_steps_display.GetElement().SendKeys(testCaseData.Custom_steps_separated.ToString());
            custom_expected_display.GetElement().SendKeys(testCaseData.Custom_expected);
            saveButton.GetElement().Click();    
        }
    }
}
