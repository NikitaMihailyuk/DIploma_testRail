using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using RestSharp;
using Core.Configuration;
using BussinessObject.BrowserObjects;
using NUnit.Framework.Interfaces;
using NUnit.Allure.Attributes;
using NLog;
using OpenQA.Selenium.Interactions;

namespace BussinessObject.ApiObjects.Services
{
    public class TestCaseService : BaseService
    {
        public string CaseEndpoint = "/case";
        public string GetRunsByCodeEndpoint = "/index.php?/api/v2/get_runs/{code}";
        public string GetTestCaseEndpoint = "index.php?/api/v2/get_case/{case_id}";
        public string GetTestCaseFieldsEndpoint = "/index.php?/api/v2/get_case_fields/{case_id}";
        public string CreateTestCaseEndPoint = "index.php?/api/v2/add_case/{section_id}";
        public string UpdateTestCaseEndPoint = "index.php?/api/v2/update_case/{case_id}";
        public string DeleteTestCaseEndpoint = "index.php?/api/v2/delete_case/{case_id}&soft=1";

        TestCaseBuilder testCaseBuilder = new TestCaseBuilder();

        public TestCaseService() : base(Configuration.Api.BaseUrl)
        {}
   
        [AllureStep]
        public RestResponse GetRuns(int projectCodeId)
        {
            var request = new RestRequest(GetRunsByCodeEndpoint, Method.Get).AddUrlSegment("code", projectCodeId); ;

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse GetAlltestRunsinvalid(int projectCodeId)
        {
            apiClient.invalidAPItoken(Configuration.Api.BaseUrl);
            var request = new RestRequest(GetRunsByCodeEndpoint, Method.Get).AddUrlSegment("code", projectCodeId);

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse GetTestCase(int idTestCase)
        {
            var request = new RestRequest(GetTestCaseEndpoint, Method.Get).AddUrlSegment("case_id", idTestCase);

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse GetTestCaseFields(int idTestCase)
        {
            var request = new RestRequest(GetTestCaseFieldsEndpoint, Method.Get).AddUrlSegment("case_id", idTestCase);

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse DeleteTestCase(int idTestCase)
        {
            var request = new RestRequest(GetTestCaseEndpoint, Method.Get).AddUrlSegment("case_id", idTestCase); 

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse CreateTestCase(int section_id)
        {
            var request = new RestRequest(CreateTestCaseEndPoint, Method.Post).AddUrlSegment("section_id", section_id);
            var body = testCaseBuilder.TestCaseCreator();
            request.AddBody(body);

            return apiClient.Execute(request);
        }

        [AllureStep]
        public RestResponse UpdateTestCase(int case_id)
        {
            var request = new RestRequest(UpdateTestCaseEndPoint, Method.Post).AddUrlSegment("case_id", case_id);
            var body = testCaseBuilder.TestCaseCreator();
            body.Section_id = 188;
            request.AddBody(body);

            return apiClient.Execute(request);
        }
    }
}
