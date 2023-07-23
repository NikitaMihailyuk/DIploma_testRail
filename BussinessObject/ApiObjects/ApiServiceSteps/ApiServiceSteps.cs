using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.ApiObjects.Services;
using Core.Models;

namespace BussinessObject.ApiObjects.ApiServiceSteps
{
    internal class ApiProjectSteps : ProjectService
    {
        public new CreateProjectModel GetProjectByCode(string code)
        {
            var response = base.GetProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<CreateProjectModel>>(response.Content).Result;
        }
    }
}