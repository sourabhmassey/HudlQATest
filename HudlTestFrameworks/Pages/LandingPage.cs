using HudlTestFrameworks;
using OpenQA.Selenium;


namespace HudlTestFrameworks.Pages
{
    public class LandingPage
    {
        public void NavigateTo(string url) 
        {
            Browser.NavigateTo(url);
        }

        public string Title => Browser.Title;
    }
}
