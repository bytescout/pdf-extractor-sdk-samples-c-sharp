//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using Bytescout.PDFExtractor;
using System.Drawing;

namespace ExtractTextFromPageArea
{
    class Program
    {
        static void Main(string[] args)
        {
            TextExtractor extractor = new TextExtractor("demo", "demo");

            // Load document
            extractor.LoadDocumentFromFile(@".\sample2.pdf");

            // Get page count
            int pageCount = extractor.GetPageCount();

            // Iterate through pages
            for (int i = 0; i < pageCount; i++)
            {
                // Define rectangle location to extract from
                RectangleF location = new RectangleF(0, 0, 200, 200);
                
                // Set extraction area
                extractor.SetExtractionArea(location);

                // Extract text from the extraction area
                string text = extractor.GetTextFromPage(i);
                
                Console.WriteLine("Extracted from page #" + i + ":");
                Console.WriteLine();
                Console.WriteLine(text);

                // Reset the extraction area
                extractor.ResetExtractionArea();

                Console.WriteLine();
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
