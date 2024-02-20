[Home](README.md)

# Generate and Integrate Code between Github, Codacy, and NuGet 

Codacy has free accounts that easily integrate with github repositories like this project.  This integration can provide valuable metrics while reducing the complexity of integration with other metric generating tools. 

## What do we want to accomplish?

  1. Using Github
      1. Check out current code
      1. Build solution
      1. Execute Tests and generate coverage results
      1. Format test results compliant with codacy needs
      1. Upload coverage report to Codacy
  2. Using Codacy
      1. Examine Results of Codacy evaluation
      1. Examine Results of Coverage Report

## How do we accomplish? 

dotnet tools allow for most of these actions to be accomplished. 

| Step | github action command |
| --- | --- |
| Checkout code | actions/checkout |
| Install dotnet tools | dotnet tool restore | 
| Restore solution | dotnet restore | 
| Build solution | dotnet build ... | 
| Run tests | dotnet test ... |
| Install Report Generator | dotnet tool install ... |
| Build Reports | reportgenerator ... | 
| Generate Report as Markdown | irongut/CodeCoverageSummary | 
| Add Report to PR Comment | marocchino/sticky-pull-request-comment | 
| Upload Report to Codacy | codacy/codacy-coverage-reporter-action | 
| Add Coverage Report to Job Summary | >> $GITHUB_STEP_SUMMARY | 
| Generate NuGet Package | dotnet pack ... | 
| Add Package to Artifacts | actions/upload-artifact | 
| Upload NuGet Package to Nuget.org | -**in progress**- | 

# References
[Github Build Workflow](.github/workflows/build-and-package.yml) - Build, Test, Package, and Report
