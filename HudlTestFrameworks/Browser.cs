using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HudlTestFrameworks
{
    public class Browser
    {
        private static IWebDriver webDriver;
        private static string baseUrl = "https://www.hudl.com/";
        public DefaultWait<IWebDriver> fluentWait;
        
        public Browser() 
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            fluentWait = new DefaultWait<IWebDriver>(webDriver);
        }

        public static void Initialize() {
            NavigateTo("");
        }

        public static string Title => webDriver.Title;
        public static string CurrentURL => webDriver.Url;

        public static IWebDriver _Driver => webDriver;

        public static void NavigateTo(string url) {
             webDriver.Url = (baseUrl + url);
        }

        public static void Close() {
            webDriver.Close();
        }
    }
}
