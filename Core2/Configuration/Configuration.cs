using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIploma_testRail.Core.Configuration
{
    public class Configuration
    {
        public static ApiConfiguration Api => BindConfiguration<ApiConfiguration>();
        public static BrowserConfiguration Browser => BindConfiguration<BrowserConfiguration>();
        private static IConfigurationRoot configurationRoot;

        static Configuration()
        {

            configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("ApiSetting.json", optional: true, reloadOnChange: true)
                .Build();         
        }

        private static T BindConfiguration<T>() where T : IConfiguration, new()
        {
            var config = new T();
            configurationRoot.GetSection(config.SectionName).Bind(config);
            return config;
        }

        public static string GetValue(string key)
        {
            return configurationRoot[key];
        }
    }
}
