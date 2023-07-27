using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.BrowserObjects.SeleniumElements
{
  public class Input : BaseElement
    {
        public Input(By locator) : base(locator)
        {
        }

        public Input(string value) : base($"//*[@id='{value}']")
        {
        }
    }
}
