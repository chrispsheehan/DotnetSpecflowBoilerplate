# DotnetSpecflowBoilerplate

A boiled down framework for running tests quickly.

- [Example Specflow code]("https://github.com/SpecFlowOSS/SpecFlow-Examples")

- [Initiallise a project]("https://docs.specflow.org/projects/specflow/en/latest/Installation/Project-and-Item-Templates.html")

## Run it (Examples)

```bash
dotnet test src
dotnet test src --filter FeatureTitle=[FeatureName]
dotnet test src --filter Description=[ScenarioName]
```

## Build Framework Shell

List templates:

```bash
dotnet new -i SpecFlow.Templates.DotNet
```

Create project shell:

```bash
dotnet new specflowproject --unittestprovider nunit --framework netcoreapp3.1 --name boilerplate --output src 
```

Create ```.gitignore``` file with the below content at root.

```bash
*.feature.cs
obj/
bin/
```

## Install packages

Package names as they appear on [nuget.org]("https://www.nuget.org")

```bash
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
```
