using NUnit.Framework;
using HudlTestFrameworks;
using HudlTestFrameworks.PageObjects;

namespace HudlClientTest
{
    public class LoginSmokeTests : SeleniumBase
    {
        [Test]
        public void IsLoginButtonDisplayed() {
            Pages.IntroLanding.NavigateTo("/");
            Assert.IsTrue(Pages.NavBar.loginButton.Displayed);
        }

        [Test]
        public void IsLoginButtonClickable() {
            Pages.IntroLanding.NavigateTo("/");
            Assert.IsTrue(Pages.NavBar.loginButton.Enabled);
        }

        [Test]
        public void IsLoginPageLoaded() {
            Pages.IntroLanding.NavigateTo("/");
            Pages.NavBar.clickLoginButton();
            Assert.IsTrue(Pages.Login.CheckTitle());
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

        [TestCase("random@random.com", "ramdompassword")]
        [TestCase("smass@gmail.com", "")]
        [TestCase("", "")]
        [TestCase("test", "test")]
        [TestCase("sourabhmassey@gmail.com", "Mass6682")]
        public void IsLoginWorking(string username, string password) {
            Pages.IntroLanding.NavigateTo("login");
            Pages.Login.PerformLogIn(username, password);
            if (Pages.Login.confirmLoginError())
                Assert.Pass();
            else {
                if (Pages.HomePg.CheckTitle())
                    Assert.Pass();
                else Assert.Fail();
            }
        }
    }
}
