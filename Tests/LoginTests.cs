using DemoBlaze.e2e.Framework.SetUp;
using DemoBlaze.e2e.Framework.Data;


namespace DemoBlaze.e2e.Tests
{
    public class LoginTests : Base
    {

        [Test]
        public void LoginWithValidCredentials()
        {
            App.LoginPage.LoginToApp(UserData.GeneralUser,UserData.GeneralUserPassword);
        }
    }
}