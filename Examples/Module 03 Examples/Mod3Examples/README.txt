This project contains multiple Main entry points, each ExampleXX class has its own.
The book examples do not show Main, but there cannot be multiple top-level entry points
in a single project. Each one of these projects explicitly defines a Main method.

Unfortunately, in Visual Studio you cannot select the startup object from the project
properties, there is a bug. You have to edit the project file XML text.

To open the file:

1. In Visual Studio, right-click on the project in the Solution Explorer, and select "Edit Project File".
2. In Visual Studio Code, just double-click the file.
3. In Rider, right-click on the project in the Solution Explorer, and select "Edit", and then "Edit Mod3Examples.csproj".

Change the <StartupObject> element in the project file to set the example that will run. The class is always Program,
it is the number at the end of the namespace that changes.

<Project Sdk="Microsoft.NET.Sdk">
	<PropertyGroup>
		<StartupObject>Mod3Example01.Program</StartupObject>
		<OutputType>Exe</OutputType>
		<TargetFramework>net9.0</TargetFramework>
		<ImplicitUsings>enable</ImplicitUsings>
		<Nullable>enable</Nullable>
	</PropertyGroup>

</Project>