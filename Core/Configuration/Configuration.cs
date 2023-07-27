using Core.Configuration.Config_Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
    public class Configuration
    {
        public static ApiConfiguration Api => BindConfiguration<ApiConfiguration>();
        public static BrowserConfiguration Browser => BindConfiguration<BrowserConfiguration>();
        public static AccountSolutionModel Account => BindConfiguration<AccountSolutionModel>();

        private static IConfigurationRoot configurationRoot;
        static string configPath = DirectoryHelper.GetTestDataFolderPath()+"ApiSetting.json";
        static Configuration()
        {

            configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(configPath, optional: true, reloadOnChange: true)
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
