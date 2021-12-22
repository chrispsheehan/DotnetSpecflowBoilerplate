using System;
using BoDi;
using TechTalk.SpecFlow;

namespace boilerplate.Hooks
{
    [Binding]
    public class Hooks
    {
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
            //objectContainer.RegisterInstanceAs(objectToRegister);

            Console.WriteLine($"Starting Scenario: {scenarioContext.ScenarioInfo.Title}");            
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine($"Finishing Scenario: {scenarioContext.ScenarioInfo.Title}");            
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"Finishing Feature: {featureContext.FeatureInfo.Title}");            
        }
    }
}
