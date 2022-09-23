using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SmartWait.WaitSteps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HudlTestFrameworks.Pages
{
    public class LandingPage
    {
        [FindsBy(How = How.CssSelector, Using = "#site-navigation > div:nth-child(1) > a")]
        public IWebElement solutionsLink;

        [FindsBy(How = How.LinkText, Using = "Products")]
        public IWebElement productsLink;

        [FindsBy(How = How.CssSelector, Using = ".subnav--solutions")]
        public IWebElement solutionsMenu;

        [FindsBy(How = How.CssSelector, Using = ".subnav--products")]
        public IWebElement productsMenu;

        public void NavigateTo(string url) {
            Browser.NavigateTo(url);
        }

        public bool VerifySolutionsMenu(Browser browser) {

            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            try {
                browser.fluentWait.Until(ExpectedConditions.ElementToBeClickable(solutionsMenu));
            }
            catch (Exception e) {

                Console.WriteLine("[Info] Solution Menu not Displayed as Element not visible \n\n"+e);
            }
            return solutionsMenu.Displayed;
        }

        public bool VerifyProductsMenu(Browser browser) {

            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            try {
                browser.fluentWait.Until(ExpectedConditions.ElementToBeClickable(productsMenu));
            }
            catch (Exception e) {

                Console.WriteLine("[Info] Product Menu not Displayed as Element not visible\n\n" + e);
            }
            return productsMenu.Displayed;
        }

        public void clickProductLink(Browser browser) {
            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);

            try {
                browser.fluentWait.Until(ExpectedConditions.ElementToBeClickable(productsLink));
                productsLink.Click();
            }
            catch (Exception) {

                Console.WriteLine("[Info] Element not visible");
            }
            
        }

        public void clickSolutionsLink(Browser browser) {
            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);

            try {
                browser.fluentWait.Until(ExpectedConditions.ElementToBeClickable(solutionsLink));
                solutionsLink.Click();
            }
            catch (Exception) {

                Console.WriteLine("[Info] Clicking failed as element not visible");
            }
        }

        public string Title => Browser.Title;
    }
}
