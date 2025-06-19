using DemoBlaze.e2e.Framework.SetUp;


namespace DemoBlaze.e2e.Tests
{
    public class LoginTests : Base
    {

        [Test]
        public void LoginWithValidCredentials()
        {
            App.LoginPage.LoginToApp();
        }
    }
}