//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace FindText
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
			extractor.LoadDocumentFromFile("sample2.pdf");
			
			int pageCount = extractor.GetPageCount();

			// Search each page for some keyword 
			for (int i = 0; i < pageCount; i++)
			{
				if (extractor.Find(i, "References", false))
				{
					// If page contains the keyword, extract a text from it.
					// For demonstration we'll extract the text from top part of the page only
					extractor.SetExtractionArea(0, 0, 600, 200);
					string text = extractor.GetTextFromPage(i);
					Console.WriteLine(text);
				}
			}
			
			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
