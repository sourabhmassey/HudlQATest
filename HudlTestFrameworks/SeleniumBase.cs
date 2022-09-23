using NUnit.Core;
using NUnit.Framework;

namespace HudlTestFrameworks
{
    [TestFixture]
    public class SeleniumBase
    {
        public static Browser browser;

        [SetUp]
        public static void SetUp()
        {
            browser = new Browser();
            Browser.Initialize();
        }

        [TearDown]
        public static void TestFixtureTearDown() {
            Browser.Close();
        }
    }
}
