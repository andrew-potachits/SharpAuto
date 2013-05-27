using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SpecFlowTtrial.App;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Features
{
    [Binding]
    public class Events
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static IWebDriver _webDriver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
        }
    }
}
