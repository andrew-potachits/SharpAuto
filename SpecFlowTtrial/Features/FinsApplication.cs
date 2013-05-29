using NUnit.Framework;
using SpecFlowTtrial.App;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Features
{
    [Binding]
    public class FinsApplication
    {
        private readonly FinsDriver _app;
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public FinsApplication()
        {
            if (!FeatureContext.Current.TryGetValue("app", out _app))
            {
                _app = new FinsDriver();
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

        [When("I login using (.*) and (.*)")]
        public void UserEntered(string userName, string password)
        {
            _app.Login(userName, password);
        }

        [Then("Login (.*)")]
        public void CheckLogin(LoginStatus status)
        {
            Assert.AreEqual(_app.IsLoggedIn, status == LoginStatus.Succeeded);
        }

        [When("The board is (Finance|Sales|IT|Asia|Europe)")]
        public void OpenBoard(string board)
        {
            _app.SwitchBoard(board);
        }

        [When("I type keyword '(.*)'")]
        public void TypeInKeyword(string keyword)
        {
            _app.TypeInKeyword(keyword);
        }

        [When("I type location '(.*)'")]
        public void TypeInLocation(string location)
        {
            _app.TypeInLocation(location);
        }

        [When("I do search")]
        public void DoSearch()
        {
            _app.Search();
        }

        [Then(@"I get (More|Less) than (\d+) results")]
        [Then(@"I get (Exactly) (\d+) results")]
        public void ValidateResults(ComparisonOperator comparisonOperator, int amountOfResults)
        {
            if (comparisonOperator == ComparisonOperator.Exactly)
                Assert.AreEqual(amountOfResults, _app.SearchResultsCount);
            else if (comparisonOperator == ComparisonOperator.Less)
                Assert.Less(_app.SearchResultsCount, amountOfResults);
            else if (comparisonOperator == ComparisonOperator.More)
                Assert.Greater(_app.SearchResultsCount, amountOfResults);
            else 
                Assert.IsTrue(false, "Not supported expression?");
        }
    }

    public enum ComparisonOperator
    {
        More,
        Less,
        Exactly
    }

    public enum LoginStatus
    {
        Succeeded,
        Failed
    }
}
