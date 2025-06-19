using DemoBlaze.e2e.Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
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
            var browser = ConfigHelper.Get("Browser").ToLower();

            switch (browser)
            {
                case "firefox":
                    return SetupFirefoxDriver();
                case "edge":
                    return SetupEdgeDriver();
                case "chrome":
                default:
                    return SetupChromeDriver();
            }
        }

        private static IWebDriver SetupChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            return new ChromeDriver(chromeOptions);
        }

        private static IWebDriver SetupFirefoxDriver()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            return new FirefoxDriver(firefoxOptions);
        }

        private static IWebDriver SetupEdgeDriver()
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            return new EdgeDriver(edgeOptions);
        }

        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}
