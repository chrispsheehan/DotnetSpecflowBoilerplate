# DotnetSpecflowBoilerplate

- [Example Specflow code]("https://github.com/SpecFlowOSS/SpecFlow-Examples")

- [Initiallise a project]("https://docs.specflow.org/projects/specflow/en/latest/Installation/Project-and-Item-Templates.html")

## Build Framework

List templates: ```dotnet new -i SpecFlow.Templates.DotNet```

Create project shell:

```bash
cd src
dotnet new specflowproject --unittestprovider xunit --framework netcoreapp3.1 --name boilerplate
```

Create ```.gitignore``` file with the below content at root.

```bash
*.feature.cs
obj/
bin/
```