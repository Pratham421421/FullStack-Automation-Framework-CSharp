using DemoBlaze.e2e.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlaze.e2e.Framework.Data
{
    public static class FrameworkConfigurations
    {
        public static string BaseUrl =>  ConfigHelper.Get("BaseUrl");
    }

}
