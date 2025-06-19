using DemoBlaze.e2e.Framework.Helpers;
using OpenQA.Selenium;
using System.Configuration;
using static System.Net.WebRequestMethods;

namespace DemoBlaze.e2e.Framework.Pages
{
    public class LoginPage : ElementActions
    {
        string baseUrl = ConfigHelper.Get("BaseUrl");
        //string baseUrl = "https://www.demoblaze.com/";

        //PageElements
        private readonly By LoginLinkEle = By.CssSelector("[data-target='#logInModal']");
        private readonly By UsernameTextBoxEle = By.CssSelector("[id='loginusername']");
        private readonly By PasswordTextBoxEle = By.CssSelector("[id='loginpassword']");
        private readonly By LogInButtonEle = By.CssSelector("[onclick='logIn()']");
        private readonly By NameOfUserNavLinkEle = By.CssSelector("[id='nameofuser']");

        public void LoginToApp(string user , string password)
        {          
            BrowserUtilities.GoToUrl(baseUrl);
            Click(LoginLinkEle);
            SendKeys(UsernameTextBoxEle, user);
            SendKeys(PasswordTextBoxEle, password);
            Click(LogInButtonEle);
            Assert.That(GetText(NameOfUserNavLinkEle), Is.EqualTo($"Welcome {user}"), "User not Logged In");
        }
    }
}
