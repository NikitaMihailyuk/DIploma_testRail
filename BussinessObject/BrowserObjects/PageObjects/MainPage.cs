using BussinessObject.BrowserObjects.SeleniumElements;
using Core.Models;
using Core;
using NUnit.Allure.Attributes;
using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.BrowserObjects.PageObjects
{
    public class MainPage
    {
        private string startPage = "https://isthisnikita2.testrail.io/";


        private Button createProjectButton = new("sidebar-projects-add");
        private Button deleteProjectButton = new("Delete");
        private Button editeProjectButton = new(By.XPath("//*[text()='Edit']"));
        private Button testCaseButton = new("navigation-suites"); 


        private static Logger logger = LogManager.GetCurrentClassLogger();

        [AllureStep]
        public MainPage OpenMainPage()
        {
            Browser.Instance.NavigateToUrl(startPage);
            logger.Info($"Navigate to url {startPage}");
            return this;
        }
        [AllureStep]
        public ProjectPage OpenNewProjectPage()
        {
            createProjectButton.GetElement().Click();
            return new ProjectPage();
        }
        [AllureStep]
        public ProjectPage OpenEditProjectPage()
        {
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='project-3']//span/following-sibling::a")).Click();
            editeProjectButton.GetElement().Click();
            return new ProjectPage();
        }
        [AllureStep]
        public MainPage DeleteProject()
        {
            Browser.Instance.NavigateToUrl("https://isthisnikita2.testrail.io/index.php?/admin/projects/overview"); 
            Browser.Instance.Driver.FindElement(By.XPath("//tr[@class=\"even hoverSensitive\"]/following-sibling::tr[last()]//div[@class='icon-small-delete']")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='deleteDialog']//input")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='deleteDialog']//a")).Click();
            return new MainPage();
        }
        [AllureStep]
        public TestCasePage OpenTestCasePage()
        {
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='project-3']//span/following-sibling::a")).Click();
            testCaseButton.GetElement().Click(); 
            return new TestCasePage();
        }
    }
}