using DemoBlaze.e2e.Framework.Controls;
using DemoBlaze.e2e.Framework.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Expected = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DemoBlaze.e2e.Framework.Helpers
{
    public class WaitUtilities : BaseUtilities
    {
        private const int TimeoutInSeconds = Constants.MinimumWaitS;

        public static void Click(By selector, int timeoutInSeconds = TimeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(GetWebDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(selector));
                element.Click();
            }
        }
    }
}
