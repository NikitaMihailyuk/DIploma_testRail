using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;
using NUnit.Allure.Core;
using Allure.Commons;
using NLog;

namespace UnitTests.ApiTests
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.Fixtures)]
    internal class BaseApiTest
    {
        private AllureLifecycle allure;
        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            allure = AllureLifecycle.Instance;
            apiClient = new BaseApiClient(Configuration.Api.BaseUrl);
        }
    }
}
