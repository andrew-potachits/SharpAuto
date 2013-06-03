using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecFlowTtrial.App;
using SpecFlowTtrial.Setup;
using TechTalk.SpecFlow;

namespace SpecFlowTtrial.Features
{
    [Binding]
    public class SearchBindings
    {
        private readonly IWebDriver _webDriver;

        public SearchBindings(IWebDriverHolder holder)
        {
            _webDriver = holder.WebDriver;
        }

        [When("in the header I type keyword '(.*)'")]
        public void TypeKeywordToFooter(string keyword)
        {
            var finsHomePage = PageFactory.InitElements<FinsHomePage>(_webDriver);
            finsHomePage.HeaderSearchControl.Keyword.Type(keyword);
        }

        [When("in the header I type location '(.*)'")]
        public void TypeLocationToFooter(string location)
        {
            var finsHomePage = PageFactory.InitElements<FinsHomePage>(_webDriver);
            finsHomePage.HeaderSearchControl.Location.Type(location);

        }
        [When("in the header I select country '(.*)'")]
        public void SelectCountryInFooter(string country)
        {
            var finsHomePage = PageFactory.InitElements<FinsHomePage>(_webDriver);
            finsHomePage.HeaderSearchControl.Country.SelectValue(country);
        }

        [When(@"in the header I search for (all|jobs|articles|companies)")]
        public void SearchFromFooter(SearchTargets searchTarget)
        {
            
        }

        [Then(@"Search has (more|less) than (\d+) (jobs|companies|overall results)")]
        [Then(@"Search has (exactly) (\d+) (jobs|companies|overall results)")]
        public void TestSearchResults(ComparisonOperator comparisonOperator, int searchResults, ResultType resultType)
        {}

        [StepArgumentTransformation("(jobs|companies|overall results)")]
        public ResultType ConvertToResultType(string input)
        {
            switch (input)
            {
                case "jobs":
                    return ResultType.Jobs;
                case "companies":
                    return ResultType.Companies;
                case "overall results":
                    return ResultType.OverallResults;
                default:
                    throw new ArgumentException(string.Format("Cannot convert from {0} to ResultType", input));
            }
        }
    }

    public enum SearchTargets
    {
        Jobs,
        Companies,
        Articles,
        All
    }
}
