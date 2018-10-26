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


using Bytescout.PDFExtractor;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace RepairText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Generate CSVExtractor instance
                using (CSVExtractor extractor = new CSVExtractor("demo", "demo"))
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile("sample.pdf");

                    // Get all data
                    string allData = extractor.GetCSV();

                    // Regular expressions and replacements
                    string ssnRegex = @"\d{3}[-]?\d{2}[-]?\d{4}";
                    string ssnReplace = "***-**-****";

                    string phoneRegex = @"\d{3}[-]?\d{3}[-]?\d{4}";
                    string phoneReplace = "***-***-****";

                    // Find and mask SSN and phone numbers
                    allData = Regex.Replace(allData, ssnRegex , ssnReplace);
                    allData = Regex.Replace(allData, phoneRegex, phoneReplace);

                    // Write as CSV
                    File.WriteAllText("output.csv", allData);

                    // Open file
                    Process.Start("output.csv");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to close...");
            Console.ReadLine();
        }
    }
}
