using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using SpecFlowTtrial.App;
using SpecFlowTtrial.Setup;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Features
{
    [Binding]
    public class FinsApplication
    {
        private readonly FinsHomePage _homePage;
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        public FinsApplication(IWebDriverHolder holder)
        {
            _homePage = PageFactory.InitElements<FinsHomePage>(holder.WebDriver);
        }

        [Given("navigate to (.*)")]
        public void NavigateTo(string url)
        {
            _homePage.Navigate(url);
        }

        [Given("I am not logged in")]
        public void UserIsNotLoggedIn()
        {
            _homePage.Logoff();
        }

        [When("I open (.*)")]
        public void UserOpen(string page)
        {
            _homePage.Navigate(page);
        }

        [When("I login using (.*) and (.*)")]
        public void UserEntered(string userName, string password)
        {
            _homePage.Login(userName, password);
        }

        [Then("Login (.*)")]
        public void CheckLogin(LoginStatus status)
        {
            Assert.AreEqual(_homePage.IsLoggedIn, status == LoginStatus.Succeeded);
        }

        [When("The board is (Finance|Sales|IT|Asia|Europe)")]
        [Given("The board is (Finance|Sales|IT|Asia|Europe)")]
        public void OpenBoard(string board)
        {
            _homePage.SwitchBoard(board);
        }

        [When("I type keyword '(.*)'")]
        public void TypeInKeyword(string keyword)
        {
            _homePage.TypeInKeyword(keyword);
        }

        [When("I type location '(.*)'")]
        public void TypeInLocation(string location)
        {
            _homePage.TypeInLocation(location);
        }

        [When("I do search")]
        public void DoSearch()
        {
            _homePage.Search();
        }

        [Then(@"I get (More|Less) than (\d+) results")]
        [Then(@"I get (Exactly) (\d+) results")]
        public void ValidateResults(ComparisonOperator comparisonOperator, int amountOfResults)
        {
            if (comparisonOperator == ComparisonOperator.Exactly)
                Assert.AreEqual(amountOfResults, _homePage.SearchResultsCount);
            else if (comparisonOperator == ComparisonOperator.Less)
                Assert.Less(_homePage.SearchResultsCount, amountOfResults);
            else if (comparisonOperator == ComparisonOperator.More)
                Assert.Greater(_homePage.SearchResultsCount, amountOfResults);
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
