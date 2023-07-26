using BussinessObject.BrowserObjects.SeleniumElements;
using Core.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NLog;

namespace BussinessObject.BrowserObjects.PageObjects
{
    public class ProjectPage : BaseBrowserPage
    {
        Input name = new("name");
        Input announcement = new("announcement_display");
        ProjectRadioButton prjButton = new("suite_mode_single");
        DropDown typeDropDown = new("Type");
        Button saveButton = new("accept");

        ProjectBuilder projectBuilder = new ProjectBuilder();

        [AllureStep]
        public ProjectPage CreateProject()
        {
            return this;
        }

        [AllureStep]
        public ProjectPage CreateProjectType1()
        {
            CreateProjectModel dataProject = projectBuilder.CreateProject();
            name.GetElement().SendKeys(dataProject.name);
            announcement.GetElement().SendKeys(dataProject.announcement);
            prjButton.GetElement().Click();
            saveButton.GetElement().Click();
            return this;
        }

        [AllureStep]
        public ProjectPage EditProject()
        {
            CreateProjectModel dataProject = projectBuilder.CreateProject();
            name.GetElement().Clear();
            name.GetElement().SendKeys(dataProject.name);

            announcement.GetElement().Clear();
            announcement.GetElement().SendKeys(dataProject.announcement);
            prjButton.GetElement().Click();
            saveButton.GetElement().Click();
            return this;
        }
    }
}
