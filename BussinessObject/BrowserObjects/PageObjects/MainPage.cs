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
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));

        private Button CreateProjectButton = new("sidebar-projects-add");

        private Button ContactTab = new(By.XPath("//*[@data-id='Contact']//span"));

        private static Logger logger = LogManager.GetCurrentClassLogger();

        [AllureStep]
        public MainPage OpenMainPage()
        {
            Browser.Instance.NavigateToUrl(startPage);
            logger.Info($"Navigate to url {startPage}");
            return this;
        }
        [AllureStep]
        public ProjectPage CreateProject(UserModel user)
        {
            CreateProjectButton.GetElement().Click();

            return new ProjectPage();
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
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