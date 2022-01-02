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
dotnet new specflowproject --unittestprovider xunit --framework netcoreapp3.1 --name boilerplate --output src 
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

## [Dotnet Test Explorer]("https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer")

Save the below file to point the explorer at the tests.

GOTCHA - ensure read/write permissions are granted to the folder. Otherwise no test will appear.

[Known issue of tests appearing twice in UI]("https://github.com/formulahendry/vscode-dotnet-test-explorer/issues/159")

```.vscode/settings.json```

```json
{
    "dotnet-test-explorer.testProjectPath" : "**/*.test.csproj"
}
```

## [Debugging in VS Code]("https://code.visualstudio.com/docs/editor/debugging")

Save the below files in the project folder. Note the ```dotnet``` binary path will need to be located.

```.vscode/launch.json```

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Test",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "[insertBinaryPath]/dotnet",
            "args": ["test", "src"],
            "cwd": "${workspaceFolder}",
            "console": "internalConsole",
            "stopAtEntry": false
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}
```

```.vscode/tasks.json```

```json
{
    "version": "2.0.0",
    "command": "dotnet",
    "args": [],
    "tasks": [
        {
            "label": "build",
            "type": "shell",
            "command": "[insertBinaryPath]/dotnet",
            "args": [
                "build",
                "src"
            ],
            "problemMatcher": "$msCompile"
        }
    ]
}
```
