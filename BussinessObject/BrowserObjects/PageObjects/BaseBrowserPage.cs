using BussinessObject.BrowserObjects.SeleniumElements;
using Core;
using Core.Configuration;
using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.BrowserObjects.PageObjects
{
    public class BaseBrowserPage
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        private BaseElement messageModal = new(By.XPath("//*[@class='message message-success']"));
        private BaseElement messageErrorTopString = new(By.XPath("//*[@class='error-on-top']"));
        private BaseElement messageErrorText = new(By.XPath("//*[@class='error-text']"));
        private BaseElement userNameElement = new(By.XPath("//*[@class='navigation-username']"));

        public void LoginErrorAssert()
        {
            string errorTopString = DataHelper.commonErrorMessage;
            string errorString = DataHelper.errorInputLoginMessage;
            string errorTop = messageErrorTopString.GetElement().Text;
            string errorText = messageErrorText.GetElement().Text;
            Assert.AreEqual(errorTopString, errorTop);
            Assert.AreEqual(errorString, errorText);
        }

        public void AssertUserName()
        {
            var userName = Configuration.Account.ToString();
            string cuurentUserName = userNameElement.GetElement().Text;
            Assert.AreEqual(cuurentUserName, userName);
        }

        public void SuccesMessageAssert(string succesMessageText)
        {
            string message = messageModal.GetElement().Text;
            Assert.AreEqual(succesMessageText, message);
        }
    }
}
