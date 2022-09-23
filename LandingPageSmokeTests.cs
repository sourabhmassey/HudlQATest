using HudlTestFrameworks;
using HudlTestFrameworks.Pages;
using NUnit.Framework;


namespace HudlClientTest
{
    public class LandingPageSmokeTests : SeleniumBase
    {
        [Test]
        public void IsHomePageLoding() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.IntroLanding.Title.Contains("Hudl • Connected solutions"));
        }

        [Test]
        public void IsNavBarVisible() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.NavBar.navBar.Displayed);
        }

        [Test]
        public void IsSolutionsLinkClickable() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.IntroLanding.solutionsLink.Enabled);
        }

        [Test]
        public void IsSolutionsTabDisplayed() {
            Pages.IntroLanding.NavigateTo("");
            Pages.IntroLanding.clickSolutionsLink(browser);
            Assert.IsTrue(Pages.IntroLanding.VerifySolutionsMenu(browser));
        }

        [Test]
        public void IsProductsLinkClickable() {
            Pages.IntroLanding.NavigateTo("");
            Assert.IsTrue(Pages.IntroLanding.productsLink.Enabled);
        }

        [Test]
        public void IsProductsTabDisplayed() {
            Pages.IntroLanding.NavigateTo("");
            Pages.IntroLanding.clickProductLink(browser);
            Assert.IsTrue(Pages.IntroLanding.VerifyProductsMenu(browser));
        }
    }
}