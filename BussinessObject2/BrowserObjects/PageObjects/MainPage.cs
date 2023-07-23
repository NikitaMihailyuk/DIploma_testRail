using DIploma_testRail.BussinessObject.BrowserObjects.SeleniumElements;
using DIploma_testRail.BussinessObject.Models;
using DIploma_testRail.Core;
using NUnit.Allure.Attributes;
using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects.PageObjects
{
    public class MainPage
    {
        private string startPage = "https://isthisnikita2.testrail.io/";


        private Button createProjectButton = new("sidebar-projects-add");
        private Button deleteProjectButton = new("Delete");
        private Button editeProjectButton = new(By.XPath("//*[text()='Edit']"));


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
        public ProjectPage OpenEditProjectPage()
        {
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='project-3']//span/following-sibling::a")).Click();
            editeProjectButton.GetElement().Click();
            return new ProjectPage();
        }

        public MainPage DeleteProject()
        {
            Browser.Instance.NavigateToUrl("https://isthisnikita2.testrail.io/index.php?/admin/projects/overview"); 
            Browser.Instance.Driver.FindElement(By.XPath("//tr[@class=\"even hoverSensitive\"]/following-sibling::tr[last()]//div[@class='icon-small-delete']")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='deleteDialog']//input")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//*[@id='deleteDialog']//a")).Click();
            return new MainPage();
        }
    }
}

/*   public NewContactModal OpenNewContactModal()
      {
          Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
          var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));

          ContactTab.ClickElementViaJs();
          new Button(By.XPath("//div[@title='New']")).GetElement().Click();

          return new NewContactModal();
      }

       /////*[@id="project-2"]//span/following-sibling::a
        ///
    public EditContactModal OpenExistingContactModal()
      {
          Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
          var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));
          DropDownMainPage DropDownNumber = new("1");
          logger.Warn("warn");
          logger.Debug("debug");
          logger.Error("-error");
          logger.Fatal("Fatal");
          DropDownNumber.Select("Edit");
          return new EditContactModal();
      }

      public void DeleteContact()
      {
          Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
          var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));
          DropDownMainPage DropDownNumber = new("1");
          DropDownNumber.Select("Delete");
          new Button(By.XPath("//*[@title='Delete']")).GetElement().Click();

      }

      [AllureStep]
      public EditAccountModal OpenExistingAccountModal()
      {
          Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
          var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Account']//span"));
          DropDownMainPage DropDownNumber = new("1");
          DropDownNumber.Select("Edit");
          return new EditAccountModal();
      }
      [AllureStep]
      public void DeleteAccount()
      {
          Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
          var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Account']//span"));
          DropDownMainPage DropDownNumber = new("1");
          DropDownNumber.Select("Delete");
          new Button(By.XPath("//*[@title='Delete']")).GetElement().Click();
      } */