# Target Multiple Frameworks in single Project

[Home](README.md)

## Status [Complete]

We want to generate a project that targets multiple frameworks so that we can generate a NuGet package that would make things simpler to consume when trying to upgrade downstream projects.

We want to do this as easily as possible with the least overhead as possible.

### How does the solution target multiple Frameworks?

Using a SDK style project, we can modify the [project file](DanDeveloping.Echo/DanDeveloping.Echo.csproj).
By Removing the \<TargetFramework> node and replacing it with the \<TargetFrameworks> node then adding the target frameworks desired.

#### Example

> \<TargetFramework>.net6\</TargetFramework>
> \<TargetFrameworks>net47;net6.0;net8.0;netstandard2.0\</TargetFrameworks>

## References

[Microsoft Learn - Support multiple .NET Framework versions in your project file](https://learn.microsoft.com/en-us/nuget/create-packages/multiple-target-frameworks-project-file)
