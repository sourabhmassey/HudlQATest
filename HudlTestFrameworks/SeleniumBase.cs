using NUnit.Framework;

namespace HudlTestFrameworks
{
    [TestFixture]
    public class SeleniumBase
    {
        [TestFixtureSetUp]
        public static void Initialize() {
            Browser.Initialize();
        }

        [TestFixtureTearDown]
        public static void TestFixtureTearDown() {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown() {

        }
    }
}
