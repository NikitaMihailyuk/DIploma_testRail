using DIploma_testRail.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIploma_testRail.Core.Configuration;

namespace DIploma_testRail.UnitTests.ApiTests
{
    internal class BaseApiTest
    {

        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            Console.WriteLine(Configuration.Api.Token);
            apiClient = new BaseApiClient("https://isthisnikita.testrail.io");

        }
    }
}
