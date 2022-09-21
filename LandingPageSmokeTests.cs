using HudlTestFrameworks;
using HudlTestFrameworks.PageObjects;
using NUnit.Framework;


namespace HudlClientTest
{
    public class LandingPageSmokeTests : SeleniumBase
    {
        [Test]
        public void IsHomePageLoding() {
            Pages.IntroLanding.NavigateTo("/");
            Assert.IsTrue(Pages.IntroLanding.Title.Contains("Hudl • Connected solutions"));
        }

        [Test]
        public void IsNavBarVisible() {
            Pages.IntroLanding.NavigateTo("/");
            Assert.IsTrue(Pages.NavBar.navBar.Displayed);
        }

        [Test]
        public void IsNavBarClickable() {
            Pages.IntroLanding.NavigateTo("/");
            Assert.IsTrue(Pages.NavBar.solutionsLink.Enabled);
            Pages.NavBar.clickSolutionsLink();
        }

        /* These are just a few scenarios that are covered here .. there can be at least 50 more scenarios added
         * to the home page tests*/
    }
}