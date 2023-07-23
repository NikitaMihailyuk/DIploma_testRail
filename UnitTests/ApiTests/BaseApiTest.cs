using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;

namespace UnitTests.ApiTests
{
    internal class BaseApiTest
    {

        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            apiClient = new BaseApiClient(Configuration.Api.BaseUrl);
        }
    }
}
