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
using BussinessObject.BrowserObjects;

namespace BussinessObject.ApiObjects.Services
{
    public class ProjectService : BaseService
    {
        public string GetProjectEndpoint = "/index.php?/api/v2/get_project/{project_id}";
        public string GetProjectsEndpoint = "/index.php?/api/v2/get_projects";
        public string AddProjectEndpoint = "/index.php?/api/v2/add_project";
        public string UpdateProjectEndpoint = "/index.php?/api/v2/update_project/{project_id}";
        public string DeleteProjectEndpoint = "/index.php?/api/v2/delete_project/{project_id}";

        ProjectBuilder projectBuilder = new ProjectBuilder();

        public ProjectService() : base(Configuration.Api.BaseUrl) {}

        [AllureStep]
        public RestResponse GetProject(int idProject)
        {
            var request = new RestRequest(GetProjectEndpoint, Method.Get).AddUrlSegment("project_id", idProject); ;
            logger.Info("Get Project by code"+idProject);
            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse GetProjects()
        {
            var request = new RestRequest(GetProjectsEndpoint, Method.Get);
            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse DeleteProject(int idProject)
        {
            var request = new RestRequest(DeleteProjectEndpoint, Method.Post).AddUrlSegment("project_id", idProject); ;
            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse CreateProject()
        {
            var request = new RestRequest(AddProjectEndpoint, Method.Post);
            var body = projectBuilder.CreateProject();
            request.AddBody(body);

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse UpdateProject(int idProject)
        {
            var request = new RestRequest(UpdateProjectEndpoint, Method.Post).AddUrlSegment("project_id", idProject);
            var body = projectBuilder.CreateProject();
            request.AddBody(body);

            return apiClient.Execute(request);
        }
    }
}
