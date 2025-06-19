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
                .SetBasePath(Directory.GetCurrentDirectory()) // gets bin/debug/net8.0 folder
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string Get(string key)
        {
            return config[key];
        }
    }
}
