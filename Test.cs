using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HudlClientTest
{
    public class Test
    {
        IWebDriver driver;
        private string baseUrl = "http://hudl.com/";

        [SetUp]
        public void Setup() {
            driver = new ChromeDriver("C:\\Users\\sourabh\\source\\repos\\TestProject1\\packages\\WebDriver.ChromeDriver.26.14.313457.1\\tools");
            driver.Manage().Window.Maximize();
            driver.Url = baseUrl.ToString();
        }


        public void Close() {
            driver.Close();
        }

        [Test]
        public void Test1() {
            Assert.IsTrue(driver.Title.Contains("Hudl"));
        }
    }
}