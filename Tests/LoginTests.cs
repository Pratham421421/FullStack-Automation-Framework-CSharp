using DemoBlaze.e2e.Framework.Helpers;
using DemoBlaze.e2e.Framework.SetUp;
using OpenQA.Selenium.Chrome;

namespace DemoBlaze.e2e.Tests
{
    public class Tests : Base
    {

        [Test]
        public void Test1()
        {
            BrowserUtilities.GoToUrl("https://www.google.com");
            Thread.Sleep(5000);
        }
    }
}