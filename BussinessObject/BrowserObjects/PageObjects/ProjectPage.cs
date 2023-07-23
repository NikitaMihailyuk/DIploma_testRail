using DIploma_testRail.BussinessObject.BrowserObjects.SeleniumElements;
using DIploma_testRail.BussinessObject.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.BussinessObject.BrowserObjects.PageObjects
{
    public class ProjectPage
    {
        Input name = new("name");
        Input announcement = new("announcement_display");
        ProjectRadioButton prjButton = new("suite_mode_single");
        DropDown typeDropDown = new("Type");
        Button saveButton = new("accept");

        ProjectBuilder projectBuilder = new ProjectBuilder();
        public ProjectPage CreateProject(UserModel user)
        {
            return this;
        }
        public ProjectPage CreateProjectType1()
        {
            CreateProjectModel dataProject = projectBuilder.CreateProject();
            name.GetElement().SendKeys(dataProject.Title);
            announcement.GetElement().SendKeys(dataProject.Description);
            prjButton.GetElement().Click();
            saveButton.GetElement().Click();
            return this;
        }


        public ProjectPage EditProject()
        {
            CreateProjectModel dataProject = projectBuilder.CreateProject();
            name.GetElement().Clear();
            name.GetElement().SendKeys(dataProject.Title);

            announcement.GetElement().Clear();
            announcement.GetElement().SendKeys(dataProject.Description);
            prjButton.GetElement().Click();
            saveButton.GetElement().Click();
            return this;
        }
    }
}
