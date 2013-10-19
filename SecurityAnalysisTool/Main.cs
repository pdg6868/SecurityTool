using System;
using System.Collections.Generic;

namespace SecurityAnalysisTool
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Parser p = new Parser();
			List<Result> results = p.Parse();

			Console.WriteLine("Results Parsed");

			//Run tools here

			//Graph results
		}
	}
}
