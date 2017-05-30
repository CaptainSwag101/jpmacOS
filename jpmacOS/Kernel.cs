using System;
using System.Collections.Generic;
using Sys = Cosmos.System;

namespace jpmacOS
{
	public class Kernel : Sys.Kernel
	{
		private string copyrightInfo = "jpmacOS v0.0.1 (c) 2017 James Pelster.";
		private List<TestObject> testList = new List<TestObject>();

		protected override void BeforeRun()
		{
			Console.Clear();
			//Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
			Console.WriteLine(copyrightInfo);
			Console.WriteLine("Cosmos kernel loaded.");
			Console.WriteLine("jpmacOS booted successfully!");
		}

		protected override void Run()
		{
			Console.Write("Input: ");
			var input = Console.ReadLine();
			//if (input.Split().Length > 1 && input.Split()[0] == "new" & input.Split()[1] == "test")
			//if (string.IsNullOrWhiteSpace(input))
			//{
			//    return;
			//}
			//string[] words = input.Split();
			//if (words[0] == "new")
			//{
			//    if (words.Length > 1 && words[1] == "test")
			//    {
			//        testList.Add(new TestObject());
			//        Console.Write("testList now contains ");
			//        if (testList.Count != 1)
			//            Console.WriteLine(testList.Count + " TestObjects.");
			//        else
			//            Console.WriteLine(testList.Count + " TestObject.");
			//    }
			//}
			if (input == "new test")
			{
				testList.Add(new TestObject());
				Console.Write("testList now contains ");
				if (testList.Count != 1)
					Console.WriteLine(testList.Count + " TestObjects.");
				else
					Console.WriteLine(testList.Count + " TestObject.");
			}
			else if (input == "clearlist")
			{
				testList.Clear();
				Console.WriteLine("testList cleared successfully.");
			}
			else if (input == "clear")
			{
				Console.Clear();
			}
			else if (input == "cls")
			{
				Console.Clear();
			}
			else if (input == "exit")
			{
				Sys.Power.Reboot();
				Stop();
			}
			else if (input == "about")
			{
				Console.WriteLine(copyrightInfo);
			}
			else
			{
				Console.Write("Text typed: ");
				Console.WriteLine(input);
			}
		}
	}
}
