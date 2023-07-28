using BussinessObject.BrowserObjects.SeleniumElements;
using Core.Models;
using Core;
using NUnit.Allure.Attributes;
using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;
using NLog.Fluent;

namespace BussinessObject.BrowserObjects.PageObjects; 

public class MainPage : BaseBrowserPage
{
    private string startPage = Configuration.Api.BaseUrl;

    private Button createProjectButton = new("sidebar-projects-add");
    private Button deleteProjectButton = new("Delete");
    private Button editeProjectButton = new(By.XPath("//*[text()='Edit']"));
    private Button testCaseButton = new("navigation-suites");
    private BaseElement projectForUpdate = new(By.XPath("//*[@id='project-24']//span/following-sibling::a"));
    private BaseElement deleteProjectIcon = new(By.XPath("//tr[@class='even hoverSensitive']/following-sibling::tr[last()]//div[@class='icon-small-delete']"));
    private BaseElement dialogDeleteButton = new(By.XPath("//*[@id='deleteDialog']//input"));
    private BaseElement dialogAcceptDeleteButton = new(By.XPath("//*[@id='deleteDialog']//a"));

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

    [AllureStep]
    public ProjectPage OpenEditProjectPage()
    {
        projectForUpdate.GetElement().Click();
        editeProjectButton.GetElement().Click();

        return new ProjectPage();
    }
    [AllureStep]
    public MainPage DeleteProject()
    {
        Browser.Instance.NavigateToUrl(DataHelper.projectPageUrl);
        logger.Info($"Navigate to url {DataHelper.projectPageUrl}");

        deleteProjectIcon.GetElement().Click();
        dialogDeleteButton.GetElement().Click();
        dialogAcceptDeleteButton.GetElement().Click();

        return new MainPage();
    }
    [AllureStep]
    public TestCasePage OpenTestCasePage()
    {
        projectForUpdate.GetElement().Click();
        testCaseButton.GetElement().Click(); 

        return new TestCasePage();
    }
}