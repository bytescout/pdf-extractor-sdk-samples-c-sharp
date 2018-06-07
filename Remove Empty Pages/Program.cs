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


using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Bytescout.PDFExtractor;

namespace RemoveEmptyPagesExample
{
    /// <summary>
    /// The example demonstrates detection of empty pages, splitting the document to separate
    /// pages excluding empty ones, then combine parts back to a single document.
    /// </summary>
    class Program
    {
        static string InputFile = @".\sample.pdf";
        static string OutputFile = @".\result.pdf";
        static string TempFolder = @".\temp";

        static void Main(string[] args)
        {
            // Create and setup Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor("demo", "demo");
            
            // Load PDF document
            extractor.LoadDocumentFromFile(InputFile);

            // List to keep non-empty page numbers
            List<string> nonEmptyPages = new List<string>();

            // Iterate through pages
            for (int pageIndex = 0; pageIndex < extractor.GetPageCount(); pageIndex++)
            {
                // Extract page text
                string pageText = extractor.GetTextFromPage(pageIndex);
                // If extracted text is not empty keep the page number
                if (pageText.Length > 0)
                    nonEmptyPages.Add((pageIndex + 1).ToString());
            }

            // Cleanup
            extractor.Dispose();


            // Form comma-separated list of page numbers to split("1,3,5")
            string ranges = string.Join(",", nonEmptyPages);

            // Create Bytescout.PDFExtractor.DocumentSplitter instance
            DocumentSplitter splitter = new DocumentSplitter("demo", "demo");
            splitter.OptimizeSplittedDocuments = true;

            // Split document by non-empty in temp folder
            string[] parts = splitter.Split(InputFile, ranges, TempFolder);

            // Cleanup
            splitter.Dispose();


            // Create Bytescout.PDFExtractor.DocumentMerger instance
            DocumentMerger merger = new DocumentMerger("demo", "demo");

            // Merge parts
            merger.Merge(parts, OutputFile);

            // Cleanup
            merger.Dispose();

            // Delete temp folder
            Directory.Delete(TempFolder, true);


            // Open the result file in default PDF viewer (for demo purposes)
            Process.Start(OutputFile);
        }
    }
}
