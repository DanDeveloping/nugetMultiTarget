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

dotnet tools allow for most of these actions to be accomplished.  There are a few actions we can use on top of that to round out this effort. 

### Regular Build [pull request and merge to main]
| Step | github action command |
| --- | --- |
| Checkout code | actions/checkout |
| Update Version Information | **in progress** | 
| Install dotnet tools | dotnet tool restore |
| Restore solution | dotnet restore |
| Build solution | dotnet build ... |
| Run tests with coverage | dotnet test ... |
| Install Report Generator | dotnet tool install ... |
| Build Coverage Reports | reportgenerator ... |
| Convert Coverage Report to a Markdown file | irongut/CodeCoverageSummary |
| Add Report to PR Comment | marocchino/sticky-pull-request-comment |
| Add Coverage Report to Job Summary | >> $GITHUB_STEP_SUMMARY |
| Upload Coverage Report to Codacy | codacy/codacy-coverage-reporter-action |
| Generate NuGet Package | dotnet pack ... |
| Add Package to Artifacts | actions/upload-artifact |

### Merge to main (additional steps)
| Step | githb action command |
| --- | --- |
| Upload Nuget Package to Github Packages | dotnet nuget push -**in progress**- |

Once the code is merged to main, we are going to perform all the branch work again, but this time we are going to build the package to be uploaded to Github Packages space.  This merged code is the official code we will use all the way to RELEASE if this version passes validations.

### Release 
| Step | githb action command |
| --- | --- |
| Download Package from snapshot | **in progress | 
| Promote/upload NuGet Package to Nuget.org | dotnet nuget push -**in progress**- |

The Release action WILL NOT rebuild the packages but to PROMOTE the selected snapshot to Nuget.org.  This protects the code from accidental changes in main that are missed between SNAPSHOT and RELEASE.

## References

[Github Build Workflow](.github/workflows/build-and-package.yml) - Build, Test, Package, and Report
