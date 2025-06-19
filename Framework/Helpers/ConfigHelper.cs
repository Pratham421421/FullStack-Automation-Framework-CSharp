using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlaze.e2e.Framework.Helpers
{
    public static class ConfigHelper
    {
        private static IConfigurationRoot config;

        static ConfigHelper()
        {
            config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true)
            .Build();
        }

        public static string Get(string key)
        {
            return config[key];
        }
    }
}
