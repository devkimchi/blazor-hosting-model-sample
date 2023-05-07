# Blazor Hosting Model Sample

This provides sample code that shows various types of Blazor hosting models - Server, WASM (hosted/standalone) and Hybrid (MAUI/WinForm/WPF). They all share the same components with minimal code changes.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/?WT.mc_id=dotnet-96001-juyoo)
- [Azure Functions Core Tools](https://learn.microsoft.com/azure/azure-functions/functions-run-local?WT.mc_id=dotnet-96001-juyoo)
- [SWA CLI](https://azure.github.io/static-web-apps-cli/)

> Due to the nature of the sample applications, it only targets Windows OS.

## Getting Started

1. Fork this repository.
1. Clone the forked repository to your local machine.
1. Open the solution, `BlazorHostingModels.sln`, with Visual Studio.
1. Build the entire solution.

   > There might be a chance that solution build fails. Then, clean the solution first and rebuild the solution.

1. Run the backend API in a separate terminal or console like [Visual Studio Code](https://code.visualstudio.com/?WT.mc_id=dotnet-96001-juyoo), [Windows Terminal](https://learn.microsoft.com/windows/terminal/?WT.mc_id=dotnet-96001-juyoo) or [PowerShell](https://learn.microsoft.com/powershell/scripting/overview?WT.mc_id=dotnet-96001-juyoo).

    ```powershell
    cd src/BackendApi
    func start
    ```

1. Run each project individually to see how it works.

   > For the hosted Blazor WASM app, run the following SWA CLI command within Visual Studio Code, Windows Terminal or PowerShell:
   > 
   > ```powershell
   > swa start
   > ```

## Something More?

- [Migrating ASP.NET WebForm to Blazor](https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/migration?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hosting Model &ndash; Server and WebAssembly (hosted/standalone)](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid Overview](https://learn.microsoft.com/aspnet/core/blazor/hybrid/?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid MAUI](https://learn.microsoft.com/aspnet/core/blazor/hybrid/tutorials/maui?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid WinForm](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/windows-forms?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid WPF](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/wpf?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid routing and navigation](https://learn.microsoft.com/aspnet/core/blazor/hybrid/routing?WT.mc_id=dotnet-96001-juyoo)
- [Blazor Hybrid reusing components](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/reuse-razor-components?WT.mc_id=dotnet-96001-juyoo)
