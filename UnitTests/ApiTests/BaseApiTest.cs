using DIploma_testRail.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.UnitTests.ApiTests
{
    internal class BaseApiTest
    {

        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            // apiClient = new BaseApiClient("https://isthisnikita.testrail.io/index.php?/api/v2");
            //  apiClient.AddToken("vd0SC5SATgakfaOApOYa-DJPIScT3dEp1AzUgVms5");
        }

    }
}
