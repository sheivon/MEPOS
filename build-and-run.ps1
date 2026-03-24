# Build and run script for Marshells solution (main: Marshell Web)
# Usage: .\build-and-run.ps1

$solution = "Marshells.sln"
$project = "Marshell Web\Marshell Web.csproj"
$configuration = "Release"
$solutionPlatform = "Any CPU"
$projectPlatform = "AnyCPU"

# Prefer MSBuild for legacy .NET Framework Web/WinForms/WPF projects.
$msbuildPaths = @(
    "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe",
    "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe",
    "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe",
    "${env:ProgramFiles}\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe",
    "${env:ProgramFiles}\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
)
$msbuild = $null
foreach ($p in $msbuildPaths) {
    if (Test-Path $p) { $msbuild = $p; break }
}

Write-Host "Restoring NuGet packages (project-only) ..." -ForegroundColor Cyan
if (Get-Command nuget -ErrorAction SilentlyContinue) {
    nuget restore "$project"
    if ($LASTEXITCODE -ne 0) {
        Write-Warning "NuGet restore failed; continuing to build in case build already has required files."
    }
} else {
    Write-Warning "NuGet CLI not found; skipping restore. Ensure that packages under ..\packages are present for all projects."
}

Write-Host "Building solution ($configuration|$platform)..." -ForegroundColor Cyan
if ($msbuild) {
    # If available, set VSToolsPath to matching VS version for WebApplication target resolution.
    $webAppToolsCandidates = @(
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Enterprise\MSBuild\Microsoft\VisualStudio\v17.0",
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\BuildTools\MSBuild\Microsoft\VisualStudio\v16.0"
    )
    $buildProps = @("/p:Configuration=$configuration", "/p:Platform=$projectPlatform")
    foreach ($candidate in $webAppToolsCandidates) {
        if (Test-Path "$candidate\WebApplications\Microsoft.WebApplication.targets") {
            $buildProps += "/p:VSToolsPath=$candidate"
            $buildProps += "/p:VisualStudioVersion=$((Split-Path -Leaf $candidate) -replace 'v','')"
            break
        }
    }

    & "$msbuild" "$project" $buildProps
    if ($LASTEXITCODE -ne 0) {
        Write-Error "MSBuild failed"; exit $LASTEXITCODE
    }
} else {
    Write-Warning "MSBuild not found; using dotnet build fallback (legacy web project may fail)."
    dotnet build "$project" --configuration $configuration /p:Platform="$projectPlatform"
    if ($LASTEXITCODE -ne 0) { Write-Error "dotnet build failed"; exit $LASTEXITCODE }
}

Write-Host "Running Marshell Web..." -ForegroundColor Cyan
$iisExpress = "${env:ProgramFiles(x86)}\IIS Express\iisexpress.exe"
if (-not (Test-Path $iisExpress)) {
    Write-Warning "IIS Express not found; please run the web project from Visual Studio manually."
    Write-Host "Build and run completed with successful build only." -ForegroundColor Green
    exit 0
}

$webRoot = Resolve-Path -Path "Marshell Web"
Write-Host "Starting IIS Express at https://localhost:44372/" -ForegroundColor Cyan
Start-Process -FilePath $iisExpress -ArgumentList "/path:$webRoot", "/port:44372"

Write-Host "Build and run completed successfully (web server started)." -ForegroundColor Green
