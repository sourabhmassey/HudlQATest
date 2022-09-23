using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;

namespace HudlTestFrameworks.Pages
{
    public class HudlHomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[4]/div[2]/div[1]/div[1]/div/div/h5")]
        private IWebElement ProfileLogo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[4]/div[2]/div[2]/div[3]/a")]
        private IWebElement LogoutOption;

        public bool CheckTitle(Browser browser) {
            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);

            try {
                browser.fluentWait.Until(ExpectedConditions.TitleContains("Home - Hudl"));
            }
            catch {
                Console.WriteLine("[Info] Title not displayed in the timelimit");
            }
                return Browser.Title.Equals("Home - Hudl");
        }

        private void ClickProfileLogo() {
            if (ProfileLogo.Displayed && ProfileLogo.Enabled) {
                ProfileLogo.Click();
            }
        }

        public void PerformLogout() {
            ClickProfileLogo();
            LogoutOption.Click();
        }


    }
}
