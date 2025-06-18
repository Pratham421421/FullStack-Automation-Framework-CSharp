using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DemoBlaze.e2e.Framework.SetUp
{
    public class WebDriver : IDisposable
    {
        public IWebDriver Driver { get; set; }

        public WebDriver()
        {
            Driver = SetupDriver();
            ConfigureSelenium(Driver);
        }

        private static void ConfigureSelenium(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        private static IWebDriver SetupDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            return new ChromeDriver(chromeOptions);
        }

        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}
