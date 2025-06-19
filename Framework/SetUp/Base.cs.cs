using DemoBlaze.e2e.Framework.Controls;
using DemoBlaze.e2e.Framework.Pages;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoBlaze.e2e.Framework.SetUp

{
    public class Base
    {
        protected WebDriver WebDriver;
        public static IWebDriver Driver;
        protected BasePage App;

        [SetUp]
        public void BeforeEach()
        {
            WebDriver = new WebDriver();
            Driver = WebDriver.Driver;
            App = new BasePage();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Dispose();
        }
    }
}
