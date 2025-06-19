using DemoBlaze.e2e.Framework.Helpers;
using OpenQA.Selenium;
using System.Configuration;
using static System.Net.WebRequestMethods;

namespace DemoBlaze.e2e.Framework.Pages
{
    public class LoginPage
    {
        //string baseUrl = ConfigHelper.Get("BaseUrl");
        string baseUrl = "https://www.demoblaze.com/";

        //PageElements
        private readonly By LoginLinkEle = By.CssSelector("[data-target='#logInModal']");

        public void LoginToApp()
        {          
            BrowserUtilities.GoToUrl(baseUrl);
            WaitUtilities.Click(LoginLinkEle);
        }
    }
}
