using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects.SeleniumElements
{
    internal class ProjectRadioButton : BaseElement
    {

        public ProjectRadioButton(By locator) : base(locator)
        {
        }

        public ProjectRadioButton(string locator) : base($"//input[@id='{locator}']")
        {
        }

        public void Select(string option)
        {
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(By.XPath($"//*[@title='{option}']")).Click();
        }

    }
}
