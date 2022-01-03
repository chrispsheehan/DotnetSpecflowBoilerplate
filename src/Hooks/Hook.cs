using System;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Boilerplate.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver _driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Starting test run");
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"Starting Feature: {featureContext.FeatureInfo.Title}");
        }

        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _driver = new ChromeDriver();

            objectContainer.RegisterInstanceAs(_driver);

            Console.WriteLine($"Starting Scenario: {scenarioContext.ScenarioInfo.Title}");            
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine($"Finishing Scenario: {scenarioContext.ScenarioInfo.Title}");

            _driver.Quit();         
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"Finishing Feature: {featureContext.FeatureInfo.Title}");            
        }
    }
}
