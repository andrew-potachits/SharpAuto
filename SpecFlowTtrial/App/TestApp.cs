using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SpecFlowTtrial.App
{

    public class TestApp
    {
        private readonly RemoteWebDriver _webDriver;

        public TestApp()
        {
            _webDriver = new FirefoxDriver();
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
            _webDriver.FindElement(By.Id("ShowLogin")).Click();

            var login = _webDriver.FindElement(By.Id("ctl00_ucloginPopup_txtEmail"));
            if (login == null)
                throw new InvalidOperationException("Can't find ctl00_ucloginPopup_txtEmail");
            login.SendKeys(userName);

            var pass = _webDriver.FindElement(By.Id("ctl00_ucloginPopup_txtPwd"));
            if (pass == null)
                throw new InvalidOperationException("Can't find ctl00_ucloginPopup_txtPwd");
            pass.SendKeys(password);

            var loginButton = _webDriver.FindElement(By.Id("ctl00_ucloginPopup_btnLogin"));
            if (loginButton == null) 
                throw new InvalidOperationException("Can't find ctl00_ucloginPopup_btnLogin");
            loginButton.Click();
        }
    }
}
