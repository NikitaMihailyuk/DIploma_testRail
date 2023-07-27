using OpenQA.Selenium;
using BussinessObject.BrowserObjects.SeleniumElements;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NLog;
using BussinessObject.BrowserObjects.PageObjects;


namespace BussinessObject.BrowserObjects.PageObjects
{
    public class LoginPage  : BaseBrowserPage
    {
        private Input userNameInput = new("name");
        private Input passwordInput = new("password");
        private Button loginButton = new("button_primary");
        private Button checkBoxButton = new(By.XPath("//*[@id='rememberme']/following-sibling::span"));

        [AllureStep]
        public LoginPage OpenPage()
        {
            var url = DataHelper.authUrl;
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