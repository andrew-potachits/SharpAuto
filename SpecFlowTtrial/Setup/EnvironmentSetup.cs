using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Setup
{
    [Binding]
    public static class EnvironmentSetup
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static IWebDriver _webDriver;

        public static IWebDriver WebDriver
        {
            get { return _webDriver; }
        }

        [BeforeTestRun]
        public static void BeforeFeature()
        {
            //TODO: read from the config
            _webDriver = new FirefoxDriver();
            _baseUrl = "fins.com";
        }

        [AfterTestRun]
        public static void BeforeScenario()
        {
            WebDriver.Close();
        }

        private static string _baseUrl;

        public static string BaseUrl
        {
            get { return _baseUrl; }
        }
    }
}
