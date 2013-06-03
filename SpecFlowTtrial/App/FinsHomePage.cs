using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SpecFlowTtrial.Setup;

namespace SpecFlowTtrial.App
{

    public class FinsHomePage
    {
        private readonly IWebDriver _webDriver;
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(30);

        [FindsBy(How = How.Id, Using = "ShowLogin")]
        private IWebElement _showLoginButton;

        [FindsBy(How = How.Id, Using = "ctl00_ucloginPopup_txtEmail")]
        private IWebElement _login;


        [FindsBy(How = How.Id, Using = "ctl00_ucloginPopup_txtPwd")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "ctl00_ucloginPopup_btnLogin")]
        private IWebElement _loginButton;


        public FinsHomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool IsLoggedIn
        {
            get { return _webDriver.FindElements(By.ClassName("loggedInView")).Count > 0; }
        }

        public void Logoff()
        {
            var logoutLink = _webDriver.FindElements(By.PartialLinkText("Log Out"));
            if (logoutLink.Count == 0)
                return;
            logoutLink[0].Click();
        }

        public void Navigate(string url)
        {
            _webDriver.Url = url;
            _webDriver.Navigate();
        }

        public void Login(string userName, string password)
        {
            _showLoginButton.Click();

            _login.SendKeys(userName);

            _password.SendKeys(password);

            _loginButton.Click();

            WaitFor(driver => driver.FindElements(By.Id("ctl00_DefaultContent_pnlError")).Count > 0 ||
                driver.FindElements(By.Id("ctl00_UCHeader_logoutPnl")).Count > 0);
        }

        private TResult WaitFor<TResult>(Func<IWebDriver, TResult> function)
        {
            var webDriverWait = new WebDriverWait(_webDriver, _timeout);
            return webDriverWait.Until(function);
        }

        public void SwitchBoard(string board)
        {
            switch (board.ToLowerInvariant())
            {
                case "finance":
                    Navigate(FinanceHomePage);
                    break;
                case "it":
                    Navigate(ITHomePage);
                    break;
                case "sales":
                    Navigate(SalesHomePage);
                    break;
                case "europe":
                    Navigate(EuropeHomePage);
                    break;
                case "asia":
                    Navigate(AsiaHomePage);
                    break;
            }
        }

        protected string AsiaHomePage { get { return string.Format("http://asia-jobs.{0}", EnvironmentSetup.BaseUrl); } }
        protected string EuropeHomePage { get { return string.Format("http://europe-jobs.{0}", EnvironmentSetup.BaseUrl); } }
        protected string SalesHomePage { get { return string.Format("http://sales-jobs.{0}", EnvironmentSetup.BaseUrl); } }
        protected string ITHomePage { get { return string.Format("http://it-jobs.{0}", EnvironmentSetup.BaseUrl); } }
        protected string FinanceHomePage { get { return string.Format("http://www.{0}/Finance", EnvironmentSetup.BaseUrl); } }

        public int SearchResultsCount
        {
            get { 
                var foundTitle = this[By.Id("ctl00_DefaultContent_lblSrchResultTitle")];
                string title;
                if (foundTitle.FindElements(By.ClassName("jobCount")).Count > 0)
                    title = foundTitle.FindElement(By.ClassName("jobCount")).Text;
                else
                    title = foundTitle.Text;

                var nItemsFound = new Regex(@"(?<items>\d+) items found", RegexOptions.IgnoreCase);
                if (!nItemsFound.IsMatch(title))
                    return 0;

                return int.Parse(nItemsFound.Match(title).Groups["items"].Value);
            }
        }

        public HeaderSearchControl HeaderSearchControl
        {
            get { return PageFactory.InitElements<HeaderSearchControl>(_webDriver); }
        }

        public IWebElement this[By by] { 
            get { 
                var elem = _webDriver.FindElements(by);
                if (elem.Count > 0)
                    return elem[0];
                return new DummyWebElement();
            }
        }
        public void TypeInKeyword(string keyword)
        {
            this[By.Id("ctl00_DefaultContent_UCSimpleSearch_txtFind")].SendKeys(keyword);
        }

        public void TypeInLocation(string location)
        {
            this[By.Id("ctl00_DefaultContent_UCSimpleSearch_txtLocation")].SendKeys(location);
        }

        public void Search()
        {
            this[By.Id("ctl00_DefaultContent_UCSimpleSearch_btnGoto")].Click();
        }
    }

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

    }
}
