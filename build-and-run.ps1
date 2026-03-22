# Build and run script for Marshells solution
# Usage: .\build-and-run.ps1

$solution = "Marshells.sln"
$project = "Marshells"

Write-Host "Restoring NuGet packages..." -ForegroundColor Cyan
dotnet restore "$solution"
if ($LASTEXITCODE -ne 0) { Write-Error "dotnet restore failed"; exit $LASTEXITCODE }

Write-Host "Building solution..." -ForegroundColor Cyan
dotnet build "$solution" --configuration Release
if ($LASTEXITCODE -ne 0) { Write-Error "dotnet build failed"; exit $LASTEXITCODE }

Write-Host "Running project..." -ForegroundColor Cyan
dotnet run --project "$project" --configuration Release
if ($LASTEXITCODE -ne 0) { Write-Error "dotnet run failed"; exit $LASTEXITCODE }

Write-Host "Build and run completed successfully." -ForegroundColor Green
