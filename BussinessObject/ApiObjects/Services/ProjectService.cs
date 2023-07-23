using Core.Models;
using Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;
using NUnit.Allure.Attributes;
using NLog;

namespace BussinessObject.ApiObjects.Services
{
    internal class ProjectService : BaseService
    {
        public string ProjectEndpoint = "/project";
        public string GetProjectByCodeEndpoint = "/project/{code}";
        public string ProjectAcces = "/project/{code}/access";

        /*
        GET index.php?/api/v2/get_project/{project_id}
        GET index.php?/api/v2/get_projects
        POST index.php?/api/v2/add_project
        POST index.php?/api/v2/update_project/{project_id
        POST index.php?/api/v2/delete_project/{project_id}
        */


        public ProjectService() : base(Configuration.Api.BaseUrl)
        {

        }
        public RestResponse GetProjectByCode(string code)
        {

            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }
    }
}
