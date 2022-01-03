using System.Collections.Generic;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Boilerplate.PageObjects
{
    [Binding]
    public class GithubHomePageObject
    {
        private readonly IWebDriver _driver;

        public GithubHomePageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SearchForRepo(string searchValue)
        {
            _driver.FindElement(GithubPageElements.SearchField).SendKeys(searchValue);
            _driver.FindElement(GithubPageElements.SearchField).Submit();
        }

        public List<string> GetSearchResults()
        {
            var repoList = _driver.FindElement(GithubPageElements.RepoList);

            var repos = repoList.FindElements(GithubPageElements.Repo);

            var results = new List<string>();

            foreach(var repo in repos) {

                results.Add(repo.Text);
            }

            return results;
        }        
    }
}