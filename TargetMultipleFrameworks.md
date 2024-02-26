# Target Multiple Frameworks in single Project

[Home](README.md)

## Status [Complete]

We want to generate a project that targets multiple frameworks so that we can generate a NuGet package that would make things simpler to consume when trying to upgrade downstream projects while maintaining legacy projects at the same time.

We want to do this as easily and with the least overhead as possible.

## How does the solution target multiple Frameworks?

Using a SDK style project, we can modify the [project file](DanDeveloping.Echo/DanDeveloping.Echo.csproj).
By Removing the \<TargetFramework> node and replacing it with the \<TargetFrameworks> node then adding the target frameworks desired.

### Example

```
<TargetFramework>.net6</TargetFramework>
```
becomes
```
<TargetFrameworks>net47;net6.0;net8.0;netstandard2.0</TargetFrameworks>
```

A lot of things are going to change in the Project's Properties to accommodate all these frameworks.

### Build Category

#### General Section - Conditional Compilation Symbols

You can set custom items for each of the frameworks we are now targeting. 

#### Errors and Warnings - Warning Levels

This section allows you to set warning levels for each target framework. 

**NOTE** 
You will have to do some of your own investigation as to the functionality of those areas as this solution is just pointing out that there are a few changes you should expect when changing to a multiple framework project. 

## References

[Microsoft Learn - Support multiple .NET Framework versions in your project file](https://learn.microsoft.com/en-us/nuget/create-packages/multiple-target-frameworks-project-file)
[Microsoft Learn - Framework targeting overview](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-multi-targeting-overview?view=vs-2022)
[Visual Studio 2022 Platform Targeting and Compatibility](https://learn.microsoft.com/en-us/visualstudio/releases/2022/compatibility)