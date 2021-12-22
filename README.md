# DotnetSpecflowBoilerplate

https://docs.specflow.org/projects/specflow/en/latest/Installation/Project-and-Item-Templates.html

list templates
dotnet new -i SpecFlow.Templates.DotNet

Create project
cd src
dotnet new specflowproject --unittestprovider xunit --framework netcoreapp3.1 --name boilerplate

output - The template "SpecFlow Project Template" was created successfully.

Exclude chaff
*.feature.cs
obj/
bin/

Dotnet test will error with Test pending: One or more step definitions are not implemented yet.


