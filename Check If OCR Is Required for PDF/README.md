## check if OCR is required for PDF in C# and ByteScout PDF Extractor SDK

### How to use ByteScout PDF Extractor SDK for check if OCR is required for PDF in C#

Source code documentation samples provide quick and easy way to add a required functionality into your application. Check if OCR is required for PDF in C# can be implemented with ByteScout PDF Extractor SDK. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

The SDK samples like this one below explain how to quickly make your application do check if OCR is required for PDF in C# with the help of ByteScout PDF Extractor SDK. Follow the instruction from the scratch to work and copy and paste code for C# into your editor. Further enhancement of the code will make it more vigorous.

Trial version can be downloaded from our website. Source code samples for C# and documentation are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### ****CheckIfOCRIsRequired.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>CheckIfOCRIsRequired</RootNamespace>
    <AssemblyName>CheckIfOCRIsRequired</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="InputFiles\sample_ocr_not_required.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample_ocr_required.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.PDFExtractor;
using System;

namespace CheckIfOCRIsRequired
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Loop through all files in directory and check whether OCR operation is required
                foreach (string filePath in System.IO.Directory.GetFiles("InputFiles"))
                {
                    _CheckOCRRequired(filePath);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

			Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        
        /// <summary>
        /// Check whether OCR Operation is required
        /// </summary>
        /// <param name="filePath"></param>
        private static void _CheckOCRRequired(string filePath)
        {
            //Read all file content...
            using (TextExtractor extractor = new TextExtractor())
            {
                extractor.RegistrationKey = "demo";
                extractor.RegistrationName = "demo";

                // Load document
                extractor.LoadDocumentFromFile(filePath);
                Console.WriteLine("\n*******************\n\nFilePath: {0}", filePath);

                int pageIndex = 0;

                // Identify OCR operation is recommended for page
                if (extractor.IsOCRRecommendedForPage(pageIndex))
                {
                    Console.WriteLine("\nOCR Recommended: True");

                    // Enable Optical Character Recognition (OCR)
                    // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                    extractor.OCRMode = OCRMode.Auto;

                    // Set the location of language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

                    // Set PDF document rendering resolution
                    extractor.OCRResolution = 300;
                }
                else
                {
                    Console.WriteLine("\nOCR Recommended: False");
                }

                //Read all text
                var allExtractedText = extractor.GetText();
                Console.WriteLine("\nExtracted Text:\n{0}\n\n", allExtractedText);
            }

        }

    }
}

```

<!-- code block end -->