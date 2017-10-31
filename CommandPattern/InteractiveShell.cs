using System;

namespace CommandPattern
{
	// Client
	public class InteractiveShell
	{
		public static void Run()
		{
			// instantiate math library
			MathLib mathlib = new MathLib();

			// instantiate calculate
			Calculator calculator = new Calculator();

			// show help
			Console.WriteLine("Please input a math operation");
			Console.WriteLine(" + <number>: add number");
			Console.WriteLine(" - <number>: subtract number");
			Console.WriteLine(" * <number>: multiply number");
			Console.WriteLine(" / <number>: divide number");
			Console.WriteLine(" ~ <steps>: undo steps");
			Console.WriteLine(" q: quit");
			Console.WriteLine();

			// loop until user presses Q
			string input;
			while ((input = Console.ReadLine()) != "q")
			{
				// parse input
				if (input.Length >= 2)
				{
					string op = input.Substring(0, 1);
					int arg = int.Parse(input.Substring(1));

					// handle undo command
					if (op == "~")
					{
						for (int i = 0; i < arg; i++)
						{
							calculator.Undo();
						}
					}
					else
					{
						// create new command
						AbstractOperation operation = new Operation(mathlib, op, arg);

						// pass it on to the calculator
						calculator.Invoke(operation);
					}
				}
				Console.WriteLine("Result: {0}", mathlib.Value);
			}
		}
	}

}