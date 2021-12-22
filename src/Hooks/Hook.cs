using System;
using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace boilerplate.Hooks
{
    [Binding]
    public class Hooks
    {
        private static RemoteWebDriver _driver;

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
            _driver = new RemoteWebDriver(new Uri("[DesiredUrl]"), new ChromeOptions());

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
