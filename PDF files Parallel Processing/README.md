## PDF files parallel processing in C# and ByteScout PDF Extractor SDK

### How to code PDF files parallel processing in C#: How-To tutorial

We’ve created and updating regularly our sample code library so you may quickly learn PDF files parallel processing and the step-by-step process in C#. ByteScout PDF Extractor SDK was made to help with PDF files parallel processing in C#. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

C# code snippet like this for ByteScout PDF Extractor SDK works best when you need to quickly implement PDF files parallel processing in your C# application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Further enhancement of the code will make it more vigorous.

ByteScout PDF Extractor SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****Parallel Processing.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Parallel Processing.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{CBF4D08A-5750-40F1-A50F-97FED95192D5}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Parallel_Processing</RootNamespace>
    <AssemblyName>Parallel Processing</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|AnyCPU'">
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=8.7.0.2981, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.IO;
using System.Threading;
using Bytescout.PDFExtractor;

namespace Parallel_Processing
{
    class Program
    {
        // Limit to 4 threads in queue.
        // Set this value to number of your processor cores for max performance.
        private static readonly Semaphore ThreadLimiter = new Semaphore(4, 4);

        static void Main(string[] args)
        {
            // Get all PDF files in a folder
            string[] files = Directory.GetFiles(@"..\..\..\..\", "*.pdf");
            // Array of events to wait
            ManualResetEvent[] doneEvents = new ManualResetEvent[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                // Wait for the queue
                ThreadLimiter.WaitOne();

                // Start thread with filename and event in params
                doneEvents[i] = new ManualResetEvent(false);
                object[] threadData = new object[] { files[i], doneEvents[i] };
                ThreadPool.QueueUserWorkItem(ConvertPdfToTxt, threadData);
            }

            // Wait until all threads finish
            WaitHandle.WaitAll(doneEvents);

            Console.WriteLine();
            Console.WriteLine("All is done.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ConvertPdfToTxt(object state)
        {
            // Get filename and event from params
            string file = (string) ((object[]) state)[0];
            ManualResetEvent doneEvent = (ManualResetEvent)((object[])state)[1];

            string resultFileName = Path.GetFileName(file) + ".txt";

            try
            {
                Console.WriteLine("Converting " + file);

                using (TextExtractor extractor = new TextExtractor("demo", "demo"))
                {
                    extractor.LoadDocumentFromFile(file);
                    extractor.SaveTextToFile(resultFileName);
                }

                Console.WriteLine("Finished " + resultFileName);
            }
            finally
            {
                // Signal the thread is finished
                doneEvent.Set();
                // Release semaphore
                ThreadLimiter.Release();
            }
        }
    }
}

```

<!-- code block end -->