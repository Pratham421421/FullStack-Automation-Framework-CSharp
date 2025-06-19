using DemoBlaze.e2e.Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlaze.e2e.Framework.Helpers
{
    public class BaseFactory
    {
        public LoginPage LoginPage => new LoginPage();
    }
}
