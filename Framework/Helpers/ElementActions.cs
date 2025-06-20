using DemoBlaze.e2e.Framework.Controls;
using DemoBlaze.e2e.Framework.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Expected = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DemoBlaze.e2e.Framework.Helpers
{
    public class ElementActions : BaseUtilities
    {
        private const int TimeoutInSeconds = WaitConstants.MinimumWaitS;

        public static void Click(By selector, int timeoutInSeconds = TimeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(GetWebDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(selector));
                element.Click();
            }
        }

        public static void SendKeys(By selector, string value, int timeoutInSeconds = TimeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(GetWebDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(selector));
            element.SendKeys(value);
        }

        public static string GetText(By selector)
        {
            WebDriverWait wait = new WebDriverWait(GetWebDriver(), TimeSpan.FromSeconds(TimeoutInSeconds));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(selector));
            return element.Text.Trim();
        }
    }
}
