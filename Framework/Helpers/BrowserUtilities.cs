

namespace DemoBlaze.e2e.Framework.Helpers
{
    public class BrowserUtilities
    {
        public static void GoToUrl(string url)
        {
            BaseUtilities.GetWebDriver().Navigate().GoToUrl(url);
        }
    }
}
