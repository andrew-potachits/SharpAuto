using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Setup
{
    [Binding]
    public class EnvironmentSetup
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static IWebDriver _webDriver;

//        public static IWebDriver WebDriver
//        {
//            get { return _webDriver; }
//        }

        [BeforeTestRun]
        public static void BeforeTest()
        {
            //TODO: read from the config
            _webDriver = new FirefoxDriver();
            _baseUrl = "fins.com";
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            _webDriver.Close();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var objectContainer = (IObjectContainer) ScenarioContext.Current.GetBindingInstance(typeof (IObjectContainer));
            objectContainer.RegisterInstanceAs<IWebDriverHolder>(new WebDriverAntiDisposer(_webDriver));
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }
        private static string _baseUrl;

        public static string BaseUrl
        {
            get { return _baseUrl; }
        }
    }

    public class WebDriverAntiDisposer : IWebDriverHolder   
    {
        public WebDriverAntiDisposer(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebDriver WebDriver { get; private set; }
    }

    public interface IWebDriverHolder
    {
        IWebDriver WebDriver { get; }
    }
}
