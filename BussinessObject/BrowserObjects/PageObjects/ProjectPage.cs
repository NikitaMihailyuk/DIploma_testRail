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
        Input name = new("//*[@id=\"name\"]");
        Input announcement = new("//*[@id=\"announcement_display\"]");
        ProjectRadioButton prjButton = new("suite_mode_single");
        DropDown typeDropDown = new("Type");
        Button saveButton = new("accept");

        public ProjectPage CreateProject(UserModel user)
        {
            return this;
        }
    }
}
