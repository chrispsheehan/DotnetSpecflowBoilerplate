using OpenQA.Selenium;

namespace Boilerplate.PageObjects
{
    public static class GithubPageElements
    {
        public static readonly By SearchField = By.ClassName("header-search-input");

        public static readonly By RepoList = By.ClassName("repo-list");

        public static readonly By Repo = By.ClassName("text-normal");
    }
}