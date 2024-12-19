## Scope
This project shows how to add `Radzne.Blazor` to an old `Blazor Server` project, using `.NET Core 3.1`.

## Disclaimer
The current getting started instructions on Radzen website no longer apply to older projects. This projects exists to serve as a tutorial on how to set up an older project.

## Steps
1. Add the needed NuGet package to your project: `<PackageReference Include="Radzen.Blazor" Version="3.8.13" />`. Newer versions do not seem to work.
2. Add the following uising statements to `_Imports.razor_`:
```
@using Radzen
@using Radzen.Blazor
```
3. In `Pages/_Host.cshtml`:
	a. Import the default CSS:
	```
		<link rel="stylesheet" href="_content/Radzen.Blazor/css/default-base.css"/>
		<link rel="stylesheet" href="_content/Radzen.Blazor/css/default.css"/>
	```
	b. Import the javascript:
	```
		<script src="_content/Radzen.Blazor/Radzen.Blazor.js"></script>
	```