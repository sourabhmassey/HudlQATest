using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace HudlTestFrameworks.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "uni-link uni-link--wrapper styles_hudlLogoContainer_1L8Lig-sH69T84pB_fXSlv styles_fadeInUpFast_13tTIPxY77Mkw_Ud-lEwlP")]
        private IWebElement companyLogo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[1]/label")]
        private IWebElement emailLabel;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"email\"]")]
        private IWebElement emailTextBox;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[2]/label")] 
        private IWebElement passwordLabel;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.Id, Using = "login-btn")]
        private IWebElement loginButton;

        [FindsBy(How = How.Id, Using = "remember-me-checkbox-label")]
        private IWebElement rememberMeLabel;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[4]/div/label/svg/rect[1]")]
        private IWebElement rememberMecheckBox;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/section/div[2]/div/form/div/div[3]/div")]
        private IWebElement loginErrorMessage;

        public bool CheckTitle() {
            return Browser.Title.Contains("Log In");
        }

        public void RememberMeCkBox() {
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
            return emailLabel.Text.Equals("Password") && passwordTextBox.Enabled.Equals(true);
        }

        public bool confirmLoginError() {
            return loginErrorMessage.Displayed;
        }
    }
}
