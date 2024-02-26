# Generate and Integrate Code between Github, Codacy, and NuGet

[Home](README.md)

Codacy has free accounts that easily integrate with github repositories like this project. This integration can provide valuable metrics while reducing the complexity of integration with other metric generating tools.

## What do we want to accomplish?

  1. Using Github
      1. Build solution
      1. Execute Tests
      1. Generate coverage results
      1. Upload coverage report to Codacy
      1. Generate Nuget Packages
      1. Upload package as artifact of workflow. 
      1. Upload SNAPSHOT version to Github Packages for validation.
  2. Using Codacy
      1. Examine Results of Codacy evaluation to identify issues needing attention.
      1. Examine Results of Coverage Report to identify test gaps to be addressed.
  3. Using Nuget.org 
      1. Promote/upload RELEASE versions of nuget package and supporting items. 
      1. Manage release visibility/deprecation

## How do we do it?

dotnet tools allow for most of these actions to be accomplished.

| Step | conditional | github action command |
| --- | --- | --- |
| Checkout code | | actions/checkout |
| Install dotnet tools | | dotnet tool restore |
| Restore solution | | dotnet restore |
| Build solution | | dotnet build ... |
| Run tests with coverage | | dotnet test ... |
| Install Report Generator | | dotnet tool install ... |
| Build Coverage Reports | | reportgenerator ... |
| Convert Coverage Report to Markdown file | | irongut/CodeCoverageSummary |
| Add Report to PR Comment | | marocchino/sticky-pull-request-comment |
| Add Coverage Report to Job Summary | | >> $GITHUB_STEP_SUMMARY |
| Upload Coverage Report to Codacy | | codacy/codacy-coverage-reporter-action |
| Generate NuGet Package | | dotnet pack ... |
| Add Package to Artifacts | | actions/upload-artifact |
| Upload Nuget Package to Github Packages | on build | -**in progress**- |
| Promote/upload NuGet Package to Nuget.org | on release | -**in progress**- |

## References

[Github Build Workflow](.github/workflows/build-and-package.yml) - Build, Test, Package, and Report
