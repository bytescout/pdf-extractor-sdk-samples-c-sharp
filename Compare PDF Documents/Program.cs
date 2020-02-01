//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace CompareDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load first document
            TextExtractor document1 = new TextExtractor();
            document1.RegistrationName = "demo";
            document1.RegistrationKey = "demo";
            document1.LoadDocumentFromFile(@".\comparison1.pdf");

            // Load second  document
            TextExtractor document2 = new TextExtractor();
            document2.RegistrationName = "demo";
            document2.RegistrationKey = "demo";
            document2.LoadDocumentFromFile(@".\comparison2.pdf");

            // Compare documents
            TextComparer comparer = new TextComparer();
            comparer.RegistrationName = "demo";
            comparer.RegistrationKey = "demo";
            comparer.Compare(document1, document2);

            // Generate report
            comparer.GenerateHtmlReport(@".\report.html");

            document1.Dispose();
            document2.Dispose();

            // Open the report in default browser
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\report.html");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
