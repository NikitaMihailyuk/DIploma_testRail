using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using RestSharp.Authenticators;
using Bogus;
using System.Security.Policy;

namespace Core
{
    public class BaseApiClient
    {
        private RestClient restClient;
        protected Logger logger = LogManager.GetCurrentClassLogger();
        Faker faker = new Faker();

        public BaseApiClient(string url)
        {
            var option = new RestClientOptions(url)
            {
                MaxTimeout = 10000,
                ThrowOnAnyError = false,
                Authenticator = new HttpBasicAuthenticator(Configuration.Configuration.Browser.ListOfUsers[0].Name, Configuration.Configuration.Api.Token)
             };

            restClient = new RestClient(option);
            restClient.AddDefaultHeader("Content-Type", "application/json");
          
           }
        
        public void AddToken(string token)
        {
           // restClient.AddDefaultHeader("Authorization", "Basic SXN0aGlzbmlraXRhQGdtYWlsLmNvbTpJc3RoaXNuaWtpdGFAZ21haWwuY29tOnZkMFNDNVNBVGdha2ZhT0FwT1lhLURKUElTY1QzZEVwMUF6VWdWbXM1");
        }
        public void invalidAPItoken(string url)
        {
            var option = new RestClientOptions(url)
            {
                MaxTimeout = 10000,
                ThrowOnAnyError = false,
                Authenticator = new HttpBasicAuthenticator(Configuration.Configuration.Browser.ListOfUsers[0].Name, faker.Internet.Password())
            };
            restClient = new RestClient(option);
        }

        public RestResponse Execute(RestRequest request)
        {
            var response = restClient.Execute(request);
            return response;
        }

        public T Execute<T>(RestRequest request)
        {
            var response = restClient.Execute<T>(request);
            return response.Data;
        }
    }
}
