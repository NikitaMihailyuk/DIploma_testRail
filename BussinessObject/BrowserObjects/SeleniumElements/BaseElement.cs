using DIploma_testRail.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects.SeleniumElements
{
    public class BaseElement
    {
        protected IWebDriver WebDriver => Browser.Instance.Driver;
        public IWebElement GetElement() => WebDriver.FindElement(locator);
        protected By locator;

        public BaseElement(By locator)
        {
            this.locator = locator;
        }

        public BaseElement(string xpath)
        {
            locator = By.XPath(xpath);
        }

        public object ClickElementViaJs()
        {
            return Browser.Instance.ExecuteScript("arguments[0].click();", GetElement());
        }

    }
}
