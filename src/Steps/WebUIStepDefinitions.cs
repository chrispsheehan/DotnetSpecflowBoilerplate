using Xunit;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace boilerplate.Steps
{
    [Binding]
    public sealed class WebUIStepDefinitions
    {
        private readonly IWebDriver _driver;

        public WebUIStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

         [Given(@"I go to ""(.*)""")]
         public void GivenIGoToGithub(string url)
         {
            _driver.Url = url;
         }

         [Then(@"the page title is ""(.*)""")]
         public void ThenTheTitleIs(string expectedTitle)
         {
            var actualTitle = _driver.Title;

            Assert.Contains(expectedTitle, actualTitle);
         }                 
    }
}
