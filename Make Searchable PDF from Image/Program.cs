//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDFExtractor;

// To make OCR work you should add to your project references to Bytescout.PDFExtractor.dll and Bytescout.PDFExtractor.OCRExtension.dll 

namespace MakeSearchablePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            SearchablePDFMaker searchablePDFMaker = new SearchablePDFMaker();
            searchablePDFMaker.RegistrationName = "demo";
            searchablePDFMaker.RegistrationKey = "demo";

            // Load sample Image document
            searchablePDFMaker.LoadDocumentFromFile("sample_ocr.jpg");
            
            // Set the location of "tessdata" folder containing language data files
            searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\";

            // Set OCR language
            searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata

            // Set PDF document rendering resolution
            searchablePDFMaker.OCRResolution = 300;

            // Save extracted text to file
            searchablePDFMaker.MakePDFSearchable("output.pdf");

            // Cleanup
            searchablePDFMaker.Dispose();

            // Open output file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
