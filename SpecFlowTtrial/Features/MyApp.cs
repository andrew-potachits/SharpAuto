using NUnit.Framework;
using SpecFlowTtrial.App;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Features
{
    [Binding]
    public class MyApp
    {
        private readonly TestApp _app;
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public MyApp()
        {
            if (!FeatureContext.Current.TryGetValue<TestApp>("app", out _app))
            {
                _app = new TestApp();
                FeatureContext.Current.Add("app", _app);
            }
        }

        [Given("navigate to (.*)")]
        public void NavigateTo(string url)
        {
            _app.Navigate(url);
        }

        [Given("I am not logged in")]
        public void UserIsNotLoggedIn()
        {
            _app.Logoff();
        }

        [When("I open (.*)")]
        public void UserOpen(string page)
        {
            _app.Navigate(page);
        }

        [When("I entered (.*) and (.*)")]
        [When("I enter (.*) and (.*)")]
        public void UserEntered(string userName, string password)
        {
            _app.Login(userName, password);
        }

        [Then("Login (.*)")]
        public void CheckLogin(LoginStatus status)
        {
            Assert.AreEqual(_app.IsLoggedIn, status == LoginStatus.Succeeded);
        }
    }

    public enum LoginStatus
    {
        Succeeded,
        Failed
    }
}
