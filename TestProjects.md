[Home](README.md)

# Testing a project that builds against multiple targets

## Status [Complete]

Because we need to test those projects, we need a test project that consumes those version as well as any downstream versions we plan to expressly support.  The way we accomplish this is targeting not only the versions the source project specifically targeted but those supporting targets as well. See the grid at the top of this page to see how they match up. 

### How do we test a multiple target project?

The dotnet tools allows a single test to be run against all the different targetframeworks set by the project file.  Therefore, the math becomes the #TargetFrameworks * #Tests = #TestCountExecuted. 

# References
