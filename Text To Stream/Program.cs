//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace ExtractTextByPages
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample1.pdf");

			// Get page count
			int pageCount = extractor.GetPageCount();

            string outputText = "";

            for (int i = 0; i < pageCount; i++)
			{
                // create new file stream
			    FileStream fStream = new FileStream("page" + i.ToString() + ".txt", FileMode.Create);
                
                // save text from page #i to the file stream
                extractor.SavePageTextToStream(i, fStream);

                // close stream
                fStream.Close();
				
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page1.txt");
		}
	}
}
