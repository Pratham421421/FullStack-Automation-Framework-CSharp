using DemoBlaze.e2e.Framework.SetUp;
using OpenQA.Selenium;

namespace DemoBlaze.e2e.Framework.Helpers
{
    public class BaseUtilities : Base
    {
        public static IWebDriver GetWebDriver()
        {
            if (Driver == null)
            {
                throw new InvalidOperationException("WebDriver not initialized.");
            }
            return Driver;
        }
    }
}
