using NUnit.Framework;
using HudlTestFrameworks;
using HudlTestFrameworks.Pages;
using System;

namespace HudlClientTest
{
    public class LoginSmokeTests : SeleniumBase
    {
        [Test]
        public void IsLoginButtonDisplayedOnMainPage() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.NavBar.loginButton.Displayed);
        }

        [Test]
        public void IsLoginButtonClickableOnMainPage() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.NavBar.loginButton.Enabled);
        }

        [Test]
        public void IsLoginButtonDisplayedOnLoginPage() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.loginButton.Displayed);
        }

        [Test]
        public void IsLoginButtonClickableOnLoginPage() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.loginButton.Enabled);
        }

        [Test]
        public void IsLoginPageLoaded() {
            Pages.IntroLanding.NavigateTo("");
            Pages.NavBar.clickLoginButton();
            Assert.IsTrue(Pages.Login.CheckTitle);
        }

        [Test]
        public void IsLoginPgEmailDisplayed() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.checkEmailTextBox());
        }

        [Test]
        public void IsLoginPgPasswdDisplayed() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.checkPasswordTextBox());
        }

        [Test]
        public void IsRememberMeCkBoxDisplayed() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.rememberMecheckBox.Displayed);
        }

        [Test]
        public void IsRememberMeCkBoxlableDisplayed() {
            Pages.IntroLanding.NavigateTo("login");
            Assert.IsTrue(Pages.Login.rememberMeLabel.Displayed);
        }

        //[Test] //Need to do it with managing cookies
        //public void CanRememberMeCkBoxBeClicked() {
        //    Pages.IntroLanding.NavigateTo("login");
        //    Pages.Login.SelectRememberMeCkBox();
        //    Pages.Login.PerformLogIn("sourabhmassey@gmail.com", "Mass6682");
        //    browser.fluentWait.Timeout = TimeSpan.FromSeconds(5);
        //    Pages.IntroLanding.NavigateTo("");
        //    browser.fluentWait.Timeout = TimeSpan.FromSeconds(5);
        //    Pages.IntroLanding.NavigateTo("login");
        //    Assert.IsTrue(Pages.Login.emailTextBox.Text.Equals("sourabhmassey@gmail.com") && Pages.Login.passwordTextBox.Text.Equals("Mass6682"));
        //}


        [TestCase("-ve","random@random.com", "ramdompassword")]
        [TestCase("-ve","smass@gmail.com", "")]
        [TestCase("-ve","", "")]
        [TestCase("-ve","test", "test")]
        [TestCase("+ve","sourabhmassey@gmail.com", "Mass6682")]
        public void IsLoginWorking(string testtype,string username, string password) {
            Pages.IntroLanding.NavigateTo("login");
            Pages.Login.PerformLogIn(username, password);

            switch (testtype) {
                case "-ve":
                    Assert.IsTrue(Pages.Login.confirmLoginError(browser));
                    break;
                case "+ve":
                    Assert.IsTrue(Pages.HomePg.CheckTitle(browser));
                    break;
            }
            
        }
    }
}
