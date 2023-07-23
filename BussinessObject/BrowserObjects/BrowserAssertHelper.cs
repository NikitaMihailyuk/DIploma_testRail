using DIploma_testRail.BussinessObject.Models;
using DIploma_testRail.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects
{
    public class BrowserAssertHelper
    {
        protected IWebDriver WebDriver => Browser.Instance.Driver;
        public void LoginErrorAssert()
        {
            string errorTopString = "Sorry, there was a problem.";
            string errorString = "Email/Login or Password is incorrect. Please try again.";
            string errorTop = WebDriver.FindElement(By.XPath("//*[@class='error-on-top']")).Text;
            string errorText = WebDriver.FindElement(By.XPath("//*[@class='error-text']")).Text;
            Assert.AreEqual(errorTopString, errorTop);
            Assert.AreEqual(errorString, errorText);
        }

        public void EditProjectAssert()
        {
            string succesMessage = "Successfully updated the project.";
            string message = WebDriver.FindElement(By.XPath("//*[@class='message message-success']")).Text;
            Assert.AreEqual(succesMessage, message);
        }

        public void CreateNewProjectAssert()
        {
            string succesMessage = "Successfully added the new project.";
            string message = WebDriver.FindElement(By.XPath("//*[@class='message message-success']")).Text;
            Assert.AreEqual(succesMessage, message);
        }

        public void DeleteProjectAssert()
        {
            string succesMessage = "Successfully deleted the project.";
            string message = WebDriver.FindElement(By.XPath("//*[@class='message message-success']")).Text;
            Assert.AreEqual(succesMessage, message);
        }
        
    }
}