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

        [FindsBy(How = How.CssSelector, Using = "#site-navigation > div:nth-child(1) > a")]
        public IWebElement solutionsLink;

        [FindsBy(How = How.ClassName, Using = "mainnav__item mainnav__item--elite mainnav__item--expandable")]
        public IWebElement productsLink;

        [FindsBy(How = How.CssSelector, Using = "body > div.outer > header > div > a.mainnav__btn.mainnav__btn--primary")]
        public IWebElement loginButton;

        //Other links i could have included but this is to showcase different identifying techniques

        public void clickHudlLogo() {
            huldLogo.Click();
        }

        public void clickProductLink() {
            productsLink.Click();
        }

        public void clickSolutionsLink() {
            solutionsLink.Click();
        }

        public void clickLoginButton() {
            loginButton.Click();
        }
    }
}
