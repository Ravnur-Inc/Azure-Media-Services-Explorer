---
page_type: sample
languages:
- csharp
products:
- azure
- azure-media-services
---

# Azure Media Services Explorer for Ravnur

The Azure Media Services Explorer (AMSE), an open-source project from Microsoft, is a Windows desktop application that allows users to work with Azure Media Services (AMS) for uploading, encoding and streaming media assets. It connects to AMS using the AMS v3 API, which means that it can natively connect to [Ravnur Media Services (RMS)](https://www.ravnur.com/). Now that Microsoft has retired AMS, Ravnur has forked the library and maintains a version that works with RMS, which we call AMSE for RMS. 

Using the AMSE for RMS, you can:

- upload assets
- download encoded assets
- encode assets using standard or custom transforms
- protect assets using AES and DRM encryption
- stream VOD and live content.


The AMSE for RMS can be downloaded from [the Releases page](https://github.com/Ravnur-Inc/Azure-Media-Services-Explorer/releases).

## Installing the tool with Winget

Run the following commands in a command prompt to install the prerequisites and AMSE :

```console
winget install Microsoft.DotNet.DesktopRuntime.7
winget install Microsoft.EdgeWebView2Runtime
winget install Microsoft.AzureMediaServicesExplorer
```

## Manual installation

**The latest binary for Windows (with a MSI installer) is available in the [releases section](https://github.com/Azure/Azure-Media-Services-Explorer/releases)**.

This application requires the installation of

- [.NET **Desktop** Runtime 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Microsoft Edge Webview2 runtime](https://developer.microsoft.com/microsoft-edge/webview2/)

## Prerequisites to compile the solution from source

This solution has been developed using [Visual Studio 2022](https://visualstudio.microsoft.com/vs/). It contains two projects: "AMSExplorer", the main application, and "Setup", a project that creates a Setup executable (EXE/MSI).

You need to install the [Microsoft Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects) in order to open and build the Setup project in Visual Studio.

This solution requires [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet/7.0) to compile.


> [!NOTE]
> This is a console application to help you test the Ravnur Media Services API. The link above is not the repo for Ravnur Media Services. You will require the deployed RMS managed application from the Azure Marketplace.

## Connect AMSE to RMS

1. Get your [RMS account credentials](https://github.com/Ravnur-Inc/ams-api-replacement-demo-app/blob/main/docs/how-to-get-credentials.md) and copy them.
2. Open Azure Media Service Explorer on your PC and select __Pick-up Ravnur account…__
3. Select the appropriate environment that corresponds to the Azure environment where RMS is deployed.
4. When the pop-up appears, paste the credentials you copied earlier and click Save.
5. Click on Connect in the AMSE main menu and authenticate using your Microsoft Entra account credentials.

> [!NOTE]
> All users connecting to the same RMS account in AMSE for RMS have access to the same list of saved transforms and the same job history. The data is tied to the RMS account, not to individual users. Thus, saved records in the account are available to anyone who connects to it.


## Notes

You can force the English or Japanese language by using /language:en-US or /language:ja-JA as a parameter of the AMSExplorer.exe executable.

AMSE uses Application Insights for Telemetry. This feature can be turned off in the Options of AMSE.

## Contacts

Contact: <support@ravnur.com>

## Contributing

This project welcomes contributions and suggestions. Please see our [contributing guide](CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](CODE_OF_CONDUCT.md).

## Data Collection

The software may collect information about you and your use of the software and send it to Microsoft. Microsoft may use this information to provide services and improve our products and services. You may turn off the telemetry as described in the repository. There are also some features in the software that may enable you and Microsoft to collect data from users of your applications. If you use these features, you must comply with applicable law, including providing appropriate notices to users of your applications together with a copy of Microsoft's privacy statement. Our privacy statement is located at <https://go.microsoft.com/fwlink/?LinkID=824704>. You can learn more about data collection and use in the help documentation and our privacy statement. Your use of the software operates as your consent to these practices.

## Security

Please read our [security policy](SECURITY.md) to learn how to report security issues.
