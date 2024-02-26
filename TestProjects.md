# Testing a project that builds against multiple targets

[Home](README.md)

## Status [Complete]

Because we need to test this project, we need to add a test project that consumes the various specific versions as well as the downstream versions we plan to expressly support.  The way we accomplish this is targeting not only the versions the source project specifically builds against but those supporting targets as well. See the [Test Targets](#test-targets) below to see how they match up.

## Test Targets 

The Test Project will act like downstream projects by testing:

- .NET Framework 4.7
  Tested by:
  - .NET Framework 4.7
  - .NET Framework 4.8
- .NET 6
  Tested by:
  - .NET 6
  - .NET 7
- .NET 8
  Tested by:
  - .NET 8
- .NETSTANDARD 2.0
  Tested by:
  - .NET 5


### How do we test a multiple target project?

The dotnet tools along with Visual Studio allows a single test to be run against all the different targetframeworks set by the project file.  Therefore, the math becomes the #TargetFrameworks * #Tests = #TestCountExecuted without repeating yourself that many times.

## References
