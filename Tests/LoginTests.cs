using DemoBlaze.e2e.Framework.Controls;
using DemoBlaze.e2e.Framework.Helpers;
using DemoBlaze.e2e.Framework.Pages;
using DemoBlaze.e2e.Framework.SetUp;
using OpenQA.Selenium.Chrome;

namespace DemoBlaze.e2e.Tests
{
    public class LoginTests : Base
    {

        [Test]
        public void Test1()
        {
            App.LoginPage.LoginToApp();
            Thread.Sleep(50000);
        }
    }
}