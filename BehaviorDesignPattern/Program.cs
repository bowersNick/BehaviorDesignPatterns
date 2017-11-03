using System;

namespace BehaviorDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ChainOfResponsibility.ChainOfResponsibility.ChainCall();

			Console.WriteLine("\nHit Enter key to exit");
			int key;
			while ((key = Console.Read()) != 13)
			{

			}

			CommandPattern.InteractiveShell.Run();

			InterpreterPattern.Client.Main();
		}
	}
}
