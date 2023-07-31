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
using Core;
using OpenQA.Selenium.Interactions;

namespace BussinessObject.BrowserObjects.PageObjects
{
    public class TestCasePage : BaseBrowserPage
    {
        TestCaseBuilder testCaseBuilder = new TestCaseBuilder();
        private Actions action = new Actions(Browser.Instance.Driver);

        private Button createTestCaseButton = new(By.XPath("//*[@id='sidebar-cases-add']"));
        private Button deleteTestCaseButton = new(By.XPath("//*[@class='deleteLink']"));
        private Button confirmationDeleteTestCaseButton = new(By.XPath("//div[@id='casesDeletionDialog']//a[contains(text(),'Delete Permanently')]"));
        private Button anotherConfirmaitonButton = new(By.XPath("//div[@id='casesDeletionConfirmationDialog']//a[contains(text(),'Delete Permanently')]"));
        private Input title = new("title");
        private Input custom_preconds_display = new("custom_preconds_display");
        private Input custom_steps_display = new("custom_steps_display");
        private Input custom_expected_display = new("custom_expected_display");
        private BaseElement testCaseElement = new(By.XPath("//*[@class='caseRow row odd caseDroppable ']"));
        private Button saveButton = new("accept");


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

        [AllureStep]
        public void DeleteTestCase()
        {
            action.MoveToElement(testCaseElement.GetElement()).Perform();
            deleteTestCaseButton.GetElement().Click();
            confirmationDeleteTestCaseButton.GetElement().Click();
            anotherConfirmaitonButton.GetElement().Click();
        }
    }
}
