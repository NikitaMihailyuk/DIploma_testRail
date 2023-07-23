using DIploma_testRail.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace DIploma_testRail.Core
{
    public class Browser
    {
        private static readonly ThreadLocal<Browser> BrowserInstances = new();
        public static Browser Instance => GetBrowser();
        private IWebDriver driver;
        public IWebDriver? Driver { get { return driver; } }

        private static Browser GetBrowser()
        {
            return BrowserInstances.Value ?? (BrowserInstances.Value = new Browser());
        }

        private Browser()
        {
            driver = Configuration.Configuration.Browser.Type.ToLower() switch
            {
                "chrome" => DriverFactory.GetChromeDriver(),
                "firefox" => DriverFactory.GetFirefoxDriver(),
                _ => DriverFactory.GetChromeDriver()
            };

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Configuration.Configuration.Browser.TimeOut);
            driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            driver?.Dispose();
            BrowserInstances.Value = null;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void AcceptDismiss()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public void SwitchToFrame(string id)
        {
            driver.SwitchTo().Frame(id);
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void ContextClickToElement(IWebElement element)
        {
            new Actions(driver)
                .ContextClick(element)
                .Build()
                .Perform();
        }

        public object ExecuteScript(string scipt, object argument = null)
        {
            try
            {

                return ((IJavaScriptExecutor)driver).ExecuteScript(scipt, argument);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
