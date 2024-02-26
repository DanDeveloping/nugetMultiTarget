
# More Things to learn

While we are working on this project we could learn a few more things that maybe you know or maybe you do not know. 

  1. [SourceLink](https://github.com/dotnet/sourcelink) - debug the source in consumer projects
  1. [Deterministic Builds](https://github.com/clairernovotny/DeterministicBuilds) - enable verification that the resulting binary was built from the specified source and provides traceability
  1. [Nuget Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) - create and explore NuGet packages

# SourceLink 

This product allows debugging into the source of nuget package in the consumer application during your debugging session.  Adding this feature to your code provides a much better debugging experience increasing a developer's confidence and speed toward any changes they may need to make to accomplish their tasks. That is iff you have the access.  Private Repos are supposed to work with SourceLink now and could impede your ability to load those symbols and source.  

For this project we used the "Microsoft.SourceLink.GitHub" nuget package.
```
<PackageReference Include="Microsoft.SourceLink.GitHub" Version="8.0.0">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```
as well as adding in a few properties in the project file 
```
<PropertyGroup>
  <DebugType>portable</DebugType>
  <PublishRepositoryUrl>true</PublishRepositoryUrl>
  <EmbedUntrackedSources>true</EmbedUntrackedSources>
  <IncludeSymbols>true</IncludeSymbols>
  <SymbolPackageFormat>snupkg</SymbolPackageFormat>
  <PackageLicenseFile>LICENSE.md</PackageLicenseFile>
</PropertyGroup>
```

We chose DebugType = portable because Visual Studio will error out if you combine SymbolPackageFormat=snupkg and DebugType=embedded.  Additionally, Nuget.org allows the upload of the \*.snupkg but Github Packages does not.

Read their [site](https://github.com/dotnet/sourcelink) to learn more.

# Deterministic Builds

(copied directly from their site) 
Deterministic builds are important as they enable verification that the resulting binary was built from the specified source and provides traceability.

Plus it gives another checkbox on the Nuget Package Explorer that makes things look more professional. 

Since we are using GitHub for this solution we added their specific items to the project file. 

```
<PropertyGroup Condition="'$(GITHUB_ACTIONS)' == 'true'">
  <ContinuousIntegrationBuild>true</ContinuousIntegrationBuild>
</PropertyGroup>
```
As noted, this only happens during the github workflow builds to avoid interfering with local dev builds. 

Read their [site](https://github.com/clairernovotny/DeterministicBuilds) to learn more.

# Nuget Package Explorer

(copied directly from their site)
NuGet Package Explorer (NPE) is an application that makes it easy to create and explore NuGet packages. You can load a .nupkg or .snupkg file from disk or directly from a feed such as nuget.org.

This is the application that gives you the nice checkboxes to say your nuget package is good.

Read their [site](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) to learn more.


## Additional References 

[Microsoft Learn - SourceLink Guidance](https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink)