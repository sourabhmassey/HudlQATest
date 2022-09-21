using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HudlTestFrameworks.Pages
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new() {
            var page = new T();
            IWebDriver driver = Browser.WebDriver;//._Driver;
            PageFactory.InitElements(driver, page);
            return page;
        }

        public static LandingPage IntroLanding => GetPage<LandingPage>();
        public static LoginPage Login => GetPage<LoginPage>();
        public static MainPageNavBar NavBar => GetPage<MainPageNavBar>();
        public static HudlHomePage HomePg => GetPage<HudlHomePage>();

    }
}
