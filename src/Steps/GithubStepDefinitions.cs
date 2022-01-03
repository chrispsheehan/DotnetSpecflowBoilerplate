using Xunit;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using boilerplate.PageObjects;
using System.Collections.Generic;

namespace boilerplate.Steps
{
    [Binding]
    public sealed class GithubStepDefinitions
    {
        private readonly GithubHomePageObject _page;

        public GithubStepDefinitions(GithubHomePageObject page)
        {
            _page = page;
        }

         [When(@"I search for ""(.*)""")]
         public void WhenISearchFor(string searchValue)
         {
             _page.SearchForRepo(searchValue);
         }

         [Then(@"I see results of ""(.*)""")]
         public void ThenISeeResultsOf(List<string> expectedResults)
         {
             List<string> actualResults = _page.GetSearchResults();

             foreach(string expectedResult in expectedResults) {
                 
                 Assert.Contains(expectedResult, actualResults);
             }         
         }                               
    }
}
