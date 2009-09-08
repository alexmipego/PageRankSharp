using System;
using PageRankSharp;

namespace PageRankSharpConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0)
				Console.WriteLine(PageRankChecker.CheckUrl(args[0]));
			else
				Console.WriteLine("Google Page Rank Checker\nUsage: [mono] pagerank.exe url");
		}
	}
}
