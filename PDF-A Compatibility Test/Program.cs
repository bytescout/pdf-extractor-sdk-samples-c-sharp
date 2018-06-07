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


using System;
using Bytescout.PDFExtractor;

namespace PDFATest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.PDFAValidator instance
			PDFAValidator validator = new PDFAValidator();
			validator.RegistrationName ="demo";
			validator.RegistrationKey = "demo";

			// Load sample PDF document
            validator.LoadDocumentFromFile("sample1.pdf");

		    if (validator.IsPDFA)
		        Console.WriteLine("This file conforms to the PDF/A standard");
		    else
		    {
		        Console.WriteLine("This file doesn't conform to the PDF/A standard.");
		        Console.WriteLine("Issues:");

		        foreach (string validationError in validator.ValidationErrors)
		            Console.WriteLine(validationError);
		    }

			// Cleanup
			validator.Dispose();

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
