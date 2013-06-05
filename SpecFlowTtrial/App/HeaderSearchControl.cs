using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowTtrial.App
{
    public class HeaderSearchControl
    {
        public HeaderSearchControl(IWebDriver webDriver)
        {
            
        }
        [FindsBy(How = How.Id, Using = "ctl00_UCHeader_ucFedFields_srchKeywords")]
        public IWebElement Keyword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_UCHeader_ucFedFields_srchLocation")]
        public IWebElement Location { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_UCHeader_ucFedFields_srchCountry")]
        public IWebElement Country { get; set; }

        public void SelectSearchType(string searchTarget)
        {
            
        }
    }
}