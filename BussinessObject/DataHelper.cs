using Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class DataHelper
    {
        public static string succesUpdateProjectMessage = "Successfully updated the project.";
        public static string succesCreateProjectMessage = "Successfully added the new project.";
        public static string succesDeleteProjectMessage = "Successfully deleted the project.";
        public static string succescAddTestCaseMessage = "Successfully added the new test case.";
        public static string errorInputLoginMessage = "Email/Login or Password is incorrect. Please try again.";
        public static string commonErrorMessage = "Sorry, there was a problem.";
        public static string authUrl = Configuration.Api.BaseUrl + "/index.php?/auth/login/";
        public static string projectPageUrl = Configuration.Api.BaseUrl + "/index.php?/admin/projects/overview/";
    }
}
