using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HudlTestFrameworks
{
    public class Browser
    {
        private static IWebDriver webDriver;

        private static string baseUrl = "https://www.hudl.com";
        // private IWebDriver webDriver = new ChromeDriver();

        public Browser(WebDriver driver) 
        {
            driver = new ChromeDriver("C:\\Users\\sourabh\\.nuget\\packages\\selenium.chrome.webdriver\\85.0.0\\driver\\chromedriver.exe");
            driver.Manage().Window.Maximize();
            WebDriver = driver;
        }

        public static void Initialize() 
        {
            NavigateTo("");
        }

        public static string Title => WebDriver.Title;
        public static string CurrentURL => WebDriver.Url;

        public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }

        // public static IWebDriver _Driver => WebDriver;
        public static void NavigateTo(string url)
        {
           // WebDriver.Url = baseUrl + url; //.Url triggers the url in the current window
            WebDriver.Navigate().GoToUrl(baseUrl);
        }
       
        public static void Close()
        {
            WebDriver.Close();
        }
    }
}
