using OpenQA.Selenium;
using DIploma_testRail.BussinessObject.BrowserObjects.SeleniumElements;
using DIploma_testRail.BussinessObject.Models;
using DIploma_testRail.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NLog;
using DIploma_testRail.BussinessObject.BrowserObjects.PageObjects;

using static System.Net.WebRequestMethods;

namespace DIploma_testRail.BussinessObject.BrowserObjects.PageObjects
{
    public class LoginPage
    {
        private Input userNameInput = new("name");
        private Input passwordInput = new("password");
        private Button loginButton = new("button_primary");
        private Button checkBoxButton = new(By.XPath("//*[@id='rememberme']/following-sibling::span"));


        private static Logger logger = LogManager.GetCurrentClassLogger();

        [AllureStep]
        public LoginPage OpenPage()
        {
            var url = "https://isthisnikita2.testrail.io/index.php?/auth/login/";
            Browser.Instance.NavigateToUrl(url);
            logger.Info($"Navigate to url {url}");
            return this;
        }
        [AllureStep]
        public MainPage Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            checkBoxButton.GetElement().Click();
            loginButton.GetElement().Click();
            logger.Info($" try to login user: {user.Name}");
            return new MainPage();
        } 
    }
}