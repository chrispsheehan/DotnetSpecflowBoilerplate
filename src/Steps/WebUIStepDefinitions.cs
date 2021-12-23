using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace boilerplate.Steps
{
    [Binding]
    public sealed class WebUIStepDefinitions
    {
        private IWebDriver _driver;

        public WebUIStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

         [Given(@"I go to ""(.*)""")]
         public void GivenIGotToGithub(string url)
         {
            _driver.Url = url;
         }

         [Then(@"the page title is ""(.*)""")]
         public void ThenTheTitleIs(string expectedTitle)
         {
            var actualTitle = _driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
         }                 
    }
}