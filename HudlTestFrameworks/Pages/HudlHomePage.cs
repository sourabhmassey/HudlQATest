using HudlTestFrameworks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HudlTestFrameworks.Pages
{
    public class HudlHomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[4]/div[2]/div[1]/div[1]/div/div/h5")]
        private IWebElement ProfileLogo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[4]/div[2]/div[2]/div[3]/a")]
        private IWebElement LogoutOption;

        public bool CheckTitle() => Browser.Title.Equals("Home - Hudl");

        private void ClickProfileLogo() 
        {
            if (ProfileLogo.Displayed && ProfileLogo.Enabled) {
                ProfileLogo.Click();
            }      
        }

        public void PerformLogout() 
        {
            ClickProfileLogo();
            LogoutOption.Click();
        }


    }
}
