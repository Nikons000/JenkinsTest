using Aquality.Selenium.Browsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstJenkinsProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.GoTo("https://www.youtube.com/");
            YouTubePage youTubePage = new YouTubePage();
            Assert.IsTrue(youTubePage.CheckThatYouTubeIsDisplayed());
            AqualityServices.Browser.Quit();
        }
    }
}
