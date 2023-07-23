using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIploma_testRail.Core;
using RestSharp;
using DIploma_testRail.Core.Configuration;

namespace DIploma_testRail.BussinessObject.ApiObjects.Services
{
    public class TestCaseService : BaseService
    {
        public string CaseEndpoint = "/case";
        public string GetCaseByCodeEndpoint = "/index.php?/api/v2/get_runs/{code}";
        public string GetCaseByCodeEndpointbulk = "/case/{code}/bulk";
        public string GetCaseByID = "/case/{code}/{id}";
        //https://support.testrail.com/hc/en-us/articles/15758177606676-API-uses-cases-intro

        // index.php?/api/v2/get_project/10
        //Suite
        //Sections
        //Cases
        //Runs
        //Plans
        /*
          
         
Case fields	GET index.php?/api/v2/get_case_fields
Case templates	GET index.php?/api/v2/get_templates/{project_id}
Case priorities	GET index.php?/api/v2/get_priorities
Case types	GET index.php?/api/v2/get_case_types
Case statuses	GET index.php?/api/v2/get_case_statuses


  "https://example.testrail.io/index.php?/api/v2/add_case/432"
        GET index.php?/api/v2/get_history_for_case/{case_id}
       POST index.php?/api/v2/copy_cases_to_section/{section_id}
        POST index.php?/api/v2/update_case/{case_id}
        POST index.php?/api/v2/delete_case/{case_id}




         */
        public TestCaseService() : base(Configuration.Api.BaseUrl)
        {
        }

        public RestResponse GetRuns(string caseCode)
        {
            var request = new RestRequest(GetCaseByCodeEndpoint, Method.Get).AddUrlSegment("code", caseCode); ;
            request.AddBody(caseCode);
            return apiClient.Execute(request);
        }

        public RestResponse CreateANewTestCase(string caseCode, string title)
        {
            var request = new RestRequest(GetCaseByCodeEndpoint, Method.Post).AddUrlSegment("code", caseCode);

            var body = new Dictionary<string, object>()
            {
                {"title", title},
            };
            request.AddBody(body);
            /// request = request.AddParameter("application/json", "{\"title\":" + title + "}", ParameterType.RequestBody);
            return apiClient.Execute(request);
        }

        public RestResponse GetASpecificTestCase(string caseCode, int id)
        {
            var request = new RestRequest(GetCaseByID, Method.Get).AddUrlSegment("code", caseCode).AddUrlSegment("id", id);
            return apiClient.Execute(request);
        }

        public RestResponse DeleteTestCase(string caseCode, int id)
        {
            var request = new RestRequest(GetCaseByID, Method.Delete).AddUrlSegment("code", caseCode).AddUrlSegment("id", id);
            return apiClient.Execute(request);
        }

        public RestResponse UpdateTestCase(string caseCode, int id, string newTitle)
        {
            var request = new RestRequest(GetCaseByID, Method.Patch).AddUrlSegment("code", caseCode).AddUrlSegment("id", id);

            var body = new Dictionary<string, object>()
            {
                {"title", newTitle},
            };

            request.AddBody(body);
            return apiClient.Execute(request);
        }

        public RestResponse CreateTestCasesinBulk(string caseCode, string title)
        {
            var request = new RestRequest(GetCaseByCodeEndpointbulk, Method.Post).AddUrlSegment("code", caseCode);
            request = request.AddParameter("application/json", "{\"cases\":[{\"title\":\"" + title + "\"}]}", ParameterType.RequestBody);
            request.AddBody(caseCode);
            return apiClient.Execute(request);
        }

        public RestResponse GetAlltestCasesinvalid(string caseCode)
        {

            apiClient.invalidAPItoken("https://isthisnikita.testrail.io");
            var request = new RestRequest(GetCaseByCodeEndpoint, Method.Get).AddUrlSegment("code", caseCode); ;
            return apiClient.Execute(request);
        }
    }
}
