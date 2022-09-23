using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HudlTestFrameworks.Pages
{
    public class MainPageNavBar
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/a/svg/path[2]")]
        public IWebElement huldLogo;

        [FindsBy(How = How.Id, Using = "site-navigation")]
        public IWebElement navBar;

        [FindsBy(How = How.CssSelector, Using = "body > div.outer > header > div > a.mainnav__btn.mainnav__btn--primary")]
        public IWebElement loginButton;

        //Other links i could have included but this is to showcase different identifying techniques

        public void clickHudlLogo() {
            huldLogo.Click();
        }

        public void clickLoginButton() {
            loginButton.Click();
        }
    }
}
