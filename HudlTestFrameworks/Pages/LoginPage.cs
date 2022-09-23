using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;
using System;

namespace HudlTestFrameworks.Pages
{
    public class LoginPage
    {
        private bool isDisplayed;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[1]/label")]
        private IWebElement emailLabel;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"email\"]")]
        public IWebElement emailTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[2]/label")]
        private IWebElement passwordLabel;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passwordTextBox;

        [FindsBy(How = How.Id, Using = "logIn")]
        public IWebElement loginButton;

        [FindsBy(How = How.CssSelector, Using = ".uni-form__label--check")]
        public IWebElement rememberMeLabel;

        [FindsBy(How = How.CssSelector, Using = ".uni-form__check-indicator__background")]
        public IWebElement rememberMecheckBox;

        [FindsBy(How = How.CssSelector, Using = ".styles_errorDisplayInnerContainer_3R2ni-zSvPIKWfKXiviJhH")]
        private IWebElement loginErrorMessage;

        public bool CheckTitle => Browser.Title.Contains("Log In");

        public void SelectRememberMeCkBox() {
            rememberMecheckBox.Click();
        }

        private void ClearLoginFields() {
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        public void PerformLogIn(string username, string passwd) {
            ClearLoginFields();
            emailTextBox.SendKeys(username);
            passwordTextBox.SendKeys(passwd);
            loginButton.Click();
        }

        public bool checkEmailTextBox() {
            return emailLabel.Text.Equals("Email") && emailTextBox.Enabled.Equals(true);
        }

        public bool checkPasswordTextBox() {
            return passwordLabel.Text.Equals("Password") && passwordTextBox.Enabled.Equals(true);
        }

        public bool confirmLoginError(Browser browser) {

            browser.fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);

            try {
                browser.fluentWait.Until(ExpectedConditions.ElementToBeClickable(loginErrorMessage));
                isDisplayed = loginErrorMessage.Displayed;
            }
            catch (Exception e) {

                Console.WriteLine("[Info] Login Error Element not Displayed \n\n"+e);
            }
            return isDisplayed;
        }
    }
}
