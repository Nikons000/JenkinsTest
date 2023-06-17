using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace FirstJenkinsProject
{
    public class YouTubePage : Form
    {
        private ILabel YouTube => ElementFactory.GetLabel(By.CssSelector(".style-scope ytd-masthead"), "YouTube Label");

        public YouTubePage() : base(By.CssSelector(".style-scope ytd-masthead"), "YouTube Page")
        {
        }

        public bool CheckThatYouTubeIsDisplayed()
        {
            return YouTube.State.WaitForDisplayed();
        }
    }
}
