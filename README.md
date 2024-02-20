[![Codacy Badge](https://app.codacy.com/project/badge/Grade/686e979f10184a749eac6553f49b830a)](https://app.codacy.com/gh/dmstrat/nugetMultiTarget/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade) [![Codacy Badge](https://app.codacy.com/project/badge/Coverage/686e979f10184a749eac6553f49b830a)](https://app.codacy.com/gh/dmstrat/nugetMultiTarget/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_coverage)

# NugetMultiTarget Project

Learning to develop multitargeted nuget packages for .NET targets

# Purpose of the Project

Here we can learn how to define, build, test, and report code coverage on a MultiTargeted Framework SDK type project. 

In this project we will build a single solution that targets multiple frameworks to allow for the maximum supportability of downstream projects and solutions. 

# What does the project do exactly?

This is a sample project that simply creates an 'echo' of a string provided to the Echoer Class with the limitation of only returning the last 15 characters of the string provided.  If the string is less than or equal to 15 characters then the entire string is returned.  It was based on the idea that if you yell too much for an echo you'll only hear the last part of what you said.  

## Project Targets

The Project we are creating will target: 

- .NET Framework 4.7 (legacy projects)
- .NET 6 (current LTS but EOL late 2024)
- .NET 8 (lext LTS version)
- .NETSTANDARD 2.0 (recommended version for support SDK projects)

## Test Targets

The Test Project will act like downstream projects by testing: 

- .NET Framework 4.7
  Will be tested by: 
  - .NET Framework 4.7
  - .NET Framework 4.8
- .NET 6
  Will be tested by: 
  - .NET 6
  - .NET 7
- .NET 8
  Will be tested by:
  - .NET 8
- .NETSTANDARD 2.0 
  Will be tested by: 
  - .NET 5

# Goals of this Solution

1. [Target multiple .NET Frameworks](TargetMultipleFrameworks.md) in a single solution/project. 
2. [Testing projects](TestProjects.md) against anticipated downstream versions to reduce revists to this code until a new version needs support or an old version is deprecated. 
3. [Integrate between Github, Codacy, and NuGet](GithubAndCodacy.md) 
4. Documentation - Generate and Integrate as much documentation as required for a professional look both on NuGet.org and when consuming the package in downstream solutions.
5. Use individually created downstream projects that consume specific versions of the NuGet Package for integration testing.
6. More Birds with this stone - learn more things while we're here. 

# References
