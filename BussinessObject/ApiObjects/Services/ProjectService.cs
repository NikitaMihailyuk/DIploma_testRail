using Core.Models;
using Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            "name": "Project X",
    "announcement": "Welcome to project X",
    "show_announcement": true
        suite_mode he suite mode of the project (1 for single suite mode, 2 for single suite + baselines, 3 for multiple suites)
}


        POST index.php?/api/v2/update_project/{project_id
        POST index.php?/api/v2/delete_project/{project_id}
        */


        public ProjectService() : base("https://api.qase.io/v1")
        {

        }
        public RestResponse GetProjectByCode(string code)
        {

            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }

     /*   public RestResponse CreateProject(CreateProjectModel project)
        {
            var request = new RestRequest(ProjectEndpoint, Method.Post);
            request.AddBody(project);
            return apiClient.Execute(request);
        }

        public CreateProjectModel GetProjectByCode<ProjectType>(string code) where ProjectType : Project
        {
            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute<CommonResultResponse<CreateProjectModel>>(request).Result;
        }

        public RestResponse GetAllProjects(int limit, int offset)
        {
            var request = new RestRequest(ProjectEndpoint, Method.Get);
            request = request.AddUrlSegment("limit", limit).AddUrlSegment("offset", offset);
            return apiClient.Execute(request);
        }
        public RestResponse DeleteProjectByCode(string code)
        {
            var request = new RestRequest(GetProjectByCodeEndpoint, Method.Delete);
            request = request.AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }

        public RestResponse RevokeAccessToProjectByCode(string code, int memberid)
        {
            var request = new RestRequest(ProjectAcces, Method.Delete);
            request = request.AddUrlSegment("code", code).AddParameter("application/json", "{\"member_id\":" + memberid + "}", ParameterType.RequestBody);
            Console.WriteLine(request);
            return apiClient.Execute(request);
        }

        public RestResponse GrantAccesstToProjectByCode(string code, int memberid)
        {
            var request = new RestRequest(ProjectAcces, Method.Post);
            request = request.AddUrlSegment("code", code).AddParameter("application/json", "{\"member_id\":" + memberid + "}", ParameterType.RequestBody);
            Console.WriteLine(request);
            return apiClient.Execute(request);
        }
     */
    }
}
